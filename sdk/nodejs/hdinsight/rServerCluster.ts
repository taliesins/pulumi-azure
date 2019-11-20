// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a HDInsight RServer Cluster.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("example", {
 *     location: "West Europe",
 * });
 * const exampleAccount = new azure.storage.Account("example", {
 *     accountReplicationType: "LRS",
 *     accountTier: "Standard",
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * const exampleContainer = new azure.storage.Container("example", {
 *     containerAccessType: "private",
 *     resourceGroupName: exampleResourceGroup.name,
 *     storageAccountName: exampleAccount.name,
 * });
 * const exampleRServerCluster = new azure.hdinsight.RServerCluster("example", {
 *     clusterVersion: "3.6",
 *     gateway: {
 *         enabled: true,
 *         password: "TerrAform123!",
 *         username: "acctestusrgw",
 *     },
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     roles: {
 *         edgeNode: {
 *             password: "AccTestvdSC4daf986!",
 *             username: "acctestusrvm",
 *             vmSize: "Standard_D3_v2",
 *         },
 *         headNode: {
 *             password: "AccTestvdSC4daf986!",
 *             username: "acctestusrvm",
 *             vmSize: "Standard_D3_v2",
 *         },
 *         workerNode: {
 *             password: "AccTestvdSC4daf986!",
 *             targetInstanceCount: 3,
 *             username: "acctestusrvm",
 *             vmSize: "Standard_D4_V2",
 *         },
 *         zookeeperNode: {
 *             password: "AccTestvdSC4daf986!",
 *             username: "acctestusrvm",
 *             vmSize: "Standard_D3_v2",
 *         },
 *     },
 *     rstudio: true,
 *     storageAccounts: [{
 *         isDefault: true,
 *         storageAccountKey: exampleAccount.primaryAccessKey,
 *         storageContainerId: exampleContainer.id,
 *     }],
 *     tier: "Standard",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/hdinsight_rserver_cluster.html.markdown.
 */
export class RServerCluster extends pulumi.CustomResource {
    /**
     * Get an existing RServerCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RServerClusterState, opts?: pulumi.CustomResourceOptions): RServerCluster {
        return new RServerCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:hdinsight/rServerCluster:RServerCluster';

    /**
     * Returns true if the given object is an instance of RServerCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RServerCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RServerCluster.__pulumiType;
    }

    /**
     * Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
     */
    public readonly clusterVersion!: pulumi.Output<string>;
    /**
     * The SSH Connectivity Endpoint for the Edge Node of the HDInsight RServer Cluster.
     */
    public /*out*/ readonly edgeSshEndpoint!: pulumi.Output<string>;
    /**
     * A `gateway` block as defined below.
     */
    public readonly gateway!: pulumi.Output<outputs.hdinsight.RServerClusterGateway>;
    /**
     * The HTTPS Connectivity Endpoint for this HDInsight RServer Cluster.
     */
    public /*out*/ readonly httpsEndpoint!: pulumi.Output<string>;
    /**
     * Specifies the Azure Region which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name for this HDInsight RServer Cluster. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the name of the Resource Group in which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `roles` block as defined below.
     */
    public readonly roles!: pulumi.Output<outputs.hdinsight.RServerClusterRoles>;
    /**
     * Should R Studio community edition for RServer be installed? Changing this forces a new resource to be created.
     */
    public readonly rstudio!: pulumi.Output<boolean>;
    /**
     * The SSH Connectivity Endpoint for this HDInsight RServer Cluster.
     */
    public /*out*/ readonly sshEndpoint!: pulumi.Output<string>;
    /**
     * One or more `storageAccount` block as defined below.
     */
    public readonly storageAccounts!: pulumi.Output<outputs.hdinsight.RServerClusterStorageAccount[]>;
    /**
     * A map of Tags which should be assigned to this HDInsight RServer Cluster.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;
    /**
     * Specifies the Tier which should be used for this HDInsight RServer Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.
     */
    public readonly tier!: pulumi.Output<string>;

    /**
     * Create a RServerCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RServerClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RServerClusterArgs | RServerClusterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as RServerClusterState | undefined;
            inputs["clusterVersion"] = state ? state.clusterVersion : undefined;
            inputs["edgeSshEndpoint"] = state ? state.edgeSshEndpoint : undefined;
            inputs["gateway"] = state ? state.gateway : undefined;
            inputs["httpsEndpoint"] = state ? state.httpsEndpoint : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["roles"] = state ? state.roles : undefined;
            inputs["rstudio"] = state ? state.rstudio : undefined;
            inputs["sshEndpoint"] = state ? state.sshEndpoint : undefined;
            inputs["storageAccounts"] = state ? state.storageAccounts : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["tier"] = state ? state.tier : undefined;
        } else {
            const args = argsOrState as RServerClusterArgs | undefined;
            if (!args || args.clusterVersion === undefined) {
                throw new Error("Missing required property 'clusterVersion'");
            }
            if (!args || args.gateway === undefined) {
                throw new Error("Missing required property 'gateway'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.roles === undefined) {
                throw new Error("Missing required property 'roles'");
            }
            if (!args || args.rstudio === undefined) {
                throw new Error("Missing required property 'rstudio'");
            }
            if (!args || args.storageAccounts === undefined) {
                throw new Error("Missing required property 'storageAccounts'");
            }
            if (!args || args.tier === undefined) {
                throw new Error("Missing required property 'tier'");
            }
            inputs["clusterVersion"] = args ? args.clusterVersion : undefined;
            inputs["gateway"] = args ? args.gateway : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["roles"] = args ? args.roles : undefined;
            inputs["rstudio"] = args ? args.rstudio : undefined;
            inputs["storageAccounts"] = args ? args.storageAccounts : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["tier"] = args ? args.tier : undefined;
            inputs["edgeSshEndpoint"] = undefined /*out*/;
            inputs["httpsEndpoint"] = undefined /*out*/;
            inputs["sshEndpoint"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(RServerCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RServerCluster resources.
 */
export interface RServerClusterState {
    /**
     * Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
     */
    readonly clusterVersion?: pulumi.Input<string>;
    /**
     * The SSH Connectivity Endpoint for the Edge Node of the HDInsight RServer Cluster.
     */
    readonly edgeSshEndpoint?: pulumi.Input<string>;
    /**
     * A `gateway` block as defined below.
     */
    readonly gateway?: pulumi.Input<inputs.hdinsight.RServerClusterGateway>;
    /**
     * The HTTPS Connectivity Endpoint for this HDInsight RServer Cluster.
     */
    readonly httpsEndpoint?: pulumi.Input<string>;
    /**
     * Specifies the Azure Region which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name for this HDInsight RServer Cluster. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `roles` block as defined below.
     */
    readonly roles?: pulumi.Input<inputs.hdinsight.RServerClusterRoles>;
    /**
     * Should R Studio community edition for RServer be installed? Changing this forces a new resource to be created.
     */
    readonly rstudio?: pulumi.Input<boolean>;
    /**
     * The SSH Connectivity Endpoint for this HDInsight RServer Cluster.
     */
    readonly sshEndpoint?: pulumi.Input<string>;
    /**
     * One or more `storageAccount` block as defined below.
     */
    readonly storageAccounts?: pulumi.Input<pulumi.Input<inputs.hdinsight.RServerClusterStorageAccount>[]>;
    /**
     * A map of Tags which should be assigned to this HDInsight RServer Cluster.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the Tier which should be used for this HDInsight RServer Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.
     */
    readonly tier?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RServerCluster resource.
 */
export interface RServerClusterArgs {
    /**
     * Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
     */
    readonly clusterVersion: pulumi.Input<string>;
    /**
     * A `gateway` block as defined below.
     */
    readonly gateway: pulumi.Input<inputs.hdinsight.RServerClusterGateway>;
    /**
     * Specifies the Azure Region which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name for this HDInsight RServer Cluster. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which this HDInsight RServer Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `roles` block as defined below.
     */
    readonly roles: pulumi.Input<inputs.hdinsight.RServerClusterRoles>;
    /**
     * Should R Studio community edition for RServer be installed? Changing this forces a new resource to be created.
     */
    readonly rstudio: pulumi.Input<boolean>;
    /**
     * One or more `storageAccount` block as defined below.
     */
    readonly storageAccounts: pulumi.Input<pulumi.Input<inputs.hdinsight.RServerClusterStorageAccount>[]>;
    /**
     * A map of Tags which should be assigned to this HDInsight RServer Cluster.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the Tier which should be used for this HDInsight RServer Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.
     */
    readonly tier: pulumi.Input<string>;
}
