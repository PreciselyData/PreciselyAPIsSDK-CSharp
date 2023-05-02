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
    /// GetCityStateProvinceAPIRequest
    /// </summary>
    [DataContract]
    public partial class GetCityStateProvinceAPIRequest :  IEquatable<GetCityStateProvinceAPIRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCityStateProvinceAPIRequest" /> class.
        /// </summary>
        /// <param name="options">options.</param>
        /// <param name="input">input.</param>
        public GetCityStateProvinceAPIRequest(GetCityStateProvinceAPIOptions options = default(GetCityStateProvinceAPIOptions), GetCityStateProvinceAPIInput input = default(GetCityStateProvinceAPIInput))
        {
            this.Options = options;
            this.Input = input;
        }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public GetCityStateProvinceAPIOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="Input", EmitDefaultValue=false)]
        public GetCityStateProvinceAPIInput Input { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCityStateProvinceAPIRequest {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
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
            return this.Equals(input as GetCityStateProvinceAPIRequest);
        }

        /// <summary>
        /// Returns true if GetCityStateProvinceAPIRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCityStateProvinceAPIRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCityStateProvinceAPIRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
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
