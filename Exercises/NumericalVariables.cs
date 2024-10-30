namespace Exercises
{
    public class NumericalVariables
    {
        //Integral numeric types
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        //Ordered from smallest to largest size, and Signed then Unsigned
        public static sbyte SbyteFunction()
        {
            /*
             * Signed - range includes negative and positive
             * sbyte range: -128 to 127
             * Size: 8-bit Integer
             */
            sbyte randomSbyte = -128;
            return randomSbyte;
        }
        public static byte ByteFunction()
        {
            /*
             * Unsigned - range is only positive including 0
             * byte range: 0 to 255
             * Size: 8-bit Integer
             */
            byte randomByte = 255;
            return randomByte;
        }
        public static short ShortFunction()
        {
            /*
             * Signed - range includes negative and positive
             * short range: -32,768 to 32,767 
             * Size: 16-bit Integer
             */
            short randomShort = -32768;
            return randomShort;
        }
        public static ushort UShortFunction()
        {
            /*
             * Unsigned - range is only positive including 0
             * Ushort range: 0 to 65535
             * Size: 16-bit Integer
             */
            ushort randomUshort = 65535;
            return randomUshort;
        }
        public static int IntegerFunction()
        {
            /*
             * Signed - range includes negative and positive
             * Integer range: -2,147,483,648 to 2,147,483,647
             * Size: 32-bit Integer
             */
            int randomInteger = 2147483647;
            randomInteger *= -1;
            return randomInteger;
        }
        public static uint UIntFunction()
        {
            /*
             * Unsigned - range is negative and positive
             * Uint range: 0 to 4,294,967,295
             * Size: 32-bit Integer
             */
            uint randomUint = 4294957295;
            return randomUint;
        }
        public static long LongFunction()
        {
            /*
             * Signed - range includes negative and positive
             * Long range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * Size: 64-bit Integer
             */
            long randomLong = -9223372036854775808;
            return randomLong;
        }
        public static ulong UlongFunction()
        {
            /*
             * Unsigned - range is negative and positive
             * Ulong range: 0 to 18,446,744,073,709,551,615
             * Size: 64-bit Integer
             */
            ulong randomUlong = 18446744073709551615;
            return randomUlong;
        }
        public static nint NIntFunction()
        {
            /*
             * Signed - range includes negative and positive
             * Nint range: Depends on platform 32-bit or 64-bit
             * Size: Depends on platform 32-bit or 64-bit
             */
            return nint.MaxValue;
        }
        public static nuint NuIntFunction()
        {
            /*
             * Unsigned - range is negative and positive
             * Nint range: Depends on platform 32-bit or 64-bit
             * Size: Depends on platform 32-bit or 64-bit
             */
            return nuint.MaxValue;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Floating-point numeric types
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#code-try-1
        //Ordered from smallest to largest size
        public static float FloatFunction()
        {
            //Float needs an f at the end
            float randomFloat = 1.1123412321321312313123f;
            //Will get rounded to estimated digits for float: ~6-9 digits
            return randomFloat;
        }
        public static double DoubleFunction()
        {
            /* Double has a precision of estimated 15 to 17 digits and is 8 bytes
             * Decimal would have a larger range with 16 bytes in size, while a float would be the smaller with 4 bytes in size
             * 
             * Double and Float can be compared without Explicit Conversion, but Decimal and Double/Float cannot be compared without Explicit conversion
             * 
             * Considerations:
             * Scale: Precision <------> Performance
             *          | Decimal   | Double    | Float
             *          
             *          Performance because of the space difference, in a large scaling application, difference between 16 and 4 bytes will add up
             *          Precision because Decimal is able to provide the most digits allowing for more precise calculation
             */

            //Double does not need an m or f at the end
            double randomDouble = 0.123456789101112123131312313213213123123213123121232111111111111111111111;
            //Will get rounded to the estimated digits
            randomDouble *= -1;
            return randomDouble;
        }
        public static decimal DecimalFunction()
        {
            //Decimal needs an m at the end
            decimal randomDecimal = 1.111111111111111111111111111111111111111111m;
            //If larger than 28-29 digits it will round to estimate.
            return randomDecimal;
        }
    }
}
