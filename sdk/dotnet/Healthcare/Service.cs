// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Healthcare
{
    /// <summary>
    /// Manages a Healthcare Service.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/healthcare_service.html.markdown.
    /// </summary>
    public partial class Service : Pulumi.CustomResource
    {
        [Output("accessPolicyObjectIds")]
        public Output<ImmutableArray<string>> AccessPolicyObjectIds { get; private set; } = null!;

        /// <summary>
        /// An `authentication_configuration` block as defined below.
        /// </summary>
        [Output("authenticationConfiguration")]
        public Output<Outputs.ServiceAuthenticationConfiguration> AuthenticationConfiguration { get; private set; } = null!;

        /// <summary>
        /// A `cors_configuration` block as defined below.
        /// </summary>
        [Output("corsConfiguration")]
        public Output<Outputs.ServiceCorsConfiguration> CorsConfiguration { get; private set; } = null!;

        /// <summary>
        /// The provisioned throughput for the backing database. Range of `400`-`1000`. Defaults to `400`.
        /// </summary>
        [Output("cosmosdbThroughput")]
        public Output<int?> CosmosdbThroughput { get; private set; } = null!;

        /// <summary>
        /// The type of the service. Values at time of publication are: `fhir`, `fhir-Stu3` and `fhir-R4`. Default value is `fhir`.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure Region where the Service should be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the service instance. Used for service endpoint, must be unique within the audience.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which to create the Service.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("azure:healthcare/service:Service", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("azure:healthcare/service:Service", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        [Input("accessPolicyObjectIds", required: true)]
        private InputList<string>? _accessPolicyObjectIds;
        public InputList<string> AccessPolicyObjectIds
        {
            get => _accessPolicyObjectIds ?? (_accessPolicyObjectIds = new InputList<string>());
            set => _accessPolicyObjectIds = value;
        }

        /// <summary>
        /// An `authentication_configuration` block as defined below.
        /// </summary>
        [Input("authenticationConfiguration")]
        public Input<Inputs.ServiceAuthenticationConfigurationArgs>? AuthenticationConfiguration { get; set; }

        /// <summary>
        /// A `cors_configuration` block as defined below.
        /// </summary>
        [Input("corsConfiguration")]
        public Input<Inputs.ServiceCorsConfigurationArgs>? CorsConfiguration { get; set; }

        /// <summary>
        /// The provisioned throughput for the backing database. Range of `400`-`1000`. Defaults to `400`.
        /// </summary>
        [Input("cosmosdbThroughput")]
        public Input<int>? CosmosdbThroughput { get; set; }

        /// <summary>
        /// The type of the service. Values at time of publication are: `fhir`, `fhir-Stu3` and `fhir-R4`. Default value is `fhir`.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Specifies the supported Azure Region where the Service should be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the service instance. Used for service endpoint, must be unique within the audience.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which to create the Service.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ServiceArgs()
        {
        }
    }

    public sealed class ServiceState : Pulumi.ResourceArgs
    {
        [Input("accessPolicyObjectIds")]
        private InputList<string>? _accessPolicyObjectIds;
        public InputList<string> AccessPolicyObjectIds
        {
            get => _accessPolicyObjectIds ?? (_accessPolicyObjectIds = new InputList<string>());
            set => _accessPolicyObjectIds = value;
        }

        /// <summary>
        /// An `authentication_configuration` block as defined below.
        /// </summary>
        [Input("authenticationConfiguration")]
        public Input<Inputs.ServiceAuthenticationConfigurationGetArgs>? AuthenticationConfiguration { get; set; }

        /// <summary>
        /// A `cors_configuration` block as defined below.
        /// </summary>
        [Input("corsConfiguration")]
        public Input<Inputs.ServiceCorsConfigurationGetArgs>? CorsConfiguration { get; set; }

        /// <summary>
        /// The provisioned throughput for the backing database. Range of `400`-`1000`. Defaults to `400`.
        /// </summary>
        [Input("cosmosdbThroughput")]
        public Input<int>? CosmosdbThroughput { get; set; }

        /// <summary>
        /// The type of the service. Values at time of publication are: `fhir`, `fhir-Stu3` and `fhir-R4`. Default value is `fhir`.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Specifies the supported Azure Region where the Service should be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the service instance. Used for service endpoint, must be unique within the audience.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which to create the Service.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ServiceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ServiceAuthenticationConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com
        /// </summary>
        [Input("audience")]
        public Input<string>? Audience { get; set; }

        /// <summary>
        /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service. The default authority is the Directory defined in the authentication scheme in use when running this provider.
        /// Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.
        /// </summary>
        [Input("authority")]
        public Input<string>? Authority { get; set; }

        /// <summary>
        /// Enables the 'SMART on FHIR' option for mobile and web implementations.
        /// </summary>
        [Input("smartProxyEnabled")]
        public Input<bool>? SmartProxyEnabled { get; set; }

        public ServiceAuthenticationConfigurationArgs()
        {
        }
    }

    public sealed class ServiceAuthenticationConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com
        /// </summary>
        [Input("audience")]
        public Input<string>? Audience { get; set; }

        /// <summary>
        /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service. The default authority is the Directory defined in the authentication scheme in use when running this provider.
        /// Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.
        /// </summary>
        [Input("authority")]
        public Input<string>? Authority { get; set; }

        /// <summary>
        /// Enables the 'SMART on FHIR' option for mobile and web implementations.
        /// </summary>
        [Input("smartProxyEnabled")]
        public Input<bool>? SmartProxyEnabled { get; set; }

        public ServiceAuthenticationConfigurationGetArgs()
        {
        }
    }

    public sealed class ServiceCorsConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("allowCredentials")]
        public Input<bool>? AllowCredentials { get; set; }

        [Input("allowedHeaders")]
        private InputList<string>? _allowedHeaders;
        public InputList<string> AllowedHeaders
        {
            get => _allowedHeaders ?? (_allowedHeaders = new InputList<string>());
            set => _allowedHeaders = value;
        }

        [Input("allowedMethods")]
        private InputList<string>? _allowedMethods;
        public InputList<string> AllowedMethods
        {
            get => _allowedMethods ?? (_allowedMethods = new InputList<string>());
            set => _allowedMethods = value;
        }

        [Input("allowedOrigins")]
        private InputList<string>? _allowedOrigins;
        public InputList<string> AllowedOrigins
        {
            get => _allowedOrigins ?? (_allowedOrigins = new InputList<string>());
            set => _allowedOrigins = value;
        }

        [Input("maxAgeInSeconds")]
        public Input<int>? MaxAgeInSeconds { get; set; }

        public ServiceCorsConfigurationArgs()
        {
        }
    }

    public sealed class ServiceCorsConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("allowCredentials")]
        public Input<bool>? AllowCredentials { get; set; }

        [Input("allowedHeaders")]
        private InputList<string>? _allowedHeaders;
        public InputList<string> AllowedHeaders
        {
            get => _allowedHeaders ?? (_allowedHeaders = new InputList<string>());
            set => _allowedHeaders = value;
        }

        [Input("allowedMethods")]
        private InputList<string>? _allowedMethods;
        public InputList<string> AllowedMethods
        {
            get => _allowedMethods ?? (_allowedMethods = new InputList<string>());
            set => _allowedMethods = value;
        }

        [Input("allowedOrigins")]
        private InputList<string>? _allowedOrigins;
        public InputList<string> AllowedOrigins
        {
            get => _allowedOrigins ?? (_allowedOrigins = new InputList<string>());
            set => _allowedOrigins = value;
        }

        [Input("maxAgeInSeconds")]
        public Input<int>? MaxAgeInSeconds { get; set; }

        public ServiceCorsConfigurationGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ServiceAuthenticationConfiguration
    {
        /// <summary>
        /// The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com
        /// </summary>
        public readonly string? Audience;
        /// <summary>
        /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service. The default authority is the Directory defined in the authentication scheme in use when running this provider.
        /// Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.
        /// </summary>
        public readonly string? Authority;
        /// <summary>
        /// Enables the 'SMART on FHIR' option for mobile and web implementations.
        /// </summary>
        public readonly bool? SmartProxyEnabled;

        [OutputConstructor]
        private ServiceAuthenticationConfiguration(
            string? audience,
            string? authority,
            bool? smartProxyEnabled)
        {
            Audience = audience;
            Authority = authority;
            SmartProxyEnabled = smartProxyEnabled;
        }
    }

    [OutputType]
    public sealed class ServiceCorsConfiguration
    {
        public readonly bool? AllowCredentials;
        public readonly ImmutableArray<string> AllowedHeaders;
        public readonly ImmutableArray<string> AllowedMethods;
        public readonly ImmutableArray<string> AllowedOrigins;
        public readonly int? MaxAgeInSeconds;

        [OutputConstructor]
        private ServiceCorsConfiguration(
            bool? allowCredentials,
            ImmutableArray<string> allowedHeaders,
            ImmutableArray<string> allowedMethods,
            ImmutableArray<string> allowedOrigins,
            int? maxAgeInSeconds)
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
