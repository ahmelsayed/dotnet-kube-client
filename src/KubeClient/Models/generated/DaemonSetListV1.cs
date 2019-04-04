using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     DaemonSetList is a collection of daemon sets.
    /// </summary>
    [KubeListItem("DaemonSet", "apps/v1")]
    [KubeObject("DaemonSetList", "apps/v1")]
    public partial class DaemonSetListV1 : KubeResourceListV1<DaemonSetV1>
    {
        /// <summary>
        ///     A list of daemon sets.
        /// </summary>
        [JsonProperty("items")]
        public override IList<DaemonSetV1> Items { get; set; }
    }
}
