/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.3
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
    /// FireStation
    /// </summary>
    [DataContract]
    public partial class FireStation :  IEquatable<FireStation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireStation" /> class.
        /// </summary>
        /// <param name="numWithinDepartment">numWithinDepartment.</param>
        /// <param name="locationReference">locationReference.</param>
        /// <param name="travelDistance">travelDistance.</param>
        /// <param name="travelTime">travelTime.</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="fireDepartment">fireDepartment.</param>
        /// <param name="geometry">geometry.</param>
        public FireStation(string numWithinDepartment = default(string), string locationReference = default(string), Distance travelDistance = default(Distance), Time travelTime = default(Time), FireStationContactDetails contactDetails = default(FireStationContactDetails), FireDepartment fireDepartment = default(FireDepartment), Geometry geometry = default(Geometry))
        {
            this.NumWithinDepartment = numWithinDepartment;
            this.LocationReference = locationReference;
            this.TravelDistance = travelDistance;
            this.TravelTime = travelTime;
            this.ContactDetails = contactDetails;
            this.FireDepartment = fireDepartment;
            this.Geometry = geometry;
        }

        /// <summary>
        /// Gets or Sets NumWithinDepartment
        /// </summary>
        [DataMember(Name="numWithinDepartment", EmitDefaultValue=false)]
        public string NumWithinDepartment { get; set; }

        /// <summary>
        /// Gets or Sets LocationReference
        /// </summary>
        [DataMember(Name="locationReference", EmitDefaultValue=false)]
        public string LocationReference { get; set; }

        /// <summary>
        /// Gets or Sets TravelDistance
        /// </summary>
        [DataMember(Name="travelDistance", EmitDefaultValue=false)]
        public Distance TravelDistance { get; set; }

        /// <summary>
        /// Gets or Sets TravelTime
        /// </summary>
        [DataMember(Name="travelTime", EmitDefaultValue=false)]
        public Time TravelTime { get; set; }

        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public FireStationContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Gets or Sets FireDepartment
        /// </summary>
        [DataMember(Name="fireDepartment", EmitDefaultValue=false)]
        public FireDepartment FireDepartment { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireStation {\n");
            sb.Append("  NumWithinDepartment: ").Append(NumWithinDepartment).Append("\n");
            sb.Append("  LocationReference: ").Append(LocationReference).Append("\n");
            sb.Append("  TravelDistance: ").Append(TravelDistance).Append("\n");
            sb.Append("  TravelTime: ").Append(TravelTime).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  FireDepartment: ").Append(FireDepartment).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(input as FireStation);
        }

        /// <summary>
        /// Returns true if FireStation instances are equal
        /// </summary>
        /// <param name="input">Instance of FireStation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireStation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumWithinDepartment == input.NumWithinDepartment ||
                    (this.NumWithinDepartment != null &&
                    this.NumWithinDepartment.Equals(input.NumWithinDepartment))
                ) && 
                (
                    this.LocationReference == input.LocationReference ||
                    (this.LocationReference != null &&
                    this.LocationReference.Equals(input.LocationReference))
                ) && 
                (
                    this.TravelDistance == input.TravelDistance ||
                    (this.TravelDistance != null &&
                    this.TravelDistance.Equals(input.TravelDistance))
                ) && 
                (
                    this.TravelTime == input.TravelTime ||
                    (this.TravelTime != null &&
                    this.TravelTime.Equals(input.TravelTime))
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
                ) && 
                (
                    this.FireDepartment == input.FireDepartment ||
                    (this.FireDepartment != null &&
                    this.FireDepartment.Equals(input.FireDepartment))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
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
                if (this.NumWithinDepartment != null)
                    hashCode = hashCode * 59 + this.NumWithinDepartment.GetHashCode();
                if (this.LocationReference != null)
                    hashCode = hashCode * 59 + this.LocationReference.GetHashCode();
                if (this.TravelDistance != null)
                    hashCode = hashCode * 59 + this.TravelDistance.GetHashCode();
                if (this.TravelTime != null)
                    hashCode = hashCode * 59 + this.TravelTime.GetHashCode();
                if (this.ContactDetails != null)
                    hashCode = hashCode * 59 + this.ContactDetails.GetHashCode();
                if (this.FireDepartment != null)
                    hashCode = hashCode * 59 + this.FireDepartment.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
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
