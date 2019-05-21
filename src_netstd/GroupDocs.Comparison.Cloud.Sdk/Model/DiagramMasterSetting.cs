// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DiagramMasterSetting.cs">
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
    /// DiagramMasterSetting Object fields
    /// </summary>
    [DataContract]
    public partial class DiagramMasterSetting
    {
        /// <summary>
        /// Path to custom master path
        /// </summary>
        /// <value>Path to custom master path</value>
        [DataMember(Name="MasterPath", EmitDefaultValue=false)]
        public string MasterPath { get; set; }

        /// <summary>
        /// Value of using master from source and target document together
        /// </summary>
        /// <value>Value of using master from source and target document together</value>
        [DataMember(Name="UseSourceMaster", EmitDefaultValue=false)]
        public bool? UseSourceMaster { get; set; }

        /// <summary>
        /// Width of original document
        /// </summary>
        /// <value>Width of original document</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height of original document
        /// </summary>
        /// <value>Height of original document</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramMasterSetting {\n");
            sb.Append("  MasterPath: ").Append(MasterPath).Append("\n");
            sb.Append("  UseSourceMaster: ").Append(UseSourceMaster).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
