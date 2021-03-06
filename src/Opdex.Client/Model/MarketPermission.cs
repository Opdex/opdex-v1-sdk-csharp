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
    /// Market permission type
    /// </summary>
    /// <value>Market permission type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketPermission
    {
        /// <summary>
        /// Enum CreatePool for value: CreatePool
        /// </summary>
        [EnumMember(Value = "CreatePool")]
        CreatePool = 1,

        /// <summary>
        /// Enum Trade for value: Trade
        /// </summary>
        [EnumMember(Value = "Trade")]
        Trade = 2,

        /// <summary>
        /// Enum Provide for value: Provide
        /// </summary>
        [EnumMember(Value = "Provide")]
        Provide = 3,

        /// <summary>
        /// Enum SetPermissions for value: SetPermissions
        /// </summary>
        [EnumMember(Value = "SetPermissions")]
        SetPermissions = 4

    }

}
