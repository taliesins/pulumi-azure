// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    public static class GetSync
    {
        /// <summary>
        /// Use this data source to access information about an existing Storage Sync.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Azure = Pulumi.Azure;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Azure.Storage.GetSync.InvokeAsync(new Azure.Storage.GetSyncArgs
        ///         {
        ///             Name = "existingStorageSyncName",
        ///             ResourceGroupName = "existingResGroup",
        ///         }));
        ///         this.Id = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSyncResult> InvokeAsync(GetSyncArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSyncResult>("azure:storage/getSync:getSync", args ?? new GetSyncArgs(), options.WithVersion());
    }


    public sealed class GetSyncArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of this Storage Sync.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Storage Sync exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetSyncArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSyncResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Incoming traffic policy.
        /// </summary>
        public readonly string IncomingTrafficPolicy;
        /// <summary>
        /// The Azure Region where the Storage Sync exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A mapping of tags assigned to the Storage Sync.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetSyncResult(
            string id,

            string incomingTrafficPolicy,

            string location,

            string name,

            string resourceGroupName,

            ImmutableDictionary<string, string> tags)
        {
            Id = id;
            IncomingTrafficPolicy = incomingTrafficPolicy;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
        }
    }
}
