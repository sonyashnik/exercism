using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    public Coord A { get; }
	public Coord B { get; }
	public Coord C { get; }
	public Coord D { get; }    
}


public class ClaimsHandler
{
    private List<Plot> _plots = new List<Plot>();

    public void StakeClaim(Plot plot) => _plots.Add(plot);

    public bool IsClaimStaked(Plot plot) => _plots.Contains(plot);
    public bool IsLastClaim(Plot plot) => plot.Equals(_plots.Last());

	private static double dist(Coord f, Coord g) => Math.Sqrt(Math.Pow(g.X - f.X, 2) + Math.Pow(g.Y - f.Y, 2));
	public static double longSide(Plot p) => Math.Max(Math.Max(dist(p.A, p.B), dist(p.B, p.C)),
	   Math.Max(dist(p.C, p.D), dist(p.D, p.A)));
	public Plot GetClaimWithLongestSide()
    {
		double maxLength = -1f;
		Plot longestPlot = new Plot();
        foreach (Plot plot in _plots)
        {
            if (longSide(plot) >= maxLength)
            {
                longestPlot = plot;
                maxLength = longSide(plot);
            }
        }
        return longestPlot;
    }
}
