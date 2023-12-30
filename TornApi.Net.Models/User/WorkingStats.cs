﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class WorkingStats {
    public int ProfileID { get; set; }

    public int OwnerID { get; set; }

    [JsonProperty ("manual_labor")]
    public int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public int Endurance { get; set; }
}
