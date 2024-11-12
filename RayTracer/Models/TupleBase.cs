using System;

namespace RayTracer.Models;

public class TupleBase
{
    protected float Value1 { get; set; }
    protected float Value2 { get; set; }
    protected float Value3 { get; set; }
    protected float Value4 { get; set; }

    protected TupleBase(float value1, float value2, float value3, float value4)
    {
        Value1 = value1;
        Value2 = value2;
        Value3 = value3;
        Value4 = value4;
    }

    // Multiply the tuple values by a scalar
    public void Multiply(float scalarValue)
    {
        Value1 *= scalarValue;
        Value2 *= scalarValue;
        Value3 *= scalarValue;
        Value4 *= scalarValue;
    }

    // Divide the tuple values by a scalar
    public void Divide(float scalarValue)
    {
        Value1 = (Value1 == 0 ? 0 : Value1 / scalarValue);
        Value2 = (Value2 == 0 ? 0 : Value2 / scalarValue);
        Value3 = (Value3 == 0 ? 0 : Value3 / scalarValue);
        Value4 = (Value4 == 0 ? 0 : Value4 / scalarValue);
    }
    
    // Operators
    public static TupleBase operator +(TupleBase a, TupleBase b)
        => new TupleBase(a.Value1 + b.Value1, a.Value2 + b.Value2, a.Value3 + b.Value3, a.Value4 + b.Value4);

    public static TupleBase operator -(TupleBase a, TupleBase b)
        => new TupleBase(a.Value1 - b.Value1, a.Value2 - b.Value2, a.Value3 - b.Value3, a.Value4 - b.Value4);
    
    public static TupleBase operator *(TupleBase a, TupleBase b)
        => new TupleBase(a.Value1 * b.Value1, a.Value2 * b.Value2, a.Value3 * b.Value3, a.Value4 * b.Value4);

    public static TupleBase operator -(TupleBase a)
        => new TupleBase(-a.Value1, -a.Value2, -a.Value3, -a.Value4);

    // Override Equals and GetHashCode for comparison
    public override bool Equals(object obj)
    {
        if (obj is TupleBase tuple)
        {
            return Value1.EqualsTo(tuple.Value1) &&
                   Value2.EqualsTo(tuple.Value2) &&
                   Value3.EqualsTo(tuple.Value3) &&
                   Value4.EqualsTo(tuple.Value4);
        }
        return false;
    }

    public override int GetHashCode() => (Value1, Value2, Value3, Value4).GetHashCode();
}