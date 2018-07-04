// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PIAttribute
	/// </summary>
	[DataContract]

	public class PIAttribute
	{
		public PIAttribute(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string Type = null, string TypeQualifier = null, string DefaultUnitsName = null, int? DisplayDigits = null, string DataReferencePlugIn = null, string ConfigString = null, bool? IsConfigurationItem = null, bool? IsExcluded = null, bool? IsHidden = null, bool? IsManualDataEntry = null, bool? HasChildren = null, List<string> CategoryNames = null, bool? Step = null, string TraitName = null, string DefaultUnitsNameAbbreviation = null, double? Span = null, double? Zero = null, PIAttributeLinks Links = null, PIWebException WebException = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.Type = Type;
			this.TypeQualifier = TypeQualifier;
			this.DefaultUnitsName = DefaultUnitsName;
			this.DisplayDigits = DisplayDigits;
			this.DataReferencePlugIn = DataReferencePlugIn;
			this.ConfigString = ConfigString;
			this.IsConfigurationItem = IsConfigurationItem;
			this.IsExcluded = IsExcluded;
			this.IsHidden = IsHidden;
			this.IsManualDataEntry = IsManualDataEntry;
			this.HasChildren = HasChildren;
			this.CategoryNames = CategoryNames;
			this.Step = Step;
			this.TraitName = TraitName;
			this.DefaultUnitsNameAbbreviation = DefaultUnitsNameAbbreviation;
			this.Span = Span;
			this.Zero = Zero;
			this.Links = Links;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "TypeQualifier", EmitDefaultValue = false)]
		public string TypeQualifier { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "DefaultUnitsName", EmitDefaultValue = false)]
		public string DefaultUnitsName { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "DisplayDigits", EmitDefaultValue = false)]
		public int? DisplayDigits { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "DataReferencePlugIn", EmitDefaultValue = false)]
		public string DataReferencePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "IsConfigurationItem", EmitDefaultValue = false)]
		public bool? IsConfigurationItem { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "IsExcluded", EmitDefaultValue = false)]
		public bool? IsExcluded { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "IsHidden", EmitDefaultValue = false)]
		public bool? IsHidden { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "IsManualDataEntry", EmitDefaultValue = false)]
		public bool? IsManualDataEntry { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool? HasChildren { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Step", EmitDefaultValue = false)]
		public bool? Step { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "TraitName", EmitDefaultValue = false)]
		public string TraitName { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "DefaultUnitsNameAbbreviation", EmitDefaultValue = false)]
		public string DefaultUnitsNameAbbreviation { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Span", EmitDefaultValue = false)]
		public double? Span { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Zero", EmitDefaultValue = false)]
		public double? Zero { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIAttributeLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PIAttribute
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
