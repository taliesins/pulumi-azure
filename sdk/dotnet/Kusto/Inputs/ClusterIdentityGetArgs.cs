// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Kusto.Inputs
{

    public sealed class ClusterIdentityGetArgs : Pulumi.ResourceArgs
    {
        [Input("identityIds")]
        private InputList<string>? _identityIds;

        /// <summary>
        /// The list of user identities associated with the Kusto cluster.
        /// </summary>
        public InputList<string> IdentityIds
        {
            get => _identityIds ?? (_identityIds = new InputList<string>());
            set => _identityIds = value;
        }

        /// <summary>
        /// Specifies the Principal ID of the System Assigned Managed Service Identity that is configured on this Kusto Cluster.
        /// </summary>
        [Input("principalId")]
        public Input<string>? PrincipalId { get; set; }

        /// <summary>
        /// Specifies the Tenant ID of the System Assigned Managed Service Identity that is configured on this Kusto Cluster.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// Specifies the type of Managed Service Identity that is configured on this Kusto Cluster. Possible values are: `SystemAssigned` (where Azure will generate a Service Principal for you).
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ClusterIdentityGetArgs()
        {
        }
    }
}
