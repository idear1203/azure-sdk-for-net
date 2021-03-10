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
    [JsonConverter(typeof(RunFilterParametersConverter))]
    public partial class RunFilterParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken");
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WritePropertyName("lastUpdatedAfter");
            writer.WriteStringValue(LastUpdatedAfter, "O");
            writer.WritePropertyName("lastUpdatedBefore");
            writer.WriteStringValue(LastUpdatedBefore, "O");
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters");
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy");
                writer.WriteStartArray();
                foreach (var item in OrderBy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal partial class RunFilterParametersConverter : JsonConverter<RunFilterParameters>
        {
            public override void Write(Utf8JsonWriter writer, RunFilterParameters model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunFilterParameters Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunFilterParameters(document.RootElement);
            }
        }
    }
}
