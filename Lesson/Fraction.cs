namespace Lesson;

public struct Fraction
{
    private int _numerator;
    private int _denominator;
    
    public int Numerator => _numerator;
    public int Denominator => _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        if (a.Denominator == b.Denominator)
        {
            return new Fraction(a.Numerator + b.Numerator, a.Denominator);
        }
        
        return new Fraction(
            a.Numerator * b.Denominator + a.Denominator * b.Numerator,
            a.Denominator * b.Denominator
        );
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        if (a.Denominator == b.Denominator)
        {
            return new Fraction(a.Numerator - b.Numerator, a.Denominator);
        }
        
        return new Fraction(
            a.Numerator * b.Denominator - a.Denominator * b.Numerator,
            a.Denominator * b.Denominator
        );
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}