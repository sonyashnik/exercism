using System;

public class SpaceAge
{
    const int EarthYearInSeconds = 31_557_600;

    const double MercuryFactor = 0.2408467;
    const double VenusFactor = 0.61519726;
    const double MarsFactor = 1.8808158;
    const double JupiterFactor = 11.862615;
    const double SaturnFactor = 29.447498;
    const double UranusFactor = 84.016846;
    const double NeptuneFactor = 164.79132;

    public int AgeInSeconds { get; set; }
    public SpaceAge(int seconds)
    {
        AgeInSeconds = seconds;
    }

    public double OnEarth() => Math.Round((double)AgeInSeconds / EarthYearInSeconds,2);
    public double OnMercury() => Math.Round((double)AgeInSeconds / EarthYearInSeconds / MercuryFactor, 2);
    public double OnVenus() => Math.Round((double)AgeInSeconds / EarthYearInSeconds / VenusFactor, 2);
    public double OnMars() => Math.Round((double)AgeInSeconds / EarthYearInSeconds / MarsFactor, 2);
    public double OnJupiter()=> Math.Round((double)AgeInSeconds / EarthYearInSeconds / JupiterFactor, 2);
    public double OnSaturn() => Math.Round((double)AgeInSeconds / EarthYearInSeconds / SaturnFactor, 2);
    public double OnUranus() => Math.Round((double)AgeInSeconds / EarthYearInSeconds / UranusFactor, 2);
    public double OnNeptune() => Math.Round( (double)AgeInSeconds / EarthYearInSeconds / NeptuneFactor, 2);
}