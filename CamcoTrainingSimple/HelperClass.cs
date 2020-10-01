using System;
using System.Collections.Generic;
using System.Text;

namespace CamcoTrainingSimple
{
    public static class HelperClass
    {
        public static int ToInteger(this string value)
        {
            int number = 0;
            int.TryParse(value, out number);
            return number;
        }
        public static double ToDouble(this string value)
        {
            try
            {
                double dob = Convert.ToDouble(value);

                return dob;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static decimal ToDecimal(this string inputString)
        {

            try
            {
                decimal dec = Convert.ToDecimal(inputString);

                return dec;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static float ToFloat(this string inputString)
        {

            try
            {
                float flt = float.Parse(inputString);

                return flt;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static float ToNumeric(this string inputString)
        {

            try
            {
                int temp = Convert.ToInt32(inputString);
                return temp;
            }
            catch (Exception h)
            {
                //  MessageBox.Show("Please provide unit price in numbers only");
                return 0;
            }
        }
    }
}
