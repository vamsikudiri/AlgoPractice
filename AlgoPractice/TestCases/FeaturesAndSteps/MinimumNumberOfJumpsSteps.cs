using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class MinimumNumberOfJumpsSteps
    {
        #region Fields

        private static MinimumNumberOfJumps minimumNumberOfJumps;
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
            minimumNumberOfJumps = new MinimumNumberOfJumps();

            calculateMethod = selectedAlgorithemType.Calculate(minimumNumberOfJumps);
        }

        [Given(@"MinimumNumberOfJumps sequence (.*)")]
        public void GivenMinimumNumberOfJumpsSequence(string list)
        {
            minimumNumberOfJumps.SetInput(list.Convert<int>().ToArray());
        }

        [Then(@"MinimumNumberOfJumps solution should be (.*)")]
        public void ThenMinimumNumberOfJumpsSolutionShouldBe(int expectedValue)
        {
            calculateMethod();
            Assert.IsTrue(minimumNumberOfJumps.VerifyWithExpectedValue(expectedValue));
        }
    }
}
