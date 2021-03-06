// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apimanagement

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an API Management Product Assignment to a Group.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/apimanagement"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleService, err := apimanagement.LookupService(ctx, &apimanagement.LookupServiceArgs{
// 			Name:              "example-api",
// 			ResourceGroupName: "example-resources",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleProduct, err := apimanagement.LookupProduct(ctx, &apimanagement.LookupProductArgs{
// 			ProductId:         "my-product",
// 			ApiManagementName: exampleService.Name,
// 			ResourceGroupName: exampleService.ResourceGroupName,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleGroup, err := apimanagement.LookupGroup(ctx, &apimanagement.LookupGroupArgs{
// 			Name:              "my-group",
// 			ApiManagementName: exampleService.Name,
// 			ResourceGroupName: exampleService.ResourceGroupName,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = apimanagement.NewProductGroup(ctx, "exampleProductGroup", &apimanagement.ProductGroupArgs{
// 			ProductId:         pulumi.String(exampleProduct.ProductId),
// 			GroupName:         pulumi.String(exampleGroup.Name),
// 			ApiManagementName: pulumi.String(exampleService.Name),
// 			ResourceGroupName: pulumi.String(exampleService.ResourceGroupName),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ProductGroup struct {
	pulumi.CustomResourceState

	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringOutput `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringOutput `pulumi:"groupName"`
	// The ID of the API Management Product within the API Management Service. Changing this forces a new resource to be created.
	ProductId pulumi.StringOutput `pulumi:"productId"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
}

// NewProductGroup registers a new resource with the given unique name, arguments, and options.
func NewProductGroup(ctx *pulumi.Context,
	name string, args *ProductGroupArgs, opts ...pulumi.ResourceOption) (*ProductGroup, error) {
	if args == nil || args.ApiManagementName == nil {
		return nil, errors.New("missing required argument 'ApiManagementName'")
	}
	if args == nil || args.GroupName == nil {
		return nil, errors.New("missing required argument 'GroupName'")
	}
	if args == nil || args.ProductId == nil {
		return nil, errors.New("missing required argument 'ProductId'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ProductGroupArgs{}
	}
	var resource ProductGroup
	err := ctx.RegisterResource("azure:apimanagement/productGroup:ProductGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProductGroup gets an existing ProductGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProductGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProductGroupState, opts ...pulumi.ResourceOption) (*ProductGroup, error) {
	var resource ProductGroup
	err := ctx.ReadResource("azure:apimanagement/productGroup:ProductGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProductGroup resources.
type productGroupState struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName *string `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName *string `pulumi:"groupName"`
	// The ID of the API Management Product within the API Management Service. Changing this forces a new resource to be created.
	ProductId *string `pulumi:"productId"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
}

type ProductGroupState struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringPtrInput
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringPtrInput
	// The ID of the API Management Product within the API Management Service. Changing this forces a new resource to be created.
	ProductId pulumi.StringPtrInput
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
}

func (ProductGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*productGroupState)(nil)).Elem()
}

type productGroupArgs struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName string `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName string `pulumi:"groupName"`
	// The ID of the API Management Product within the API Management Service. Changing this forces a new resource to be created.
	ProductId string `pulumi:"productId"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a ProductGroup resource.
type ProductGroupArgs struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringInput
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringInput
	// The ID of the API Management Product within the API Management Service. Changing this forces a new resource to be created.
	ProductId pulumi.StringInput
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
}

func (ProductGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*productGroupArgs)(nil)).Elem()
}
