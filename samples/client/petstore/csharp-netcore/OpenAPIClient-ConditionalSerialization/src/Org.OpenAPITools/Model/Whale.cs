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
    /// Whale
    /// </summary>
    [DataContract(Name = "whale")]
    public partial class Whale : IEquatable<Whale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Whale()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        /// <param name="hasBaleen">hasBaleen.</param>
        /// <param name="hasTeeth">hasTeeth.</param>
        /// <param name="className">className (required).</param>
        public Whale(bool hasBaleen = default(bool), bool hasTeeth = default(bool), string className = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null) {
                throw new ArgumentNullException("className is a required property for Whale and cannot be null");
            }
            this._ClassName = className;
            this._HasBaleen = hasBaleen;
            this._HasTeeth = hasTeeth;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets HasBaleen
        /// </summary>
        [DataMember(Name = "hasBaleen", EmitDefaultValue = true)]
        public bool HasBaleen
        {
            get{ return _HasBaleen;}
            set
            {
                _HasBaleen = value;
                _flagHasBaleen = true;
            }
        }
        private bool _HasBaleen;
        private bool _flagHasBaleen;

        /// <summary>
        /// Returns false as HasBaleen should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasBaleen()
        {
            return _flagHasBaleen;
        }
        /// <summary>
        /// Gets or Sets HasTeeth
        /// </summary>
        [DataMember(Name = "hasTeeth", EmitDefaultValue = true)]
        public bool HasTeeth
        {
            get{ return _HasTeeth;}
            set
            {
                _HasTeeth = value;
                _flagHasTeeth = true;
            }
        }
        private bool _HasTeeth;
        private bool _flagHasTeeth;

        /// <summary>
        /// Returns false as HasTeeth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasTeeth()
        {
            return _flagHasTeeth;
        }
        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", IsRequired = true, EmitDefaultValue = false)]
        public string ClassName
        {
            get{ return _ClassName;}
            set
            {
                _ClassName = value;
                _flagClassName = true;
            }
        }
        private string _ClassName;
        private bool _flagClassName;

        /// <summary>
        /// Returns false as ClassName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClassName()
        {
            return _flagClassName;
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
            sb.Append("class Whale {\n");
            sb.Append("  HasBaleen: ").Append(HasBaleen).Append("\n");
            sb.Append("  HasTeeth: ").Append(HasTeeth).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Whale).AreEqual;
        }

        /// <summary>
        /// Returns true if Whale instances are equal
        /// </summary>
        /// <param name="input">Instance of Whale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Whale input)
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
                hashCode = hashCode * 59 + this.HasBaleen.GetHashCode();
                hashCode = hashCode * 59 + this.HasTeeth.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
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
