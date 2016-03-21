﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestCases.FeaturesAndSteps
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("LongestIncreasingSequence", SourceFile="FeaturesAndSteps\\LongestIncreasingSequence.feature", SourceLine=0)]
    public partial class LongestIncreasingSequenceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LongestIncreasingSequence.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LongestIncreasingSequence", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void LongestIncreasingSequenceTestingBySimpleRecursive(string sequence, string maxLength, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SimpleRecursive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LongestIncreasingSequence Testing by SimpleRecursive", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("LongestIncreasingSequence sequence {0}", sequence), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then(string.Format("LongestIncreasingSequence solution should be {0}", maxLength), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by SimpleRecursive, 10, 22, 9, 33, 21, 50, 41, " +
            "60, 80", new string[] {
                "SimpleRecursive"}, SourceLine=10)]
        public virtual void LongestIncreasingSequenceTestingBySimpleRecursive_10229332150416080()
        {
            this.LongestIncreasingSequenceTestingBySimpleRecursive("10, 22, 9, 33, 21, 50, 41, 60, 80", "6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by SimpleRecursive, 1, 3, 5, 8, 9, 2, 6, 7, 6, " +
            "8, 9", new string[] {
                "SimpleRecursive"}, SourceLine=10)]
        public virtual void LongestIncreasingSequenceTestingBySimpleRecursive_13589267689()
        {
            this.LongestIncreasingSequenceTestingBySimpleRecursive("1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by SimpleRecursive, 1, 3, 5, 8, 0, 2, 6, 7, 6, " +
            "8, 9", new string[] {
                "SimpleRecursive"}, SourceLine=10)]
        public virtual void LongestIncreasingSequenceTestingBySimpleRecursive_13580267689()
        {
            this.LongestIncreasingSequenceTestingBySimpleRecursive("1, 3, 5, 8, 0, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by SimpleRecursive, 1, 3, 5, 0, 0, 2, 6, 7, 6, " +
            "8, 9", new string[] {
                "SimpleRecursive"}, SourceLine=10)]
        public virtual void LongestIncreasingSequenceTestingBySimpleRecursive_13500267689()
        {
            this.LongestIncreasingSequenceTestingBySimpleRecursive("1, 3, 5, 0, 0, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        public virtual void LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp(string sequence, string maxLength, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DynamicProgrammingBottomUp"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LongestIncreasingSequence Testing by DynamicProgrammingBottomUp", @__tags);
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given(string.Format("LongestIncreasingSequence sequence {0}", sequence), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.Then(string.Format("LongestIncreasingSequence solution should be {0}", maxLength), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by DynamicProgrammingBottomUp, 10, 22, 9, 33, 2" +
            "1, 50, 41, 60, 80", new string[] {
                "DynamicProgrammingBottomUp"}, SourceLine=23)]
        public virtual void LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp_10229332150416080()
        {
            this.LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp("10, 22, 9, 33, 21, 50, 41, 60, 80", "6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by DynamicProgrammingBottomUp, 1, 3, 5, 8, 9, 2" +
            ", 6, 7, 6, 8, 9", new string[] {
                "DynamicProgrammingBottomUp"}, SourceLine=23)]
        public virtual void LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp_13589267689()
        {
            this.LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp("1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by DynamicProgrammingBottomUp, 1, 3, 5, 8, 0, 2" +
            ", 6, 7, 6, 8, 9", new string[] {
                "DynamicProgrammingBottomUp"}, SourceLine=23)]
        public virtual void LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp_13580267689()
        {
            this.LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp("1, 3, 5, 8, 0, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("LongestIncreasingSequence Testing by DynamicProgrammingBottomUp, 1, 3, 5, 0, 0, 2" +
            ", 6, 7, 6, 8, 9", new string[] {
                "DynamicProgrammingBottomUp"}, SourceLine=23)]
        public virtual void LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp_13500267689()
        {
            this.LongestIncreasingSequenceTestingByDynamicProgrammingBottomUp("1, 3, 5, 0, 0, 2, 6, 7, 6, 8, 9", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
