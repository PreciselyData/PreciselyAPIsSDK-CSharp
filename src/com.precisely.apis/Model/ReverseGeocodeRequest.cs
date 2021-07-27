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
    /// ReverseGeocodeRequest
    /// </summary>
    [DataContract]
    public partial class ReverseGeocodeRequest :  IEquatable<ReverseGeocodeRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseGeocodeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeRequest" /> class.
        /// </summary>
        /// <param name="Preferences">Preferences.</param>
        /// <param name="Points">Points (required).</param>
        public ReverseGeocodeRequest(Preferences Preferences = null, List<Points> Points = null)
        {
            // to ensure "Points" is required (not null)
            if (Points == null)
            {
                throw new InvalidDataException("Points is a required property for ReverseGeocodeRequest and cannot be null");
            }
            else
            {
                this.Points = Points;
            }
            this.Preferences = Preferences;
        }
        
        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public Preferences Preferences { get; set; }
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public List<Points> Points { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReverseGeocodeRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(obj as ReverseGeocodeRequest);
        }

        /// <summary>
        /// Returns true if ReverseGeocodeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReverseGeocodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseGeocodeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Preferences == other.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.Equals(other.Preferences)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.SequenceEqual(other.Points)
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
                if (this.Preferences != null)
                    hash = hash * 59 + this.Preferences.GetHashCode();
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                return hash;
            }
        }
    }

}
