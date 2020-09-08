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

namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Generic queryString argument.
    /// 
    /// </summary>
    [JsonConverter(typeof(ArgumentModelConverter))]
    public class Argument 
    {
                ///
        /// <value>
        /// Classification of argument type.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FIELD")]
            Field,
            [EnumMember(Value = "LITERAL")]
            Literal
        };

        /// <value>
        /// Classification of argument type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
    }

    public class ArgumentModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Argument);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Argument);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "LITERAL":
                    obj = new LiteralArgument();
                    break;
                case "FIELD":
                    obj = new FieldArgument();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
