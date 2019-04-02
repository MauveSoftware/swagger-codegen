/* 
 * My title
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
using NullableStringEnumConverter = IO.Swagger.Client.NullableStringEnumConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MyClassWithOptionalInlineEnum
    /// </summary>
    [DataContract]
    [Serializable]
    public partial class MyClassWithOptionalInlineEnum :  IEquatable<MyClassWithOptionalInlineEnum>, IValidatableObject
    {
        /// <summary>
        /// Defines Days
        /// </summary>
        [JsonConverter(typeof(NullableStringEnumConverter))]
        public enum DaysEnum
        {
            
            /// <summary>
            /// Enum Sun for value: sun
            /// </summary>
            [EnumMember(Value = "sun")]
            Sun = 1,
            
            /// <summary>
            /// Enum Mon for value: mon
            /// </summary>
            [EnumMember(Value = "mon")]
            Mon = 2,
            
            /// <summary>
            /// Enum Tue for value: tue
            /// </summary>
            [EnumMember(Value = "tue")]
            Tue = 3,
            
            /// <summary>
            /// Enum Wed for value: wed
            /// </summary>
            [EnumMember(Value = "wed")]
            Wed = 4,
            
            /// <summary>
            /// Enum Thu for value: thu
            /// </summary>
            [EnumMember(Value = "thu")]
            Thu = 5,
            
            /// <summary>
            /// Enum Fri for value: fri
            /// </summary>
            [EnumMember(Value = "fri")]
            Fri = 6,
            
            /// <summary>
            /// Enum Sat for value: sat
            /// </summary>
            [EnumMember(Value = "sat")]
            Sat = 7
        }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public DaysEnum? Days { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyClassWithOptionalInlineEnum" /> class.
        /// </summary>
        /// <param name="quarantine">quarantine.</param>
        /// <param name="grayware">grayware.</param>
        /// <param name="days">days.</param>
        public MyClassWithOptionalInlineEnum(bool? quarantine = default(bool?), bool? grayware = default(bool?), DaysEnum? days = default(DaysEnum?))
        {
            this.Quarantine = quarantine;
            this.Grayware = grayware;
            this.Days = days;
        }
        
        /// <summary>
        /// Gets or Sets Quarantine
        /// </summary>
        [DataMember(Name="quarantine", EmitDefaultValue=false)]
        public bool? Quarantine { get; set; }

        /// <summary>
        /// Gets or Sets Grayware
        /// </summary>
        [DataMember(Name="grayware", EmitDefaultValue=false)]
        public bool? Grayware { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyClassWithOptionalInlineEnum {\n");
            sb.Append("  Quarantine: ").Append(Quarantine).Append("\n");
            sb.Append("  Grayware: ").Append(Grayware).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MyClassWithOptionalInlineEnum);
        }

        /// <summary>
        /// Returns true if MyClassWithOptionalInlineEnum instances are equal
        /// </summary>
        /// <param name="input">Instance of MyClassWithOptionalInlineEnum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MyClassWithOptionalInlineEnum input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quarantine == input.Quarantine ||
                    (this.Quarantine != null &&
                    this.Quarantine.Equals(input.Quarantine))
                ) && 
                (
                    this.Grayware == input.Grayware ||
                    (this.Grayware != null &&
                    this.Grayware.Equals(input.Grayware))
                ) && 
                (
                    this.Days == input.Days ||
                    (this.Days != null &&
                    this.Days.Equals(input.Days))
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
                if (this.Quarantine != null)
                    hashCode = hashCode * 59 + this.Quarantine.GetHashCode();
                if (this.Grayware != null)
                    hashCode = hashCode * 59 + this.Grayware.GetHashCode();
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
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
