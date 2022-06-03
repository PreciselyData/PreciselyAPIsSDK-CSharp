/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.3
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
    /// LocationTime
    /// </summary>
    [DataContract]
    public partial class LocationTime :  IEquatable<LocationTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationTime" /> class.
        /// </summary>
        /// <param name="geometry">geometry (required).</param>
        /// <param name="purchaseAmount">purchaseAmount.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="timestamp">timestamp.</param>
        public LocationTime(TimezoneGeometry geometry = default(TimezoneGeometry), string purchaseAmount = default(string), string objectId = default(string), string timestamp = default(string))
        {
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new InvalidDataException("geometry is a required property for LocationTime and cannot be null");
            }
            else
            {
                this.Geometry = geometry;
            }

            this.PurchaseAmount = purchaseAmount;
            this.ObjectId = objectId;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=true)]
        public TimezoneGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseAmount
        /// </summary>
        [DataMember(Name="purchaseAmount", EmitDefaultValue=false)]
        public string PurchaseAmount { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationTime {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PurchaseAmount: ").Append(PurchaseAmount).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as LocationTime);
        }

        /// <summary>
        /// Returns true if LocationTime instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.PurchaseAmount == input.PurchaseAmount ||
                    (this.PurchaseAmount != null &&
                    this.PurchaseAmount.Equals(input.PurchaseAmount))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.PurchaseAmount != null)
                    hashCode = hashCode * 59 + this.PurchaseAmount.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
