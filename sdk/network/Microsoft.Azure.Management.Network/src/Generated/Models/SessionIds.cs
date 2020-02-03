// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of session IDs.
    /// </summary>
    public partial class SessionIds
    {
        /// <summary>
        /// Initializes a new instance of the SessionIds class.
        /// </summary>
        public SessionIds()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionIds class.
        /// </summary>
        /// <param name="sessionIdsProperty">List of session IDs.</param>
        public SessionIds(IList<string> sessionIdsProperty = default(IList<string>))
        {
            SessionIdsProperty = sessionIdsProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of session IDs.
        /// </summary>
        [JsonProperty(PropertyName = "sessionIds")]
        public IList<string> SessionIdsProperty { get; set; }

    }
}