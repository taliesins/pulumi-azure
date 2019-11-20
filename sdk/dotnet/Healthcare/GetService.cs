// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Healthcare
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Healthcare Service
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/healthcare_service.html.markdown.
        /// </summary>
        public static Task<GetServiceResult> GetService(GetServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceResult>("azure:healthcare/getService:getService", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetServiceArgs : Pulumi.ResourceArgs
    {
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Healthcare Service.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Healthcare Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public GetServiceArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetServiceResult
    {
        public readonly ImmutableArray<string> AccessPolicyObjectIds;
        /// <summary>
        /// An `authentication_configuration` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceAuthenticationConfigurationsResult> AuthenticationConfigurations;
        /// <summary>
        /// A `cors_configuration` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetServiceCorsConfigurationsResult> CorsConfigurations;
        public readonly int CosmosdbThroughput;
        /// <summary>
        /// The type of the service.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The Azure Region where the Service is located.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetServiceResult(
            ImmutableArray<string> accessPolicyObjectIds,
            ImmutableArray<Outputs.GetServiceAuthenticationConfigurationsResult> authenticationConfigurations,
            ImmutableArray<Outputs.GetServiceCorsConfigurationsResult> corsConfigurations,
            int cosmosdbThroughput,
            string kind,
            string location,
            string name,
            string resourceGroupName,
            ImmutableDictionary<string, object> tags,
            string id)
        {
            AccessPolicyObjectIds = accessPolicyObjectIds;
            AuthenticationConfigurations = authenticationConfigurations;
            CorsConfigurations = corsConfigurations;
            CosmosdbThroughput = cosmosdbThroughput;
            Kind = kind;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetServiceAuthenticationConfigurationsResult
    {
        /// <summary>
        /// The intended audience to receive authentication tokens for the service. 
        /// </summary>
        public readonly string Audience;
        /// <summary>
        /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service. 
        /// </summary>
        public readonly string Authority;
        /// <summary>
        /// Is the 'SMART on FHIR' option for mobile and web implementations enbled?
        /// </summary>
        public readonly bool SmartProxyEnabled;

        [OutputConstructor]
        private GetServiceAuthenticationConfigurationsResult(
            string audience,
            string authority,
            bool smartProxyEnabled)
        {
            Audience = audience;
            Authority = authority;
            SmartProxyEnabled = smartProxyEnabled;
        }
    }

    [OutputType]
    public sealed class GetServiceCorsConfigurationsResult
    {
        /// <summary>
        /// Are credentials are allowed via CORS?
        /// </summary>
        public readonly bool AllowCredentials;
        /// <summary>
        /// The set of headers to be allowed via CORS.
        /// </summary>
        public readonly ImmutableArray<string> AllowedHeaders;
        /// <summary>
        /// The methods to be allowed via CORS.
        /// </summary>
        public readonly ImmutableArray<string> AllowedMethods;
        /// <summary>
        /// The set of origins to be allowed via CORS.
        /// </summary>
        public readonly ImmutableArray<string> AllowedOrigins;
        /// <summary>
        /// The max age to be allowed via CORS.
        /// </summary>
        public readonly int MaxAgeInSeconds;

        [OutputConstructor]
        private GetServiceCorsConfigurationsResult(
            bool allowCredentials,
            ImmutableArray<string> allowedHeaders,
            ImmutableArray<string> allowedMethods,
            ImmutableArray<string> allowedOrigins,
            int maxAgeInSeconds)
        {
            AllowCredentials = allowCredentials;
            AllowedHeaders = allowedHeaders;
            AllowedMethods = allowedMethods;
            AllowedOrigins = allowedOrigins;
            MaxAgeInSeconds = maxAgeInSeconds;
        }
    }
    }
}
