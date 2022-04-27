/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.2
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
    /// GetPostalCodesAPIOptions
    /// </summary>
    [DataContract]
    public partial class GetPostalCodesAPIOptions :  IEquatable<GetPostalCodesAPIOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPostalCodesAPIOptions" /> class.
        /// </summary>
        /// <param name="outputCityType">Output CityType. (default to &quot;N&quot;).</param>
        /// <param name="outputVanityCity">Output VanityCity. (default to &quot;N&quot;).</param>
        public GetPostalCodesAPIOptions(string outputCityType = "N", string outputVanityCity = "N")
        {
            // use default value if no "outputCityType" provided
            if (outputCityType == null)
            {
                this.OutputCityType = "N";
            }
            else
            {
                this.OutputCityType = outputCityType;
            }
            // use default value if no "outputVanityCity" provided
            if (outputVanityCity == null)
            {
                this.OutputVanityCity = "N";
            }
            else
            {
                this.OutputVanityCity = outputVanityCity;
            }
        }

        /// <summary>
        /// Output CityType.
        /// </summary>
        /// <value>Output CityType.</value>
        [DataMember(Name="OutputCityType", EmitDefaultValue=false)]
        public string OutputCityType { get; set; }

        /// <summary>
        /// Output VanityCity.
        /// </summary>
        /// <value>Output VanityCity.</value>
        [DataMember(Name="OutputVanityCity", EmitDefaultValue=false)]
        public string OutputVanityCity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPostalCodesAPIOptions {\n");
            sb.Append("  OutputCityType: ").Append(OutputCityType).Append("\n");
            sb.Append("  OutputVanityCity: ").Append(OutputVanityCity).Append("\n");
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
            return this.Equals(input as GetPostalCodesAPIOptions);
        }

        /// <summary>
        /// Returns true if GetPostalCodesAPIOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPostalCodesAPIOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPostalCodesAPIOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputCityType == input.OutputCityType ||
                    (this.OutputCityType != null &&
                    this.OutputCityType.Equals(input.OutputCityType))
                ) && 
                (
                    this.OutputVanityCity == input.OutputVanityCity ||
                    (this.OutputVanityCity != null &&
                    this.OutputVanityCity.Equals(input.OutputVanityCity))
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
                if (this.OutputCityType != null)
                    hashCode = hashCode * 59 + this.OutputCityType.GetHashCode();
                if (this.OutputVanityCity != null)
                    hashCode = hashCode * 59 + this.OutputVanityCity.GetHashCode();
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
