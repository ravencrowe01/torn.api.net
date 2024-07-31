﻿using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class UserProperty : IUserProperty {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty ("property_type")]
    public int PropertyType { get; set; }

    [JsonProperty ("happy")]
    public int Happy { get; set; }

    [JsonProperty ("upkeep")]
    public int Upkeep { get; set; }

    [JsonProperty ("upgrades")]
    public List<string> Upgrades { get; set; }

    [JsonProperty ("staff")]
    public List<string> Staff { get; set; }

    [JsonProperty ("rented")]
    public object Rented { get; set; }

    [JsonProperty ("users_living")]
    public string UsersLiving { get; set; }
}
