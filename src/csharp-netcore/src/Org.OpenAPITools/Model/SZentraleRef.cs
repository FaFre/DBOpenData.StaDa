/* 
 * Stationsdatenbereitstellung
 *
 * An API providing master data for German railway stations by DB Station&Service AG.
 *
 * The version of the OpenAPI document: 2.2.01
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// reference object contained in station
    /// </summary>
    [DataContract]
    public partial class SZentraleRef :  IEquatable<SZentraleRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SZentraleRef" /> class.
        /// </summary>
        /// <param name="number">unique identifier for SZentrale.</param>
        /// <param name="name">unique identifier of 3SZentrale.</param>
        /// <param name="publicPhoneNumber">publicPhoneNumber.</param>
        public SZentraleRef(int number = default(int), string name = default(string), string publicPhoneNumber = default(string))
        {
            this.Number = number;
            this.Name = name;
            this.PublicPhoneNumber = publicPhoneNumber;
        }
        
        /// <summary>
        /// unique identifier for SZentrale
        /// </summary>
        /// <value>unique identifier for SZentrale</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int Number { get; set; }

        /// <summary>
        /// unique identifier of 3SZentrale
        /// </summary>
        /// <value>unique identifier of 3SZentrale</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PublicPhoneNumber
        /// </summary>
        [DataMember(Name="publicPhoneNumber", EmitDefaultValue=false)]
        public string PublicPhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SZentraleRef {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublicPhoneNumber: ").Append(PublicPhoneNumber).Append("\n");
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
            return this.Equals(input as SZentraleRef);
        }

        /// <summary>
        /// Returns true if SZentraleRef instances are equal
        /// </summary>
        /// <param name="input">Instance of SZentraleRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SZentraleRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicPhoneNumber == input.PublicPhoneNumber ||
                    (this.PublicPhoneNumber != null &&
                    this.PublicPhoneNumber.Equals(input.PublicPhoneNumber))
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
                hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicPhoneNumber != null)
                    hashCode = hashCode * 59 + this.PublicPhoneNumber.GetHashCode();
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