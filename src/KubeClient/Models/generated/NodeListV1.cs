using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     NodeList is the whole list of all Nodes which have been registered with master.
    /// </summary>
    [KubeListItem("Node", "v1")]
    [KubeObject("NodeList", "v1")]
    public partial class NodeListV1 : KubeResourceListV1<NodeV1>
    {
        /// <summary>
        ///     List of nodes
        /// </summary>
        [JsonProperty("items")]
        public override IList<NodeV1> Items { get; set; }
    }
}
