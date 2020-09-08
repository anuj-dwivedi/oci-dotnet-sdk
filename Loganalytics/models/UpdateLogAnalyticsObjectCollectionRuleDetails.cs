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
    /// To update the attributes of an Object Storage based collection rule.
    /// 
    /// </summary>
    public class UpdateLogAnalyticsObjectCollectionRuleDetails 
    {
        
        /// <value>
        /// A string that describes the details of the rule.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// Log Analytics Log group OCID to associate the processed logs with.
        /// </value>
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }

        /// <value>
        /// Name of the Log Analytics Source to use for the processing.
        /// </value>
        [JsonProperty(PropertyName = "logSourceName")]
        public string LogSourceName { get; set; }

        /// <value>
        /// Log Analytics entity OCID. Associates the processed logs with the given entity (optional).
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }

        /// <value>
        /// An optional character encoding to aid in detecting the character encoding of the contents of the objects while processing.
        /// It is recommended to set this value as ISO_8589_1 when configuring content of the objects having more numeric characters,
        /// and very few alphabets.
        /// For e.g. this applies when configuring VCN Flow Logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "charEncoding")]
        public string CharEncoding { get; set; }

        /// <value>
        /// Use this to override some property values which are defined at bucket level to the scope of object.
        /// Supported propeties for override are, logSourceName, charEncoding.
        /// Supported matchType for override are \"contains\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overrides")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PropertyOverride>> Overrides { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
    }
}
