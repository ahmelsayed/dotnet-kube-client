using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole
    /// </summary>
    public partial class AggregationRuleV1
    {
        /// <summary>
        ///     ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added
        /// </summary>
        [YamlMember(Alias = "clusterRoleSelectors")]
        [JsonProperty("clusterRoleSelectors")]
        public IList<LabelSelectorV1> ClusterRoleSelectors { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="ClusterRoleSelectors"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeClusterRoleSelectors() => ClusterRoleSelectors.Count > 0;
    }
}
