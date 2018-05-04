// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for SignalR service create/update operation.
    ///
    /// Keep the same schema as AzSignalR.Models.SignalRResource
    /// </summary>
    public partial class SignalRCreateParameters : SignalRUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the SignalRCreateParameters class.
        /// </summary>
        public SignalRCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRCreateParameters class.
        /// </summary>
        /// <param name="location">Azure GEO region: e.g. West US | East US |
        /// North Central US | South Central US | West Europe | North Europe |
        /// East Asia | Southeast Asia | etc.
        /// The geo region of a resource never changes after it is
        /// created.</param>
        /// <param name="tags">A list of key value pairs that describe the
        /// resource.</param>
        /// <param name="sku">The billing information of the resource.(e.g.
        /// basic vs. standard)</param>
        /// <param name="properties">Settings used to provision or configure
        /// the resource</param>
        public SignalRCreateParameters(string location, IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceSku sku = default(ResourceSku), SignalRCreateOrUpdateProperties properties = default(SignalRCreateOrUpdateProperties))
            : base(tags, sku, properties)
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure GEO region: e.g. West US | East US | North
        /// Central US | South Central US | West Europe | North Europe | East
        /// Asia | Southeast Asia | etc.
        /// The geo region of a resource never changes after it is created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
