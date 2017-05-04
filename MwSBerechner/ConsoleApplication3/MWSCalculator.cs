using System;

/// <summary>
/// Zusammenfassungsbeschreibung für Class1
/// </summary>
/// 

public class MWSCalculator
{
    double bruttoPreis;
    double MWS;

    public MWSCalculator(double bruttoPreis)
    {
        this.bruttoPreis = bruttoPreis;
        this.calculateMWS();
    }

        private void calculateMWS()
    {
        this.MWS = (this.bruttoPreis * 19) / 100; 
    }

    public double getMWS()
    {
        return this.MWS;
    }
}
