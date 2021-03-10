// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunQueryOrderByConverter))]
    public partial class RunQueryOrderBy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orderBy");
            writer.WriteStringValue(OrderBy.ToString());
            writer.WritePropertyName("order");
            writer.WriteStringValue(Order.ToString());
            writer.WriteEndObject();
        }

        internal static RunQueryOrderBy DeserializeRunQueryOrderBy(JsonElement element)
        {
            RunQueryOrderByField orderBy = default;
            RunQueryOrder order = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orderBy"))
                {
                    orderBy = new RunQueryOrderByField(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    order = new RunQueryOrder(property.Value.GetString());
                    continue;
                }
            }
            return new RunQueryOrderBy(orderBy, order);
        }

        internal partial class RunQueryOrderByConverter : JsonConverter<RunQueryOrderBy>
        {
            public override void Write(Utf8JsonWriter writer, RunQueryOrderBy model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunQueryOrderBy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunQueryOrderBy(document.RootElement);
            }
        }
    }
}
