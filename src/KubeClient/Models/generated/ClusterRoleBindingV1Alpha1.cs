using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ClusterRoleBinding references a ClusterRole, but not contain it.  It can reference a ClusterRole in the global namespace, and adds who information via Subject.
    /// </summary>
    [KubeObject("ClusterRoleBinding", "rbac.authorization.k8s.io/v1alpha1")]
    [KubeApi(KubeAction.List, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings")]
    [KubeApi(KubeAction.Create, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings")]
    [KubeApi(KubeAction.Get, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings/{name}")]
    [KubeApi(KubeAction.Patch, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings/{name}")]
    [KubeApi(KubeAction.Delete, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings/{name}")]
    [KubeApi(KubeAction.Update, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings/{name}")]
    [KubeApi(KubeAction.WatchList, "apis/rbac.authorization.k8s.io/v1alpha1/watch/clusterrolebindings")]
    [KubeApi(KubeAction.DeleteCollection, "apis/rbac.authorization.k8s.io/v1alpha1/clusterrolebindings")]
    [KubeApi(KubeAction.Watch, "apis/rbac.authorization.k8s.io/v1alpha1/watch/clusterrolebindings/{name}")]
    public partial class ClusterRoleBindingV1Alpha1 : KubeResourceV1
    {
        /// <summary>
        ///     RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.
        /// </summary>
        [YamlMember(Alias = "roleRef")]
        [JsonProperty("roleRef", NullValueHandling = NullValueHandling.Include)]
        public RoleRefV1Alpha1 RoleRef { get; set; }

        /// <summary>
        ///     Subjects holds references to the objects the role applies to.
        /// </summary>
        [YamlMember(Alias = "subjects")]
        [JsonProperty("subjects")]
        public IList<SubjectV1Alpha1> Subjects { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Subjects"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeSubjects() => Subjects.Count > 0;
    }
}
