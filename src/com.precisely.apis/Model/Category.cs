/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// Category
    /// </summary>
    [DataContract]
    public partial class Category :  IEquatable<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="CategoryCode">CategoryCode.</param>
        /// <param name="TradeDivision">TradeDivision.</param>
        /// <param name="TradeGroup">TradeGroup.</param>
        /// <param name="SubClass">SubClass.</param>
        /// <param name="_Class">_Class.</param>
        public Category(string CategoryCode = null, string TradeDivision = null, string TradeGroup = null, string SubClass = null, string _Class = null)
        {
            this.CategoryCode = CategoryCode;
            this.TradeDivision = TradeDivision;
            this.TradeGroup = TradeGroup;
            this.SubClass = SubClass;
            this._Class = _Class;
        }
        
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
        /// Gets or Sets SubClass
        /// </summary>
        [DataMember(Name="subClass", EmitDefaultValue=false)]
        public string SubClass { get; set; }
        /// <summary>
        /// Gets or Sets _Class
        /// </summary>
        [DataMember(Name="class", EmitDefaultValue=false)]
        public string _Class { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  TradeDivision: ").Append(TradeDivision).Append("\n");
            sb.Append("  TradeGroup: ").Append(TradeGroup).Append("\n");
            sb.Append("  SubClass: ").Append(SubClass).Append("\n");
            sb.Append("  _Class: ").Append(_Class).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.TradeDivision == other.TradeDivision ||
                    this.TradeDivision != null &&
                    this.TradeDivision.Equals(other.TradeDivision)
                ) && 
                (
                    this.TradeGroup == other.TradeGroup ||
                    this.TradeGroup != null &&
                    this.TradeGroup.Equals(other.TradeGroup)
                ) && 
                (
                    this.SubClass == other.SubClass ||
                    this.SubClass != null &&
                    this.SubClass.Equals(other.SubClass)
                ) && 
                (
                    this._Class == other._Class ||
                    this._Class != null &&
                    this._Class.Equals(other._Class)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.TradeDivision != null)
                    hash = hash * 59 + this.TradeDivision.GetHashCode();
                if (this.TradeGroup != null)
                    hash = hash * 59 + this.TradeGroup.GetHashCode();
                if (this.SubClass != null)
                    hash = hash * 59 + this.SubClass.GetHashCode();
                if (this._Class != null)
                    hash = hash * 59 + this._Class.GetHashCode();
                return hash;
            }
        }
    }

}
