using System;
using System.Collections.Generic;

namespace Bank.DataModel;

public partial class History
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Amount { get; set; }

    public string Date { get; set; } = null!;

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }
}
