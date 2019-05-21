// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ItemsStyle.cs">
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Comparison.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Comparison.Cloud.Sdk.Model
{
    /// <summary>
    /// ItemsStyle Object fields
    /// </summary>
    [DataContract]
    public partial class ItemsStyle
    {
        /// <summary>
        /// Font color for changed components
        /// </summary>
        /// <value>Font color for changed components</value>
        [DataMember(Name="FontColor", EmitDefaultValue=false)]
        public string FontColor { get; set; }

        /// <summary>
        /// Highlight color for changed components
        /// </summary>
        /// <value>Highlight color for changed components</value>
        [DataMember(Name="HighlightColor", EmitDefaultValue=false)]
        public string HighlightColor { get; set; }

        /// <summary>
        /// Start tag for changed components
        /// </summary>
        /// <value>Start tag for changed components</value>
        [DataMember(Name="BeginSeparatorString", EmitDefaultValue=false)]
        public string BeginSeparatorString { get; set; }

        /// <summary>
        /// End tag for changed components
        /// </summary>
        /// <value>End tag for changed components</value>
        [DataMember(Name="EndSeparatorString", EmitDefaultValue=false)]
        public string EndSeparatorString { get; set; }

        /// <summary>
        /// Bold style for changed components
        /// </summary>
        /// <value>Bold style for changed components</value>
        [DataMember(Name="Bold", EmitDefaultValue=false)]
        public bool? Bold { get; set; }

        /// <summary>
        /// Italic style for changed components
        /// </summary>
        /// <value>Italic style for changed components</value>
        [DataMember(Name="Italic", EmitDefaultValue=false)]
        public bool? Italic { get; set; }

        /// <summary>
        /// Strikethrough style for changed components
        /// </summary>
        /// <value>Strikethrough style for changed components</value>
        [DataMember(Name="StrikeThrough", EmitDefaultValue=false)]
        public bool? StrikeThrough { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemsStyle {\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  HighlightColor: ").Append(HighlightColor).Append("\n");
            sb.Append("  BeginSeparatorString: ").Append(BeginSeparatorString).Append("\n");
            sb.Append("  EndSeparatorString: ").Append(EndSeparatorString).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  StrikeThrough: ").Append(StrikeThrough).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
