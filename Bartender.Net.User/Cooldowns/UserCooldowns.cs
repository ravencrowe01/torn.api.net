using Bartender.Net.Framework.User.Cooldowns;
using Newtonsoft.Json;

namespace Bartender.Net.User.UserCooldowns;

public class UserCooldowns : IUserCooldowns {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("drug")]
    public int Drug { get; set; }

    [JsonProperty ("medical")]
    public int Medical { get; set; }

    [JsonProperty ("booster")]
    public int Booster { get; set; }
}
