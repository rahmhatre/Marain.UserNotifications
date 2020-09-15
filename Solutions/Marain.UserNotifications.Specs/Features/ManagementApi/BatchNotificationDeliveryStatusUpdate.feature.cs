﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Marain.UserNotifications.Specs.Features.ManagementApi
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Batch update of notification delivery statuses")]
    [NUnit.Framework.CategoryAttribute("perFeatureContainer")]
    [NUnit.Framework.CategoryAttribute("useApis")]
    [NUnit.Framework.CategoryAttribute("useTransientTenant")]
    public partial class BatchUpdateOfNotificationDeliveryStatusesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "perFeatureContainer",
                "useApis",
                "useTransientTenant"};
        
#line 1 "BatchNotificationDeliveryStatusUpdate.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/ManagementApi", "Batch update of notification delivery statuses", null, ProgrammingLanguage.CSharp, new string[] {
                        "perFeatureContainer",
                        "useApis",
                        "useTransientTenant"});
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Set delivery state of a subset of notifications for a user")]
        public virtual void SetDeliveryStateOfASubsetOfNotificationsForAUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Set delivery state of a subset of notifications for a user", null, tagsOfScenario, argumentsOfScenario);
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
#line 8
 testRunner.Given("I have created and stored 25 notifications in the current transient tenant with t" +
                        "imestamps at 30 second intervals for the user with Id \'user100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("I have created and stored 5 notifications in the current transient tenant with ti" +
                        "mestamps at 30 second intervals for the user with Id \'user101\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("I send a management API request to batch update the delivery status of the first " +
                        "10 stored notifications for user \'user100\' to \'Delivered\' for the delivery chann" +
                        "el with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("the response status code should be \'Accepted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
    testRunner.And("the response should contain a \'Location\' header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.And("the long running operation whose Url is in the response Location header should no" +
                        "t have a \'status\' of \'NotStarted\' within 10 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And("the long running operation whose Url is in the response Location header should ha" +
                        "ve a \'status\' of \'Succeeded\' within 30 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the first 10 notifications stored in the transient tenant for the user with Id \'u" +
                        "ser100\' have the delivery status \'Delivered\' for the delivery channel with Id \'a" +
                        "pi\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the first 10 notifications stored in the transient tenant for the user with Id \'u" +
                        "ser100\' have the delivery status last updated set to within 60 seconds of now fo" +
                        "r the delivery channel with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the first 10 notifications stored in the transient tenant for the user with Id \'u" +
                        "ser100\' have the read status \'Unknown\' for the delivery channel with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the first 10 notifications stored in the transient tenant for the user with Id \'u" +
                        "ser100\' have the read status last updated set to within 60 seconds of now for th" +
                        "e delivery channel with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update delivery state of a subset of notifications for a user")]
        public virtual void UpdateDeliveryStateOfASubsetOfNotificationsForAUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update delivery state of a subset of notifications for a user", null, tagsOfScenario, argumentsOfScenario);
#line 20
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
#line 21
 testRunner.Given("I have created and stored 25 notifications in the current transient tenant with t" +
                        "imestamps at 30 second intervals for the user with Id \'user200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.And("I have created and stored 5 notifications in the current transient tenant with ti" +
                        "mestamps at 30 second intervals for the user with Id \'user201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("I have sent a management API request to batch update the delivery status of the f" +
                        "irst 10 stored notifications for user \'user200\' to \'Undelivered\' for the deliver" +
                        "y channel with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
    testRunner.And("I have waited for up to 30 seconds for the long running operation whose Url is in" +
                        " the response Location header to have a \'status\' of \'Succeeded\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.When("I send a management API request to batch update the delivery status of the first " +
                        "5 stored notifications for user \'user200\' to \'Delivered\' for the delivery channe" +
                        "l with Id \'api\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("the response status code should be \'Accepted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
    testRunner.And("the response should contain a \'Location\' header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
    testRunner.And("the long running operation whose Url is in the response Location header should no" +
                        "t have a \'status\' of \'NotStarted\' within 10 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.And("the long running operation whose Url is in the response Location header should ha" +
                        "ve a \'status\' of \'Succeeded\' within 30 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the first 5 notifications stored in the transient tenant for the user with Id \'us" +
                        "er200\' have the delivery status \'Delivered\' for the delivery channel with Id \'ap" +
                        "i\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion