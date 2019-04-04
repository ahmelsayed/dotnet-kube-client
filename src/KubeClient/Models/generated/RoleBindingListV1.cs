using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     RoleBindingList is a collection of RoleBindings
    /// </summary>
    [KubeListItem("RoleBinding", "rbac.authorization.k8s.io/v1")]
    [KubeObject("RoleBindingList", "rbac.authorization.k8s.io/v1")]
    public partial class RoleBindingListV1 : KubeResourceListV1<RoleBindingV1>
    {
        /// <summary>
        ///     Items is a list of RoleBindings
        /// </summary>
        [JsonProperty("items")]
        public override IList<RoleBindingV1> Items { get; set; }
    }
}
