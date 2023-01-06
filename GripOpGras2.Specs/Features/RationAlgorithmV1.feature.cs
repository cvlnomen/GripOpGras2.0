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
        public void CreateARationForAHerdWhenHavingTwoRoughageProducts()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
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
 testRunner.Given("I have the roughage product <roughage1> that contains <protein-roughage1> g prote" +
                        "in, and <vem-roughage1> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("I have the roughage product <roughage2> that contains <protein-roughage2> g prote" +
                        "in, and <vem-roughage2> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.And("I have a herd with <herd-size> cows in it, which have taken in <grass-intake> kg " +
                        "dm grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("each kg dm grass contains <vem-grass> VEM and <protein-grass> g protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("my herd has produced <lmilk-produced> liters of milk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
    testRunner.Then("the ration should contain between <dm-roughage-ration-min> and <dm-roughage-ratio" +
                        "n-max> kg dm of roughage products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
    testRunner.And("the ration should contain between <dm-supplementary-ration-min> and <dm-supplemen" +
                        "tary-ration-max> kg dm of supplementary products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And("the ration should contain between <protein-ration-min> and <protein-ration-max> g" +
                        " protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.And("the ration should contain between <vem-ration-min> and <vem-ration-max> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the ration must contain <grass-intake> kg of grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, when having three roughage products")]
        public void CreateARationForAHerdWhenHavingThreeRoughageProducts()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, when having three roughage products", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
 testRunner.Given("I have the roughage product <roughage1> that contains <protein-roughage1> g prote" +
                        "in, and <vem-roughage1> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.And("I have the roughage product <roughage2> that contains <protein-roughage2> g prote" +
                        "in, and <vem-roughage2> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("I have the roughage product <roughage3> that contains <protein-roughage3> g prote" +
                        "in, and <vem-roughage3> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("I have a herd with <herd-size> cows in it, which have taken in <grass-intake> kg " +
                        "dm grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("each kg dm grass contains <vem-grass> VEM and <protein-grass> g protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("my herd has produced <lmilk-produced> liters of milk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
    testRunner.Then("the ration should contain between <dm-roughage-ration-min> and <dm-roughage-ratio" +
                        "n-max> kg dm of roughage products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
    testRunner.And("the ration should contain between <protein-ration-min> and <protein-ration-max> g" +
                        " protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.And("the ration should contain between <vem-ration-min> and <vem-ration-max> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the ration must contain <grass-intake> kg of grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, when having two roughage products and three supplemen" +
            "tary product")]
        [NUnit.Framework.TestCaseAttribute("silo 1-2019", "161.56", "861.56", "maissilo 2018", "81.82", "959.39", "PERSPULP 24%", "95.24", "1037.62", "GEPLETTE TARWE", "117.14", "1219.29", "TARWE MEEL", "121.11", "1240", "59", "123.9", "903.81", "180", "25.4", "725.7", "806.58", "259.6", "309.41", "151925", "162053.33", "998870", "1098757", null)]
        public void CreateARationForAHerdWhenHavingTwoRoughageProductsAndThreeSupplementaryProduct(
                    string roughage1, 
                    string protein_Roughage1, 
                    string vem_Roughage1, 
                    string roughage2, 
                    string protein_Roughage2, 
                    string vem_Roughage2, 
                    string supplementary1, 
                    string protein_Supplementary1, 
                    string vem_Supplementary1, 
                    string supplementary2, 
                    string protein_Supplementary2, 
                    string vem_Supplementary2, 
                    string supplementary3, 
                    string protein_Supplementary3, 
                    string vem_Supplementary3, 
                    string herd_Size, 
                    string grass_Intake, 
                    string vem_Grass, 
                    string protein_Grass, 
                    string lmilk_Produced, 
                    string dm_Roughage_Ration_Min, 
                    string dm_Roughage_Ration_Max, 
                    string dm_Supplementary_Ration_Min, 
                    string dm_Supplementary_Ration_Max, 
                    string protein_Ration_Min, 
                    string protein_Ration_Max, 
                    string vem_Ration_Min, 
                    string vem_Ration_Max, 
                    string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("roughage1", roughage1);
            argumentsOfScenario.Add("protein-roughage1", protein_Roughage1);
            argumentsOfScenario.Add("vem-roughage1", vem_Roughage1);
            argumentsOfScenario.Add("roughage2", roughage2);
            argumentsOfScenario.Add("protein-roughage2", protein_Roughage2);
            argumentsOfScenario.Add("vem-roughage2", vem_Roughage2);
            argumentsOfScenario.Add("supplementary1", supplementary1);
            argumentsOfScenario.Add("protein-supplementary1", protein_Supplementary1);
            argumentsOfScenario.Add("vem-supplementary1", vem_Supplementary1);
            argumentsOfScenario.Add("supplementary2", supplementary2);
            argumentsOfScenario.Add("protein-supplementary2", protein_Supplementary2);
            argumentsOfScenario.Add("vem-supplementary2", vem_Supplementary2);
            argumentsOfScenario.Add("supplementary3", supplementary3);
            argumentsOfScenario.Add("protein-supplementary3", protein_Supplementary3);
            argumentsOfScenario.Add("vem-supplementary3", vem_Supplementary3);
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("grass-intake", grass_Intake);
            argumentsOfScenario.Add("vem-grass", vem_Grass);
            argumentsOfScenario.Add("protein-grass", protein_Grass);
            argumentsOfScenario.Add("lmilk-produced", lmilk_Produced);
            argumentsOfScenario.Add("dm-roughage-ration-min", dm_Roughage_Ration_Min);
            argumentsOfScenario.Add("dm-roughage-ration-max", dm_Roughage_Ration_Max);
            argumentsOfScenario.Add("dm-supplementary-ration-min", dm_Supplementary_Ration_Min);
            argumentsOfScenario.Add("dm-supplementary-ration-max", dm_Supplementary_Ration_Max);
            argumentsOfScenario.Add("protein-ration-min", protein_Ration_Min);
            argumentsOfScenario.Add("protein-ration-max", protein_Ration_Max);
            argumentsOfScenario.Add("vem-ration-min", vem_Ration_Min);
            argumentsOfScenario.Add("vem-ration-max", vem_Ration_Max);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, when having two roughage products and three supplemen" +
                    "tary product", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given(string.Format("I have the roughage product {0} that contains {1} g protein, and {2} VEM", roughage1, protein_Roughage1, vem_Roughage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.And(string.Format("I have the roughage product {0} that contains {1} g protein, and {2} VEM", roughage2, protein_Roughage2, vem_Roughage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And(string.Format("I have the supplementary product {0} that contains {1} g protein, and {2} VEM", supplementary1, protein_Supplementary1, vem_Supplementary1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And(string.Format("I have the supplementary product {0} that contains {1} g protein, and {2} VEM", supplementary2, protein_Supplementary2, vem_Supplementary2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And(string.Format("I have the supplementary product {0} that contains {1} g protein, and {2} VEM", supplementary3, protein_Supplementary3, vem_Supplementary3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And(string.Format("I have a herd with {0} cows in it, which have taken in {1} kg dm grass", herd_Size, grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And(string.Format("each kg dm grass contains {0} VEM and {1} g protein", vem_Grass, protein_Grass), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("my herd has produced {0} liters of milk", lmilk_Produced), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
    testRunner.Then(string.Format("the ration should contain between {0} and {1} kg dm of roughage products", dm_Roughage_Ration_Min, dm_Roughage_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
    testRunner.And(string.Format("the ration should contain between {0} and {1} kg dm of supplementary products", dm_Supplementary_Ration_Min, dm_Supplementary_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
    testRunner.And(string.Format("the ration should contain between {0} and {1} g protein", protein_Ration_Min, protein_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
    testRunner.And(string.Format("the ration should contain between {0} and {1} VEM", vem_Ration_Min, vem_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the ration must contain {0} kg of grass", grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, when having two roughage products and one supplementa" +
            "ry product")]
        public void CreateARationForAHerdWhenHavingTwoRoughageProductsAndOneSupplementaryProduct()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, when having two roughage products and one supplementa" +
                    "ry product", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 56
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 57
 testRunner.Given("I have the roughage product <roughage1> that contains <protein-roughage1> g prote" +
                        "in, and <vem-roughage1> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
 testRunner.And("I have the roughage product <roughage2> that contains <protein-roughage2> g prote" +
                        "in, and <vem-roughage2> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("I have the supplementary product <supplementary1> that contains <protein-suppleme" +
                        "ntary1> g protein, and <vem-supplementary1> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("I have a herd with <herd-size> cows in it, which have taken in <grass-intake> kg " +
                        "dm grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("each kg dm grass contains <vem-grass> VEM and <protein-grass> g protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("my herd has produced <lmilk-produced> liters of milk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
    testRunner.Then("the ration should contain between <dm-roughage-ration-min> and <dm-roughage-ratio" +
                        "n-max> kg dm of roughage products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
    testRunner.And("the ration should contain between <dm-supplementary-ration-min> and <dm-supplemen" +
                        "tary-ration-max> kg dm of supplementary products", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
    testRunner.And("the ration should contain between <protein-ration-min> and <protein-ration-max> g" +
                        " protein", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
    testRunner.And("the ration should contain between <vem-ration-min> and <vem-ration-max> VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the ration must contain <grass-intake> kg of grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd, without having any feed products")]
        [NUnit.Framework.TestCaseAttribute("200", "100", "1000", "200", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0", "10", "200", null)]
        [NUnit.Framework.TestCaseAttribute("100", "100", "0", "0", null)]
        public void CreateARationForAHerdWithoutHavingAnyFeedProducts(string herd_Size, string grass_Intake, string vem_Grass, string protein_Grass, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("grass-intake", grass_Intake);
            argumentsOfScenario.Add("vem-grass", vem_Grass);
            argumentsOfScenario.Add("protein-grass", protein_Grass);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd, without having any feed products", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 74
 testRunner.Given(string.Format("I have a herd with {0} cows in it, which have taken in {1} kg dm grass", herd_Size, grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 75
 testRunner.And(string.Format("each kg dm grass contains {0} VEM and {1} g protein", vem_Grass, protein_Grass), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then(string.Format("the ration must contain {0} kg of grass", grass_Intake), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd when haven\'t grazed today and having two roughage prod" +
            "ucts")]
        [NUnit.Framework.TestCaseAttribute("Kuil 1 2020 + 21 balen", "180", "907", "Maiskuil 2019", "58.3", "963", "62", "2002.6", "954.89", "1018.55", "143234.10", "162968.57", "1242170", "1366387", null)]
        public void CreateARationForAHerdWhenHaventGrazedTodayAndHavingTwoRoughageProducts(string roughage1, string protein_Roughage1, string vem_Roughage1, string roughage2, string protein_Roughage2, string vem_Roughage2, string herd_Size, string lmilk_Produced, string dm_Roughage_Ration_Min, string dm_Roughage_Ration_Max, string protein_Ration_Min, string protein_Ration_Max, string vem_Ration_Min, string vem_Ration_Max, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("roughage1", roughage1);
            argumentsOfScenario.Add("protein-roughage1", protein_Roughage1);
            argumentsOfScenario.Add("vem-roughage1", vem_Roughage1);
            argumentsOfScenario.Add("roughage2", roughage2);
            argumentsOfScenario.Add("protein-roughage2", protein_Roughage2);
            argumentsOfScenario.Add("vem-roughage2", vem_Roughage2);
            argumentsOfScenario.Add("herd-size", herd_Size);
            argumentsOfScenario.Add("lmilk-produced", lmilk_Produced);
            argumentsOfScenario.Add("dm-roughage-ration-min", dm_Roughage_Ration_Min);
            argumentsOfScenario.Add("dm-roughage-ration-max", dm_Roughage_Ration_Max);
            argumentsOfScenario.Add("protein-ration-min", protein_Ration_Min);
            argumentsOfScenario.Add("protein-ration-max", protein_Ration_Max);
            argumentsOfScenario.Add("vem-ration-min", vem_Ration_Min);
            argumentsOfScenario.Add("vem-ration-max", vem_Ration_Max);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd when haven\'t grazed today and having two roughage prod" +
                    "ucts", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 84
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 85
 testRunner.Given(string.Format("I have a herd with {0} cows in it", herd_Size), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 86
 testRunner.And(string.Format("my herd has produced {0} liters of milk", lmilk_Produced), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And(string.Format("I have the roughage product {0} that contains {1} g protein, and {2} VEM", roughage1, protein_Roughage1, vem_Roughage1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And(string.Format("I have the roughage product {0} that contains {1} g protein, and {2} VEM", roughage2, protein_Roughage2, vem_Roughage2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
    testRunner.Then(string.Format("the ration should contain between {0} and {1} kg dm of roughage products", dm_Roughage_Ration_Min, dm_Roughage_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
    testRunner.And(string.Format("the ration should contain between {0} and {1} g protein", protein_Ration_Min, protein_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
    testRunner.And(string.Format("the ration should contain between {0} and {1} VEM", vem_Ration_Min, vem_Ration_Max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("the ration must contain 0 kg of grass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a ration for a herd that doesnt contain any cows")]
        public void CreateARationForAHerdThatDoesntContainAnyCows()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a ration for a herd that doesnt contain any cows", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 99
 testRunner.Given("I have a herd with 0 cows in it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
 testRunner.And("I have the roughage product mais that contains 60 g protein, and 960 VEM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.When("I let Grip op Gras 2 create a ration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("an exception with the message \'The herd doesn\'t contain any cows\' should be throw" +
                        "n", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
