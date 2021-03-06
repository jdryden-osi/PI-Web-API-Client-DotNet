// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using NUnit.Framework;
using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System.Collections.Generic;

namespace OSIsoft.PIDevClub.PIWebApiClient.Test
{
    /// <summary>
    ///  Class for testing AttributeTraitApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AttributeTraitApiTests : CommonApi
    {
        private IAttributeTraitApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            base.CommonInit();
            instance = client.AttributeTrait;
            base.CreateSampleDatabaseForTests();

            ////string path = Constants.AF_ATTRIBUTE_PATH;
            //string selectedFields = null;
            ////webId = instance.GetByPath(path, selectedFields).WebId;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            base.DeleteSampleDatabaseForTests();
        }

        /// <summary>
        /// Test an instance of AttributeTraitApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AttributeTraitApi
            Assert.IsInstanceOf(typeof(AttributeTraitApi), instance, "instance is a AttributeTraitApi");
        }


        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = "LimitLoLo";
            string selectedFields = null;
            var response = instance.Get(name, selectedFields);
            Assert.IsInstanceOf<PIAttributeTrait>(response, "response is PIAttributeTrait");
        }

        /// <summary>
        /// Test GetByCategory
        /// </summary>
        [Test]
        public void GetByCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            List<string> category = new List<string>() { "Limit" };
            string selectedFields = null;
            var response = instance.GetByCategory(category, selectedFields);
            Assert.IsInstanceOf<PIItemsAttributeTrait>(response, "response is PIItemsAttributeTrait");
        }

    }

}
