using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     EventList is a list of events.
    /// </summary>
    [KubeListItem("Event", "v1")]
    [KubeObject("EventList", "v1")]
    public partial class EventListV1 : KubeResourceListV1<EventV1>
    {
        /// <summary>
        ///     List of events
        /// </summary>
        [JsonProperty("items")]
        public override IList<EventV1> Items { get; set; }
    }
}
