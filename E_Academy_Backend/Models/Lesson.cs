using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Lesson
{
    public int Id { get; set; }

    public int ModuleId { get; set; }

    public string LessonTitle { get; set; } = null!;

    public string LessonNumber { get; set; } = null!;

    public string PdfUrl { get; set; } = null!;

    public string LessonDetails { get; set; } = null!;

    public string? CourseOrder { get; set; }

    public virtual Module Module { get; set; } = null!;
}
