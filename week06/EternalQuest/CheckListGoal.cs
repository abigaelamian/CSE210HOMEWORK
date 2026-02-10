public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public ChecklistGoal(string[] data) : base(data[1], data[2], int.Parse(data[3]))
    {
        _target = int.Parse(data[4]);
        _bonus = int.Parse(data[5]);
        _count = int.Parse(data[6]);
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
            return _points + _bonus;
        return _points;
    }

    public override string GetDetailsString()
    {
        string box = _count >= _target ? "[X] " : "[ ] ";
        return box + _name + " (" + _description + ") -- Completed " + _count + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal|" + _name + "|" + _description + "|" + _points + "|" + _target + "|" + _bonus + "|" + _count;
    }
}