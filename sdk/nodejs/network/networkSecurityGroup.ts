// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a network security group that contains a list of network security rules.  Network security groups enable inbound or outbound traffic to be enabled or denied.
 * 
 * > **NOTE on Network Security Groups and Network Security Rules:** This provider currently
 * provides both a standalone Network Security Rule resource, and allows for Network Security Rules to be defined in-line within the Network Security Group resource.
 * At this time you cannot use a Network Security Group with in-line Network Security Rules in conjunction with any Network Security Rule resources. Doing so will cause a conflict of rule settings and will overwrite rules.
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
 * const testNetworkSecurityGroup = new azure.network.NetworkSecurityGroup("test", {
 *     location: testResourceGroup.location,
 *     resourceGroupName: testResourceGroup.name,
 *     securityRules: [{
 *         access: "Allow",
 *         destinationAddressPrefix: "*",
 *         destinationPortRange: "*",
 *         direction: "Inbound",
 *         name: "test123",
 *         priority: 100,
 *         protocol: "Tcp",
 *         sourceAddressPrefix: "*",
 *         sourcePortRange: "*",
 *     }],
 *     tags: {
 *         environment: "Production",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/network_security_group.html.markdown.
 */
export class NetworkSecurityGroup extends pulumi.CustomResource {
    /**
     * Get an existing NetworkSecurityGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NetworkSecurityGroupState, opts?: pulumi.CustomResourceOptions): NetworkSecurityGroup {
        return new NetworkSecurityGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:network/networkSecurityGroup:NetworkSecurityGroup';

    /**
     * Returns true if the given object is an instance of NetworkSecurityGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkSecurityGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkSecurityGroup.__pulumiType;
    }

    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the security rule.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the network security group. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * [List of objects](https://www.terraform.io/docs/configuration/attr-as-blocks.html) representing security rules, as defined below.
     */
    public readonly securityRules!: pulumi.Output<outputs.network.NetworkSecurityGroupSecurityRule[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a NetworkSecurityGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkSecurityGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NetworkSecurityGroupArgs | NetworkSecurityGroupState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as NetworkSecurityGroupState | undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["securityRules"] = state ? state.securityRules : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as NetworkSecurityGroupArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["securityRules"] = args ? args.securityRules : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(NetworkSecurityGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NetworkSecurityGroup resources.
 */
export interface NetworkSecurityGroupState {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the security rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the network security group. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * [List of objects](https://www.terraform.io/docs/configuration/attr-as-blocks.html) representing security rules, as defined below.
     */
    readonly securityRules?: pulumi.Input<pulumi.Input<inputs.network.NetworkSecurityGroupSecurityRule>[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a NetworkSecurityGroup resource.
 */
export interface NetworkSecurityGroupArgs {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the security rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the network security group. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * [List of objects](https://www.terraform.io/docs/configuration/attr-as-blocks.html) representing security rules, as defined below.
     */
    readonly securityRules?: pulumi.Input<pulumi.Input<inputs.network.NetworkSecurityGroupSecurityRule>[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
