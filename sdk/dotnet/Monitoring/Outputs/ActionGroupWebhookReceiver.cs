// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring.Outputs
{

    [OutputType]
    public sealed class ActionGroupWebhookReceiver
    {
        /// <summary>
        /// The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The URI where webhooks should be sent.
        /// </summary>
        public readonly string ServiceUri;
        /// <summary>
        /// Enables or disables the common alert schema.
        /// </summary>
        public readonly bool? UseCommonAlertSchema;

        [OutputConstructor]
        private ActionGroupWebhookReceiver(
            string name,

            string serviceUri,

            bool? useCommonAlertSchema)
        {
            Name = name;
            ServiceUri = serviceUri;
            UseCommonAlertSchema = useCommonAlertSchema;
        }
    }
}