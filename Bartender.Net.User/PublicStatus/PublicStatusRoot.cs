﻿using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.PublicStatus;

public class PublicStatusRoot {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("baned")]
    public required bool Banned { get; set; }

    [JsonProperty ("playername")]
    public required string PlayerName { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonIgnore]
    public TornRole TornRole {
        get => Status.ToTornRole ();
        set => Status = value.ToTornRoleString ();
    }

    [JsonProperty ("userID")]
    public required int UserID { get; set; }
}
