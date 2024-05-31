using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class StudentLesson
{
    public int StudentId { get; set; }

    public int LessonId { get; set; }

    public DateOnly? CompletedDate { get; set; }

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
