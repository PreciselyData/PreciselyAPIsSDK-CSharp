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
    /// POIByGeometryRequest
    /// </summary>
    [DataContract]
    public partial class POIByGeometryRequest :  IEquatable<POIByGeometryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIByGeometryRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="categoryCode">categoryCode.</param>
        /// <param name="sicCode">sicCode.</param>
        /// <param name="maxCandidates">maxCandidates.</param>
        /// <param name="fuzzyOnName">fuzzyOnName.</param>
        /// <param name="page">page.</param>
        /// <param name="matchMode">matchMode.</param>
        /// <param name="specificMatchOn">specificMatchOn.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="geometryAsText">geometryAsText.</param>
        public POIByGeometryRequest(string name = default(string), string type = default(string), string categoryCode = default(string), string sicCode = default(string), string maxCandidates = default(string), string fuzzyOnName = default(string), string page = default(string), string matchMode = default(string), string specificMatchOn = default(string), Geometry geometry = default(Geometry), string geometryAsText = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.CategoryCode = categoryCode;
            this.SicCode = sicCode;
            this.MaxCandidates = maxCandidates;
            this.FuzzyOnName = fuzzyOnName;
            this.Page = page;
            this.MatchMode = matchMode;
            this.SpecificMatchOn = specificMatchOn;
            this.Geometry = geometry;
            this.GeometryAsText = geometryAsText;
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
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or Sets MaxCandidates
        /// </summary>
        [DataMember(Name="maxCandidates", EmitDefaultValue=false)]
        public string MaxCandidates { get; set; }

        /// <summary>
        /// Gets or Sets FuzzyOnName
        /// </summary>
        [DataMember(Name="fuzzyOnName", EmitDefaultValue=false)]
        public string FuzzyOnName { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public string Page { get; set; }

        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// Gets or Sets SpecificMatchOn
        /// </summary>
        [DataMember(Name="specificMatchOn", EmitDefaultValue=false)]
        public string SpecificMatchOn { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets GeometryAsText
        /// </summary>
        [DataMember(Name="geometryAsText", EmitDefaultValue=false)]
        public string GeometryAsText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class POIByGeometryRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  MaxCandidates: ").Append(MaxCandidates).Append("\n");
            sb.Append("  FuzzyOnName: ").Append(FuzzyOnName).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  SpecificMatchOn: ").Append(SpecificMatchOn).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  GeometryAsText: ").Append(GeometryAsText).Append("\n");
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
            return this.Equals(input as POIByGeometryRequest);
        }

        /// <summary>
        /// Returns true if POIByGeometryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of POIByGeometryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIByGeometryRequest input)
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
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.SicCode == input.SicCode ||
                    (this.SicCode != null &&
                    this.SicCode.Equals(input.SicCode))
                ) && 
                (
                    this.MaxCandidates == input.MaxCandidates ||
                    (this.MaxCandidates != null &&
                    this.MaxCandidates.Equals(input.MaxCandidates))
                ) && 
                (
                    this.FuzzyOnName == input.FuzzyOnName ||
                    (this.FuzzyOnName != null &&
                    this.FuzzyOnName.Equals(input.FuzzyOnName))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.MatchMode == input.MatchMode ||
                    (this.MatchMode != null &&
                    this.MatchMode.Equals(input.MatchMode))
                ) && 
                (
                    this.SpecificMatchOn == input.SpecificMatchOn ||
                    (this.SpecificMatchOn != null &&
                    this.SpecificMatchOn.Equals(input.SpecificMatchOn))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.GeometryAsText == input.GeometryAsText ||
                    (this.GeometryAsText != null &&
                    this.GeometryAsText.Equals(input.GeometryAsText))
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
                if (this.CategoryCode != null)
                    hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.SicCode != null)
                    hashCode = hashCode * 59 + this.SicCode.GetHashCode();
                if (this.MaxCandidates != null)
                    hashCode = hashCode * 59 + this.MaxCandidates.GetHashCode();
                if (this.FuzzyOnName != null)
                    hashCode = hashCode * 59 + this.FuzzyOnName.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.MatchMode != null)
                    hashCode = hashCode * 59 + this.MatchMode.GetHashCode();
                if (this.SpecificMatchOn != null)
                    hashCode = hashCode * 59 + this.SpecificMatchOn.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.GeometryAsText != null)
                    hashCode = hashCode * 59 + this.GeometryAsText.GetHashCode();
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
