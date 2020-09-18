// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.CosmosDB
{
    /// <summary>
    /// Manages a Gremlin Database within a Cosmos DB Account.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleAccount = Output.Create(Azure.CosmosDB.GetAccount.InvokeAsync(new Azure.CosmosDB.GetAccountArgs
    ///         {
    ///             Name = "tfex-cosmosdb-account",
    ///             ResourceGroupName = "tfex-cosmosdb-account-rg",
    ///         }));
    ///         var exampleGremlinDatabase = new Azure.CosmosDB.GremlinDatabase("exampleGremlinDatabase", new Azure.CosmosDB.GremlinDatabaseArgs
    ///         {
    ///             ResourceGroupName = exampleAccount.Apply(exampleAccount =&gt; exampleAccount.ResourceGroupName),
    ///             AccountName = exampleAccount.Apply(exampleAccount =&gt; exampleAccount.Name),
    ///             Throughput = 400,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class GremlinDatabase : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the CosmosDB Account to create the Gremlin Database within. Changing this forces a new resource to be created.
        /// </summary>
        [Output("accountName")]
        public Output<string> AccountName { get; private set; } = null!;

        [Output("autoscaleSettings")]
        public Output<Outputs.GremlinDatabaseAutoscaleSettings?> AutoscaleSettings { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Cosmos DB Gremlin Database. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Cosmos DB Gremlin Database is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The throughput of the Gremlin database (RU/s). Must be set in increments of `100`. The minimum value is `400`. This must be set upon database creation otherwise it cannot be updated without a manual resource destroy-apply.
        /// </summary>
        [Output("throughput")]
        public Output<int> Throughput { get; private set; } = null!;


        /// <summary>
        /// Create a GremlinDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GremlinDatabase(string name, GremlinDatabaseArgs args, CustomResourceOptions? options = null)
            : base("azure:cosmosdb/gremlinDatabase:GremlinDatabase", name, args ?? new GremlinDatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GremlinDatabase(string name, Input<string> id, GremlinDatabaseState? state = null, CustomResourceOptions? options = null)
            : base("azure:cosmosdb/gremlinDatabase:GremlinDatabase", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing GremlinDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GremlinDatabase Get(string name, Input<string> id, GremlinDatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new GremlinDatabase(name, id, state, options);
        }
    }

    public sealed class GremlinDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the CosmosDB Account to create the Gremlin Database within. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("autoscaleSettings")]
        public Input<Inputs.GremlinDatabaseAutoscaleSettingsArgs>? AutoscaleSettings { get; set; }

        /// <summary>
        /// Specifies the name of the Cosmos DB Gremlin Database. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Cosmos DB Gremlin Database is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The throughput of the Gremlin database (RU/s). Must be set in increments of `100`. The minimum value is `400`. This must be set upon database creation otherwise it cannot be updated without a manual resource destroy-apply.
        /// </summary>
        [Input("throughput")]
        public Input<int>? Throughput { get; set; }

        public GremlinDatabaseArgs()
        {
        }
    }

    public sealed class GremlinDatabaseState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the CosmosDB Account to create the Gremlin Database within. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        [Input("autoscaleSettings")]
        public Input<Inputs.GremlinDatabaseAutoscaleSettingsGetArgs>? AutoscaleSettings { get; set; }

        /// <summary>
        /// Specifies the name of the Cosmos DB Gremlin Database. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Cosmos DB Gremlin Database is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The throughput of the Gremlin database (RU/s). Must be set in increments of `100`. The minimum value is `400`. This must be set upon database creation otherwise it cannot be updated without a manual resource destroy-apply.
        /// </summary>
        [Input("throughput")]
        public Input<int>? Throughput { get; set; }

        public GremlinDatabaseState()
        {
        }
    }
}
