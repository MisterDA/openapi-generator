/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EnumArrays
    /// </summary>
    [DataContract(Name = "EnumArrays")]
    public partial class EnumArrays : IEquatable<EnumArrays>, IValidatableObject
    {
        /// <summary>
        /// Defines JustSymbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustSymbolEnum
        {
            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: &gt;&#x3D;
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 1,

            /// <summary>
            /// Enum Dollar for value: $
            /// </summary>
            [EnumMember(Value = "$")]
            Dollar = 2

        }


        /// <summary>
        /// Gets or Sets JustSymbol
        /// </summary>

        [DataMember(Name = "just_symbol", EmitDefaultValue = false)]
        public JustSymbolEnum? JustSymbol
        {
            get{ return _JustSymbol;}
            set
            {
                _JustSymbol = value;
                _flagJustSymbol = true;
            }
        }
        private JustSymbolEnum? _JustSymbol;
        private bool _flagJustSymbol;

        /// <summary>
        /// Returns false as JustSymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJustSymbol()
        {
            return _flagJustSymbol;
        }
        /// <summary>
        /// Defines ArrayEnum
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArrayEnumEnum
        {
            /// <summary>
            /// Enum Fish for value: fish
            /// </summary>
            [EnumMember(Value = "fish")]
            Fish = 1,

            /// <summary>
            /// Enum Crab for value: crab
            /// </summary>
            [EnumMember(Value = "crab")]
            Crab = 2

        }



        /// <summary>
        /// Gets or Sets ArrayEnum
        /// </summary>

        [DataMember(Name = "array_enum", EmitDefaultValue = false)]
        public List<ArrayEnumEnum> ArrayEnum
        {
            get{ return _ArrayEnum;}
            set
            {
                _ArrayEnum = value;
                _flagArrayEnum = true;
            }
        }
        private List<ArrayEnumEnum> _ArrayEnum;
        private bool _flagArrayEnum;

        /// <summary>
        /// Returns false as ArrayEnum should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeArrayEnum()
        {
            return _flagArrayEnum;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumArrays" /> class.
        /// </summary>
        /// <param name="justSymbol">justSymbol.</param>
        /// <param name="arrayEnum">arrayEnum.</param>
        public EnumArrays(JustSymbolEnum? justSymbol = default(JustSymbolEnum?), List<ArrayEnumEnum> arrayEnum = default(List<ArrayEnumEnum>))
        {
            this._JustSymbol = justSymbol;
            this._ArrayEnum = arrayEnum;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumArrays {\n");
            sb.Append("  JustSymbol: ").Append(JustSymbol).Append("\n");
            sb.Append("  ArrayEnum: ").Append(ArrayEnum).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as EnumArrays).AreEqual;
        }

        /// <summary>
        /// Returns true if EnumArrays instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumArrays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumArrays input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = hashCode * 59 + this.JustSymbol.GetHashCode();
                hashCode = hashCode * 59 + this.ArrayEnum.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
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
