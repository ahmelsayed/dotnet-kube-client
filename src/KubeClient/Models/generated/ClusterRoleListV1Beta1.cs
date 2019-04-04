using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClusterRoleList is a collection of ClusterRoles
    /// </summary>
    [KubeListItem("ClusterRole", "rbac.authorization.k8s.io/v1beta1")]
    [KubeObject("ClusterRoleList", "rbac.authorization.k8s.io/v1beta1")]
    public partial class ClusterRoleListV1Beta1 : KubeResourceListV1<ClusterRoleV1Beta1>
    {
        /// <summary>
        ///     Items is a list of ClusterRoles
        /// </summary>
        [JsonProperty("items")]
        public override IList<ClusterRoleV1Beta1> Items { get; set; }
    }
}
