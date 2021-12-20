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
    /// UseTaxRate
    /// </summary>
    [DataContract]
    public partial class UseTaxRate :  IEquatable<UseTaxRate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseTaxRate" /> class.
        /// </summary>
        /// <param name="TotalTaxRate">TotalTaxRate.</param>
        /// <param name="StateTaxRate">StateTaxRate.</param>
        /// <param name="CountyTaxRate">CountyTaxRate.</param>
        /// <param name="MunicipalTaxRate">MunicipalTaxRate.</param>
        /// <param name="SpdsTax">SpdsTax.</param>
        public UseTaxRate(double? TotalTaxRate = null, double? StateTaxRate = null, double? CountyTaxRate = null, double? MunicipalTaxRate = null, List<SpecialPurposeDistrictTaxRate> SpdsTax = null)
        {
            this.TotalTaxRate = TotalTaxRate;
            this.StateTaxRate = StateTaxRate;
            this.CountyTaxRate = CountyTaxRate;
            this.MunicipalTaxRate = MunicipalTaxRate;
            this.SpdsTax = SpdsTax;
        }
        
        /// <summary>
        /// Gets or Sets TotalTaxRate
        /// </summary>
        [DataMember(Name="totalTaxRate", EmitDefaultValue=false)]
        public double? TotalTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets StateTaxRate
        /// </summary>
        [DataMember(Name="stateTaxRate", EmitDefaultValue=false)]
        public double? StateTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets CountyTaxRate
        /// </summary>
        [DataMember(Name="countyTaxRate", EmitDefaultValue=false)]
        public double? CountyTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets MunicipalTaxRate
        /// </summary>
        [DataMember(Name="municipalTaxRate", EmitDefaultValue=false)]
        public double? MunicipalTaxRate { get; set; }
        /// <summary>
        /// Gets or Sets SpdsTax
        /// </summary>
        [DataMember(Name="spdsTax", EmitDefaultValue=false)]
        public List<SpecialPurposeDistrictTaxRate> SpdsTax { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UseTaxRate {\n");
            sb.Append("  TotalTaxRate: ").Append(TotalTaxRate).Append("\n");
            sb.Append("  StateTaxRate: ").Append(StateTaxRate).Append("\n");
            sb.Append("  CountyTaxRate: ").Append(CountyTaxRate).Append("\n");
            sb.Append("  MunicipalTaxRate: ").Append(MunicipalTaxRate).Append("\n");
            sb.Append("  SpdsTax: ").Append(SpdsTax).Append("\n");
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
            return this.Equals(obj as UseTaxRate);
        }

        /// <summary>
        /// Returns true if UseTaxRate instances are equal
        /// </summary>
        /// <param name="other">Instance of UseTaxRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UseTaxRate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalTaxRate == other.TotalTaxRate ||
                    this.TotalTaxRate != null &&
                    this.TotalTaxRate.Equals(other.TotalTaxRate)
                ) && 
                (
                    this.StateTaxRate == other.StateTaxRate ||
                    this.StateTaxRate != null &&
                    this.StateTaxRate.Equals(other.StateTaxRate)
                ) && 
                (
                    this.CountyTaxRate == other.CountyTaxRate ||
                    this.CountyTaxRate != null &&
                    this.CountyTaxRate.Equals(other.CountyTaxRate)
                ) && 
                (
                    this.MunicipalTaxRate == other.MunicipalTaxRate ||
                    this.MunicipalTaxRate != null &&
                    this.MunicipalTaxRate.Equals(other.MunicipalTaxRate)
                ) && 
                (
                    this.SpdsTax == other.SpdsTax ||
                    this.SpdsTax != null &&
                    this.SpdsTax.SequenceEqual(other.SpdsTax)
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
                if (this.TotalTaxRate != null)
                    hash = hash * 59 + this.TotalTaxRate.GetHashCode();
                if (this.StateTaxRate != null)
                    hash = hash * 59 + this.StateTaxRate.GetHashCode();
                if (this.CountyTaxRate != null)
                    hash = hash * 59 + this.CountyTaxRate.GetHashCode();
                if (this.MunicipalTaxRate != null)
                    hash = hash * 59 + this.MunicipalTaxRate.GetHashCode();
                if (this.SpdsTax != null)
                    hash = hash * 59 + this.SpdsTax.GetHashCode();
                return hash;
            }
        }
    }

}
