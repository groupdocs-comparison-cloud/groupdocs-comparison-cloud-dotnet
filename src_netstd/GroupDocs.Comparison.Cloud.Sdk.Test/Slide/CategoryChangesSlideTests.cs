//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Slide
//{
//    public class CategoryChangesSlideTests : BaseApiTest
//    {
//        [Test]
//        public void CategorySlideByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByTypeMulti()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlide,
//                    TestFiles.TargetSlide1,
//                    TestFiles.TargetSlide2
//                });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByTypeChangedMultiPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlideProtected,
//                    TestFiles.TargetSlide1Protected,
//                    TestFiles.TargetSlide2Protected
//                });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategorySlideByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByNodeTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByNodeTypeCMulti()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(
//                TestFiles.SourceSlide,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlide,
//                    TestFiles.TargetSlide1,
//                    TestFiles.TargetSlide2
//                });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(5, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideByNodeTypeMultiPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlideProtected,
//                    TestFiles.TargetSlide1Protected,
//                    TestFiles.TargetSlide2Protected
//                });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategorySlideContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideContainsNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideContainsNumbersCMulti()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlide,
//                    TestFiles.TargetSlide1,
//                    TestFiles.TargetSlide2
//                });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideContainsNumbersMultiPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlideProtected,
//                    TestFiles.TargetSlide1Protected,
//                    TestFiles.TargetSlide2Protected
//                });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategorySlideOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide, new List<TestFile>() { TestFiles.TargetSlide });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideOnlyNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected, new List<TestFile>() { TestFiles.TargetSlideProtected });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideOnlyNumbersCMulti()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlide,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlide,
//                    TestFiles.TargetSlide1,
//                    TestFiles.TargetSlide2
//                });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test, Ignore("Fixed in Comparison 19.4")]
//        public void CategorySlideOnlyNumbersMultiPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceSlideProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetSlideProtected,
//                    TestFiles.TargetSlide1Protected,
//                    TestFiles.TargetSlide2Protected
//                });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
