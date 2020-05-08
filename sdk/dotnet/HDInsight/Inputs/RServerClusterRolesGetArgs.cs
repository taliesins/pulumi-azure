// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.HDInsight.Inputs
{

    public sealed class RServerClusterRolesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `edge_node` block as defined above.
        /// </summary>
        [Input("edgeNode", required: true)]
        public Input<Inputs.RServerClusterRolesEdgeNodeGetArgs> EdgeNode { get; set; } = null!;

        /// <summary>
        /// A `head_node` block as defined above.
        /// </summary>
        [Input("headNode", required: true)]
        public Input<Inputs.RServerClusterRolesHeadNodeGetArgs> HeadNode { get; set; } = null!;

        /// <summary>
        /// A `worker_node` block as defined below.
        /// </summary>
        [Input("workerNode", required: true)]
        public Input<Inputs.RServerClusterRolesWorkerNodeGetArgs> WorkerNode { get; set; } = null!;

        /// <summary>
        /// A `zookeeper_node` block as defined below.
        /// </summary>
        [Input("zookeeperNode", required: true)]
        public Input<Inputs.RServerClusterRolesZookeeperNodeGetArgs> ZookeeperNode { get; set; } = null!;

        public RServerClusterRolesGetArgs()
        {
        }
    }
}