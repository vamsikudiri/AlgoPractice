using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases
{
    [Binding]
    public class LongestCommonSubSequenceSteps
    {

        #region Fields

        private static LongestCommonSubSequence longestCommonSubSequence;
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
            longestCommonSubSequence = new LongestCommonSubSequence();

            calculateMethod = selectedAlgorithemType.Calculate(longestCommonSubSequence);
        }


        [Given(@"input of LongestCommonSubSequence (.*), (.*)")]
        public void GivenInputOfLongestCommonSubSequence(string str1, string str2)
        {
            longestCommonSubSequence.SetInput(str1, str2);
        }

        [Then(@"the LongestCommonSubSequence should be (.*)")]
        public void LongestCommonSubSequencShouldBe(string expected)
        {
            calculateMethod();
            Assert.IsTrue(longestCommonSubSequence.VerifyWithExpectedValue(expected));
        }
    }
}
