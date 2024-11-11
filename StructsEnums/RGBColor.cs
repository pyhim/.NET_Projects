namespace StructsEnums;

public struct RGBColor
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public RGBColor(ushort r, ushort g, ushort b)
    {
        R = r;
        G = g;
        B = b;
    }

    public string ToHEX()
    {
        return Convert.ToHexString([R, G, B]);
    }

    public string ToHSL()
    {
        double r = R / 255.0, g = G / 255.0, b = B / 255.0;
        
        double max = Math.Max(r, Math.Max(g, b));
        double min = Math.Min(r, Math.Min(g, b));
        
        double L = (max + min) / 2.0;

        double S = 0, H = 0;
        if (max != min)
        {
            if (L < 0.5) 
                S = (max - min) / (max + min);
            else 
                S = (max - min) / (2.0 - max - min);

            if (max = r)
                H = (g - b) / (max - min);
            else if (max == g)
                H = 2.0 + (b - r) / (max - min);
            else if (max == b)
                H = 4.0 + (r - g) / (max - min);

            H *= 60;
            if (H < 0) H += 360;
        }

        return $"{H}{S}{L}";
    }

    public string ToCMYK()
    {
        double r = R / 255.0, g = G / 255.0, b = B / 255.0;
        double max = Math.Max(r, Math.Max(g, b));

        double C = 0, M = 0, Y = 0;
        double K = 1 - max;

        if (K == 1) return $"{C}{M}{Y}{K}";
        
        C = (1 - r - K) / (1 - K);
        M = (1 - g - K) / (1 - K);
        Y = (1 - b - K) / (1 - K);
        
        return $"{C}{M}{Y}{K}";
    }
}