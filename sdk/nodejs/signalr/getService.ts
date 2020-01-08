// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Azure SignalR service.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = azure.signalr.getService({
 *     name: "test-signalr",
 *     resourceGroupName: "signalr-resource-group",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/signalr_service.html.markdown.
 */
export function getService(args: GetServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceResult> & GetServiceResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetServiceResult> = pulumi.runtime.invoke("azure:signalr/getService:getService", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getService.
 */
export interface GetServiceArgs {
    /**
     * Specifies the name of the SignalR service.
     */
    readonly name: string;
    /**
     * Specifies the name of the resource group the SignalR service is located in.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getService.
 */
export interface GetServiceResult {
    /**
     * The FQDN of the SignalR service.
     */
    readonly hostname: string;
    /**
     * The publicly accessible IP of the SignalR service.
     */
    readonly ipAddress: string;
    /**
     * Specifies the supported Azure location where the SignalR service exists.
     */
    readonly location: string;
    readonly name: string;
    /**
     * The primary access key of the SignalR service.
     */
    readonly primaryAccessKey: string;
    /**
     * The primary connection string of the SignalR service.
     */
    readonly primaryConnectionString: string;
    /**
     * The publicly accessible port of the SignalR service which is designed for browser/client use.
     */
    readonly publicPort: number;
    readonly resourceGroupName: string;
    /**
     * The secondary access key of the SignalR service.
     */
    readonly secondaryAccessKey: string;
    /**
     * The secondary connection string of the SignalR service.
     */
    readonly secondaryConnectionString: string;
    /**
     * The publicly accessible port of the SignalR service which is designed for customer server side use.
     */
    readonly serverPort: number;
    readonly tags: {[key: string]: string};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
