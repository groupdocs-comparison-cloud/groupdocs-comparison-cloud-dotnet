//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Word
//{
//    public class CategoryChangesWordTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryWordByType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile>() { TestFiles.TargetWord });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryWordByTypePasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected,new List<TestFile>() { TestFiles.TargetWordProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryWordByTypeMulti()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWord,
//                    TestFiles.TargetWord1,
//                    TestFiles.TargetWord2
//                });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryWordByTypeChangedMultiPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWordProtected,
//                    TestFiles.TargetWord1Protected,
//                    TestFiles.TargetWord2Protected
//                });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryWordByNodeType()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile>() { TestFiles.TargetWord });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(4, response.Count);
//        }

//        [Test]
//        public void CategoryWordByNodeTypePasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected, new List<TestFile>() { TestFiles.TargetWordProtected });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryWordByNodeTypeCMulti()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWord,
//                    TestFiles.TargetWord1,
//                    TestFiles.TargetWord2
//                });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(5, response.Count);
//        }

//        [Test]
//        public void CategoryWordByNodeTypeMultiPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWordProtected,
//                    TestFiles.TargetWord1Protected,
//                    TestFiles.TargetWord2Protected
//                });
//            options.CategoryType = "ByNodeType";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(2, response.Count);
//        }

//        [Test]
//        public void CategoryWordContainsNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile>() { TestFiles.TargetWord });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordContainsNumbersPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected, new List<TestFile>() { TestFiles.TargetWordProtected });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordContainsNumbersCMulti()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile>()
//                {
//                    TestFiles.TargetWord,
//                    TestFiles.TargetWord1,
//                    TestFiles.TargetWord2
//                });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordContainsNumbersMultiPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWordProtected,
//                    TestFiles.TargetWord1Protected,
//                    TestFiles.TargetWord2Protected
//                });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordOnlyNumbers()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord, new List<TestFile>() { TestFiles.TargetWord });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordOnlyNumbersPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected, new List<TestFile>() { TestFiles.TargetWordProtected });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordOnlyNumbersCMulti()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWord,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWord,
//                    TestFiles.TargetWord1,
//                    TestFiles.TargetWord2
//                });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryWordOnlyNumbersMultiPasswords()
//        {
//            ComparisonOptions options = GetComparisonOptions(TestFiles.SourceWordProtected,
//                new List<TestFile>()
//                {
//                    TestFiles.TargetWordProtected,
//                    TestFiles.TargetWord1Protected,
//                    TestFiles.TargetWord2Protected
//                });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
