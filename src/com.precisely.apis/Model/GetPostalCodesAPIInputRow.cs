/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 14.0.0
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
    /// GetPostalCodesAPIInputRow
    /// </summary>
    [DataContract]
    public partial class GetPostalCodesAPIInputRow :  IEquatable<GetPostalCodesAPIInputRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPostalCodesAPIInputRow" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="city">The city name..</param>
        /// <param name="stateProvince">The state or province..</param>
        public GetPostalCodesAPIInputRow(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string city = default(string), string stateProvince = default(string))
        {
            this.UserFields = userFields;
            this.City = city;
            this.StateProvince = stateProvince;
        }

        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<GetPostalCodesAPIOutputUserFields> UserFields { get; set; }

        /// <summary>
        /// The city name.
        /// </summary>
        /// <value>The city name.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The state or province.
        /// </summary>
        /// <value>The state or province.</value>
        [DataMember(Name="StateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPostalCodesAPIInputRow {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
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
            return this.Equals(input as GetPostalCodesAPIInputRow);
        }

        /// <summary>
        /// Returns true if GetPostalCodesAPIInputRow instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPostalCodesAPIInputRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPostalCodesAPIInputRow input)
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
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
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
