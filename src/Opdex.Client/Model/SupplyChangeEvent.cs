/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
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
using FileParameter = Opdex.Client.Client.FileParameter;
using OpenAPIDateConverter = Opdex.Client.Client.OpenAPIDateConverter;

namespace Opdex.Client.Model
{
    /// <summary>
    /// Indiciates a change in total supply for an Interflux token
    /// </summary>
    [DataContract(Name = "supplyChangeEvent")]
    public partial class SupplyChangeEvent : IEquatable<SupplyChangeEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplyChangeEvent" /> class.
        /// </summary>
        /// <param name="totalSupply">Decimal value with uncapped precision and size.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="contract">An address on the Cirrus network.</param>
        /// <param name="sortOrder">Index to sort event order.</param>
        public SupplyChangeEvent(string totalSupply = default(string), TransactionEventType eventType = default(TransactionEventType), string contract = default(string), int sortOrder = default(int))
        {
            this.TotalSupply = totalSupply;
            this.EventType = eventType;
            this.Contract = contract;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "totalSupply", EmitDefaultValue = false)]
        public string TotalSupply { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public TransactionEventType EventType { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Index to sort event order
        /// </summary>
        /// <value>Index to sort event order</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupplyChangeEvent {\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as SupplyChangeEvent);
        }

        /// <summary>
        /// Returns true if SupplyChangeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SupplyChangeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupplyChangeEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                if (this.TotalSupply != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSupply.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // TotalSupply (string) pattern
            Regex regexTotalSupply = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTotalSupply.Match(this.TotalSupply).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalSupply, must match a pattern of " + regexTotalSupply, new [] { "TotalSupply" });
            }

            // Contract (string) maxLength
            if (this.Contract != null && this.Contract.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be less than 42.", new [] { "Contract" });
            }

            // Contract (string) minLength
            if (this.Contract != null && this.Contract.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be greater than 30.", new [] { "Contract" });
            }

            // Contract (string) pattern
            Regex regexContract = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexContract.Match(this.Contract).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, must match a pattern of " + regexContract, new [] { "Contract" });
            }

            // SortOrder (int) minimum
            if (this.SortOrder < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOrder, must be a value greater than or equal to 0.", new [] { "SortOrder" });
            }

            yield break;
        }
    }

}
