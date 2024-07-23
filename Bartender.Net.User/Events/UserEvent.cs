using Bartender.Net.Framework.User.Events;
using Newtonsoft.Json;

namespace Bartender.Net.User.Events;

public class UserEvent : IUserEvent {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("event")]
    public required string Event { get; set; }
}
