// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ComparisonOptions.cs">
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
    /// Defines comparison options
    /// </summary>  
    public class ComparisonOptions 
    {                       
        /// <summary>
        /// Changes type. Used only for Changes resource(/comparison/changes)
        /// </summary>
        /// <value>Changes type. Used only for Changes resource(/comparison/changes)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangeTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Modified for "Modified"
            /// </summary>            
            Modified,
            
            /// <summary>
            /// Enum Inserted for "Inserted"
            /// </summary>            
            Inserted,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>            
            Deleted,
            
            /// <summary>
            /// Enum Added for "Added"
            /// </summary>            
            Added,
            
            /// <summary>
            /// Enum NotModified for "NotModified"
            /// </summary>            
            NotModified,
            
            /// <summary>
            /// Enum StyleChanged for "StyleChanged"
            /// </summary>            
            StyleChanged,
            
            /// <summary>
            /// Enum Resized for "Resized"
            /// </summary>            
            Resized,
            
            /// <summary>
            /// Enum Moved for "Moved"
            /// </summary>            
            Moved,
            
            /// <summary>
            /// Enum MovedAndResized for "MovedAndResized"
            /// </summary>            
            MovedAndResized,
            
            /// <summary>
            /// Enum ShiftedAndResized for "ShiftedAndResized"
            /// </summary>            
            ShiftedAndResized            
        }

        /// <summary>
        /// Changes type. Used only for Changes resource(/comparison/changes)
        /// </summary>
        public ChangeTypeEnum? ChangeType { get; set; }

        /// <summary>
        /// Information about source file
        /// </summary>  
        public FileInfo SourceFile { get; set; }

        /// <summary>
        /// Information about target file(s)
        /// </summary>  
        public List<FileInfo> TargetFiles { get; set; }

        /// <summary>
        /// Comparison settings
        /// </summary>  
        public Settings Settings { get; set; }

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
          sb.Append("class ComparisonOptions {\n");
          sb.Append("  SourceFile: ").Append(this.SourceFile).Append("\n");
          sb.Append("  TargetFiles: ").Append(this.TargetFiles).Append("\n");
          sb.Append("  Settings: ").Append(this.Settings).Append("\n");
          sb.Append("  ChangeType: ").Append(this.ChangeType).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
