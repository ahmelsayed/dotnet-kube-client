using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     LoadBalancerStatus represents the status of a load-balancer.
    /// </summary>
    public partial class LoadBalancerStatusV1
    {
        /// <summary>
        ///     Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.
        /// </summary>
        [YamlMember(Alias = "ingress")]
        [JsonProperty("ingress")]
        public IList<LoadBalancerIngressV1> Ingress { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Ingress"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeIngress() => Ingress.Count > 0;
    }
}
