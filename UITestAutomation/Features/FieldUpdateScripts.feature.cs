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
    [NUnit.Framework.DescriptionAttribute("FieldUpdateScripts")]
    public partial class FieldUpdateScriptsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FieldUpdateScripts.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "FieldUpdateScripts", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("FieldUpdateScripts")]
        [NUnit.Framework.CategoryAttribute("FieldUpdateScript")]
        public virtual void FieldUpdateScripts()
        {
            string[] tagsOfScenario = new string[] {
                    "FieldUpdateScript"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FieldUpdateScripts", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.And("User selects the Field Update Scripts option from the dropdown menu of ProfileIco" +
                        "n", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table44.AddRow(new string[] {
                            "Add Field Update Script"});
                table44.AddRow(new string[] {
                            "Download Letter"});
                table44.AddRow(new string[] {
                            "Edit Script"});
                table44.AddRow(new string[] {
                            "Copy Script"});
                table44.AddRow(new string[] {
                            "Delete Script"});
                table44.AddRow(new string[] {
                            "Refresh"});
                table44.AddRow(new string[] {
                            "Action"});
                table44.AddRow(new string[] {
                            "Reference"});
                table44.AddRow(new string[] {
                            "Name"});
#line 11
 testRunner.And("User validates the following UI Controls on the Field Update Script Page", ((string)(null)), table44, "And ");
#line hidden
#line 22
 testRunner.And("User clicks the Add Script Icon on the Field Update Script Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table45.AddRow(new string[] {
                            "Script Name"});
                table45.AddRow(new string[] {
                            "Unique Reference"});
                table45.AddRow(new string[] {
                            "Table"});
                table45.AddRow(new string[] {
                            "Field"});
                table45.AddRow(new string[] {
                            "Operator"});
                table45.AddRow(new string[] {
                            "Value/Function"});
                table45.AddRow(new string[] {
                            "Save"});
                table45.AddRow(new string[] {
                            "Close"});
                table45.AddRow(new string[] {
                            "Upload to Library"});
                table45.AddRow(new string[] {
                            "Add Update to Script"});
#line 23
 testRunner.And("User validates the following fields on the Field Update Script Page", ((string)(null)), table45, "And ");
#line hidden
#line 35
 testRunner.And("User clicks the Close Button on the Field Update Script Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
   testRunner.And("User clicks the Download From Library Button on the Field Update Script Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Control and Fields"});
                table46.AddRow(new string[] {
                            "Search Bar"});
                table46.AddRow(new string[] {
                            "Search Button"});
                table46.AddRow(new string[] {
                            "Action"});
                table46.AddRow(new string[] {
                            "Reference"});
                table46.AddRow(new string[] {
                            "Name"});
                table46.AddRow(new string[] {
                            "Download Template Option"});
                table46.AddRow(new string[] {
                            "Close"});
                table46.AddRow(new string[] {
                            "Cross Button"});
#line 37
   testRunner.And("User validates the following UI Controls and fields on the Field Update Script Pa" +
                        "ge", ((string)(null)), table46, "And ");
#line hidden
#line 47
 testRunner.And("User clicks the Close Button on FieldScript Library Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("User clicks the Dashboard Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
