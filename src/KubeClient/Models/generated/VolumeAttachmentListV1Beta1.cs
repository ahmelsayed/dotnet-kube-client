using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     VolumeAttachmentList is a collection of VolumeAttachment objects.
    /// </summary>
    [KubeListItem("VolumeAttachment", "storage.k8s.io/v1beta1")]
    [KubeObject("VolumeAttachmentList", "storage.k8s.io/v1beta1")]
    public partial class VolumeAttachmentListV1Beta1 : KubeResourceListV1<VolumeAttachmentV1Beta1>
    {
        /// <summary>
        ///     Items is the list of VolumeAttachments
        /// </summary>
        [JsonProperty("items")]
        public override IList<VolumeAttachmentV1Beta1> Items { get; set; }
    }
}
