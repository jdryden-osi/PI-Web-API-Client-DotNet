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
	/// PIStreamUpdatesRegister
	/// </summary>
	[DataContract]

	public class PIStreamUpdatesRegister
	{
		public PIStreamUpdatesRegister(string Status = null, string Source = null, string SourceName = null, string SourcePath = null, string LatestMarker = null, PIErrors Exception = null)
		{
			this.Status = Status;
			this.Source = Source;
			this.SourceName = SourceName;
			this.SourcePath = SourcePath;
			this.LatestMarker = LatestMarker;
			this.Exception = Exception;
		}

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "Source", EmitDefaultValue = false)]
		public string Source { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "SourceName", EmitDefaultValue = false)]
		public string SourceName { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "SourcePath", EmitDefaultValue = false)]
		public string SourcePath { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "LatestMarker", EmitDefaultValue = false)]
		public string LatestMarker { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamUpdatesRegister
		/// </summary>
		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
