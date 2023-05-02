/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// EarthquakeEvent
    /// </summary>
    [DataContract]
    public partial class EarthquakeEvent :  IEquatable<EarthquakeEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeEvent" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="seismicRegionNumber">seismicRegionNumber.</param>
        /// <param name="depth">depth.</param>
        /// <param name="magnitude">magnitude.</param>
        /// <param name="cause">cause.</param>
        /// <param name="culturalEffect">culturalEffect.</param>
        /// <param name="intensity">intensity.</param>
        /// <param name="diastrophism">diastrophism.</param>
        /// <param name="miscPhenomena">miscPhenomena.</param>
        /// <param name="location">location.</param>
        public EarthquakeEvent(EarthquakeDateTime dateTime = default(EarthquakeDateTime), int seismicRegionNumber = default(int), Depth depth = default(Depth), Magnitude magnitude = default(Magnitude), string cause = default(string), string culturalEffect = default(string), int intensity = default(int), string diastrophism = default(string), string miscPhenomena = default(string), EarthquakeLocation location = default(EarthquakeLocation))
        {
            this.DateTime = dateTime;
            this.SeismicRegionNumber = seismicRegionNumber;
            this.Depth = depth;
            this.Magnitude = magnitude;
            this.Cause = cause;
            this.CulturalEffect = culturalEffect;
            this.Intensity = intensity;
            this.Diastrophism = diastrophism;
            this.MiscPhenomena = miscPhenomena;
            this.Location = location;
        }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public EarthquakeDateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets SeismicRegionNumber
        /// </summary>
        [DataMember(Name="seismicRegionNumber", EmitDefaultValue=false)]
        public int SeismicRegionNumber { get; set; }

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
        public int Intensity { get; set; }

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
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EarthquakeEvent);
        }

        /// <summary>
        /// Returns true if EarthquakeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EarthquakeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.SeismicRegionNumber == input.SeismicRegionNumber ||
                    (this.SeismicRegionNumber != null &&
                    this.SeismicRegionNumber.Equals(input.SeismicRegionNumber))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.Magnitude == input.Magnitude ||
                    (this.Magnitude != null &&
                    this.Magnitude.Equals(input.Magnitude))
                ) && 
                (
                    this.Cause == input.Cause ||
                    (this.Cause != null &&
                    this.Cause.Equals(input.Cause))
                ) && 
                (
                    this.CulturalEffect == input.CulturalEffect ||
                    (this.CulturalEffect != null &&
                    this.CulturalEffect.Equals(input.CulturalEffect))
                ) && 
                (
                    this.Intensity == input.Intensity ||
                    (this.Intensity != null &&
                    this.Intensity.Equals(input.Intensity))
                ) && 
                (
                    this.Diastrophism == input.Diastrophism ||
                    (this.Diastrophism != null &&
                    this.Diastrophism.Equals(input.Diastrophism))
                ) && 
                (
                    this.MiscPhenomena == input.MiscPhenomena ||
                    (this.MiscPhenomena != null &&
                    this.MiscPhenomena.Equals(input.MiscPhenomena))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.SeismicRegionNumber != null)
                    hashCode = hashCode * 59 + this.SeismicRegionNumber.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Magnitude != null)
                    hashCode = hashCode * 59 + this.Magnitude.GetHashCode();
                if (this.Cause != null)
                    hashCode = hashCode * 59 + this.Cause.GetHashCode();
                if (this.CulturalEffect != null)
                    hashCode = hashCode * 59 + this.CulturalEffect.GetHashCode();
                if (this.Intensity != null)
                    hashCode = hashCode * 59 + this.Intensity.GetHashCode();
                if (this.Diastrophism != null)
                    hashCode = hashCode * 59 + this.Diastrophism.GetHashCode();
                if (this.MiscPhenomena != null)
                    hashCode = hashCode * 59 + this.MiscPhenomena.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
