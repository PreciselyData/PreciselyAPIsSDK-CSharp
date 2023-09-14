/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
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
    /// GetCityStateProvinceAPIOptions
    /// </summary>
    [DataContract]
    public partial class GetCityStateProvinceAPIOptions :  IEquatable<GetCityStateProvinceAPIOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCityStateProvinceAPIOptions" /> class.
        /// </summary>
        /// <param name="outputVanityCity">Output VanityCity. (default to &quot;N&quot;).</param>
        /// <param name="performCanadianProcessing">PerformCanadianProcessing. (default to &quot;Y&quot;).</param>
        /// <param name="maximumResults">MaximumResults. (default to &quot;10&quot;).</param>
        /// <param name="performUSProcessing">PerformUSProcessing. (default to &quot;Y&quot;).</param>
        public GetCityStateProvinceAPIOptions(string outputVanityCity = "N", string performCanadianProcessing = "Y", string maximumResults = "10", string performUSProcessing = "Y")
        {
            // use default value if no "outputVanityCity" provided
            if (outputVanityCity == null)
            {
                this.OutputVanityCity = "N";
            }
            else
            {
                this.OutputVanityCity = outputVanityCity;
            }
            // use default value if no "performCanadianProcessing" provided
            if (performCanadianProcessing == null)
            {
                this.PerformCanadianProcessing = "Y";
            }
            else
            {
                this.PerformCanadianProcessing = performCanadianProcessing;
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
            // use default value if no "performUSProcessing" provided
            if (performUSProcessing == null)
            {
                this.PerformUSProcessing = "Y";
            }
            else
            {
                this.PerformUSProcessing = performUSProcessing;
            }
        }

        /// <summary>
        /// Output VanityCity.
        /// </summary>
        /// <value>Output VanityCity.</value>
        [DataMember(Name="OutputVanityCity", EmitDefaultValue=false)]
        public string OutputVanityCity { get; set; }

        /// <summary>
        /// PerformCanadianProcessing.
        /// </summary>
        /// <value>PerformCanadianProcessing.</value>
        [DataMember(Name="PerformCanadianProcessing", EmitDefaultValue=false)]
        public string PerformCanadianProcessing { get; set; }

        /// <summary>
        /// MaximumResults.
        /// </summary>
        /// <value>MaximumResults.</value>
        [DataMember(Name="MaximumResults", EmitDefaultValue=false)]
        public string MaximumResults { get; set; }

        /// <summary>
        /// PerformUSProcessing.
        /// </summary>
        /// <value>PerformUSProcessing.</value>
        [DataMember(Name="PerformUSProcessing", EmitDefaultValue=false)]
        public string PerformUSProcessing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCityStateProvinceAPIOptions {\n");
            sb.Append("  OutputVanityCity: ").Append(OutputVanityCity).Append("\n");
            sb.Append("  PerformCanadianProcessing: ").Append(PerformCanadianProcessing).Append("\n");
            sb.Append("  MaximumResults: ").Append(MaximumResults).Append("\n");
            sb.Append("  PerformUSProcessing: ").Append(PerformUSProcessing).Append("\n");
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
            return this.Equals(input as GetCityStateProvinceAPIOptions);
        }

        /// <summary>
        /// Returns true if GetCityStateProvinceAPIOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCityStateProvinceAPIOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCityStateProvinceAPIOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputVanityCity == input.OutputVanityCity ||
                    (this.OutputVanityCity != null &&
                    this.OutputVanityCity.Equals(input.OutputVanityCity))
                ) && 
                (
                    this.PerformCanadianProcessing == input.PerformCanadianProcessing ||
                    (this.PerformCanadianProcessing != null &&
                    this.PerformCanadianProcessing.Equals(input.PerformCanadianProcessing))
                ) && 
                (
                    this.MaximumResults == input.MaximumResults ||
                    (this.MaximumResults != null &&
                    this.MaximumResults.Equals(input.MaximumResults))
                ) && 
                (
                    this.PerformUSProcessing == input.PerformUSProcessing ||
                    (this.PerformUSProcessing != null &&
                    this.PerformUSProcessing.Equals(input.PerformUSProcessing))
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
                if (this.OutputVanityCity != null)
                    hashCode = hashCode * 59 + this.OutputVanityCity.GetHashCode();
                if (this.PerformCanadianProcessing != null)
                    hashCode = hashCode * 59 + this.PerformCanadianProcessing.GetHashCode();
                if (this.MaximumResults != null)
                    hashCode = hashCode * 59 + this.MaximumResults.GetHashCode();
                if (this.PerformUSProcessing != null)
                    hashCode = hashCode * 59 + this.PerformUSProcessing.GetHashCode();
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
