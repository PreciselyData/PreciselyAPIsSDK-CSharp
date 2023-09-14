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
    /// TypeaheadLocation
    /// </summary>
    [DataContract]
    public partial class TypeaheadLocation :  IEquatable<TypeaheadLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeaheadLocation" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="match">match.</param>
        /// <param name="address">address.</param>
        /// <param name="poi">poi.</param>
        /// <param name="distance">distance.</param>
        /// <param name="unitTemp">unitTemp.</param>
        /// <param name="valueTemp">valueTemp.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="totalUnitCount">totalUnitCount.</param>
        /// <param name="ranges">ranges.</param>
        /// <param name="place">place.</param>
        public TypeaheadLocation(string dataset = default(string), Match match = default(Match), Address1 address = default(Address1), Poi poi = default(Poi), Distance distance = default(Distance), string unitTemp = default(string), string valueTemp = default(string), Geometry geometry = default(Geometry), int totalUnitCount = default(int), List<TypeaheadRange> ranges = default(List<TypeaheadRange>), Place place = default(Place))
        {
            this.Dataset = dataset;
            this.Match = match;
            this.Address = address;
            this.Poi = poi;
            this.Distance = distance;
            this.UnitTemp = unitTemp;
            this.ValueTemp = valueTemp;
            this.Geometry = geometry;
            this.TotalUnitCount = totalUnitCount;
            this.Ranges = ranges;
            this.Place = place;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name="dataset", EmitDefaultValue=false)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name="match", EmitDefaultValue=false)]
        public Match Match { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address1 Address { get; set; }

        /// <summary>
        /// Gets or Sets Poi
        /// </summary>
        [DataMember(Name="poi", EmitDefaultValue=false)]
        public Poi Poi { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Distance Distance { get; set; }

        /// <summary>
        /// Gets or Sets UnitTemp
        /// </summary>
        [DataMember(Name="unitTemp", EmitDefaultValue=false)]
        public string UnitTemp { get; set; }

        /// <summary>
        /// Gets or Sets ValueTemp
        /// </summary>
        [DataMember(Name="valueTemp", EmitDefaultValue=false)]
        public string ValueTemp { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets TotalUnitCount
        /// </summary>
        [DataMember(Name="totalUnitCount", EmitDefaultValue=false)]
        public int TotalUnitCount { get; set; }

        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public List<TypeaheadRange> Ranges { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name="place", EmitDefaultValue=false)]
        public Place Place { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeaheadLocation {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Poi: ").Append(Poi).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  UnitTemp: ").Append(UnitTemp).Append("\n");
            sb.Append("  ValueTemp: ").Append(ValueTemp).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  TotalUnitCount: ").Append(TotalUnitCount).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
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
            return this.Equals(input as TypeaheadLocation);
        }

        /// <summary>
        /// Returns true if TypeaheadLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of TypeaheadLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeaheadLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dataset == input.Dataset ||
                    (this.Dataset != null &&
                    this.Dataset.Equals(input.Dataset))
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Poi == input.Poi ||
                    (this.Poi != null &&
                    this.Poi.Equals(input.Poi))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.UnitTemp == input.UnitTemp ||
                    (this.UnitTemp != null &&
                    this.UnitTemp.Equals(input.UnitTemp))
                ) && 
                (
                    this.ValueTemp == input.ValueTemp ||
                    (this.ValueTemp != null &&
                    this.ValueTemp.Equals(input.ValueTemp))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.TotalUnitCount == input.TotalUnitCount ||
                    (this.TotalUnitCount != null &&
                    this.TotalUnitCount.Equals(input.TotalUnitCount))
                ) && 
                (
                    this.Ranges == input.Ranges ||
                    this.Ranges != null &&
                    input.Ranges != null &&
                    this.Ranges.SequenceEqual(input.Ranges)
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
                if (this.Dataset != null)
                    hashCode = hashCode * 59 + this.Dataset.GetHashCode();
                if (this.Match != null)
                    hashCode = hashCode * 59 + this.Match.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Poi != null)
                    hashCode = hashCode * 59 + this.Poi.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.UnitTemp != null)
                    hashCode = hashCode * 59 + this.UnitTemp.GetHashCode();
                if (this.ValueTemp != null)
                    hashCode = hashCode * 59 + this.ValueTemp.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.TotalUnitCount != null)
                    hashCode = hashCode * 59 + this.TotalUnitCount.GetHashCode();
                if (this.Ranges != null)
                    hashCode = hashCode * 59 + this.Ranges.GetHashCode();
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
