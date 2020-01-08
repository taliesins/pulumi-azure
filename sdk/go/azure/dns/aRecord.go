// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dns

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Enables you to manage DNS A Records within Azure DNS.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/dns_a_record.html.markdown.
type ARecord struct {
	s *pulumi.ResourceState
}

// NewARecord registers a new resource with the given unique name, arguments, and options.
func NewARecord(ctx *pulumi.Context,
	name string, args *ARecordArgs, opts ...pulumi.ResourceOpt) (*ARecord, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Ttl == nil {
		return nil, errors.New("missing required argument 'Ttl'")
	}
	if args == nil || args.ZoneName == nil {
		return nil, errors.New("missing required argument 'ZoneName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["name"] = nil
		inputs["records"] = nil
		inputs["resourceGroupName"] = nil
		inputs["tags"] = nil
		inputs["targetResourceId"] = nil
		inputs["ttl"] = nil
		inputs["zoneName"] = nil
	} else {
		inputs["name"] = args.Name
		inputs["records"] = args.Records
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
		inputs["targetResourceId"] = args.TargetResourceId
		inputs["ttl"] = args.Ttl
		inputs["zoneName"] = args.ZoneName
	}
	inputs["fqdn"] = nil
	s, err := ctx.RegisterResource("azure:dns/aRecord:ARecord", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ARecord{s: s}, nil
}

// GetARecord gets an existing ARecord resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetARecord(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ARecordState, opts ...pulumi.ResourceOpt) (*ARecord, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["fqdn"] = state.Fqdn
		inputs["name"] = state.Name
		inputs["records"] = state.Records
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["tags"] = state.Tags
		inputs["targetResourceId"] = state.TargetResourceId
		inputs["ttl"] = state.Ttl
		inputs["zoneName"] = state.ZoneName
	}
	s, err := ctx.ReadResource("azure:dns/aRecord:ARecord", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ARecord{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ARecord) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ARecord) ID() pulumi.IDOutput {
	return r.s.ID()
}

// The FQDN of the DNS A Record.
func (r *ARecord) Fqdn() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["fqdn"])
}

// The name of the DNS A Record.
func (r *ARecord) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// List of IPv4 Addresses. Conflicts with `targetResourceId`.
func (r *ARecord) Records() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["records"])
}

// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
func (r *ARecord) ResourceGroupName() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A mapping of tags to assign to the resource.
func (r *ARecord) Tags() pulumi.MapOutput {
	return (pulumi.MapOutput)(r.s.State["tags"])
}

// The Azure resource id of the target object. Conflicts with `records`
func (r *ARecord) TargetResourceId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["targetResourceId"])
}

func (r *ARecord) Ttl() pulumi.IntOutput {
	return (pulumi.IntOutput)(r.s.State["ttl"])
}

// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
func (r *ARecord) ZoneName() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["zoneName"])
}

// Input properties used for looking up and filtering ARecord resources.
type ARecordState struct {
	// The FQDN of the DNS A Record.
	Fqdn interface{}
	// The name of the DNS A Record.
	Name interface{}
	// List of IPv4 Addresses. Conflicts with `targetResourceId`.
	Records interface{}
	// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The Azure resource id of the target object. Conflicts with `records`
	TargetResourceId interface{}
	Ttl interface{}
	// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
	ZoneName interface{}
}

// The set of arguments for constructing a ARecord resource.
type ARecordArgs struct {
	// The name of the DNS A Record.
	Name interface{}
	// List of IPv4 Addresses. Conflicts with `targetResourceId`.
	Records interface{}
	// Specifies the resource group where the DNS Zone (parent resource) exists. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The Azure resource id of the target object. Conflicts with `records`
	TargetResourceId interface{}
	Ttl interface{}
	// Specifies the DNS Zone where the resource exists. Changing this forces a new resource to be created.
	ZoneName interface{}
}
