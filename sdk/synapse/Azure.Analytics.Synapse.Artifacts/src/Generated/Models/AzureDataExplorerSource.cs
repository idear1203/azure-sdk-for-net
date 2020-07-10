// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure Data Explorer (Kusto) source. </summary>
    public partial class AzureDataExplorerSource : CopySource
    {
        /// <summary> Initializes a new instance of AzureDataExplorerSource. </summary>
        /// <param name="query"> Database query. Should be a Kusto Query Language (KQL) query. Type: string (or Expression with resultType string). </param>
        public AzureDataExplorerSource(object query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            Query = query;
            Type = "AzureDataExplorerSource";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="query"> Database query. Should be a Kusto Query Language (KQL) query. Type: string (or Expression with resultType string). </param>
        /// <param name="noTruncation"> The name of the Boolean option that controls whether truncation is applied to result-sets that go beyond a certain row-count limit. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).. </param>
        internal AzureDataExplorerSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object query, object noTruncation, object queryTimeout) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            Query = query;
            NoTruncation = noTruncation;
            QueryTimeout = queryTimeout;
            Type = type ?? "AzureDataExplorerSource";
        }

        /// <summary> Database query. Should be a Kusto Query Language (KQL) query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> The name of the Boolean option that controls whether truncation is applied to result-sets that go beyond a certain row-count limit. </summary>
        public object NoTruncation { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).. </summary>
        public object QueryTimeout { get; set; }
    }
}
