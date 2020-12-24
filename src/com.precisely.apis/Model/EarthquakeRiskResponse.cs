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
    /// EarthquakeRiskResponse
    /// </summary>
    [DataContract]
    public partial class EarthquakeRiskResponse :  IEquatable<EarthquakeRiskResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeRiskResponse" /> class.
        /// </summary>
        /// <param name="RiskLevel">RiskLevel.</param>
        /// <param name="EventsCount">EventsCount.</param>
        /// <param name="Grid">Grid.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        public EarthquakeRiskResponse(string RiskLevel = null, EventsCount EventsCount = null, Grid Grid = null, MatchedAddress MatchedAddress = null)
        {
            this.RiskLevel = RiskLevel;
            this.EventsCount = EventsCount;
            this.Grid = Grid;
            this.MatchedAddress = MatchedAddress;
        }
        
        /// <summary>
        /// Gets or Sets RiskLevel
        /// </summary>
        [DataMember(Name="riskLevel", EmitDefaultValue=false)]
        public string RiskLevel { get; set; }
        /// <summary>
        /// Gets or Sets EventsCount
        /// </summary>
        [DataMember(Name="eventsCount", EmitDefaultValue=false)]
        public EventsCount EventsCount { get; set; }
        /// <summary>
        /// Gets or Sets Grid
        /// </summary>
        [DataMember(Name="grid", EmitDefaultValue=false)]
        public Grid Grid { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarthquakeRiskResponse {\n");
            sb.Append("  RiskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  EventsCount: ").Append(EventsCount).Append("\n");
            sb.Append("  Grid: ").Append(Grid).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(obj as EarthquakeRiskResponse);
        }

        /// <summary>
        /// Returns true if EarthquakeRiskResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EarthquakeRiskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeRiskResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RiskLevel == other.RiskLevel ||
                    this.RiskLevel != null &&
                    this.RiskLevel.Equals(other.RiskLevel)
                ) && 
                (
                    this.EventsCount == other.EventsCount ||
                    this.EventsCount != null &&
                    this.EventsCount.Equals(other.EventsCount)
                ) && 
                (
                    this.Grid == other.Grid ||
                    this.Grid != null &&
                    this.Grid.Equals(other.Grid)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
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
                if (this.RiskLevel != null)
                    hash = hash * 59 + this.RiskLevel.GetHashCode();
                if (this.EventsCount != null)
                    hash = hash * 59 + this.EventsCount.GetHashCode();
                if (this.Grid != null)
                    hash = hash * 59 + this.Grid.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                return hash;
            }
        }
    }

}
