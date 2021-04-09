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
    /// Match
    /// </summary>
    [DataContract]
    public partial class Match :  IEquatable<Match>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Match" /> class.
        /// </summary>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="PercentGeocode">PercentGeocode.</param>
        /// <param name="PrecisionLevel">PrecisionLevel.</param>
        /// <param name="LocationCode">LocationCode.</param>
        /// <param name="MatchCode">MatchCode.</param>
        public Match(string Confidence = null, string PercentGeocode = null, string PrecisionLevel = null, string LocationCode = null, string MatchCode = null)
        {
            this.Confidence = Confidence;
            this.PercentGeocode = PercentGeocode;
            this.PrecisionLevel = PrecisionLevel;
            this.LocationCode = LocationCode;
            this.MatchCode = MatchCode;
        }
        
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public string Confidence { get; set; }
        /// <summary>
        /// Gets or Sets PercentGeocode
        /// </summary>
        [DataMember(Name="percentGeocode", EmitDefaultValue=false)]
        public string PercentGeocode { get; set; }
        /// <summary>
        /// Gets or Sets PrecisionLevel
        /// </summary>
        [DataMember(Name="precisionLevel", EmitDefaultValue=false)]
        public string PrecisionLevel { get; set; }
        /// <summary>
        /// Gets or Sets LocationCode
        /// </summary>
        [DataMember(Name="locationCode", EmitDefaultValue=false)]
        public string LocationCode { get; set; }
        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name="matchCode", EmitDefaultValue=false)]
        public string MatchCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  PercentGeocode: ").Append(PercentGeocode).Append("\n");
            sb.Append("  PrecisionLevel: ").Append(PrecisionLevel).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
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
            return this.Equals(obj as Match);
        }

        /// <summary>
        /// Returns true if Match instances are equal
        /// </summary>
        /// <param name="other">Instance of Match to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Match other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) && 
                (
                    this.PercentGeocode == other.PercentGeocode ||
                    this.PercentGeocode != null &&
                    this.PercentGeocode.Equals(other.PercentGeocode)
                ) && 
                (
                    this.PrecisionLevel == other.PrecisionLevel ||
                    this.PrecisionLevel != null &&
                    this.PrecisionLevel.Equals(other.PrecisionLevel)
                ) && 
                (
                    this.LocationCode == other.LocationCode ||
                    this.LocationCode != null &&
                    this.LocationCode.Equals(other.LocationCode)
                ) && 
                (
                    this.MatchCode == other.MatchCode ||
                    this.MatchCode != null &&
                    this.MatchCode.Equals(other.MatchCode)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                if (this.PercentGeocode != null)
                    hash = hash * 59 + this.PercentGeocode.GetHashCode();
                if (this.PrecisionLevel != null)
                    hash = hash * 59 + this.PrecisionLevel.GetHashCode();
                if (this.LocationCode != null)
                    hash = hash * 59 + this.LocationCode.GetHashCode();
                if (this.MatchCode != null)
                    hash = hash * 59 + this.MatchCode.GetHashCode();
                return hash;
            }
        }
    }

}
