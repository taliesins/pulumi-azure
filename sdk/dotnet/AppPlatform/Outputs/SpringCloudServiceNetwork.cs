// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppPlatform.Outputs
{

    [OutputType]
    public sealed class SpringCloudServiceNetwork
    {
        /// <summary>
        /// Specifies the Name of the resource group containing network resources of Azure Spring Cloud Apps. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string? AppNetworkResourceGroup;
        /// <summary>
        /// Specifies the ID of the Subnet which should host the Spring Boot Applications deployed in this Spring Cloud Service. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string AppSubnetId;
        /// <summary>
        /// A list of (at least 3) CIDR ranges (at least /16) which are used to host the Spring Cloud infrastructure, which must not overlap with any existing CIDR ranges in the Subnet. Changing this forces a new resource to be created.
        /// </summary>
        public readonly ImmutableArray<string> CidrRanges;
        /// <summary>
        /// Specifies the Name of the resource group containing network resources of Azure Spring Cloud Service Runtime. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string? ServiceRuntimeNetworkResourceGroup;
        /// <summary>
        /// Specifies the ID of the Subnet where the Service Runtime components of the Spring Cloud Service will exist. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string ServiceRuntimeSubnetId;

        [OutputConstructor]
        private SpringCloudServiceNetwork(
            string? appNetworkResourceGroup,

            string appSubnetId,

            ImmutableArray<string> cidrRanges,

            string? serviceRuntimeNetworkResourceGroup,

            string serviceRuntimeSubnetId)
        {
            AppNetworkResourceGroup = appNetworkResourceGroup;
            AppSubnetId = appSubnetId;
            CidrRanges = cidrRanges;
            ServiceRuntimeNetworkResourceGroup = serviceRuntimeNetworkResourceGroup;
            ServiceRuntimeSubnetId = serviceRuntimeSubnetId;
        }
    }
}
