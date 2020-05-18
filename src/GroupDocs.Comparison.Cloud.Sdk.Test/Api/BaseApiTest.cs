// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using FileInfo = GroupDocs.Comparison.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api
{
    public class BaseApiTest
    {
        private readonly string _appSid = Config.AppSid;
        private readonly string _appKey = Config.AppKey;
        private readonly string _apiBaseUrl = Config.ApiBaseUrl;

        protected CompareApi CompareApi;
        protected InfoApi InfoApi;
        protected FileApi FileApi;
        protected FolderApi FolderApi;
        protected StorageApi StorageApi;

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            var config = new Configuration(_appSid, _appKey)
            {
                ApiBaseUrl = _apiBaseUrl
            };

            CompareApi = new CompareApi(config);
            InfoApi = new InfoApi(config);
            FileApi = new FileApi(config);
            FolderApi = new FolderApi(config);
            StorageApi = new StorageApi(config);

            UploadTestFiles();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Cleanup();
        }

        private void UploadTestFiles()
        {
            foreach (var testFile in TestFiles.TestFilesList)
            {
                var existRequest = new ObjectExistsRequest(testFile.FullName);
                var existResponse = StorageApi.ObjectExists(existRequest);
                if (existResponse.Exists == true) continue;
                var request = new UploadFileRequest(testFile.FullName, GetTestFileStream(testFile));
                FileApi.UploadFile(request);
            }
        }

        private void Cleanup()
        {
            DeleteFolderFromStorage("comparison");
        }

        private void DeleteFolderFromStorage(string folderName)
        {
            var request = new DeleteFolderRequest(folderName, null, true);
            FolderApi.DeleteFolder(request);
        }

        private byte[] GetTestFileBytes(TestFile file)
        {
            var filePath = Path.Combine(GetTestDataPath(), file.Folder, file.FileName);
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found: " + filePath);
            }

            return File.ReadAllBytes(filePath);
        }

        protected Stream GetTestFileStream(TestFile file)
        {
            var bytes = GetTestFileBytes(file);

            return new MemoryStream(bytes);
        }

        protected Stream SerializeObject(object obj)
        {
            var options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(obj, options);

            var bytes = Encoding.UTF8.GetBytes(json);

            return new MemoryStream(bytes);
        }

        private static string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath) ?? Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "Resources", "TestData");

            return Path.GetFullPath(baseDir);
        }

        protected Options GetComparisonOptions(TestFile sourceFile, List<TestFile> targetFiles)
        {
            var options = new Options()
            {
                SourceFile = sourceFile.ToFileInfo(),
                OutputPath = "/resultFilePath/" + sourceFile.FileName,
                Settings = new Settings
                {
                    GenerateSummaryPage = true,
                    ShowDeletedContent = true,
                    StyleChangeDetection = true,
                    UseFramesForDelInsElements = false,
                    MetaData = null,
                    DetailLevel = "Low",
                    DiagramMasterSetting = null,
                    CalculateComponentCoordinates = false,
                    CloneMetadata = "Default",
                    MarkDeletedInsertedContentDeep = false,
                    Password = "1111",
                    PasswordSaveOption = "User",
                    DeletedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "16711680",
                        HighlightColor = "16711680",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                    InsertedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "255",
                        HighlightColor = "255",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                    StyleChangedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "65280",
                        HighlightColor = "65280",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                },

            };

            var targets = new List<FileInfo>();
            foreach (var targetFile in targetFiles)
                targets.Add(targetFile.ToFileInfo());
            options.TargetFiles = targets.ToList();

            return options;
        }

        protected UpdatesOptions GetComparisonOptionsUpdates(TestFile sourceFile, List<TestFile> targetFiles)
        {
            var options = new UpdatesOptions()
            {
                SourceFile = sourceFile.ToFileInfo(),
                OutputPath = "/resultFilePath/" + sourceFile.FileName,
                Settings = new Settings
                {
                    GenerateSummaryPage = true,
                    ShowDeletedContent = true,
                    StyleChangeDetection = true,
                    UseFramesForDelInsElements = false,
                    MetaData = null,
                    DetailLevel = "Low",
                    DiagramMasterSetting = null,
                    CalculateComponentCoordinates = false,
                    CloneMetadata = "Default",
                    MarkDeletedInsertedContentDeep = false,
                    Password = "1111",
                    PasswordSaveOption = "User",
                    DeletedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "16711680",
                        HighlightColor = "16711680",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                    InsertedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "255",
                        HighlightColor = "255",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                    StyleChangedItemsStyle = new ItemsStyle
                    {
                        BeginSeparatorString = "",
                        EndSeparatorString = "",
                        FontColor = "65280",
                        HighlightColor = "65280",
                        Bold = false,
                        Italic = false,
                        StrikeThrough = false
                    },
                },

            };

            var targets = new List<FileInfo>();
            foreach (var targetFile in targetFiles)
                targets.Add(targetFile.ToFileInfo());
            options.TargetFiles = targets.ToList();


            var changes = new List<ChangeInfo>
            {
                new ChangeInfo {Id = 0, ComparisonAction = "Accept"},
                new ChangeInfo {Id = 1, ComparisonAction = "Reject"}
            };
            options.Changes = changes.ToList();

            return options;
        }
    }
}
