// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Settings.cs">
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
    /// Defines comparison process additional settings 
    /// </summary>  
    public class Settings 
    {                       
        /// <summary>
        /// Indicates whether to add summary page to resultant document or not
        /// </summary>  
        public bool? GenerateSummaryPage { get; set; }

        /// <summary>
        /// Indicates whether to show deleted components in resultant document or not
        /// </summary>  
        public bool? ShowDeletedContent { get; set; }

        /// <summary>
        /// Indicates whether to detect style changes or not
        /// </summary>  
        public bool? StyleChangeDetection { get; set; }

        /// <summary>
        /// Style for inserted components
        /// </summary>  
        public ItemsStyle InsertedItemsStyle { get; set; }

        /// <summary>
        /// Style for deleted components
        /// </summary>  
        public ItemsStyle DeletedItemsStyle { get; set; }

        /// <summary>
        /// Style for components with changed style
        /// </summary>  
        public ItemsStyle StyleChangedItemsStyle { get; set; }

        /// <summary>
        /// An array of delimiters to split text into words
        /// </summary>  
        public List<string> WordsSeparatorChars { get; set; }

        /// <summary>
        /// Gets of sets the comparison detalisation level 
        /// </summary>  
        public string DetailLevel { get; set; }

        /// <summary>
        /// Indicates whether to use frames for shapes in Word Processing and for rectangles in Image documents
        /// </summary>  
        public bool? UseFramesForDelInsElements { get; set; }

        /// <summary>
        /// Indicates whether to calculate coordinates for changed components
        /// </summary>  
        public bool? CalculateComponentCoordinates { get; set; }

        /// <summary>
        /// Indicates whether to accept inserted/deleted styles for all children of inserted/deleted components
        /// </summary>  
        public bool? MarkDeletedInsertedContentDeep { get; set; }

        /// <summary>
        /// Gets or sets type of metadata to clone
        /// </summary>  
        public string CloneMetadata { get; set; }

        /// <summary>
        /// Gets or sets user metadata
        /// </summary>  
        public Metadata MetaData { get; set; }

        /// <summary>
        /// Gets or sets type of password saving
        /// </summary>  
        public string PasswordSaveOption { get; set; }

        /// <summary>
        /// Gets or sets user password to resultant document
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets master for Diagram document
        /// </summary>  
        public DiagramMasterSetting DiagramMasterSetting { get; set; }

        /// <summary>
        /// Gets or sets original document size when picture is compared with other different formats
        /// </summary>  
        public OriginalSize OriginalSize { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Settings {\n");
          sb.Append("  GenerateSummaryPage: ").Append(this.GenerateSummaryPage).Append("\n");
          sb.Append("  ShowDeletedContent: ").Append(this.ShowDeletedContent).Append("\n");
          sb.Append("  StyleChangeDetection: ").Append(this.StyleChangeDetection).Append("\n");
          sb.Append("  InsertedItemsStyle: ").Append(this.InsertedItemsStyle).Append("\n");
          sb.Append("  DeletedItemsStyle: ").Append(this.DeletedItemsStyle).Append("\n");
          sb.Append("  StyleChangedItemsStyle: ").Append(this.StyleChangedItemsStyle).Append("\n");
          sb.Append("  WordsSeparatorChars: ").Append(this.WordsSeparatorChars).Append("\n");
          sb.Append("  DetailLevel: ").Append(this.DetailLevel).Append("\n");
          sb.Append("  UseFramesForDelInsElements: ").Append(this.UseFramesForDelInsElements).Append("\n");
          sb.Append("  CalculateComponentCoordinates: ").Append(this.CalculateComponentCoordinates).Append("\n");
          sb.Append("  MarkDeletedInsertedContentDeep: ").Append(this.MarkDeletedInsertedContentDeep).Append("\n");
          sb.Append("  CloneMetadata: ").Append(this.CloneMetadata).Append("\n");
          sb.Append("  MetaData: ").Append(this.MetaData).Append("\n");
          sb.Append("  PasswordSaveOption: ").Append(this.PasswordSaveOption).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  DiagramMasterSetting: ").Append(this.DiagramMasterSetting).Append("\n");
          sb.Append("  OriginalSize: ").Append(this.OriginalSize).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
