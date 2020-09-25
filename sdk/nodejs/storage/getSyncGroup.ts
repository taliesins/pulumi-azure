// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Storage Sync Group.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const example = azure.storage.getSyncGroup({
 *     name: "existing-ss-group",
 *     storageSyncId: "existing-ss-id",
 * });
 * export const id = example.then(example => example.id);
 * ```
 */
export function getSyncGroup(args: GetSyncGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetSyncGroupResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:storage/getSyncGroup:getSyncGroup", {
        "name": args.name,
        "storageSyncId": args.storageSyncId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSyncGroup.
 */
export interface GetSyncGroupArgs {
    /**
     * The name of this Storage Sync Group.
     */
    readonly name: string;
    /**
     * The resource ID of the Storage Sync where this Storage Sync Group is.
     */
    readonly storageSyncId: string;
}

/**
 * A collection of values returned by getSyncGroup.
 */
export interface GetSyncGroupResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly storageSyncId: string;
}
