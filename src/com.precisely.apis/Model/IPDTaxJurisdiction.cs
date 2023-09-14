/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
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
    /// IPDTaxJurisdiction
    /// </summary>
    [DataContract]
    public partial class IPDTaxJurisdiction :  IEquatable<IPDTaxJurisdiction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPDTaxJurisdiction" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="county">county.</param>
        /// <param name="place">place.</param>
        public IPDTaxJurisdiction(TaxState state = default(TaxState), TaxCounty county = default(TaxCounty), TaxPlace place = default(TaxPlace))
        {
            this.State = state;
            this.County = county;
            this.Place = place;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TaxState State { get; set; }

        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public TaxCounty County { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name="place", EmitDefaultValue=false)]
        public TaxPlace Place { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPDTaxJurisdiction {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
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
            return this.Equals(input as IPDTaxJurisdiction);
        }

        /// <summary>
        /// Returns true if IPDTaxJurisdiction instances are equal
        /// </summary>
        /// <param name="input">Instance of IPDTaxJurisdiction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPDTaxJurisdiction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.Place == input.Place ||
                    (this.Place != null &&
                    this.Place.Equals(input.Place))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.Place != null)
                    hashCode = hashCode * 59 + this.Place.GetHashCode();
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
