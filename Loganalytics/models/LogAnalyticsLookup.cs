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
    /// LogAnalyticsLookup
    /// </summary>
    public class LogAnalyticsLookup 
    {
        
        /// <value>
        /// active edit version
        /// </value>
        [JsonProperty(PropertyName = "activeEditVersion")]
        public System.Nullable<long> ActiveEditVersion { get; set; }

        /// <value>
        /// canonical link
        /// </value>
        [JsonProperty(PropertyName = "canonicalLink")]
        public string CanonicalLink { get; set; }

        /// <value>
        /// description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// edit version
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }

        /// <value>
        /// fields
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<LookupField> Fields { get; set; }

        /// <value>
        /// lookupReference
        /// </value>
        [JsonProperty(PropertyName = "lookupReference")]
        public System.Nullable<long> LookupReference { get; set; }

        /// <value>
        /// iname
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// is built in
        /// </value>
        [JsonProperty(PropertyName = "isBuiltIn")]
        public System.Nullable<long> IsBuiltIn { get; set; }

        /// <value>
        /// is hidden
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }

        /// <value>
        /// name
        /// </value>
        [JsonProperty(PropertyName = "lookupDisplayName")]
        public string LookupDisplayName { get; set; }

        /// <value>
        /// sources using
        /// </value>
        [JsonProperty(PropertyName = "referringSources")]
        public AutoLookups ReferringSources { get; set; }

        /// <value>
        /// status summary
        /// </value>
        [JsonProperty(PropertyName = "statusSummary")]
        public StatusSummary StatusSummary { get; set; }

        /// <value>
        /// last updated date
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
    }
}
