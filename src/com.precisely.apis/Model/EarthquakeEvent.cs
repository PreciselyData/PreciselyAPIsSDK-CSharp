/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
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
    /// EarthquakeEvent
    /// </summary>
    [DataContract]
    public partial class EarthquakeEvent :  IEquatable<EarthquakeEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeEvent" /> class.
        /// </summary>
        /// <param name="DateTime">DateTime.</param>
        /// <param name="SeismicRegionNumber">SeismicRegionNumber.</param>
        /// <param name="Depth">Depth.</param>
        /// <param name="Magnitude">Magnitude.</param>
        /// <param name="Cause">Cause.</param>
        /// <param name="CulturalEffect">CulturalEffect.</param>
        /// <param name="Intensity">Intensity.</param>
        /// <param name="Diastrophism">Diastrophism.</param>
        /// <param name="MiscPhenomena">MiscPhenomena.</param>
        /// <param name="Location">Location.</param>
        public EarthquakeEvent(DateTimeEarthQuake DateTime = null, int? SeismicRegionNumber = null, Depth Depth = null, Magnitude Magnitude = null, string Cause = null, string CulturalEffect = null, int? Intensity = null, string Diastrophism = null, string MiscPhenomena = null, EarthquakeLocation Location = null)
        {
            this.DateTime = DateTime;
            this.SeismicRegionNumber = SeismicRegionNumber;
            this.Depth = Depth;
            this.Magnitude = Magnitude;
            this.Cause = Cause;
            this.CulturalEffect = CulturalEffect;
            this.Intensity = Intensity;
            this.Diastrophism = Diastrophism;
            this.MiscPhenomena = MiscPhenomena;
            this.Location = Location;
        }
        
        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTimeEarthQuake DateTime { get; set; }
        /// <summary>
        /// Gets or Sets SeismicRegionNumber
        /// </summary>
        [DataMember(Name="seismicRegionNumber", EmitDefaultValue=false)]
        public int? SeismicRegionNumber { get; set; }
        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public Depth Depth { get; set; }
        /// <summary>
        /// Gets or Sets Magnitude
        /// </summary>
        [DataMember(Name="magnitude", EmitDefaultValue=false)]
        public Magnitude Magnitude { get; set; }
        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name="cause", EmitDefaultValue=false)]
        public string Cause { get; set; }
        /// <summary>
        /// Gets or Sets CulturalEffect
        /// </summary>
        [DataMember(Name="culturalEffect", EmitDefaultValue=false)]
        public string CulturalEffect { get; set; }
        /// <summary>
        /// Gets or Sets Intensity
        /// </summary>
        [DataMember(Name="intensity", EmitDefaultValue=false)]
        public int? Intensity { get; set; }
        /// <summary>
        /// Gets or Sets Diastrophism
        /// </summary>
        [DataMember(Name="diastrophism", EmitDefaultValue=false)]
        public string Diastrophism { get; set; }
        /// <summary>
        /// Gets or Sets MiscPhenomena
        /// </summary>
        [DataMember(Name="miscPhenomena", EmitDefaultValue=false)]
        public string MiscPhenomena { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public EarthquakeLocation Location { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarthquakeEvent {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  SeismicRegionNumber: ").Append(SeismicRegionNumber).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Magnitude: ").Append(Magnitude).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  CulturalEffect: ").Append(CulturalEffect).Append("\n");
            sb.Append("  Intensity: ").Append(Intensity).Append("\n");
            sb.Append("  Diastrophism: ").Append(Diastrophism).Append("\n");
            sb.Append("  MiscPhenomena: ").Append(MiscPhenomena).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as EarthquakeEvent);
        }

        /// <summary>
        /// Returns true if EarthquakeEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of EarthquakeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                ) && 
                (
                    this.SeismicRegionNumber == other.SeismicRegionNumber ||
                    this.SeismicRegionNumber != null &&
                    this.SeismicRegionNumber.Equals(other.SeismicRegionNumber)
                ) && 
                (
                    this.Depth == other.Depth ||
                    this.Depth != null &&
                    this.Depth.Equals(other.Depth)
                ) && 
                (
                    this.Magnitude == other.Magnitude ||
                    this.Magnitude != null &&
                    this.Magnitude.Equals(other.Magnitude)
                ) && 
                (
                    this.Cause == other.Cause ||
                    this.Cause != null &&
                    this.Cause.Equals(other.Cause)
                ) && 
                (
                    this.CulturalEffect == other.CulturalEffect ||
                    this.CulturalEffect != null &&
                    this.CulturalEffect.Equals(other.CulturalEffect)
                ) && 
                (
                    this.Intensity == other.Intensity ||
                    this.Intensity != null &&
                    this.Intensity.Equals(other.Intensity)
                ) && 
                (
                    this.Diastrophism == other.Diastrophism ||
                    this.Diastrophism != null &&
                    this.Diastrophism.Equals(other.Diastrophism)
                ) && 
                (
                    this.MiscPhenomena == other.MiscPhenomena ||
                    this.MiscPhenomena != null &&
                    this.MiscPhenomena.Equals(other.MiscPhenomena)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();
                if (this.SeismicRegionNumber != null)
                    hash = hash * 59 + this.SeismicRegionNumber.GetHashCode();
                if (this.Depth != null)
                    hash = hash * 59 + this.Depth.GetHashCode();
                if (this.Magnitude != null)
                    hash = hash * 59 + this.Magnitude.GetHashCode();
                if (this.Cause != null)
                    hash = hash * 59 + this.Cause.GetHashCode();
                if (this.CulturalEffect != null)
                    hash = hash * 59 + this.CulturalEffect.GetHashCode();
                if (this.Intensity != null)
                    hash = hash * 59 + this.Intensity.GetHashCode();
                if (this.Diastrophism != null)
                    hash = hash * 59 + this.Diastrophism.GetHashCode();
                if (this.MiscPhenomena != null)
                    hash = hash * 59 + this.MiscPhenomena.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                return hash;
            }
        }
    }

}
