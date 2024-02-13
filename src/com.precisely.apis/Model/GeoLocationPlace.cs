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
    /// GeoLocationPlace
    /// </summary>
    [DataContract]
    public partial class GeoLocationPlace :  IEquatable<GeoLocationPlace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationPlace" /> class.
        /// </summary>
        /// <param name="continent">continent.</param>
        /// <param name="country">country.</param>
        /// <param name="consistencyCode">consistencyCode.</param>
        /// <param name="region">region.</param>
        /// <param name="state">state.</param>
        /// <param name="city">city.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="postCodeConfidence">postCodeConfidence.</param>
        public GeoLocationPlace(string continent = default(string), GeoLocationCountry country = default(GeoLocationCountry), ConsistencyCode consistencyCode = default(ConsistencyCode), string region = default(string), GeoLocationState state = default(GeoLocationState), City city = default(City), string postCode = default(string), string postCodeConfidence = default(string))
        {
            this.Continent = continent;
            this.Country = country;
            this.ConsistencyCode = consistencyCode;
            this.Region = region;
            this.State = state;
            this.City = city;
            this.PostCode = postCode;
            this.PostCodeConfidence = postCodeConfidence;
        }

        /// <summary>
        /// Gets or Sets Continent
        /// </summary>
        [DataMember(Name="continent", EmitDefaultValue=false)]
        public string Continent { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GeoLocationCountry Country { get; set; }

        /// <summary>
        /// Gets or Sets ConsistencyCode
        /// </summary>
        [DataMember(Name="consistencyCode", EmitDefaultValue=false)]
        public ConsistencyCode ConsistencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public GeoLocationState State { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public City City { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets PostCodeConfidence
        /// </summary>
        [DataMember(Name="postCodeConfidence", EmitDefaultValue=false)]
        public string PostCodeConfidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationPlace {\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ConsistencyCode: ").Append(ConsistencyCode).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  PostCodeConfidence: ").Append(PostCodeConfidence).Append("\n");
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
            return this.Equals(input as GeoLocationPlace);
        }

        /// <summary>
        /// Returns true if GeoLocationPlace instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoLocationPlace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationPlace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Continent == input.Continent ||
                    (this.Continent != null &&
                    this.Continent.Equals(input.Continent))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ConsistencyCode == input.ConsistencyCode ||
                    (this.ConsistencyCode != null &&
                    this.ConsistencyCode.Equals(input.ConsistencyCode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.PostCodeConfidence == input.PostCodeConfidence ||
                    (this.PostCodeConfidence != null &&
                    this.PostCodeConfidence.Equals(input.PostCodeConfidence))
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
                if (this.Continent != null)
                    hashCode = hashCode * 59 + this.Continent.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ConsistencyCode != null)
                    hashCode = hashCode * 59 + this.ConsistencyCode.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.PostCodeConfidence != null)
                    hashCode = hashCode * 59 + this.PostCodeConfidence.GetHashCode();
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
