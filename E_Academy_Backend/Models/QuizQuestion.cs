using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class QuizQuestion
{
    public int Id { get; set; }

    public int QuizId { get; set; }

    public string QuestionTitle { get; set; } = null!;

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual ICollection<QuizAnswer> QuizAnswers { get; set; } = new List<QuizAnswer>();
}
