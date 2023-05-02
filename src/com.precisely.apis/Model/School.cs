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
    /// School
    /// </summary>
    [DataContract]
    public partial class School :  IEquatable<School>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="assigned">assigned.</param>
        /// <param name="phone">phone.</param>
        /// <param name="website">website.</param>
        /// <param name="addressType">addressType.</param>
        /// <param name="address">address.</param>
        /// <param name="lowestGrade">lowestGrade.</param>
        /// <param name="highestGrade">highestGrade.</param>
        /// <param name="schoolType">schoolType.</param>
        /// <param name="schoolTypeDesc">schoolTypeDesc.</param>
        /// <param name="schoolSubType">schoolSubType.</param>
        /// <param name="schoolSubTypeDesc">schoolSubTypeDesc.</param>
        /// <param name="gender">gender.</param>
        /// <param name="genderDesc">genderDesc.</param>
        /// <param name="educationLevel">educationLevel.</param>
        /// <param name="educationLevelDesc">educationLevelDesc.</param>
        /// <param name="greatschools">greatschools.</param>
        /// <param name="ncesSchoolId">ncesSchoolId.</param>
        /// <param name="ncesDistrictId">ncesDistrictId.</param>
        /// <param name="ncesDataYear">ncesDataYear.</param>
        /// <param name="schoolRanking">schoolRanking.</param>
        /// <param name="students">students.</param>
        /// <param name="teachers">teachers.</param>
        /// <param name="status">status.</param>
        /// <param name="studentTeacherRatio">studentTeacherRatio.</param>
        /// <param name="choice">choice.</param>
        /// <param name="coextensiv">coextensiv.</param>
        /// <param name="schoolDistricts">schoolDistricts.</param>
        /// <param name="schoolProfile">schoolProfile.</param>
        /// <param name="gradeLevelsTaught">gradeLevelsTaught.</param>
        /// <param name="distance">distance.</param>
        /// <param name="geometry">geometry.</param>
        public School(string id = default(string), string name = default(string), string assigned = default(string), string phone = default(string), string website = default(string), string addressType = default(string), Address address = default(Address), string lowestGrade = default(string), string highestGrade = default(string), string schoolType = default(string), string schoolTypeDesc = default(string), string schoolSubType = default(string), string schoolSubTypeDesc = default(string), string gender = default(string), string genderDesc = default(string), string educationLevel = default(string), string educationLevelDesc = default(string), Greatschools greatschools = default(Greatschools), string ncesSchoolId = default(string), string ncesDistrictId = default(string), string ncesDataYear = default(string), List<SchoolRanking> schoolRanking = default(List<SchoolRanking>), string students = default(string), string teachers = default(string), string status = default(string), string studentTeacherRatio = default(string), string choice = default(string), string coextensiv = default(string), SchoolDistrict schoolDistricts = default(SchoolDistrict), SchoolProfile schoolProfile = default(SchoolProfile), GradeLevelsTaught gradeLevelsTaught = default(GradeLevelsTaught), Distance distance = default(Distance), Geometry geometry = default(Geometry))
        {
            this.Id = id;
            this.Name = name;
            this.Assigned = assigned;
            this.Phone = phone;
            this.Website = website;
            this.AddressType = addressType;
            this.Address = address;
            this.LowestGrade = lowestGrade;
            this.HighestGrade = highestGrade;
            this.SchoolType = schoolType;
            this.SchoolTypeDesc = schoolTypeDesc;
            this.SchoolSubType = schoolSubType;
            this.SchoolSubTypeDesc = schoolSubTypeDesc;
            this.Gender = gender;
            this.GenderDesc = genderDesc;
            this.EducationLevel = educationLevel;
            this.EducationLevelDesc = educationLevelDesc;
            this.Greatschools = greatschools;
            this.NcesSchoolId = ncesSchoolId;
            this.NcesDistrictId = ncesDistrictId;
            this.NcesDataYear = ncesDataYear;
            this.SchoolRanking = schoolRanking;
            this.Students = students;
            this.Teachers = teachers;
            this.Status = status;
            this.StudentTeacherRatio = studentTeacherRatio;
            this.Choice = choice;
            this.Coextensiv = coextensiv;
            this.SchoolDistricts = schoolDistricts;
            this.SchoolProfile = schoolProfile;
            this.GradeLevelsTaught = gradeLevelsTaught;
            this.Distance = distance;
            this.Geometry = geometry;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public string Assigned { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets LowestGrade
        /// </summary>
        [DataMember(Name="lowestGrade", EmitDefaultValue=false)]
        public string LowestGrade { get; set; }

        /// <summary>
        /// Gets or Sets HighestGrade
        /// </summary>
        [DataMember(Name="highestGrade", EmitDefaultValue=false)]
        public string HighestGrade { get; set; }

        /// <summary>
        /// Gets or Sets SchoolType
        /// </summary>
        [DataMember(Name="schoolType", EmitDefaultValue=false)]
        public string SchoolType { get; set; }

        /// <summary>
        /// Gets or Sets SchoolTypeDesc
        /// </summary>
        [DataMember(Name="schoolTypeDesc", EmitDefaultValue=false)]
        public string SchoolTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets SchoolSubType
        /// </summary>
        [DataMember(Name="schoolSubType", EmitDefaultValue=false)]
        public string SchoolSubType { get; set; }

        /// <summary>
        /// Gets or Sets SchoolSubTypeDesc
        /// </summary>
        [DataMember(Name="schoolSubTypeDesc", EmitDefaultValue=false)]
        public string SchoolSubTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets GenderDesc
        /// </summary>
        [DataMember(Name="genderDesc", EmitDefaultValue=false)]
        public string GenderDesc { get; set; }

        /// <summary>
        /// Gets or Sets EducationLevel
        /// </summary>
        [DataMember(Name="educationLevel", EmitDefaultValue=false)]
        public string EducationLevel { get; set; }

        /// <summary>
        /// Gets or Sets EducationLevelDesc
        /// </summary>
        [DataMember(Name="educationLevelDesc", EmitDefaultValue=false)]
        public string EducationLevelDesc { get; set; }

        /// <summary>
        /// Gets or Sets Greatschools
        /// </summary>
        [DataMember(Name="greatschools", EmitDefaultValue=false)]
        public Greatschools Greatschools { get; set; }

        /// <summary>
        /// Gets or Sets NcesSchoolId
        /// </summary>
        [DataMember(Name="ncesSchoolId", EmitDefaultValue=false)]
        public string NcesSchoolId { get; set; }

        /// <summary>
        /// Gets or Sets NcesDistrictId
        /// </summary>
        [DataMember(Name="ncesDistrictId", EmitDefaultValue=false)]
        public string NcesDistrictId { get; set; }

        /// <summary>
        /// Gets or Sets NcesDataYear
        /// </summary>
        [DataMember(Name="ncesDataYear", EmitDefaultValue=false)]
        public string NcesDataYear { get; set; }

        /// <summary>
        /// Gets or Sets SchoolRanking
        /// </summary>
        [DataMember(Name="schoolRanking", EmitDefaultValue=false)]
        public List<SchoolRanking> SchoolRanking { get; set; }

        /// <summary>
        /// Gets or Sets Students
        /// </summary>
        [DataMember(Name="students", EmitDefaultValue=false)]
        public string Students { get; set; }

        /// <summary>
        /// Gets or Sets Teachers
        /// </summary>
        [DataMember(Name="teachers", EmitDefaultValue=false)]
        public string Teachers { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StudentTeacherRatio
        /// </summary>
        [DataMember(Name="studentTeacherRatio", EmitDefaultValue=false)]
        public string StudentTeacherRatio { get; set; }

        /// <summary>
        /// Gets or Sets Choice
        /// </summary>
        [DataMember(Name="choice", EmitDefaultValue=false)]
        public string Choice { get; set; }

        /// <summary>
        /// Gets or Sets Coextensiv
        /// </summary>
        [DataMember(Name="coextensiv", EmitDefaultValue=false)]
        public string Coextensiv { get; set; }

        /// <summary>
        /// Gets or Sets SchoolDistricts
        /// </summary>
        [DataMember(Name="schoolDistricts", EmitDefaultValue=false)]
        public SchoolDistrict SchoolDistricts { get; set; }

        /// <summary>
        /// Gets or Sets SchoolProfile
        /// </summary>
        [DataMember(Name="schoolProfile", EmitDefaultValue=false)]
        public SchoolProfile SchoolProfile { get; set; }

        /// <summary>
        /// Gets or Sets GradeLevelsTaught
        /// </summary>
        [DataMember(Name="gradeLevelsTaught", EmitDefaultValue=false)]
        public GradeLevelsTaught GradeLevelsTaught { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Distance Distance { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class School {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LowestGrade: ").Append(LowestGrade).Append("\n");
            sb.Append("  HighestGrade: ").Append(HighestGrade).Append("\n");
            sb.Append("  SchoolType: ").Append(SchoolType).Append("\n");
            sb.Append("  SchoolTypeDesc: ").Append(SchoolTypeDesc).Append("\n");
            sb.Append("  SchoolSubType: ").Append(SchoolSubType).Append("\n");
            sb.Append("  SchoolSubTypeDesc: ").Append(SchoolSubTypeDesc).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  GenderDesc: ").Append(GenderDesc).Append("\n");
            sb.Append("  EducationLevel: ").Append(EducationLevel).Append("\n");
            sb.Append("  EducationLevelDesc: ").Append(EducationLevelDesc).Append("\n");
            sb.Append("  Greatschools: ").Append(Greatschools).Append("\n");
            sb.Append("  NcesSchoolId: ").Append(NcesSchoolId).Append("\n");
            sb.Append("  NcesDistrictId: ").Append(NcesDistrictId).Append("\n");
            sb.Append("  NcesDataYear: ").Append(NcesDataYear).Append("\n");
            sb.Append("  SchoolRanking: ").Append(SchoolRanking).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
            sb.Append("  Teachers: ").Append(Teachers).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StudentTeacherRatio: ").Append(StudentTeacherRatio).Append("\n");
            sb.Append("  Choice: ").Append(Choice).Append("\n");
            sb.Append("  Coextensiv: ").Append(Coextensiv).Append("\n");
            sb.Append("  SchoolDistricts: ").Append(SchoolDistricts).Append("\n");
            sb.Append("  SchoolProfile: ").Append(SchoolProfile).Append("\n");
            sb.Append("  GradeLevelsTaught: ").Append(GradeLevelsTaught).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(input as School);
        }

        /// <summary>
        /// Returns true if School instances are equal
        /// </summary>
        /// <param name="input">Instance of School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(School input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Assigned == input.Assigned ||
                    (this.Assigned != null &&
                    this.Assigned.Equals(input.Assigned))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.LowestGrade == input.LowestGrade ||
                    (this.LowestGrade != null &&
                    this.LowestGrade.Equals(input.LowestGrade))
                ) && 
                (
                    this.HighestGrade == input.HighestGrade ||
                    (this.HighestGrade != null &&
                    this.HighestGrade.Equals(input.HighestGrade))
                ) && 
                (
                    this.SchoolType == input.SchoolType ||
                    (this.SchoolType != null &&
                    this.SchoolType.Equals(input.SchoolType))
                ) && 
                (
                    this.SchoolTypeDesc == input.SchoolTypeDesc ||
                    (this.SchoolTypeDesc != null &&
                    this.SchoolTypeDesc.Equals(input.SchoolTypeDesc))
                ) && 
                (
                    this.SchoolSubType == input.SchoolSubType ||
                    (this.SchoolSubType != null &&
                    this.SchoolSubType.Equals(input.SchoolSubType))
                ) && 
                (
                    this.SchoolSubTypeDesc == input.SchoolSubTypeDesc ||
                    (this.SchoolSubTypeDesc != null &&
                    this.SchoolSubTypeDesc.Equals(input.SchoolSubTypeDesc))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.GenderDesc == input.GenderDesc ||
                    (this.GenderDesc != null &&
                    this.GenderDesc.Equals(input.GenderDesc))
                ) && 
                (
                    this.EducationLevel == input.EducationLevel ||
                    (this.EducationLevel != null &&
                    this.EducationLevel.Equals(input.EducationLevel))
                ) && 
                (
                    this.EducationLevelDesc == input.EducationLevelDesc ||
                    (this.EducationLevelDesc != null &&
                    this.EducationLevelDesc.Equals(input.EducationLevelDesc))
                ) && 
                (
                    this.Greatschools == input.Greatschools ||
                    (this.Greatschools != null &&
                    this.Greatschools.Equals(input.Greatschools))
                ) && 
                (
                    this.NcesSchoolId == input.NcesSchoolId ||
                    (this.NcesSchoolId != null &&
                    this.NcesSchoolId.Equals(input.NcesSchoolId))
                ) && 
                (
                    this.NcesDistrictId == input.NcesDistrictId ||
                    (this.NcesDistrictId != null &&
                    this.NcesDistrictId.Equals(input.NcesDistrictId))
                ) && 
                (
                    this.NcesDataYear == input.NcesDataYear ||
                    (this.NcesDataYear != null &&
                    this.NcesDataYear.Equals(input.NcesDataYear))
                ) && 
                (
                    this.SchoolRanking == input.SchoolRanking ||
                    this.SchoolRanking != null &&
                    input.SchoolRanking != null &&
                    this.SchoolRanking.SequenceEqual(input.SchoolRanking)
                ) && 
                (
                    this.Students == input.Students ||
                    (this.Students != null &&
                    this.Students.Equals(input.Students))
                ) && 
                (
                    this.Teachers == input.Teachers ||
                    (this.Teachers != null &&
                    this.Teachers.Equals(input.Teachers))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StudentTeacherRatio == input.StudentTeacherRatio ||
                    (this.StudentTeacherRatio != null &&
                    this.StudentTeacherRatio.Equals(input.StudentTeacherRatio))
                ) && 
                (
                    this.Choice == input.Choice ||
                    (this.Choice != null &&
                    this.Choice.Equals(input.Choice))
                ) && 
                (
                    this.Coextensiv == input.Coextensiv ||
                    (this.Coextensiv != null &&
                    this.Coextensiv.Equals(input.Coextensiv))
                ) && 
                (
                    this.SchoolDistricts == input.SchoolDistricts ||
                    (this.SchoolDistricts != null &&
                    this.SchoolDistricts.Equals(input.SchoolDistricts))
                ) && 
                (
                    this.SchoolProfile == input.SchoolProfile ||
                    (this.SchoolProfile != null &&
                    this.SchoolProfile.Equals(input.SchoolProfile))
                ) && 
                (
                    this.GradeLevelsTaught == input.GradeLevelsTaught ||
                    (this.GradeLevelsTaught != null &&
                    this.GradeLevelsTaught.Equals(input.GradeLevelsTaught))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Assigned != null)
                    hashCode = hashCode * 59 + this.Assigned.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.LowestGrade != null)
                    hashCode = hashCode * 59 + this.LowestGrade.GetHashCode();
                if (this.HighestGrade != null)
                    hashCode = hashCode * 59 + this.HighestGrade.GetHashCode();
                if (this.SchoolType != null)
                    hashCode = hashCode * 59 + this.SchoolType.GetHashCode();
                if (this.SchoolTypeDesc != null)
                    hashCode = hashCode * 59 + this.SchoolTypeDesc.GetHashCode();
                if (this.SchoolSubType != null)
                    hashCode = hashCode * 59 + this.SchoolSubType.GetHashCode();
                if (this.SchoolSubTypeDesc != null)
                    hashCode = hashCode * 59 + this.SchoolSubTypeDesc.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.GenderDesc != null)
                    hashCode = hashCode * 59 + this.GenderDesc.GetHashCode();
                if (this.EducationLevel != null)
                    hashCode = hashCode * 59 + this.EducationLevel.GetHashCode();
                if (this.EducationLevelDesc != null)
                    hashCode = hashCode * 59 + this.EducationLevelDesc.GetHashCode();
                if (this.Greatschools != null)
                    hashCode = hashCode * 59 + this.Greatschools.GetHashCode();
                if (this.NcesSchoolId != null)
                    hashCode = hashCode * 59 + this.NcesSchoolId.GetHashCode();
                if (this.NcesDistrictId != null)
                    hashCode = hashCode * 59 + this.NcesDistrictId.GetHashCode();
                if (this.NcesDataYear != null)
                    hashCode = hashCode * 59 + this.NcesDataYear.GetHashCode();
                if (this.SchoolRanking != null)
                    hashCode = hashCode * 59 + this.SchoolRanking.GetHashCode();
                if (this.Students != null)
                    hashCode = hashCode * 59 + this.Students.GetHashCode();
                if (this.Teachers != null)
                    hashCode = hashCode * 59 + this.Teachers.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StudentTeacherRatio != null)
                    hashCode = hashCode * 59 + this.StudentTeacherRatio.GetHashCode();
                if (this.Choice != null)
                    hashCode = hashCode * 59 + this.Choice.GetHashCode();
                if (this.Coextensiv != null)
                    hashCode = hashCode * 59 + this.Coextensiv.GetHashCode();
                if (this.SchoolDistricts != null)
                    hashCode = hashCode * 59 + this.SchoolDistricts.GetHashCode();
                if (this.SchoolProfile != null)
                    hashCode = hashCode * 59 + this.SchoolProfile.GetHashCode();
                if (this.GradeLevelsTaught != null)
                    hashCode = hashCode * 59 + this.GradeLevelsTaught.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
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
