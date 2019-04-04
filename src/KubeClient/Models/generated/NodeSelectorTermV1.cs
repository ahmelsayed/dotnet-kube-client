using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
    /// </summary>
    public partial class NodeSelectorTermV1
    {
        /// <summary>
        ///     A list of node selector requirements by node's labels.
        /// </summary>
        [YamlMember(Alias = "matchExpressions")]
        [JsonProperty("matchExpressions")]
        public IList<NodeSelectorRequirementV1> MatchExpressions { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="MatchExpressions"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeMatchExpressions() => MatchExpressions.Count > 0;

        /// <summary>
        ///     A list of node selector requirements by node's fields.
        /// </summary>
        [YamlMember(Alias = "matchFields")]
        [JsonProperty("matchFields")]
        public IList<NodeSelectorRequirementV1> MatchFields { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="MatchFields"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeMatchFields() => MatchFields.Count > 0;
    }
}
