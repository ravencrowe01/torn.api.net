﻿using Bartender.Net.Framework.Selection;

namespace Bartender.Net.Framework.REST;

public interface IRequestConfiguration {
    string? Comment { get; set; }
    DateTime? From { get; set; }
    int ID { get; set; }
    string Key { get; set; }
    int? Limit { get; set; }
    string Section { get; set; }
    List<string> Selections { get; set; }
    string? Sort { get; set; }
    DateTime? To { get; set; }
    AccessLevel AccessLevel { get; set; }

    string ToString ();
}