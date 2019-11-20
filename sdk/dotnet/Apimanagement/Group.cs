// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    /// <summary>
    /// Manages an API Management Group.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/api_management_group.html.markdown.
    /// </summary>
    public partial class Group : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("apiManagementName")]
        public Output<string> ApiManagementName { get; private set; } = null!;

        /// <summary>
        /// The description of this API Management Group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of this API Management Group.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The identifier of the external Group. For example, an Azure Active Directory group `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`.
        /// </summary>
        [Output("externalId")]
        public Output<string?> ExternalId { get; private set; } = null!;

        /// <summary>
        /// The name of the API Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The type of this API Management Group. Possible values are `custom` and `external`. Default is `custom`.
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Group resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Group(string name, GroupArgs args, CustomResourceOptions? options = null)
            : base("azure:apimanagement/group:Group", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Group(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
            : base("azure:apimanagement/group:Group", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Group resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Group Get(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
        {
            return new Group(name, id, state, options);
        }
    }

    public sealed class GroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The description of this API Management Group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of this API Management Group.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// The identifier of the external Group. For example, an Azure Active Directory group `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`.
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// The name of the API Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The type of this API Management Group. Possible values are `custom` and `external`. Default is `custom`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GroupArgs()
        {
        }
    }

    public sealed class GroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName")]
        public Input<string>? ApiManagementName { get; set; }

        /// <summary>
        /// The description of this API Management Group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of this API Management Group.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The identifier of the external Group. For example, an Azure Active Directory group `aad://&lt;tenant&gt;.onmicrosoft.com/groups/&lt;group object id&gt;`.
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// The name of the API Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Group should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The type of this API Management Group. Possible values are `custom` and `external`. Default is `custom`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public GroupState()
        {
        }
    }
}
