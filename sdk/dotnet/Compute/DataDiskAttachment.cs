// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute
{
    /// <summary>
    /// Manages attaching a Disk to a Virtual Machine.
    /// 
    /// &gt; **NOTE:** Data Disks can be attached either directly on the `azure.compute.VirtualMachine` resource, or using the `azure.compute.DataDiskAttachment` resource - but the two cannot be used together. If both are used against the same Virtual Machine, spurious changes will occur.
    /// 
    /// &gt; **Please Note:** only Managed Disks are supported via this separate resource, Unmanaged Disks can be attached using the `storage_data_disk` block in the `azure.compute.VirtualMachine` resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/virtual_machine_data_disk_attachment.html.markdown.
    /// </summary>
    public partial class DataDiskAttachment : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
        /// </summary>
        [Output("caching")]
        public Output<string> Caching { get; private set; } = null!;

        /// <summary>
        /// The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("createOption")]
        public Output<string?> CreateOption { get; private set; } = null!;

        /// <summary>
        /// The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Output("lun")]
        public Output<int> Lun { get; private set; } = null!;

        /// <summary>
        /// The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Output("managedDiskId")]
        public Output<string> ManagedDiskId { get; private set; } = null!;

        /// <summary>
        /// The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Output("virtualMachineId")]
        public Output<string> VirtualMachineId { get; private set; } = null!;

        /// <summary>
        /// Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
        /// </summary>
        [Output("writeAcceleratorEnabled")]
        public Output<bool?> WriteAcceleratorEnabled { get; private set; } = null!;


        /// <summary>
        /// Create a DataDiskAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DataDiskAttachment(string name, DataDiskAttachmentArgs args, CustomResourceOptions? options = null)
            : base("azure:compute/dataDiskAttachment:DataDiskAttachment", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private DataDiskAttachment(string name, Input<string> id, DataDiskAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("azure:compute/dataDiskAttachment:DataDiskAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DataDiskAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DataDiskAttachment Get(string name, Input<string> id, DataDiskAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new DataDiskAttachment(name, id, state, options);
        }
    }

    public sealed class DataDiskAttachmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
        /// </summary>
        [Input("caching", required: true)]
        public Input<string> Caching { get; set; } = null!;

        /// <summary>
        /// The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("createOption")]
        public Input<string>? CreateOption { get; set; }

        /// <summary>
        /// The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("lun", required: true)]
        public Input<int> Lun { get; set; } = null!;

        /// <summary>
        /// The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Input("managedDiskId", required: true)]
        public Input<string> ManagedDiskId { get; set; } = null!;

        /// <summary>
        /// The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Input("virtualMachineId", required: true)]
        public Input<string> VirtualMachineId { get; set; } = null!;

        /// <summary>
        /// Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
        /// </summary>
        [Input("writeAcceleratorEnabled")]
        public Input<bool>? WriteAcceleratorEnabled { get; set; }

        public DataDiskAttachmentArgs()
        {
        }
    }

    public sealed class DataDiskAttachmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
        /// </summary>
        [Input("caching")]
        public Input<string>? Caching { get; set; }

        /// <summary>
        /// The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("createOption")]
        public Input<string>? CreateOption { get; set; }

        /// <summary>
        /// The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
        /// </summary>
        [Input("lun")]
        public Input<int>? Lun { get; set; }

        /// <summary>
        /// The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Input("managedDiskId")]
        public Input<string>? ManagedDiskId { get; set; }

        /// <summary>
        /// The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
        /// </summary>
        [Input("virtualMachineId")]
        public Input<string>? VirtualMachineId { get; set; }

        /// <summary>
        /// Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
        /// </summary>
        [Input("writeAcceleratorEnabled")]
        public Input<bool>? WriteAcceleratorEnabled { get; set; }

        public DataDiskAttachmentState()
        {
        }
    }
}
