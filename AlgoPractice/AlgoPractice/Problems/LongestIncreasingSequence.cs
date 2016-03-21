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
    public class LongestIncreasingSequence : Problem, ISimpleRecursive, IDynamicProgrammingBottomUp
    {
        #region Fields
        private int[] inputArray;
        private int lenthOfLongestIncreasingSequence;

        #endregion Fields

        /// <summary>
        /// Sets the input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void SetInput(int[] input)
        {
            inputArray = input;
        }

        /// <summary>
        /// Calculates the solution.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CalculateSolutionBySimpleRecursive()
        {
            lenthOfLongestIncreasingSequence = Recursive(inputArray, inputArray.Length);
        }

        /// <summary>
        /// Recursives the specified input array.
        /// </summary>
        /// <param name="inputArray">The input array.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private int Recursive(int[] input, int n)
        {
            int result = 0;
            if (n > 1)
            {
                int temp = 0;
                for (int i = 1; i < n; i++)
                {
                    if (inputArray[i - 1] < inputArray[n - 1])
                    {
                        temp = Recursive(input, i);
                        if (result < temp)
                        {
                            result = temp;
                        }
                    }
                }

            }
            result++;
            return result;
        }

        /// <summary>
        /// Verifies the with expected value.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <returns></returns>
        public bool VerifyWithExpectedValue(int expected)
        {
            return expected == lenthOfLongestIncreasingSequence;
        }

        /// <summary>
        /// Calculates the solution by bottom up.
        /// </summary>
        public void CalculateSolutionByBottomUp()
        {
            lenthOfLongestIncreasingSequence = 0;
            int[] map = new int[inputArray.Length];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = 1;
            }

            int temp = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (inputArray[j] < inputArray[i])
                    {
                        if (temp < map[j])
                        {
                            temp = map[j];
                        }
                    }
                }
                map[i] = temp + 1;
                temp = 0;
            }
            if (inputArray.Length > 0)
            {
                lenthOfLongestIncreasingSequence = map[inputArray.Length-1];
            }
        }
    }
}
