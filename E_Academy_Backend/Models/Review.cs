using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Review
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }

    public string? Rating { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
