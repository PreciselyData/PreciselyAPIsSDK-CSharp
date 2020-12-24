/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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

namespace com.precisely.apis.Model
{
    /// <summary>
    /// AddressesPreferences
    /// </summary>
    [DataContract]
    public partial class AddressesPreferences :  IEquatable<AddressesPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesPreferences" /> class.
        /// </summary>
        /// <param name="MaxCandidates">MaxCandidates.</param>
        /// <param name="Page">Page.</param>
        public AddressesPreferences(string MaxCandidates = null, string Page = null)
        {
            this.MaxCandidates = MaxCandidates;
            this.Page = Page;
        }
        
        /// <summary>
        /// Gets or Sets MaxCandidates
        /// </summary>
        [DataMember(Name="maxCandidates", EmitDefaultValue=false)]
        public string MaxCandidates { get; set; }
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public string Page { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressesPreferences {\n");
            sb.Append("  MaxCandidates: ").Append(MaxCandidates).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AddressesPreferences);
        }

        /// <summary>
        /// Returns true if AddressesPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressesPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressesPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaxCandidates == other.MaxCandidates ||
                    this.MaxCandidates != null &&
                    this.MaxCandidates.Equals(other.MaxCandidates)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MaxCandidates != null)
                    hash = hash * 59 + this.MaxCandidates.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                return hash;
            }
        }
    }

}
