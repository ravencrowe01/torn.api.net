﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.Currency;

public class FactionCurrency {
    [JsonProperty ("faction_id")]
    public required int FactionId { get; set; }

    [JsonProperty ("points")]
    public required int Points { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }
}