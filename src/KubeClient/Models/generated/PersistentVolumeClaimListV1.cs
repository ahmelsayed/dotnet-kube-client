using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PersistentVolumeClaimList is a list of PersistentVolumeClaim items.
    /// </summary>
    [KubeListItem("PersistentVolumeClaim", "v1")]
    [KubeObject("PersistentVolumeClaimList", "v1")]
    public partial class PersistentVolumeClaimListV1 : KubeResourceListV1<PersistentVolumeClaimV1>
    {
        /// <summary>
        ///     A list of persistent volume claims. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty("items")]
        public override IList<PersistentVolumeClaimV1> Items { get; set; }
    }
}
