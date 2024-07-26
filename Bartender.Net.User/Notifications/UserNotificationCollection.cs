﻿using Bartender.Net.Framework.User.Notifications;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationCollection : IUserNotificationCollection {
    [JsonProperty("notifications")]
    public required IUserNotifications Notifications { get; set; }
}