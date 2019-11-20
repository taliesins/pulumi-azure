// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.MySql
{
    /// <summary>
    /// Manages a MySQL Virtual Network Rule.
    /// 
    /// &gt; **NOTE:** MySQL Virtual Network Rules [can only be used with SKU Tiers of `GeneralPurpose` or `MemoryOptimized`](https://docs.microsoft.com/en-us/azure/mysql/concepts-data-access-and-security-vnet)
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mysql_virtual_network_rule.html.markdown.
    /// </summary>
    public partial class VirtualNetworkRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the MySQL Virtual Network Rule. Cannot be empty and must only contain alphanumeric characters and hyphens. Cannot start with a number, and cannot start or end with a hyphen. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group where the MySQL server resides. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The name of the SQL Server to which this MySQL virtual network rule will be applied to. Changing this forces a new resource to be created.
        /// </summary>
        [Output("serverName")]
        public Output<string> ServerName { get; private set; } = null!;

        /// <summary>
        /// The ID of the subnet that the MySQL server will be connected to.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualNetworkRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualNetworkRule(string name, VirtualNetworkRuleArgs args, CustomResourceOptions? options = null)
            : base("azure:mysql/virtualNetworkRule:VirtualNetworkRule", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private VirtualNetworkRule(string name, Input<string> id, VirtualNetworkRuleState? state = null, CustomResourceOptions? options = null)
            : base("azure:mysql/virtualNetworkRule:VirtualNetworkRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualNetworkRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualNetworkRule Get(string name, Input<string> id, VirtualNetworkRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new VirtualNetworkRule(name, id, state, options);
        }
    }

    public sealed class VirtualNetworkRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the MySQL Virtual Network Rule. Cannot be empty and must only contain alphanumeric characters and hyphens. Cannot start with a number, and cannot start or end with a hyphen. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group where the MySQL server resides. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the SQL Server to which this MySQL virtual network rule will be applied to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        /// <summary>
        /// The ID of the subnet that the MySQL server will be connected to.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public VirtualNetworkRuleArgs()
        {
        }
    }

    public sealed class VirtualNetworkRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the MySQL Virtual Network Rule. Cannot be empty and must only contain alphanumeric characters and hyphens. Cannot start with a number, and cannot start or end with a hyphen. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group where the MySQL server resides. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The name of the SQL Server to which this MySQL virtual network rule will be applied to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// The ID of the subnet that the MySQL server will be connected to.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public VirtualNetworkRuleState()
        {
        }
    }
}
