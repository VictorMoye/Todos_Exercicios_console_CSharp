using System;

public class Triangulo
{
    public Double A;
    public Double B;
    public Double C;
    public Double Area()
    {
        Double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
