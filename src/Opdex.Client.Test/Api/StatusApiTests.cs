/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Opdex.Client.Client;
using Opdex.Client.Api;
// uncomment below to import models
//using Opdex.Client.Model;

namespace Opdex.Client.Test.Api
{
    /// <summary>
    ///  Class for testing StatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatusApiTests : IDisposable
    {
        private StatusApi instance;

        public StatusApiTests()
        {
            instance = new StatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StatusApi
            //Assert.IsType<StatusApi>(instance);
        }

        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Fact]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStatus();
            //Assert.IsType<StatusResponse>(response);
        }
    }
}
