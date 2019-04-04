using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     StatefulSetList is a collection of StatefulSets.
    /// </summary>
    [KubeListItem("StatefulSet", "apps/v1beta2")]
    [KubeObject("StatefulSetList", "apps/v1beta2")]
    public partial class StatefulSetListV1Beta2 : KubeResourceListV1<StatefulSetV1Beta2>
    {
        /// <summary>
        ///     Description not provided.
        /// </summary>
        [JsonProperty("items")]
        public override IList<StatefulSetV1Beta2> Items { get; set; }
    }
}
