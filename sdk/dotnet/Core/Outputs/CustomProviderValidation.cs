// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Core.Outputs
{

    [OutputType]
    public sealed class CustomProviderValidation
    {
        /// <summary>
        /// The endpoint where the validation specification is located.
        /// </summary>
        public readonly string Specification;

        [OutputConstructor]
        private CustomProviderValidation(string specification)
        {
            Specification = specification;
        }
    }
}
