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
    /// SicMetadata
    /// </summary>
    [DataContract]
    public partial class SicMetadata :  IEquatable<SicMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SicMetadata" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="categoryCode">categoryCode.</param>
        /// <param name="tradeDivision">tradeDivision.</param>
        /// <param name="tradeGroup">tradeGroup.</param>
        /// <param name="_class">_class.</param>
        /// <param name="subClass">subClass.</param>
        /// <param name="description">description.</param>
        public SicMetadata(string code = default(string), string categoryCode = default(string), string tradeDivision = default(string), string tradeGroup = default(string), string _class = default(string), string subClass = default(string), string description = default(string))
        {
            this.Code = code;
            this.CategoryCode = categoryCode;
            this.TradeDivision = tradeDivision;
            this.TradeGroup = tradeGroup;
            this.Class = _class;
            this.SubClass = subClass;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets TradeDivision
        /// </summary>
        [DataMember(Name="tradeDivision", EmitDefaultValue=false)]
        public string TradeDivision { get; set; }

        /// <summary>
        /// Gets or Sets TradeGroup
        /// </summary>
        [DataMember(Name="tradeGroup", EmitDefaultValue=false)]
        public string TradeGroup { get; set; }

        /// <summary>
        /// Gets or Sets Class
        /// </summary>
        [DataMember(Name="class", EmitDefaultValue=false)]
        public string Class { get; set; }

        /// <summary>
        /// Gets or Sets SubClass
        /// </summary>
        [DataMember(Name="subClass", EmitDefaultValue=false)]
        public string SubClass { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SicMetadata {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  TradeDivision: ").Append(TradeDivision).Append("\n");
            sb.Append("  TradeGroup: ").Append(TradeGroup).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  SubClass: ").Append(SubClass).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as SicMetadata);
        }

        /// <summary>
        /// Returns true if SicMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of SicMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SicMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.TradeDivision == input.TradeDivision ||
                    (this.TradeDivision != null &&
                    this.TradeDivision.Equals(input.TradeDivision))
                ) && 
                (
                    this.TradeGroup == input.TradeGroup ||
                    (this.TradeGroup != null &&
                    this.TradeGroup.Equals(input.TradeGroup))
                ) && 
                (
                    this.Class == input.Class ||
                    (this.Class != null &&
                    this.Class.Equals(input.Class))
                ) && 
                (
                    this.SubClass == input.SubClass ||
                    (this.SubClass != null &&
                    this.SubClass.Equals(input.SubClass))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CategoryCode != null)
                    hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.TradeDivision != null)
                    hashCode = hashCode * 59 + this.TradeDivision.GetHashCode();
                if (this.TradeGroup != null)
                    hashCode = hashCode * 59 + this.TradeGroup.GetHashCode();
                if (this.Class != null)
                    hashCode = hashCode * 59 + this.Class.GetHashCode();
                if (this.SubClass != null)
                    hashCode = hashCode * 59 + this.SubClass.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
