/*
 * Dingo Mail AU API
 *
 * <p>API for api.dingomail.com.au</p> 
 *
 * The version of the OpenAPI document: 0.2.4
 * Contact: info@dingomail.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Au.Com.Dingomail.Api.Dingomailau.Client;
using Au.Com.Dingomail.Api.Dingomailau.Api;
// uncomment below to import models
//using Au.Com.Dingomail.Api.Dingomailau.Model;

namespace Au.Com.Dingomail.Api.Dingomailau.Test.Api
{
    /// <summary>
    ///  Class for testing OptoutsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OptoutsApiTests : IDisposable
    {
        private OptoutsApi instance;

        public OptoutsApiTests()
        {
            instance = new OptoutsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OptoutsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OptoutsApi
            //Assert.IsType<OptoutsApi>(instance);
        }

        /// <summary>
        /// Test GetUnsubscribes
        /// </summary>
        [Fact]
        public void GetUnsubscribesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyid = null;
            //var response = instance.GetUnsubscribes(keyid);
            //Assert.IsType<List<GetUnsubscribes>>(response);
        }
    }
}