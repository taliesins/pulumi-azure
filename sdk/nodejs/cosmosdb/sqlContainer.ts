// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a SQL Container within a Cosmos DB Account.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = new azure.cosmosdb.SqlContainer("example", {
 *     accountName: azurerm_cosmosdb_account_example.name,
 *     databaseName: azurerm_cosmosdb_sql_database_example.name,
 *     partitionKeyPath: "/definition/id",
 *     resourceGroupName: azurerm_cosmosdb_account_example.resourceGroupName,
 *     uniqueKeys: [{
 *         paths: [
 *             "/definition/idlong",
 *             "/definition/idshort",
 *         ],
 *     }],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/cosmosdb_sql_container.html.markdown.
 */
export class SqlContainer extends pulumi.CustomResource {
    /**
     * Get an existing SqlContainer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SqlContainerState, opts?: pulumi.CustomResourceOptions): SqlContainer {
        return new SqlContainer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:cosmosdb/sqlContainer:SqlContainer';

    /**
     * Returns true if the given object is an instance of SqlContainer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlContainer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlContainer.__pulumiType;
    }

    /**
     * The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.
     */
    public readonly accountName!: pulumi.Output<string>;
    /**
     * The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.
     */
    public readonly databaseName!: pulumi.Output<string>;
    /**
     * Specifies the name of the Cosmos DB SQL Database. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Define a partition key. Changing this forces a new resource to be created.
     */
    public readonly partitionKeyPath!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group in which the Cosmos DB SQL Database is created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * One or more `uniqueKey` blocks as defined below. Changing this forces a new resource to be created.
     */
    public readonly uniqueKeys!: pulumi.Output<outputs.cosmosdb.SqlContainerUniqueKey[] | undefined>;

    /**
     * Create a SqlContainer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SqlContainerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SqlContainerArgs | SqlContainerState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as SqlContainerState | undefined;
            inputs["accountName"] = state ? state.accountName : undefined;
            inputs["databaseName"] = state ? state.databaseName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["partitionKeyPath"] = state ? state.partitionKeyPath : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["uniqueKeys"] = state ? state.uniqueKeys : undefined;
        } else {
            const args = argsOrState as SqlContainerArgs | undefined;
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.databaseName === undefined) {
                throw new Error("Missing required property 'databaseName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["databaseName"] = args ? args.databaseName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["partitionKeyPath"] = args ? args.partitionKeyPath : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["uniqueKeys"] = args ? args.uniqueKeys : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(SqlContainer.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SqlContainer resources.
 */
export interface SqlContainerState {
    /**
     * The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.
     */
    readonly accountName?: pulumi.Input<string>;
    /**
     * The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.
     */
    readonly databaseName?: pulumi.Input<string>;
    /**
     * Specifies the name of the Cosmos DB SQL Database. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Define a partition key. Changing this forces a new resource to be created.
     */
    readonly partitionKeyPath?: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Cosmos DB SQL Database is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * One or more `uniqueKey` blocks as defined below. Changing this forces a new resource to be created.
     */
    readonly uniqueKeys?: pulumi.Input<pulumi.Input<inputs.cosmosdb.SqlContainerUniqueKey>[]>;
}

/**
 * The set of arguments for constructing a SqlContainer resource.
 */
export interface SqlContainerArgs {
    /**
     * The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.
     */
    readonly databaseName: pulumi.Input<string>;
    /**
     * Specifies the name of the Cosmos DB SQL Database. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Define a partition key. Changing this forces a new resource to be created.
     */
    readonly partitionKeyPath?: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Cosmos DB SQL Database is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * One or more `uniqueKey` blocks as defined below. Changing this forces a new resource to be created.
     */
    readonly uniqueKeys?: pulumi.Input<pulumi.Input<inputs.cosmosdb.SqlContainerUniqueKey>[]>;
}
