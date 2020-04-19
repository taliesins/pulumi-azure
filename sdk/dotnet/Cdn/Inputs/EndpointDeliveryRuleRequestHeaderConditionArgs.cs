// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Cdn.Inputs
{

    public sealed class EndpointDeliveryRuleRequestHeaderConditionArgs : Pulumi.ResourceArgs
    {
        [Input("matchValues", required: true)]
        private InputList<string>? _matchValues;

        /// <summary>
        /// List of header values.
        /// </summary>
        public InputList<string> MatchValues
        {
            get => _matchValues ?? (_matchValues = new InputList<string>());
            set => _matchValues = value;
        }

        /// <summary>
        /// Defaults to `false`.
        /// </summary>
        [Input("negateCondition")]
        public Input<bool>? NegateCondition { get; set; }

        /// <summary>
        /// Valid values are `Any`, `BeginsWith`, `Contains`, `EndsWith`, `Equal`, `GreaterThan`, `GreaterThanOrEqual`, `LessThan` and `LessThanOrEqual`.
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        /// <summary>
        /// Header name.
        /// </summary>
        [Input("selector", required: true)]
        public Input<string> Selector { get; set; } = null!;

        [Input("transforms")]
        private InputList<string>? _transforms;

        /// <summary>
        /// Valid values are `Lowercase` and `Uppercase`.
        /// </summary>
        public InputList<string> Transforms
        {
            get => _transforms ?? (_transforms = new InputList<string>());
            set => _transforms = value;
        }

        public EndpointDeliveryRuleRequestHeaderConditionArgs()
        {
        }
    }
}
