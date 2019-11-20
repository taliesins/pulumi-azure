// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.NotificationHub
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Notification Hub within a Notification Hub Namespace.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/notification_hub.html.markdown.
        /// </summary>
        public static Task<GetHubResult> GetHub(GetHubArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetHubResult>("azure:notificationhub/getHub:getHub", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetHubArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the Name of the Notification Hub.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the Name of the Notification Hub Namespace which contains the Notification Hub.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// Specifies the Name of the Resource Group within which the Notification Hub exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetHubArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetHubResult
    {
        /// <summary>
        /// A `apns_credential` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHubApnsCredentialsResult> ApnsCredentials;
        /// <summary>
        /// A `gcm_credential` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHubGcmCredentialsResult> GcmCredentials;
        /// <summary>
        /// The Azure Region in which this Notification Hub exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string NamespaceName;
        public readonly string ResourceGroupName;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetHubResult(
            ImmutableArray<Outputs.GetHubApnsCredentialsResult> apnsCredentials,
            ImmutableArray<Outputs.GetHubGcmCredentialsResult> gcmCredentials,
            string location,
            string name,
            string namespaceName,
            string resourceGroupName,
            string id)
        {
            ApnsCredentials = apnsCredentials;
            GcmCredentials = gcmCredentials;
            Location = location;
            Name = name;
            NamespaceName = namespaceName;
            ResourceGroupName = resourceGroupName;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetHubApnsCredentialsResult
    {
        /// <summary>
        /// The Application Mode which defines which server the APNS Messages should be sent to. Possible values are `Production` and `Sandbox`.
        /// </summary>
        public readonly string ApplicationMode;
        /// <summary>
        /// The Bundle ID of the iOS/macOS application to send push notifications for, such as `com.org.example`.
        /// </summary>
        public readonly string BundleId;
        /// <summary>
        /// The Apple Push Notifications Service (APNS) Key.
        /// </summary>
        public readonly string KeyId;
        /// <summary>
        /// The ID of the team the Token.
        /// </summary>
        public readonly string TeamId;
        /// <summary>
        /// The Push Token associated with the Apple Developer Account.
        /// </summary>
        public readonly string Token;

        [OutputConstructor]
        private GetHubApnsCredentialsResult(
            string applicationMode,
            string bundleId,
            string keyId,
            string teamId,
            string token)
        {
            ApplicationMode = applicationMode;
            BundleId = bundleId;
            KeyId = keyId;
            TeamId = teamId;
            Token = token;
        }
    }

    [OutputType]
    public sealed class GetHubGcmCredentialsResult
    {
        /// <summary>
        /// The API Key associated with the Google Cloud Messaging service.
        /// </summary>
        public readonly string ApiKey;

        [OutputConstructor]
        private GetHubGcmCredentialsResult(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
    }
}
