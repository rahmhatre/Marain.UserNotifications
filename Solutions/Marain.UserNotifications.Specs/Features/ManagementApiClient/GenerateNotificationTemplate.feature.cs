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
namespace Marain.UserNotifications.Specs.Features.ManagementApiClient
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Generate Notification Template via the client library")]
    [NUnit.Framework.CategoryAttribute("perFeatureContainer")]
    [NUnit.Framework.CategoryAttribute("useApis")]
    [NUnit.Framework.CategoryAttribute("useTransientTenant")]
    public partial class GenerateNotificationTemplateViaTheClientLibraryFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "perFeatureContainer",
                "useApis",
                "useTransientTenant"};
        
#line 1 "GenerateNotificationTemplate.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/ManagementApiClient", "Generate Notification Template via the client library", null, ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("Generate a web push Notification Template")]
        public virtual void GenerateAWebPushNotificationTemplate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate a web push Notification Template", null, tagsOfScenario, argumentsOfScenario);
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
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "title",
                            "contentType",
                            "image",
                            "notificationType"});
                table10.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "A new lead added: {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1",
                            "Base+64xddfa",
                            "marain.NewLeadv1"});
#line 7
 testRunner.Given("I have created and stored a web push notification template", ((string)(null)), table10, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "userId",
                            "email",
                            "phoneNumber",
                            "communicationChannelsPerNotificationConfiguration"});
                table11.AddRow(new string[] {
                            "1",
                            "test@test.com",
                            "041532211",
                            "{\"marain.NewLeadv1\": [\"webpush\", \"sms\"]}"});
#line 10
 testRunner.And("I have created and stored a user preference for a user", ((string)(null)), table11, "And ");
#line hidden
#line 13
 testRunner.When("I use the client to send a generate template API request", @"      {
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
#line 27
 testRunner.Then("the client response status code should be \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.And("the client response for the notification template property \'SmsTemplate\' should b" +
                        "e null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the client response for the notification template property \'WebPushTemplate\' shou" +
                        "ld not be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the client response for the object \'WebPushTemplate\' with property \'Body\' should " +
                        "have a value of \'A new lead was added by TestUser123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("the client response for the object \'WebPushTemplate\' with property \'Title\' should" +
                        " have a value of \'A new lead added: TestUser123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate a web push, sms and email Notification Template")]
        public virtual void GenerateAWebPushSmsAndEmailNotificationTemplate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate a web push, sms and email Notification Template", null, tagsOfScenario, argumentsOfScenario);
#line 33
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
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "title",
                            "contentType",
                            "image",
                            "notificationType"});
                table12.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "You have a {{mortgageType}} case",
                            "application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1",
                            "Base+64xddfa",
                            "marain.NewLeadv2"});
#line 34
 testRunner.Given("I have created and stored a web push notification template", ((string)(null)), table12, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "contentType",
                            "notificationType"});
                table13.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.smstemplate.v1",
                            "marain.NewLeadv2"});
#line 37
 testRunner.And("I have created and stored a sms notification template", ((string)(null)), table13, "And ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "subject",
                            "important",
                            "contentType",
                            "image",
                            "notificationType"});
                table14.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}} with Mortgage Type: {{mortgageType}}",
                            "New lead {{leadAddedBy}}",
                            "true",
                            "application/vnd.marain.usernotifications.notificationtemplate.emailtemplate.v1",
                            "Base+64xddfa",
                            "marain.NewLeadv2"});
#line 40
 testRunner.And("I have created and stored an email notification template", ((string)(null)), table14, "And ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "userId",
                            "email",
                            "phoneNumber",
                            "communicationChannelsPerNotificationConfiguration"});
                table15.AddRow(new string[] {
                            "2",
                            "test@test.com",
                            "041532211",
                            "{\"marain.NewLeadv2\": [\"webpush\", \"sms\", \"email\"]}"});
#line 43
 testRunner.And("I have created and stored a user preference for a user", ((string)(null)), table15, "And ");
