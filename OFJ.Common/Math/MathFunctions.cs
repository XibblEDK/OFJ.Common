using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFJ.Common.Math
{
    public static class MathFunctions
    {
        /// <summary>
        /// Function that returns the absolute value of <paramref name="value"/>
        /// </summary>
        /// <param name="value">Int value to get absolute value of</param>
        /// <returns>int</returns>
        public static int AbosluteValue(int value)
        {
            return System.Math.Abs(value);
        }

        /// <summary>
        /// Function that returns the BigMul value of <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to be BigMultiplied</param>
        /// <returns>long</returns>
        public static long BigMul(int value)
        {
            return System.Math.BigMul(value, value);
        }

        /// <summary>
        /// Function that returns the floored value of <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to be floored</param>
        /// <returns>double</returns>
        public static double FloorValueOf(double value)
        {
            return System.Math.Floor(value);
        }

        /// <summary>
        /// Function that returns the ceiled value of <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to be ceiled</param>
        /// <returns>double</returns>
        public static double CeilValueOf(double value)
        {
            return System.Math.Ceiling(value);
        }

        /// <summary>
        /// Function that returns the sine value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get sine value of</param>
        /// <returns>double</returns>
        public static double SineValueOf(double value)
        {
            return System.Math.Sin(value);
        }

        /// <summary>
        /// Function that returns the cosine value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get cosine value of</param>
        /// <returns>double</returns>
        public static double CosineValueOf(double value)
        {
            return System.Math.Cos(value);
        }

        /// <summary>
        /// Function that returns the tangent value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get tangent value of</param>
        /// <returns>double</returns>
        public static double TangentValueOf(double value)
        {
            return System.Math.Tan(value);
        }

        /// <summary>
        /// Function that returns the hyperbolic sine value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get hyperbolic sine value of</param>
        /// <returns>double</returns>
        public static double HyperbolicSineValueOf(double value)
        {
            return System.Math.Sinh(value);
        }

        /// <summary>
        /// Function that returns the hyperbolic cosine value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get hyperbolic cosine value of</param>
        /// <returns>double</returns>
        public static double HyperbolicCosineValueOf(double value)
        {
            return System.Math.Cosh(value);
        }

        /// <summary>
        /// Function that returns the hyperbolic tangent value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get hyperbolic tangent value of</param>
        /// <returns>double</returns>
        public static double HyperbolicTangentValueOf(double value)
        {
            return System.Math.Tanh(value);
        }

        /// <summary>
        /// Function that returns the Asin value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get Asin value of</param>
        /// <returns>double</returns>
        public static double AsinValueOf(double value)
        {
            return System.Math.Asin(value);
        }

        /// <summary>
        /// Function that returns the Acos value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get Acos value of</param>
        /// <returns>double</returns>
        public static double AcosValueOf(double value)
        {
            return System.Math.Acos(value);
        }

        /// <summary>
        /// Function that returns the Atan value of given <paramref name="value"/>
        /// </summary>
        /// <param name="value">Value to get Atan value of</param>
        /// <returns>double</returns>
        public static double AtanValueOf(double value)
        {
            return System.Math.Atan(value);
        }

        /// <summary>
        /// Function that returns the quotient value of given <paramref name="dividend"/> and <paramref name="divisor"/>
        /// </summary>
        /// <param name="dividend">Value to divide</param>
        /// <param name="divisor">Value to be divided to</param>
        /// <param name="remainder">The remainder value</param>
        /// <returns>int</returns>
        public static int QuotientValueOf(int dividend, int divisor, out int remainder)
        {
            return System.Math.DivRem(dividend, divisor, out remainder);
        }

        /// <summary>
        /// Function that returns Math.E to the power of <paramref name="power"/>
        /// </summary>
        /// <param name="power"></param>
        /// <returns>double</returns>
        public static double ExponentialValueOf(int power)
        {
            return System.Math.Exp(power);
        }

        /// <summary>
        /// Function that adds <paramref name="a"/> and <paramref name="b"/> that then multiplies with <paramref name="c"/>
        /// </summary>
        /// <param name="a">1st value to add</param>
        /// <param name="b">2nd value to add</param>
        /// <param name="c">Value to multiply with</param>
        /// <returns>int</returns>
        public static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c;
        }
    }
}
