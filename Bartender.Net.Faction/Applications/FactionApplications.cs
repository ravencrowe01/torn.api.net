﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplications {
    [JsonProperty ("applications")]
    public required Dictionary<string, FactionApplication> Applications { get; set; }
}