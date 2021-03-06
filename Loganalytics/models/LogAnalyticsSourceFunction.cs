/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsSourceFunction
    /// </summary>
    public class LogAnalyticsSourceFunction 
    {
        
        /// <value>
        /// argument
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<LogAnalyticsMetaFunctionArgument> Arguments { get; set; }

        /// <value>
        /// enabled flag
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }

        [JsonProperty(PropertyName = "function")]
        public LogAnalyticsMetaFunction Function { get; set; }

        /// <value>
        /// source function Id
        /// </value>
        [JsonProperty(PropertyName = "functionId")]
        public System.Nullable<long> FunctionId { get; set; }

        /// <value>
        /// source function order
        /// </value>
        [JsonProperty(PropertyName = "order")]
        public System.Nullable<long> Order { get; set; }

        /// <value>
        /// is system flag
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }

        /// <value>
        /// column
        /// </value>
        [JsonProperty(PropertyName = "lookupColumn")]
        public string LookupColumn { get; set; }

        /// <value>
        /// column position
        /// </value>
        [JsonProperty(PropertyName = "lookupColumnPosition")]
        public System.Nullable<long> LookupColumnPosition { get; set; }

        /// <value>
        /// lookup display name
        /// </value>
        [JsonProperty(PropertyName = "lookupDisplayName")]
        public string LookupDisplayName { get; set; }

        /// <value>
        /// lookup mode
        /// </value>
        [JsonProperty(PropertyName = "lookupMode")]
        public System.Nullable<long> LookupMode { get; set; }

        /// <value>
        /// lookup table
        /// </value>
        [JsonProperty(PropertyName = "lookupTable")]
        public string LookupTable { get; set; }

        /// <value>
        /// source Id
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
    }
}
