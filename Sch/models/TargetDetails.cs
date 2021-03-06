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
using Newtonsoft.Json.Linq;

namespace Oci.SchService.Models
{
    /// <summary>
    /// An object that represents the target of the flow defined by the service connector.
    /// An example target is a stream.
    /// For more information about flows defined by service connectors, see
    /// [Service Connector Hub Overview](https://docs.cloud.oracle.com/iaas/service-connector-hub/using/index.htm).
    /// 
    /// </summary>
    [JsonConverter(typeof(TargetDetailsModelConverter))]
    public class TargetDetails 
    {
                ///
        /// <value>
        /// The type descriminator.
        /// 
        /// </value>
        ///
        public enum KindEnum {
            [EnumMember(Value = "streaming")]
            Streaming,
            [EnumMember(Value = "objectStorage")]
            ObjectStorage,
            [EnumMember(Value = "monitoring")]
            Monitoring,
            [EnumMember(Value = "functions")]
            Functions,
            [EnumMember(Value = "notifications")]
            Notifications
        };

        /// <value>
        /// The type descriminator.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Kind is required.")]
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KindEnum> Kind { get; set; }
    }

    public class TargetDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TargetDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TargetDetails);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "notifications":
                    obj = new NotificationsTargetDetails();
                    break;
                case "objectStorage":
                    obj = new ObjectStorageTargetDetails();
                    break;
                case "monitoring":
                    obj = new MonitoringTargetDetails();
                    break;
                case "functions":
                    obj = new FunctionsTargetDetails();
                    break;
                case "streaming":
                    obj = new StreamingTargetDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
