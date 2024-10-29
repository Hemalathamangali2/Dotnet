using System;
using System.Collections.Generic;

namespace DatabaseApproachCarDb.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string CarModel { get; set; } = null!;

    public DateOnly CarYear { get; set; }

    public int? EngineId { get; set; }

    public virtual Engine? Engine { get; set; }
}
