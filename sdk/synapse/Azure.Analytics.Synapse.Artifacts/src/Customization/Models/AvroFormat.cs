// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Analytics.Synapse.Artifacts.Models
{

    [CodeGenModel(Formats = new[] { "json" }, Usage = new[]{"input", "output", "model"})]
    public partial class AvroFormat : DatasetStorageFormat
    {
    }
}
