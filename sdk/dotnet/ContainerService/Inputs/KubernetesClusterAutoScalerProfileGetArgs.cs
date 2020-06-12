// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService.Inputs
{

    public sealed class KubernetesClusterAutoScalerProfileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Detect similar node groups and balance the number of nodes between them. Defaults to `false`.
        /// </summary>
        [Input("balanceSimilarNodeGroups")]
        public Input<bool>? BalanceSimilarNodeGroups { get; set; }

        /// <summary>
        /// Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node. Defaults to `600`.
        /// </summary>
        [Input("maxGracefulTerminationSec")]
        public Input<string>? MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// How long after the scale up of AKS nodes the scale down evaluation resumes. Defaults to `10m`.
        /// </summary>
        [Input("scaleDownDelayAfterAdd")]
        public Input<string>? ScaleDownDelayAfterAdd { get; set; }

        /// <summary>
        /// How long after node deletion that scale down evaluation resumes. Defaults to the value used for `scan_interval`.
        /// </summary>
        [Input("scaleDownDelayAfterDelete")]
        public Input<string>? ScaleDownDelayAfterDelete { get; set; }

        /// <summary>
        /// How long after scale down failure that scale down evaluation resumes. Defaults to `3m`.
        /// </summary>
        [Input("scaleDownDelayAfterFailure")]
        public Input<string>? ScaleDownDelayAfterFailure { get; set; }

        /// <summary>
        /// How long a node should be unneeded before it is eligible for scale down. Defaults to `10m`.
        /// </summary>
        [Input("scaleDownUnneeded")]
        public Input<string>? ScaleDownUnneeded { get; set; }

        /// <summary>
        /// How long an unready node should be unneeded before it is eligible for scale down. Defaults to `20m`.
        /// </summary>
        [Input("scaleDownUnready")]
        public Input<string>? ScaleDownUnready { get; set; }

        /// <summary>
        /// Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down. Defaults to `0.5`.
        /// </summary>
        [Input("scaleDownUtilizationThreshold")]
        public Input<string>? ScaleDownUtilizationThreshold { get; set; }

        /// <summary>
        /// How often the AKS Cluster should be re-evaluated for scale up/down. Defaults to `10s`.
        /// </summary>
        [Input("scanInterval")]
        public Input<string>? ScanInterval { get; set; }

        public KubernetesClusterAutoScalerProfileGetArgs()
        {
        }
    }
}
