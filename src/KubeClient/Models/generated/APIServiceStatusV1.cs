using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     APIServiceStatus contains derived information about an API server
    /// </summary>
    public partial class APIServiceStatusV1
    {
        /// <summary>
        ///     Current service state of apiService.
        /// </summary>
        [MergeStrategy(Key = "type")]
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions")]
        public IList<APIServiceConditionV1> Conditions { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Conditions"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeConditions() => Conditions.Count > 0;
    }
}
