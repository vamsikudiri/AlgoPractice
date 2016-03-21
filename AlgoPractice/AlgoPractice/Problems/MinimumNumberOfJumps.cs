using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class MinimumNumberOfJumps : Problem, IDynamicProgrammingTopDown
    {

        #region Fields

        int[] inputArray;
        int[] map;
        int minSteps;

        #endregion

        public void SetInput(int[] input)
        {
            inputArray = input;
        }

        public void CalculateSolutionByTopDown()
        {
            map = new int[inputArray.Length];

            map[inputArray.Length - 1] = 0;
            int temp = int.MaxValue;
            if (inputArray.Length > 1)
            {
                for (int i = inputArray.Length - 2; i >= 0; i--)
                {
                    temp = int.MaxValue;
                    for(int j = 1 ; j <= inputArray[i]; j++)
                    {
                        if(j + i < inputArray.Length)
                        {
                            if (temp > map[j + i])
                            {
                                temp = map[j + i];
                            }
                        }
                    }
                    map[i] = temp != int.MaxValue ? temp + 1 : temp;
                }
            }
            minSteps = map[0];
        }

        /// <summary>
        /// Verifies the with expected value.
        /// </summary>
        /// <param name="expectedValue">The expected value.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool VerifyWithExpectedValue(int expectedValue)
        {
            return expectedValue == minSteps;
        }
    }
}
