using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Faq
{
    public int Id { get; set; }

    public string FaqQuestion { get; set; } = null!;

    public string FaqAnswer { get; set; } = null!;
}
