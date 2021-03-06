using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     APIVersions lists the versions that are available, to allow clients to discover the API at /api, which is the root path of the legacy v1 API.
    /// </summary>
    public partial class APIVersionsV1 : KubeObjectV1
    {
        /// <summary>
        ///     a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.
        /// </summary>
        [YamlMember(Alias = "serverAddressByClientCIDRs")]
        [JsonProperty("serverAddressByClientCIDRs")]
        public IList<ServerAddressByClientCIDRV1> ServerAddressByClientCIDRs { get; set; }

        /// <summary>
        ///     versions are the api versions that are available.
        /// </summary>
        [YamlMember(Alias = "versions")]
        [JsonProperty("versions")]
        public IList<string> Versions { get; set; }
    }
}
