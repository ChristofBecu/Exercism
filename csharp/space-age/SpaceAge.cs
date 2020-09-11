using System;

public class SpaceAge
{
    double earthYears;

    public struct Planets {
        public const double Earth = 365.25;
        public const double Mercury = 0.2408467;
        public const double Venus = 0.61519726;
        public const double Mars = 1.8808158;
        public const double Jupiter = 11.862615;
        public const double Saturn = 29.447498;
        public const double Uranus = 84.016846;
        public const double Neptune = 164.79132;
    }

    public SpaceAge(int seconds) => earthYears = TimeSpan.FromSeconds(seconds).TotalDays / Planets.Earth;

    private double CalculateSpaceAge(double planetEarthYears = 1) => Math.Round(earthYears / planetEarthYears, 2);

    public double OnEarth() => CalculateSpaceAge();

    public double OnMercury() => CalculateSpaceAge(Planets.Mercury);

    public double OnVenus() => CalculateSpaceAge(Planets.Venus);

    public double OnMars() => CalculateSpaceAge(Planets.Mars);

    public double OnJupiter() => CalculateSpaceAge(Planets.Jupiter);

    public double OnSaturn() => CalculateSpaceAge(Planets.Saturn);

    public double OnUranus() => CalculateSpaceAge(Planets.Uranus);

    public double OnNeptune() => CalculateSpaceAge(Planets.Neptune);
}