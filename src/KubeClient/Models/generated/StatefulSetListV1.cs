using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     StatefulSetList is a collection of StatefulSets.
    /// </summary>
    [KubeListItem("StatefulSet", "apps/v1")]
    [KubeObject("StatefulSetList", "apps/v1")]
    public partial class StatefulSetListV1 : KubeResourceListV1<StatefulSetV1>
    {
        /// <summary>
        ///     Description not provided.
        /// </summary>
        [JsonProperty("items")]
        public override IList<StatefulSetV1> Items { get; set; }
    }
}
