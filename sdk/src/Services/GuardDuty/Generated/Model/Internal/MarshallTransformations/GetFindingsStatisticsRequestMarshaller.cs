/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFindingsStatistics Request Marshaller
    /// </summary>       
    public class GetFindingsStatisticsRequestMarshaller : IMarshaller<IRequest, GetFindingsStatisticsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFindingsStatisticsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetFindingsStatisticsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GuardDuty");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-28";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDetectorId())
                throw new AmazonGuardDutyException("Request object does not have required field DetectorId set");
            request.AddPathResource("{detectorId}", StringUtils.FromString(publicRequest.DetectorId));
            request.ResourcePath = "/detector/{detectorId}/findings/statistics";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFindingCriteria())
                {
                    context.Writer.WritePropertyName("findingCriteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = FindingCriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FindingCriteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFindingStatisticTypes())
                {
                    context.Writer.WritePropertyName("findingStatisticTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFindingStatisticTypesListValue in publicRequest.FindingStatisticTypes)
                    {
                            context.Writer.Write(publicRequestFindingStatisticTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetFindingsStatisticsRequestMarshaller _instance = new GetFindingsStatisticsRequestMarshaller();        

        internal static GetFindingsStatisticsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetFindingsStatisticsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}