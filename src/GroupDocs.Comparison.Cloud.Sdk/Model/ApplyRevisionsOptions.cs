// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ApplyRevisionsOptions.cs">
//  Copyright (c) Aspose Pty Ltd
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

namespace GroupDocs.Comparison.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Options for apply revisions method
    /// </summary>  
    public class ApplyRevisionsOptions 
    {                       
        /// <summary>
        /// Information about source file
        /// </summary>  
        public FileInfo SourceFile { get; set; }

        /// <summary>
        /// Revisions to apply or reject.
        /// </summary>  
        public List<RevisionInfo> Revisions { get; set; }

        /// <summary>
        /// Indicates whether to apply all revisions in the document
        /// </summary>  
        public bool? AcceptAll { get; set; }

        /// <summary>
        /// Indicates whether to reject all revisions in the document
        /// </summary>  
        public bool? RejectAll { get; set; }

        /// <summary>
        /// Path to the resultant document (if not specified the document will not be saved)
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ApplyRevisionsOptions {\n");
          sb.Append("  SourceFile: ").Append(this.SourceFile).Append("\n");
          sb.Append("  Revisions: ").Append(this.Revisions).Append("\n");
          sb.Append("  AcceptAll: ").Append(this.AcceptAll).Append("\n");
          sb.Append("  RejectAll: ").Append(this.RejectAll).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
