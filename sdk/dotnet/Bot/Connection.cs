// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Bot
{
    /// <summary>
    /// Manages a Bot Connection.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/bot_connection.html.markdown.
    /// </summary>
    public partial class Connection : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the Bot Resource this connection will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Output("botName")]
        public Output<string> BotName { get; private set; } = null!;

        /// <summary>
        /// The Client ID that will be used to authenticate with the service provider.
        /// </summary>
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        /// <summary>
        /// The Client Secret that will be used to authenticate with the service provider.
        /// </summary>
        [Output("clientSecret")]
        public Output<string> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Bot Connection. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A map of additional parameters to apply to the connection.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Bot Connection. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The Scopes at which the connection should be applied.
        /// </summary>
        [Output("scopes")]
        public Output<string?> Scopes { get; private set; } = null!;

        /// <summary>
        /// The name of the service provider that will be associated with this connection. Changing this forces a new resource to be created.
        /// </summary>
        [Output("serviceProviderName")]
        public Output<string> ServiceProviderName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Connection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Connection(string name, ConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure:bot/connection:Connection", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Connection(string name, Input<string> id, ConnectionState? state = null, CustomResourceOptions? options = null)
            : base("azure:bot/connection:Connection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Connection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Connection Get(string name, Input<string> id, ConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new Connection(name, id, state, options);
        }
    }

    public sealed class ConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Bot Resource this connection will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Input("botName", required: true)]
        public Input<string> BotName { get; set; } = null!;

        /// <summary>
        /// The Client ID that will be used to authenticate with the service provider.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The Client Secret that will be used to authenticate with the service provider.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Bot Connection. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of additional parameters to apply to the connection.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Bot Connection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Scopes at which the connection should be applied.
        /// </summary>
        [Input("scopes")]
        public Input<string>? Scopes { get; set; }

        /// <summary>
        /// The name of the service provider that will be associated with this connection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serviceProviderName", required: true)]
        public Input<string> ServiceProviderName { get; set; } = null!;

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

        public ConnectionArgs()
        {
        }
    }

    public sealed class ConnectionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Bot Resource this connection will be associated with. Changing this forces a new resource to be created.
        /// </summary>
        [Input("botName")]
        public Input<string>? BotName { get; set; }

        /// <summary>
        /// The Client ID that will be used to authenticate with the service provider.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The Client Secret that will be used to authenticate with the service provider.
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// The supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Bot Connection. Changing this forces a new resource to be created. Must be globally unique.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of additional parameters to apply to the connection.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Bot Connection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The Scopes at which the connection should be applied.
        /// </summary>
        [Input("scopes")]
        public Input<string>? Scopes { get; set; }

        /// <summary>
        /// The name of the service provider that will be associated with this connection. Changing this forces a new resource to be created.
        /// </summary>
        [Input("serviceProviderName")]
        public Input<string>? ServiceProviderName { get; set; }

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

        public ConnectionState()
        {
        }
    }
}
