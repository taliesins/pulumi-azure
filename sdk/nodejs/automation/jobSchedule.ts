// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Links an Automation Runbook and Schedule.
 * 
 * ## Example Usage
 * 
 * This is an example of just the Job Schedule.
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = new azure.automation.JobSchedule("example", {
 *     automationAccountName: "tf-automation-account",
 *     parameters: {
 *         resourcegroup: "tf-rgr-vm",
 *         vmname: "TF-VM-01",
 *     },
 *     resourceGroupName: "tf-rgr-automation",
 *     runbookName: "Get-VirtualMachine",
 *     scheduleName: "hour",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/automation_job_schedule.html.markdown.
 */
export class JobSchedule extends pulumi.CustomResource {
    /**
     * Get an existing JobSchedule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: JobScheduleState, opts?: pulumi.CustomResourceOptions): JobSchedule {
        return new JobSchedule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:automation/jobSchedule:JobSchedule';

    /**
     * Returns true if the given object is an instance of JobSchedule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is JobSchedule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === JobSchedule.__pulumiType;
    }

    /**
     * The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    public readonly automationAccountName!: pulumi.Output<string>;
    /**
     * The UUID identifying the Automation Job Schedule.
     */
    public readonly jobScheduleId!: pulumi.Output<string>;
    /**
     * A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
     */
    public readonly parameters!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
     */
    public readonly runOn!: pulumi.Output<string | undefined>;
    /**
     * The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
     */
    public readonly runbookName!: pulumi.Output<string>;
    public readonly scheduleName!: pulumi.Output<string>;

    /**
     * Create a JobSchedule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: JobScheduleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: JobScheduleArgs | JobScheduleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as JobScheduleState | undefined;
            inputs["automationAccountName"] = state ? state.automationAccountName : undefined;
            inputs["jobScheduleId"] = state ? state.jobScheduleId : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["runOn"] = state ? state.runOn : undefined;
            inputs["runbookName"] = state ? state.runbookName : undefined;
            inputs["scheduleName"] = state ? state.scheduleName : undefined;
        } else {
            const args = argsOrState as JobScheduleArgs | undefined;
            if (!args || args.automationAccountName === undefined) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.runbookName === undefined) {
                throw new Error("Missing required property 'runbookName'");
            }
            if (!args || args.scheduleName === undefined) {
                throw new Error("Missing required property 'scheduleName'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["jobScheduleId"] = args ? args.jobScheduleId : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["runOn"] = args ? args.runOn : undefined;
            inputs["runbookName"] = args ? args.runbookName : undefined;
            inputs["scheduleName"] = args ? args.scheduleName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(JobSchedule.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering JobSchedule resources.
 */
export interface JobScheduleState {
    /**
     * The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    readonly automationAccountName?: pulumi.Input<string>;
    /**
     * The UUID identifying the Automation Job Schedule.
     */
    readonly jobScheduleId?: pulumi.Input<string>;
    /**
     * A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
     */
    readonly parameters?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
     */
    readonly runOn?: pulumi.Input<string>;
    /**
     * The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
     */
    readonly runbookName?: pulumi.Input<string>;
    readonly scheduleName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a JobSchedule resource.
 */
export interface JobScheduleArgs {
    /**
     * The name of the Automation Account in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    readonly automationAccountName: pulumi.Input<string>;
    /**
     * The UUID identifying the Automation Job Schedule.
     */
    readonly jobScheduleId?: pulumi.Input<string>;
    /**
     * A map of key/value pairs corresponding to the arguments that can be passed to the Runbook. Changing this forces a new resource to be created.
     */
    readonly parameters?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the resource group in which the Job Schedule is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of a Hybrid Worker Group the Runbook will be executed on. Changing this forces a new resource to be created.
     */
    readonly runOn?: pulumi.Input<string>;
    /**
     * The name of a Runbook to link to a Schedule. It needs to be in the same Automation Account as the Schedule and Job Schedule. Changing this forces a new resource to be created.
     */
    readonly runbookName: pulumi.Input<string>;
    readonly scheduleName: pulumi.Input<string>;
}
