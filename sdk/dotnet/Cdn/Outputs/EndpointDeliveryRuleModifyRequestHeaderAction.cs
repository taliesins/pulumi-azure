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
    public sealed class EndpointDeliveryRuleModifyRequestHeaderAction
    {
        /// <summary>
        /// Action to be executed on a header value. Valid values are `Append`, `Delete` and `Overwrite`.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// The header name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The value of the header. Only needed when `action` is set to `Append` or `overwrite`.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private EndpointDeliveryRuleModifyRequestHeaderAction(
            string action,

            string name,

            string? value)
        {
            Action = action;
            Name = name;
            Value = value;
        }
    }
}
