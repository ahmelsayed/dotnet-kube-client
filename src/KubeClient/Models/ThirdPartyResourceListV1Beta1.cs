using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KubeClient.Models
{
    /// <summary>
    ///     ThirdPartyResourceList is a list of ThirdPartyResources.
    /// </summary>
    [KubeObject("ThirdPartyResourceList", "extensions/v1beta1")]
    public class ThirdPartyResourceListV1Beta1 : KubeResourceListV1<ThirdPartyResourceV1Beta1>
    {
        /// <summary>
        ///     Items is the list of ThirdPartyResources.
        /// </summary>
        [JsonProperty("items")]
        public override IList<ThirdPartyResourceV1Beta1> Items { get; set; }
    }
}
