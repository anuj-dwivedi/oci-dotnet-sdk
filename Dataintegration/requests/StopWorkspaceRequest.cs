/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Requests
{
    public class StopWorkspaceRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// DIS workspace id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkspaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "workspaceId")]
        public string WorkspaceId { get; set; }
        
        /// <value>
        /// This parameter allows users to set the timeout for DIS to gracefully close down any running jobs before stopping the workspace.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "quiesceTimeout")]
        public System.Nullable<long> QuiesceTimeout { get; set; }
        
        /// <value>
        /// This parameter allows users to force close down the workspace.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isForceOperation")]
        public System.Nullable<bool> IsForceOperation { get; set; }
        
        /// <value>
        /// Update and Delete operations should accept an optional If-Match header,
        /// in which clients can send a previously-received ETag. When If-Match is
        /// provided and its value does not exactly match the ETag of the resource
        /// on the server, the request should fail with HTTP response status code 412
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If
        /// you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Caller may provide \"retry tokens\" allowing them to retry an operation
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}