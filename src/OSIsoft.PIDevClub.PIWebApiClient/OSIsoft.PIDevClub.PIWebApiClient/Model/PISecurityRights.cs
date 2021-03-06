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
	/// PISecurityRights
	/// </summary>
	[DataContract]

	public class PISecurityRights
	{
		public PISecurityRights(string OwnerWebId = null, string SecurityItem = null, string UserIdentity = null, PISecurityRightsLinks Links = null, bool? CanAnnotate = null, bool? CanDelete = null, bool? CanExecute = null, bool? CanRead = null, bool? CanReadData = null, bool? CanSubscribe = null, bool? CanSubscribeOthers = null, bool? CanWrite = null, bool? CanWriteData = null, bool? HasAdmin = null, List<string> Rights = null, PIWebException WebException = null)
		{
			this.OwnerWebId = OwnerWebId;
			this.SecurityItem = SecurityItem;
			this.UserIdentity = UserIdentity;
			this.Links = Links;
			this.CanAnnotate = CanAnnotate;
			this.CanDelete = CanDelete;
			this.CanExecute = CanExecute;
			this.CanRead = CanRead;
			this.CanReadData = CanReadData;
			this.CanSubscribe = CanSubscribe;
			this.CanSubscribeOthers = CanSubscribeOthers;
			this.CanWrite = CanWrite;
			this.CanWriteData = CanWriteData;
			this.HasAdmin = HasAdmin;
			this.Rights = Rights;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "OwnerWebId", EmitDefaultValue = false)]
		public string OwnerWebId { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "SecurityItem", EmitDefaultValue = false)]
		public string SecurityItem { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "UserIdentity", EmitDefaultValue = false)]
		public string UserIdentity { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PISecurityRightsLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanAnnotate", EmitDefaultValue = false)]
		public bool? CanAnnotate { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanDelete", EmitDefaultValue = false)]
		public bool? CanDelete { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanExecute", EmitDefaultValue = false)]
		public bool? CanExecute { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanRead", EmitDefaultValue = false)]
		public bool? CanRead { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanReadData", EmitDefaultValue = false)]
		public bool? CanReadData { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanSubscribe", EmitDefaultValue = false)]
		public bool? CanSubscribe { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanSubscribeOthers", EmitDefaultValue = false)]
		public bool? CanSubscribeOthers { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanWrite", EmitDefaultValue = false)]
		public bool? CanWrite { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "CanWriteData", EmitDefaultValue = false)]
		public bool? CanWriteData { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "HasAdmin", EmitDefaultValue = false)]
		public bool? HasAdmin { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "Rights", EmitDefaultValue = false)]
		public List<string> Rights { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityRights
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
