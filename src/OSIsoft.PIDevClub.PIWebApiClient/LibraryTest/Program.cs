﻿// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
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


using OSIsoft.PIDevClub.PIWebApiClient;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using OSIsoft.PIDevClub.PIWebApiClient.WebID;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the PI Web API top level object.

            PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", true);
            // TODO: The PI Web API client must provide a user name and password when using “basic” authentication 
            // Store passwords outside of the code in a hardware TPM, trusted service (credential manager) or in a protected file.
            // Code to return the user name and password is not shown here.



            var homeLanding = client.Home.Get();
            ////Get the PI Data Archive object
            PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");
            string expression = "'sinusoid'*2 + 'cdt158'";
            PITimedValues values = client.Calculation.GetAtTimes(webId: dataServer.WebId, expression: expression, time: new List<string>() { "*-1d" });

            string expression2 = "'cdt158'+tagval('sinusoid','*-1d')";
            PITimedValues values2 = client.Calculation.GetAtTimes(webId: dataServer.WebId, expression: expression2, time: new List<string>() { "*-1d" });

            PIItemsSummaryValue itemsSummaryValue = client.Calculation.GetSummary(expression: expression2, startTime: "*-1d", endTime: "*", webId: dataServer.WebId,
                summaryType: new List<string>() { "Average", "Maximum" });

            //Get PI Point
            PIPoint createdPoint = client.Point.GetByPath("\\\\MARC-PI2016\\SINUSOIDR1259", null);

            //Change the description of the PI Point
            string webId = createdPoint.WebId;
            createdPoint.DigitalSetName = null;
            createdPoint.EngineeringUnits = null;
            createdPoint.Descriptor = "New description";
            createdPoint.Future = null;
            createdPoint.Id = null;
            createdPoint.Links = null;
            createdPoint.Name = null;
            createdPoint.Path = null;
            createdPoint.PointClass = null;
            createdPoint.PointType = null;
            createdPoint.Span = null;
            createdPoint.Zero = null;
            createdPoint.WebId = null;

            //Update PI Point
            ApiResponse<Object> response = client.Point.UpdateWithHttpInfo(webId, createdPoint);

            //Check if the request was successful
            Console.WriteLine(response.StatusCode);

            //Get PI Points WebIds
            PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
            PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu", selectedFields: "webId;name");
            PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
            List<string> webIds = new List<string>() { point1.WebId, point2.WebId, point3.WebId };





            //Get recorded values in bulk 
            PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webId: webIds, startTime: "*-3d", endTime: "*");


            //Send values in bulk
            var streamValuesItems = new PIItemsStreamValues();
            var streamValue1 = new PIStreamValues();
            var streamValue2 = new PIStreamValues();
            var streamValue3 = new PIStreamValues();
            var value1 = new PITimedValue();
            var value2 = new PITimedValue();
            var value3 = new PITimedValue();
            var value4 = new PITimedValue();
            var value5 = new PITimedValue();
            var value6 = new PITimedValue();
            value1.Value = 2;
            value1.Timestamp = "*-1d";
            value2.Value = 3;
            value2.Timestamp = "*-2d";
            value3.Value = 4;
            value3.Timestamp = "*-1d";
            value4.Value = 5;
            value4.Timestamp = "*-2d";
            value5.Value = 6;
            value5.Timestamp = "*-1d";
            value6.Value = 7;
            value6.Timestamp = "*-2d";
            streamValue1.WebId = point1.WebId;
            streamValue1.Items = new List<PITimedValue>();
            streamValue1.Items.Add(value1);
            streamValue1.Items.Add(value2);
            streamValue2.WebId = point2.WebId;
            streamValue2.Items = new List<PITimedValue>();
            streamValue2.Items.Add(value3);
            streamValue2.Items.Add(value4);
            streamValue3.WebId = point2.WebId;
            streamValue3.Items = new List<PITimedValue>();
            streamValue3.Items.Add(value5);
            streamValue3.Items.Add(value6);
            ApiResponse<PIItemsItemsSubstatus> response2 = client.StreamSet.UpdateValuesAdHocWithHttpInfo(new List<PIStreamValues>() { streamValue1, streamValue2, streamValue3 });




            //Get an element given a path
            PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");


            //Get element's attributes
            PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, null, 1000, null, false);

            //Get an attribute given a path
            PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));

            WebIdInfo webIdInfo = client.WebIdHelper.GetWebIdInfo(myElement.WebId);
            WebIdInfo webIdInfo2 = client.WebIdHelper.GetWebIdInfo(attribute.WebId);
            WebIdInfo webIdInfo4 = client.WebIdHelper.GetWebIdInfo(point1.WebId);
            WebIdInfo webIdInfo3 = client.WebIdHelper.GetWebIdInfo(dataServer.WebId);

            //Get the attribute's end of the stream value
            PITimedValue value = client.Stream.GetEnd(attribute.WebId);

            //Cancelling the HTTP request with the CancellationToken
            Stopwatch watch = Stopwatch.StartNew();
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            PIItemsStreamValues bulkValues = null;
            try
            {
                Task t = Task.Run(async () =>
                {
                    bulkValues = await client.StreamSet.GetRecordedAdHocAsync(webId: webIds, startTime: "*-1800d", endTime: "*", maxCount: 50000, cancellationToken: cancellationTokenSource.Token);

                });
                //Cancel the request after 4s
                System.Threading.Thread.Sleep(4000);
                cancellationTokenSource.Cancel();
                t.Wait();
                Console.WriteLine("Completed task: Time elapsed: {0}s", 0.001 * watch.ElapsedMilliseconds);
            }
            catch (Exception)
            {
                Console.WriteLine("Cancelled task: Time elapsed: {0}s", 0.001 * watch.ElapsedMilliseconds);
            };


            //Stream Updates
            PIItemsStreamUpdatesRegister piItemsStreamUpdatesRegister = client.StreamSet.RegisterStreamSetUpdates(webIds);
            List<string> markers = piItemsStreamUpdatesRegister.Items.Select(i => i.LatestMarker).ToList();
            int k = 3;
            while (k > 0)
            {
                PIItemsStreamUpdatesRetrieve piItemsStreamUpdatesRetrieve = client.StreamSet.RetrieveStreamSetUpdates(markers);
                markers = piItemsStreamUpdatesRetrieve.Items.Select(i => i.LatestMarker).ToList();
                foreach (PIStreamUpdatesRetrieve item in piItemsStreamUpdatesRetrieve.Items)
                {
                    foreach (PIDataPipeEvent piEvent in item.Events)
                    {
                        Console.WriteLine("Action={0}, Value={1}, SourcePath={2}", piEvent.Action, piEvent.Value, item.SourcePath);
                    }
                }
                System.Threading.Thread.Sleep(30000);
                k--;
            }

            ChannelsExamples(client, webIds);
            Console.WriteLine("Finished");
            Console.ReadKey();

        }

        private static void ChannelsExamples(PIWebApiClient client, List<string> webIds)
        {
            //Example StartStream
            CancellationTokenSource cancellationSource1 = new CancellationTokenSource();
            IObserver<PIItemsStreamValues> observer1 = new CustomChannelObserver();
            Task channelTask1 = client.Channel.StartStream(webIds[0], observer1, cancellationSource1.Token);


            //Example StartStreamSet
            CancellationTokenSource cancellationSource2 = new CancellationTokenSource();
            IObserver<PIItemsStreamValues> observer2 = new CustomChannelObserver();
            PIElement element = client.Element.GetByPath("\\\\MARC-PI2016\\AFSDKTest\\Element2");
            Task channelTask2 = client.Channel.StartStreamSet(element.WebId, observer2, cancellationSource2.Token);



            //Example StartStreamSets
            CancellationTokenSource cancellationSource3 = new CancellationTokenSource();
            IObserver<PIItemsStreamValues> observer3 = new CustomChannelObserver();
            Task channelTask3 = client.Channel.StartStreamSets(webIds, observer3, cancellationSource3.Token);



            System.Threading.Thread.Sleep(120000);
            cancellationSource3.Cancel();
            cancellationSource2.Cancel();
            cancellationSource1.Cancel();
            channelTask1.Wait();
            channelTask2.Wait();
            channelTask3.Wait();
        }
    }
}
