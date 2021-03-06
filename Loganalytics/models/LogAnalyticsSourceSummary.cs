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
    /// LogAnalyticsSourceSummary
    /// </summary>
    public class LogAnalyticsSourceSummary 
    {
        
        /// <value>
        /// alert conditions
        /// </value>
        [JsonProperty(PropertyName = "labelConditions")]
        public System.Collections.Generic.List<LogAnalyticsSourceLabelCondition> LabelConditions { get; set; }

        /// <value>
        /// association count
        /// </value>
        [JsonProperty(PropertyName = "associationCount")]
        public System.Nullable<int> AssociationCount { get; set; }

        /// <value>
        /// association entity
        /// </value>
        [JsonProperty(PropertyName = "associationEntity")]
        public System.Collections.Generic.List<LogAnalyticsAssociation> AssociationEntity { get; set; }

        /// <value>
        /// data filter definitions
        /// </value>
        [JsonProperty(PropertyName = "dataFilterDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsSourceDataFilter> DataFilterDefinitions { get; set; }

        /// <value>
        /// DB credential
        /// </value>
        [JsonProperty(PropertyName = "databaseCredential")]
        public string DatabaseCredential { get; set; }

        /// <value>
        /// extended field definition
        /// </value>
        [JsonProperty(PropertyName = "extendedFieldDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsSourceExtendedFieldDefinition> ExtendedFieldDefinitions { get; set; }

        /// <value>
        /// is for cloud flag
        /// </value>
        [JsonProperty(PropertyName = "isForCloud")]
        public System.Nullable<bool> IsForCloud { get; set; }

        /// <value>
        /// labels
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<LogAnalyticsLabelView> Labels { get; set; }

        /// <value>
        /// metric definitions
        /// </value>
        [JsonProperty(PropertyName = "metricDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsMetric> MetricDefinitions { get; set; }

        /// <value>
        /// metric source map
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<LogAnalyticsSourceMetric> Metrics { get; set; }

        /// <value>
        /// out-of-the-box source parser list
        /// </value>
        [JsonProperty(PropertyName = "oobParsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> OobParsers { get; set; }

        /// <value>
        /// parameters
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<LogAnalyticsParameter> Parameters { get; set; }

        /// <value>
        /// pattern count
        /// </value>
        [JsonProperty(PropertyName = "patternCount")]
        public System.Nullable<int> PatternCount { get; set; }

        /// <value>
        /// patterns
        /// </value>
        [JsonProperty(PropertyName = "patterns")]
        public System.Collections.Generic.List<LogAnalyticsSourcePattern> Patterns { get; set; }

        /// <value>
        /// description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// source edit version
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }

        /// <value>
        /// source functions
        /// </value>
        [JsonProperty(PropertyName = "functions")]
        public System.Collections.Generic.List<LogAnalyticsSourceFunction> Functions { get; set; }

        /// <value>
        /// source Id
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }

        /// <value>
        /// source internal name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// is secure content flag
        /// </value>
        [JsonProperty(PropertyName = "isSecureContent")]
        public System.Nullable<bool> IsSecureContent { get; set; }

        /// <value>
        /// is system flag
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }

        /// <value>
        /// parser list
        /// </value>
        [JsonProperty(PropertyName = "parsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> Parsers { get; set; }

        /// <value>
        /// rule auto association enabled flag
        /// </value>
        [JsonProperty(PropertyName = "isAutoAssociationEnabled")]
        public System.Nullable<bool> IsAutoAssociationEnabled { get; set; }

        /// <value>
        /// rule auto association override
        /// </value>
        [JsonProperty(PropertyName = "isAutoAssociationOverride")]
        public System.Nullable<bool> IsAutoAssociationOverride { get; set; }

        /// <value>
        /// rule Id
        /// </value>
        [JsonProperty(PropertyName = "ruleId")]
        public System.Nullable<long> RuleId { get; set; }

        /// <value>
        /// source type internal name
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <value>
        /// source type name
        /// </value>
        [JsonProperty(PropertyName = "typeDisplayName")]
        public string TypeDisplayName { get; set; }

        /// <value>
        /// source warning configuration
        /// </value>
        [JsonProperty(PropertyName = "warningConfig")]
        public System.Nullable<long> WarningConfig { get; set; }

        /// <value>
        /// source metadata fields
        /// </value>
        [JsonProperty(PropertyName = "metadataFields")]
        public System.Collections.Generic.List<LogAnalyticsSourceMetadataField> MetadataFields { get; set; }

        /// <value>
        /// tags
        /// </value>
        [JsonProperty(PropertyName = "labelDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsLabelDefinition> LabelDefinitions { get; set; }

        /// <value>
        /// Entity types
        /// </value>
        [JsonProperty(PropertyName = "entityTypes")]
        public System.Collections.Generic.List<LogAnalyticsSourceEntityType> EntityTypes { get; set; }

        /// <value>
        /// time zone override
        /// </value>
        [JsonProperty(PropertyName = "isTimezoneOverride")]
        public System.Nullable<bool> IsTimezoneOverride { get; set; }

        /// <value>
        /// source parser list
        /// </value>
        [JsonProperty(PropertyName = "userParsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> UserParsers { get; set; }

        /// <value>
        /// timeUpdated
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
    }
}
