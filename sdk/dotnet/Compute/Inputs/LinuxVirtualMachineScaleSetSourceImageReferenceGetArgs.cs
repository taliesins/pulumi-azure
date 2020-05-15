// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute.Inputs
{

    public sealed class LinuxVirtualMachineScaleSetSourceImageReferenceGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the offer of the image used to create the virtual machines.
        /// </summary>
        [Input("offer", required: true)]
        public Input<string> Offer { get; set; } = null!;

        /// <summary>
        /// Specifies the publisher of the image used to create the virtual machines.
        /// </summary>
        [Input("publisher", required: true)]
        public Input<string> Publisher { get; set; } = null!;

        /// <summary>
        /// Specifies the SKU of the image used to create the virtual machines.
        /// </summary>
        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

        /// <summary>
        /// Specifies the version of the image used to create the virtual machines.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public LinuxVirtualMachineScaleSetSourceImageReferenceGetArgs()
        {
        }
    }
}
