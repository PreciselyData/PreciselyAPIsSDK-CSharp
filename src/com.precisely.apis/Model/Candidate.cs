/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.1
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
    /// Candidate
    /// </summary>
    [DataContract]
    public partial class Candidate :  IEquatable<Candidate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        /// <param name="PrecisionLevel">PrecisionLevel.</param>
        /// <param name="FormattedStreetAddress">FormattedStreetAddress.</param>
        /// <param name="FormattedLocationAddress">FormattedLocationAddress.</param>
        /// <param name="Identifier">Identifier.</param>
        /// <param name="PrecisionCode">PrecisionCode.</param>
        /// <param name="SourceDictionary">SourceDictionary.</param>
        /// <param name="Matching">Matching.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Ranges">Ranges.</param>
        public Candidate(int? PrecisionLevel = null, string FormattedStreetAddress = null, string FormattedLocationAddress = null, string Identifier = null, string PrecisionCode = null, string SourceDictionary = null, FieldsMatching Matching = null, GeoPos Geometry = null, GeocodeAddress Address = null, List<CandidateRange> Ranges = null)
        {
            this.PrecisionLevel = PrecisionLevel;
            this.FormattedStreetAddress = FormattedStreetAddress;
            this.FormattedLocationAddress = FormattedLocationAddress;
            this.Identifier = Identifier;
            this.PrecisionCode = PrecisionCode;
            this.SourceDictionary = SourceDictionary;
            this.Matching = Matching;
            this.Geometry = Geometry;
            this.Address = Address;
            this.Ranges = Ranges;
        }
        
        /// <summary>
        /// Gets or Sets PrecisionLevel
        /// </summary>
        [DataMember(Name="precisionLevel", EmitDefaultValue=false)]
        public int? PrecisionLevel { get; set; }
        /// <summary>
        /// Gets or Sets FormattedStreetAddress
        /// </summary>
        [DataMember(Name="formattedStreetAddress", EmitDefaultValue=false)]
        public string FormattedStreetAddress { get; set; }
        /// <summary>
        /// Gets or Sets FormattedLocationAddress
        /// </summary>
        [DataMember(Name="formattedLocationAddress", EmitDefaultValue=false)]
        public string FormattedLocationAddress { get; set; }
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }
        /// <summary>
        /// Gets or Sets PrecisionCode
        /// </summary>
        [DataMember(Name="precisionCode", EmitDefaultValue=false)]
        public string PrecisionCode { get; set; }
        /// <summary>
        /// Gets or Sets SourceDictionary
        /// </summary>
        [DataMember(Name="sourceDictionary", EmitDefaultValue=false)]
        public string SourceDictionary { get; set; }
        /// <summary>
        /// Gets or Sets Matching
        /// </summary>
        [DataMember(Name="matching", EmitDefaultValue=false)]
        public FieldsMatching Matching { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public GeoPos Geometry { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public GeocodeAddress Address { get; set; }
        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<CandidateRange> Ranges { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Candidate {\n");
            sb.Append("  PrecisionLevel: ").Append(PrecisionLevel).Append("\n");
            sb.Append("  FormattedStreetAddress: ").Append(FormattedStreetAddress).Append("\n");
            sb.Append("  FormattedLocationAddress: ").Append(FormattedLocationAddress).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  PrecisionCode: ").Append(PrecisionCode).Append("\n");
            sb.Append("  SourceDictionary: ").Append(SourceDictionary).Append("\n");
            sb.Append("  Matching: ").Append(Matching).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
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
            return this.Equals(obj as Candidate);
        }

        /// <summary>
        /// Returns true if Candidate instances are equal
        /// </summary>
        /// <param name="other">Instance of Candidate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Candidate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PrecisionLevel == other.PrecisionLevel ||
                    this.PrecisionLevel != null &&
                    this.PrecisionLevel.Equals(other.PrecisionLevel)
                ) && 
                (
                    this.FormattedStreetAddress == other.FormattedStreetAddress ||
                    this.FormattedStreetAddress != null &&
                    this.FormattedStreetAddress.Equals(other.FormattedStreetAddress)
                ) && 
                (
                    this.FormattedLocationAddress == other.FormattedLocationAddress ||
                    this.FormattedLocationAddress != null &&
                    this.FormattedLocationAddress.Equals(other.FormattedLocationAddress)
                ) && 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.PrecisionCode == other.PrecisionCode ||
                    this.PrecisionCode != null &&
                    this.PrecisionCode.Equals(other.PrecisionCode)
                ) && 
                (
                    this.SourceDictionary == other.SourceDictionary ||
                    this.SourceDictionary != null &&
                    this.SourceDictionary.Equals(other.SourceDictionary)
                ) && 
                (
                    this.Matching == other.Matching ||
                    this.Matching != null &&
                    this.Matching.Equals(other.Matching)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.SequenceEqual(other.Ranges)
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
                if (this.PrecisionLevel != null)
                    hash = hash * 59 + this.PrecisionLevel.GetHashCode();
                if (this.FormattedStreetAddress != null)
                    hash = hash * 59 + this.FormattedStreetAddress.GetHashCode();
                if (this.FormattedLocationAddress != null)
                    hash = hash * 59 + this.FormattedLocationAddress.GetHashCode();
                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                if (this.PrecisionCode != null)
                    hash = hash * 59 + this.PrecisionCode.GetHashCode();
                if (this.SourceDictionary != null)
                    hash = hash * 59 + this.SourceDictionary.GetHashCode();
                if (this.Matching != null)
                    hash = hash * 59 + this.Matching.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();
                return hash;
            }
        }
    }

}
