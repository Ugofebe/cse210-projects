public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public int _streakCount; // Tracks consecutive completions

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus() => _bonus;

    // Exceeding requirement: If the user completes a ChecklistGoal multiple times in a row (without skipping), they get an extra bonus multiplier (e.g., 2x) on subsequent completions.
    public void IncrementStreak() => _streakCount++;
    public void ResetStreak() => _streakCount = 0;
    public int GetCurrentStreak() => _streakCount;
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}