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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the ListFaces operation.
    /// </summary>
    public partial class ListFacesResponse : AmazonWebServiceResponse
    {
        private List<Face> _faces = new List<Face>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Faces. 
        /// <para>
        /// An array of <code>Face</code> objects. 
        /// </para>
        /// </summary>
        public List<Face> Faces
        {
            get { return this._faces; }
            set { this._faces = value; }
        }

        // Check to see if Faces property is set
        internal bool IsSetFaces()
        {
            return this._faces != null && this._faces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Rekognition returns this token that you can use
        /// in the subsequent request to retrieve the next set of faces.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}