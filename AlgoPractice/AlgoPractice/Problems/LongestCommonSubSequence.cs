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
    public class LongestCommonSubSequence : Problem, IDynamicProgrammingBottomUp, IDynamicProgrammingTopDown
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

            map.Clear();
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    if (string1[i] == string2[j])
                    {
                        SetMap(i, j, GetMaxFromMap(i, j)+1);
                    }
                    else
                    {
                        SetMap(i, j, 0);
                    }
                }
            }

            int lengthOfSubSequence = 1;
            StringBuilder tempString = new StringBuilder();


            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    if (lengthOfSubSequence == map[i][j])
                    {
                        tempString.Append(string1[i]);
                        lengthOfSubSequence++;
                        break;
                    }
                }
            }
                solution = tempString.ToString();
        }

        #endregion Public Methods

        #region Private Methods
        /// <summary>
        /// Gets from map.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <returns></returns>
        private int GetMaxFromMap(int index1, int index2)
        {
            int max = 0;
            if (map.Keys.Contains(index1-1) && map[index1-1].Keys.Contains(index2-1))
            {
                for (int i = 0; i < index1;i++)
                {
                    for(int j=0;j<index2;j++)
                    {
                        if(max < map[i][j])
                        {
                            max = map[i][j];
                        }
                    }
                }

            }
            return max;
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
