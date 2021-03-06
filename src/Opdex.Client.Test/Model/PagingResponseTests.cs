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
    ///  Class for testing PagingResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PagingResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PagingResponse
        //private PagingResponse instance;

        public PagingResponseTests()
        {
            // TODO uncomment below to create an instance of PagingResponse
            //instance = new PagingResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PagingResponse
        /// </summary>
        [Fact]
        public void PagingResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" PagingResponse
            //Assert.IsType<PagingResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Next'
        /// </summary>
        [Fact]
        public void NextTest()
        {
            // TODO unit test for the property 'Next'
        }
        /// <summary>
        /// Test the property 'Previous'
        /// </summary>
        [Fact]
        public void PreviousTest()
        {
            // TODO unit test for the property 'Previous'
        }

    }

}
