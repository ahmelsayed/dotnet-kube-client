using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClusterRoleBindingList is a collection of ClusterRoleBindings
    /// </summary>
    [KubeListItem("ClusterRoleBinding", "rbac.authorization.k8s.io/v1beta1")]
    [KubeObject("ClusterRoleBindingList", "rbac.authorization.k8s.io/v1beta1")]
    public partial class ClusterRoleBindingListV1Beta1 : KubeResourceListV1<ClusterRoleBindingV1Beta1>
    {
        /// <summary>
        ///     Items is a list of ClusterRoleBindings
        /// </summary>
        [JsonProperty("items")]
        public override IList<ClusterRoleBindingV1Beta1> Items { get; set; }
    }
}
