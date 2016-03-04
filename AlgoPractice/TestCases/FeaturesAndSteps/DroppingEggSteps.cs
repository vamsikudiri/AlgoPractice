using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace TestCases
{
    [Binding]
    class DroppingEggSteps
    {
        #region Fields

        static List<DroppingEggProblem> eggProblems = new List<DroppingEggProblem>();
        protected static AlgorithemType selectedAlgorithemType;
        protected static VoidMethod calculateMethod;

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
            eggProblems.Clear();
        }


        [Given(@"(.*), (.*) floors")]
        public void GivenFloors(int eggCount, string list)
        {
            List<int> floors = list.Convert<int>();
            StringBuilder solution = new StringBuilder();
            foreach(int floor in floors)
            {
                DroppingEggProblem egg = new DroppingEggProblem();
                egg.LoadEggs(eggCount);
                egg.LoadFloors(floor);
                eggProblems.Add(egg);
            }
        }
        
        [Then(@"the result should (.*)")]
        public void ThenTheResultShould(string list)
        {
            List<int> expected = list.Convert<int>();
            for (int i = 0; i < expected.Count;i++ )
            {
                calculateMethod = selectedAlgorithemType.Calculate(eggProblems[i]);
                Assert.IsNotNull(calculateMethod,selectedAlgorithemType + " is not implemented");
                calculateMethod();
                Assert.IsTrue(eggProblems[i].VerifyWithExpectedResult(expected[i]));
            }
        }
    }
}
