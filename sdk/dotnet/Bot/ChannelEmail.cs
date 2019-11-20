// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Bot
{
    /// <summary>
    /// Manages a Email integration for a Bot Channel
    /// 
    /// &gt; **Note** A bot can only have a single Email Channel associated with it.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/bot_channel_email.html.markdown.
    /// </summary>
    public partial class ChannelEmail : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Output("botName")]
        public Output<string> BotName { get; private set; } = null!;

        /// <summary>
        /// The email address that the Bot will authenticate with.
        /// </summary>
        [Output("emailAddress")]
        public Output<string> EmailAddress { get; private set; } = null!;

        /// <summary>
        /// The email password that the the Bot will authenticate with.
        /// </summary>
        [Output("emailPassword")]
        public Output<string> EmailPassword { get; private set; } = null!;

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;


        /// <summary>
        /// Create a ChannelEmail resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ChannelEmail(string name, ChannelEmailArgs args, CustomResourceOptions? options = null)
            : base("azure:bot/channelEmail:ChannelEmail", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ChannelEmail(string name, Input<string> id, ChannelEmailState? state = null, CustomResourceOptions? options = null)
            : base("azure:bot/channelEmail:ChannelEmail", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ChannelEmail resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ChannelEmail Get(string name, Input<string> id, ChannelEmailState? state = null, CustomResourceOptions? options = null)
        {
            return new ChannelEmail(name, id, state, options);
        }
    }

    public sealed class ChannelEmailArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Input("botName", required: true)]
        public Input<string> BotName { get; set; } = null!;

        /// <summary>
        /// The email address that the Bot will authenticate with.
        /// </summary>
        [Input("emailAddress", required: true)]
        public Input<string> EmailAddress { get; set; } = null!;

        /// <summary>
        /// The email password that the the Bot will authenticate with.
        /// </summary>
        [Input("emailPassword", required: true)]
        public Input<string> EmailPassword { get; set; } = null!;

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public ChannelEmailArgs()
        {
        }
    }

    public sealed class ChannelEmailState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Input("botName")]
        public Input<string>? BotName { get; set; }

        /// <summary>
        /// The email address that the Bot will authenticate with.
        /// </summary>
        [Input("emailAddress")]
        public Input<string>? EmailAddress { get; set; }

        /// <summary>
        /// The email password that the the Bot will authenticate with.
        /// </summary>
        [Input("emailPassword")]
        public Input<string>? EmailPassword { get; set; }

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        public ChannelEmailState()
        {
        }
    }
}
