using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PodTemplateList is a list of PodTemplates.
    /// </summary>
    [KubeListItem("PodTemplate", "v1")]
    [KubeObject("PodTemplateList", "v1")]
    public partial class PodTemplateListV1 : KubeResourceListV1<PodTemplateV1>
    {
        /// <summary>
        ///     List of pod templates
        /// </summary>
        [JsonProperty("items")]
        public override IList<PodTemplateV1> Items { get; set; }
    }
}
