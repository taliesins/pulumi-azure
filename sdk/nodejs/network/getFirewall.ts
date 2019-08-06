// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Azure Firewall.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const test = pulumi.output(azure.network.getFirewall({
 *     name: "firewall1",
 *     resourceGroupName: "firewall-RG",
 * }));
 * 
 * export const firewallPrivateIp = test.ipConfiguration.privateIpAddress;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/firewall.html.markdown.
 */
export function getFirewall(args: GetFirewallArgs, opts?: pulumi.InvokeOptions): Promise<GetFirewallResult> & GetFirewallResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetFirewallResult> = pulumi.runtime.invoke("azure:network/getFirewall:getFirewall", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getFirewall.
 */
export interface GetFirewallArgs {
    /**
     * The name of the Azure Firewall.
     */
    readonly name: string;
    /**
     * The name of the Resource Group in which the Azure Firewall exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getFirewall.
 */
export interface GetFirewallResult {
    /**
     * A `ipConfiguration` block as defined below.
     */
    readonly ipConfiguration: { internalPublicIpAddressId: string, name: string, privateIpAddress: string, publicIpAddressId: string, subnetId: string };
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
