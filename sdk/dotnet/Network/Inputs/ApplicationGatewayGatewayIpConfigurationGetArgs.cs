// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network.Inputs
{

    public sealed class ApplicationGatewayGatewayIpConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Rewrite Rule Set
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The Name of this Gateway IP Configuration.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The ID of the Subnet which the Application Gateway should be connected to.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public ApplicationGatewayGatewayIpConfigurationGetArgs()
        {
        }
    }
}
