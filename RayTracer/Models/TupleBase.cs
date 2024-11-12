using System;

namespace RayTracer.Models;

public class TupleBase
{
    protected (float, float, float, float) Values;
    
    protected TupleBase(float x, float y, float z, float w)
    {
        Values = (x, y, z, w);
    }
        
    protected void SetItem1(float value) => Values = (value, Values.Item2, Values.Item3, Values.Item4);

    protected void SetItem2(float value) => Values = (Values.Item1, value, Values.Item3, Values.Item4);

    protected void SetItem3(float value) => Values = (Values.Item1, Values.Item2, value, Values.Item4);

    protected void SetItem4(float value) => Values = (Values.Item1, Values.Item2, Values.Item3, value);

    // Multiply the tuple values by a scalar
    public void Multiply(float scalarValue)
    {
        Values = (Values.Item1 * scalarValue, Values.Item2 * scalarValue, Values.Item3 * scalarValue, Values.Item4 * scalarValue);
    }

    // Divide the tuple values by a scalar
    public void Divide(float scalarValue)
    {
        Values = (Values.Item1 == 0 ? 0 : Values.Item1 / scalarValue,
            Values.Item2 == 0 ? 0 : Values.Item2 / scalarValue,
            Values.Item3 == 0 ? 0 : Values.Item3 / scalarValue,
            Values.Item4 == 0 ? 0 : Values.Item4 / scalarValue);
    }

    // Check if the tuple represents a point (w == 1)
    public bool IsAPoint => Values.Item4.EqualsTo(1);

    // Check if the tuple represents a vector (w == 0)
    public bool IsAVector => Values.Item4.EqualsTo(0);

    // Operators
    public static TupleBase operator +(TupleBase a, TupleBase b)
        => new TupleBase(a.Values.Item1 + b.Values.Item1, a.Values.Item2 + b.Values.Item2, a.Values.Item3 + b.Values.Item3, a.Values.Item4 + b.Values.Item4);

    public static TupleBase operator -(TupleBase a, TupleBase b)
        => new TupleBase(a.Values.Item1 - b.Values.Item1, a.Values.Item2 - b.Values.Item2, a.Values.Item3 - b.Values.Item3, Math.Abs(a.Values.Item4 - b.Values.Item4));

    public static TupleBase operator -(TupleBase a)
        => new TupleBase(-a.Values.Item1, -a.Values.Item2, -a.Values.Item3, -a.Values.Item4);

    // Override Equals and GetHashCode for comparison
    public override bool Equals(object obj)
    {
        if (obj is TupleBase tuple)
        {
            return Values.Item1.EqualsTo(tuple.Values.Item1) &&
                   Values.Item2.EqualsTo(tuple.Values.Item2) &&
                   Values.Item3.EqualsTo(tuple.Values.Item3) &&
                   Values.Item4.EqualsTo(tuple.Values.Item4);
        }
        return false;
    }

    public override int GetHashCode() => Values.GetHashCode();
}