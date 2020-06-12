// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.KeyVault.Outputs
{

    [OutputType]
    public sealed class GetCertificateCertificatePolicyIssuerParameterResult
    {
        /// <summary>
        /// Specifies the name of the Key Vault Secret.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetCertificateCertificatePolicyIssuerParameterResult(string name)
        {
            Name = name;
        }
    }
}
