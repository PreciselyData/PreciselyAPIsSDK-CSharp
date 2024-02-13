/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// Magnitude
    /// </summary>
    [DataContract]
    public partial class Magnitude :  IEquatable<Magnitude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Magnitude" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="scale">scale.</param>
        /// <param name="bodyWave">bodyWave.</param>
        /// <param name="surfaceWave">surfaceWave.</param>
        /// <param name="surfaceWaveValue">surfaceWaveValue.</param>
        /// <param name="bodyWaveValue">bodyWaveValue.</param>
        public Magnitude(double value = default(double), string scale = default(string), double bodyWave = default(double), double surfaceWave = default(double), double surfaceWaveValue = default(double), double bodyWaveValue = default(double))
        {
            this.Value = value;
            this.Scale = scale;
            this.BodyWave = bodyWave;
            this.SurfaceWave = surfaceWave;
            this.SurfaceWaveValue = surfaceWaveValue;
            this.BodyWaveValue = bodyWaveValue;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public string Scale { get; set; }

        /// <summary>
        /// Gets or Sets BodyWave
        /// </summary>
        [DataMember(Name="bodyWave", EmitDefaultValue=false)]
        public double BodyWave { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceWave
        /// </summary>
        [DataMember(Name="surfaceWave", EmitDefaultValue=false)]
        public double SurfaceWave { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceWaveValue
        /// </summary>
        [DataMember(Name="surfaceWaveValue", EmitDefaultValue=false)]
        public double SurfaceWaveValue { get; set; }

        /// <summary>
        /// Gets or Sets BodyWaveValue
        /// </summary>
        [DataMember(Name="bodyWaveValue", EmitDefaultValue=false)]
        public double BodyWaveValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Magnitude {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  BodyWave: ").Append(BodyWave).Append("\n");
            sb.Append("  SurfaceWave: ").Append(SurfaceWave).Append("\n");
            sb.Append("  SurfaceWaveValue: ").Append(SurfaceWaveValue).Append("\n");
            sb.Append("  BodyWaveValue: ").Append(BodyWaveValue).Append("\n");
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
            return this.Equals(input as Magnitude);
        }

        /// <summary>
        /// Returns true if Magnitude instances are equal
        /// </summary>
        /// <param name="input">Instance of Magnitude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Magnitude input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Scale == input.Scale ||
                    (this.Scale != null &&
                    this.Scale.Equals(input.Scale))
                ) && 
                (
                    this.BodyWave == input.BodyWave ||
                    (this.BodyWave != null &&
                    this.BodyWave.Equals(input.BodyWave))
                ) && 
                (
                    this.SurfaceWave == input.SurfaceWave ||
                    (this.SurfaceWave != null &&
                    this.SurfaceWave.Equals(input.SurfaceWave))
                ) && 
                (
                    this.SurfaceWaveValue == input.SurfaceWaveValue ||
                    (this.SurfaceWaveValue != null &&
                    this.SurfaceWaveValue.Equals(input.SurfaceWaveValue))
                ) && 
                (
                    this.BodyWaveValue == input.BodyWaveValue ||
                    (this.BodyWaveValue != null &&
                    this.BodyWaveValue.Equals(input.BodyWaveValue))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                if (this.BodyWave != null)
                    hashCode = hashCode * 59 + this.BodyWave.GetHashCode();
                if (this.SurfaceWave != null)
                    hashCode = hashCode * 59 + this.SurfaceWave.GetHashCode();
                if (this.SurfaceWaveValue != null)
                    hashCode = hashCode * 59 + this.SurfaceWaveValue.GetHashCode();
                if (this.BodyWaveValue != null)
                    hashCode = hashCode * 59 + this.BodyWaveValue.GetHashCode();
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
