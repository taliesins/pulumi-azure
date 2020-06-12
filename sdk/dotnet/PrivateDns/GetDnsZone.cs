// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.PrivateDns
{
    public static class GetDnsZone
    {
        /// <summary>
        /// Use this data source to access information about an existing Private DNS Zone.
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
        ///         var example = Output.Create(Azure.PrivateDns.GetDnsZone.InvokeAsync(new Azure.PrivateDns.GetDnsZoneArgs
        ///         {
        ///             Name = "contoso.internal",
        ///             ResourceGroupName = "contoso-dns",
        ///         }));
        ///         this.PrivateDnsZoneId = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("privateDnsZoneId")]
        ///     public Output&lt;string&gt; PrivateDnsZoneId { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDnsZoneResult> InvokeAsync(GetDnsZoneArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDnsZoneResult>("azure:privatedns/getDnsZone:getDnsZone", args ?? new GetDnsZoneArgs(), options.WithVersion());
    }


    public sealed class GetDnsZoneArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Private DNS Zone.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the Private DNS Zone exists.
        /// If the Name of the Resource Group is not provided, the first Private DNS Zone from the list of Private
        /// DNS Zones in your subscription that matches `name` will be returned.
        /// </summary>
        [Input("resourceGroupName")]
        public string? ResourceGroupName { get; set; }

        public GetDnsZoneArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDnsZoneResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Maximum number of recordsets that can be created in this Private Zone.
        /// </summary>
        public readonly int MaxNumberOfRecordSets;
        /// <summary>
        /// Maximum number of Virtual Networks that can be linked to this Private Zone.
        /// </summary>
        public readonly int MaxNumberOfVirtualNetworkLinks;
        /// <summary>
        /// Maximum number of Virtual Networks that can be linked to this Private Zone with registration enabled.
        /// </summary>
        public readonly int MaxNumberOfVirtualNetworkLinksWithRegistration;
        public readonly string Name;
        /// <summary>
        /// The number of recordsets currently in the zone.
        /// </summary>
        public readonly int NumberOfRecordSets;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A mapping of tags for the zone.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetDnsZoneResult(
            string id,

            int maxNumberOfRecordSets,

            int maxNumberOfVirtualNetworkLinks,

            int maxNumberOfVirtualNetworkLinksWithRegistration,

            string name,

            int numberOfRecordSets,

            string resourceGroupName,

            ImmutableDictionary<string, string> tags)
        {
            Id = id;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            MaxNumberOfVirtualNetworkLinks = maxNumberOfVirtualNetworkLinks;
            MaxNumberOfVirtualNetworkLinksWithRegistration = maxNumberOfVirtualNetworkLinksWithRegistration;
            Name = name;
            NumberOfRecordSets = numberOfRecordSets;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
        }
    }
}
