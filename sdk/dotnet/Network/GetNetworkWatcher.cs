// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Network Watcher.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/network_watcher.html.markdown.
        /// </summary>
        public static Task<GetNetworkWatcherResult> GetNetworkWatcher(GetNetworkWatcherArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkWatcherResult>("azure:network/getNetworkWatcher:getNetworkWatcher", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetNetworkWatcherArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the Name of the Network Watcher.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the Name of the Resource Group within which the Network Watcher exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetNetworkWatcherArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetNetworkWatcherResult
    {
        /// <summary>
        /// The supported Azure location where the resource exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetNetworkWatcherResult(
            string location,
            string name,
            string resourceGroupName,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
            Id = id;
        }
    }
}
