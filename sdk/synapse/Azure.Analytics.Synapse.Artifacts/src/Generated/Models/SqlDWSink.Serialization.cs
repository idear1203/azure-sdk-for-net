// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SqlDWSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PreCopyScript != null)
            {
                writer.WritePropertyName("preCopyScript");
                writer.WriteObjectValue(PreCopyScript);
            }
            if (AllowPolyBase != null)
            {
                writer.WritePropertyName("allowPolyBase");
                writer.WriteObjectValue(AllowPolyBase);
            }
            if (PolyBaseSettings != null)
            {
                writer.WritePropertyName("polyBaseSettings");
                writer.WriteObjectValue(PolyBaseSettings);
            }
            if (AllowCopyCommand != null)
            {
                writer.WritePropertyName("allowCopyCommand");
                writer.WriteObjectValue(AllowCopyCommand);
            }
            if (CopyCommandSettings != null)
            {
                writer.WritePropertyName("copyCommandSettings");
                writer.WriteObjectValue(CopyCommandSettings);
            }
            if (TableOption != null)
            {
                writer.WritePropertyName("tableOption");
                writer.WriteObjectValue(TableOption);
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

        internal static SqlDWSink DeserializeSqlDWSink(JsonElement element)
        {
            object preCopyScript = default;
            object allowPolyBase = default;
            PolybaseSettings polyBaseSettings = default;
            object allowCopyCommand = default;
            DWCopyCommandSettings copyCommandSettings = default;
            object tableOption = default;
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
                if (property.NameEquals("preCopyScript"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preCopyScript = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("allowPolyBase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPolyBase = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("polyBaseSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    polyBaseSettings = PolybaseSettings.DeserializePolybaseSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("allowCopyCommand"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCopyCommand = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyCommandSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyCommandSettings = DWCopyCommandSettings.DeserializeDWCopyCommandSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("tableOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableOption = property.Value.GetObject();
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
            return new SqlDWSink(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties, preCopyScript, allowPolyBase, polyBaseSettings, allowCopyCommand, copyCommandSettings, tableOption);
        }
    }
}
