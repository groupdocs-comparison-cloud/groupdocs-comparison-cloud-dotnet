// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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

using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Api
{
    public class InfoApiTests : BaseApiTest
    {
        [Test]
        public void GetSupportedFileFormatsTest()
        {
            var response = InfoApi.GetSupportedFileFormats();

            Assert.IsTrue(response.Formats.Count > 0);
            foreach (var entry in response.Formats)
            {
                Assert.IsNotEmpty(entry.Extension);
                Assert.IsNotEmpty(entry.FileFormat);
            }
        }

        [Test]
        public void TestGetInfoReturnsMissingFileInfo()
        {
            // Arrange
            var request = new GetDocumentInfoRequest();

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetDocumentInfo(request);
            });

            Assert.AreEqual("Missing required parameter 'fileInfo' when calling GetDocumentInfo", ex.Message);
        }

        [Test]
        public void TestGetInfoReturnsFileNotFound()
        {
            // Arrange
            var request = new GetDocumentInfoRequest(TestFiles.NotExist.ToFileInfo());

            // Act & Assert
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetDocumentInfo(request);
            });
            Assert.AreEqual("Can't find file located at 'some-folder\\NotExist.docx'.", ex.Message);
        }

        [Test]
        public void TestGetInfo()
        {
            // Arrange
            var request = new GetDocumentInfoRequest(TestFiles.SourceWord.ToFileInfo());

            // Act & Assert
            var infoResult = InfoApi.GetDocumentInfo(request);

            Assert.AreEqual(1, infoResult.PageCount);
        }
    }
}
