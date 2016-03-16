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
    public class PartitionProblem : Problem, IDynamicProgrammingTopDown
    {
        #region Fields
        private List<int> list;
        private bool canBePartitioned=false;
        #endregion Fields


        public void SetInput(List<int> input)
        {
            list = input;
        }
        /// <summary>
        /// Calculates the solution by top down.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CalculateSolutionByTopDown()
        {
            canBePartitioned = false;
            int total = 0;
            foreach(int ele in list)
            {
                total += ele;
            }
            if(total%2 == 0)
            {
                canBePartitioned = DoesElementsPickedOfTotal(total / 2,list.Count());
            }
        }

        /// <summary>
        /// Doeses the elements picked of total.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private bool DoesElementsPickedOfTotal(int total,int length)
        {
            bool result = false;

            if (total == 0)
            {
                result = true;
            }
            else if(length > 0)
            {
                result = DoesElementsPickedOfTotal(total - list[length - 1], length - 1) || DoesElementsPickedOfTotal(total, length - 1);
            }
            return result;
        }

        /// <summary>
        /// Verifies the with expected value.
        /// </summary>
        /// <param name="expectedValue">if set to <c>true</c> [expected value].</param>
        /// <returns></returns>
        public bool VerifyWithExpectedValue(bool expectedValue)
        {
            return expectedValue == canBePartitioned;
        }
    }
}
