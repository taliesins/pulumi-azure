// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.StreamAnalytics
{
    /// <summary>
    /// Manages a Stream Analytics Output to a ServiceBus Queue.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_output_servicebus_queue.html.markdown.
    /// </summary>
    public partial class OutputServiceBusQueue : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Stream Output. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Service Bus Queue.
        /// </summary>
        [Output("queueName")]
        public Output<string> QueueName { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `serialization` block as defined below.
        /// </summary>
        [Output("serialization")]
        public Output<Outputs.OutputServiceBusQueueSerialization> Serialization { get; private set; } = null!;

        /// <summary>
        /// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Output("servicebusNamespace")]
        public Output<string> ServicebusNamespace { get; private set; } = null!;

        /// <summary>
        /// The shared access policy key for the specified shared access policy.
        /// </summary>
        [Output("sharedAccessPolicyKey")]
        public Output<string> SharedAccessPolicyKey { get; private set; } = null!;

        /// <summary>
        /// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Output("sharedAccessPolicyName")]
        public Output<string> SharedAccessPolicyName { get; private set; } = null!;

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Output("streamAnalyticsJobName")]
        public Output<string> StreamAnalyticsJobName { get; private set; } = null!;


        /// <summary>
        /// Create a OutputServiceBusQueue resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OutputServiceBusQueue(string name, OutputServiceBusQueueArgs args, CustomResourceOptions? options = null)
            : base("azure:streamanalytics/outputServiceBusQueue:OutputServiceBusQueue", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private OutputServiceBusQueue(string name, Input<string> id, OutputServiceBusQueueState? state = null, CustomResourceOptions? options = null)
            : base("azure:streamanalytics/outputServiceBusQueue:OutputServiceBusQueue", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OutputServiceBusQueue resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OutputServiceBusQueue Get(string name, Input<string> id, OutputServiceBusQueueState? state = null, CustomResourceOptions? options = null)
        {
            return new OutputServiceBusQueue(name, id, state, options);
        }
    }

    public sealed class OutputServiceBusQueueArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Stream Output. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Service Bus Queue.
        /// </summary>
        [Input("queueName", required: true)]
        public Input<string> QueueName { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `serialization` block as defined below.
        /// </summary>
        [Input("serialization", required: true)]
        public Input<Inputs.OutputServiceBusQueueSerializationArgs> Serialization { get; set; } = null!;

        /// <summary>
        /// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Input("servicebusNamespace", required: true)]
        public Input<string> ServicebusNamespace { get; set; } = null!;

        /// <summary>
        /// The shared access policy key for the specified shared access policy.
        /// </summary>
        [Input("sharedAccessPolicyKey", required: true)]
        public Input<string> SharedAccessPolicyKey { get; set; } = null!;

        /// <summary>
        /// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Input("sharedAccessPolicyName", required: true)]
        public Input<string> SharedAccessPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Input("streamAnalyticsJobName", required: true)]
        public Input<string> StreamAnalyticsJobName { get; set; } = null!;

        public OutputServiceBusQueueArgs()
        {
        }
    }

    public sealed class OutputServiceBusQueueState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Stream Output. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Service Bus Queue.
        /// </summary>
        [Input("queueName")]
        public Input<string>? QueueName { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `serialization` block as defined below.
        /// </summary>
        [Input("serialization")]
        public Input<Inputs.OutputServiceBusQueueSerializationGetArgs>? Serialization { get; set; }

        /// <summary>
        /// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Input("servicebusNamespace")]
        public Input<string>? ServicebusNamespace { get; set; }

        /// <summary>
        /// The shared access policy key for the specified shared access policy.
        /// </summary>
        [Input("sharedAccessPolicyKey")]
        public Input<string>? SharedAccessPolicyKey { get; set; }

        /// <summary>
        /// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
        /// </summary>
        [Input("sharedAccessPolicyName")]
        public Input<string>? SharedAccessPolicyName { get; set; }

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Input("streamAnalyticsJobName")]
        public Input<string>? StreamAnalyticsJobName { get; set; }

        public OutputServiceBusQueueState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class OutputServiceBusQueueSerializationArgs : Pulumi.ResourceArgs
    {
        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        [Input("fieldDelimiter")]
        public Input<string>? FieldDelimiter { get; set; }

        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public OutputServiceBusQueueSerializationArgs()
        {
        }
    }

    public sealed class OutputServiceBusQueueSerializationGetArgs : Pulumi.ResourceArgs
    {
        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        [Input("fieldDelimiter")]
        public Input<string>? FieldDelimiter { get; set; }

        [Input("format")]
        public Input<string>? Format { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public OutputServiceBusQueueSerializationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class OutputServiceBusQueueSerialization
    {
        public readonly string? Encoding;
        public readonly string? FieldDelimiter;
        public readonly string? Format;
        public readonly string Type;

        [OutputConstructor]
        private OutputServiceBusQueueSerialization(
            string? encoding,
            string? fieldDelimiter,
            string? format,
            string type)
        {
            Encoding = encoding;
            FieldDelimiter = fieldDelimiter;
            Format = format;
            Type = type;
        }
    }
    }
}
