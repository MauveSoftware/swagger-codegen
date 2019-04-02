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
    /// Invalid use of required on $ref enum, per Swagger 2.0 spec: Any members other than &#39;$ref&#39; in a JSON Reference object SHALL be ignored. See My_Class_With_Required_Inline_Enum for appropriate usage.
    /// </summary>
    [DataContract]
    [Serializable]
    public partial class MyClassWithInvalidRequiredEnumUsageOnRef :  IEquatable<MyClassWithInvalidRequiredEnumUsageOnRef>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public WeekDays? Days { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyClassWithInvalidRequiredEnumUsageOnRef" /> class.
        /// </summary>
        /// <param name="first">first.</param>
        /// <param name="days">days.</param>
        public MyClassWithInvalidRequiredEnumUsageOnRef(bool? first = default(bool?), WeekDays? days = default(WeekDays?))
        {
            this.First = first;
            this.Days = days;
        }
        
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public bool? First { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MyClassWithInvalidRequiredEnumUsageOnRef {\n");
            sb.Append("  First: ").Append(First).Append("\n");
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
            return this.Equals(input as MyClassWithInvalidRequiredEnumUsageOnRef);
        }

        /// <summary>
        /// Returns true if MyClassWithInvalidRequiredEnumUsageOnRef instances are equal
        /// </summary>
        /// <param name="input">Instance of MyClassWithInvalidRequiredEnumUsageOnRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MyClassWithInvalidRequiredEnumUsageOnRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
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
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
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
