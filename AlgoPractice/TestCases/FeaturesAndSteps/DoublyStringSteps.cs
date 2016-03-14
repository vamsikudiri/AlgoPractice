using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TestCases.FeaturesAndSteps
{
    [Binding]
    public class DoublyStringSteps
    {
        #region Fields

        private static DoublyString doublyString;
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
            doublyString = new DoublyString();

            calculateMethod = selectedAlgorithemType.Calculate(doublyString);
        }



        [Given(@"DoublyString input (.*)")]
        public void GivenDoublyStringInput(string intputString)
        {
            doublyString.SetInput(intputString);
        }

        [Then(@"DoublyString result should be (.*)")]
        public void ThenDoublyStringResultShouldBeTrue(bool expected)
        {
            calculateMethod();
            Assert.IsTrue(doublyString.VerifyWithExpectedValue(expected));
        }
    }
}
