// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.PrivateLink
{
    public static class GetEndpointConnection
    {
        /// <summary>
        /// Use this data source to access the connection status information about an existing Private Endpoint Connection.
        /// 
        /// &gt; **NOTE** Private Endpoint is currently in Public Preview.
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
        ///         var example = Output.Create(Azure.PrivateLink.GetEndpointConnection.InvokeAsync(new Azure.PrivateLink.GetEndpointConnectionArgs
        ///         {
        ///             Name = "example-private-endpoint",
        ///             ResourceGroupName = "example-rg",
        ///         }));
        ///         this.PrivateEndpointStatus = example.Apply(example =&gt; example.PrivateServiceConnections[0].Status);
        ///     }
        /// 
        ///     [Output("privateEndpointStatus")]
        ///     public Output&lt;string&gt; PrivateEndpointStatus { get; set; }
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetEndpointConnectionResult> InvokeAsync(GetEndpointConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEndpointConnectionResult>("azure:privatelink/getEndpointConnection:getEndpointConnection", args ?? new GetEndpointConnectionArgs(), options.WithVersion());
    }


    public sealed class GetEndpointConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the Name of the private endpoint.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Specifies the Name of the Resource Group within which the private endpoint exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetEndpointConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEndpointConnectionResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The supported Azure location where the resource exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the private endpoint.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetEndpointConnectionPrivateServiceConnectionResult> PrivateServiceConnections;
        public readonly string ResourceGroupName;

        [OutputConstructor]
        private GetEndpointConnectionResult(
            string id,

            string location,

            string name,

            ImmutableArray<Outputs.GetEndpointConnectionPrivateServiceConnectionResult> privateServiceConnections,

            string resourceGroupName)
        {
            Id = id;
            Location = location;
            Name = name;
            PrivateServiceConnections = privateServiceConnections;
            ResourceGroupName = resourceGroupName;
        }
    }
}
