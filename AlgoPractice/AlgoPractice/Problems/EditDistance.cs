using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    /// <summary>
    /// 
    /// </summary>
    public class EditDistance: Problem, IDynamicProgrammingTopDown
    {

        #region Fields
        private string str1;
        private string str2;
        private int distance = 0;
        #endregion Fields

        /// <summary>
        /// Sets the input.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        public void SetInput(string input1,string input2)
        {
            str1 = input1;
            str2 = input2;
        }


        /// <summary>
        /// Calculates the solution by top down.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CalculateSolutionByTopDown()
        {
            int result = 0;
            if(string.IsNullOrEmpty(str1))
            {
                result = str2.Length;
            }
            else if(string.IsNullOrEmpty(str2))
            {
                result = str1.Length;
            }
            else
            {
                result = Recursive(str1, str1.Length, str2, str2.Length);
            }

            distance = result;
        }

        /// <summary>
        /// Recursives the specified STR1.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="n1">The n1.</param>
        /// <param name="str2">The STR2.</param>
        /// <param name="n2">The n2.</param>
        /// <returns></returns>
        private int Recursive(string str1, int n1, string str2, int n2)
        {
            int result = 0;
            if (n1 == 0 || n2 == 0)
            {
                result = n1 == 0 ? n2 : n1; 
            }
            else if(str1[n1-1] != str2[n2-1])
            {
                result = 1 + Min(Recursive(str1, n1 -1, str2, n2-1),Recursive(str1, n1, str2, n2-1),Recursive(str1, n1 -1, str2, n2));
            }
            else
            {
                result = Recursive(str1, n1 - 1, str2, n2 - 1);
            }

            return result;
        }

        /// <summary>
        /// Minimums the specified p1.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="p3">The p3.</param>
        /// <returns></returns>
        private int Min(int p1, int p2, int p3)
        {
            return p1 > p2 ? (p2 > p3 ? p3 : p2) : (p1 > p3 ? p3 : p1);
        }


        
        
        
        /// <summary>
        /// Verifies the with expected value.
        /// </summary>
        /// <param name="expectedValue">The expected value.</param>
        /// <returns></returns>
        public bool VerifyWithExpectedValue(int expectedValue)
        {
            return distance == expectedValue;
        }
    }
}
