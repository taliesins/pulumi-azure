// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute
{
    /// <summary>
    /// Manages a Bastion Host Instance.
    /// 
    /// &gt; **Note:** Bastion Host Instances are a preview feature in Azure, and therefore are only supported in a select number of regions. [Read more](https://docs.microsoft.com/en-us/azure/bastion/bastion-faq).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/bastion_host.html.markdown.
    /// </summary>
    public partial class BastionHost : Pulumi.CustomResource
    {
        /// <summary>
        /// The FQDN for the Azure Bastion Host.
        /// </summary>
        [Output("dnsName")]
        public Output<string> DnsName { get; private set; } = null!;

        /// <summary>
        /// A `ip_configuration` block as defined below.
        /// </summary>
        [Output("ipConfiguration")]
        public Output<Outputs.BastionHostIpConfiguration?> IpConfiguration { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Bastion Host.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a BastionHost resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BastionHost(string name, BastionHostArgs args, CustomResourceOptions? options = null)
            : base("azure:compute/bastionHost:BastionHost", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private BastionHost(string name, Input<string> id, BastionHostState? state = null, CustomResourceOptions? options = null)
            : base("azure:compute/bastionHost:BastionHost", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BastionHost resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BastionHost Get(string name, Input<string> id, BastionHostState? state = null, CustomResourceOptions? options = null)
        {
            return new BastionHost(name, id, state, options);
        }
    }

    public sealed class BastionHostArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `ip_configuration` block as defined below.
        /// </summary>
        [Input("ipConfiguration")]
        public Input<Inputs.BastionHostIpConfigurationArgs>? IpConfiguration { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Bastion Host.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public BastionHostArgs()
        {
        }
    }

    public sealed class BastionHostState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The FQDN for the Azure Bastion Host.
        /// </summary>
        [Input("dnsName")]
        public Input<string>? DnsName { get; set; }

        /// <summary>
        /// A `ip_configuration` block as defined below.
        /// </summary>
        [Input("ipConfiguration")]
        public Input<Inputs.BastionHostIpConfigurationGetArgs>? IpConfiguration { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Bastion Host.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public BastionHostState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class BastionHostIpConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("publicIpAddressId", required: true)]
        public Input<string> PublicIpAddressId { get; set; } = null!;

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public BastionHostIpConfigurationArgs()
        {
        }
    }

    public sealed class BastionHostIpConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("publicIpAddressId", required: true)]
        public Input<string> PublicIpAddressId { get; set; } = null!;

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public BastionHostIpConfigurationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class BastionHostIpConfiguration
    {
        /// <summary>
        /// Specifies the name of the Bastion Host. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string PublicIpAddressId;
        public readonly string SubnetId;

        [OutputConstructor]
        private BastionHostIpConfiguration(
            string name,
            string publicIpAddressId,
            string subnetId)
        {
            Name = name;
            PublicIpAddressId = publicIpAddressId;
            SubnetId = subnetId;
        }
    }
    }
}
