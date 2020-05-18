//using GroupDocs.Comparison.Cloud.Sdk.Model;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
//using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace GroupDocs.Comparison.Cloud.Sdk.Test.Note
//{
//    public class CategoryChangesNoteTests : BaseApiTest
//    {
//        [Test]
//        public void CategoryNoteByType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryNoteByNodeType()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryNoteContainsNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryNoteOnlyNumbers()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNote, new List<TestFile>() { TestFiles.TargetNote });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryNoteByTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryNoteByNodeTypePasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
//            options.CategoryType = "ByTypeChanged";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(3, response.Count);
//        }

//        [Test]
//        public void CategoryNoteContainsNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
//            options.CategoryType = "ContainsNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }

//        [Test]
//        public void CategoryNoteOnlyNumbersPasswords()
//        {
//            ComparisonOptionsBase options = GetComparisonOptions(TestFiles.SourceNoteProtected, new List<TestFile>() { TestFiles.TargetNoteProtected });
//            options.CategoryType = "OnlyNumbers";
//            var response = comparisonApi.PostCategoryChanges(options);
//            Assert.AreEqual(1, response.Count);
//        }
//    }
//}
