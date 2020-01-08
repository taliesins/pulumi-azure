// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.SignalR
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Azure SignalR service.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/signalr_service.html.markdown.
        /// </summary>
        public static Task<GetServiceResult> GetService(GetServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceResult>("azure:signalr/getService:getService", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the SignalR service.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group the SignalR service is located in.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetServiceArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetServiceResult
    {
        /// <summary>
        /// The FQDN of the SignalR service.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// The publicly accessible IP of the SignalR service.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// Specifies the supported Azure location where the SignalR service exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        /// <summary>
        /// The primary access key of the SignalR service.
        /// </summary>
        public readonly string PrimaryAccessKey;
        /// <summary>
        /// The primary connection string of the SignalR service.
        /// </summary>
        public readonly string PrimaryConnectionString;
        /// <summary>
        /// The publicly accessible port of the SignalR service which is designed for browser/client use.
        /// </summary>
        public readonly int PublicPort;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The secondary access key of the SignalR service.
        /// </summary>
        public readonly string SecondaryAccessKey;
        /// <summary>
        /// The secondary connection string of the SignalR service.
        /// </summary>
        public readonly string SecondaryConnectionString;
        /// <summary>
        /// The publicly accessible port of the SignalR service which is designed for customer server side use.
        /// </summary>
        public readonly int ServerPort;
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetServiceResult(
            string hostname,
            string ipAddress,
            string location,
            string name,
            string primaryAccessKey,
            string primaryConnectionString,
            int publicPort,
            string resourceGroupName,
            string secondaryAccessKey,
            string secondaryConnectionString,
            int serverPort,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            Hostname = hostname;
            IpAddress = ipAddress;
            Location = location;
            Name = name;
            PrimaryAccessKey = primaryAccessKey;
            PrimaryConnectionString = primaryConnectionString;
            PublicPort = publicPort;
            ResourceGroupName = resourceGroupName;
            SecondaryAccessKey = secondaryAccessKey;
            SecondaryConnectionString = secondaryConnectionString;
            ServerPort = serverPort;
            Tags = tags;
            Id = id;
        }
    }
}
