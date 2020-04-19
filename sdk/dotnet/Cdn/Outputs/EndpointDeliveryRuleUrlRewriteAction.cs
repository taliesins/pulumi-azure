// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Cdn.Outputs
{

    [OutputType]
    public sealed class EndpointDeliveryRuleUrlRewriteAction
    {
        /// <summary>
        /// This value must start with a `/` and can't be longer than 260 characters.
        /// </summary>
        public readonly string Destination;
        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        public readonly bool? PreserveUnmatchedPath;
        /// <summary>
        /// This value must start with a `/` and can't be longer than 260 characters.
        /// </summary>
        public readonly string SourcePattern;

        [OutputConstructor]
        private EndpointDeliveryRuleUrlRewriteAction(
            string destination,

            bool? preserveUnmatchedPath,

            string sourcePattern)
        {
            Destination = destination;
            PreserveUnmatchedPath = preserveUnmatchedPath;
            SourcePattern = sourcePattern;
        }
    }
}
