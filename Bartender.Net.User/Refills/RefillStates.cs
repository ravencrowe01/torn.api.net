﻿using Bartender.Net.Framework.User.Refills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillStates : IRefillStates {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("energy_refill_used")]
    public required bool EnergyRefillUsed { get; set; }

    [JsonProperty ("nerve_refill_used")]
    public required bool NerveRefillUsed { get; set; }

    [JsonProperty ("token_refill_used")]
    public required bool TokenRefillUsed { get; set; }

    [JsonProperty ("special_refills_available")]
    public required int SpecialRefillsAvailable { get; set; }
}