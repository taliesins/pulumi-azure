// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ServiceBus
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing ServiceBus Namespace Authorization Rule.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/servicebus_namespace_authorization_rule.html.markdown.
        /// </summary>
        public static Task<GetNamespaceAuthorizationRuleResult> GetNamespaceAuthorizationRule(GetNamespaceAuthorizationRuleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNamespaceAuthorizationRuleResult>("azure:servicebus/getNamespaceAuthorizationRule:getNamespaceAuthorizationRule", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetNamespaceAuthorizationRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the ServiceBus Namespace Authorization Rule.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the ServiceBus Namespace.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Resource Group where the ServiceBus Namespace exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetNamespaceAuthorizationRuleArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetNamespaceAuthorizationRuleResult
    {
        public readonly string Name;
        public readonly string NamespaceName;
        /// <summary>
        /// The primary connection string for the authorization rule.
        /// </summary>
        public readonly string PrimaryConnectionString;
        /// <summary>
        /// The primary access key for the authorization rule.
        /// </summary>
        public readonly string PrimaryKey;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The secondary connection string for the authorization rule.
        /// </summary>
        public readonly string SecondaryConnectionString;
        /// <summary>
        /// The secondary access key for the authorization rule.
        /// </summary>
        public readonly string SecondaryKey;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetNamespaceAuthorizationRuleResult(
            string name,
            string namespaceName,
            string primaryConnectionString,
            string primaryKey,
            string resourceGroupName,
            string secondaryConnectionString,
            string secondaryKey,
            string id)
        {
            Name = name;
            NamespaceName = namespaceName;
            PrimaryConnectionString = primaryConnectionString;
            PrimaryKey = primaryKey;
            ResourceGroupName = resourceGroupName;
            SecondaryConnectionString = secondaryConnectionString;
            SecondaryKey = secondaryKey;
            Id = id;
        }
    }
}
