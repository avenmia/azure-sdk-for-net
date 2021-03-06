// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The endpoint configuration for a pool.
    /// </summary>
    public partial class PoolEndpointConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PoolEndpointConfiguration class.
        /// </summary>
        public PoolEndpointConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolEndpointConfiguration class.
        /// </summary>
        /// <param name="inboundNatPools">A list of inbound NAT pools that can
        /// be used to address specific ports on an individual compute node
        /// externally.</param>
        public PoolEndpointConfiguration(IList<InboundNatPool> inboundNatPools)
        {
            InboundNatPools = inboundNatPools;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of inbound NAT pools that can be used to
        /// address specific ports on an individual compute node externally.
        /// </summary>
        /// <remarks>
        /// The maximum number of inbound NAT pools per Batch pool is 5. If the
        /// maximum number of inbound NAT pools is exceeded the request fails
        /// with HTTP status code 400. This cannot be specified if the
        /// IPAddressProvisioningType is NoPublicIPAddresses.
        /// </remarks>
        [JsonProperty(PropertyName = "inboundNatPools")]
        public IList<InboundNatPool> InboundNatPools { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InboundNatPools == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InboundNatPools");
            }
            if (InboundNatPools != null)
            {
                foreach (var element in InboundNatPools)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
