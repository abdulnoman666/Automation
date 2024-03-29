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
    [NUnit.Framework.DescriptionAttribute("Brands")]
    public partial class BrandsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Brands.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Brands", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Brands")]
        [NUnit.Framework.CategoryAttribute("Brands")]
        public virtual void Brands()
        {
            string[] tagsOfScenario = new string[] {
                    "Brands"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Brands", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.And("User selects the Brands option from the drop down menu of the ProfileIcon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "UI Controls"});
                table10.AddRow(new string[] {
                            "New Case"});
                table10.AddRow(new string[] {
                            "Update Brand"});
                table10.AddRow(new string[] {
                            "Delete Brand"});
                table10.AddRow(new string[] {
                            "Refresh"});
                table10.AddRow(new string[] {
                            "Action"});
                table10.AddRow(new string[] {
                            "Brand Name"});
                table10.AddRow(new string[] {
                            "Email"});
                table10.AddRow(new string[] {
                            "Address"});
                table10.AddRow(new string[] {
                            "City"});
                table10.AddRow(new string[] {
                            "State"});
                table10.AddRow(new string[] {
                            "Zip"});
                table10.AddRow(new string[] {
                            "Phone"});
                table10.AddRow(new string[] {
                            "Fax"});
                table10.AddRow(new string[] {
                            "Charter"});
                table10.AddRow(new string[] {
                            "Logo"});
#line 11
 testRunner.And("User validates the following UI Controls on the Brand Page", ((string)(null)), table10, "And ");
#line hidden
#line 28
    testRunner.And("User clicks the Add Brand Icon on the Brand Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Fields"});
                table11.AddRow(new string[] {
                            "Select Logo File"});
                table11.AddRow(new string[] {
                            "Brand Name"});
                table11.AddRow(new string[] {
                            "Charter"});
                table11.AddRow(new string[] {
                            "Email"});
                table11.AddRow(new string[] {
                            "Address"});
                table11.AddRow(new string[] {
                            "City"});
                table11.AddRow(new string[] {
                            "State"});
                table11.AddRow(new string[] {
                            "Zip"});
                table11.AddRow(new string[] {
                            "Phone"});
                table11.AddRow(new string[] {
                            "Fax"});
                table11.AddRow(new string[] {
                            "Save"});
                table11.AddRow(new string[] {
                            "Close"});
                table11.AddRow(new string[] {
                            "Cross Button"});
#line 29
 testRunner.And("User validates the following fields on the Brand Page", ((string)(null)), table11, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
