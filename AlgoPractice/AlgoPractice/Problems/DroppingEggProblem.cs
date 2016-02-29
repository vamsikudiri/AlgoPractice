using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    /// <summary>
    /// Egg dropping DP problem and its solution.
    /// </summary>
    public class DroppingEggProblem : Problem, IDynamicProgrammingTopDown, IDynamicProgrammingBottomUp
    {
        #region Fields

        private int floors;
        private int eggs;
        private int solution = -1;
        Dictionary<int, Dictionary<int, int>> map = new Dictionary<int, Dictionary<int, int>>();

        #endregion

        #region private Methods

        /// <summary>
        /// Recursive method for eggs problem.
        /// </summary>
        /// <param name="eggs">The eggs.</param>
        /// <param name="floors">The floors.</param>
        /// <returns></returns>
        private int Recursive(int eggs, int floors)
        {
            int result = -1;
            Dictionary<int, int> tempDictionary;

            if (map.Keys.Contains(eggs) && map[eggs].Keys.Contains(floors))
            {
                result = map[eggs][floors];
            }
            else if (floors == 0)
            {
                tempDictionary = new Dictionary<int, int>();
                tempDictionary[floors] = 0;
                map[eggs] = tempDictionary;
                result = tempDictionary[floors];
            }
            else if (eggs == 0)
            {
                tempDictionary = new Dictionary<int, int>();
                tempDictionary[floors] = -1;
                map[eggs] = tempDictionary;
                result = tempDictionary[floors];
            }

            else
            {
                int minSteps = int.MaxValue;
                int max = 0;
                int temp1, temp2;
                for (int i = 1; i <= floors; i++)
                {
                    temp1 = Recursive(eggs - 1, i - 1);
                    temp2 = Recursive(eggs, floors - i);
                   
                    if (temp1 != -1 && temp2 != -1)
                    {
                        max = temp1 > temp2 ? temp1 : temp2;
                        if (max < minSteps)
                        {
                            minSteps = max;
                        }
                    }
                }

                //Since one step at this recursive call
                minSteps = minSteps + 1;
                if (!map.Keys.Contains(eggs))
                {
                    tempDictionary = new Dictionary<int, int>();
                    map[eggs] = tempDictionary;
                }
                else
                {
                    tempDictionary = map[eggs];
                }
                tempDictionary[floors] = minSteps;
                result = minSteps;
            }
            return result;
        }

        #endregion

        #region public Methods
        /// <summary>
        /// Loads the floors.
        /// </summary>
        /// <param name="inputFloors">The input floors.</param>
        public void LoadFloors(int inputFloors)
        {
            floors = inputFloors;
        }

        /// <summary>
        /// Loads the eggs.
        /// </summary>
        /// <param name="inputEggs">The input eggs.</param>
        public void LoadEggs(int inputEggs)
        {
            eggs = inputEggs;
        }


        /// <summary>
        /// Verifies the with expected result.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <returns></returns>
        public bool VerifyWithExpectedResult(int expected)
        {
            return expected == solution;
        }

        /// <summary>
        /// Calculates the solution by bottom up.
        /// </summary>
        public void CalculateSolutionByBottomUp()
        {
            map[0] = new Dictionary<int, int>();
            map[1] = new Dictionary<int, int>();

            for (int i = 0; i <= floors; i++)
            {
                map[0][i] = -1;
                map[1][i] = i;
            }

            for (int i = 0; i <= eggs; i++)
            {
                if (!map.Keys.Contains(i))
                {
                    map[i] = new Dictionary<int, int>();
                }
                map[i][0] = 0;
            }

            for (int i = 2; i < floors; i++)
            {
                for (int j = 1; j <= eggs; j++)
                {

                }
            }
        }

        /// <summary>
        /// Calculates the solution by top down.
        /// </summary>
        public void CalculateSolutionByTopDown()
        {
            map.Clear();
            solution = Recursive(eggs, floors);
        }
        #endregion


    }
}
