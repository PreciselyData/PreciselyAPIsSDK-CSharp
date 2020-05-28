/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.0.0
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
    /// FireDepartment
    /// </summary>
    [DataContract]
    public partial class FireDepartment :  IEquatable<FireDepartment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireDepartment" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="NumberOfStations">NumberOfStations.</param>
        /// <param name="AdministrativeOfficeOnly">AdministrativeOfficeOnly (default to false).</param>
        /// <param name="ContactDetails">ContactDetails.</param>
        public FireDepartment(string Name = null, string Type = null, int? NumberOfStations = null, bool? AdministrativeOfficeOnly = null, FireDepartmentContactDetails ContactDetails = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.NumberOfStations = NumberOfStations;
            // use default value if no "AdministrativeOfficeOnly" provided
            if (AdministrativeOfficeOnly == null)
            {
                this.AdministrativeOfficeOnly = false;
            }
            else
            {
                this.AdministrativeOfficeOnly = AdministrativeOfficeOnly;
            }
            this.ContactDetails = ContactDetails;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfStations
        /// </summary>
        [DataMember(Name="numberOfStations", EmitDefaultValue=false)]
        public int? NumberOfStations { get; set; }
        /// <summary>
        /// Gets or Sets AdministrativeOfficeOnly
        /// </summary>
        [DataMember(Name="administrativeOfficeOnly", EmitDefaultValue=false)]
        public bool? AdministrativeOfficeOnly { get; set; }
        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public FireDepartmentContactDetails ContactDetails { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireDepartment {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfStations: ").Append(NumberOfStations).Append("\n");
            sb.Append("  AdministrativeOfficeOnly: ").Append(AdministrativeOfficeOnly).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
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
            return this.Equals(obj as FireDepartment);
        }

        /// <summary>
        /// Returns true if FireDepartment instances are equal
        /// </summary>
        /// <param name="other">Instance of FireDepartment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireDepartment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.NumberOfStations == other.NumberOfStations ||
                    this.NumberOfStations != null &&
                    this.NumberOfStations.Equals(other.NumberOfStations)
                ) && 
                (
                    this.AdministrativeOfficeOnly == other.AdministrativeOfficeOnly ||
                    this.AdministrativeOfficeOnly != null &&
                    this.AdministrativeOfficeOnly.Equals(other.AdministrativeOfficeOnly)
                ) && 
                (
                    this.ContactDetails == other.ContactDetails ||
                    this.ContactDetails != null &&
                    this.ContactDetails.Equals(other.ContactDetails)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.NumberOfStations != null)
                    hash = hash * 59 + this.NumberOfStations.GetHashCode();
                if (this.AdministrativeOfficeOnly != null)
                    hash = hash * 59 + this.AdministrativeOfficeOnly.GetHashCode();
                if (this.ContactDetails != null)
                    hash = hash * 59 + this.ContactDetails.GetHashCode();
                return hash;
            }
        }
    }

}
