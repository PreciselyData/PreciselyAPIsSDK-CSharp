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
    /// PhoneVerificationOutput
    /// </summary>
    [DataContract]
    public partial class PhoneVerificationOutput :  IEquatable<PhoneVerificationOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationOutput" /> class.
        /// </summary>
        /// <param name="mNC">mNC.</param>
        /// <param name="mCC">mCC.</param>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="phoneType">phoneType.</param>
        /// <param name="phoneNumberFormatted">phoneNumberFormatted.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="userFields">userFields.</param>
        public PhoneVerificationOutput(string mNC = default(string), string mCC = default(string), string carrierName = default(string), string phoneType = default(string), string phoneNumberFormatted = default(string), string countryCode = default(string), string phoneNumber = default(string), string resultCode = default(string), List<string> userFields = default(List<string>))
        {
            this.MNC = mNC;
            this.MCC = mCC;
            this.CarrierName = carrierName;
            this.PhoneType = phoneType;
            this.PhoneNumberFormatted = phoneNumberFormatted;
            this.CountryCode = countryCode;
            this.PhoneNumber = phoneNumber;
            this.ResultCode = resultCode;
            this.UserFields = userFields;
        }

        /// <summary>
        /// Gets or Sets MNC
        /// </summary>
        [DataMember(Name="MNC", EmitDefaultValue=false)]
        public string MNC { get; set; }

        /// <summary>
        /// Gets or Sets MCC
        /// </summary>
        [DataMember(Name="MCC", EmitDefaultValue=false)]
        public string MCC { get; set; }

        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="CarrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneType
        /// </summary>
        [DataMember(Name="PhoneType", EmitDefaultValue=false)]
        public string PhoneType { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumberFormatted
        /// </summary>
        [DataMember(Name="PhoneNumberFormatted", EmitDefaultValue=false)]
        public string PhoneNumberFormatted { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ResultCode
        /// </summary>
        [DataMember(Name="ResultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Gets or Sets UserFields
        /// </summary>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<string> UserFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneVerificationOutput {\n");
            sb.Append("  MNC: ").Append(MNC).Append("\n");
            sb.Append("  MCC: ").Append(MCC).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  PhoneNumberFormatted: ").Append(PhoneNumberFormatted).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
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
            return this.Equals(input as PhoneVerificationOutput);
        }

        /// <summary>
        /// Returns true if PhoneVerificationOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneVerificationOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneVerificationOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MNC == input.MNC ||
                    (this.MNC != null &&
                    this.MNC.Equals(input.MNC))
                ) && 
                (
                    this.MCC == input.MCC ||
                    (this.MCC != null &&
                    this.MCC.Equals(input.MCC))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.PhoneNumberFormatted == input.PhoneNumberFormatted ||
                    (this.PhoneNumberFormatted != null &&
                    this.PhoneNumberFormatted.Equals(input.PhoneNumberFormatted))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.UserFields == input.UserFields ||
                    this.UserFields != null &&
                    input.UserFields != null &&
                    this.UserFields.SequenceEqual(input.UserFields)
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
                if (this.MNC != null)
                    hashCode = hashCode * 59 + this.MNC.GetHashCode();
                if (this.MCC != null)
                    hashCode = hashCode * 59 + this.MCC.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.PhoneType != null)
                    hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.PhoneNumberFormatted != null)
                    hashCode = hashCode * 59 + this.PhoneNumberFormatted.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ResultCode != null)
                    hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.UserFields != null)
                    hashCode = hashCode * 59 + this.UserFields.GetHashCode();
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
