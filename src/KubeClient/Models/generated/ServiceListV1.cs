using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     ServiceList holds a list of services.
    /// </summary>
    [KubeListItem("Service", "v1")]
    [KubeObject("ServiceList", "v1")]
    public partial class ServiceListV1 : KubeResourceListV1<ServiceV1>
    {
        /// <summary>
        ///     List of services
        /// </summary>
        [JsonProperty("items")]
        public override IList<ServiceV1> Items { get; set; }
    }
}
