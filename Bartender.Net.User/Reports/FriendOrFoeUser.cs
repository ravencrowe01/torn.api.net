﻿using Bartender.Net.Framework.User.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class FriendOrFoeUser : IFriendOrFoeUser {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("user_id")]
    public int UserID { get; set; }
}
