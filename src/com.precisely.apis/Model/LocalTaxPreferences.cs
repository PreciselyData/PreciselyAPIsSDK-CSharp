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
    /// LocalTaxPreferences
    /// </summary>
    [DataContract]
    public partial class LocalTaxPreferences :  IEquatable<LocalTaxPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalTaxPreferences" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalTaxPreferences() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalTaxPreferences" /> class.
        /// </summary>
        /// <param name="customPreferences">customPreferences.</param>
        /// <param name="defaultBufferWidth">defaultBufferWidth.</param>
        /// <param name="distanceUnits">distanceUnits.</param>
        /// <param name="fallbackToGeographic">fallbackToGeographic (required).</param>
        /// <param name="latLongFormat">latLongFormat.</param>
        /// <param name="latLongOffset">latLongOffset.</param>
        /// <param name="matchMode">matchMode.</param>
        /// <param name="outputCasing">outputCasing.</param>
        /// <param name="returnCensusFields">returnCensusFields.</param>
        /// <param name="returnLatLongFields">returnLatLongFields.</param>
        /// <param name="squeeze">squeeze.</param>
        /// <param name="taxRatetypeID">taxRatetypeID.</param>
        /// <param name="useGeoTaxAuxiliaryFile">useGeoTaxAuxiliaryFile.</param>
        public LocalTaxPreferences(Dictionary<string, Object> customPreferences = default(Dictionary<string, Object>), string defaultBufferWidth = default(string), string distanceUnits = default(string), string fallbackToGeographic = default(string), string latLongFormat = default(string), string latLongOffset = default(string), string matchMode = default(string), string outputCasing = default(string), string returnCensusFields = default(string), string returnLatLongFields = default(string), string squeeze = default(string), string taxRatetypeID = default(string), string useGeoTaxAuxiliaryFile = default(string))
        {
            // to ensure "fallbackToGeographic" is required (not null)
            if (fallbackToGeographic == null)
            {
                throw new InvalidDataException("fallbackToGeographic is a required property for LocalTaxPreferences and cannot be null");
            }
            else
            {
                this.FallbackToGeographic = fallbackToGeographic;
            }

            this.CustomPreferences = customPreferences;
            this.DefaultBufferWidth = defaultBufferWidth;
            this.DistanceUnits = distanceUnits;
            this.LatLongFormat = latLongFormat;
            this.LatLongOffset = latLongOffset;
            this.MatchMode = matchMode;
            this.OutputCasing = outputCasing;
            this.ReturnCensusFields = returnCensusFields;
            this.ReturnLatLongFields = returnLatLongFields;
            this.Squeeze = squeeze;
            this.TaxRatetypeID = taxRatetypeID;
            this.UseGeoTaxAuxiliaryFile = useGeoTaxAuxiliaryFile;
        }

        /// <summary>
        /// Gets or Sets CustomPreferences
        /// </summary>
        [DataMember(Name="customPreferences", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomPreferences { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBufferWidth
        /// </summary>
        [DataMember(Name="defaultBufferWidth", EmitDefaultValue=false)]
        public string DefaultBufferWidth { get; set; }

        /// <summary>
        /// Gets or Sets DistanceUnits
        /// </summary>
        [DataMember(Name="distanceUnits", EmitDefaultValue=false)]
        public string DistanceUnits { get; set; }

        /// <summary>
        /// Gets or Sets FallbackToGeographic
        /// </summary>
        [DataMember(Name="fallbackToGeographic", EmitDefaultValue=true)]
        public string FallbackToGeographic { get; set; }

        /// <summary>
        /// Gets or Sets LatLongFormat
        /// </summary>
        [DataMember(Name="latLongFormat", EmitDefaultValue=false)]
        public string LatLongFormat { get; set; }

        /// <summary>
        /// Gets or Sets LatLongOffset
        /// </summary>
        [DataMember(Name="latLongOffset", EmitDefaultValue=false)]
        public string LatLongOffset { get; set; }

        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// Gets or Sets OutputCasing
        /// </summary>
        [DataMember(Name="outputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }

        /// <summary>
        /// Gets or Sets ReturnCensusFields
        /// </summary>
        [DataMember(Name="returnCensusFields", EmitDefaultValue=false)]
        public string ReturnCensusFields { get; set; }

        /// <summary>
        /// Gets or Sets ReturnLatLongFields
        /// </summary>
        [DataMember(Name="returnLatLongFields", EmitDefaultValue=false)]
        public string ReturnLatLongFields { get; set; }

        /// <summary>
        /// Gets or Sets Squeeze
        /// </summary>
        [DataMember(Name="squeeze", EmitDefaultValue=false)]
        public string Squeeze { get; set; }

        /// <summary>
        /// Gets or Sets TaxRatetypeID
        /// </summary>
        [DataMember(Name="taxRatetypeID", EmitDefaultValue=false)]
        public string TaxRatetypeID { get; set; }

        /// <summary>
        /// Gets or Sets UseGeoTaxAuxiliaryFile
        /// </summary>
        [DataMember(Name="useGeoTaxAuxiliaryFile", EmitDefaultValue=false)]
        public string UseGeoTaxAuxiliaryFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalTaxPreferences {\n");
            sb.Append("  CustomPreferences: ").Append(CustomPreferences).Append("\n");
            sb.Append("  DefaultBufferWidth: ").Append(DefaultBufferWidth).Append("\n");
            sb.Append("  DistanceUnits: ").Append(DistanceUnits).Append("\n");
            sb.Append("  FallbackToGeographic: ").Append(FallbackToGeographic).Append("\n");
            sb.Append("  LatLongFormat: ").Append(LatLongFormat).Append("\n");
            sb.Append("  LatLongOffset: ").Append(LatLongOffset).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  ReturnCensusFields: ").Append(ReturnCensusFields).Append("\n");
            sb.Append("  ReturnLatLongFields: ").Append(ReturnLatLongFields).Append("\n");
            sb.Append("  Squeeze: ").Append(Squeeze).Append("\n");
            sb.Append("  TaxRatetypeID: ").Append(TaxRatetypeID).Append("\n");
            sb.Append("  UseGeoTaxAuxiliaryFile: ").Append(UseGeoTaxAuxiliaryFile).Append("\n");
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
            return this.Equals(input as LocalTaxPreferences);
        }

        /// <summary>
        /// Returns true if LocalTaxPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalTaxPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalTaxPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomPreferences == input.CustomPreferences ||
                    this.CustomPreferences != null &&
                    input.CustomPreferences != null &&
                    this.CustomPreferences.SequenceEqual(input.CustomPreferences)
                ) && 
                (
                    this.DefaultBufferWidth == input.DefaultBufferWidth ||
                    (this.DefaultBufferWidth != null &&
                    this.DefaultBufferWidth.Equals(input.DefaultBufferWidth))
                ) && 
                (
                    this.DistanceUnits == input.DistanceUnits ||
                    (this.DistanceUnits != null &&
                    this.DistanceUnits.Equals(input.DistanceUnits))
                ) && 
                (
                    this.FallbackToGeographic == input.FallbackToGeographic ||
                    (this.FallbackToGeographic != null &&
                    this.FallbackToGeographic.Equals(input.FallbackToGeographic))
                ) && 
                (
                    this.LatLongFormat == input.LatLongFormat ||
                    (this.LatLongFormat != null &&
                    this.LatLongFormat.Equals(input.LatLongFormat))
                ) && 
                (
                    this.LatLongOffset == input.LatLongOffset ||
                    (this.LatLongOffset != null &&
                    this.LatLongOffset.Equals(input.LatLongOffset))
                ) && 
                (
                    this.MatchMode == input.MatchMode ||
                    (this.MatchMode != null &&
                    this.MatchMode.Equals(input.MatchMode))
                ) && 
                (
                    this.OutputCasing == input.OutputCasing ||
                    (this.OutputCasing != null &&
                    this.OutputCasing.Equals(input.OutputCasing))
                ) && 
                (
                    this.ReturnCensusFields == input.ReturnCensusFields ||
                    (this.ReturnCensusFields != null &&
                    this.ReturnCensusFields.Equals(input.ReturnCensusFields))
                ) && 
                (
                    this.ReturnLatLongFields == input.ReturnLatLongFields ||
                    (this.ReturnLatLongFields != null &&
                    this.ReturnLatLongFields.Equals(input.ReturnLatLongFields))
                ) && 
                (
                    this.Squeeze == input.Squeeze ||
                    (this.Squeeze != null &&
                    this.Squeeze.Equals(input.Squeeze))
                ) && 
                (
                    this.TaxRatetypeID == input.TaxRatetypeID ||
                    (this.TaxRatetypeID != null &&
                    this.TaxRatetypeID.Equals(input.TaxRatetypeID))
                ) && 
                (
                    this.UseGeoTaxAuxiliaryFile == input.UseGeoTaxAuxiliaryFile ||
                    (this.UseGeoTaxAuxiliaryFile != null &&
                    this.UseGeoTaxAuxiliaryFile.Equals(input.UseGeoTaxAuxiliaryFile))
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
                if (this.CustomPreferences != null)
                    hashCode = hashCode * 59 + this.CustomPreferences.GetHashCode();
                if (this.DefaultBufferWidth != null)
                    hashCode = hashCode * 59 + this.DefaultBufferWidth.GetHashCode();
                if (this.DistanceUnits != null)
                    hashCode = hashCode * 59 + this.DistanceUnits.GetHashCode();
                if (this.FallbackToGeographic != null)
                    hashCode = hashCode * 59 + this.FallbackToGeographic.GetHashCode();
                if (this.LatLongFormat != null)
                    hashCode = hashCode * 59 + this.LatLongFormat.GetHashCode();
                if (this.LatLongOffset != null)
                    hashCode = hashCode * 59 + this.LatLongOffset.GetHashCode();
                if (this.MatchMode != null)
                    hashCode = hashCode * 59 + this.MatchMode.GetHashCode();
                if (this.OutputCasing != null)
                    hashCode = hashCode * 59 + this.OutputCasing.GetHashCode();
                if (this.ReturnCensusFields != null)
                    hashCode = hashCode * 59 + this.ReturnCensusFields.GetHashCode();
                if (this.ReturnLatLongFields != null)
                    hashCode = hashCode * 59 + this.ReturnLatLongFields.GetHashCode();
                if (this.Squeeze != null)
                    hashCode = hashCode * 59 + this.Squeeze.GetHashCode();
                if (this.TaxRatetypeID != null)
                    hashCode = hashCode * 59 + this.TaxRatetypeID.GetHashCode();
                if (this.UseGeoTaxAuxiliaryFile != null)
                    hashCode = hashCode * 59 + this.UseGeoTaxAuxiliaryFile.GetHashCode();
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
