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
    /// LiquidityPoolRewardsSnapshot
    /// </summary>
    [DataContract(Name = "liquidityPoolRewardsSnapshot")]
    public partial class LiquidityPoolRewardsSnapshot : IEquatable<LiquidityPoolRewardsSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidityPoolRewardsSnapshot" /> class.
        /// </summary>
        /// <param name="providerUsd">Decimal value with uncapped precision and size.</param>
        /// <param name="marketUsd">Decimal value with uncapped precision and size.</param>
        /// <param name="totalUsd">Decimal value with uncapped precision and size.</param>
        public LiquidityPoolRewardsSnapshot(string providerUsd = default(string), string marketUsd = default(string), string totalUsd = default(string))
        {
            this.ProviderUsd = providerUsd;
            this.MarketUsd = marketUsd;
            this.TotalUsd = totalUsd;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "providerUsd", EmitDefaultValue = false)]
        public string ProviderUsd { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "marketUsd", EmitDefaultValue = false)]
        public string MarketUsd { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "totalUsd", EmitDefaultValue = false)]
        public string TotalUsd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiquidityPoolRewardsSnapshot {\n");
            sb.Append("  ProviderUsd: ").Append(ProviderUsd).Append("\n");
            sb.Append("  MarketUsd: ").Append(MarketUsd).Append("\n");
            sb.Append("  TotalUsd: ").Append(TotalUsd).Append("\n");
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
            return this.Equals(input as LiquidityPoolRewardsSnapshot);
        }

        /// <summary>
        /// Returns true if LiquidityPoolRewardsSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of LiquidityPoolRewardsSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiquidityPoolRewardsSnapshot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderUsd == input.ProviderUsd ||
                    (this.ProviderUsd != null &&
                    this.ProviderUsd.Equals(input.ProviderUsd))
                ) && 
                (
                    this.MarketUsd == input.MarketUsd ||
                    (this.MarketUsd != null &&
                    this.MarketUsd.Equals(input.MarketUsd))
                ) && 
                (
                    this.TotalUsd == input.TotalUsd ||
                    (this.TotalUsd != null &&
                    this.TotalUsd.Equals(input.TotalUsd))
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
                if (this.ProviderUsd != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderUsd.GetHashCode();
                }
                if (this.MarketUsd != null)
                {
                    hashCode = (hashCode * 59) + this.MarketUsd.GetHashCode();
                }
                if (this.TotalUsd != null)
                {
                    hashCode = (hashCode * 59) + this.TotalUsd.GetHashCode();
                }
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
            // ProviderUsd (string) pattern
            Regex regexProviderUsd = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexProviderUsd.Match(this.ProviderUsd).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProviderUsd, must match a pattern of " + regexProviderUsd, new [] { "ProviderUsd" });
            }

            // MarketUsd (string) pattern
            Regex regexMarketUsd = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexMarketUsd.Match(this.MarketUsd).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MarketUsd, must match a pattern of " + regexMarketUsd, new [] { "MarketUsd" });
            }

            // TotalUsd (string) pattern
            Regex regexTotalUsd = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTotalUsd.Match(this.TotalUsd).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalUsd, must match a pattern of " + regexTotalUsd, new [] { "TotalUsd" });
            }

            yield break;
        }
    }

}
