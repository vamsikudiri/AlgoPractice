using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class PallondromPartitioningSteps
    {


        #region Fields

        private static PallondromPartitioning pallondromPartitioning;
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
            pallondromPartitioning = new PallondromPartitioning();

            calculateMethod = selectedAlgorithemType.Calculate(pallondromPartitioning);
        }


        [Given(@"PallondromPartitioning input (.*)")]
        public void GivenPallondromPartitioningInput(string intputString)
        {
            pallondromPartitioning.SetInput(intputString);
        }

        [Then(@"minimum number of partitions are (.*)")]
        public void ThenMinimumNumberOfPartionsAre(int expected)
        {
            calculateMethod();
            Assert.IsTrue(pallondromPartitioning.VerifyWithExpectedValue(expected));
        }
    }
}
