// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Outputs
{

    [OutputType]
    public sealed class ProviderFeaturesVirtualMachine
    {
        public readonly bool DeleteOsDiskOnDeletion;

        [OutputConstructor]
        private ProviderFeaturesVirtualMachine(bool deleteOsDiskOnDeletion)
        {
            DeleteOsDiskOnDeletion = deleteOsDiskOnDeletion;
        }
    }
}
