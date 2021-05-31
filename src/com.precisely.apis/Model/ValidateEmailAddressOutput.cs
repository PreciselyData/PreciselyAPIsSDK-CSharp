/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// ValidateEmailAddressOutput
    /// </summary>
    [DataContract]
    public partial class ValidateEmailAddressOutput :  IEquatable<ValidateEmailAddressOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressOutput" /> class.
        /// </summary>
        /// <param name="UserFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="EMAIL">The email address submitted for verification..</param>
        /// <param name="FINDING">One character code indicating the validity of the submitted email address..</param>
        /// <param name="COMMENT">The comment string pertaining to the result of the submitted email address..</param>
        /// <param name="COMMENT_CODE">A short code which maps to each returned COMMENT field value..</param>
        /// <param name="SUGG_EMAIL">Suggested correction for submitted email address, if found. A suggestion will only be provided if it is valid and SafeToDeliver..</param>
        /// <param name="SUGG_COMMENT">This field contains suggestion not SafeToDeliver when ValidateEmailAddress corrected the address and the corrected version of the email address failed one or more SafeToDeliver process checks..</param>
        /// <param name="ERROR_RESPONSE">Pre-formatted response intended to be provided to user..</param>
        /// <param name="ERROR">Field reserved for special features only..</param>
        /// <param name="Status">.</param>
        /// <param name="StatusCode">.</param>
        /// <param name="StatusDescription">.</param>
        public ValidateEmailAddressOutput(List<ValidateMailingAddressInputRowUserFields> UserFields = null, string EMAIL = null, string FINDING = null, string COMMENT = null, string COMMENT_CODE = null, string SUGG_EMAIL = null, string SUGG_COMMENT = null, string ERROR_RESPONSE = null, string ERROR = null, string Status = null, string StatusCode = null, string StatusDescription = null)
        {
            this.UserFields = UserFields;
            this.EMAIL = EMAIL;
            this.FINDING = FINDING;
            this.COMMENT = COMMENT;
            this.COMMENT_CODE = COMMENT_CODE;
            this.SUGG_EMAIL = SUGG_EMAIL;
            this.SUGG_COMMENT = SUGG_COMMENT;
            this.ERROR_RESPONSE = ERROR_RESPONSE;
            this.ERROR = ERROR;
            this.Status = Status;
            this.StatusCode = StatusCode;
            this.StatusDescription = StatusDescription;
        }
        
        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<ValidateMailingAddressInputRowUserFields> UserFields { get; set; }
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
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Status.Code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ValidateEmailAddressOutput);
        }

        /// <summary>
        /// Returns true if ValidateEmailAddressOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateEmailAddressOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateEmailAddressOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserFields == other.UserFields ||
                    this.UserFields != null &&
                    this.UserFields.SequenceEqual(other.UserFields)
                ) && 
                (
                    this.EMAIL == other.EMAIL ||
                    this.EMAIL != null &&
                    this.EMAIL.Equals(other.EMAIL)
                ) && 
                (
                    this.FINDING == other.FINDING ||
                    this.FINDING != null &&
                    this.FINDING.Equals(other.FINDING)
                ) && 
                (
                    this.COMMENT == other.COMMENT ||
                    this.COMMENT != null &&
                    this.COMMENT.Equals(other.COMMENT)
                ) && 
                (
                    this.COMMENT_CODE == other.COMMENT_CODE ||
                    this.COMMENT_CODE != null &&
                    this.COMMENT_CODE.Equals(other.COMMENT_CODE)
                ) && 
                (
                    this.SUGG_EMAIL == other.SUGG_EMAIL ||
                    this.SUGG_EMAIL != null &&
                    this.SUGG_EMAIL.Equals(other.SUGG_EMAIL)
                ) && 
                (
                    this.SUGG_COMMENT == other.SUGG_COMMENT ||
                    this.SUGG_COMMENT != null &&
                    this.SUGG_COMMENT.Equals(other.SUGG_COMMENT)
                ) && 
                (
                    this.ERROR_RESPONSE == other.ERROR_RESPONSE ||
                    this.ERROR_RESPONSE != null &&
                    this.ERROR_RESPONSE.Equals(other.ERROR_RESPONSE)
                ) && 
                (
                    this.ERROR == other.ERROR ||
                    this.ERROR != null &&
                    this.ERROR.Equals(other.ERROR)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.StatusDescription == other.StatusDescription ||
                    this.StatusDescription != null &&
                    this.StatusDescription.Equals(other.StatusDescription)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.UserFields != null)
                    hash = hash * 59 + this.UserFields.GetHashCode();
                if (this.EMAIL != null)
                    hash = hash * 59 + this.EMAIL.GetHashCode();
                if (this.FINDING != null)
                    hash = hash * 59 + this.FINDING.GetHashCode();
                if (this.COMMENT != null)
                    hash = hash * 59 + this.COMMENT.GetHashCode();
                if (this.COMMENT_CODE != null)
                    hash = hash * 59 + this.COMMENT_CODE.GetHashCode();
                if (this.SUGG_EMAIL != null)
                    hash = hash * 59 + this.SUGG_EMAIL.GetHashCode();
                if (this.SUGG_COMMENT != null)
                    hash = hash * 59 + this.SUGG_COMMENT.GetHashCode();
                if (this.ERROR_RESPONSE != null)
                    hash = hash * 59 + this.ERROR_RESPONSE.GetHashCode();
                if (this.ERROR != null)
                    hash = hash * 59 + this.ERROR.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.StatusDescription != null)
                    hash = hash * 59 + this.StatusDescription.GetHashCode();
                return hash;
            }
        }
    }

}
