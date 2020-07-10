// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SqlMISink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SqlWriterStoredProcedureName != null)
            {
                writer.WritePropertyName("sqlWriterStoredProcedureName");
                writer.WriteObjectValue(SqlWriterStoredProcedureName);
            }
            if (SqlWriterTableType != null)
            {
                writer.WritePropertyName("sqlWriterTableType");
                writer.WriteObjectValue(SqlWriterTableType);
            }
            if (PreCopyScript != null)
            {
                writer.WritePropertyName("preCopyScript");
                writer.WriteObjectValue(PreCopyScript);
            }
            if (StoredProcedureParameters != null)
            {
                writer.WritePropertyName("storedProcedureParameters");
                writer.WriteStartObject();
                foreach (var item in StoredProcedureParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (StoredProcedureTableTypeParameterName != null)
            {
                writer.WritePropertyName("storedProcedureTableTypeParameterName");
                writer.WriteObjectValue(StoredProcedureTableTypeParameterName);
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

        internal static SqlMISink DeserializeSqlMISink(JsonElement element)
        {
            object sqlWriterStoredProcedureName = default;
            object sqlWriterTableType = default;
            object preCopyScript = default;
            IDictionary<string, StoredProcedureParameter> storedProcedureParameters = default;
            object storedProcedureTableTypeParameterName = default;
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
                if (property.NameEquals("sqlWriterStoredProcedureName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterStoredProcedureName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sqlWriterTableType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterTableType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("preCopyScript"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preCopyScript = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, StoredProcedureParameter> dictionary = new Dictionary<string, StoredProcedureParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, StoredProcedureParameter.DeserializeStoredProcedureParameter(property0.Value));
                        }
                    }
                    storedProcedureParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("storedProcedureTableTypeParameterName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storedProcedureTableTypeParameterName = property.Value.GetObject();
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
            return new SqlMISink(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties, sqlWriterStoredProcedureName, sqlWriterTableType, preCopyScript, storedProcedureParameters, storedProcedureTableTypeParameterName, tableOption);
        }
    }
}
