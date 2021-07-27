/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.2
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
    /// GeoLocationFixedLine
    /// </summary>
    [DataContract]
    public partial class GeoLocationFixedLine :  IEquatable<GeoLocationFixedLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationFixedLine" /> class.
        /// </summary>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="Accuracy">Accuracy.</param>
        /// <param name="DeviceId">DeviceId.</param>
        /// <param name="Country">Country.</param>
        public GeoLocationFixedLine(Geometry Geometry = null, Accuracy Accuracy = null, string DeviceId = null, GeoLocationFixedLineCountry Country = null)
        {
            this.Geometry = Geometry;
            this.Accuracy = Accuracy;
            this.DeviceId = DeviceId;
            this.Country = Country;
        }
        
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets Accuracy
        /// </summary>
        [DataMember(Name="accuracy", EmitDefaultValue=false)]
        public Accuracy Accuracy { get; set; }
        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GeoLocationFixedLineCountry Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationFixedLine {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as GeoLocationFixedLine);
        }

        /// <summary>
        /// Returns true if GeoLocationFixedLine instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoLocationFixedLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationFixedLine other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.Accuracy == other.Accuracy ||
                    this.Accuracy != null &&
                    this.Accuracy.Equals(other.Accuracy)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.Accuracy != null)
                    hash = hash * 59 + this.Accuracy.GetHashCode();
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }
    }

}
