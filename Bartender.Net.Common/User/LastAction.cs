﻿using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Newtonsoft.Json;

namespace Bartender.Net.Common.User;

public class LastAction {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    public LastActionStatus LastActionStatus {
        get => Status.ToLastActionStatus ();
        set => Status = value.ToLastActionStatusString ();
    }

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }
}
