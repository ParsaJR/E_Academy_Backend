using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class QuizAnswer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public string AnswerText { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public virtual QuizQuestion Question { get; set; } = null!;
}
