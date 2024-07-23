﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class FactionStub {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("days_in_faction")]
    public required int DaysInFaction { get; set; }

    [JsonProperty ("faction_id")]
    public required int FactionID { get; set; }

    [JsonProperty ("faction_name")]
    public required string FactionName { get; set; }

    [JsonProperty ("faction_tag")]
    public required string FactionTag { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }
}
