﻿using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class RelativeLastAction : BartenderEntity {
    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonProperty ("relative")]
    public required string Relative { get; set; }

    public LastActionStatus LastActionStatus {
        get => Status.ToLastActionStatus ();
        set => Status = value.ToLastActionStatusString ();
    }

    [JsonProperty ("timestamp")]
    public required long Timestamp { get; set; }
}