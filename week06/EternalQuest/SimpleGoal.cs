public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string[] data) : base(data[1], data[2], int.Parse(data[3]))
    {
        _isComplete = bool.Parse(data[4]);
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return (_isComplete ? "[X] " : "[ ] ") + _name + " (" + _description + ")";
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal|" + _name + "|" + _description + "|" + _points + "|" + _isComplete;
    }
}