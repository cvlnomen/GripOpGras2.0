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
namespace GripOpGras2.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GripOpGras2.RationAlgorithmV1")]
    public partial class GripOpGras2_RationAlgorithmV1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "RationAlgorithmV1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "GripOpGras2.RationAlgorithmV1", "The first approach devised to create a ration for a herd", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, when having two roughage products")]
        [NUnit.Framework.TestCaseAttribute("120", "720", "1000", "200", "27.14285713", "Graskuil", "320", "149", "857", "Maïskuil", "352", "57", "938", "1300", "900", null)]
        public void CreateARationForAHerdWhenHavingTwoRoughageProducts(
                    string herd_Size, 
                    string grass_Intake, 
                    string vem_Grass, 
                    string protein_Grass, 
                    string lmilk_Produced, 
                    string roaghage1, 
                    string dm_Roaghage1, 
                    string re_Roaghage1, 
                    string vem_Roaghage1, 
                    string roaghage2, 
                    string dm_Roaghage2, 
                    string re_Roaghage2, 
                    string vem_Roaghage2, 
                    string kg_Roaghage1, 
                    string kg_Roaghage2, 
                    string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("grass-intake", grass_Intake);
            argumentsOfScenario.Add("vem-grass", vem_Grass);
            argumentsOfScenario.Add("protein-grass", protein_Grass);
            argumentsOfScenario.Add("lmilk-produced", lmilk_Produced);
            argumentsOfScenario.Add("roaghage1", roaghage1);
            argumentsOfScenario.Add("dm-roaghage1", dm_Roaghage1);
            argumentsOfScenario.Add("re-roaghage1", re_Roaghage1);
            argumentsOfScenario.Add("vem-roaghage1", vem_Roaghage1);
            argumentsOfScenario.Add("roaghage2", roaghage2);
            argumentsOfScenario.Add("dm-roaghage2", dm_Roaghage2);
            argumentsOfScenario.Add("re-roaghage2", re_Roaghage2);
            argumentsOfScenario.Add("vem-roaghage2", vem_Roaghage2);
            argumentsOfScenario.Add("kg-roaghage1", kg_Roaghage1);
            argumentsOfScenario.Add("kg-roaghage2", kg_Roaghage2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, when having two roughage products", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage1, dm_Roaghage1, re_Roaghage1, vem_Roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage2, dm_Roaghage2, re_Roaghage2, vem_Roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.And(string.Format("I have a herd with {0} cows in it, which have taken in {1} kg dm grass", herd_Size, grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And(string.Format("each kg dm grass contains {0} VEM and {1} g protein", vem_Grass, protein_Grass), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("my herd has produced {0} liters of milk", lmilk_Produced), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage1, roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.And(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage2, roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the ration must contain {0} kg of grass", grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, when having three roughage products")]
        [NUnit.Framework.TestCaseAttribute("120", "720", "1000", "200", "27.14285713", "Graskuil", "320", "149", "857", "Maïskuil", "352", "57", "938", "Maïskuil", "352", "57", "938", "1300", "900", "900", null)]
        public void CreateARationForAHerdWhenHavingThreeRoughageProducts(
                    string herd_Size, 
                    string grass_Intake, 
                    string vem_Grass, 
                    string protein_Grass, 
                    string lmilk_Produced, 
                    string roaghage1, 
                    string dm_Roaghage1, 
                    string re_Roaghage1, 
                    string vem_Roaghage1, 
                    string roaghage2, 
                    string dm_Roaghage2, 
                    string re_Roaghage2, 
                    string vem_Roaghage2, 
                    string roaghage3, 
                    string dm_Roaghage3, 
                    string re_Roaghage3, 
                    string vem_Roaghage3, 
                    string kg_Roaghage1, 
                    string kg_Roaghage2, 
                    string kg_Roaghage3, 
                    string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("grass-intake", grass_Intake);
            argumentsOfScenario.Add("vem-grass", vem_Grass);
            argumentsOfScenario.Add("protein-grass", protein_Grass);
            argumentsOfScenario.Add("lmilk-produced", lmilk_Produced);
            argumentsOfScenario.Add("roaghage1", roaghage1);
            argumentsOfScenario.Add("dm-roaghage1", dm_Roaghage1);
            argumentsOfScenario.Add("re-roaghage1", re_Roaghage1);
            argumentsOfScenario.Add("vem-roaghage1", vem_Roaghage1);
            argumentsOfScenario.Add("roaghage2", roaghage2);
            argumentsOfScenario.Add("dm-roaghage2", dm_Roaghage2);
            argumentsOfScenario.Add("re-roaghage2", re_Roaghage2);
            argumentsOfScenario.Add("vem-roaghage2", vem_Roaghage2);
            argumentsOfScenario.Add("roaghage3", roaghage3);
            argumentsOfScenario.Add("dm-roaghage3", dm_Roaghage3);
            argumentsOfScenario.Add("re-roaghage3", re_Roaghage3);
            argumentsOfScenario.Add("vem-roaghage3", vem_Roaghage3);
            argumentsOfScenario.Add("kg-roaghage1", kg_Roaghage1);
            argumentsOfScenario.Add("kg-roaghage2", kg_Roaghage2);
            argumentsOfScenario.Add("kg-roaghage3", kg_Roaghage3);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, when having three roughage products", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage1, dm_Roaghage1, re_Roaghage1, vem_Roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.And(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage2, dm_Roaghage2, re_Roaghage2, vem_Roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage3, dm_Roaghage3, re_Roaghage3, vem_Roaghage3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("I have a herd with {0} cows in it, which have taken in {1} kg dm grass", herd_Size, grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("each kg dm grass contains {0} VEM and {1} g protein", vem_Grass, protein_Grass), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And(string.Format("my herd has produced {0} liters of milk", lmilk_Produced), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage1, roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.And(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage2, roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage3, roaghage3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("the ration must contain {0} kg of grass", grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, without having any roughage products")]
        [NUnit.Framework.TestCaseAttribute("200", "100", "1000", "200", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0", "10", "200", null)]
        [NUnit.Framework.TestCaseAttribute("100", "100", "0", "0", null)]
        public void CreateARationForAHerdWithoutHavingAnyRoughageProducts(string herd_Size, string grass_Intake, string vem_Grass, string protein_Grass, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("grass-intake", grass_Intake);
            argumentsOfScenario.Add("vem-grass", vem_Grass);
            argumentsOfScenario.Add("protein-grass", protein_Grass);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, without having any roughage products", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
 testRunner.Given(string.Format("I have a herd with {0} cows in it, which have taken in {1} kg dm grass", herd_Size, grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.And(string.Format("each kg dm grass contains {0} VEM and {1} g protein", vem_Grass, protein_Grass), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then(string.Format("the ration must contain {0} kg of grass", grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd when haven\'t grazed today and having two roughage prod" +
            "ucts")]
        [NUnit.Framework.TestCaseAttribute("120", "Graskuil", "320", "149", "857", "Maïskuil", "352", "57", "938", "1300", "900", null)]
        public void CreateARationForAHerdWhenHaventGrazedTodayAndHavingTwoRoughageProducts(string herd_Size, string roaghage1, string dm_Roaghage1, string re_Roaghage1, string vem_Roaghage1, string roaghage2, string dm_Roaghage2, string re_Roaghage2, string vem_Roaghage2, string kg_Roaghage1, string kg_Roaghage2, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("roaghage1", roaghage1);
            argumentsOfScenario.Add("dm-roaghage1", dm_Roaghage1);
            argumentsOfScenario.Add("re-roaghage1", re_Roaghage1);
            argumentsOfScenario.Add("vem-roaghage1", vem_Roaghage1);
            argumentsOfScenario.Add("roaghage2", roaghage2);
            argumentsOfScenario.Add("dm-roaghage2", dm_Roaghage2);
            argumentsOfScenario.Add("re-roaghage2", re_Roaghage2);
            argumentsOfScenario.Add("vem-roaghage2", vem_Roaghage2);
            argumentsOfScenario.Add("kg-roaghage1", kg_Roaghage1);
            argumentsOfScenario.Add("kg-roaghage2", kg_Roaghage2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd when haven\'t grazed today and having two roughage prod" +
                    "ucts", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given(string.Format("I have a herd with {0} cows in it", herd_Size), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
 testRunner.And(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage1, dm_Roaghage1, re_Roaghage1, vem_Roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("I have {0} that contains {1} kg dm, {2} g protein, and {3} VEM", roaghage2, dm_Roaghage2, re_Roaghage2, vem_Roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage1, roaghage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.And(string.Format("the ration should contain {0} kg dm of {1}", kg_Roaghage2, roaghage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the ration must contain 0 kg of grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
