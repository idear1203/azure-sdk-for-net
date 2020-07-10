// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class Dataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Structure != null)
            {
                writer.WritePropertyName("structure");
                writer.WriteObjectValue(Structure);
            }
            if (Schema != null)
            {
                writer.WritePropertyName("schema");
                writer.WriteObjectValue(Schema);
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Annotations != null)
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Folder != null)
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static Dataset DeserializeDataset(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSObject": return AmazonMWSObjectDataset.DeserializeAmazonMWSObjectDataset(element);
                    case "AmazonRedshiftTable": return AmazonRedshiftTableDataset.DeserializeAmazonRedshiftTableDataset(element);
                    case "Avro": return AvroDataset.DeserializeAvroDataset(element);
                    case "AzureDataExplorerTable": return AzureDataExplorerTableDataset.DeserializeAzureDataExplorerTableDataset(element);
                    case "AzureMariaDBTable": return AzureMariaDBTableDataset.DeserializeAzureMariaDBTableDataset(element);
                    case "AzureMySqlTable": return AzureMySqlTableDataset.DeserializeAzureMySqlTableDataset(element);
                    case "AzurePostgreSqlTable": return AzurePostgreSqlTableDataset.DeserializeAzurePostgreSqlTableDataset(element);
                    case "AzureSearchIndex": return AzureSearchIndexDataset.DeserializeAzureSearchIndexDataset(element);
                    case "AzureSqlDWTable": return AzureSqlDWTableDataset.DeserializeAzureSqlDWTableDataset(element);
                    case "AzureSqlMITable": return AzureSqlMITableDataset.DeserializeAzureSqlMITableDataset(element);
                    case "AzureSqlTable": return AzureSqlTableDataset.DeserializeAzureSqlTableDataset(element);
                    case "AzureTable": return AzureTableDataset.DeserializeAzureTableDataset(element);
                    case "Binary": return BinaryDataset.DeserializeBinaryDataset(element);
                    case "CassandraTable": return CassandraTableDataset.DeserializeCassandraTableDataset(element);
                    case "CommonDataServiceForAppsEntity": return CommonDataServiceForAppsEntityDataset.DeserializeCommonDataServiceForAppsEntityDataset(element);
                    case "ConcurObject": return ConcurObjectDataset.DeserializeConcurObjectDataset(element);
                    case "CosmosDbMongoDbApiCollection": return CosmosDbMongoDbApiCollectionDataset.DeserializeCosmosDbMongoDbApiCollectionDataset(element);
                    case "CosmosDbSqlApiCollection": return CosmosDbSqlApiCollectionDataset.DeserializeCosmosDbSqlApiCollectionDataset(element);
                    case "CouchbaseTable": return CouchbaseTableDataset.DeserializeCouchbaseTableDataset(element);
                    case "CustomDataset": return CustomDataset.DeserializeCustomDataset(element);
                    case "Db2Table": return Db2TableDataset.DeserializeDb2TableDataset(element);
                    case "DelimitedText": return DelimitedTextDataset.DeserializeDelimitedTextDataset(element);
                    case "DocumentDbCollection": return DocumentDbCollectionDataset.DeserializeDocumentDbCollectionDataset(element);
                    case "DrillTable": return DrillTableDataset.DeserializeDrillTableDataset(element);
                    case "DynamicsAXResource": return DynamicsAXResourceDataset.DeserializeDynamicsAXResourceDataset(element);
                    case "DynamicsCrmEntity": return DynamicsCrmEntityDataset.DeserializeDynamicsCrmEntityDataset(element);
                    case "DynamicsEntity": return DynamicsEntityDataset.DeserializeDynamicsEntityDataset(element);
                    case "EloquaObject": return EloquaObjectDataset.DeserializeEloquaObjectDataset(element);
                    case "GoogleAdWordsObject": return GoogleAdWordsObjectDataset.DeserializeGoogleAdWordsObjectDataset(element);
                    case "GoogleBigQueryObject": return GoogleBigQueryObjectDataset.DeserializeGoogleBigQueryObjectDataset(element);
                    case "GreenplumTable": return GreenplumTableDataset.DeserializeGreenplumTableDataset(element);
                    case "HBaseObject": return HBaseObjectDataset.DeserializeHBaseObjectDataset(element);
                    case "HiveObject": return HiveObjectDataset.DeserializeHiveObjectDataset(element);
                    case "HubspotObject": return HubspotObjectDataset.DeserializeHubspotObjectDataset(element);
                    case "ImpalaObject": return ImpalaObjectDataset.DeserializeImpalaObjectDataset(element);
                    case "InformixTable": return InformixTableDataset.DeserializeInformixTableDataset(element);
                    case "JiraObject": return JiraObjectDataset.DeserializeJiraObjectDataset(element);
                    case "Json": return JsonDataset.DeserializeJsonDataset(element);
                    case "MagentoObject": return MagentoObjectDataset.DeserializeMagentoObjectDataset(element);
                    case "MariaDBTable": return MariaDBTableDataset.DeserializeMariaDBTableDataset(element);
                    case "MarketoObject": return MarketoObjectDataset.DeserializeMarketoObjectDataset(element);
                    case "MicrosoftAccessTable": return MicrosoftAccessTableDataset.DeserializeMicrosoftAccessTableDataset(element);
                    case "MongoDbCollection": return MongoDbCollectionDataset.DeserializeMongoDbCollectionDataset(element);
                    case "MongoDbV2Collection": return MongoDbV2CollectionDataset.DeserializeMongoDbV2CollectionDataset(element);
                    case "MySqlTable": return MySqlTableDataset.DeserializeMySqlTableDataset(element);
                    case "NetezzaTable": return NetezzaTableDataset.DeserializeNetezzaTableDataset(element);
                    case "ODataResource": return ODataResourceDataset.DeserializeODataResourceDataset(element);
                    case "OdbcTable": return OdbcTableDataset.DeserializeOdbcTableDataset(element);
                    case "Office365Table": return Office365Dataset.DeserializeOffice365Dataset(element);
                    case "OracleServiceCloudObject": return OracleServiceCloudObjectDataset.DeserializeOracleServiceCloudObjectDataset(element);
                    case "OracleTable": return OracleTableDataset.DeserializeOracleTableDataset(element);
                    case "Orc": return OrcDataset.DeserializeOrcDataset(element);
                    case "Parquet": return ParquetDataset.DeserializeParquetDataset(element);
                    case "PaypalObject": return PaypalObjectDataset.DeserializePaypalObjectDataset(element);
                    case "PhoenixObject": return PhoenixObjectDataset.DeserializePhoenixObjectDataset(element);
                    case "PostgreSqlTable": return PostgreSqlTableDataset.DeserializePostgreSqlTableDataset(element);
                    case "PrestoObject": return PrestoObjectDataset.DeserializePrestoObjectDataset(element);
                    case "QuickBooksObject": return QuickBooksObjectDataset.DeserializeQuickBooksObjectDataset(element);
                    case "RelationalTable": return RelationalTableDataset.DeserializeRelationalTableDataset(element);
                    case "ResponsysObject": return ResponsysObjectDataset.DeserializeResponsysObjectDataset(element);
                    case "RestResource": return RestResourceDataset.DeserializeRestResourceDataset(element);
                    case "SalesforceMarketingCloudObject": return SalesforceMarketingCloudObjectDataset.DeserializeSalesforceMarketingCloudObjectDataset(element);
                    case "SalesforceObject": return SalesforceObjectDataset.DeserializeSalesforceObjectDataset(element);
                    case "SalesforceServiceCloudObject": return SalesforceServiceCloudObjectDataset.DeserializeSalesforceServiceCloudObjectDataset(element);
                    case "SapBwCube": return SapBwCubeDataset.DeserializeSapBwCubeDataset(element);
                    case "SapCloudForCustomerResource": return SapCloudForCustomerResourceDataset.DeserializeSapCloudForCustomerResourceDataset(element);
                    case "SapEccResource": return SapEccResourceDataset.DeserializeSapEccResourceDataset(element);
                    case "SapHanaTable": return SapHanaTableDataset.DeserializeSapHanaTableDataset(element);
                    case "SapOpenHubTable": return SapOpenHubTableDataset.DeserializeSapOpenHubTableDataset(element);
                    case "SapTableResource": return SapTableResourceDataset.DeserializeSapTableResourceDataset(element);
                    case "ServiceNowObject": return ServiceNowObjectDataset.DeserializeServiceNowObjectDataset(element);
                    case "ShopifyObject": return ShopifyObjectDataset.DeserializeShopifyObjectDataset(element);
                    case "SparkObject": return SparkObjectDataset.DeserializeSparkObjectDataset(element);
                    case "SqlServerTable": return SqlServerTableDataset.DeserializeSqlServerTableDataset(element);
                    case "SquareObject": return SquareObjectDataset.DeserializeSquareObjectDataset(element);
                    case "SybaseTable": return SybaseTableDataset.DeserializeSybaseTableDataset(element);
                    case "TeradataTable": return TeradataTableDataset.DeserializeTeradataTableDataset(element);
                    case "VerticaTable": return VerticaTableDataset.DeserializeVerticaTableDataset(element);
                    case "WebTable": return WebTableDataset.DeserializeWebTableDataset(element);
                    case "XeroObject": return XeroObjectDataset.DeserializeXeroObjectDataset(element);
                    case "ZohoObject": return ZohoObjectDataset.DeserializeZohoObjectDataset(element);
                }
            }
            string type = default;
            string description = default;
            object structure = default;
            object schema = default;
            LinkedServiceReference linkedServiceName = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            DatasetFolder folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
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
            return new Dataset(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties);
        }
    }
}
