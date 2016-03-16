using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class PartitionProblemSteps
    {
        #region Fields

        private static PartitionProblem partitionProblem;
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
            partitionProblem = new PartitionProblem();

            calculateMethod = selectedAlgorithemType.Calculate(partitionProblem);
        }

        [Given(@"PartitionProblem input (.*)")]
        public void GivenPartitionProblemInput(string list)
        {
            partitionProblem.SetInput(list.Convert<int>());   
        }

        [Then(@"PartitionProblem solution should be (.*)")]
        public void ThenPartitionProblemSolutionShouleBe(bool expectedValue)
        {
            calculateMethod();
            Assert.IsTrue(partitionProblem.VerifyWithExpectedValue(expectedValue));
        }
    }
}
