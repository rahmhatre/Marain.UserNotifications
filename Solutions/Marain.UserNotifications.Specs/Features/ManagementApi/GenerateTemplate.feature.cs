﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Generate Template")]
    [NUnit.Framework.CategoryAttribute("perFeatureContainer")]
    [NUnit.Framework.CategoryAttribute("useApis")]
    [NUnit.Framework.CategoryAttribute("useTransientTenant")]
    public partial class GenerateTemplateFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "perFeatureContainer",
                "useApis",
                "useTransientTenant"};
        
#line 1 "GenerateTemplate.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/ManagementApi", "Generate Template", null, ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("Generate populated template")]
        public virtual void GeneratePopulatedTemplate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate populated template", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
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
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "subject",
                            "contentType",
                            "image",
                            "notificationType"});
                table19.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "A new lead added: {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.emailtemplate.v1",
                            "Base+64xddfa",
                            "marain.NewLeadv1"});
#line 7
 testRunner.Given("I have created and stored an email notification template", ((string)(null)), table19, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "contentType",
                            "notificationType"});
                table20.AddRow(new string[] {
                            "New lead added by {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.smstemplate.v1",
                            "marain.NewLeadv1"});
#line 10
 testRunner.And("I have created and stored a sms notification template", ((string)(null)), table20, "And ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "title",
                            "contentType",
                            "actionUrl",
                            "image",
                            "notificationType"});
                table21.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "A new lead added: {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1",
                            "https://www.google.co.uk/",
                            "Base+64xddfa",
                            "marain.NewLeadv1"});
#line 13
 testRunner.And("I have created and stored a web push notification template", ((string)(null)), table21, "And ");
#line hidden
#line 16
 testRunner.When("I send the generate template API request", @"      {
          ""notificationType"": ""marain.NewLeadv1"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""1""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""leadAddedBy"": ""TestUser123"",
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("the response status code should be \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.And("the response content should have a string property called \'notificationType\' with" +
                        " value \'marain.NewLeadv1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(@"the response content should have a json property called 'smsTemplate' with value '{ ""notificationType"": ""marain.NewLeadv1"", ""body"": ""New lead added by TestUser123"", ""contentType"": ""application/vnd.marain.usernotifications.notificationtemplate.smstemplate.v1"" }'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(@"the response content should have a json property called 'emailTemplate' with value '{ ""notificationType"": ""marain.NewLeadv1"", ""body"": ""A new lead was added by TestUser123"", ""subject"": ""A new lead added: TestUser123"", ""contentType"": ""application/vnd.marain.usernotifications.notificationtemplate.emailtemplate.v1"" }'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And(@"the response content should have a json property called 'webPushTemplate' with value '{ ""notificationType"": ""marain.NewLeadv1"", ""body"": ""A new lead was added by TestUser123"", ""title"": ""A new lead added: TestUser123"", ""image"": ""Base+64xddfa"", ""actionUrl"": ""https://www.google.co.uk/"", ""contentType"": ""application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1"" }'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate populated template having nested objects in the property bag")]
        public virtual void GeneratePopulatedTemplateHavingNestedObjectsInThePropertyBag()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate populated template having nested objects in the property bag", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 36
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
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "title",
                            "contentType",
                            "actionUrl",
                            "image",
                            "notificationType"});
                table22.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "A new lead added: {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1",
                            "https://www.google.co.uk/",
                            "Base+64xddfa",
                            "marain.NewLeadv2"});
#line 37
 testRunner.Given("I have created and stored a web push notification template", ((string)(null)), table22, "Given ");
#line hidden
#line 40
 testRunner.When("I send the generate template API request", @"      {
          ""notificationType"": ""marain.NewLeadv2"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""1""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""lead"": {
			""leadAddedBy"": ""TestUser123"",
		}
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("the response status code should be \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And(@"the response content should have a json property called 'webPushTemplate' with value '{ ""notificationType"": ""marain.NewLeadv2"", ""body"": ""A new lead was added by TestUser123"", ""title"": ""A new lead added: TestUser123"", ""image"": ""Base+64xddfa"", ""actionUrl"": ""https://www.google.co.uk/"", ""contentType"": ""application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1"" }'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
