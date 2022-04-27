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
    /// GetCityStateProvinceAPIInputRow
    /// </summary>
    [DataContract]
    public partial class GetCityStateProvinceAPIInputRow :  IEquatable<GetCityStateProvinceAPIInputRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCityStateProvinceAPIInputRow" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="postalCode">The validated ZIP Code or postal code..</param>
        public GetCityStateProvinceAPIInputRow(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string postalCode = default(string))
        {
            this.UserFields = userFields;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<GetPostalCodesAPIOutputUserFields> UserFields { get; set; }

        /// <summary>
        /// The validated ZIP Code or postal code.
        /// </summary>
        /// <value>The validated ZIP Code or postal code.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCityStateProvinceAPIInputRow {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as GetCityStateProvinceAPIInputRow);
        }

        /// <summary>
        /// Returns true if GetCityStateProvinceAPIInputRow instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCityStateProvinceAPIInputRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCityStateProvinceAPIInputRow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserFields == input.UserFields ||
                    this.UserFields != null &&
                    input.UserFields != null &&
                    this.UserFields.SequenceEqual(input.UserFields)
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.UserFields != null)
                    hashCode = hashCode * 59 + this.UserFields.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
