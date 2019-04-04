using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Adds and removes POSIX capabilities from running containers.
    /// </summary>
    public partial class CapabilitiesV1
    {
        /// <summary>
        ///     Added capabilities
        /// </summary>
        [YamlMember(Alias = "add")]
        [JsonProperty("add")]
        public IList<string> Add { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Add"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeAdd() => Add.Count > 0;

        /// <summary>
        ///     Removed capabilities
        /// </summary>
        [YamlMember(Alias = "drop")]
        [JsonProperty("drop")]
        public IList<string> Drop { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Drop"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeDrop() => Drop.Count > 0;
    }
}
