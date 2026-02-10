public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public EternalGoal(string[] data) : base(data[1], data[2], int.Parse(data[3])) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        return "[ ] " + _name + " (" + _description + ")";
    }

    public override string GetStringRepresentation()
    {
        return "EternalGoal|" + _name + "|" + _description + "|" + _points;
    }
}