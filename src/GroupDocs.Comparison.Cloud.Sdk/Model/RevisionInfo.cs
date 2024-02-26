// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RevisionInfo.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Provides information about one revision.
    /// </summary>  
    public class RevisionInfo 
    {                       
        /// <summary>
        /// Action (accept or reject). This field allows you to influence the display of the revision.             
        /// </summary>
        /// <value>Action (accept or reject). This field allows you to influence the display of the revision.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Accept for "Accept"
            /// </summary>            
            Accept,
            
            /// <summary>
            /// Enum Reject for "Reject"
            /// </summary>            
            Reject            
        }

        /// <summary>
        /// RevisionHandler type, depending on the type the Action (accept or reject) logic changes.             
        /// </summary>
        /// <value>RevisionHandler type, depending on the type the Action (accept or reject) logic changes.             </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum Insertion for "Insertion"
            /// </summary>            
            Insertion,
            
            /// <summary>
            /// Enum Deletion for "Deletion"
            /// </summary>            
            Deletion,
            
            /// <summary>
            /// Enum FormatChange for "FormatChange"
            /// </summary>            
            FormatChange,
            
            /// <summary>
            /// Enum StyleDefinitionChange for "StyleDefinitionChange"
            /// </summary>            
            StyleDefinitionChange,
            
            /// <summary>
            /// Enum Moving for "Moving"
            /// </summary>            
            Moving            
        }

        /// <summary>
        /// Action (accept or reject). This field allows you to influence the display of the revision.             
        /// </summary>
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// RevisionHandler type, depending on the type the Action (accept or reject) logic changes.             
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Id of revision
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// The text that is in revision.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Author.
        /// </summary>  
        public string Author { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RevisionInfo {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Action: ").Append(this.Action).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Author: ").Append(this.Author).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
