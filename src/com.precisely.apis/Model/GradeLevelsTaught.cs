/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.2
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
    /// GradeLevelsTaught
    /// </summary>
    [DataContract]
    public partial class GradeLevelsTaught :  IEquatable<GradeLevelsTaught>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GradeLevelsTaught" /> class.
        /// </summary>
        /// <param name="pk">pk.</param>
        /// <param name="kg">kg.</param>
        /// <param name="first">first.</param>
        /// <param name="second">second.</param>
        /// <param name="third">third.</param>
        /// <param name="fourth">fourth.</param>
        /// <param name="fifth">fifth.</param>
        /// <param name="sixth">sixth.</param>
        /// <param name="seventh">seventh.</param>
        /// <param name="eighth">eighth.</param>
        /// <param name="ninth">ninth.</param>
        /// <param name="tenth">tenth.</param>
        /// <param name="eleventh">eleventh.</param>
        /// <param name="twelfth">twelfth.</param>
        public GradeLevelsTaught(string pk = default(string), string kg = default(string), string first = default(string), string second = default(string), string third = default(string), string fourth = default(string), string fifth = default(string), string sixth = default(string), string seventh = default(string), string eighth = default(string), string ninth = default(string), string tenth = default(string), string eleventh = default(string), string twelfth = default(string))
        {
            this.Pk = pk;
            this.Kg = kg;
            this.First = first;
            this.Second = second;
            this.Third = third;
            this.Fourth = fourth;
            this.Fifth = fifth;
            this.Sixth = sixth;
            this.Seventh = seventh;
            this.Eighth = eighth;
            this.Ninth = ninth;
            this.Tenth = tenth;
            this.Eleventh = eleventh;
            this.Twelfth = twelfth;
        }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public string Pk { get; set; }

        /// <summary>
        /// Gets or Sets Kg
        /// </summary>
        [DataMember(Name="kg", EmitDefaultValue=false)]
        public string Kg { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public string First { get; set; }

        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name="second", EmitDefaultValue=false)]
        public string Second { get; set; }

        /// <summary>
        /// Gets or Sets Third
        /// </summary>
        [DataMember(Name="third", EmitDefaultValue=false)]
        public string Third { get; set; }

        /// <summary>
        /// Gets or Sets Fourth
        /// </summary>
        [DataMember(Name="fourth", EmitDefaultValue=false)]
        public string Fourth { get; set; }

        /// <summary>
        /// Gets or Sets Fifth
        /// </summary>
        [DataMember(Name="fifth", EmitDefaultValue=false)]
        public string Fifth { get; set; }

        /// <summary>
        /// Gets or Sets Sixth
        /// </summary>
        [DataMember(Name="sixth", EmitDefaultValue=false)]
        public string Sixth { get; set; }

        /// <summary>
        /// Gets or Sets Seventh
        /// </summary>
        [DataMember(Name="seventh", EmitDefaultValue=false)]
        public string Seventh { get; set; }

        /// <summary>
        /// Gets or Sets Eighth
        /// </summary>
        [DataMember(Name="eighth", EmitDefaultValue=false)]
        public string Eighth { get; set; }

        /// <summary>
        /// Gets or Sets Ninth
        /// </summary>
        [DataMember(Name="ninth", EmitDefaultValue=false)]
        public string Ninth { get; set; }

        /// <summary>
        /// Gets or Sets Tenth
        /// </summary>
        [DataMember(Name="tenth", EmitDefaultValue=false)]
        public string Tenth { get; set; }

        /// <summary>
        /// Gets or Sets Eleventh
        /// </summary>
        [DataMember(Name="eleventh", EmitDefaultValue=false)]
        public string Eleventh { get; set; }

        /// <summary>
        /// Gets or Sets Twelfth
        /// </summary>
        [DataMember(Name="twelfth", EmitDefaultValue=false)]
        public string Twelfth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradeLevelsTaught {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Kg: ").Append(Kg).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
            sb.Append("  Third: ").Append(Third).Append("\n");
            sb.Append("  Fourth: ").Append(Fourth).Append("\n");
            sb.Append("  Fifth: ").Append(Fifth).Append("\n");
            sb.Append("  Sixth: ").Append(Sixth).Append("\n");
            sb.Append("  Seventh: ").Append(Seventh).Append("\n");
            sb.Append("  Eighth: ").Append(Eighth).Append("\n");
            sb.Append("  Ninth: ").Append(Ninth).Append("\n");
            sb.Append("  Tenth: ").Append(Tenth).Append("\n");
            sb.Append("  Eleventh: ").Append(Eleventh).Append("\n");
            sb.Append("  Twelfth: ").Append(Twelfth).Append("\n");
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
            return this.Equals(input as GradeLevelsTaught);
        }

        /// <summary>
        /// Returns true if GradeLevelsTaught instances are equal
        /// </summary>
        /// <param name="input">Instance of GradeLevelsTaught to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GradeLevelsTaught input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pk == input.Pk ||
                    (this.Pk != null &&
                    this.Pk.Equals(input.Pk))
                ) && 
                (
                    this.Kg == input.Kg ||
                    (this.Kg != null &&
                    this.Kg.Equals(input.Kg))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Second == input.Second ||
                    (this.Second != null &&
                    this.Second.Equals(input.Second))
                ) && 
                (
                    this.Third == input.Third ||
                    (this.Third != null &&
                    this.Third.Equals(input.Third))
                ) && 
                (
                    this.Fourth == input.Fourth ||
                    (this.Fourth != null &&
                    this.Fourth.Equals(input.Fourth))
                ) && 
                (
                    this.Fifth == input.Fifth ||
                    (this.Fifth != null &&
                    this.Fifth.Equals(input.Fifth))
                ) && 
                (
                    this.Sixth == input.Sixth ||
                    (this.Sixth != null &&
                    this.Sixth.Equals(input.Sixth))
                ) && 
                (
                    this.Seventh == input.Seventh ||
                    (this.Seventh != null &&
                    this.Seventh.Equals(input.Seventh))
                ) && 
                (
                    this.Eighth == input.Eighth ||
                    (this.Eighth != null &&
                    this.Eighth.Equals(input.Eighth))
                ) && 
                (
                    this.Ninth == input.Ninth ||
                    (this.Ninth != null &&
                    this.Ninth.Equals(input.Ninth))
                ) && 
                (
                    this.Tenth == input.Tenth ||
                    (this.Tenth != null &&
                    this.Tenth.Equals(input.Tenth))
                ) && 
                (
                    this.Eleventh == input.Eleventh ||
                    (this.Eleventh != null &&
                    this.Eleventh.Equals(input.Eleventh))
                ) && 
                (
                    this.Twelfth == input.Twelfth ||
                    (this.Twelfth != null &&
                    this.Twelfth.Equals(input.Twelfth))
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
                if (this.Pk != null)
                    hashCode = hashCode * 59 + this.Pk.GetHashCode();
                if (this.Kg != null)
                    hashCode = hashCode * 59 + this.Kg.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Second != null)
                    hashCode = hashCode * 59 + this.Second.GetHashCode();
                if (this.Third != null)
                    hashCode = hashCode * 59 + this.Third.GetHashCode();
                if (this.Fourth != null)
                    hashCode = hashCode * 59 + this.Fourth.GetHashCode();
                if (this.Fifth != null)
                    hashCode = hashCode * 59 + this.Fifth.GetHashCode();
                if (this.Sixth != null)
                    hashCode = hashCode * 59 + this.Sixth.GetHashCode();
                if (this.Seventh != null)
                    hashCode = hashCode * 59 + this.Seventh.GetHashCode();
                if (this.Eighth != null)
                    hashCode = hashCode * 59 + this.Eighth.GetHashCode();
                if (this.Ninth != null)
                    hashCode = hashCode * 59 + this.Ninth.GetHashCode();
                if (this.Tenth != null)
                    hashCode = hashCode * 59 + this.Tenth.GetHashCode();
                if (this.Eleventh != null)
                    hashCode = hashCode * 59 + this.Eleventh.GetHashCode();
                if (this.Twelfth != null)
                    hashCode = hashCode * 59 + this.Twelfth.GetHashCode();
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
