﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplication : BartenderEntity {
    [JsonProperty ("expires")]
    public required int Expires { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("message")]
    public required string Message { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("stats")]
    public virtual required CompanyApplicationStats Stats { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonProperty ("userID")]
    public required int UserID { get; set; }
}
