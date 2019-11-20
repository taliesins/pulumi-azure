// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DevTest
{
    /// <summary>
    /// Manages a Linux Virtual Machine within a Dev Test Lab.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/dev_test_linux_virtual_machine.html.markdown.
    /// </summary>
    public partial class LinuxVirtualMachine : Pulumi.CustomResource
    {
        /// <summary>
        /// Can this Virtual Machine be claimed by users? Defaults to `true`.
        /// </summary>
        [Output("allowClaim")]
        public Output<bool?> AllowClaim { get; private set; } = null!;

        /// <summary>
        /// Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
        /// </summary>
        [Output("disallowPublicIpAddress")]
        public Output<bool?> DisallowPublicIpAddress { get; private set; } = null!;

        /// <summary>
        /// The FQDN of the Virtual Machine.
        /// </summary>
        [Output("fqdn")]
        public Output<string> Fqdn { get; private set; } = null!;

        /// <summary>
        /// A `gallery_image_reference` block as defined below.
        /// </summary>
        [Output("galleryImageReference")]
        public Output<Outputs.LinuxVirtualMachineGalleryImageReference> GalleryImageReference { get; private set; } = null!;

        /// <summary>
        /// One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        [Output("inboundNatRules")]
        public Output<ImmutableArray<Outputs.LinuxVirtualMachineInboundNatRules>> InboundNatRules { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("labName")]
        public Output<string> LabName { get; private set; } = null!;

        /// <summary>
        /// The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("labSubnetName")]
        public Output<string> LabSubnetName { get; private set; } = null!;

        /// <summary>
        /// The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("labVirtualNetworkId")]
        public Output<string> LabVirtualNetworkId { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Any notes about the Virtual Machine.
        /// </summary>
        [Output("notes")]
        public Output<string?> Notes { get; private set; } = null!;

        /// <summary>
        /// The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("size")]
        public Output<string> Size { get; private set; } = null!;

        /// <summary>
        /// The SSH Key associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Output("sshKey")]
        public Output<string?> SshKey { get; private set; } = null!;

        /// <summary>
        /// The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
        /// </summary>
        [Output("storageType")]
        public Output<string> StorageType { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// The unique immutable identifier of the Virtual Machine.
        /// </summary>
        [Output("uniqueIdentifier")]
        public Output<string> UniqueIdentifier { get; private set; } = null!;

        /// <summary>
        /// The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Output("username")]
        public Output<string> Username { get; private set; } = null!;


        /// <summary>
        /// Create a LinuxVirtualMachine resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LinuxVirtualMachine(string name, LinuxVirtualMachineArgs args, CustomResourceOptions? options = null)
            : base("azure:devtest/linuxVirtualMachine:LinuxVirtualMachine", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private LinuxVirtualMachine(string name, Input<string> id, LinuxVirtualMachineState? state = null, CustomResourceOptions? options = null)
            : base("azure:devtest/linuxVirtualMachine:LinuxVirtualMachine", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LinuxVirtualMachine resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LinuxVirtualMachine Get(string name, Input<string> id, LinuxVirtualMachineState? state = null, CustomResourceOptions? options = null)
        {
            return new LinuxVirtualMachine(name, id, state, options);
        }
    }

    public sealed class LinuxVirtualMachineArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Can this Virtual Machine be claimed by users? Defaults to `true`.
        /// </summary>
        [Input("allowClaim")]
        public Input<bool>? AllowClaim { get; set; }

        /// <summary>
        /// Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
        /// </summary>
        [Input("disallowPublicIpAddress")]
        public Input<bool>? DisallowPublicIpAddress { get; set; }

        /// <summary>
        /// A `gallery_image_reference` block as defined below.
        /// </summary>
        [Input("galleryImageReference", required: true)]
        public Input<Inputs.LinuxVirtualMachineGalleryImageReferenceArgs> GalleryImageReference { get; set; } = null!;

        [Input("inboundNatRules")]
        private InputList<Inputs.LinuxVirtualMachineInboundNatRulesArgs>? _inboundNatRules;

        /// <summary>
        /// One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        public InputList<Inputs.LinuxVirtualMachineInboundNatRulesArgs> InboundNatRules
        {
            get => _inboundNatRules ?? (_inboundNatRules = new InputList<Inputs.LinuxVirtualMachineInboundNatRulesArgs>());
            set => _inboundNatRules = value;
        }

        /// <summary>
        /// Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labName", required: true)]
        public Input<string> LabName { get; set; } = null!;

        /// <summary>
        /// The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labSubnetName", required: true)]
        public Input<string> LabSubnetName { get; set; } = null!;

        /// <summary>
        /// The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labVirtualNetworkId", required: true)]
        public Input<string> LabVirtualNetworkId { get; set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Any notes about the Virtual Machine.
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        /// <summary>
        /// The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("size", required: true)]
        public Input<string> Size { get; set; } = null!;

        /// <summary>
        /// The SSH Key associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("sshKey")]
        public Input<string>? SshKey { get; set; }

        /// <summary>
        /// The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
        /// </summary>
        [Input("storageType", required: true)]
        public Input<string> StorageType { get; set; } = null!;

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

        /// <summary>
        /// The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public LinuxVirtualMachineArgs()
        {
        }
    }

    public sealed class LinuxVirtualMachineState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Can this Virtual Machine be claimed by users? Defaults to `true`.
        /// </summary>
        [Input("allowClaim")]
        public Input<bool>? AllowClaim { get; set; }

        /// <summary>
        /// Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
        /// </summary>
        [Input("disallowPublicIpAddress")]
        public Input<bool>? DisallowPublicIpAddress { get; set; }

        /// <summary>
        /// The FQDN of the Virtual Machine.
        /// </summary>
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// A `gallery_image_reference` block as defined below.
        /// </summary>
        [Input("galleryImageReference")]
        public Input<Inputs.LinuxVirtualMachineGalleryImageReferenceGetArgs>? GalleryImageReference { get; set; }

        [Input("inboundNatRules")]
        private InputList<Inputs.LinuxVirtualMachineInboundNatRulesGetArgs>? _inboundNatRules;

        /// <summary>
        /// One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
        /// </summary>
        public InputList<Inputs.LinuxVirtualMachineInboundNatRulesGetArgs> InboundNatRules
        {
            get => _inboundNatRules ?? (_inboundNatRules = new InputList<Inputs.LinuxVirtualMachineInboundNatRulesGetArgs>());
            set => _inboundNatRules = value;
        }

        /// <summary>
        /// Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labName")]
        public Input<string>? LabName { get; set; }

        /// <summary>
        /// The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labSubnetName")]
        public Input<string>? LabSubnetName { get; set; }

        /// <summary>
        /// The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("labVirtualNetworkId")]
        public Input<string>? LabVirtualNetworkId { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Any notes about the Virtual Machine.
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        /// <summary>
        /// The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("size")]
        public Input<string>? Size { get; set; }

        /// <summary>
        /// The SSH Key associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("sshKey")]
        public Input<string>? SshKey { get; set; }

        /// <summary>
        /// The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
        /// </summary>
        [Input("storageType")]
        public Input<string>? StorageType { get; set; }

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

        /// <summary>
        /// The unique immutable identifier of the Virtual Machine.
        /// </summary>
        [Input("uniqueIdentifier")]
        public Input<string>? UniqueIdentifier { get; set; }

        /// <summary>
        /// The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public LinuxVirtualMachineState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class LinuxVirtualMachineGalleryImageReferenceArgs : Pulumi.ResourceArgs
    {
        [Input("offer", required: true)]
        public Input<string> Offer { get; set; } = null!;

        [Input("publisher", required: true)]
        public Input<string> Publisher { get; set; } = null!;

        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public LinuxVirtualMachineGalleryImageReferenceArgs()
        {
        }
    }

    public sealed class LinuxVirtualMachineGalleryImageReferenceGetArgs : Pulumi.ResourceArgs
    {
        [Input("offer", required: true)]
        public Input<string> Offer { get; set; } = null!;

        [Input("publisher", required: true)]
        public Input<string> Publisher { get; set; } = null!;

        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public LinuxVirtualMachineGalleryImageReferenceGetArgs()
        {
        }
    }

    public sealed class LinuxVirtualMachineInboundNatRulesArgs : Pulumi.ResourceArgs
    {
        [Input("backendPort", required: true)]
        public Input<int> BackendPort { get; set; } = null!;

        /// <summary>
        /// The frontend port associated with this Inbound NAT Rule.
        /// </summary>
        [Input("frontendPort")]
        public Input<int>? FrontendPort { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        public LinuxVirtualMachineInboundNatRulesArgs()
        {
        }
    }

    public sealed class LinuxVirtualMachineInboundNatRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("backendPort", required: true)]
        public Input<int> BackendPort { get; set; } = null!;

        /// <summary>
        /// The frontend port associated with this Inbound NAT Rule.
        /// </summary>
        [Input("frontendPort")]
        public Input<int>? FrontendPort { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        public LinuxVirtualMachineInboundNatRulesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class LinuxVirtualMachineGalleryImageReference
    {
        public readonly string Offer;
        public readonly string Publisher;
        public readonly string Sku;
        public readonly string Version;

        [OutputConstructor]
        private LinuxVirtualMachineGalleryImageReference(
            string offer,
            string publisher,
            string sku,
            string version)
        {
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
        }
    }

    [OutputType]
    public sealed class LinuxVirtualMachineInboundNatRules
    {
        public readonly int BackendPort;
        /// <summary>
        /// The frontend port associated with this Inbound NAT Rule.
        /// </summary>
        public readonly int FrontendPort;
        public readonly string Protocol;

        [OutputConstructor]
        private LinuxVirtualMachineInboundNatRules(
            int backendPort,
            int frontendPort,
            string protocol)
        {
            BackendPort = backendPort;
            FrontendPort = frontendPort;
            Protocol = protocol;
        }
    }
    }
}
