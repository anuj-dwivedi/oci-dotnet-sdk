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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties for a dashboard, including dashboard id.
    /// </summary>
    public class ManagementDashboard 
    {
        
        /// <value>
        /// Dashboard Id. Must be providied if OOB, otherwise must not be provided.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DashboardId is required.")]
        [JsonProperty(PropertyName = "dashboardId")]
        public string DashboardId { get; set; }

        /// <value>
        /// Provider Id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderId is required.")]
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }

        /// <value>
        /// Provider name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderName is required.")]
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }

        /// <value>
        /// Provider version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderVersion is required.")]
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }

        /// <value>
        /// Dashboard tiles array
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Tiles is required.")]
        [JsonProperty(PropertyName = "tiles")]
        public System.Collections.Generic.List<ManagementDashboardTileDetails> Tiles { get; set; }

        /// <value>
        /// Display name for dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Dashboard's description.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The ocid of the compartment that owns the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// String boolean (\"true\" or \"false\"). OOB (Out of the Box) dashboards are only provided by Oracle.  They cannot be modified by non-Oracle.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOobDashboard is required.")]
        [JsonProperty(PropertyName = "isOobDashboard")]
        public System.Nullable<bool> IsOobDashboard { get; set; }

        /// <value>
        /// String boolean (\"true\" or \"false\").  When false, dashboard is not shown in dashboard home.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsShowInHome is required.")]
        [JsonProperty(PropertyName = "isShowInHome")]
        public System.Nullable<bool> IsShowInHome { get; set; }

        /// <value>
        /// Created by which user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }

        /// <value>
        /// Time created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// Updated by which user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdatedBy is required.")]
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }

        /// <value>
        /// Time updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// Version of the metadata.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadataVersion is required.")]
        [JsonProperty(PropertyName = "metadataVersion")]
        public string MetadataVersion { get; set; }

        /// <value>
        /// String boolean (\"true\" or \"false\").  When false, dashboard is not automatically refreshed in intervals.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsShowDescription is required.")]
        [JsonProperty(PropertyName = "isShowDescription")]
        public System.Nullable<bool> IsShowDescription { get; set; }

        /// <value>
        /// screen image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScreenImage is required.")]
        [JsonProperty(PropertyName = "screenImage")]
        public string ScreenImage { get; set; }

        /// <value>
        /// Json for internationalization.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nls is required.")]
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }

        /// <value>
        /// Json to contain options for UI.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UiConfig is required.")]
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }

        /// <value>
        /// Array of Json to contain options for source of data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataConfig is required.")]
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }

        /// <value>
        /// NORMAL means single dashboard, SET means dashboard set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <value>
        /// String boolean (\"true\" or \"false\").
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsFavorite is required.")]
        [JsonProperty(PropertyName = "isFavorite")]
        public System.Nullable<bool> IsFavorite { get; set; }

        /// <value>
        /// Array of saved searches.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SavedSearches is required.")]
        [JsonProperty(PropertyName = "savedSearches")]
        public System.Collections.Generic.List<ManagementSavedSearch> SavedSearches { get; set; }

        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
