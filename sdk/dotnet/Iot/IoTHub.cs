// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Iot
{
    /// <summary>
    /// Manages an IotHub
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/iothub.html.markdown.
    /// </summary>
    public partial class IoTHub : Pulumi.CustomResource
    {
        /// <summary>
        /// An `endpoint` block as defined below.
        /// </summary>
        [Output("endpoints")]
        public Output<ImmutableArray<Outputs.IoTHubEndpoints>> Endpoints { get; private set; } = null!;

        /// <summary>
        /// The EventHub compatible endpoint for events data
        /// </summary>
        [Output("eventHubEventsEndpoint")]
        public Output<string> EventHubEventsEndpoint { get; private set; } = null!;

        /// <summary>
        /// The EventHub compatible path for events data
        /// </summary>
        [Output("eventHubEventsPath")]
        public Output<string> EventHubEventsPath { get; private set; } = null!;

        /// <summary>
        /// The EventHub compatible endpoint for operational data
        /// </summary>
        [Output("eventHubOperationsEndpoint")]
        public Output<string> EventHubOperationsEndpoint { get; private set; } = null!;

        /// <summary>
        /// The EventHub compatible path for operational data
        /// </summary>
        [Output("eventHubOperationsPath")]
        public Output<string> EventHubOperationsPath { get; private set; } = null!;

        /// <summary>
        /// A `fallback_route` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
        /// </summary>
        [Output("fallbackRoute")]
        public Output<Outputs.IoTHubFallbackRoute> FallbackRoute { get; private set; } = null!;

        /// <summary>
        /// A `file_upload` block as defined below.
        /// </summary>
        [Output("fileUpload")]
        public Output<Outputs.IoTHubFileUpload?> FileUpload { get; private set; } = null!;

        /// <summary>
        /// The hostname of the IotHub Resource.
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// One or more `ip_filter_rule` blocks as defined below.
        /// </summary>
        [Output("ipFilterRules")]
        public Output<ImmutableArray<Outputs.IoTHubIpFilterRules>> IpFilterRules { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `route` block as defined below.
        /// </summary>
        [Output("routes")]
        public Output<ImmutableArray<Outputs.IoTHubRoutes>> Routes { get; private set; } = null!;

        /// <summary>
        /// One or more `shared_access_policy` blocks as defined below.
        /// </summary>
        [Output("sharedAccessPolicies")]
        public Output<ImmutableArray<Outputs.IoTHubSharedAccessPolicies>> SharedAccessPolicies { get; private set; } = null!;

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.IoTHubSku> Sku { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IoTHub resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IoTHub(string name, IoTHubArgs args, CustomResourceOptions? options = null)
            : base("azure:iot/ioTHub:IoTHub", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private IoTHub(string name, Input<string> id, IoTHubState? state = null, CustomResourceOptions? options = null)
            : base("azure:iot/ioTHub:IoTHub", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IoTHub resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IoTHub Get(string name, Input<string> id, IoTHubState? state = null, CustomResourceOptions? options = null)
        {
            return new IoTHub(name, id, state, options);
        }
    }

    public sealed class IoTHubArgs : Pulumi.ResourceArgs
    {
        [Input("endpoints")]
        private InputList<Inputs.IoTHubEndpointsArgs>? _endpoints;

        /// <summary>
        /// An `endpoint` block as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubEndpointsArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.IoTHubEndpointsArgs>());
            set => _endpoints = value;
        }

        /// <summary>
        /// A `fallback_route` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
        /// </summary>
        [Input("fallbackRoute")]
        public Input<Inputs.IoTHubFallbackRouteArgs>? FallbackRoute { get; set; }

        /// <summary>
        /// A `file_upload` block as defined below.
        /// </summary>
        [Input("fileUpload")]
        public Input<Inputs.IoTHubFileUploadArgs>? FileUpload { get; set; }

        [Input("ipFilterRules")]
        private InputList<Inputs.IoTHubIpFilterRulesArgs>? _ipFilterRules;

        /// <summary>
        /// One or more `ip_filter_rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubIpFilterRulesArgs> IpFilterRules
        {
            get => _ipFilterRules ?? (_ipFilterRules = new InputList<Inputs.IoTHubIpFilterRulesArgs>());
            set => _ipFilterRules = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("routes")]
        private InputList<Inputs.IoTHubRoutesArgs>? _routes;

        /// <summary>
        /// A `route` block as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubRoutesArgs> Routes
        {
            get => _routes ?? (_routes = new InputList<Inputs.IoTHubRoutesArgs>());
            set => _routes = value;
        }

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.IoTHubSkuArgs> Sku { get; set; } = null!;

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

        public IoTHubArgs()
        {
        }
    }

    public sealed class IoTHubState : Pulumi.ResourceArgs
    {
        [Input("endpoints")]
        private InputList<Inputs.IoTHubEndpointsGetArgs>? _endpoints;

        /// <summary>
        /// An `endpoint` block as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubEndpointsGetArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.IoTHubEndpointsGetArgs>());
            set => _endpoints = value;
        }

        /// <summary>
        /// The EventHub compatible endpoint for events data
        /// </summary>
        [Input("eventHubEventsEndpoint")]
        public Input<string>? EventHubEventsEndpoint { get; set; }

        /// <summary>
        /// The EventHub compatible path for events data
        /// </summary>
        [Input("eventHubEventsPath")]
        public Input<string>? EventHubEventsPath { get; set; }

        /// <summary>
        /// The EventHub compatible endpoint for operational data
        /// </summary>
        [Input("eventHubOperationsEndpoint")]
        public Input<string>? EventHubOperationsEndpoint { get; set; }

        /// <summary>
        /// The EventHub compatible path for operational data
        /// </summary>
        [Input("eventHubOperationsPath")]
        public Input<string>? EventHubOperationsPath { get; set; }

        /// <summary>
        /// A `fallback_route` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
        /// </summary>
        [Input("fallbackRoute")]
        public Input<Inputs.IoTHubFallbackRouteGetArgs>? FallbackRoute { get; set; }

        /// <summary>
        /// A `file_upload` block as defined below.
        /// </summary>
        [Input("fileUpload")]
        public Input<Inputs.IoTHubFileUploadGetArgs>? FileUpload { get; set; }

        /// <summary>
        /// The hostname of the IotHub Resource.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("ipFilterRules")]
        private InputList<Inputs.IoTHubIpFilterRulesGetArgs>? _ipFilterRules;

        /// <summary>
        /// One or more `ip_filter_rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubIpFilterRulesGetArgs> IpFilterRules
        {
            get => _ipFilterRules ?? (_ipFilterRules = new InputList<Inputs.IoTHubIpFilterRulesGetArgs>());
            set => _ipFilterRules = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("routes")]
        private InputList<Inputs.IoTHubRoutesGetArgs>? _routes;

        /// <summary>
        /// A `route` block as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubRoutesGetArgs> Routes
        {
            get => _routes ?? (_routes = new InputList<Inputs.IoTHubRoutesGetArgs>());
            set => _routes = value;
        }

        [Input("sharedAccessPolicies")]
        private InputList<Inputs.IoTHubSharedAccessPoliciesGetArgs>? _sharedAccessPolicies;

        /// <summary>
        /// One or more `shared_access_policy` blocks as defined below.
        /// </summary>
        public InputList<Inputs.IoTHubSharedAccessPoliciesGetArgs> SharedAccessPolicies
        {
            get => _sharedAccessPolicies ?? (_sharedAccessPolicies = new InputList<Inputs.IoTHubSharedAccessPoliciesGetArgs>());
            set => _sharedAccessPolicies = value;
        }

        /// <summary>
        /// A `sku` block as defined below.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.IoTHubSkuGetArgs>? Sku { get; set; }

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

        [Input("type")]
        public Input<string>? Type { get; set; }

        public IoTHubState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class IoTHubEndpointsArgs : Pulumi.ResourceArgs
    {
        [Input("batchFrequencyInSeconds")]
        public Input<int>? BatchFrequencyInSeconds { get; set; }

        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        [Input("fileNameFormat")]
        public Input<string>? FileNameFormat { get; set; }

        [Input("maxChunkSizeInBytes")]
        public Input<int>? MaxChunkSizeInBytes { get; set; }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IoTHubEndpointsArgs()
        {
        }
    }

    public sealed class IoTHubEndpointsGetArgs : Pulumi.ResourceArgs
    {
        [Input("batchFrequencyInSeconds")]
        public Input<int>? BatchFrequencyInSeconds { get; set; }

        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        [Input("encoding")]
        public Input<string>? Encoding { get; set; }

        [Input("fileNameFormat")]
        public Input<string>? FileNameFormat { get; set; }

        [Input("maxChunkSizeInBytes")]
        public Input<int>? MaxChunkSizeInBytes { get; set; }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IoTHubEndpointsGetArgs()
        {
        }
    }

    public sealed class IoTHubFallbackRouteArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("endpointNames")]
        private InputList<string>? _endpointNames;
        public InputList<string> EndpointNames
        {
            get => _endpointNames ?? (_endpointNames = new InputList<string>());
            set => _endpointNames = value;
        }

        [Input("source")]
        public Input<string>? Source { get; set; }

        public IoTHubFallbackRouteArgs()
        {
        }
    }

    public sealed class IoTHubFallbackRouteGetArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("endpointNames")]
        private InputList<string>? _endpointNames;
        public InputList<string> EndpointNames
        {
            get => _endpointNames ?? (_endpointNames = new InputList<string>());
            set => _endpointNames = value;
        }

        [Input("source")]
        public Input<string>? Source { get; set; }

        public IoTHubFallbackRouteGetArgs()
        {
        }
    }

    public sealed class IoTHubFileUploadArgs : Pulumi.ResourceArgs
    {
        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        [Input("containerName", required: true)]
        public Input<string> ContainerName { get; set; } = null!;

        [Input("defaultTtl")]
        public Input<string>? DefaultTtl { get; set; }

        [Input("lockDuration")]
        public Input<string>? LockDuration { get; set; }

        [Input("maxDeliveryCount")]
        public Input<int>? MaxDeliveryCount { get; set; }

        [Input("notifications")]
        public Input<bool>? Notifications { get; set; }

        [Input("sasTtl")]
        public Input<string>? SasTtl { get; set; }

        public IoTHubFileUploadArgs()
        {
        }
    }

    public sealed class IoTHubFileUploadGetArgs : Pulumi.ResourceArgs
    {
        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        [Input("containerName", required: true)]
        public Input<string> ContainerName { get; set; } = null!;

        [Input("defaultTtl")]
        public Input<string>? DefaultTtl { get; set; }

        [Input("lockDuration")]
        public Input<string>? LockDuration { get; set; }

        [Input("maxDeliveryCount")]
        public Input<int>? MaxDeliveryCount { get; set; }

        [Input("notifications")]
        public Input<bool>? Notifications { get; set; }

        [Input("sasTtl")]
        public Input<string>? SasTtl { get; set; }

        public IoTHubFileUploadGetArgs()
        {
        }
    }

    public sealed class IoTHubIpFilterRulesArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("ipMask", required: true)]
        public Input<string> IpMask { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public IoTHubIpFilterRulesArgs()
        {
        }
    }

    public sealed class IoTHubIpFilterRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("ipMask", required: true)]
        public Input<string> IpMask { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public IoTHubIpFilterRulesGetArgs()
        {
        }
    }

    public sealed class IoTHubRoutesArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("endpointNames", required: true)]
        private InputList<string>? _endpointNames;
        public InputList<string> EndpointNames
        {
            get => _endpointNames ?? (_endpointNames = new InputList<string>());
            set => _endpointNames = value;
        }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public IoTHubRoutesArgs()
        {
        }
    }

    public sealed class IoTHubRoutesGetArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<string>? Condition { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("endpointNames", required: true)]
        private InputList<string>? _endpointNames;
        public InputList<string> EndpointNames
        {
            get => _endpointNames ?? (_endpointNames = new InputList<string>());
            set => _endpointNames = value;
        }

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public IoTHubRoutesGetArgs()
        {
        }
    }

    public sealed class IoTHubSharedAccessPoliciesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the shared access policy.
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        /// <summary>
        /// The permissions assigned to the shared access policy.
        /// </summary>
        [Input("permissions")]
        public Input<string>? Permissions { get; set; }

        /// <summary>
        /// The primary key.
        /// </summary>
        [Input("primaryKey")]
        public Input<string>? PrimaryKey { get; set; }

        /// <summary>
        /// The secondary key.
        /// </summary>
        [Input("secondaryKey")]
        public Input<string>? SecondaryKey { get; set; }

        public IoTHubSharedAccessPoliciesGetArgs()
        {
        }
    }

    public sealed class IoTHubSkuArgs : Pulumi.ResourceArgs
    {
        [Input("capacity", required: true)]
        public Input<int> Capacity { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tier", required: true)]
        public Input<string> Tier { get; set; } = null!;

        public IoTHubSkuArgs()
        {
        }
    }

    public sealed class IoTHubSkuGetArgs : Pulumi.ResourceArgs
    {
        [Input("capacity", required: true)]
        public Input<int> Capacity { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tier", required: true)]
        public Input<string> Tier { get; set; } = null!;

        public IoTHubSkuGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class IoTHubEndpoints
    {
        public readonly int? BatchFrequencyInSeconds;
        public readonly string ConnectionString;
        public readonly string? ContainerName;
        public readonly string? Encoding;
        public readonly string? FileNameFormat;
        public readonly int? MaxChunkSizeInBytes;
        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string Type;

        [OutputConstructor]
        private IoTHubEndpoints(
            int? batchFrequencyInSeconds,
            string connectionString,
            string? containerName,
            string? encoding,
            string? fileNameFormat,
            int? maxChunkSizeInBytes,
            string name,
            string type)
        {
            BatchFrequencyInSeconds = batchFrequencyInSeconds;
            ConnectionString = connectionString;
            ContainerName = containerName;
            Encoding = encoding;
            FileNameFormat = fileNameFormat;
            MaxChunkSizeInBytes = maxChunkSizeInBytes;
            Name = name;
            Type = type;
        }
    }

    [OutputType]
    public sealed class IoTHubFallbackRoute
    {
        public readonly string? Condition;
        public readonly bool Enabled;
        public readonly ImmutableArray<string> EndpointNames;
        public readonly string? Source;

        [OutputConstructor]
        private IoTHubFallbackRoute(
            string? condition,
            bool enabled,
            ImmutableArray<string> endpointNames,
            string? source)
        {
            Condition = condition;
            Enabled = enabled;
            EndpointNames = endpointNames;
            Source = source;
        }
    }

    [OutputType]
    public sealed class IoTHubFileUpload
    {
        public readonly string ConnectionString;
        public readonly string ContainerName;
        public readonly string DefaultTtl;
        public readonly string LockDuration;
        public readonly int? MaxDeliveryCount;
        public readonly bool? Notifications;
        public readonly string SasTtl;

        [OutputConstructor]
        private IoTHubFileUpload(
            string connectionString,
            string containerName,
            string defaultTtl,
            string lockDuration,
            int? maxDeliveryCount,
            bool? notifications,
            string sasTtl)
        {
            ConnectionString = connectionString;
            ContainerName = containerName;
            DefaultTtl = defaultTtl;
            LockDuration = lockDuration;
            MaxDeliveryCount = maxDeliveryCount;
            Notifications = notifications;
            SasTtl = sasTtl;
        }
    }

    [OutputType]
    public sealed class IoTHubIpFilterRules
    {
        public readonly string Action;
        public readonly string IpMask;
        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private IoTHubIpFilterRules(
            string action,
            string ipMask,
            string name)
        {
            Action = action;
            IpMask = ipMask;
            Name = name;
        }
    }

    [OutputType]
    public sealed class IoTHubRoutes
    {
        public readonly string? Condition;
        public readonly bool Enabled;
        public readonly ImmutableArray<string> EndpointNames;
        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string Source;

        [OutputConstructor]
        private IoTHubRoutes(
            string? condition,
            bool enabled,
            ImmutableArray<string> endpointNames,
            string name,
            string source)
        {
            Condition = condition;
            Enabled = enabled;
            EndpointNames = endpointNames;
            Name = name;
            Source = source;
        }
    }

    [OutputType]
    public sealed class IoTHubSharedAccessPolicies
    {
        /// <summary>
        /// The name of the shared access policy.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// The permissions assigned to the shared access policy.
        /// </summary>
        public readonly string Permissions;
        /// <summary>
        /// The primary key.
        /// </summary>
        public readonly string PrimaryKey;
        /// <summary>
        /// The secondary key.
        /// </summary>
        public readonly string SecondaryKey;

        [OutputConstructor]
        private IoTHubSharedAccessPolicies(
            string keyName,
            string permissions,
            string primaryKey,
            string secondaryKey)
        {
            KeyName = keyName;
            Permissions = permissions;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }
    }

    [OutputType]
    public sealed class IoTHubSku
    {
        public readonly int Capacity;
        /// <summary>
        /// Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string Tier;

        [OutputConstructor]
        private IoTHubSku(
            int capacity,
            string name,
            string tier)
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }
    }
    }
}
