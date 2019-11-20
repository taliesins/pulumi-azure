// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Core
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access the configuration of the AzureRM provider.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/client_config.html.markdown.
        /// </summary>
        public static Task<GetClientConfigResult> GetClientConfig(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetClientConfigResult>("azure:core/getClientConfig:getClientConfig", ResourceArgs.Empty, options.WithVersion());
    }

    [OutputType]
    public sealed class GetClientConfigResult
    {
        public readonly string ClientId;
        public readonly string ObjectId;
        public readonly string ServicePrincipalApplicationId;
        public readonly string ServicePrincipalObjectId;
        public readonly string SubscriptionId;
        public readonly string TenantId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetClientConfigResult(
            string clientId,
            string objectId,
            string servicePrincipalApplicationId,
            string servicePrincipalObjectId,
            string subscriptionId,
            string tenantId,
            string id)
        {
            ClientId = clientId;
            ObjectId = objectId;
            ServicePrincipalApplicationId = servicePrincipalApplicationId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            Id = id;
        }
    }
}
