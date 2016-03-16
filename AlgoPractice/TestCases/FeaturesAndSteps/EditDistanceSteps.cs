using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class EditDistanceSteps
    {

        #region Fields

        private static EditDistance editDistance;
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
            editDistance = new EditDistance();

            calculateMethod = selectedAlgorithemType.Calculate(editDistance);
        }

        [Given(@"EditDistance input (.*), (.*)")]
        public void GivenEditDistanceInput(string str1, string str2)
        {
            editDistance.SetInput(str1,str2);
            
        }

        [Then(@"EditDistance should be (.*)")]
        public void ThenEditDistanceShouldBe(int expectedValue)
        {
            calculateMethod();
            Assert.IsTrue(editDistance.VerifyWithExpectedValue(expectedValue));
        }
    }
}
