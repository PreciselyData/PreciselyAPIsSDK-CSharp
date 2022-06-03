/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.3
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
    /// ValidateMailingAddressPremiumOptions
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressPremiumOptions :  IEquatable<ValidateMailingAddressPremiumOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressPremiumOptions" /> class.
        /// </summary>
        /// <param name="outputAddressBlocks">Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece. (default to &quot;Y&quot;).</param>
        /// <param name="keepMultimatch">Specifies whether to return multiple address for those input addresses that have more than one possible match. (default to &quot;N&quot;).</param>
        /// <param name="outputCountryFormat">Specifies the format to use for the country name returned in the Country output field. (default to &quot;E&quot;).</param>
        /// <param name="outputRecordType">Specifies the type of output record you get. (default to &quot;A&quot;).</param>
        /// <param name="outputFieldLevelReturnCodes">Specifies whether to include field-level result indicators. (default to &quot;N&quot;).</param>
        /// <param name="outputScript">Specifies the alphabet or script in which the output should be returned. (default to &quot;InputScript&quot;).</param>
        /// <param name="outputCasing">Specify the casing of the output data. (default to &quot;M&quot;).</param>
        /// <param name="maximumResults">A number between 1 and 10 that indicates the maximum number of addresses to return. (default to &quot;10&quot;).</param>
        public ValidateMailingAddressPremiumOptions(string outputAddressBlocks = "Y", string keepMultimatch = "N", string outputCountryFormat = "E", string outputRecordType = "A", string outputFieldLevelReturnCodes = "N", string outputScript = "InputScript", string outputCasing = "M", string maximumResults = "10")
        {
            // use default value if no "outputAddressBlocks" provided
            if (outputAddressBlocks == null)
            {
                this.OutputAddressBlocks = "Y";
            }
            else
            {
                this.OutputAddressBlocks = outputAddressBlocks;
            }
            // use default value if no "keepMultimatch" provided
            if (keepMultimatch == null)
            {
                this.KeepMultimatch = "N";
            }
            else
            {
                this.KeepMultimatch = keepMultimatch;
            }
            // use default value if no "outputCountryFormat" provided
            if (outputCountryFormat == null)
            {
                this.OutputCountryFormat = "E";
            }
            else
            {
                this.OutputCountryFormat = outputCountryFormat;
            }
            // use default value if no "outputRecordType" provided
            if (outputRecordType == null)
            {
                this.OutputRecordType = "A";
            }
            else
            {
                this.OutputRecordType = outputRecordType;
            }
            // use default value if no "outputFieldLevelReturnCodes" provided
            if (outputFieldLevelReturnCodes == null)
            {
                this.OutputFieldLevelReturnCodes = "N";
            }
            else
            {
                this.OutputFieldLevelReturnCodes = outputFieldLevelReturnCodes;
            }
            // use default value if no "outputScript" provided
            if (outputScript == null)
            {
                this.OutputScript = "InputScript";
            }
            else
            {
                this.OutputScript = outputScript;
            }
            // use default value if no "outputCasing" provided
            if (outputCasing == null)
            {
                this.OutputCasing = "M";
            }
            else
            {
                this.OutputCasing = outputCasing;
            }
            // use default value if no "maximumResults" provided
            if (maximumResults == null)
            {
                this.MaximumResults = "10";
            }
            else
            {
                this.MaximumResults = maximumResults;
            }
        }

        /// <summary>
        /// Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece.
        /// </summary>
        /// <value>Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece.</value>
        [DataMember(Name="OutputAddressBlocks", EmitDefaultValue=false)]
        public string OutputAddressBlocks { get; set; }

        /// <summary>
        /// Specifies whether to return multiple address for those input addresses that have more than one possible match.
        /// </summary>
        /// <value>Specifies whether to return multiple address for those input addresses that have more than one possible match.</value>
        [DataMember(Name="KeepMultimatch", EmitDefaultValue=false)]
        public string KeepMultimatch { get; set; }

        /// <summary>
        /// Specifies the format to use for the country name returned in the Country output field.
        /// </summary>
        /// <value>Specifies the format to use for the country name returned in the Country output field.</value>
        [DataMember(Name="OutputCountryFormat", EmitDefaultValue=false)]
        public string OutputCountryFormat { get; set; }

        /// <summary>
        /// Specifies the type of output record you get.
        /// </summary>
        /// <value>Specifies the type of output record you get.</value>
        [DataMember(Name="OutputRecordType", EmitDefaultValue=false)]
        public string OutputRecordType { get; set; }

        /// <summary>
        /// Specifies whether to include field-level result indicators.
        /// </summary>
        /// <value>Specifies whether to include field-level result indicators.</value>
        [DataMember(Name="OutputFieldLevelReturnCodes", EmitDefaultValue=false)]
        public string OutputFieldLevelReturnCodes { get; set; }

        /// <summary>
        /// Specifies the alphabet or script in which the output should be returned.
        /// </summary>
        /// <value>Specifies the alphabet or script in which the output should be returned.</value>
        [DataMember(Name="OutputScript", EmitDefaultValue=false)]
        public string OutputScript { get; set; }

        /// <summary>
        /// Specify the casing of the output data.
        /// </summary>
        /// <value>Specify the casing of the output data.</value>
        [DataMember(Name="OutputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }

        /// <summary>
        /// A number between 1 and 10 that indicates the maximum number of addresses to return.
        /// </summary>
        /// <value>A number between 1 and 10 that indicates the maximum number of addresses to return.</value>
        [DataMember(Name="MaximumResults", EmitDefaultValue=false)]
        public string MaximumResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateMailingAddressPremiumOptions {\n");
            sb.Append("  OutputAddressBlocks: ").Append(OutputAddressBlocks).Append("\n");
            sb.Append("  KeepMultimatch: ").Append(KeepMultimatch).Append("\n");
            sb.Append("  OutputCountryFormat: ").Append(OutputCountryFormat).Append("\n");
            sb.Append("  OutputRecordType: ").Append(OutputRecordType).Append("\n");
            sb.Append("  OutputFieldLevelReturnCodes: ").Append(OutputFieldLevelReturnCodes).Append("\n");
            sb.Append("  OutputScript: ").Append(OutputScript).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  MaximumResults: ").Append(MaximumResults).Append("\n");
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
            return this.Equals(input as ValidateMailingAddressPremiumOptions);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressPremiumOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateMailingAddressPremiumOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressPremiumOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputAddressBlocks == input.OutputAddressBlocks ||
                    (this.OutputAddressBlocks != null &&
                    this.OutputAddressBlocks.Equals(input.OutputAddressBlocks))
                ) && 
                (
                    this.KeepMultimatch == input.KeepMultimatch ||
                    (this.KeepMultimatch != null &&
                    this.KeepMultimatch.Equals(input.KeepMultimatch))
                ) && 
                (
                    this.OutputCountryFormat == input.OutputCountryFormat ||
                    (this.OutputCountryFormat != null &&
                    this.OutputCountryFormat.Equals(input.OutputCountryFormat))
                ) && 
                (
                    this.OutputRecordType == input.OutputRecordType ||
                    (this.OutputRecordType != null &&
                    this.OutputRecordType.Equals(input.OutputRecordType))
                ) && 
                (
                    this.OutputFieldLevelReturnCodes == input.OutputFieldLevelReturnCodes ||
                    (this.OutputFieldLevelReturnCodes != null &&
                    this.OutputFieldLevelReturnCodes.Equals(input.OutputFieldLevelReturnCodes))
                ) && 
                (
                    this.OutputScript == input.OutputScript ||
                    (this.OutputScript != null &&
                    this.OutputScript.Equals(input.OutputScript))
                ) && 
                (
                    this.OutputCasing == input.OutputCasing ||
                    (this.OutputCasing != null &&
                    this.OutputCasing.Equals(input.OutputCasing))
                ) && 
                (
                    this.MaximumResults == input.MaximumResults ||
                    (this.MaximumResults != null &&
                    this.MaximumResults.Equals(input.MaximumResults))
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
                if (this.OutputAddressBlocks != null)
                    hashCode = hashCode * 59 + this.OutputAddressBlocks.GetHashCode();
                if (this.KeepMultimatch != null)
                    hashCode = hashCode * 59 + this.KeepMultimatch.GetHashCode();
                if (this.OutputCountryFormat != null)
                    hashCode = hashCode * 59 + this.OutputCountryFormat.GetHashCode();
                if (this.OutputRecordType != null)
                    hashCode = hashCode * 59 + this.OutputRecordType.GetHashCode();
                if (this.OutputFieldLevelReturnCodes != null)
                    hashCode = hashCode * 59 + this.OutputFieldLevelReturnCodes.GetHashCode();
                if (this.OutputScript != null)
                    hashCode = hashCode * 59 + this.OutputScript.GetHashCode();
                if (this.OutputCasing != null)
                    hashCode = hashCode * 59 + this.OutputCasing.GetHashCode();
                if (this.MaximumResults != null)
                    hashCode = hashCode * 59 + this.MaximumResults.GetHashCode();
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
