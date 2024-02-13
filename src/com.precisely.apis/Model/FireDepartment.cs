/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// FireDepartment
    /// </summary>
    [DataContract]
    public partial class FireDepartment :  IEquatable<FireDepartment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireDepartment" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="numberOfStations">numberOfStations.</param>
        /// <param name="administrativeOfficeOnly">administrativeOfficeOnly.</param>
        /// <param name="contactDetails">contactDetails.</param>
        public FireDepartment(string name = default(string), string type = default(string), int numberOfStations = default(int), bool administrativeOfficeOnly = default(bool), FireStationContactDetails contactDetails = default(FireStationContactDetails))
        {
            this.Name = name;
            this.Type = type;
            this.NumberOfStations = numberOfStations;
            this.AdministrativeOfficeOnly = administrativeOfficeOnly;
            this.ContactDetails = contactDetails;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfStations
        /// </summary>
        [DataMember(Name="numberOfStations", EmitDefaultValue=false)]
        public int NumberOfStations { get; set; }

        /// <summary>
        /// Gets or Sets AdministrativeOfficeOnly
        /// </summary>
        [DataMember(Name="administrativeOfficeOnly", EmitDefaultValue=false)]
        public bool AdministrativeOfficeOnly { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public FireStationContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireDepartment {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfStations: ").Append(NumberOfStations).Append("\n");
            sb.Append("  AdministrativeOfficeOnly: ").Append(AdministrativeOfficeOnly).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
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
            return this.Equals(input as FireDepartment);
        }

        /// <summary>
        /// Returns true if FireDepartment instances are equal
        /// </summary>
        /// <param name="input">Instance of FireDepartment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireDepartment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NumberOfStations == input.NumberOfStations ||
                    (this.NumberOfStations != null &&
                    this.NumberOfStations.Equals(input.NumberOfStations))
                ) && 
                (
                    this.AdministrativeOfficeOnly == input.AdministrativeOfficeOnly ||
                    (this.AdministrativeOfficeOnly != null &&
                    this.AdministrativeOfficeOnly.Equals(input.AdministrativeOfficeOnly))
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NumberOfStations != null)
                    hashCode = hashCode * 59 + this.NumberOfStations.GetHashCode();
                if (this.AdministrativeOfficeOnly != null)
                    hashCode = hashCode * 59 + this.AdministrativeOfficeOnly.GetHashCode();
                if (this.ContactDetails != null)
                    hashCode = hashCode * 59 + this.ContactDetails.GetHashCode();
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
