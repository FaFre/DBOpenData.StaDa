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
    /// period of time from/to
    /// </summary>
    [DataContract]
    public partial class OpeningHours :  IEquatable<OpeningHours>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpeningHours" /> class.
        /// </summary>
        /// <param name="fromTime">fromTime.</param>
        /// <param name="toTime">toTime.</param>
        public OpeningHours(DateTime fromTime = default(DateTime), DateTime toTime = default(DateTime))
        {
            this.FromTime = fromTime;
            this.ToTime = toTime;
        }
        
        /// <summary>
        /// Gets or Sets FromTime
        /// </summary>
        [DataMember(Name="fromTime", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime FromTime { get; set; }

        /// <summary>
        /// Gets or Sets ToTime
        /// </summary>
        [DataMember(Name="toTime", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ToTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpeningHours {\n");
            sb.Append("  FromTime: ").Append(FromTime).Append("\n");
            sb.Append("  ToTime: ").Append(ToTime).Append("\n");
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
            return this.Equals(input as OpeningHours);
        }

        /// <summary>
        /// Returns true if OpeningHours instances are equal
        /// </summary>
        /// <param name="input">Instance of OpeningHours to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpeningHours input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromTime == input.FromTime ||
                    (this.FromTime != null &&
                    this.FromTime.Equals(input.FromTime))
                ) && 
                (
                    this.ToTime == input.ToTime ||
                    (this.ToTime != null &&
                    this.ToTime.Equals(input.ToTime))
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
                if (this.FromTime != null)
                    hashCode = hashCode * 59 + this.FromTime.GetHashCode();
                if (this.ToTime != null)
                    hashCode = hashCode * 59 + this.ToTime.GetHashCode();
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
