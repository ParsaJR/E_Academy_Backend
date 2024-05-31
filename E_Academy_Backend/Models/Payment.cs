using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string PaymentAmount { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public virtual Student Student { get; set; } = null!;
}
