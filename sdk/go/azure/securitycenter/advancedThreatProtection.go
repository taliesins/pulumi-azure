// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package securitycenter

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a resources Advanced Threat Protection setting.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/advanced_threat_protection.html.markdown.
type AdvancedThreatProtection struct {
	s *pulumi.ResourceState
}

// NewAdvancedThreatProtection registers a new resource with the given unique name, arguments, and options.
func NewAdvancedThreatProtection(ctx *pulumi.Context,
	name string, args *AdvancedThreatProtectionArgs, opts ...pulumi.ResourceOpt) (*AdvancedThreatProtection, error) {
	if args == nil || args.Enabled == nil {
		return nil, errors.New("missing required argument 'Enabled'")
	}
	if args == nil || args.TargetResourceId == nil {
		return nil, errors.New("missing required argument 'TargetResourceId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["enabled"] = nil
		inputs["targetResourceId"] = nil
	} else {
		inputs["enabled"] = args.Enabled
		inputs["targetResourceId"] = args.TargetResourceId
	}
	s, err := ctx.RegisterResource("azure:securitycenter/advancedThreatProtection:AdvancedThreatProtection", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &AdvancedThreatProtection{s: s}, nil
}

// GetAdvancedThreatProtection gets an existing AdvancedThreatProtection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAdvancedThreatProtection(ctx *pulumi.Context,
	name string, id pulumi.ID, state *AdvancedThreatProtectionState, opts ...pulumi.ResourceOpt) (*AdvancedThreatProtection, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["enabled"] = state.Enabled
		inputs["targetResourceId"] = state.TargetResourceId
	}
	s, err := ctx.ReadResource("azure:securitycenter/advancedThreatProtection:AdvancedThreatProtection", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &AdvancedThreatProtection{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *AdvancedThreatProtection) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *AdvancedThreatProtection) ID() pulumi.IDOutput {
	return r.s.ID()
}

// Should Advanced Threat Protection be enabled on this resource?
func (r *AdvancedThreatProtection) Enabled() pulumi.BoolOutput {
	return (pulumi.BoolOutput)(r.s.State["enabled"])
}

// The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
func (r *AdvancedThreatProtection) TargetResourceId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["targetResourceId"])
}

// Input properties used for looking up and filtering AdvancedThreatProtection resources.
type AdvancedThreatProtectionState struct {
	// Should Advanced Threat Protection be enabled on this resource?
	Enabled interface{}
	// The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
	TargetResourceId interface{}
}

// The set of arguments for constructing a AdvancedThreatProtection resource.
type AdvancedThreatProtectionArgs struct {
	// Should Advanced Threat Protection be enabled on this resource?
	Enabled interface{}
	// The ID of the Azure Resource which to enable Advanced Threat Protection on. Changing this forces a new resource to be created.
	TargetResourceId interface{}
}
