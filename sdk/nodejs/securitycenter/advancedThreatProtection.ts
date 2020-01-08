// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a resources Advanced Threat Protection setting.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const rg = new azure.core.ResourceGroup("rg", {
 *     location: "northeurope",
 * });
 * const exampleAccount = new azure.storage.Account("example", {
 *     accountReplicationType: "LRS",
 *     accountTier: "Standard",
 *     location: azurerm_resource_group_example.location,
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     tags: {
 *         environment: "example",
 *     },
 * });
 * const exampleAdvancedThreatProtection = new azure.securitycenter.AdvancedThreatProtection("example", {
 *     enabled: true,
 *     targetResourceId: exampleAccount.id,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/advanced_threat_protection.html.markdown.
 */
export class AdvancedThreatProtection extends pulumi.CustomResource {
    /**
     * Get an existing AdvancedThreatProtection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AdvancedThreatProtectionState, opts?: pulumi.CustomResourceOptions): AdvancedThreatProtection {
        return new AdvancedThreatProtection(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:securitycenter/advancedThreatProtection:AdvancedThreatProtection';

    /**
     * Returns true if the given object is an instance of AdvancedThreatProtection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AdvancedThreatProtection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AdvancedThreatProtection.__pulumiType;
    }

    /**
     * Should Advanced Threat Protection be enabled on this resource?
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
     */
    public readonly targetResourceId!: pulumi.Output<string>;

    /**
     * Create a AdvancedThreatProtection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AdvancedThreatProtectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AdvancedThreatProtectionArgs | AdvancedThreatProtectionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AdvancedThreatProtectionState | undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["targetResourceId"] = state ? state.targetResourceId : undefined;
        } else {
            const args = argsOrState as AdvancedThreatProtectionArgs | undefined;
            if (!args || args.enabled === undefined) {
                throw new Error("Missing required property 'enabled'");
            }
            if (!args || args.targetResourceId === undefined) {
                throw new Error("Missing required property 'targetResourceId'");
            }
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["targetResourceId"] = args ? args.targetResourceId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AdvancedThreatProtection.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AdvancedThreatProtection resources.
 */
export interface AdvancedThreatProtectionState {
    /**
     * Should Advanced Threat Protection be enabled on this resource?
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
     */
    readonly targetResourceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AdvancedThreatProtection resource.
 */
export interface AdvancedThreatProtectionArgs {
    /**
     * Should Advanced Threat Protection be enabled on this resource?
     */
    readonly enabled: pulumi.Input<boolean>;
    /**
     * The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
     */
    readonly targetResourceId: pulumi.Input<string>;
}
