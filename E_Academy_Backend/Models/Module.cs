using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Module
{
    public int Id { get; set; }

    public int CourseId { get; set; }

    public string ModuleName { get; set; } = null!;

    public int ModuleNumber { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
