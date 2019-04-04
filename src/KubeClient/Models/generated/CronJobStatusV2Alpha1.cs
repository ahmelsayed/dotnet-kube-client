using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     CronJobStatus represents the current state of a cron job.
    /// </summary>
    public partial class CronJobStatusV2Alpha1
    {
        /// <summary>
        ///     A list of pointers to currently running jobs.
        /// </summary>
        [YamlMember(Alias = "active")]
        [JsonProperty("active")]
        public IList<ObjectReferenceV1> Active { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Active"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeActive() => Active.Count > 0;

        /// <summary>
        ///     Information when was the last time the job was successfully scheduled.
        /// </summary>
        [YamlMember(Alias = "lastScheduleTime")]
        [JsonProperty("lastScheduleTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastScheduleTime { get; set; }
    }
}
