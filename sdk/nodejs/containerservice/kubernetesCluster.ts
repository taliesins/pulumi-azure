// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Managed Kubernetes Cluster (also known as AKS / Azure Kubernetes Service)
 * 
 * > **Note:** All arguments including the client secret will be stored in the raw state as plain-text. [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 * 
 * ## Example Usage
 * 
 * This example provisions a basic Managed Kubernetes Cluster. Other examples of the `azurerm_kubernetes_cluster` resource can be found in [the `./examples/kubernetes` directory within the Github Repository](https://github.com/terraform-providers/terraform-provider-azurerm/tree/master/examples/kubernetes)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const testResourceGroup = new azure.core.ResourceGroup("test", {
 *     location: "East US",
 *     name: "acctestRG1",
 * });
 * const testKubernetesCluster = new azure.containerservice.KubernetesCluster("test", {
 *     agentPoolProfile: {
 *         count: 1,
 *         name: "default",
 *         osDiskSizeGb: 30,
 *         osType: "Linux",
 *         vmSize: "Standard_D1_v2",
 *     },
 *     dnsPrefix: "acctestagent1",
 *     location: testResourceGroup.location,
 *     name: "acctestaks1",
 *     resourceGroupName: testResourceGroup.name,
 *     servicePrincipal: {
 *         clientId: "00000000-0000-0000-0000-000000000000",
 *         clientSecret: "00000000000000000000000000000000",
 *     },
 *     tags: {
 *         Environment: "Production",
 *     },
 * });
 * 
 * export const clientCertificate = testKubernetesCluster.kubeConfig.clientCertificate;
 * export const kubeConfig = testKubernetesCluster.kubeConfigRaw;
 * ```
 */
export class KubernetesCluster extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KubernetesClusterState, opts?: pulumi.CustomResourceOptions): KubernetesCluster {
        return new KubernetesCluster(name, <any>state, { ...opts, id: id });
    }

    /**
     * A `addon_profile` block.
     */
    public readonly addonProfile!: pulumi.Output<{ aciConnectorLinux?: { enabled: boolean, subnetName: string }, httpApplicationRouting?: { enabled: boolean, httpApplicationRoutingZoneName: string }, omsAgent?: { enabled: boolean, logAnalyticsWorkspaceId: string } }>;
    /**
     * An `agent_pool_profile` block.  Currently only one agent pool can exist.
     */
    public readonly agentPoolProfile!: pulumi.Output<{ count?: number, dnsPrefix: string, fqdn: string, maxPods: number, name: string, osDiskSizeGb: number, osType?: string, type?: string, vmSize: string, vnetSubnetId?: string }>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    public readonly apiServerAuthorizedIpRanges!: pulumi.Output<string[] | undefined>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    public readonly dnsPrefix!: pulumi.Output<string>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    public /*out*/ readonly fqdn!: pulumi.Output<string>;
    /**
     * A `kube_admin_config` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    public /*out*/ readonly kubeAdminConfig!: pulumi.Output<{ clientCertificate: string, clientKey: string, clusterCaCertificate: string, host: string, password: string, username: string }>;
    /**
     * Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    public /*out*/ readonly kubeAdminConfigRaw!: pulumi.Output<string>;
    /**
     * A `kube_config` block as defined below.
     */
    public /*out*/ readonly kubeConfig!: pulumi.Output<{ clientCertificate: string, clientKey: string, clusterCaCertificate: string, host: string, password: string, username: string }>;
    /**
     * Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
     */
    public /*out*/ readonly kubeConfigRaw!: pulumi.Output<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    public readonly kubernetesVersion!: pulumi.Output<string>;
    /**
     * A `linux_profile` block.
     */
    public readonly linuxProfile!: pulumi.Output<{ adminUsername: string, sshKey: { keyData: string } } | undefined>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A `network_profile` block.
     */
    public readonly networkProfile!: pulumi.Output<{ dnsServiceIp: string, dockerBridgeCidr: string, networkPlugin: string, networkPolicy: string, podCidr: string, serviceCidr: string }>;
    /**
     * The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.
     */
    public /*out*/ readonly nodeResourceGroup!: pulumi.Output<string>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `role_based_access_control` block. Changing this forces a new resource to be created.
     */
    public readonly roleBasedAccessControl!: pulumi.Output<{ azureActiveDirectory?: { clientAppId: string, serverAppId: string, serverAppSecret: string, tenantId: string }, enabled: boolean }>;
    /**
     * A `service_principal` block as documented below.
     */
    public readonly servicePrincipal!: pulumi.Output<{ clientId: string, clientSecret: string }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a KubernetesCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KubernetesClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KubernetesClusterArgs | KubernetesClusterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as KubernetesClusterState | undefined;
            inputs["addonProfile"] = state ? state.addonProfile : undefined;
            inputs["agentPoolProfile"] = state ? state.agentPoolProfile : undefined;
            inputs["apiServerAuthorizedIpRanges"] = state ? state.apiServerAuthorizedIpRanges : undefined;
            inputs["dnsPrefix"] = state ? state.dnsPrefix : undefined;
            inputs["fqdn"] = state ? state.fqdn : undefined;
            inputs["kubeAdminConfig"] = state ? state.kubeAdminConfig : undefined;
            inputs["kubeAdminConfigRaw"] = state ? state.kubeAdminConfigRaw : undefined;
            inputs["kubeConfig"] = state ? state.kubeConfig : undefined;
            inputs["kubeConfigRaw"] = state ? state.kubeConfigRaw : undefined;
            inputs["kubernetesVersion"] = state ? state.kubernetesVersion : undefined;
            inputs["linuxProfile"] = state ? state.linuxProfile : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkProfile"] = state ? state.networkProfile : undefined;
            inputs["nodeResourceGroup"] = state ? state.nodeResourceGroup : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["roleBasedAccessControl"] = state ? state.roleBasedAccessControl : undefined;
            inputs["servicePrincipal"] = state ? state.servicePrincipal : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as KubernetesClusterArgs | undefined;
            if (!args || args.agentPoolProfile === undefined) {
                throw new Error("Missing required property 'agentPoolProfile'");
            }
            if (!args || args.dnsPrefix === undefined) {
                throw new Error("Missing required property 'dnsPrefix'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.servicePrincipal === undefined) {
                throw new Error("Missing required property 'servicePrincipal'");
            }
            inputs["addonProfile"] = args ? args.addonProfile : undefined;
            inputs["agentPoolProfile"] = args ? args.agentPoolProfile : undefined;
            inputs["apiServerAuthorizedIpRanges"] = args ? args.apiServerAuthorizedIpRanges : undefined;
            inputs["dnsPrefix"] = args ? args.dnsPrefix : undefined;
            inputs["kubernetesVersion"] = args ? args.kubernetesVersion : undefined;
            inputs["linuxProfile"] = args ? args.linuxProfile : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkProfile"] = args ? args.networkProfile : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["roleBasedAccessControl"] = args ? args.roleBasedAccessControl : undefined;
            inputs["servicePrincipal"] = args ? args.servicePrincipal : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["fqdn"] = undefined /*out*/;
            inputs["kubeAdminConfig"] = undefined /*out*/;
            inputs["kubeAdminConfigRaw"] = undefined /*out*/;
            inputs["kubeConfig"] = undefined /*out*/;
            inputs["kubeConfigRaw"] = undefined /*out*/;
            inputs["nodeResourceGroup"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super("azure:containerservice/kubernetesCluster:KubernetesCluster", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KubernetesCluster resources.
 */
export interface KubernetesClusterState {
    /**
     * A `addon_profile` block.
     */
    readonly addonProfile?: pulumi.Input<{ aciConnectorLinux?: pulumi.Input<{ enabled: pulumi.Input<boolean>, subnetName: pulumi.Input<string> }>, httpApplicationRouting?: pulumi.Input<{ enabled: pulumi.Input<boolean>, httpApplicationRoutingZoneName?: pulumi.Input<string> }>, omsAgent?: pulumi.Input<{ enabled: pulumi.Input<boolean>, logAnalyticsWorkspaceId: pulumi.Input<string> }> }>;
    /**
     * An `agent_pool_profile` block.  Currently only one agent pool can exist.
     */
    readonly agentPoolProfile?: pulumi.Input<{ count?: pulumi.Input<number>, dnsPrefix?: pulumi.Input<string>, fqdn?: pulumi.Input<string>, maxPods?: pulumi.Input<number>, name: pulumi.Input<string>, osDiskSizeGb?: pulumi.Input<number>, osType?: pulumi.Input<string>, type?: pulumi.Input<string>, vmSize: pulumi.Input<string>, vnetSubnetId?: pulumi.Input<string> }>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    readonly apiServerAuthorizedIpRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    readonly dnsPrefix?: pulumi.Input<string>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    readonly fqdn?: pulumi.Input<string>;
    /**
     * A `kube_admin_config` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfig?: pulumi.Input<{ clientCertificate?: pulumi.Input<string>, clientKey?: pulumi.Input<string>, clusterCaCertificate?: pulumi.Input<string>, host?: pulumi.Input<string>, password?: pulumi.Input<string>, username?: pulumi.Input<string> }>;
    /**
     * Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfigRaw?: pulumi.Input<string>;
    /**
     * A `kube_config` block as defined below.
     */
    readonly kubeConfig?: pulumi.Input<{ clientCertificate?: pulumi.Input<string>, clientKey?: pulumi.Input<string>, clusterCaCertificate?: pulumi.Input<string>, host?: pulumi.Input<string>, password?: pulumi.Input<string>, username?: pulumi.Input<string> }>;
    /**
     * Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
     */
    readonly kubeConfigRaw?: pulumi.Input<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A `linux_profile` block.
     */
    readonly linuxProfile?: pulumi.Input<{ adminUsername: pulumi.Input<string>, sshKey: pulumi.Input<{ keyData: pulumi.Input<string> }> }>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `network_profile` block.
     */
    readonly networkProfile?: pulumi.Input<{ dnsServiceIp?: pulumi.Input<string>, dockerBridgeCidr?: pulumi.Input<string>, networkPlugin: pulumi.Input<string>, networkPolicy?: pulumi.Input<string>, podCidr?: pulumi.Input<string>, serviceCidr?: pulumi.Input<string> }>;
    /**
     * The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.
     */
    readonly nodeResourceGroup?: pulumi.Input<string>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `role_based_access_control` block. Changing this forces a new resource to be created.
     */
    readonly roleBasedAccessControl?: pulumi.Input<{ azureActiveDirectory?: pulumi.Input<{ clientAppId: pulumi.Input<string>, serverAppId: pulumi.Input<string>, serverAppSecret: pulumi.Input<string>, tenantId?: pulumi.Input<string> }>, enabled: pulumi.Input<boolean> }>;
    /**
     * A `service_principal` block as documented below.
     */
    readonly servicePrincipal?: pulumi.Input<{ clientId: pulumi.Input<string>, clientSecret: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a KubernetesCluster resource.
 */
export interface KubernetesClusterArgs {
    /**
     * A `addon_profile` block.
     */
    readonly addonProfile?: pulumi.Input<{ aciConnectorLinux?: pulumi.Input<{ enabled: pulumi.Input<boolean>, subnetName: pulumi.Input<string> }>, httpApplicationRouting?: pulumi.Input<{ enabled: pulumi.Input<boolean>, httpApplicationRoutingZoneName?: pulumi.Input<string> }>, omsAgent?: pulumi.Input<{ enabled: pulumi.Input<boolean>, logAnalyticsWorkspaceId: pulumi.Input<string> }> }>;
    /**
     * An `agent_pool_profile` block.  Currently only one agent pool can exist.
     */
    readonly agentPoolProfile: pulumi.Input<{ count?: pulumi.Input<number>, dnsPrefix?: pulumi.Input<string>, fqdn?: pulumi.Input<string>, maxPods?: pulumi.Input<number>, name: pulumi.Input<string>, osDiskSizeGb?: pulumi.Input<number>, osType?: pulumi.Input<string>, type?: pulumi.Input<string>, vmSize: pulumi.Input<string>, vnetSubnetId?: pulumi.Input<string> }>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    readonly apiServerAuthorizedIpRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    readonly dnsPrefix: pulumi.Input<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A `linux_profile` block.
     */
    readonly linuxProfile?: pulumi.Input<{ adminUsername: pulumi.Input<string>, sshKey: pulumi.Input<{ keyData: pulumi.Input<string> }> }>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `network_profile` block.
     */
    readonly networkProfile?: pulumi.Input<{ dnsServiceIp?: pulumi.Input<string>, dockerBridgeCidr?: pulumi.Input<string>, networkPlugin: pulumi.Input<string>, networkPolicy?: pulumi.Input<string>, podCidr?: pulumi.Input<string>, serviceCidr?: pulumi.Input<string> }>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `role_based_access_control` block. Changing this forces a new resource to be created.
     */
    readonly roleBasedAccessControl?: pulumi.Input<{ azureActiveDirectory?: pulumi.Input<{ clientAppId: pulumi.Input<string>, serverAppId: pulumi.Input<string>, serverAppSecret: pulumi.Input<string>, tenantId?: pulumi.Input<string> }>, enabled: pulumi.Input<boolean> }>;
    /**
     * A `service_principal` block as documented below.
     */
    readonly servicePrincipal: pulumi.Input<{ clientId: pulumi.Input<string>, clientSecret: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
