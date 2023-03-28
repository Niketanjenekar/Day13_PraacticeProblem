using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_GenericProblems
{
    public class FindStringMaximum
    {
        public static string FindingStringMaximum(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.Length > secondValue.Length && firstValue.Length > thirdValue.Length ||
                firstValue.Length >= secondValue.Length && firstValue.Length > thirdValue.Length ||
                firstValue.Length > secondValue.Length && firstValue.Length >= thirdValue.Length)
            {
                return firstValue;
            }

            if (secondValue.Length > firstValue.Length && secondValue.Length > thirdValue.Length ||
                secondValue.Length >= firstValue.Length && secondValue.Length > thirdValue.Length ||
                secondValue.Length > firstValue.Length && secondValue.Length >= thirdValue.Length)
            {
                return secondValue;
            }

            if (thirdValue.Length > firstValue.Length && thirdValue.Length > secondValue.Length ||
                thirdValue.Length >= firstValue.Length && thirdValue.Length > secondValue.Length ||
                thirdValue.Length > firstValue.Length && thirdValue.Length >= secondValue.Length)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
