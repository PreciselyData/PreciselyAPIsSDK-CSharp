/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.0
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
    /// Ipd
    /// </summary>
    [DataContract]
    public partial class Ipd :  IEquatable<Ipd>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ipd" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DistrictName">DistrictName.</param>
        /// <param name="DistrictType">DistrictType.</param>
        /// <param name="TaxCodeDescription">TaxCodeDescription.</param>
        /// <param name="EffectiveDate">EffectiveDate.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="BoundaryBuffer">BoundaryBuffer.</param>
        /// <param name="Rates">Rates.</param>
        public Ipd(string Id = null, string DistrictName = null, DistrictType DistrictType = null, string TaxCodeDescription = null, string EffectiveDate = null, string ExpirationDate = null, BoundaryBuffer BoundaryBuffer = null, List<Rate> Rates = null)
        {
            this.Id = Id;
            this.DistrictName = DistrictName;
            this.DistrictType = DistrictType;
            this.TaxCodeDescription = TaxCodeDescription;
            this.EffectiveDate = EffectiveDate;
            this.ExpirationDate = ExpirationDate;
            this.BoundaryBuffer = BoundaryBuffer;
            this.Rates = Rates;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets DistrictName
        /// </summary>
        [DataMember(Name="districtName", EmitDefaultValue=false)]
        public string DistrictName { get; set; }
        /// <summary>
        /// Gets or Sets DistrictType
        /// </summary>
        [DataMember(Name="districtType", EmitDefaultValue=false)]
        public DistrictType DistrictType { get; set; }
        /// <summary>
        /// Gets or Sets TaxCodeDescription
        /// </summary>
        [DataMember(Name="taxCodeDescription", EmitDefaultValue=false)]
        public string TaxCodeDescription { get; set; }
        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public string EffectiveDate { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }
        /// <summary>
        /// Gets or Sets BoundaryBuffer
        /// </summary>
        [DataMember(Name="boundaryBuffer", EmitDefaultValue=false)]
        public BoundaryBuffer BoundaryBuffer { get; set; }
        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<Rate> Rates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ipd {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DistrictName: ").Append(DistrictName).Append("\n");
            sb.Append("  DistrictType: ").Append(DistrictType).Append("\n");
            sb.Append("  TaxCodeDescription: ").Append(TaxCodeDescription).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  BoundaryBuffer: ").Append(BoundaryBuffer).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
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
            return this.Equals(obj as Ipd);
        }

        /// <summary>
        /// Returns true if Ipd instances are equal
        /// </summary>
        /// <param name="other">Instance of Ipd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ipd other)
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
                    this.DistrictName == other.DistrictName ||
                    this.DistrictName != null &&
                    this.DistrictName.Equals(other.DistrictName)
                ) && 
                (
                    this.DistrictType == other.DistrictType ||
                    this.DistrictType != null &&
                    this.DistrictType.Equals(other.DistrictType)
                ) && 
                (
                    this.TaxCodeDescription == other.TaxCodeDescription ||
                    this.TaxCodeDescription != null &&
                    this.TaxCodeDescription.Equals(other.TaxCodeDescription)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.BoundaryBuffer == other.BoundaryBuffer ||
                    this.BoundaryBuffer != null &&
                    this.BoundaryBuffer.Equals(other.BoundaryBuffer)
                ) && 
                (
                    this.Rates == other.Rates ||
                    this.Rates != null &&
                    this.Rates.SequenceEqual(other.Rates)
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
                if (this.DistrictName != null)
                    hash = hash * 59 + this.DistrictName.GetHashCode();
                if (this.DistrictType != null)
                    hash = hash * 59 + this.DistrictType.GetHashCode();
                if (this.TaxCodeDescription != null)
                    hash = hash * 59 + this.TaxCodeDescription.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.BoundaryBuffer != null)
                    hash = hash * 59 + this.BoundaryBuffer.GetHashCode();
                if (this.Rates != null)
                    hash = hash * 59 + this.Rates.GetHashCode();
                return hash;
            }
        }
    }

}
