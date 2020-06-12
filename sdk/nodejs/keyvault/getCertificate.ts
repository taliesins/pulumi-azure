// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Key Vault Certificate.
 *
 * > **Note:** All arguments including the secret value will be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleKeyVault = azure.keyvault.getKeyVault({
 *     name: "examplekv",
 *     resourceGroupName: "some-resource-group",
 * });
 * const exampleCertificate = exampleKeyVault.then(exampleKeyVault => azure.keyvault.getCertificate({
 *     name: "secret-sauce",
 *     keyVaultId: exampleKeyVault.id,
 * }));
 * export const certificateThumbprint = exampleCertificate.then(exampleCertificate => exampleCertificate.thumbprint);
 * ```
 */
export function getCertificate(args: GetCertificateArgs, opts?: pulumi.InvokeOptions): Promise<GetCertificateResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:keyvault/getCertificate:getCertificate", {
        "keyVaultId": args.keyVaultId,
        "name": args.name,
        "version": args.version,
    }, opts);
}

/**
 * A collection of arguments for invoking getCertificate.
 */
export interface GetCertificateArgs {
    /**
     * Specifies the ID of the Key Vault instance where the Secret resides, available on the `azure.keyvault.KeyVault` Data Source / Resource.
     */
    readonly keyVaultId: string;
    /**
     * Specifies the name of the Key Vault Secret.
     */
    readonly name: string;
    /**
     * Specifies the version of the certificate to look up.  (Defaults to latest) 
     */
    readonly version?: string;
}

/**
 * A collection of values returned by getCertificate.
 */
export interface GetCertificateResult {
    readonly certificateData: string;
    /**
     * A `certificatePolicy` block as defined below.
     */
    readonly certificatePolicies: outputs.keyvault.GetCertificateCertificatePolicy[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly keyVaultId: string;
    /**
     * The name of the Certificate Issuer.
     */
    readonly name: string;
    readonly secretId: string;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags: {[key: string]: string};
    readonly thumbprint: string;
    readonly version: string;
}
