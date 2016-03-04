using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class LongestCommonSubStringSteps
    {
        #region Fields

        private static LongestCommonSubString longestCommonSubString;
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
            longestCommonSubString = new LongestCommonSubString();

            calculateMethod = selectedAlgorithemType.Calculate(longestCommonSubString);
        }

        [Given(@"two strings (.*),(.*)")]
        public void GivenTwoStrings(string str1, string str2)
        {
            longestCommonSubString.SetInput(str1, str2);
        }

        [Then(@"the longest common substring should be (.*)")]
        public void LongestCommonSubstringShouldBe(string expected)
        {
            calculateMethod();
            Assert.IsTrue(longestCommonSubString.VerifyWithExpectedValue(expected));
        }

    }
}
