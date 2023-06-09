public class Swimming : Activity
{
    private double _numLaps;
    private int _minutes;

    public Swimming(string activityType, string date, int minutes, double numLaps) : base(activityType, date, minutes)
    {
        _numLaps = numLaps;
        _minutes = minutes;
    }

    public override double Distance()
    {
        double _distance = _numLaps * 50 / 1000;
        return _distance;
    }
    public override double Speed()
    {
        double _speed = Distance() / _minutes * 60;
        return Math.Round(_speed,2);
    }
    public override double Pace()
    {
        double pace = _minutes / Distance();
        return pace;
    }
}