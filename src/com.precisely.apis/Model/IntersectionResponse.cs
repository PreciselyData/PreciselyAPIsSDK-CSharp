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
    /// IntersectionResponse
    /// </summary>
    [DataContract]
    public partial class IntersectionResponse :  IEquatable<IntersectionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntersectionResponse" /> class.
        /// </summary>
        /// <param name="intersection">intersection.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        public IntersectionResponse(List<Intersection> intersection = default(List<Intersection>), Address matchedAddress = default(Address))
        {
            this.Intersection = intersection;
            this.MatchedAddress = matchedAddress;
        }

        /// <summary>
        /// Gets or Sets Intersection
        /// </summary>
        [DataMember(Name="intersection", EmitDefaultValue=false)]
        public List<Intersection> Intersection { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public Address MatchedAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntersectionResponse {\n");
            sb.Append("  Intersection: ").Append(Intersection).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(input as IntersectionResponse);
        }

        /// <summary>
        /// Returns true if IntersectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IntersectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntersectionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Intersection == input.Intersection ||
                    this.Intersection != null &&
                    input.Intersection != null &&
                    this.Intersection.SequenceEqual(input.Intersection)
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
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
                if (this.Intersection != null)
                    hashCode = hashCode * 59 + this.Intersection.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
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
