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
    /// LogAnalyticsParserFunctionParameter
    /// </summary>
    public class LogAnalyticsParserFunctionParameter 
    {
        
        /// <value>
        /// plugin Id
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionId")]
        public System.Nullable<long> ParserFunctionId { get; set; }

        /// <value>
        /// internal name
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionParameterName")]
        public string ParserFunctionParameterName { get; set; }

        /// <value>
        /// plugin instance Id
        /// </value>
        [JsonProperty(PropertyName = "parserFunctionParameterId")]
        public System.Nullable<long> ParserFunctionParameterId { get; set; }

        /// <value>
        /// parameter internal name
        /// </value>
        [JsonProperty(PropertyName = "parserMetaPluginParameterName")]
        public string ParserMetaPluginParameterName { get; set; }

        /// <value>
        /// parameter value
        /// </value>
        [JsonProperty(PropertyName = "parserMetaPluginParameterValue")]
        public string ParserMetaPluginParameterValue { get; set; }

        /// <value>
        /// parser internal name
        /// </value>
        [JsonProperty(PropertyName = "parserName")]
        public string ParserName { get; set; }

        [JsonProperty(PropertyName = "parserMetaPluginParameter")]
        public LogAnalyticsParserMetaPluginParameter ParserMetaPluginParameter { get; set; }
    }
}
