// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class CommonDataServiceForAppsSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("writeBehavior");
            writer.WriteStringValue(WriteBehavior);
            if (IgnoreNullValues != null)
            {
                writer.WritePropertyName("ignoreNullValues");
                writer.WriteObjectValue(IgnoreNullValues);
            }
            if (AlternateKeyName != null)
            {
                writer.WritePropertyName("alternateKeyName");
                writer.WriteObjectValue(AlternateKeyName);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (WriteBatchSize != null)
            {
                writer.WritePropertyName("writeBatchSize");
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (WriteBatchTimeout != null)
            {
                writer.WritePropertyName("writeBatchTimeout");
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (SinkRetryCount != null)
            {
                writer.WritePropertyName("sinkRetryCount");
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (SinkRetryWait != null)
            {
                writer.WritePropertyName("sinkRetryWait");
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CommonDataServiceForAppsSink DeserializeCommonDataServiceForAppsSink(JsonElement element)
        {
            string writeBehavior = default;
            object ignoreNullValues = default;
            object alternateKeyName = default;
            string type = default;
            object writeBatchSize = default;
            object writeBatchTimeout = default;
            object sinkRetryCount = default;
            object sinkRetryWait = default;
            object maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"))
                {
                    writeBehavior = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreNullValues = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("alternateKeyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alternateKeyName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CommonDataServiceForAppsSink(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties, writeBehavior, ignoreNullValues, alternateKeyName);
        }
    }
}
