using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PriorityClassList is a collection of priority classes.
    /// </summary>
    [KubeListItem("PriorityClass", "scheduling.k8s.io/v1alpha1")]
    [KubeObject("PriorityClassList", "scheduling.k8s.io/v1alpha1")]
    public partial class PriorityClassListV1Alpha1 : KubeResourceListV1<PriorityClassV1Alpha1>
    {
        /// <summary>
        ///     items is the list of PriorityClasses
        /// </summary>
        [JsonProperty("items")]
        public override IList<PriorityClassV1Alpha1> Items { get; set; }
    }
}
