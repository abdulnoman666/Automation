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
    [NUnit.Framework.DescriptionAttribute("FeeReimbursementSettings")]
    public partial class FeeReimbursementSettingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FeeReimbursementSettings.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "FeeReimbursementSettings", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Fee Reimbursement Settings")]
        [NUnit.Framework.CategoryAttribute("Add")]
        public virtual void FeeReimbursementSettings()
        {
            string[] tagsOfScenario = new string[] {
                    "Add"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fee Reimbursement Settings", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("User clicks the Profile Icon on the dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("User Selects the Fee Reimbursement Settings from the dropdown menu of the Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table23.AddRow(new string[] {
                            "Add"});
                table23.AddRow(new string[] {
                            "Delete"});
                table23.AddRow(new string[] {
                            "Edit"});
#line 11
 testRunner.And("User validates following UI controls on Fee Reimbursement Settings Page", ((string)(null)), table23, "And ");
#line hidden
#line 17
 testRunner.And("User clicks the Add Fee Reimbursement Settings Icon on Fee Reimbursement Settings" +
                        " Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field"});
                table24.AddRow(new string[] {
                            "Reference"});
                table24.AddRow(new string[] {
                            "Description"});
                table24.AddRow(new string[] {
                            "Auto Generate GL"});
                table24.AddRow(new string[] {
                            "Auto Fee GL Reference"});
                table24.AddRow(new string[] {
                            "Show On Dispute Form"});
                table24.AddRow(new string[] {
                            "Create Disputes"});
                table24.AddRow(new string[] {
                            "Include In Claim Total"});
#line 18
 testRunner.And("User validates following fields on Add Fee Reimbursement Settings Dialog", ((string)(null)), table24, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("FeeRUpdate")]
        [NUnit.Framework.CategoryAttribute("Edit")]
        public virtual void FeeRUpdate()
        {
            string[] tagsOfScenario = new string[] {
                    "Edit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FeeRUpdate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
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
#line 30
 testRunner.Given("User clicks on the Edit Fee Reimbursement button on the Fee Reimbursement Setting" +
                        "s Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "fields"});
                table25.AddRow(new string[] {
                            "Reference"});
                table25.AddRow(new string[] {
                            "Description"});
                table25.AddRow(new string[] {
                            "Auto Generate GL"});
                table25.AddRow(new string[] {
                            "Auto Fee GL Reference"});
                table25.AddRow(new string[] {
                            "Show On Dispute Form"});
                table25.AddRow(new string[] {
                            "Create Disputes"});
                table25.AddRow(new string[] {
                            "Include In Claim Total"});
#line 31
 testRunner.And("User validates the following fileds on Edit Fee Reimbursement Settings Page", ((string)(null)), table25, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("FeeRDelete")]
        [NUnit.Framework.CategoryAttribute("Delete")]
        public virtual void FeeRDelete()
        {
            string[] tagsOfScenario = new string[] {
                    "Delete"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FeeRDelete", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
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
#line 43
 testRunner.Given("User clicks on the Delete Fee Reimbursement button on Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Controls"});
                table26.AddRow(new string[] {
                            "Yes"});
                table26.AddRow(new string[] {
                            "No"});
#line 44
 testRunner.And("User validates the following Controls on Confirm Deletion Popup", ((string)(null)), table26, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion