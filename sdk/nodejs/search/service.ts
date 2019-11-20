// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Allows you to manage an Azure Search Service.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const testResourceGroup = new azure.core.ResourceGroup("test", {
 *     location: "West US",
 * });
 * const testService = new azure.search.Service("test", {
 *     location: testResourceGroup.location,
 *     resourceGroupName: testResourceGroup.name,
 *     sku: "standard",
 *     tags: {
 *         database: "test",
 *         environment: "staging",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/search_service.html.markdown.
 */
export class Service extends pulumi.CustomResource {
    /**
     * Get an existing Service resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServiceState, opts?: pulumi.CustomResourceOptions): Service {
        return new Service(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:search/service:Service';

    /**
     * Returns true if the given object is an instance of Service.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Service {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Service.__pulumiType;
    }

    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the Search Service. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Default is 1. Valid values include 1, 2, 3, 4, 6, or 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    public readonly partitionCount!: pulumi.Output<number>;
    /**
     * The Search Service Administration primary key.
     */
    public /*out*/ readonly primaryKey!: pulumi.Output<string>;
    /**
     * Default is 1. Valid values include 1 through 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    public readonly replicaCount!: pulumi.Output<number>;
    /**
     * The name of the resource group in which to create the Search Service. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The Search Service Administration secondary key.
     */
    public /*out*/ readonly secondaryKey!: pulumi.Output<string>;
    /**
     * Valid values are `basic`, `free` and `standard`. `standard2` and `standard3` are also valid, but can only be used when it's enabled on the backend by Microsoft support. `free` provisions the service in shared clusters. `standard` provisions the service in dedicated clusters.  Changing this forces a new resource to be created.
     */
    public readonly sku!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a Service resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServiceArgs | ServiceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ServiceState | undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["partitionCount"] = state ? state.partitionCount : undefined;
            inputs["primaryKey"] = state ? state.primaryKey : undefined;
            inputs["replicaCount"] = state ? state.replicaCount : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["secondaryKey"] = state ? state.secondaryKey : undefined;
            inputs["sku"] = state ? state.sku : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ServiceArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["partitionCount"] = args ? args.partitionCount : undefined;
            inputs["replicaCount"] = args ? args.replicaCount : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["primaryKey"] = undefined /*out*/;
            inputs["secondaryKey"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Service.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Service resources.
 */
export interface ServiceState {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Search Service. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Default is 1. Valid values include 1, 2, 3, 4, 6, or 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    readonly partitionCount?: pulumi.Input<number>;
    /**
     * The Search Service Administration primary key.
     */
    readonly primaryKey?: pulumi.Input<string>;
    /**
     * Default is 1. Valid values include 1 through 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    readonly replicaCount?: pulumi.Input<number>;
    /**
     * The name of the resource group in which to create the Search Service. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The Search Service Administration secondary key.
     */
    readonly secondaryKey?: pulumi.Input<string>;
    /**
     * Valid values are `basic`, `free` and `standard`. `standard2` and `standard3` are also valid, but can only be used when it's enabled on the backend by Microsoft support. `free` provisions the service in shared clusters. `standard` provisions the service in dedicated clusters.  Changing this forces a new resource to be created.
     */
    readonly sku?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Service resource.
 */
export interface ServiceArgs {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Search Service. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Default is 1. Valid values include 1, 2, 3, 4, 6, or 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    readonly partitionCount?: pulumi.Input<number>;
    /**
     * Default is 1. Valid values include 1 through 12. Valid only when `sku` is `standard`. Changing this forces a new resource to be created.
     */
    readonly replicaCount?: pulumi.Input<number>;
    /**
     * The name of the resource group in which to create the Search Service. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Valid values are `basic`, `free` and `standard`. `standard2` and `standard3` are also valid, but can only be used when it's enabled on the backend by Microsoft support. `free` provisions the service in shared clusters. `standard` provisions the service in dedicated clusters.  Changing this forces a new resource to be created.
     */
    readonly sku: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
