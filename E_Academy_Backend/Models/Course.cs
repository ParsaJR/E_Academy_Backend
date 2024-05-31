using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Course
{
    public int Id { get; set; }

    public string CourseDescription { get; set; } = null!;

    public string CoursePrice { get; set; } = null!;

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
