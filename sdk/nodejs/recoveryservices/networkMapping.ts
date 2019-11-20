// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a site recovery network mapping on Azure. A network mapping decides how to translate connected netwroks when a VM is migrated from one region to another.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const primaryResourceGroup = new azure.core.ResourceGroup("primary", {
 *     location: "West US",
 * });
 * const secondaryResourceGroup = new azure.core.ResourceGroup("secondary", {
 *     location: "East US",
 * });
 * const vault = new azure.recoveryservices.Vault("vault", {
 *     location: secondaryResourceGroup.location,
 *     resourceGroupName: secondaryResourceGroup.name,
 *     sku: "Standard",
 * });
 * const primaryFabric = new azure.recoveryservices.Fabric("primary", {
 *     location: primaryResourceGroup.location,
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * const secondaryFabric = new azure.recoveryservices.Fabric("secondary", {
 *     location: secondaryResourceGroup.location,
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * }, {dependsOn: [primaryFabric]});
 * const primaryVirtualNetwork = new azure.network.VirtualNetwork("primary", {
 *     addressSpaces: ["192.168.1.0/24"],
 *     location: primaryResourceGroup.location,
 *     resourceGroupName: primaryResourceGroup.name,
 * });
 * const secondaryVirtualNetwork = new azure.network.VirtualNetwork("secondary", {
 *     addressSpaces: ["192.168.2.0/24"],
 *     location: secondaryResourceGroup.location,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * const recoveryMapping = new azure.recoveryservices.NetworkMapping("recovery-mapping", {
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 *     sourceNetworkId: primaryVirtualNetwork.id,
 *     sourceRecoveryFabricName: "primary-fabric",
 *     targetNetworkId: secondaryVirtualNetwork.id,
 *     targetRecoveryFabricName: "secondary-fabric",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/recovery_network_mapping.html.markdown.
 */
export class NetworkMapping extends pulumi.CustomResource {
    /**
     * Get an existing NetworkMapping resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkMappingState, opts?: pulumi.CustomResourceOptions): NetworkMapping {
        return new NetworkMapping(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:recoveryservices/networkMapping:NetworkMapping';

    /**
     * Returns true if the given object is an instance of NetworkMapping.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkMapping {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkMapping.__pulumiType;
    }

    /**
     * The name of the network mapping.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the vault that should be updated.
     */
    public readonly recoveryVaultName!: pulumi.Output<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The id of the primary network.
     */
    public readonly sourceNetworkId!: pulumi.Output<string>;
    /**
     * Specifies the ASR fabric where mapping should be created.
     */
    public readonly sourceRecoveryFabricName!: pulumi.Output<string>;
    /**
     * The id of the recovery network.
     */
    public readonly targetNetworkId!: pulumi.Output<string>;
    /**
     * The Azure Site Recovery fabric object corresponding to the recovery Azure region.
     */
    public readonly targetRecoveryFabricName!: pulumi.Output<string>;

    /**
     * Create a NetworkMapping resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkMappingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkMappingArgs | NetworkMappingState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as NetworkMappingState | undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["recoveryVaultName"] = state ? state.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["sourceNetworkId"] = state ? state.sourceNetworkId : undefined;
            inputs["sourceRecoveryFabricName"] = state ? state.sourceRecoveryFabricName : undefined;
            inputs["targetNetworkId"] = state ? state.targetNetworkId : undefined;
            inputs["targetRecoveryFabricName"] = state ? state.targetRecoveryFabricName : undefined;
        } else {
            const args = argsOrState as NetworkMappingArgs | undefined;
            if (!args || args.recoveryVaultName === undefined) {
                throw new Error("Missing required property 'recoveryVaultName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sourceNetworkId === undefined) {
                throw new Error("Missing required property 'sourceNetworkId'");
            }
            if (!args || args.sourceRecoveryFabricName === undefined) {
                throw new Error("Missing required property 'sourceRecoveryFabricName'");
            }
            if (!args || args.targetNetworkId === undefined) {
                throw new Error("Missing required property 'targetNetworkId'");
            }
            if (!args || args.targetRecoveryFabricName === undefined) {
                throw new Error("Missing required property 'targetRecoveryFabricName'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["recoveryVaultName"] = args ? args.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sourceNetworkId"] = args ? args.sourceNetworkId : undefined;
            inputs["sourceRecoveryFabricName"] = args ? args.sourceRecoveryFabricName : undefined;
            inputs["targetNetworkId"] = args ? args.targetNetworkId : undefined;
            inputs["targetRecoveryFabricName"] = args ? args.targetRecoveryFabricName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(NetworkMapping.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NetworkMapping resources.
 */
export interface NetworkMappingState {
    /**
     * The name of the network mapping.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the vault that should be updated.
     */
    readonly recoveryVaultName?: pulumi.Input<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The id of the primary network.
     */
    readonly sourceNetworkId?: pulumi.Input<string>;
    /**
     * Specifies the ASR fabric where mapping should be created.
     */
    readonly sourceRecoveryFabricName?: pulumi.Input<string>;
    /**
     * The id of the recovery network.
     */
    readonly targetNetworkId?: pulumi.Input<string>;
    /**
     * The Azure Site Recovery fabric object corresponding to the recovery Azure region.
     */
    readonly targetRecoveryFabricName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a NetworkMapping resource.
 */
export interface NetworkMappingArgs {
    /**
     * The name of the network mapping.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the vault that should be updated.
     */
    readonly recoveryVaultName: pulumi.Input<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The id of the primary network.
     */
    readonly sourceNetworkId: pulumi.Input<string>;
    /**
     * Specifies the ASR fabric where mapping should be created.
     */
    readonly sourceRecoveryFabricName: pulumi.Input<string>;
    /**
     * The id of the recovery network.
     */
    readonly targetNetworkId: pulumi.Input<string>;
    /**
     * The Azure Site Recovery fabric object corresponding to the recovery Azure region.
     */
    readonly targetRecoveryFabricName: pulumi.Input<string>;
}
