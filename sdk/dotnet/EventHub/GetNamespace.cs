// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.EventHub
{
    public static class GetNamespace
    {
        /// <summary>
        /// Use this data source to access information about an existing EventHub Namespace.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetNamespaceResult> InvokeAsync(GetNamespaceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNamespaceResult>("azure:eventhub/getNamespace:getNamespace", args ?? new GetNamespaceArgs(), options.WithVersion());
    }


    public sealed class GetNamespaceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the EventHub Namespace.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the EventHub Namespace exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetNamespaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNamespaceResult
    {
        /// <summary>
        /// Is Auto Inflate enabled for the EventHub Namespace?
        /// </summary>
        public readonly bool AutoInflateEnabled;
        /// <summary>
        /// The Capacity / Throughput Units for a `Standard` SKU namespace.
        /// </summary>
        public readonly int Capacity;
        /// <summary>
        /// The primary connection string for the authorization
        /// rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultPrimaryConnectionString;
        /// <summary>
        /// The alias of the primary connection string for the authorization
        /// rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultPrimaryConnectionStringAlias;
        /// <summary>
        /// The primary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultPrimaryKey;
        /// <summary>
        /// The secondary connection string for the
        /// authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultSecondaryConnectionString;
        /// <summary>
        /// The alias of the secondary connection string for the
        /// authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultSecondaryConnectionStringAlias;
        /// <summary>
        /// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
        /// </summary>
        public readonly string DefaultSecondaryKey;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool KafkaEnabled;
        /// <summary>
        /// The Azure location where the EventHub Namespace exists
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Specifies the maximum number of throughput units when Auto Inflate is Enabled.
        /// </summary>
        public readonly int MaximumThroughputUnits;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// Defines which tier to use.
        /// </summary>
        public readonly string Sku;
        /// <summary>
        /// A mapping of tags to assign to the EventHub Namespace.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetNamespaceResult(
            bool autoInflateEnabled,

            int capacity,

            string defaultPrimaryConnectionString,

            string defaultPrimaryConnectionStringAlias,

            string defaultPrimaryKey,

            string defaultSecondaryConnectionString,

            string defaultSecondaryConnectionStringAlias,

            string defaultSecondaryKey,

            string id,

            bool kafkaEnabled,

            string location,

            int maximumThroughputUnits,

            string name,

            string resourceGroupName,

            string sku,

            ImmutableDictionary<string, string> tags)
        {
            AutoInflateEnabled = autoInflateEnabled;
            Capacity = capacity;
            DefaultPrimaryConnectionString = defaultPrimaryConnectionString;
            DefaultPrimaryConnectionStringAlias = defaultPrimaryConnectionStringAlias;
            DefaultPrimaryKey = defaultPrimaryKey;
            DefaultSecondaryConnectionString = defaultSecondaryConnectionString;
            DefaultSecondaryConnectionStringAlias = defaultSecondaryConnectionStringAlias;
            DefaultSecondaryKey = defaultSecondaryKey;
            Id = id;
            KafkaEnabled = kafkaEnabled;
            Location = location;
            MaximumThroughputUnits = maximumThroughputUnits;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Sku = sku;
            Tags = tags;
        }
    }
}