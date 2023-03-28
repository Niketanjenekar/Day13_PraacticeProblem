using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_GenericProblems
{
    public class RefactorUsingGenerics<T> where T : IComparable
    {
        private T firstValue;
        private T secondValue;
        private T thirdValue;

        public void FindMax(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            {
                this.firstValue = firstValue;
                this.secondValue = secondValue;
                this.thirdValue = thirdValue;
            }
            internal static T FindingMaximum<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
            {

                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                {
                    return firstValue;
                }

                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                    secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                    secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                {
                    return secondValue;
                }

                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                    thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                    thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
                {
                    return thirdValue;
                }
                return firstValue;

            }
            


              
        }
    }
}
