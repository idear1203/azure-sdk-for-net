// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Blob index tag based filtering for blob objects. </summary>
    public partial class TagFilter
    {
        /// <summary> Initializes a new instance of TagFilter. </summary>
        /// <param name="name"> This is the filter tag name, it can have 1 - 128 characters. </param>
        /// <param name="op"> This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported. </param>
        /// <param name="value"> This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters. </param>
        public TagFilter(string name, string op, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (op == null)
            {
                throw new ArgumentNullException(nameof(op));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Op = op;
            Value = value;
        }

        /// <summary> This is the filter tag name, it can have 1 - 128 characters. </summary>
        public string Name { get; set; }
        /// <summary> This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported. </summary>
        public string Op { get; set; }
        /// <summary> This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters. </summary>
        public string Value { get; set; }
    }
}