using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class LongestIncreasingSequenceSteps
    {
        #region Fields

        private static LongestIncreasingSequence longestIncreasingSequence;
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
            longestIncreasingSequence = new LongestIncreasingSequence();

            calculateMethod = selectedAlgorithemType.Calculate(longestIncreasingSequence);
        }

        [Given(@"LongestIncreasingSequence sequence (.*)")]
        public void GivenLongestIncreasingSequenceSequence(string list)
        {
            longestIncreasingSequence.SetInput(list.Convert<int>().ToArray());
        }
        
        [Then(@"LongestIncreasingSequence solution should be (.*)")]
        public void ThenLongestIncreasingSequenceSolutionShouldBe(int expectedValue)
        {
            calculateMethod();
            Assert.IsTrue(longestIncreasingSequence.VerifyWithExpectedValue(expectedValue));
        }
    }
}
