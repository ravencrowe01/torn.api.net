﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Networth;

public class NetworthRoot : BartenderEntity {
    [JsonProperty ("Networth")]
    public virtual required NetworthRecord NetworthRecord { get; set; }
}