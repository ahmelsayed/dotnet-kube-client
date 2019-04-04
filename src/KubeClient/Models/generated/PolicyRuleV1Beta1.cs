using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.
    /// </summary>
    public partial class PolicyRuleV1Beta1
    {
        /// <summary>
        ///     APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.
        /// </summary>
        [YamlMember(Alias = "apiGroups")]
        [JsonProperty("apiGroups")]
        public IList<string> ApiGroups { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="ApiGroups"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeApiGroups() => ApiGroups.Count > 0;

        /// <summary>
        ///     NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.
        /// </summary>
        [YamlMember(Alias = "nonResourceURLs")]
        [JsonProperty("nonResourceURLs")]
        public IList<string> NonResourceURLs { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="NonResourceURLs"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeNonResourceURLs() => NonResourceURLs.Count > 0;

        /// <summary>
        ///     ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.
        /// </summary>
        [YamlMember(Alias = "resourceNames")]
        [JsonProperty("resourceNames")]
        public IList<string> ResourceNames { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="ResourceNames"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeResourceNames() => ResourceNames.Count > 0;

        /// <summary>
        ///     Resources is a list of resources this rule applies to.  '*' represents all resources in the specified apiGroups. '*/foo' represents the subresource 'foo' for all resources in the specified apiGroups.
        /// </summary>
        [YamlMember(Alias = "resources")]
        [JsonProperty("resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Resources"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeResources() => Resources.Count > 0;

        /// <summary>
        ///     Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.
        /// </summary>
        [YamlMember(Alias = "verbs")]
        [JsonProperty("verbs")]
        public IList<string> Verbs { get; set; }
    }
}
