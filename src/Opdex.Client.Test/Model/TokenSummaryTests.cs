/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opdex.Client.Api;
using Opdex.Client.Model;
using Opdex.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opdex.Client.Test.Model
{
    /// <summary>
    ///  Class for testing TokenSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TokenSummaryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TokenSummary
        //private TokenSummary instance;

        public TokenSummaryTests()
        {
            // TODO uncomment below to create an instance of TokenSummary
            //instance = new TokenSummary();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokenSummary
        /// </summary>
        [Fact]
        public void TokenSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsType" TokenSummary
            //Assert.IsType<TokenSummary>(instance);
        }


        /// <summary>
        /// Test the property 'PriceUsd'
        /// </summary>
        [Fact]
        public void PriceUsdTest()
        {
            // TODO unit test for the property 'PriceUsd'
        }
        /// <summary>
        /// Test the property 'DailyPriceChangePercent'
        /// </summary>
        [Fact]
        public void DailyPriceChangePercentTest()
        {
            // TODO unit test for the property 'DailyPriceChangePercent'
        }
        /// <summary>
        /// Test the property 'CreatedBlock'
        /// </summary>
        [Fact]
        public void CreatedBlockTest()
        {
            // TODO unit test for the property 'CreatedBlock'
        }
        /// <summary>
        /// Test the property 'ModifiedBlock'
        /// </summary>
        [Fact]
        public void ModifiedBlockTest()
        {
            // TODO unit test for the property 'ModifiedBlock'
        }

    }

}
