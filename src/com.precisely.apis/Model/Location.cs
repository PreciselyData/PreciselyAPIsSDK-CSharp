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
    /// Location
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="City">City.</param>
        /// <param name="Region">Region.</param>
        /// <param name="RegionCode">RegionCode.</param>
        /// <param name="Country">Country.</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="Formatted">Formatted.</param>
        public Location(string Label = null, string City = null, string Region = null, string RegionCode = null, string Country = null, string CountryCode = null, string Formatted = null)
        {
            this.Label = Label;
            this.City = City;
            this.Region = Region;
            this.RegionCode = RegionCode;
            this.Country = Country;
            this.CountryCode = CountryCode;
            this.Formatted = Formatted;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        /// <summary>
        /// Gets or Sets RegionCode
        /// </summary>
        [DataMember(Name="regionCode", EmitDefaultValue=false)]
        public string RegionCode { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Gets or Sets Formatted
        /// </summary>
        [DataMember(Name="formatted", EmitDefaultValue=false)]
        public string Formatted { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Formatted: ").Append(Formatted).Append("\n");
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
            return this.Equals(obj as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="other">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.Formatted == other.Formatted ||
                    this.Formatted != null &&
                    this.Formatted.Equals(other.Formatted)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.Formatted != null)
                    hash = hash * 59 + this.Formatted.GetHashCode();
                return hash;
            }
        }
    }

}