#line hidden
#line 46
 testRunner.When("I use the client to send a generate template API request", @"      {
          ""notificationType"": ""marain.NewLeadv2"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""2""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""leadAddedBy"": ""TestUser123"",
              ""mortgageType"": ""First time buyer""
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("the client response status code should be \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.And("the client response for the notification template property \'WebPushTemplate\' shou" +
                        "ld not be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("the client response for the notification template property \'SmsTemplate\' should n" +
                        "ot be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("the client response for the notification template property \'EmailTemplate\' should" +
                        " not be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the client response for the object \'WebPushTemplate\' with property \'Body\' should " +
                        "have a value of \'A new lead was added by TestUser123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the client response for the object \'WebPushTemplate\' with property \'Title\' should" +
                        " have a value of \'You have a First time buyer case\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("the client response for the object \'WebPushTemplate\' with property \'Image\' should" +
                        " have a value of \'Base+64xddfa\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the client response for the object \'SmsTemplate\' with property \'Body\' should have" +
                        " a value of \'A new lead was added by TestUser123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the client response for the object \'EmailTemplate\' with property \'Body\' should ha" +
                        "ve a value of \'A new lead was added by TestUser123 with Mortgage Type: First tim" +
                        "e buyer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("the client response for the object \'EmailTemplate\' with property \'Subject\' should" +
                        " have a value of \'New lead TestUser123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generation of a Notification Template is UnSuccessful")]
        public virtual void GenerationOfANotificationTemplateIsUnSuccessful()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generation of a Notification Template is UnSuccessful", null, tagsOfScenario, argumentsOfScenario);
#line 72
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
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "userId",
                            "email",
                            "phoneNumber",
                            "communicationChannelsPerNotificationConfiguration"});
                table16.AddRow(new string[] {
                            "3",
                            "test@test.com",
                            "041532211",
                            "{\"marain.notifications.test.v1\": [\"webpush\"]}"});
#line 76
 testRunner.And("I have created and stored a user preference for a user", ((string)(null)), table16, "And ");
#line hidden
#line 79
 testRunner.When("I use the client to send a generate template API request", @"      {
          ""notificationType"": ""marain.notifications.test.v1"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""3""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""leadAddedBy"": ""TestUser123"",
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.Then("the client response status code should be \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.And("the client response for the notification template property \'WebPushTemplate\' shou" +
                        "ld be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("the client response for the notification template property \'SmsTemplate\' should b" +
                        "e null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate a notification template for unconfigured user")]
        public virtual void GenerateANotificationTemplateForUnconfiguredUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate a notification template for unconfigured user", null, tagsOfScenario, argumentsOfScenario);
#line 97
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
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "body",
                            "title",
                            "contentType",
                            "image",
                            "notificationType"});
                table17.AddRow(new string[] {
                            "A new lead was added by {{leadAddedBy}}",
                            "A new lead added: {{leadAddedBy}}",
                            "application/vnd.marain.usernotifications.notificationtemplate.webpushtemplate.v1",
                            "Base+64xddfa",
                            "marain.NewLeadv1"});
#line 98
 testRunner.Given("I have created and stored a web push notification template", ((string)(null)), table17, "Given ");
#line hidden
#line 101
 testRunner.When("I use the client to send a generate template API request", @"      {
          ""notificationType"": ""marain.notifications.test.v1"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""3""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""leadAddedBy"": ""TestUser123"",
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.Then("a \'UserNotificationsApiException\' should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generate a notification template for unconfigured communication channel")]
        public virtual void GenerateANotificationTemplateForUnconfiguredCommunicationChannel()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate a notification template for unconfigured communication channel", null, tagsOfScenario, argumentsOfScenario);
#line 117
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
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "userId",
                            "email",
                            "phoneNumber",
                            "communicationChannelsPerNotificationConfiguration"});
                table18.AddRow(new string[] {
                            "4",
                            "test@test.com",
                            "041532211",
                            "{\"marain.notifications.test.v2\": [\"webpush\"]}"});
#line 118
 testRunner.Given("I have created and stored a user preference for a user", ((string)(null)), table18, "Given ");
#line hidden
#line 121
 testRunner.When("I use the client to send a generate template API request", @"      {
          ""notificationType"": ""marain.notifications.test.v2"",
          ""timestamp"": ""2020-07-21T17:32:28Z"",
          ""userIds"": [
              ""4""
          ],
          ""correlationIds"": [""cid1"", ""cid2""],
          ""properties"": {
              ""leadAddedBy"": ""TestUser123"",
          }
      }", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 135
 testRunner.Then("the client response for the notification template property \'WebPushTemplate\' shou" +
                        "ld be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.And("the client response for the notification template property \'SmsTemplate\' should b" +
                        "e null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.And("the client response for the notification template property \'EmailTemplate\' should" +
                        " be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
