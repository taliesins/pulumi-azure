// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package containerservice

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a managed Kubernetes Cluster (AKS)
// 
// ~> **Note:** All arguments including the client secret will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
type KubernetesCluster struct {
	s *pulumi.ResourceState
}

// NewKubernetesCluster registers a new resource with the given unique name, arguments, and options.
func NewKubernetesCluster(ctx *pulumi.Context,
	name string, args *KubernetesClusterArgs, opts ...pulumi.ResourceOpt) (*KubernetesCluster, error) {
	if args == nil || args.AgentPoolProfile == nil {
		return nil, errors.New("missing required argument 'AgentPoolProfile'")
	}
	if args == nil || args.DnsPrefix == nil {
		return nil, errors.New("missing required argument 'DnsPrefix'")
	}
	if args == nil || args.LinuxProfile == nil {
		return nil, errors.New("missing required argument 'LinuxProfile'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServicePrincipal == nil {
		return nil, errors.New("missing required argument 'ServicePrincipal'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["addonProfile"] = nil
		inputs["agentPoolProfile"] = nil
		inputs["dnsPrefix"] = nil
		inputs["enableRbac"] = nil
		inputs["kubernetesVersion"] = nil
		inputs["linuxProfile"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["networkProfile"] = nil
		inputs["resourceGroupName"] = nil
		inputs["servicePrincipal"] = nil
		inputs["tags"] = nil
	} else {
		inputs["addonProfile"] = args.AddonProfile
		inputs["agentPoolProfile"] = args.AgentPoolProfile
		inputs["dnsPrefix"] = args.DnsPrefix
		inputs["enableRbac"] = args.EnableRbac
		inputs["kubernetesVersion"] = args.KubernetesVersion
		inputs["linuxProfile"] = args.LinuxProfile
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["networkProfile"] = args.NetworkProfile
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["servicePrincipal"] = args.ServicePrincipal
		inputs["tags"] = args.Tags
	}
	inputs["fqdn"] = nil
	inputs["kubeConfig"] = nil
	inputs["kubeConfigRaw"] = nil
	inputs["nodeResourceGroup"] = nil
	s, err := ctx.RegisterResource("azure:containerservice/kubernetesCluster:KubernetesCluster", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KubernetesCluster{s: s}, nil
}

// GetKubernetesCluster gets an existing KubernetesCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubernetesCluster(ctx *pulumi.Context,
	name string, id pulumi.ID, state *KubernetesClusterState, opts ...pulumi.ResourceOpt) (*KubernetesCluster, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["addonProfile"] = state.AddonProfile
		inputs["agentPoolProfile"] = state.AgentPoolProfile
		inputs["dnsPrefix"] = state.DnsPrefix
		inputs["enableRbac"] = state.EnableRbac
		inputs["fqdn"] = state.Fqdn
		inputs["kubeConfig"] = state.KubeConfig
		inputs["kubeConfigRaw"] = state.KubeConfigRaw
		inputs["kubernetesVersion"] = state.KubernetesVersion
		inputs["linuxProfile"] = state.LinuxProfile
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["networkProfile"] = state.NetworkProfile
		inputs["nodeResourceGroup"] = state.NodeResourceGroup
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["servicePrincipal"] = state.ServicePrincipal
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:containerservice/kubernetesCluster:KubernetesCluster", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KubernetesCluster{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *KubernetesCluster) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *KubernetesCluster) ID() *pulumi.IDOutput {
	return r.s.ID
}

// A `addon_profile` block.
func (r *KubernetesCluster) AddonProfile() *pulumi.Output {
	return r.s.State["addonProfile"]
}

// One or more Agent Pool Profile's block as documented below.
func (r *KubernetesCluster) AgentPoolProfile() *pulumi.Output {
	return r.s.State["agentPoolProfile"]
}

// DNS prefix specified when creating the managed cluster.
func (r *KubernetesCluster) DnsPrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dnsPrefix"])
}

// True or False. Enables or Disables Kubernetes Role Based Access Control (RBAC). Defaults to True. Changing this forces a new resource to be created.
func (r *KubernetesCluster) EnableRbac() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["enableRbac"])
}

// The FQDN of the Azure Kubernetes Managed Cluster.
func (r *KubernetesCluster) Fqdn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["fqdn"])
}

// A `kube_config` block as defined below.
func (r *KubernetesCluster) KubeConfig() *pulumi.Output {
	return r.s.State["kubeConfig"]
}

// Raw Kubernetes config to be used by
// [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and
// other compatible tools
func (r *KubernetesCluster) KubeConfigRaw() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kubeConfigRaw"])
}

// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
func (r *KubernetesCluster) KubernetesVersion() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kubernetesVersion"])
}

// A Linux Profile block as documented below.
func (r *KubernetesCluster) LinuxProfile() *pulumi.Output {
	return r.s.State["linuxProfile"]
}

// The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
func (r *KubernetesCluster) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The name of the AKS Managed Cluster instance to create. Changing this forces a new resource to be created.
func (r *KubernetesCluster) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A Network Profile block as documented below.
func (r *KubernetesCluster) NetworkProfile() *pulumi.Output {
	return r.s.State["networkProfile"]
}

// Auto-generated Resource Group containing AKS Cluster resources.
func (r *KubernetesCluster) NodeResourceGroup() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["nodeResourceGroup"])
}

// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
func (r *KubernetesCluster) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A Service Principal block as documented below.
func (r *KubernetesCluster) ServicePrincipal() *pulumi.Output {
	return r.s.State["servicePrincipal"]
}

// A mapping of tags to assign to the resource.
func (r *KubernetesCluster) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering KubernetesCluster resources.
type KubernetesClusterState struct {
	// A `addon_profile` block.
	AddonProfile interface{}
	// One or more Agent Pool Profile's block as documented below.
	AgentPoolProfile interface{}
	// DNS prefix specified when creating the managed cluster.
	DnsPrefix interface{}
	// True or False. Enables or Disables Kubernetes Role Based Access Control (RBAC). Defaults to True. Changing this forces a new resource to be created.
	EnableRbac interface{}
	// The FQDN of the Azure Kubernetes Managed Cluster.
	Fqdn interface{}
	// A `kube_config` block as defined below.
	KubeConfig interface{}
	// Raw Kubernetes config to be used by
	// [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and
	// other compatible tools
	KubeConfigRaw interface{}
	// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
	KubernetesVersion interface{}
	// A Linux Profile block as documented below.
	LinuxProfile interface{}
	// The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the AKS Managed Cluster instance to create. Changing this forces a new resource to be created.
	Name interface{}
	// A Network Profile block as documented below.
	NetworkProfile interface{}
	// Auto-generated Resource Group containing AKS Cluster resources.
	NodeResourceGroup interface{}
	// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A Service Principal block as documented below.
	ServicePrincipal interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a KubernetesCluster resource.
type KubernetesClusterArgs struct {
	// A `addon_profile` block.
	AddonProfile interface{}
	// One or more Agent Pool Profile's block as documented below.
	AgentPoolProfile interface{}
	// DNS prefix specified when creating the managed cluster.
	DnsPrefix interface{}
	// True or False. Enables or Disables Kubernetes Role Based Access Control (RBAC). Defaults to True. Changing this forces a new resource to be created.
	EnableRbac interface{}
	// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
	KubernetesVersion interface{}
	// A Linux Profile block as documented below.
	LinuxProfile interface{}
	// The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the AKS Managed Cluster instance to create. Changing this forces a new resource to be created.
	Name interface{}
	// A Network Profile block as documented below.
	NetworkProfile interface{}
	// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A Service Principal block as documented below.
	ServicePrincipal interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
