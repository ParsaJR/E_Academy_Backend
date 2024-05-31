using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class Quiz
{
    public int Id { get; set; }

    public int CourseId { get; set; }

    public string QuizName { get; set; } = null!;

    public string QuizNumber { get; set; } = null!;

    public string CourseOrder { get; set; } = null!;

    public string MinPassScore { get; set; } = null!;

    public virtual ICollection<QuizQuestion> QuizQuestions { get; set; } = new List<QuizQuestion>();
}
