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
    /// ReservesSummary
    /// </summary>
    [DataContract(Name = "reservesSummary")]
    public partial class ReservesSummary : IEquatable<ReservesSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservesSummary" /> class.
        /// </summary>
        /// <param name="crs">Decimal value with uncapped precision and size.</param>
        /// <param name="src">Decimal value with uncapped precision and size.</param>
        /// <param name="usd">Decimal value with uncapped precision and size.</param>
        /// <param name="dailyUsdPercentChange">Decimal value with uncapped precision and size.</param>
        public ReservesSummary(string crs = default(string), string src = default(string), string usd = default(string), string dailyUsdPercentChange = default(string))
        {
            this.Crs = crs;
            this.Src = src;
            this.Usd = usd;
            this.DailyUsdPercentChange = dailyUsdPercentChange;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "crs", EmitDefaultValue = false)]
        public string Crs { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "src", EmitDefaultValue = false)]
        public string Src { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "usd", EmitDefaultValue = false)]
        public string Usd { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "dailyUsdPercentChange", EmitDefaultValue = false)]
        public string DailyUsdPercentChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReservesSummary {\n");
            sb.Append("  Crs: ").Append(Crs).Append("\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Usd: ").Append(Usd).Append("\n");
            sb.Append("  DailyUsdPercentChange: ").Append(DailyUsdPercentChange).Append("\n");
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
            return this.Equals(input as ReservesSummary);
        }

        /// <summary>
        /// Returns true if ReservesSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ReservesSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservesSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Crs == input.Crs ||
                    (this.Crs != null &&
                    this.Crs.Equals(input.Crs))
                ) && 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
                ) && 
                (
                    this.Usd == input.Usd ||
                    (this.Usd != null &&
                    this.Usd.Equals(input.Usd))
                ) && 
                (
                    this.DailyUsdPercentChange == input.DailyUsdPercentChange ||
                    (this.DailyUsdPercentChange != null &&
                    this.DailyUsdPercentChange.Equals(input.DailyUsdPercentChange))
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
                if (this.Crs != null)
                {
                    hashCode = (hashCode * 59) + this.Crs.GetHashCode();
                }
                if (this.Src != null)
                {
                    hashCode = (hashCode * 59) + this.Src.GetHashCode();
                }
                if (this.Usd != null)
                {
                    hashCode = (hashCode * 59) + this.Usd.GetHashCode();
                }
                if (this.DailyUsdPercentChange != null)
                {
                    hashCode = (hashCode * 59) + this.DailyUsdPercentChange.GetHashCode();
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
            // Crs (string) pattern
            Regex regexCrs = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexCrs.Match(this.Crs).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Crs, must match a pattern of " + regexCrs, new [] { "Crs" });
            }

            // Src (string) pattern
            Regex regexSrc = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexSrc.Match(this.Src).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Src, must match a pattern of " + regexSrc, new [] { "Src" });
            }

            // Usd (string) pattern
            Regex regexUsd = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexUsd.Match(this.Usd).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Usd, must match a pattern of " + regexUsd, new [] { "Usd" });
            }

            // DailyUsdPercentChange (string) pattern
            Regex regexDailyUsdPercentChange = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexDailyUsdPercentChange.Match(this.DailyUsdPercentChange).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DailyUsdPercentChange, must match a pattern of " + regexDailyUsdPercentChange, new [] { "DailyUsdPercentChange" });
            }

            yield break;
        }
    }

}
