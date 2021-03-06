using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClusterRoleBindingList is a collection of ClusterRoleBindings
    /// </summary>
    [KubeListItem("ClusterRoleBinding", "rbac.authorization.k8s.io/v1")]
    [KubeObject("ClusterRoleBindingList", "rbac.authorization.k8s.io/v1")]
    public partial class ClusterRoleBindingListV1 : KubeResourceListV1<ClusterRoleBindingV1>
    {
        /// <summary>
        ///     Items is a list of ClusterRoleBindings
        /// </summary>
        [JsonProperty("items")]
        public override IList<ClusterRoleBindingV1> Items { get; set; }
    }
}
