// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a virtual network including any configured subnets. Each subnet can
// optionally be configured with a security group to be associated with the subnet.
// 
// > **NOTE on Virtual Networks and Subnet's:** This provider currently
// provides both a standalone Subnet resource, and allows for Subnets to be defined in-line within the Virtual Network resource.
// At this time you cannot use a Virtual Network with in-line Subnets in conjunction with any Subnet resources. Doing so will cause a conflict of Subnet configurations and will overwrite Subnet's.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/virtual_network.html.markdown.
type VirtualNetwork struct {
	s *pulumi.ResourceState
}

// NewVirtualNetwork registers a new resource with the given unique name, arguments, and options.
func NewVirtualNetwork(ctx *pulumi.Context,
	name string, args *VirtualNetworkArgs, opts ...pulumi.ResourceOpt) (*VirtualNetwork, error) {
	if args == nil || args.AddressSpaces == nil {
		return nil, errors.New("missing required argument 'AddressSpaces'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["addressSpaces"] = nil
		inputs["ddosProtectionPlan"] = nil
		inputs["dnsServers"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["subnets"] = nil
		inputs["tags"] = nil
	} else {
		inputs["addressSpaces"] = args.AddressSpaces
		inputs["ddosProtectionPlan"] = args.DdosProtectionPlan
		inputs["dnsServers"] = args.DnsServers
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["subnets"] = args.Subnets
		inputs["tags"] = args.Tags
	}
	s, err := ctx.RegisterResource("azure:network/virtualNetwork:VirtualNetwork", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &VirtualNetwork{s: s}, nil
}

// GetVirtualNetwork gets an existing VirtualNetwork resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualNetwork(ctx *pulumi.Context,
	name string, id pulumi.ID, state *VirtualNetworkState, opts ...pulumi.ResourceOpt) (*VirtualNetwork, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["addressSpaces"] = state.AddressSpaces
		inputs["ddosProtectionPlan"] = state.DdosProtectionPlan
		inputs["dnsServers"] = state.DnsServers
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["subnets"] = state.Subnets
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:network/virtualNetwork:VirtualNetwork", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &VirtualNetwork{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *VirtualNetwork) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *VirtualNetwork) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The address space that is used the virtual
// network. You can supply more than one address space. Changing this forces
// a new resource to be created.
func (r *VirtualNetwork) AddressSpaces() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["addressSpaces"])
}

// A `ddosProtectionPlan` block as documented below.
func (r *VirtualNetwork) DdosProtectionPlan() *pulumi.Output {
	return r.s.State["ddosProtectionPlan"]
}

// List of IP addresses of DNS servers
func (r *VirtualNetwork) DnsServers() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["dnsServers"])
}

// The location/region where the virtual network is
// created. Changing this forces a new resource to be created.
func (r *VirtualNetwork) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The name of the virtual network. Changing this forces a
// new resource to be created.
func (r *VirtualNetwork) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the resource group in which to
// create the virtual network.
func (r *VirtualNetwork) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Can be specified multiple times to define multiple
// subnets. Each `subnet` block supports fields documented below.
func (r *VirtualNetwork) Subnets() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["subnets"])
}

// A mapping of tags to assign to the resource.
func (r *VirtualNetwork) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering VirtualNetwork resources.
type VirtualNetworkState struct {
	// The address space that is used the virtual
	// network. You can supply more than one address space. Changing this forces
	// a new resource to be created.
	AddressSpaces interface{}
	// A `ddosProtectionPlan` block as documented below.
	DdosProtectionPlan interface{}
	// List of IP addresses of DNS servers
	DnsServers interface{}
	// The location/region where the virtual network is
	// created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the virtual network. Changing this forces a
	// new resource to be created.
	Name interface{}
	// The name of the resource group in which to
	// create the virtual network.
	ResourceGroupName interface{}
	// Can be specified multiple times to define multiple
	// subnets. Each `subnet` block supports fields documented below.
	Subnets interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a VirtualNetwork resource.
type VirtualNetworkArgs struct {
	// The address space that is used the virtual
	// network. You can supply more than one address space. Changing this forces
	// a new resource to be created.
	AddressSpaces interface{}
	// A `ddosProtectionPlan` block as documented below.
	DdosProtectionPlan interface{}
	// List of IP addresses of DNS servers
	DnsServers interface{}
	// The location/region where the virtual network is
	// created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the virtual network. Changing this forces a
	// new resource to be created.
	Name interface{}
	// The name of the resource group in which to
	// create the virtual network.
	ResourceGroupName interface{}
	// Can be specified multiple times to define multiple
	// subnets. Each `subnet` block supports fields documented below.
	Subnets interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
