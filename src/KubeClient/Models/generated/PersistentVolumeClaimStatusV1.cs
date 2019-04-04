using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     PersistentVolumeClaimStatus is the current status of a persistent volume claim.
    /// </summary>
    public partial class PersistentVolumeClaimStatusV1
    {
        /// <summary>
        ///     Phase represents the current phase of PersistentVolumeClaim.
        /// </summary>
        [YamlMember(Alias = "phase")]
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        ///     AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        /// </summary>
        [YamlMember(Alias = "accessModes")]
        [JsonProperty("accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="AccessModes"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeAccessModes() => AccessModes.Count > 0;

        /// <summary>
        ///     Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'ResizeStarted'.
        /// </summary>
        [MergeStrategy(Key = "type")]
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions")]
        public IList<PersistentVolumeClaimConditionV1> Conditions { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Conditions"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeConditions() => Conditions.Count > 0;

        /// <summary>
        ///     Represents the actual resources of the underlying volume.
        /// </summary>
        [YamlMember(Alias = "capacity")]
        [JsonProperty("capacity")]
        public Dictionary<string, string> Capacity { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Capacity"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeCapacity() => Capacity.Count > 0;
    }
}
