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
    /// FireRiskV2ResponseList
    /// </summary>
    [DataContract]
    public partial class FireRiskV2ResponseList :  IEquatable<FireRiskV2ResponseList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireRiskV2ResponseList" /> class.
        /// </summary>
        /// <param name="fireRisk">fireRisk.</param>
        public FireRiskV2ResponseList(List<FireRiskV2Response> fireRisk = default(List<FireRiskV2Response>))
        {
            this.FireRisk = fireRisk;
        }

        /// <summary>
        /// Gets or Sets FireRisk
        /// </summary>
        [DataMember(Name="fireRisk", EmitDefaultValue=false)]
        public List<FireRiskV2Response> FireRisk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireRiskV2ResponseList {\n");
            sb.Append("  FireRisk: ").Append(FireRisk).Append("\n");
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
            return this.Equals(input as FireRiskV2ResponseList);
        }

        /// <summary>
        /// Returns true if FireRiskV2ResponseList instances are equal
        /// </summary>
        /// <param name="input">Instance of FireRiskV2ResponseList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireRiskV2ResponseList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FireRisk == input.FireRisk ||
                    this.FireRisk != null &&
                    input.FireRisk != null &&
                    this.FireRisk.SequenceEqual(input.FireRisk)
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
                if (this.FireRisk != null)
                    hashCode = hashCode * 59 + this.FireRisk.GetHashCode();
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
