using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    /// <summary>
    /// Longest common substring
    /// </summary>
    public class LongestCommonSubString : Problem, IDynamicProgrammingBottomUp, IDynamicProgrammingTopDown
    {
        #region Fields

        private Dictionary<int, Dictionary<int, int>> map = new Dictionary<int, Dictionary<int, int>>();
        private string solution = string.Empty;
        private string string1;
        private string string2;

        #endregion Fields

        #region Public Methods

        /// <summary>
        /// Sets the input.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        public void SetInput(string str1, string str2)
        {
            string1 = str1;
            string2 = str2;
        }

        /// <summary>
        /// Verifies the with expected value.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <returns></returns>
        public bool VerifyWithExpectedValue(string expected)
        {
            return string.Compare(solution, expected) == 0;
        }


        /// <summary>
        /// Calculates the solution by top down.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CalculateSolutionByTopDown()
        {

        }

        /// <summary>
        /// Calculates the solution by bottom up.
        /// </summary>
        public void CalculateSolutionByBottomUp()
        {
            int temp = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    temp = 0;
                    if (string1[i] == string2[j])
                    {
                        temp = i > 0 && j > 0 ? GetFromMap(i-1, j-1) + 1 : 1;
                        SetMap(i, j, temp);
                    }
                    else
                    {
                        SetMap(i, j, 0);
                    }
                }
            }

            int maxInMap = 0;
            temp = -1;
            int indexInString1 = -1, indexInString2 = -1;
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    temp = GetFromMap(i, j);
                    if (temp > maxInMap)
                    {
                        maxInMap = temp;
                        indexInString1 = i;
                        indexInString2 = j;
                    }
                }
            }

            if (maxInMap > 0)
            {
                StringBuilder tempString = new StringBuilder();
                while (indexInString1 >= 0 && indexInString2 >= 0 && map[indexInString1][indexInString2] > 0)
                {
                    tempString.Append(string1[indexInString1--]);
                    indexInString2--;
                }
                solution = new string(tempString.ToString().Reverse().ToArray());
            }
        }


        #endregion Public Methods

        #region Private Methods
        /// <summary>
        /// Gets from map.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <returns></returns>
        private int GetFromMap(int i, int j)
        {
            int result = -1;
            if (map.Keys.Contains(i) && map[i].Keys.Contains(j))
            {
                result = map[i][j];
            }
            return result;
        }



        /// <summary>
        /// Sets the map.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <param name="value">The value.</param>
        private void SetMap(int i, int j, int value)
        {
            Dictionary<int, int> temp;
            if (map.Keys.Contains(i))
            {
                temp = map[i];
            }
            else
            {
                temp = new Dictionary<int, int>();
                map[i] = temp;
            }

            temp[j] = value;
        }
   

        #endregion
    }
}
