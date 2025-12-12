public class SpaceAge
{
    private readonly int _seconds;
    private readonly double _secondsPerYear = 31557600.0;
    
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth() => _seconds / _secondsPerYear;

    public double OnMercury() =>(_seconds/_secondsPerYear)/0.2408467;

    public double OnVenus() => (_seconds/_secondsPerYear)/0.61519726;

    public double OnMars() => (_seconds/_secondsPerYear)/1.8808158;

    public double OnJupiter() => (_seconds/_secondsPerYear)/11.862615;

    public double OnSaturn() => (_seconds/_secondsPerYear)/29.447498;

    public double OnUranus() => (_seconds/_secondsPerYear)/84.016846;

    public double OnNeptune() => (_seconds/_secondsPerYear)/164.79132;
}