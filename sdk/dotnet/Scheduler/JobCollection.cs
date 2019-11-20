// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Scheduler
{
    /// <summary>
    /// Manages a Scheduler Job Collection.
    /// 
    /// &gt; **NOTE:** Support for Scheduler Job Collections has been deprecated by Microsoft in favour of Logic Apps ([more information can be found at this link](https://docs.microsoft.com/en-us/azure/scheduler/migrate-from-scheduler-to-logic-apps)) - as such we plan to remove support for this resource as a part of version 2.0 of the AzureRM Provider.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/scheduler_job_collection.html.markdown.
    /// </summary>
    public partial class JobCollection : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configures the Job collection quotas as documented in the `quota` block below. 
        /// </summary>
        [Output("quota")]
        public Output<Outputs.JobCollectionQuota?> Quota { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Sets the Job Collection's pricing level's SKU. Possible values include: `Standard`, `Free`, `P10Premium`, `P20Premium`.
        /// </summary>
        [Output("sku")]
        public Output<string> Sku { get; private set; } = null!;

        /// <summary>
        /// Sets Job Collection's state. Possible values include: `Enabled`, `Disabled`, `Suspended`.
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a JobCollection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public JobCollection(string name, JobCollectionArgs args, CustomResourceOptions? options = null)
            : base("azure:scheduler/jobCollection:JobCollection", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private JobCollection(string name, Input<string> id, JobCollectionState? state = null, CustomResourceOptions? options = null)
            : base("azure:scheduler/jobCollection:JobCollection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing JobCollection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static JobCollection Get(string name, Input<string> id, JobCollectionState? state = null, CustomResourceOptions? options = null)
        {
            return new JobCollection(name, id, state, options);
        }
    }

    public sealed class JobCollectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configures the Job collection quotas as documented in the `quota` block below. 
        /// </summary>
        [Input("quota")]
        public Input<Inputs.JobCollectionQuotaArgs>? Quota { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Sets the Job Collection's pricing level's SKU. Possible values include: `Standard`, `Free`, `P10Premium`, `P20Premium`.
        /// </summary>
        [Input("sku", required: true)]
        public Input<string> Sku { get; set; } = null!;

        /// <summary>
        /// Sets Job Collection's state. Possible values include: `Enabled`, `Disabled`, `Suspended`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

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

        public JobCollectionArgs()
        {
        }
    }

    public sealed class JobCollectionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configures the Job collection quotas as documented in the `quota` block below. 
        /// </summary>
        [Input("quota")]
        public Input<Inputs.JobCollectionQuotaGetArgs>? Quota { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Scheduler Job Collection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Sets the Job Collection's pricing level's SKU. Possible values include: `Standard`, `Free`, `P10Premium`, `P20Premium`.
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

        /// <summary>
        /// Sets Job Collection's state. Possible values include: `Enabled`, `Disabled`, `Suspended`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

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

        public JobCollectionState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class JobCollectionQuotaArgs : Pulumi.ResourceArgs
    {
        [Input("maxJobCount")]
        public Input<int>? MaxJobCount { get; set; }

        [Input("maxRecurrenceFrequency", required: true)]
        public Input<string> MaxRecurrenceFrequency { get; set; } = null!;

        [Input("maxRecurrenceInterval")]
        public Input<int>? MaxRecurrenceInterval { get; set; }

        [Input("maxRetryInterval")]
        public Input<int>? MaxRetryInterval { get; set; }

        public JobCollectionQuotaArgs()
        {
        }
    }

    public sealed class JobCollectionQuotaGetArgs : Pulumi.ResourceArgs
    {
        [Input("maxJobCount")]
        public Input<int>? MaxJobCount { get; set; }

        [Input("maxRecurrenceFrequency", required: true)]
        public Input<string> MaxRecurrenceFrequency { get; set; } = null!;

        [Input("maxRecurrenceInterval")]
        public Input<int>? MaxRecurrenceInterval { get; set; }

        [Input("maxRetryInterval")]
        public Input<int>? MaxRetryInterval { get; set; }

        public JobCollectionQuotaGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class JobCollectionQuota
    {
        public readonly int? MaxJobCount;
        public readonly string MaxRecurrenceFrequency;
        public readonly int? MaxRecurrenceInterval;
        public readonly int MaxRetryInterval;

        [OutputConstructor]
        private JobCollectionQuota(
            int? maxJobCount,
            string maxRecurrenceFrequency,
            int? maxRecurrenceInterval,
            int maxRetryInterval)
        {
            MaxJobCount = maxJobCount;
            MaxRecurrenceFrequency = maxRecurrenceFrequency;
            MaxRecurrenceInterval = maxRecurrenceInterval;
            MaxRetryInterval = maxRetryInterval;
        }
    }
    }
}
