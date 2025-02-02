
namespace RayTracer.Models;

public struct Matrix
{
    public float M00;
    public float M01;
    public float M02;
    public float M03;
    public float M10;
    public float M11;
    public float M12;
    public float M13;
    public float M20;
    public float M21;
    public float M22;
    public float M23;
    public float M30;
    public float M31;
    public float M32;
    public float M33;
    
    public Matrix(
        float m00, float m01, float m02, float m03,
        float m10, float m11, float m12, float m13,
        float m20, float m21, float m22, float m23,
        float m30, float m31, float m32, float m33)
    {
        M00 = m00; M01 = m01; M02 = m02; M03 = m03;
        M10 = m10; M11 = m11; M12 = m12; M13 = m13;
        M20 = m20; M21 = m21; M22 = m22; M23 = m23;
        M30 = m30; M31 = m31; M32 = m32; M33 = m33;
    }

    public Matrix GetTranspose()
    {
        return new Matrix
        {
            M00 = M00, M01 = M10, M02 = M20, M03 = M30,
            M10 = M01, M11 = M11, M12 = M21, M13 = M31,
            M20 = M02, M21 = M12, M22 = M22, M23 = M32,
            M30 = M03, M31 = M13, M32 = M23, M33 = M33
        };
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        return a.M00.EqualsTo(b.M00) && a.M01.EqualsTo(b.M01) && a.M02.EqualsTo(b.M02) && a.M03.EqualsTo(b.M03) &&
               a.M10.EqualsTo(b.M10) && a.M11.EqualsTo(b.M11) && a.M12.EqualsTo(b.M12) && a.M13.EqualsTo(b.M13) &&
               a.M20.EqualsTo(b.M20) && a.M21.EqualsTo(b.M21) && a.M22.EqualsTo(b.M22) && a.M23.EqualsTo(b.M23) &&
               a.M30.EqualsTo(b.M30) && a.M31.EqualsTo(b.M31) && a.M32.EqualsTo(b.M32) && a.M33.EqualsTo(b.M33);
    }
    
    public static bool operator !=(Matrix a, Matrix b)
    {
        return !a.M00.EqualsTo(b.M00) || !a.M01.EqualsTo(b.M01) || !a.M02.EqualsTo(b.M02) || !a.M03.EqualsTo(b.M03) ||
               !a.M10.EqualsTo(b.M10) || !a.M11.EqualsTo(b.M11) || !a.M12.EqualsTo(b.M12) || !a.M13.EqualsTo(b.M13) ||
               !a.M20.EqualsTo(b.M20) || !a.M21.EqualsTo(b.M21) || !a.M22.EqualsTo(b.M22) || !a.M23.EqualsTo(b.M23) ||
               !a.M30.EqualsTo(b.M30) || !a.M31.EqualsTo(b.M31) || !a.M32.EqualsTo(b.M32) || !a.M33.EqualsTo(b.M33);
    }
    
    public static Matrix operator *(Matrix a, Matrix b)
    {
        return new Matrix
        {
            M00 = a.M00 * b.M00 + a.M01 * b.M10 + a.M02 * b.M20 + a.M03 * b.M30,
            M01 = a.M00 * b.M01 + a.M01 * b.M11 + a.M02 * b.M21 + a.M03 * b.M31,
            M02 = a.M00 * b.M02 + a.M01 * b.M12 + a.M02 * b.M22 + a.M03 * b.M32,
            M03 = a.M00 * b.M03 + a.M01 * b.M13 + a.M02 * b.M23 + a.M03 * b.M33,

            M10 = a.M10 * b.M00 + a.M11 * b.M10 + a.M12 * b.M20 + a.M13 * b.M30,
            M11 = a.M10 * b.M01 + a.M11 * b.M11 + a.M12 * b.M21 + a.M13 * b.M31,
            M12 = a.M10 * b.M02 + a.M11 * b.M12 + a.M12 * b.M22 + a.M13 * b.M32,
            M13 = a.M10 * b.M03 + a.M11 * b.M13 + a.M12 * b.M23 + a.M13 * b.M33,

            M20 = a.M20 * b.M00 + a.M21 * b.M10 + a.M22 * b.M20 + a.M23 * b.M30,
            M21 = a.M20 * b.M01 + a.M21 * b.M11 + a.M22 * b.M21 + a.M23 * b.M31,
            M22 = a.M20 * b.M02 + a.M21 * b.M12 + a.M22 * b.M22 + a.M23 * b.M32,
            M23 = a.M20 * b.M03 + a.M21 * b.M13 + a.M22 * b.M23 + a.M23 * b.M33,

            M30 = a.M30 * b.M00 + a.M31 * b.M10 + a.M32 * b.M20 + a.M33 * b.M30,
            M31 = a.M30 * b.M01 + a.M31 * b.M11 + a.M32 * b.M21 + a.M33 * b.M31,
            M32 = a.M30 * b.M02 + a.M31 * b.M12 + a.M32 * b.M22 + a.M33 * b.M32,
            M33 = a.M30 * b.M03 + a.M31 * b.M13 + a.M32 * b.M23 + a.M33 * b.M33
        };
    }

    public static Matrix Identity = new Matrix(
        1, 0, 0, 0,
        0, 1, 0, 0,
        0, 0, 1, 0,
        0, 0, 0, 1);
}