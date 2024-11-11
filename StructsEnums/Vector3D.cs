namespace StructsEnums;

public struct Vector3D
{
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public Vector3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3D operator *(Vector3D v, int scale)
    {
        return new Vector3D(v.X * scale, v.Y * scale, v.Z * scale);
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}