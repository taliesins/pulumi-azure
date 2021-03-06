// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Key Vault Certificate Issuer.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West US"});
 * const current = azure.core.getClientConfig({});
 * const exampleKeyVault = new azure.keyvault.KeyVault("exampleKeyVault", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     skuName: "standard",
 *     tenantId: current.then(current => current.tenantId),
 * });
 * const exampleCertificateIssuer = new azure.keyvault.CertificateIssuer("exampleCertificateIssuer", {
 *     orgId: "ExampleOrgName",
 *     keyVaultId: exampleKeyVault.id,
 *     providerName: "DigiCert",
 *     accountId: "0000",
 *     password: "example-password",
 * });
 * ```
 */
export class CertificateIssuer extends pulumi.CustomResource {
    /**
     * Get an existing CertificateIssuer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CertificateIssuerState, opts?: pulumi.CustomResourceOptions): CertificateIssuer {
        return new CertificateIssuer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:keyvault/certificateIssuer:CertificateIssuer';

    /**
     * Returns true if the given object is an instance of CertificateIssuer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CertificateIssuer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CertificateIssuer.__pulumiType;
    }

    /**
     * The account number with the third-party Certificate Issuer.
     */
    public readonly accountId!: pulumi.Output<string | undefined>;
    /**
     * One or more `admin` blocks as defined below.
     */
    public readonly admins!: pulumi.Output<outputs.keyvault.CertificateIssuerAdmin[] | undefined>;
    /**
     * The ID of the Key Vault in which to create the Certificate Issuer.
     */
    public readonly keyVaultId!: pulumi.Output<string>;
    /**
     * The name which should be used for this Key Vault Certificate Issuer. Changing this forces a new Key Vault Certificate Issuer to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the organization as provided to the issuer.
     */
    public readonly orgId!: pulumi.Output<string>;
    /**
     * The password associated with the account and organization ID at the third-party Certificate Issuer. If not specified, will not overwrite any previous value.
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * The name of the third-party Certificate Issuer. Possible values are: `DigiCert`, `GlobalSign`.
     */
    public readonly providerName!: pulumi.Output<string>;

    /**
     * Create a CertificateIssuer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CertificateIssuerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CertificateIssuerArgs | CertificateIssuerState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as CertificateIssuerState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["admins"] = state ? state.admins : undefined;
            inputs["keyVaultId"] = state ? state.keyVaultId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["orgId"] = state ? state.orgId : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["providerName"] = state ? state.providerName : undefined;
        } else {
            const args = argsOrState as CertificateIssuerArgs | undefined;
            if (!args || args.keyVaultId === undefined) {
                throw new Error("Missing required property 'keyVaultId'");
            }
            if (!args || args.orgId === undefined) {
                throw new Error("Missing required property 'orgId'");
            }
            if (!args || args.providerName === undefined) {
                throw new Error("Missing required property 'providerName'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["admins"] = args ? args.admins : undefined;
            inputs["keyVaultId"] = args ? args.keyVaultId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["orgId"] = args ? args.orgId : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["providerName"] = args ? args.providerName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(CertificateIssuer.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CertificateIssuer resources.
 */
export interface CertificateIssuerState {
    /**
     * The account number with the third-party Certificate Issuer.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * One or more `admin` blocks as defined below.
     */
    readonly admins?: pulumi.Input<pulumi.Input<inputs.keyvault.CertificateIssuerAdmin>[]>;
    /**
     * The ID of the Key Vault in which to create the Certificate Issuer.
     */
    readonly keyVaultId?: pulumi.Input<string>;
    /**
     * The name which should be used for this Key Vault Certificate Issuer. Changing this forces a new Key Vault Certificate Issuer to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the organization as provided to the issuer.
     */
    readonly orgId?: pulumi.Input<string>;
    /**
     * The password associated with the account and organization ID at the third-party Certificate Issuer. If not specified, will not overwrite any previous value.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The name of the third-party Certificate Issuer. Possible values are: `DigiCert`, `GlobalSign`.
     */
    readonly providerName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CertificateIssuer resource.
 */
export interface CertificateIssuerArgs {
    /**
     * The account number with the third-party Certificate Issuer.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * One or more `admin` blocks as defined below.
     */
    readonly admins?: pulumi.Input<pulumi.Input<inputs.keyvault.CertificateIssuerAdmin>[]>;
    /**
     * The ID of the Key Vault in which to create the Certificate Issuer.
     */
    readonly keyVaultId: pulumi.Input<string>;
    /**
     * The name which should be used for this Key Vault Certificate Issuer. Changing this forces a new Key Vault Certificate Issuer to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the organization as provided to the issuer.
     */
    readonly orgId: pulumi.Input<string>;
    /**
     * The password associated with the account and organization ID at the third-party Certificate Issuer. If not specified, will not overwrite any previous value.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The name of the third-party Certificate Issuer. Possible values are: `DigiCert`, `GlobalSign`.
     */
    readonly providerName: pulumi.Input<string>;
}
