/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    /// ValidateMailingAddressProOutput
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressProOutput :  IEquatable<ValidateMailingAddressProOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressProOutput" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="addressLine1">The first line of the validated address..</param>
        /// <param name="addressLine2">The second line of the validated address..</param>
        /// <param name="firmName">The validated firm or company name..</param>
        /// <param name="changeScore">A value of 0 and 100 that reflects how much the address has changed to make it valid..</param>
        /// <param name="locality">Generally a locality is a village in rural areas or it may be a suburb in urban areas..</param>
        /// <param name="suburb">The suburb name..</param>
        /// <param name="addressType">A single letter code that indicates the type of address..</param>
        /// <param name="deliverability">An estimate of confidence that an item mailed or shipped to this address would be successfully delivered..</param>
        /// <param name="addressQuality">A two character code indicating overall quality of the resulting address..</param>
        /// <param name="couldNotValidate">Mentions the address component that could not be validated, in case no match is found..</param>
        /// <param name="city">The validated city name..</param>
        /// <param name="postalCode">The validated ZIP Code or postal code..</param>
        /// <param name="country">The country in the format determined by what you selected..</param>
        /// <param name="stateProvince">The validated state or province abbreviation..</param>
        /// <param name="blockAddress">The formatted address, as it would appear on a physical mail piece..</param>
        /// <param name="additionalInputData">Input data that could not be matched to a particular address component..</param>
        /// <param name="postalCodeBase">The 5-digit ZIP Code..</param>
        /// <param name="postalCodeAddOn">The 4-digit add-on part of the ZIP Code..</param>
        /// <param name="status">Reports the success or failure of the match attempt..</param>
        /// <param name="statusCode">Reason for failure, if there is one..</param>
        /// <param name="statusDescription">Description of the problem, if there is one..</param>
        public ValidateMailingAddressProOutput(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string addressLine1 = default(string), string addressLine2 = default(string), string firmName = default(string), string changeScore = default(string), string locality = default(string), string suburb = default(string), string addressType = default(string), string deliverability = default(string), string addressQuality = default(string), string couldNotValidate = default(string), string city = default(string), string postalCode = default(string), string country = default(string), string stateProvince = default(string), string blockAddress = default(string), string additionalInputData = default(string), string postalCodeBase = default(string), string postalCodeAddOn = default(string), string status = default(string), string statusCode = default(string), string statusDescription = default(string))
        {
            this.UserFields = userFields;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.FirmName = firmName;
            this.ChangeScore = changeScore;
            this.Locality = locality;
            this.Suburb = suburb;
            this.AddressType = addressType;
            this.Deliverability = deliverability;
            this.AddressQuality = addressQuality;
            this.CouldNotValidate = couldNotValidate;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
            this.StateProvince = stateProvince;
            this.BlockAddress = blockAddress;
            this.AdditionalInputData = additionalInputData;
            this.PostalCodeBase = postalCodeBase;
            this.PostalCodeAddOn = postalCodeAddOn;
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
        /// The first line of the validated address.
        /// </summary>
        /// <value>The first line of the validated address.</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the validated address.
        /// </summary>
        /// <value>The second line of the validated address.</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The validated firm or company name.
        /// </summary>
        /// <value>The validated firm or company name.</value>
        [DataMember(Name="FirmName", EmitDefaultValue=false)]
        public string FirmName { get; set; }

        /// <summary>
        /// A value of 0 and 100 that reflects how much the address has changed to make it valid.
        /// </summary>
        /// <value>A value of 0 and 100 that reflects how much the address has changed to make it valid.</value>
        [DataMember(Name="ChangeScore", EmitDefaultValue=false)]
        public string ChangeScore { get; set; }

        /// <summary>
        /// Generally a locality is a village in rural areas or it may be a suburb in urban areas.
        /// </summary>
        /// <value>Generally a locality is a village in rural areas or it may be a suburb in urban areas.</value>
        [DataMember(Name="Locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// The suburb name.
        /// </summary>
        /// <value>The suburb name.</value>
        [DataMember(Name="Suburb", EmitDefaultValue=false)]
        public string Suburb { get; set; }

        /// <summary>
        /// A single letter code that indicates the type of address.
        /// </summary>
        /// <value>A single letter code that indicates the type of address.</value>
        [DataMember(Name="AddressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// An estimate of confidence that an item mailed or shipped to this address would be successfully delivered.
        /// </summary>
        /// <value>An estimate of confidence that an item mailed or shipped to this address would be successfully delivered.</value>
        [DataMember(Name="Deliverability", EmitDefaultValue=false)]
        public string Deliverability { get; set; }

        /// <summary>
        /// A two character code indicating overall quality of the resulting address.
        /// </summary>
        /// <value>A two character code indicating overall quality of the resulting address.</value>
        [DataMember(Name="AddressQuality", EmitDefaultValue=false)]
        public string AddressQuality { get; set; }

        /// <summary>
        /// Mentions the address component that could not be validated, in case no match is found.
        /// </summary>
        /// <value>Mentions the address component that could not be validated, in case no match is found.</value>
        [DataMember(Name="CouldNotValidate", EmitDefaultValue=false)]
        public string CouldNotValidate { get; set; }

        /// <summary>
        /// The validated city name.
        /// </summary>
        /// <value>The validated city name.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The validated ZIP Code or postal code.
        /// </summary>
        /// <value>The validated ZIP Code or postal code.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country in the format determined by what you selected.
        /// </summary>
        /// <value>The country in the format determined by what you selected.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The validated state or province abbreviation.
        /// </summary>
        /// <value>The validated state or province abbreviation.</value>
        [DataMember(Name="StateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// The formatted address, as it would appear on a physical mail piece.
        /// </summary>
        /// <value>The formatted address, as it would appear on a physical mail piece.</value>
        [DataMember(Name="BlockAddress", EmitDefaultValue=false)]
        public string BlockAddress { get; set; }

        /// <summary>
        /// Input data that could not be matched to a particular address component.
        /// </summary>
        /// <value>Input data that could not be matched to a particular address component.</value>
        [DataMember(Name="AdditionalInputData", EmitDefaultValue=false)]
        public string AdditionalInputData { get; set; }

        /// <summary>
        /// The 5-digit ZIP Code.
        /// </summary>
        /// <value>The 5-digit ZIP Code.</value>
        [DataMember(Name="PostalCode.Base", EmitDefaultValue=false)]
        public string PostalCodeBase { get; set; }

        /// <summary>
        /// The 4-digit add-on part of the ZIP Code.
        /// </summary>
        /// <value>The 4-digit add-on part of the ZIP Code.</value>
        [DataMember(Name="PostalCode.AddOn", EmitDefaultValue=false)]
        public string PostalCodeAddOn { get; set; }

        /// <summary>
        /// Reports the success or failure of the match attempt.
        /// </summary>
        /// <value>Reports the success or failure of the match attempt.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Reason for failure, if there is one.
        /// </summary>
        /// <value>Reason for failure, if there is one.</value>
        [DataMember(Name="Status.Code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Description of the problem, if there is one.
        /// </summary>
        /// <value>Description of the problem, if there is one.</value>
        [DataMember(Name="Status.Description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateMailingAddressProOutput {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  FirmName: ").Append(FirmName).Append("\n");
            sb.Append("  ChangeScore: ").Append(ChangeScore).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Deliverability: ").Append(Deliverability).Append("\n");
            sb.Append("  AddressQuality: ").Append(AddressQuality).Append("\n");
            sb.Append("  CouldNotValidate: ").Append(CouldNotValidate).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  BlockAddress: ").Append(BlockAddress).Append("\n");
            sb.Append("  AdditionalInputData: ").Append(AdditionalInputData).Append("\n");
            sb.Append("  PostalCodeBase: ").Append(PostalCodeBase).Append("\n");
            sb.Append("  PostalCodeAddOn: ").Append(PostalCodeAddOn).Append("\n");
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
            return this.Equals(input as ValidateMailingAddressProOutput);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressProOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateMailingAddressProOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressProOutput input)
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
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.FirmName == input.FirmName ||
                    (this.FirmName != null &&
                    this.FirmName.Equals(input.FirmName))
                ) && 
                (
                    this.ChangeScore == input.ChangeScore ||
                    (this.ChangeScore != null &&
                    this.ChangeScore.Equals(input.ChangeScore))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Deliverability == input.Deliverability ||
                    (this.Deliverability != null &&
                    this.Deliverability.Equals(input.Deliverability))
                ) && 
                (
                    this.AddressQuality == input.AddressQuality ||
                    (this.AddressQuality != null &&
                    this.AddressQuality.Equals(input.AddressQuality))
                ) && 
                (
                    this.CouldNotValidate == input.CouldNotValidate ||
                    (this.CouldNotValidate != null &&
                    this.CouldNotValidate.Equals(input.CouldNotValidate))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.BlockAddress == input.BlockAddress ||
                    (this.BlockAddress != null &&
                    this.BlockAddress.Equals(input.BlockAddress))
                ) && 
                (
                    this.AdditionalInputData == input.AdditionalInputData ||
                    (this.AdditionalInputData != null &&
                    this.AdditionalInputData.Equals(input.AdditionalInputData))
                ) && 
                (
                    this.PostalCodeBase == input.PostalCodeBase ||
                    (this.PostalCodeBase != null &&
                    this.PostalCodeBase.Equals(input.PostalCodeBase))
                ) && 
                (
                    this.PostalCodeAddOn == input.PostalCodeAddOn ||
                    (this.PostalCodeAddOn != null &&
                    this.PostalCodeAddOn.Equals(input.PostalCodeAddOn))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.FirmName != null)
                    hashCode = hashCode * 59 + this.FirmName.GetHashCode();
                if (this.ChangeScore != null)
                    hashCode = hashCode * 59 + this.ChangeScore.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Deliverability != null)
                    hashCode = hashCode * 59 + this.Deliverability.GetHashCode();
                if (this.AddressQuality != null)
                    hashCode = hashCode * 59 + this.AddressQuality.GetHashCode();
                if (this.CouldNotValidate != null)
                    hashCode = hashCode * 59 + this.CouldNotValidate.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.BlockAddress != null)
                    hashCode = hashCode * 59 + this.BlockAddress.GetHashCode();
                if (this.AdditionalInputData != null)
                    hashCode = hashCode * 59 + this.AdditionalInputData.GetHashCode();
                if (this.PostalCodeBase != null)
                    hashCode = hashCode * 59 + this.PostalCodeBase.GetHashCode();
                if (this.PostalCodeAddOn != null)
                    hashCode = hashCode * 59 + this.PostalCodeAddOn.GetHashCode();
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
