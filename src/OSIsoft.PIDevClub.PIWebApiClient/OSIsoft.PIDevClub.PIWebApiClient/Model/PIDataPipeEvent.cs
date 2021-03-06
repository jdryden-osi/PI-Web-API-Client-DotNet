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
	/// PIDataPipeEvent
	/// </summary>
	[DataContract]

	public class PIDataPipeEvent
	{
		public PIDataPipeEvent(string Action = null, string Timestamp = null, string UnitsAbbreviation = null, bool? Good = null, bool? Questionable = null, bool? Substituted = null, bool? Annotated = null, object Value = null, List<PIPropertyError> Errors = null, PIWebException WebException = null)
		{
			this.Action = Action;
			this.Timestamp = Timestamp;
			this.UnitsAbbreviation = UnitsAbbreviation;
			this.Good = Good;
			this.Questionable = Questionable;
			this.Substituted = Substituted;
			this.Annotated = Annotated;
			this.Value = Value;
			this.Errors = Errors;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Action", EmitDefaultValue = false)]
		public string Action { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Timestamp", EmitDefaultValue = false)]
		public string Timestamp { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Good", EmitDefaultValue = false)]
		public bool? Good { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Questionable", EmitDefaultValue = false)]
		public bool? Questionable { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Substituted", EmitDefaultValue = false)]
		public bool? Substituted { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Annotated", EmitDefaultValue = false)]
		public bool? Annotated { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public object Value { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "Errors", EmitDefaultValue = false)]
		public List<PIPropertyError> Errors { get; set; }

		/// <summary>
		/// Gets or Sets PIDataPipeEvent
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
