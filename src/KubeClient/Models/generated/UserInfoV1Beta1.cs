using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     UserInfo holds the information about the user needed to implement the user.Info interface.
    /// </summary>
    public partial class UserInfoV1Beta1
    {
        /// <summary>
        ///     Any additional information provided by the authenticator.
        /// </summary>
        [YamlMember(Alias = "extra")]
        [JsonProperty("extra")]
        public Dictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Extra"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeExtra() => Extra.Count > 0;

        /// <summary>
        ///     A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.
        /// </summary>
        [YamlMember(Alias = "uid")]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        ///     The name that uniquely identifies this user among all active users.
        /// </summary>
        [YamlMember(Alias = "username")]
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        ///     The names of groups this user is a part of.
        /// </summary>
        [YamlMember(Alias = "groups")]
        [JsonProperty("groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        ///     Determine whether the <see cref="Groups"/> property should be serialised.
        /// </summary>
        public bool ShouldSerializeGroups() => Groups.Count > 0;
    }
}
