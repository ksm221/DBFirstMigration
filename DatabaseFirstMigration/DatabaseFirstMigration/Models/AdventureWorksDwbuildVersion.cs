using System;
using System.Collections.Generic;

namespace DatabaseFirstMigration.Models;

public partial class AdventureWorksDwbuildVersion
{
    public string? Dbversion { get; set; }

    public DateTime? VersionDate { get; set; }
}
