/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.8.0
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
    /// Identity
    /// </summary>
    [DataContract]
    public partial class Identity :  IEquatable<Identity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        /// <param name="FullName">FullName.</param>
        /// <param name="AgeRange">AgeRange.</param>
        /// <param name="Gender">Gender.</param>
        /// <param name="Location">Location.</param>
        /// <param name="CoreId">CoreId.</param>
        /// <param name="PbKey">PbKey.</param>
        /// <param name="Details">Details.</param>
        public Identity(string FullName = null, string AgeRange = null, string Gender = null, string Location = null, string CoreId = null, string PbKey = null, IdentityDetail Details = null)
        {
            this.FullName = FullName;
            this.AgeRange = AgeRange;
            this.Gender = Gender;
            this.Location = Location;
            this.CoreId = CoreId;
            this.PbKey = PbKey;
            this.Details = Details;
        }
        
        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or Sets AgeRange
        /// </summary>
        [DataMember(Name="ageRange", EmitDefaultValue=false)]
        public string AgeRange { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets CoreId
        /// </summary>
        [DataMember(Name="coreId", EmitDefaultValue=false)]
        public string CoreId { get; set; }
        /// <summary>
        /// Gets or Sets PbKey
        /// </summary>
        [DataMember(Name="pbKey", EmitDefaultValue=false)]
        public string PbKey { get; set; }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public IdentityDetail Details { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Identity {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  AgeRange: ").Append(AgeRange).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  CoreId: ").Append(CoreId).Append("\n");
            sb.Append("  PbKey: ").Append(PbKey).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as Identity);
        }

        /// <summary>
        /// Returns true if Identity instances are equal
        /// </summary>
        /// <param name="other">Instance of Identity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Identity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.AgeRange == other.AgeRange ||
                    this.AgeRange != null &&
                    this.AgeRange.Equals(other.AgeRange)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.CoreId == other.CoreId ||
                    this.CoreId != null &&
                    this.CoreId.Equals(other.CoreId)
                ) && 
                (
                    this.PbKey == other.PbKey ||
                    this.PbKey != null &&
                    this.PbKey.Equals(other.PbKey)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.AgeRange != null)
                    hash = hash * 59 + this.AgeRange.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.CoreId != null)
                    hash = hash * 59 + this.CoreId.GetHashCode();
                if (this.PbKey != null)
                    hash = hash * 59 + this.PbKey.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                return hash;
            }
        }
    }

}
