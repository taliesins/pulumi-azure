// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Azure recovery vault protection container mapping. A network protection container mapping decides how to translate the protection container when a VM is migrated from one region to another.
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
 * });
 * const primaryProtectionContainer = new azure.recoveryservices.ProtectionContainer("primary", {
 *     recoveryFabricName: primaryFabric.name,
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * const secondaryProtectionContainer = new azure.recoveryservices.ProtectionContainer("secondary", {
 *     recoveryFabricName: secondaryFabric.name,
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * const policy = new azure.recoveryservices.ReplicationPolicy("policy", {
 *     applicationConsistentSnapshotFrequencyInMinutes: (4 * 60),
 *     recoveryPointRetentionInMinutes: (24 * 60),
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * const containerMapping = new azure.recoveryservices.ProtectionContainerMapping("container-mapping", {
 *     recoveryFabricName: primaryFabric.name,
 *     recoveryReplicationPolicyId: policy.id,
 *     recoverySourceProtectionContainerName: primaryProtectionContainer.name,
 *     recoveryTargetProtectionContainerId: secondaryProtectionContainer.id,
 *     recoveryVaultName: vault.name,
 *     resourceGroupName: secondaryResourceGroup.name,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/recovery_services_protection_container_mapping.html.markdown.
 */
export class ProtectionContainerMapping extends pulumi.CustomResource {
    /**
     * Get an existing ProtectionContainerMapping resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProtectionContainerMappingState, opts?: pulumi.CustomResourceOptions): ProtectionContainerMapping {
        return new ProtectionContainerMapping(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:recoveryservices/protectionContainerMapping:ProtectionContainerMapping';

    /**
     * Returns true if the given object is an instance of ProtectionContainerMapping.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProtectionContainerMapping {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProtectionContainerMapping.__pulumiType;
    }

    /**
     * The name of the network mapping.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Name of fabric that should contains the protection container to map.
     */
    public readonly recoveryFabricName!: pulumi.Output<string>;
    /**
     * Id of the policy to use for this mapping.
     */
    public readonly recoveryReplicationPolicyId!: pulumi.Output<string>;
    /**
     * Name of the protection container to map.
     */
    public readonly recoverySourceProtectionContainerName!: pulumi.Output<string>;
    /**
     * Id of protection container to map to.
     */
    public readonly recoveryTargetProtectionContainerId!: pulumi.Output<string>;
    /**
     * The name of the vault that should be updated.
     */
    public readonly recoveryVaultName!: pulumi.Output<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a ProtectionContainerMapping resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProtectionContainerMappingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProtectionContainerMappingArgs | ProtectionContainerMappingState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ProtectionContainerMappingState | undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["recoveryFabricName"] = state ? state.recoveryFabricName : undefined;
            inputs["recoveryReplicationPolicyId"] = state ? state.recoveryReplicationPolicyId : undefined;
            inputs["recoverySourceProtectionContainerName"] = state ? state.recoverySourceProtectionContainerName : undefined;
            inputs["recoveryTargetProtectionContainerId"] = state ? state.recoveryTargetProtectionContainerId : undefined;
            inputs["recoveryVaultName"] = state ? state.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as ProtectionContainerMappingArgs | undefined;
            if (!args || args.recoveryFabricName === undefined) {
                throw new Error("Missing required property 'recoveryFabricName'");
            }
            if (!args || args.recoveryReplicationPolicyId === undefined) {
                throw new Error("Missing required property 'recoveryReplicationPolicyId'");
            }
            if (!args || args.recoverySourceProtectionContainerName === undefined) {
                throw new Error("Missing required property 'recoverySourceProtectionContainerName'");
            }
            if (!args || args.recoveryTargetProtectionContainerId === undefined) {
                throw new Error("Missing required property 'recoveryTargetProtectionContainerId'");
            }
            if (!args || args.recoveryVaultName === undefined) {
                throw new Error("Missing required property 'recoveryVaultName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["recoveryFabricName"] = args ? args.recoveryFabricName : undefined;
            inputs["recoveryReplicationPolicyId"] = args ? args.recoveryReplicationPolicyId : undefined;
            inputs["recoverySourceProtectionContainerName"] = args ? args.recoverySourceProtectionContainerName : undefined;
            inputs["recoveryTargetProtectionContainerId"] = args ? args.recoveryTargetProtectionContainerId : undefined;
            inputs["recoveryVaultName"] = args ? args.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ProtectionContainerMapping.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProtectionContainerMapping resources.
 */
export interface ProtectionContainerMappingState {
    /**
     * The name of the network mapping.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Name of fabric that should contains the protection container to map.
     */
    readonly recoveryFabricName?: pulumi.Input<string>;
    /**
     * Id of the policy to use for this mapping.
     */
    readonly recoveryReplicationPolicyId?: pulumi.Input<string>;
    /**
     * Name of the protection container to map.
     */
    readonly recoverySourceProtectionContainerName?: pulumi.Input<string>;
    /**
     * Id of protection container to map to.
     */
    readonly recoveryTargetProtectionContainerId?: pulumi.Input<string>;
    /**
     * The name of the vault that should be updated.
     */
    readonly recoveryVaultName?: pulumi.Input<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProtectionContainerMapping resource.
 */
export interface ProtectionContainerMappingArgs {
    /**
     * The name of the network mapping.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Name of fabric that should contains the protection container to map.
     */
    readonly recoveryFabricName: pulumi.Input<string>;
    /**
     * Id of the policy to use for this mapping.
     */
    readonly recoveryReplicationPolicyId: pulumi.Input<string>;
    /**
     * Name of the protection container to map.
     */
    readonly recoverySourceProtectionContainerName: pulumi.Input<string>;
    /**
     * Id of protection container to map to.
     */
    readonly recoveryTargetProtectionContainerId: pulumi.Input<string>;
    /**
     * The name of the vault that should be updated.
     */
    readonly recoveryVaultName: pulumi.Input<string>;
    /**
     * Name of the resource group where the vault that should be updated is located.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
