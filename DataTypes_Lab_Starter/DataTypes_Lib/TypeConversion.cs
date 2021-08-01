using System;


namespace DataTypes_Lib
{
    public class TypeConversion
    {
            // ALL DONE

        public static short UIntToShort(uint num)
        {

            if (num == uint.MaxValue || num == uint.MinValue && num != 0)
            {
                throw new OverflowException();
            }
            else if (num == short.MaxValue + 1) 
            {
                throw new OverflowException();
            }

            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            if (num == float.MaxValue || num == float.MinValue)
            {
                throw new OverflowException();
            }
            else if (num < 0) 
            {
                return (long)Math.Round(num);
            }


            return (long)Math.Round(num);
        }
    }
}
