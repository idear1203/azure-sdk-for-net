// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryListResponseConverter))]
    internal partial class LibraryListResponse
    {
        internal static LibraryListResponse DeserializeLibraryListResponse(JsonElement element)
        {
            IReadOnlyList<LibraryResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LibraryResource> array = new List<LibraryResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LibraryResource.DeserializeLibraryResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryListResponse(value, nextLink.Value);
        }

        internal partial class LibraryListResponseConverter : JsonConverter<LibraryListResponse>
        {
            public override void Write(Utf8JsonWriter writer, LibraryListResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryListResponse(document.RootElement);
            }
        }
    }
}
