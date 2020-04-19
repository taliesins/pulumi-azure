// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Cdn.Inputs
{

    public sealed class EndpointGlobalDeliveryRuleCacheKeyQueryStringActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The behavior of the cache key for query strings. Valid values are `Exclude`, `ExcludeAll`, `Include` and `IncludeAll`.
        /// </summary>
        [Input("behavior", required: true)]
        public Input<string> Behavior { get; set; } = null!;

        /// <summary>
        /// Comma separated list of parameter values.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        public EndpointGlobalDeliveryRuleCacheKeyQueryStringActionArgs()
        {
        }
    }
}
