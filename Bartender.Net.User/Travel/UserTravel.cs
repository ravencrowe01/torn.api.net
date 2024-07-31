﻿using Bartender.Net.Framework.User.Travel;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class UserTravel : IUserTravel {
    [JsonProperty ("travel")]
    public ITravelEntry Travel { get; set; }
}
