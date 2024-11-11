namespace StructsEnums;

public struct DecimalNumber
{
    public int Value { get; set; }
    
    public DecimalNumber(int value) => Value = value;
    
    public string ToBinary() => Convert.ToString(Value, 2);
    
    public string ToOctal() => Convert.ToString(Value, 8);
    
    public string ToHexadecimal() => Convert.ToString(Value, 16);

    public override string ToString()
    {
        return Value.ToString();
    }
}