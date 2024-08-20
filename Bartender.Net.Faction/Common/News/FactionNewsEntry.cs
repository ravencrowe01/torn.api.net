﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.Common.News;

public class FactionNewsEntry {
    [JsonIgnore]
    public  int ID { get; set; }

    [JsonProperty ("news")]
    public required string News { get; set; }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }
}