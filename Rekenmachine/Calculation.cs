using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Calculation
    {
        public void ConvertNumbers(ref double num1, ref double num2, string num)
        {
            if (num != null && num != "")
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(num);

                }
                else
                {
                    num2 = Convert.ToDouble(num);
                }

            }
        }

        public string PosNeg(string resultaat)
        {
            try
            {
                double numSwitch = Convert.ToDouble(resultaat);
                numSwitch *= -1;
                return resultaat = numSwitch.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
