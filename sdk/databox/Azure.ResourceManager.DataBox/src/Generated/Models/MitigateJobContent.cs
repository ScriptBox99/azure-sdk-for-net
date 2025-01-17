// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Mitigate Job captured from request body for Mitigate API. </summary>
    public partial class MitigateJobContent
    {
        /// <summary> Serial number and the customer resolution code corresponding to each serial number. </summary>
        public IDictionary<string, CustomerResolutionCode> SerialNumberCustomerResolutionMap { get; }
    }
}
