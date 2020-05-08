// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class FunctionAppSlotSiteCredentialArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The password associated with the username, which can be used to publish to this App Service.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The username which can be used to publish to this App Service
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public FunctionAppSlotSiteCredentialArgs()
        {
        }
    }
}
