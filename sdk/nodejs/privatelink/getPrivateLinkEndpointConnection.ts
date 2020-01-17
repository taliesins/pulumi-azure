// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/private_link_endpoint_connection.html.markdown.
 */
export function getPrivateLinkEndpointConnection(args: GetPrivateLinkEndpointConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateLinkEndpointConnectionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:privatelink/getPrivateLinkEndpointConnection:getPrivateLinkEndpointConnection", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getPrivateLinkEndpointConnection.
 */
export interface GetPrivateLinkEndpointConnectionArgs {
    /**
     * Specifies the Name of the private link endpoint.
     */
    readonly name: string;
    /**
     * Specifies the Name of the Resource Group within which the private link endpoint exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getPrivateLinkEndpointConnection.
 */
export interface GetPrivateLinkEndpointConnectionResult {
    /**
     * The supported Azure location where the resource exists.
     */
    readonly location: string;
    /**
     * The name of the private linke endpoint.
     */
    readonly name: string;
    readonly privateServiceConnections: outputs.privatelink.GetPrivateLinkEndpointConnectionPrivateServiceConnection[];
    readonly resourceGroupName: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}