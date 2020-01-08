// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appconfiguration

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Azure App Configuration.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/app_configuration.html.markdown.
type ConfigurationStore struct {
	s *pulumi.ResourceState
}

// NewConfigurationStore registers a new resource with the given unique name, arguments, and options.
func NewConfigurationStore(ctx *pulumi.Context,
	name string, args *ConfigurationStoreArgs, opts ...pulumi.ResourceOpt) (*ConfigurationStore, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["sku"] = nil
		inputs["tags"] = nil
	} else {
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["sku"] = args.Sku
		inputs["tags"] = args.Tags
	}
	inputs["endpoint"] = nil
	inputs["primaryReadKeys"] = nil
	inputs["primaryWriteKeys"] = nil
	inputs["secondaryReadKeys"] = nil
	inputs["secondaryWriteKeys"] = nil
	s, err := ctx.RegisterResource("azure:appconfiguration/configurationStore:ConfigurationStore", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ConfigurationStore{s: s}, nil
}

// GetConfigurationStore gets an existing ConfigurationStore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigurationStore(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ConfigurationStoreState, opts ...pulumi.ResourceOpt) (*ConfigurationStore, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["endpoint"] = state.Endpoint
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["primaryReadKeys"] = state.PrimaryReadKeys
		inputs["primaryWriteKeys"] = state.PrimaryWriteKeys
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["secondaryReadKeys"] = state.SecondaryReadKeys
		inputs["secondaryWriteKeys"] = state.SecondaryWriteKeys
		inputs["sku"] = state.Sku
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:appconfiguration/configurationStore:ConfigurationStore", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ConfigurationStore{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ConfigurationStore) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ConfigurationStore) ID() pulumi.IDOutput {
	return r.s.ID()
}

// The URL of the App Configuration.
func (r *ConfigurationStore) Endpoint() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["endpoint"])
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *ConfigurationStore) Location() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the App Configuration. Changing this forces a new resource to be created.
func (r *ConfigurationStore) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// An `accessKey` block as defined below containing the primary read access key.
func (r *ConfigurationStore) PrimaryReadKeys() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["primaryReadKeys"])
}

// An `accessKey` block as defined below containing the primary write access key.
func (r *ConfigurationStore) PrimaryWriteKeys() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["primaryWriteKeys"])
}

// The name of the resource group in which to create the App Configuration. Changing this forces a new resource to be created.
func (r *ConfigurationStore) ResourceGroupName() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// An `accessKey` block as defined below containing the secondary read access key.
func (r *ConfigurationStore) SecondaryReadKeys() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["secondaryReadKeys"])
}

// An `accessKey` block as defined below containing the secondary write access key.
func (r *ConfigurationStore) SecondaryWriteKeys() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["secondaryWriteKeys"])
}

// The SKU name of the the App Configuration. Possible values are `free` and `standard`.
func (r *ConfigurationStore) Sku() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["sku"])
}

// A mapping of tags to assign to the resource.
func (r *ConfigurationStore) Tags() pulumi.MapOutput {
	return (pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering ConfigurationStore resources.
type ConfigurationStoreState struct {
	// The URL of the App Configuration.
	Endpoint interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the App Configuration. Changing this forces a new resource to be created.
	Name interface{}
	// An `accessKey` block as defined below containing the primary read access key.
	PrimaryReadKeys interface{}
	// An `accessKey` block as defined below containing the primary write access key.
	PrimaryWriteKeys interface{}
	// The name of the resource group in which to create the App Configuration. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// An `accessKey` block as defined below containing the secondary read access key.
	SecondaryReadKeys interface{}
	// An `accessKey` block as defined below containing the secondary write access key.
	SecondaryWriteKeys interface{}
	// The SKU name of the the App Configuration. Possible values are `free` and `standard`.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a ConfigurationStore resource.
type ConfigurationStoreArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the App Configuration. Changing this forces a new resource to be created.
	Name interface{}
	// The name of the resource group in which to create the App Configuration. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// The SKU name of the the App Configuration. Possible values are `free` and `standard`.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
