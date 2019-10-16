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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateForecast operation.
    /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
    /// was used to train the predictor. This is known as inference. To retrieve the forecast
    /// for a single item at low latency, use the operation. To export the complete forecast
    /// into your Amazon Simple Storage Service (Amazon S3), use the <a>CreateForecastExportJob</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// The range of the forecast is determined by the <code>ForecastHorizon</code>, specified
    /// in the <a>CreatePredictor</a> request, multiplied by the <code>DataFrequency</code>,
    /// specified in the <a>CreateDataset</a> request. When you query a forecast, you can
    /// request a specific date range within the complete forecast.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
    /// that was used to create the predictor.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a>howitworks-forecast</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
    /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
    /// status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateForecastRequest : AmazonForecastServiceRequest
    {
        private string _forecastName;
        private string _predictorArn;

        /// <summary>
        /// Gets and sets the property ForecastName. 
        /// <para>
        /// The name for the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ForecastName
        {
            get { return this._forecastName; }
            set { this._forecastName = value; }
        }

        // Check to see if ForecastName property is set
        internal bool IsSetForecastName()
        {
            return this._forecastName != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor to use to generate the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

    }
}