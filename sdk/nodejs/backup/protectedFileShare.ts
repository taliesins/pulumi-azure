// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/backup_protected_file_share.html.markdown.
 */
export class ProtectedFileShare extends pulumi.CustomResource {
    /**
     * Get an existing ProtectedFileShare resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProtectedFileShareState, opts?: pulumi.CustomResourceOptions): ProtectedFileShare {
        return new ProtectedFileShare(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:backup/protectedFileShare:ProtectedFileShare';

    /**
     * Returns true if the given object is an instance of ProtectedFileShare.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProtectedFileShare {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProtectedFileShare.__pulumiType;
    }

    /**
     * Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
     */
    public readonly backupPolicyId!: pulumi.Output<string>;
    /**
     * Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
     */
    public readonly recoveryVaultName!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * Specifies the name of the file share to backup. Changing this forces a new resource to be created.
     */
    public readonly sourceFileShareName!: pulumi.Output<string>;
    /**
     * Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
     */
    public readonly sourceStorageAccountId!: pulumi.Output<string>;

    /**
     * Create a ProtectedFileShare resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProtectedFileShareArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProtectedFileShareArgs | ProtectedFileShareState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ProtectedFileShareState | undefined;
            inputs["backupPolicyId"] = state ? state.backupPolicyId : undefined;
            inputs["recoveryVaultName"] = state ? state.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["sourceFileShareName"] = state ? state.sourceFileShareName : undefined;
            inputs["sourceStorageAccountId"] = state ? state.sourceStorageAccountId : undefined;
        } else {
            const args = argsOrState as ProtectedFileShareArgs | undefined;
            if (!args || args.backupPolicyId === undefined) {
                throw new Error("Missing required property 'backupPolicyId'");
            }
            if (!args || args.recoveryVaultName === undefined) {
                throw new Error("Missing required property 'recoveryVaultName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sourceFileShareName === undefined) {
                throw new Error("Missing required property 'sourceFileShareName'");
            }
            if (!args || args.sourceStorageAccountId === undefined) {
                throw new Error("Missing required property 'sourceStorageAccountId'");
            }
            inputs["backupPolicyId"] = args ? args.backupPolicyId : undefined;
            inputs["recoveryVaultName"] = args ? args.recoveryVaultName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sourceFileShareName"] = args ? args.sourceFileShareName : undefined;
            inputs["sourceStorageAccountId"] = args ? args.sourceStorageAccountId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ProtectedFileShare.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProtectedFileShare resources.
 */
export interface ProtectedFileShareState {
    /**
     * Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
     */
    readonly backupPolicyId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
     */
    readonly recoveryVaultName?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * Specifies the name of the file share to backup. Changing this forces a new resource to be created.
     */
    readonly sourceFileShareName?: pulumi.Input<string>;
    /**
     * Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
     */
    readonly sourceStorageAccountId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProtectedFileShare resource.
 */
export interface ProtectedFileShareArgs {
    /**
     * Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
     */
    readonly backupPolicyId: pulumi.Input<string>;
    /**
     * Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
     */
    readonly recoveryVaultName: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the name of the file share to backup. Changing this forces a new resource to be created.
     */
    readonly sourceFileShareName: pulumi.Input<string>;
    /**
     * Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
     */
    readonly sourceStorageAccountId: pulumi.Input<string>;
}
