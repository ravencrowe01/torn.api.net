﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionTemporary {
    [JsonProperty ("temporary")]
    public required List<FactionLoanable> Loanables { get; set; }
}