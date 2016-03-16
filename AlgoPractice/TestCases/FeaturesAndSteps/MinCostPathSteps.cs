using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class MinCostPathSteps
    {


        #region Fields

        private static MinCostPath minCostPath;
        private static AlgorithemType selectedAlgorithemType;
        private static VoidMethod calculateMethod;

        #endregion Fields


        /// <summary>
        /// Before the scenario.
        /// </summary>
        [BeforeScenario]
        public static void BeforeScenario()
        {
            string[] tags = ScenarioContext.Current.ScenarioInfo.Tags;
            if (tags.Length > 0)
            {
                selectedAlgorithemType = (AlgorithemType)Enum.Parse(typeof(AlgorithemType), tags[0]);
            }
            minCostPath = new MinCostPath();

            calculateMethod = selectedAlgorithemType.Calculate(minCostPath);
        }


        [Given(@"MinCostPath input (.*), (.*), (.*)")]
        public void GivenMinCostPathInput(int rows, int columns, string matrix)
        {
            minCostPath.SetInput(matrix.CovertToArray<int>(rows, columns), rows, columns);
        }

        [Then(@"MinCostPath should be (.*)")]
        public void ThenMinCostPathShouldBe(int expected)
        {
            calculateMethod();
            Assert.IsTrue(minCostPath.VerifyWithExpectedValue(expected));
        }
    }
}
