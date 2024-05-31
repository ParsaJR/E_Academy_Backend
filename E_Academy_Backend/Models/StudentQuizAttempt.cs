using System;
using System.Collections.Generic;

namespace E_Academy_Backend.Models;

public partial class StudentQuizAttempt
{
    public int StudentId { get; set; }

    public int QuizId { get; set; }

    public string? AttemptDate { get; set; }

    public string? Score { get; set; }

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
