// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Specify the write behavior when upserting documents into Azure Search Index. </summary>
    public readonly partial struct AzureSearchIndexWriteBehaviorType : IEquatable<AzureSearchIndexWriteBehaviorType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AzureSearchIndexWriteBehaviorType"/> values are the same. </summary>
        public AzureSearchIndexWriteBehaviorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MergeValue = "Merge";
        private const string UploadValue = "Upload";

        /// <summary> Merge. </summary>
        public static AzureSearchIndexWriteBehaviorType Merge { get; } = new AzureSearchIndexWriteBehaviorType(MergeValue);
        /// <summary> Upload. </summary>
        public static AzureSearchIndexWriteBehaviorType Upload { get; } = new AzureSearchIndexWriteBehaviorType(UploadValue);
        /// <summary> Determines if two <see cref="AzureSearchIndexWriteBehaviorType"/> values are the same. </summary>
        public static bool operator ==(AzureSearchIndexWriteBehaviorType left, AzureSearchIndexWriteBehaviorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureSearchIndexWriteBehaviorType"/> values are not the same. </summary>
        public static bool operator !=(AzureSearchIndexWriteBehaviorType left, AzureSearchIndexWriteBehaviorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureSearchIndexWriteBehaviorType"/>. </summary>
        public static implicit operator AzureSearchIndexWriteBehaviorType(string value) => new AzureSearchIndexWriteBehaviorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureSearchIndexWriteBehaviorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureSearchIndexWriteBehaviorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
