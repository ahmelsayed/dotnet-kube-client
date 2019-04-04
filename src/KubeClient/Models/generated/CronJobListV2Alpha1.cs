using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     CronJobList is a collection of cron jobs.
    /// </summary>
    [KubeListItem("CronJob", "batch/v2alpha1")]
    [KubeObject("CronJobList", "batch/v2alpha1")]
    public partial class CronJobListV2Alpha1 : KubeResourceListV1<CronJobV2Alpha1>
    {
        /// <summary>
        ///     items is the list of CronJobs.
        /// </summary>
        [JsonProperty("items")]
        public override IList<CronJobV2Alpha1> Items { get; set; }
    }
}
