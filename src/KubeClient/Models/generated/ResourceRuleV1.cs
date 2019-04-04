using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ResourceRule is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.
    /// </summary>
    public partial class ResourceRuleV1
    {
        /// <summary>
        ///     APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.  "*" means all.
        /// </summary>
        [YamlMember(Alias = "apiGroups")]
        [JsonProperty("apiGroups")]
        public IList<string> ApiGroups { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="ApiGroups"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeApiGroups() => ApiGroups.Count > 0;

        /// <summary>
        ///     ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.  "*" means all.
        /// </summary>
        [YamlMember(Alias = "resourceNames")]
        [JsonProperty("resourceNames")]
        public IList<string> ResourceNames { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="ResourceNames"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeResourceNames() => ResourceNames.Count > 0;

        /// <summary>
        ///     Resources is a list of resources this rule applies to.  "*" means all in the specified apiGroups.
        ///      "*/foo" represents the subresource 'foo' for all resources in the specified apiGroups.
        /// </summary>
        [YamlMember(Alias = "resources")]
        [JsonProperty("resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Resources"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeResources() => Resources.Count > 0;

        /// <summary>
        ///     Verb is a list of kubernetes resource API verbs, like: get, list, watch, create, update, delete, proxy.  "*" means all.
        /// </summary>
        [YamlMember(Alias = "verbs")]
        [JsonProperty("verbs")]
        public IList<string> Verbs { get; set; }
    }
}
