// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a MS Teams integration for a Bot Channel
 *
 * > **Note** A bot can only have a single MS Teams Channel associated with it.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const current = azure.core.getClientConfig({});
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "northeurope"});
 * const exampleChannelsRegistration = new azure.bot.ChannelsRegistration("exampleChannelsRegistration", {
 *     location: "global",
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "F0",
 *     microsoftAppId: current.then(current => current.clientId),
 * });
 * const exampleChannelTeams = new azure.bot.ChannelTeams("exampleChannelTeams", {
 *     botName: exampleChannelsRegistration.name,
 *     location: exampleChannelsRegistration.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     callingWebHook: "https://example2.com/",
 *     enableCalling: false,
 * });
 * ```
 */
export class ChannelTeams extends pulumi.CustomResource {
    /**
     * Get an existing ChannelTeams resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ChannelTeamsState, opts?: pulumi.CustomResourceOptions): ChannelTeams {
        return new ChannelTeams(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:bot/channelTeams:ChannelTeams';

    /**
     * Returns true if the given object is an instance of ChannelTeams.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ChannelTeams {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ChannelTeams.__pulumiType;
    }

    /**
     * The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
     */
    public readonly botName!: pulumi.Output<string>;
    /**
     * Specifies the webhook for Microsoft Teams channel calls.
     */
    public readonly callingWebHook!: pulumi.Output<string | undefined>;
    /**
     * Specifies whether to enable Microsoft Teams channel calls. This defaults to `false`.
     */
    public readonly enableCalling!: pulumi.Output<boolean | undefined>;
    /**
     * The supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a ChannelTeams resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ChannelTeamsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ChannelTeamsArgs | ChannelTeamsState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ChannelTeamsState | undefined;
            inputs["botName"] = state ? state.botName : undefined;
            inputs["callingWebHook"] = state ? state.callingWebHook : undefined;
            inputs["enableCalling"] = state ? state.enableCalling : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as ChannelTeamsArgs | undefined;
            if (!args || args.botName === undefined) {
                throw new Error("Missing required property 'botName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["botName"] = args ? args.botName : undefined;
            inputs["callingWebHook"] = args ? args.callingWebHook : undefined;
            inputs["enableCalling"] = args ? args.enableCalling : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ChannelTeams.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ChannelTeams resources.
 */
export interface ChannelTeamsState {
    /**
     * The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
     */
    readonly botName?: pulumi.Input<string>;
    /**
     * Specifies the webhook for Microsoft Teams channel calls.
     */
    readonly callingWebHook?: pulumi.Input<string>;
    /**
     * Specifies whether to enable Microsoft Teams channel calls. This defaults to `false`.
     */
    readonly enableCalling?: pulumi.Input<boolean>;
    /**
     * The supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ChannelTeams resource.
 */
export interface ChannelTeamsArgs {
    /**
     * The name of the Bot Resource this channel will be associated with. Changing this forces a new resource to be created.
     */
    readonly botName: pulumi.Input<string>;
    /**
     * Specifies the webhook for Microsoft Teams channel calls.
     */
    readonly callingWebHook?: pulumi.Input<string>;
    /**
     * Specifies whether to enable Microsoft Teams channel calls. This defaults to `false`.
     */
    readonly enableCalling?: pulumi.Input<boolean>;
    /**
     * The supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Bot Channel. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
