using System;
using System.Collections.Generic;

namespace DatabaseApproachProductDB.Models;

public partial class BillTbl
{
    public int BillId { get; set; }

    public int OrderId { get; set; }

    public virtual OrderTbl Order { get; set; } = null!;
}
