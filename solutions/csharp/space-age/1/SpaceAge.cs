public class SpaceAge
{
    private readonly int _seconds;
    private readonly double _secondsPerYear = 31557600.0;
    
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
    }

    public double OnEarth()
    {
        return _seconds / _secondsPerYear;
    }

    public double OnMercury()
    {
        return (_seconds/_secondsPerYear)/0.2408467;
    }

    public double OnVenus()
    {
        return (_seconds/_secondsPerYear)/0.61519726;
    }

    public double OnMars()
    {
        return (_seconds/_secondsPerYear)/1.8808158;
    }

    public double OnJupiter()
    {
        return (_seconds/_secondsPerYear)/11.862615;
    }

    public double OnSaturn()
    {
        return (_seconds/_secondsPerYear)/29.447498;
    }

    public double OnUranus()
    {
        return (_seconds/_secondsPerYear)/84.016846;
    }

    public double OnNeptune()
    {
        return (_seconds/_secondsPerYear)/164.79132;
    }
}