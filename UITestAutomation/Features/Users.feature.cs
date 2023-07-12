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
    [NUnit.Framework.DescriptionAttribute("Users")]
    public partial class UsersFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Users.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Users", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Users")]
        [NUnit.Framework.CategoryAttribute("Add")]
        public virtual void Users()
        {
            string[] tagsOfScenario = new string[] {
                    "Add"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
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
#line 9
 testRunner.Given("User clicks the Profile Icon on Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("User selects the Users Field from the dropdown menu of Profile Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table98 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table98.AddRow(new string[] {
                            "Add"});
                table98.AddRow(new string[] {
                            "Refresh"});
                table98.AddRow(new string[] {
                            "Edit"});
                table98.AddRow(new string[] {
                            "Delete"});
                table98.AddRow(new string[] {
                            "Show Deleted Users"});
                table98.AddRow(new string[] {
                            "Go"});
                table98.AddRow(new string[] {
                            "Enter Page"});
                table98.AddRow(new string[] {
                            "Action"});
                table98.AddRow(new string[] {
                            "Name"});
                table98.AddRow(new string[] {
                            "Email"});
                table98.AddRow(new string[] {
                            "Phone"});
                table98.AddRow(new string[] {
                            "Role"});
                table98.AddRow(new string[] {
                            "Deleted"});
                table98.AddRow(new string[] {
                            "Has Login"});
                table98.AddRow(new string[] {
                            "Branch"});
                table98.AddRow(new string[] {
                            "More"});
                table98.AddRow(new string[] {
                            "setpageDirect"});
                table98.AddRow(new string[] {
                            "prevpage"});
                table98.AddRow(new string[] {
                            "nextpage"});
                table98.AddRow(new string[] {
                            "setpageDirect(pages.length)"});
#line 11
 testRunner.And("User validates the following UI Controls on Users Page", ((string)(null)), table98, "And ");
#line hidden
#line 33
 testRunner.And("User clicks the Add User on Users Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table99 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table99.AddRow(new string[] {
                            "First Name"});
                table99.AddRow(new string[] {
                            "Last Name"});
                table99.AddRow(new string[] {
                            "Email"});
                table99.AddRow(new string[] {
                            "Phone"});
                table99.AddRow(new string[] {
                            "Role"});
                table99.AddRow(new string[] {
                            "Close"});
                table99.AddRow(new string[] {
                            "Save"});
#line 34
 testRunner.And("User validates the following fields on Add User Dialog", ((string)(null)), table99, "And ");
#line hidden
                TechTalk.SpecFlow.Table table100 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields",
                            "Values"});
                table100.AddRow(new string[] {
                            "First Name",
                            "Sania"});
                table100.AddRow(new string[] {
                            "Last Name",
                            "Danial"});
                table100.AddRow(new string[] {
                            "Email",
                            "apap@gmail.com"});
                table100.AddRow(new string[] {
                            "Phone",
                            "123"});
                table100.AddRow(new string[] {
                            "Role",
                            "User"});
#line 43
 testRunner.And("User adds following data to respective fields on Add User Dialog", ((string)(null)), table100, "And ");
#line hidden
#line 50
 testRunner.And("User clicks the Save Button on Add User Dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("User validates the total number of Action Fields on Users Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("User clicks the Dashboard Icon on Users Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
