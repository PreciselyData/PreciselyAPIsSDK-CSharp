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
    /// Parcel
    /// </summary>
    [DataContract]
    public partial class Parcel :  IEquatable<Parcel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parcel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="CensusCode">CensusCode.</param>
        /// <param name="Pbkey">Pbkey.</param>
        /// <param name="Address">Address.</param>
        public Parcel(string Id = null, string CensusCode = null, string Pbkey = null, MatchedAddress Address = null)
        {
            this.Id = Id;
            this.CensusCode = CensusCode;
            this.Pbkey = Pbkey;
            this.Address = Address;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets CensusCode
        /// </summary>
        [DataMember(Name="censusCode", EmitDefaultValue=false)]
        public string CensusCode { get; set; }
        /// <summary>
        /// Gets or Sets Pbkey
        /// </summary>
        [DataMember(Name="pbkey", EmitDefaultValue=false)]
        public string Pbkey { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public MatchedAddress Address { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parcel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CensusCode: ").Append(CensusCode).Append("\n");
            sb.Append("  Pbkey: ").Append(Pbkey).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(obj as Parcel);
        }

        /// <summary>
        /// Returns true if Parcel instances are equal
        /// </summary>
        /// <param name="other">Instance of Parcel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Parcel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CensusCode == other.CensusCode ||
                    this.CensusCode != null &&
                    this.CensusCode.Equals(other.CensusCode)
                ) && 
                (
                    this.Pbkey == other.Pbkey ||
                    this.Pbkey != null &&
                    this.Pbkey.Equals(other.Pbkey)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CensusCode != null)
                    hash = hash * 59 + this.CensusCode.GetHashCode();
                if (this.Pbkey != null)
                    hash = hash * 59 + this.Pbkey.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }
    }

}
