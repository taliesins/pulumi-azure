// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Dns
{
    /// <summary>
    /// Enables you to manage DNS SRV Records within Azure DNS.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/dns_srv_record.html.markdown.
    /// </summary>
    public partial class SrvRecord : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the DNS SRV Record.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of values that make up the SRV record. Each `record` block supports fields documented below.
        /// </summary>
        [Output("records")]
        public Output<ImmutableArray<Outputs.SrvRecordRecords>> Records { get; private set; } = null!;

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// The Time To Live (TTL) of the DNS record in seconds.
        /// </summary>
        [Output("ttl")]
        public Output<int> Ttl { get; private set; } = null!;

        /// <summary>
        /// Specifies the DNS Zone where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("zoneName")]
        public Output<string> ZoneName { get; private set; } = null!;


        /// <summary>
        /// Create a SrvRecord resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SrvRecord(string name, SrvRecordArgs args, CustomResourceOptions? options = null)
            : base("azure:dns/srvRecord:SrvRecord", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private SrvRecord(string name, Input<string> id, SrvRecordState? state = null, CustomResourceOptions? options = null)
            : base("azure:dns/srvRecord:SrvRecord", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SrvRecord resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SrvRecord Get(string name, Input<string> id, SrvRecordState? state = null, CustomResourceOptions? options = null)
        {
            return new SrvRecord(name, id, state, options);
        }
    }

    public sealed class SrvRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the DNS SRV Record.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("records", required: true)]
        private InputList<Inputs.SrvRecordRecordsArgs>? _records;

        /// <summary>
        /// A list of values that make up the SRV record. Each `record` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.SrvRecordRecordsArgs> Records
        {
            get => _records ?? (_records = new InputList<Inputs.SrvRecordRecordsArgs>());
            set => _records = value;
        }

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
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

        /// <summary>
        /// The Time To Live (TTL) of the DNS record in seconds.
        /// </summary>
        [Input("ttl", required: true)]
        public Input<int> Ttl { get; set; } = null!;

        /// <summary>
        /// Specifies the DNS Zone where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("zoneName", required: true)]
        public Input<string> ZoneName { get; set; } = null!;

        public SrvRecordArgs()
        {
        }
    }

    public sealed class SrvRecordState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the DNS SRV Record.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("records")]
        private InputList<Inputs.SrvRecordRecordsGetArgs>? _records;

        /// <summary>
        /// A list of values that make up the SRV record. Each `record` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.SrvRecordRecordsGetArgs> Records
        {
            get => _records ?? (_records = new InputList<Inputs.SrvRecordRecordsGetArgs>());
            set => _records = value;
        }

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
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

        /// <summary>
        /// The Time To Live (TTL) of the DNS record in seconds.
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        /// <summary>
        /// Specifies the DNS Zone where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("zoneName")]
        public Input<string>? ZoneName { get; set; }

        public SrvRecordState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class SrvRecordRecordsArgs : Pulumi.ResourceArgs
    {
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public SrvRecordRecordsArgs()
        {
        }
    }

    public sealed class SrvRecordRecordsGetArgs : Pulumi.ResourceArgs
    {
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public SrvRecordRecordsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class SrvRecordRecords
    {
        public readonly int Port;
        public readonly int Priority;
        public readonly string Target;
        public readonly int Weight;

        [OutputConstructor]
        private SrvRecordRecords(
            int port,
            int priority,
            string target,
            int weight)
        {
            Port = port;
            Priority = priority;
            Target = target;
            Weight = weight;
        }
    }
    }
}
