// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    /// <summary>
    /// Manages a Network Watcher Flow Log.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/network_watcher_flow_log.html.markdown.
    /// </summary>
    public partial class NetworkWatcherFlowLog : Pulumi.CustomResource
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// The ID of the Network Security Group for which to enable flow logs for. Changing this forces a new resource to be created.
        /// </summary>
        [Output("networkSecurityGroupId")]
        public Output<string> NetworkSecurityGroupId { get; private set; } = null!;

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Output("networkWatcherName")]
        public Output<string> NetworkWatcherName { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Network Watcher was deployed. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `retention_policy` block as documented below.
        /// </summary>
        [Output("retentionPolicy")]
        public Output<Outputs.NetworkWatcherFlowLogRetentionPolicy> RetentionPolicy { get; private set; } = null!;

        /// <summary>
        /// The ID of the Storage Account where flow logs are stored.
        /// </summary>
        [Output("storageAccountId")]
        public Output<string> StorageAccountId { get; private set; } = null!;

        /// <summary>
        /// A `traffic_analytics` block as documented below.
        /// </summary>
        [Output("trafficAnalytics")]
        public Output<Outputs.NetworkWatcherFlowLogTrafficAnalytics?> TrafficAnalytics { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkWatcherFlowLog resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkWatcherFlowLog(string name, NetworkWatcherFlowLogArgs args, CustomResourceOptions? options = null)
            : base("azure:network/networkWatcherFlowLog:NetworkWatcherFlowLog", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private NetworkWatcherFlowLog(string name, Input<string> id, NetworkWatcherFlowLogState? state = null, CustomResourceOptions? options = null)
            : base("azure:network/networkWatcherFlowLog:NetworkWatcherFlowLog", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NetworkWatcherFlowLog resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkWatcherFlowLog Get(string name, Input<string> id, NetworkWatcherFlowLogState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkWatcherFlowLog(name, id, state, options);
        }
    }

    public sealed class NetworkWatcherFlowLogArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The ID of the Network Security Group for which to enable flow logs for. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkSecurityGroupId", required: true)]
        public Input<string> NetworkSecurityGroupId { get; set; } = null!;

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkWatcherName", required: true)]
        public Input<string> NetworkWatcherName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Network Watcher was deployed. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `retention_policy` block as documented below.
        /// </summary>
        [Input("retentionPolicy", required: true)]
        public Input<Inputs.NetworkWatcherFlowLogRetentionPolicyArgs> RetentionPolicy { get; set; } = null!;

        /// <summary>
        /// The ID of the Storage Account where flow logs are stored.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public Input<string> StorageAccountId { get; set; } = null!;

        /// <summary>
        /// A `traffic_analytics` block as documented below.
        /// </summary>
        [Input("trafficAnalytics")]
        public Input<Inputs.NetworkWatcherFlowLogTrafficAnalyticsArgs>? TrafficAnalytics { get; set; }

        public NetworkWatcherFlowLogArgs()
        {
        }
    }

    public sealed class NetworkWatcherFlowLogState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The ID of the Network Security Group for which to enable flow logs for. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkSecurityGroupId")]
        public Input<string>? NetworkSecurityGroupId { get; set; }

        /// <summary>
        /// The name of the Network Watcher. Changing this forces a new resource to be created.
        /// </summary>
        [Input("networkWatcherName")]
        public Input<string>? NetworkWatcherName { get; set; }

        /// <summary>
        /// The name of the resource group in which the Network Watcher was deployed. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `retention_policy` block as documented below.
        /// </summary>
        [Input("retentionPolicy")]
        public Input<Inputs.NetworkWatcherFlowLogRetentionPolicyGetArgs>? RetentionPolicy { get; set; }

        /// <summary>
        /// The ID of the Storage Account where flow logs are stored.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        /// <summary>
        /// A `traffic_analytics` block as documented below.
        /// </summary>
        [Input("trafficAnalytics")]
        public Input<Inputs.NetworkWatcherFlowLogTrafficAnalyticsGetArgs>? TrafficAnalytics { get; set; }

        public NetworkWatcherFlowLogState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class NetworkWatcherFlowLogRetentionPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of days to retain flow log records.
        /// </summary>
        [Input("days", required: true)]
        public Input<int> Days { get; set; } = null!;

        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public NetworkWatcherFlowLogRetentionPolicyArgs()
        {
        }
    }

    public sealed class NetworkWatcherFlowLogRetentionPolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of days to retain flow log records.
        /// </summary>
        [Input("days", required: true)]
        public Input<int> Days { get; set; } = null!;

        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public NetworkWatcherFlowLogRetentionPolicyGetArgs()
        {
        }
    }

    public sealed class NetworkWatcherFlowLogTrafficAnalyticsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The resource guid of the attached workspace.
        /// </summary>
        [Input("workspaceId", required: true)]
        public Input<string> WorkspaceId { get; set; } = null!;

        /// <summary>
        /// The location of the attached workspace.
        /// </summary>
        [Input("workspaceRegion", required: true)]
        public Input<string> WorkspaceRegion { get; set; } = null!;

        /// <summary>
        /// The resource ID of the attached workspace.
        /// </summary>
        [Input("workspaceResourceId", required: true)]
        public Input<string> WorkspaceResourceId { get; set; } = null!;

        public NetworkWatcherFlowLogTrafficAnalyticsArgs()
        {
        }
    }

    public sealed class NetworkWatcherFlowLogTrafficAnalyticsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The resource guid of the attached workspace.
        /// </summary>
        [Input("workspaceId", required: true)]
        public Input<string> WorkspaceId { get; set; } = null!;

        /// <summary>
        /// The location of the attached workspace.
        /// </summary>
        [Input("workspaceRegion", required: true)]
        public Input<string> WorkspaceRegion { get; set; } = null!;

        /// <summary>
        /// The resource ID of the attached workspace.
        /// </summary>
        [Input("workspaceResourceId", required: true)]
        public Input<string> WorkspaceResourceId { get; set; } = null!;

        public NetworkWatcherFlowLogTrafficAnalyticsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class NetworkWatcherFlowLogRetentionPolicy
    {
        /// <summary>
        /// The number of days to retain flow log records.
        /// </summary>
        public readonly int Days;
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private NetworkWatcherFlowLogRetentionPolicy(
            int days,
            bool enabled)
        {
            Days = days;
            Enabled = enabled;
        }
    }

    [OutputType]
    public sealed class NetworkWatcherFlowLogTrafficAnalytics
    {
        /// <summary>
        /// Boolean flag to enable/disable traffic analytics.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// The resource guid of the attached workspace.
        /// </summary>
        public readonly string WorkspaceId;
        /// <summary>
        /// The location of the attached workspace.
        /// </summary>
        public readonly string WorkspaceRegion;
        /// <summary>
        /// The resource ID of the attached workspace.
        /// </summary>
        public readonly string WorkspaceResourceId;

        [OutputConstructor]
        private NetworkWatcherFlowLogTrafficAnalytics(
            bool enabled,
            string workspaceId,
            string workspaceRegion,
            string workspaceResourceId)
        {
            Enabled = enabled;
            WorkspaceId = workspaceId;
            WorkspaceRegion = workspaceRegion;
            WorkspaceResourceId = workspaceResourceId;
        }
    }
    }
}
