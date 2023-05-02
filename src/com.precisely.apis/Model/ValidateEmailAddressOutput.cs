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
    /// ValidateEmailAddressOutput
    /// </summary>
    [DataContract]
    public partial class ValidateEmailAddressOutput :  IEquatable<ValidateEmailAddressOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressOutput" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="eMAIL">The email address submitted for verification..</param>
        /// <param name="fINDING">One character code indicating the validity of the submitted email address..</param>
        /// <param name="cOMMENT">The comment string pertaining to the result of the submitted email address..</param>
        /// <param name="cOMMENTCODE">A short code which maps to each returned COMMENT field value..</param>
        /// <param name="sUGGEMAIL">Suggested correction for submitted email address, if found. A suggestion will only be provided if it is valid and SafeToDeliver..</param>
        /// <param name="sUGGCOMMENT">This field contains suggestion not SafeToDeliver when ValidateEmailAddress corrected the address and the corrected version of the email address failed one or more SafeToDeliver process checks..</param>
        /// <param name="eRRORRESPONSE">Pre-formatted response intended to be provided to user..</param>
        /// <param name="eRROR">Field reserved for special features only..</param>
        /// <param name="status">status.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="statusDescription">statusDescription.</param>
        public ValidateEmailAddressOutput(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string eMAIL = default(string), string fINDING = default(string), string cOMMENT = default(string), string cOMMENTCODE = default(string), string sUGGEMAIL = default(string), string sUGGCOMMENT = default(string), string eRRORRESPONSE = default(string), string eRROR = default(string), string status = default(string), string statusCode = default(string), string statusDescription = default(string))
        {
            this.UserFields = userFields;
            this.EMAIL = eMAIL;
            this.FINDING = fINDING;
            this.COMMENT = cOMMENT;
            this.COMMENT_CODE = cOMMENTCODE;
            this.SUGG_EMAIL = sUGGEMAIL;
            this.SUGG_COMMENT = sUGGCOMMENT;
            this.ERROR_RESPONSE = eRRORRESPONSE;
            this.ERROR = eRROR;
            this.Status = status;
            this.StatusCode = statusCode;
            this.StatusDescription = statusDescription;
        }

        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<GetPostalCodesAPIOutputUserFields> UserFields { get; set; }

        /// <summary>
        /// The email address submitted for verification.
        /// </summary>
        /// <value>The email address submitted for verification.</value>
        [DataMember(Name="EMAIL", EmitDefaultValue=false)]
        public string EMAIL { get; set; }

        /// <summary>
        /// One character code indicating the validity of the submitted email address.
        /// </summary>
        /// <value>One character code indicating the validity of the submitted email address.</value>
        [DataMember(Name="FINDING", EmitDefaultValue=false)]
        public string FINDING { get; set; }

        /// <summary>
        /// The comment string pertaining to the result of the submitted email address.
        /// </summary>
        /// <value>The comment string pertaining to the result of the submitted email address.</value>
        [DataMember(Name="COMMENT", EmitDefaultValue=false)]
        public string COMMENT { get; set; }

        /// <summary>
        /// A short code which maps to each returned COMMENT field value.
        /// </summary>
        /// <value>A short code which maps to each returned COMMENT field value.</value>
        [DataMember(Name="COMMENT_CODE", EmitDefaultValue=false)]
        public string COMMENT_CODE { get; set; }

        /// <summary>
        /// Suggested correction for submitted email address, if found. A suggestion will only be provided if it is valid and SafeToDeliver.
        /// </summary>
        /// <value>Suggested correction for submitted email address, if found. A suggestion will only be provided if it is valid and SafeToDeliver.</value>
        [DataMember(Name="SUGG_EMAIL", EmitDefaultValue=false)]
        public string SUGG_EMAIL { get; set; }

        /// <summary>
        /// This field contains suggestion not SafeToDeliver when ValidateEmailAddress corrected the address and the corrected version of the email address failed one or more SafeToDeliver process checks.
        /// </summary>
        /// <value>This field contains suggestion not SafeToDeliver when ValidateEmailAddress corrected the address and the corrected version of the email address failed one or more SafeToDeliver process checks.</value>
        [DataMember(Name="SUGG_COMMENT", EmitDefaultValue=false)]
        public string SUGG_COMMENT { get; set; }

        /// <summary>
        /// Pre-formatted response intended to be provided to user.
        /// </summary>
        /// <value>Pre-formatted response intended to be provided to user.</value>
        [DataMember(Name="ERROR_RESPONSE", EmitDefaultValue=false)]
        public string ERROR_RESPONSE { get; set; }

        /// <summary>
        /// Field reserved for special features only.
        /// </summary>
        /// <value>Field reserved for special features only.</value>
        [DataMember(Name="ERROR", EmitDefaultValue=false)]
        public string ERROR { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="Status.Code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name="Status.Description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateEmailAddressOutput {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  EMAIL: ").Append(EMAIL).Append("\n");
            sb.Append("  FINDING: ").Append(FINDING).Append("\n");
            sb.Append("  COMMENT: ").Append(COMMENT).Append("\n");
            sb.Append("  COMMENT_CODE: ").Append(COMMENT_CODE).Append("\n");
            sb.Append("  SUGG_EMAIL: ").Append(SUGG_EMAIL).Append("\n");
            sb.Append("  SUGG_COMMENT: ").Append(SUGG_COMMENT).Append("\n");
            sb.Append("  ERROR_RESPONSE: ").Append(ERROR_RESPONSE).Append("\n");
            sb.Append("  ERROR: ").Append(ERROR).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
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
            return this.Equals(input as ValidateEmailAddressOutput);
        }

        /// <summary>
        /// Returns true if ValidateEmailAddressOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateEmailAddressOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateEmailAddressOutput input)
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
                    this.EMAIL == input.EMAIL ||
                    (this.EMAIL != null &&
                    this.EMAIL.Equals(input.EMAIL))
                ) && 
                (
                    this.FINDING == input.FINDING ||
                    (this.FINDING != null &&
                    this.FINDING.Equals(input.FINDING))
                ) && 
                (
                    this.COMMENT == input.COMMENT ||
                    (this.COMMENT != null &&
                    this.COMMENT.Equals(input.COMMENT))
                ) && 
                (
                    this.COMMENT_CODE == input.COMMENT_CODE ||
                    (this.COMMENT_CODE != null &&
                    this.COMMENT_CODE.Equals(input.COMMENT_CODE))
                ) && 
                (
                    this.SUGG_EMAIL == input.SUGG_EMAIL ||
                    (this.SUGG_EMAIL != null &&
                    this.SUGG_EMAIL.Equals(input.SUGG_EMAIL))
                ) && 
                (
                    this.SUGG_COMMENT == input.SUGG_COMMENT ||
                    (this.SUGG_COMMENT != null &&
                    this.SUGG_COMMENT.Equals(input.SUGG_COMMENT))
                ) && 
                (
                    this.ERROR_RESPONSE == input.ERROR_RESPONSE ||
                    (this.ERROR_RESPONSE != null &&
                    this.ERROR_RESPONSE.Equals(input.ERROR_RESPONSE))
                ) && 
                (
                    this.ERROR == input.ERROR ||
                    (this.ERROR != null &&
                    this.ERROR.Equals(input.ERROR))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
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
                if (this.EMAIL != null)
                    hashCode = hashCode * 59 + this.EMAIL.GetHashCode();
                if (this.FINDING != null)
                    hashCode = hashCode * 59 + this.FINDING.GetHashCode();
                if (this.COMMENT != null)
                    hashCode = hashCode * 59 + this.COMMENT.GetHashCode();
                if (this.COMMENT_CODE != null)
                    hashCode = hashCode * 59 + this.COMMENT_CODE.GetHashCode();
                if (this.SUGG_EMAIL != null)
                    hashCode = hashCode * 59 + this.SUGG_EMAIL.GetHashCode();
                if (this.SUGG_COMMENT != null)
                    hashCode = hashCode * 59 + this.SUGG_COMMENT.GetHashCode();
                if (this.ERROR_RESPONSE != null)
                    hashCode = hashCode * 59 + this.ERROR_RESPONSE.GetHashCode();
                if (this.ERROR != null)
                    hashCode = hashCode * 59 + this.ERROR.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
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
