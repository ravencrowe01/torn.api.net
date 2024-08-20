﻿using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Territory;

public class Racket {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("changed")]
    public required int Changed { get; set; }

    [JsonProperty ("created")]
    public required int Created { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("reward")]
    public required string Reward { get; set; }
}
