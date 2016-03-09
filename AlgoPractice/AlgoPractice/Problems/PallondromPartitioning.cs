using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class PallondromPartitioning : Problem, IDynamicProgrammingTopDown
    {
#region Fields
        int solution = -2;
        string inputString = string.Empty;
        Dictionary<int, int> map = new Dictionary<int, int>();
#endregion Fields
        public void SetInput(string input)
        {
            inputString = input;
        }

        public void CalculateSolutionByTopDown()
        {

            solution = RecursiveSolution(inputString);
        }

        /// <summary>
        /// Recursives the solution.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private int RecursiveSolution(string inputString)
        {
            int result = -1;
            if(!string.IsNullOrEmpty(inputString))
            {
                if (map.Keys.Contains(inputString.Length))
                {
                    result = map[inputString.Length];
                }
                else
                {
                    result = inputString.Length - 1;
                    int temp = 0;
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        if (IsPallandrom(inputString.Substring(0, i + 1)))
                        {
                            temp = 1 + RecursiveSolution(inputString.Substring(i + 1));
                            if (result > temp)
                            {
                                result = temp;
                            }
                        }
                    }
                    map[inputString.Length] = result;
                }
            }
            return result;
        }

        /// <summary>
        /// Determines whether the specified input is pallandrom.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        private bool IsPallandrom(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    result = false;
                    break;

                }
            }
            return result;
        }

        public bool VerifyWithExpectedValue(int expected)
        {
            return solution == expected;
        }
    }
}
