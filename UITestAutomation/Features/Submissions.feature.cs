﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITestAutomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Submissions")]
    public partial class SubmissionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Submissions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Submissions", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
 testRunner.Given("User log into Dispute Tracking Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.And("User should be able to see Dashboard in Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Submissions")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public virtual void Submissions()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Submissions", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 8
 testRunner.Given("User clicks the Submissions Field on the Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("User selects the Submissions List Field from the dropdown menu of Submissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table82 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table82.AddRow(new string[] {
                            "New Case"});
                table82.AddRow(new string[] {
                            "Settings"});
                table82.AddRow(new string[] {
                            "Search"});
                table82.AddRow(new string[] {
                            "Refresh"});
                table82.AddRow(new string[] {
                            "All Originators"});
                table82.AddRow(new string[] {
                            "All Assignee"});
                table82.AddRow(new string[] {
                            "Enter Page"});
                table82.AddRow(new string[] {
                            "Go"});
                table82.AddRow(new string[] {
                            "Show Closed Submissions"});
                table82.AddRow(new string[] {
                            "View Submission"});
                table82.AddRow(new string[] {
                            "Reassign Submission"});
                table82.AddRow(new string[] {
                            "Delete or Withdraw Submission"});
#line 10
 testRunner.And("User validates the following UI Controls on Submissions List Page", ((string)(null)), table82, "And ");
#line hidden
                TechTalk.SpecFlow.Table table83 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table83.AddRow(new string[] {
                            "Action"});
                table83.AddRow(new string[] {
                            "ID"});
                table83.AddRow(new string[] {
                            "Type"});
                table83.AddRow(new string[] {
                            "Account Type"});
                table83.AddRow(new string[] {
                            "Customer"});
                table83.AddRow(new string[] {
                            "Workflow"});
                table83.AddRow(new string[] {
                            "Reported"});
                table83.AddRow(new string[] {
                            "Days"});
                table83.AddRow(new string[] {
                            "Status"});
                table83.AddRow(new string[] {
                            "Total"});
                table83.AddRow(new string[] {
                            "Item Count"});
                table83.AddRow(new string[] {
                            "Assigned To"});
#line 24
 testRunner.And("User validates the following Fields on Submissions List Page", ((string)(null)), table83, "And ");
#line hidden
#line 38
 testRunner.And("User clicks the Reassign Submission Icon on Submissions List Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table84 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table84.AddRow(new string[] {
                            "Processors"});
                table84.AddRow(new string[] {
                            "Cancel"});
                table84.AddRow(new string[] {
                            "Assign Case"});
#line 39
 testRunner.And("User validates the following UI Controls on Reassign Submission Dialog", ((string)(null)), table84, "And ");
#line hidden
#line 44
 testRunner.And("User clicks the Cancel Button on Reassign Submission Dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("User clicks the Dashboard Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
