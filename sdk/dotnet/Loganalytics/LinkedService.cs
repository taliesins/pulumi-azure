// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.LogAnalytics
{
    /// <summary>
    /// Links a Log Analytics (formally Operational Insights) Workspace to another resource. The (currently) only linkable service is an Azure Automation Account.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/log_analytics_linked_service.html.markdown.
    /// </summary>
    public partial class LinkedService : Pulumi.CustomResource
    {
        /// <summary>
        /// Name of the type of linkedServices resource to connect to the Log Analytics Workspace specified in `workspace_name`. Currently it defaults to and only supports `automation` as a value. Changing this forces a new resource to be created.
        /// </summary>
        [Output("linkedServiceName")]
        public Output<string?> LinkedServiceName { get; private set; } = null!;

        /// <summary>
        /// A `linked_service_properties` block as defined below.
        /// </summary>
        [Output("linkedServiceProperties")]
        public Output<Outputs.LinkedServiceLinkedServiceProperties> LinkedServiceProperties { get; private set; } = null!;

        /// <summary>
        /// The automatically generated name of the Linked Service. This cannot be specified. The format is always `&lt;workspace_name&gt;/&lt;linked_service_name&gt;` e.g. `workspace1/Automation`
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Log Analytics Linked Service is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        [Output("resourceId")]
        public Output<string> ResourceId { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// Name of the Log Analytics Workspace that will contain the linkedServices resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("workspaceName")]
        public Output<string> WorkspaceName { get; private set; } = null!;


        /// <summary>
        /// Create a LinkedService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LinkedService(string name, LinkedServiceArgs args, CustomResourceOptions? options = null)
            : base("azure:loganalytics/linkedService:LinkedService", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private LinkedService(string name, Input<string> id, LinkedServiceState? state = null, CustomResourceOptions? options = null)
            : base("azure:loganalytics/linkedService:LinkedService", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LinkedService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LinkedService Get(string name, Input<string> id, LinkedServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new LinkedService(name, id, state, options);
        }
    }

    public sealed class LinkedServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the type of linkedServices resource to connect to the Log Analytics Workspace specified in `workspace_name`. Currently it defaults to and only supports `automation` as a value. Changing this forces a new resource to be created.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<string>? LinkedServiceName { get; set; }

        /// <summary>
        /// A `linked_service_properties` block as defined below.
        /// </summary>
        [Input("linkedServiceProperties")]
        public Input<Inputs.LinkedServiceLinkedServicePropertiesArgs>? LinkedServiceProperties { get; set; }

        /// <summary>
        /// The name of the resource group in which the Log Analytics Linked Service is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

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
        /// Name of the Log Analytics Workspace that will contain the linkedServices resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public LinkedServiceArgs()
        {
        }
    }

    public sealed class LinkedServiceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the type of linkedServices resource to connect to the Log Analytics Workspace specified in `workspace_name`. Currently it defaults to and only supports `automation` as a value. Changing this forces a new resource to be created.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<string>? LinkedServiceName { get; set; }

        /// <summary>
        /// A `linked_service_properties` block as defined below.
        /// </summary>
        [Input("linkedServiceProperties")]
        public Input<Inputs.LinkedServiceLinkedServicePropertiesGetArgs>? LinkedServiceProperties { get; set; }

        /// <summary>
        /// The automatically generated name of the Linked Service. This cannot be specified. The format is always `&lt;workspace_name&gt;/&lt;linked_service_name&gt;` e.g. `workspace1/Automation`
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Log Analytics Linked Service is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

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
        /// Name of the Log Analytics Workspace that will contain the linkedServices resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("workspaceName")]
        public Input<string>? WorkspaceName { get; set; }

        public LinkedServiceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class LinkedServiceLinkedServicePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        public LinkedServiceLinkedServicePropertiesArgs()
        {
        }
    }

    public sealed class LinkedServiceLinkedServicePropertiesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        public LinkedServiceLinkedServicePropertiesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class LinkedServiceLinkedServiceProperties
    {
        /// <summary>
        /// The resource id of the resource that will be linked to the workspace. This field has been deprecated in favour of the top-level `resource_id` field and will be removed in v2.0 of the AzureRM Provider.
        /// </summary>
        public readonly string ResourceId;

        [OutputConstructor]
        private LinkedServiceLinkedServiceProperties(string resourceId)
        {
            ResourceId = resourceId;
        }
    }
    }
}
