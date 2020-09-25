// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a policy set definition.
 *
 * > **NOTE:**  Policy set definitions (also known as policy initiatives) do not take effect until they are assigned to a scope using a Policy Set Assignment.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const example = new azure.policy.PolicySetDefinition("example", {
 *     displayName: "Test Policy Set",
 *     parameters: `    {
 *         "allowedLocations": {
 *             "type": "Array",
 *             "metadata": {
 *                 "description": "The list of allowed locations for resources.",
 *                 "displayName": "Allowed locations",
 *                 "strongType": "location"
 *             }
 *         }
 *     }
 * `,
 *     policyDefinitionReferences: [{
 *         parameterValues: `    {
 *       "listOfAllowedLocations": {"value": "[parameters('allowedLocations')]"}
 *     }
 *     `,
 *         policyDefinitionId: "/providers/Microsoft.Authorization/policyDefinitions/e765b5de-1225-4ba3-bd56-1ac6695af988",
 *     }],
 *     policyType: "Custom",
 * });
 * ```
 */
export class PolicySetDefinition extends pulumi.CustomResource {
    /**
     * Get an existing PolicySetDefinition resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PolicySetDefinitionState, opts?: pulumi.CustomResourceOptions): PolicySetDefinition {
        return new PolicySetDefinition(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:policy/policySetDefinition:PolicySetDefinition';

    /**
     * Returns true if the given object is an instance of PolicySetDefinition.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PolicySetDefinition {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PolicySetDefinition.__pulumiType;
    }

    /**
     * The description of the policy set definition.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The display name of the policy set definition.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     *
     * @deprecated Deprecated in favour of `management_group_name`
     */
    public readonly managementGroupId!: pulumi.Output<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     */
    public readonly managementGroupName!: pulumi.Output<string>;
    /**
     * The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
     */
    public readonly metadata!: pulumi.Output<string>;
    /**
     * The name of the policy set definition. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
     */
    public readonly parameters!: pulumi.Output<string | undefined>;
    /**
     * One or more `policyDefinitionReference` blocks as defined below.
     */
    public readonly policyDefinitionReferences!: pulumi.Output<outputs.policy.PolicySetDefinitionPolicyDefinitionReference[]>;
    /**
     * The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions.
     *
     * @deprecated Deprecated in favor of `policy_definition_reference`
     */
    public readonly policyDefinitions!: pulumi.Output<string>;
    /**
     * The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
     */
    public readonly policyType!: pulumi.Output<string>;

    /**
     * Create a PolicySetDefinition resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PolicySetDefinitionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PolicySetDefinitionArgs | PolicySetDefinitionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as PolicySetDefinitionState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["managementGroupId"] = state ? state.managementGroupId : undefined;
            inputs["managementGroupName"] = state ? state.managementGroupName : undefined;
            inputs["metadata"] = state ? state.metadata : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["policyDefinitionReferences"] = state ? state.policyDefinitionReferences : undefined;
            inputs["policyDefinitions"] = state ? state.policyDefinitions : undefined;
            inputs["policyType"] = state ? state.policyType : undefined;
        } else {
            const args = argsOrState as PolicySetDefinitionArgs | undefined;
            if (!args || args.displayName === undefined) {
                throw new Error("Missing required property 'displayName'");
            }
            if (!args || args.policyType === undefined) {
                throw new Error("Missing required property 'policyType'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["managementGroupId"] = args ? args.managementGroupId : undefined;
            inputs["managementGroupName"] = args ? args.managementGroupName : undefined;
            inputs["metadata"] = args ? args.metadata : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["policyDefinitionReferences"] = args ? args.policyDefinitionReferences : undefined;
            inputs["policyDefinitions"] = args ? args.policyDefinitions : undefined;
            inputs["policyType"] = args ? args.policyType : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(PolicySetDefinition.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PolicySetDefinition resources.
 */
export interface PolicySetDefinitionState {
    /**
     * The description of the policy set definition.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The display name of the policy set definition.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     *
     * @deprecated Deprecated in favour of `management_group_name`
     */
    readonly managementGroupId?: pulumi.Input<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     */
    readonly managementGroupName?: pulumi.Input<string>;
    /**
     * The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
     */
    readonly metadata?: pulumi.Input<string>;
    /**
     * The name of the policy set definition. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
     */
    readonly parameters?: pulumi.Input<string>;
    /**
     * One or more `policyDefinitionReference` blocks as defined below.
     */
    readonly policyDefinitionReferences?: pulumi.Input<pulumi.Input<inputs.policy.PolicySetDefinitionPolicyDefinitionReference>[]>;
    /**
     * The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions.
     *
     * @deprecated Deprecated in favor of `policy_definition_reference`
     */
    readonly policyDefinitions?: pulumi.Input<string>;
    /**
     * The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
     */
    readonly policyType?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PolicySetDefinition resource.
 */
export interface PolicySetDefinitionArgs {
    /**
     * The description of the policy set definition.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The display name of the policy set definition.
     */
    readonly displayName: pulumi.Input<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     *
     * @deprecated Deprecated in favour of `management_group_name`
     */
    readonly managementGroupId?: pulumi.Input<string>;
    /**
     * The name of the Management Group where this policy set definition should be defined. Changing this forces a new resource to be created.
     */
    readonly managementGroupName?: pulumi.Input<string>;
    /**
     * The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
     */
    readonly metadata?: pulumi.Input<string>;
    /**
     * The name of the policy set definition. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
     */
    readonly parameters?: pulumi.Input<string>;
    /**
     * One or more `policyDefinitionReference` blocks as defined below.
     */
    readonly policyDefinitionReferences?: pulumi.Input<pulumi.Input<inputs.policy.PolicySetDefinitionPolicyDefinitionReference>[]>;
    /**
     * The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions.
     *
     * @deprecated Deprecated in favor of `policy_definition_reference`
     */
    readonly policyDefinitions?: pulumi.Input<string>;
    /**
     * The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
     */
    readonly policyType: pulumi.Input<string>;
}
