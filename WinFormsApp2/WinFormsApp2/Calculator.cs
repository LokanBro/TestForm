using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    ///<summary>Digital numbers caster</summary>
    public class Calculator
    {
        private List<int> _primeNumbers = new List<int>();
        public List<int> Digitalnumbersinrange(decimal from, decimal till)
        {
            for (int i = Convert.ToInt32(from); i < till; i++)
            {
                uint flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag == 0)
                {
                    _primeNumbers.Add(i);
                }
            }
            return _primeNumbers;
        }

        public List<int> Digital5(IEnumerable<int> arr)
        {
            return arr
               .Where(
                   n =>
                   {
                       var digitSum = 0;
                       while (n > 0)
                       {
                           digitSum += n % 10;
                           n /= 10;
                       }

                       return digitSum == 5;
                   })
               .ToList();
        }

        



            
    }
}
