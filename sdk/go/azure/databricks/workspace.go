// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package databricks

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Databricks Workspace
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/databricks"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.NewResourceGroup(ctx, "exampleResourceGroup", &core.ResourceGroupArgs{
// 			Location: pulumi.String("West US"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = databricks.NewWorkspace(ctx, "exampleWorkspace", &databricks.WorkspaceArgs{
// 			ResourceGroupName: exampleResourceGroup.Name,
// 			Location:          exampleResourceGroup.Location,
// 			Sku:               pulumi.String("standard"),
// 			Tags: pulumi.StringMap{
// 				"Environment": pulumi.String("Production"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Workspace struct {
	pulumi.CustomResourceState

	// A `customParameters` block as documented below.
	CustomParameters WorkspaceCustomParametersOutput `pulumi:"customParameters"`
	// Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.
	Location pulumi.StringOutput `pulumi:"location"`
	// The ID of the Managed Resource Group created by the Databricks Workspace.
	ManagedResourceGroupId pulumi.StringOutput `pulumi:"managedResourceGroupId"`
	// The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.
	ManagedResourceGroupName pulumi.StringOutput `pulumi:"managedResourceGroupName"`
	// Specifies the name of the Databricks Workspace resource. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The `sku` to use for the Databricks Workspace. Possible values are `standard`, `premium`, or `trial`. Changing this forces a new resource to be created.
	Sku pulumi.StringOutput `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The unique identifier of the databricks workspace in Databricks control plane.
	WorkspaceId pulumi.StringOutput `pulumi:"workspaceId"`
	// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
	WorkspaceUrl pulumi.StringOutput `pulumi:"workspaceUrl"`
}

// NewWorkspace registers a new resource with the given unique name, arguments, and options.
func NewWorkspace(ctx *pulumi.Context,
	name string, args *WorkspaceArgs, opts ...pulumi.ResourceOption) (*Workspace, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	if args == nil {
		args = &WorkspaceArgs{}
	}
	var resource Workspace
	err := ctx.RegisterResource("azure:databricks/workspace:Workspace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkspace gets an existing Workspace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkspace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkspaceState, opts ...pulumi.ResourceOption) (*Workspace, error) {
	var resource Workspace
	err := ctx.ReadResource("azure:databricks/workspace:Workspace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Workspace resources.
type workspaceState struct {
	// A `customParameters` block as documented below.
	CustomParameters *WorkspaceCustomParameters `pulumi:"customParameters"`
	// Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// The ID of the Managed Resource Group created by the Databricks Workspace.
	ManagedResourceGroupId *string `pulumi:"managedResourceGroupId"`
	// The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.
	ManagedResourceGroupName *string `pulumi:"managedResourceGroupName"`
	// Specifies the name of the Databricks Workspace resource. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The `sku` to use for the Databricks Workspace. Possible values are `standard`, `premium`, or `trial`. Changing this forces a new resource to be created.
	Sku *string `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// The unique identifier of the databricks workspace in Databricks control plane.
	WorkspaceId *string `pulumi:"workspaceId"`
	// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
	WorkspaceUrl *string `pulumi:"workspaceUrl"`
}

type WorkspaceState struct {
	// A `customParameters` block as documented below.
	CustomParameters WorkspaceCustomParametersPtrInput
	// Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// The ID of the Managed Resource Group created by the Databricks Workspace.
	ManagedResourceGroupId pulumi.StringPtrInput
	// The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.
	ManagedResourceGroupName pulumi.StringPtrInput
	// Specifies the name of the Databricks Workspace resource. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// The `sku` to use for the Databricks Workspace. Possible values are `standard`, `premium`, or `trial`. Changing this forces a new resource to be created.
	Sku pulumi.StringPtrInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// The unique identifier of the databricks workspace in Databricks control plane.
	WorkspaceId pulumi.StringPtrInput
	// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
	WorkspaceUrl pulumi.StringPtrInput
}

func (WorkspaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceState)(nil)).Elem()
}

type workspaceArgs struct {
	// A `customParameters` block as documented below.
	CustomParameters *WorkspaceCustomParameters `pulumi:"customParameters"`
	// Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.
	ManagedResourceGroupName *string `pulumi:"managedResourceGroupName"`
	// Specifies the name of the Databricks Workspace resource. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The `sku` to use for the Databricks Workspace. Possible values are `standard`, `premium`, or `trial`. Changing this forces a new resource to be created.
	Sku string `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Workspace resource.
type WorkspaceArgs struct {
	// A `customParameters` block as documented below.
	CustomParameters WorkspaceCustomParametersPtrInput
	// Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.
	ManagedResourceGroupName pulumi.StringPtrInput
	// Specifies the name of the Databricks Workspace resource. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// The `sku` to use for the Databricks Workspace. Possible values are `standard`, `premium`, or `trial`. Changing this forces a new resource to be created.
	Sku pulumi.StringInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapInput
}

func (WorkspaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workspaceArgs)(nil)).Elem()
}
