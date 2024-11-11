namespace StructsEnums;

class Run
{
    public static void Main(string[] args)
    {
        var v1 = new Vector3D(2, 4, 6);
        var v2 = new Vector3D(2, 4, 6);
        
        Console.WriteLine(v1 * 2);
        Console.WriteLine(v1 + v2);
        Console.WriteLine(v1 - v2);

        var dec = new DecimalNumber(16);
        
        Console.WriteLine(dec.ToBinary());
        Console.WriteLine(dec.ToOctal());
        Console.WriteLine(dec.ToHexadecimal());
        
        
    }
}