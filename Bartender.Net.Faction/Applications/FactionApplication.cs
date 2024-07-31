﻿using Bartender.Net.Framework.Faction.Applications;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplication : IFactionApplication {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("expires")]
    public int Expires { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("message")]
    public string Message { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("stats")]
    public IFactionApplicationStats Stats { get; set; }

    [JsonProperty ("status")]
    public string Status { get; set; }

    [JsonProperty ("userID")]
    public int UserID { get; set; }
}
