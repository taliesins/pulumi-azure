// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apimanagement

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an API Management User Assignment to a Group.
//
//
// ## Example Usage
//
//
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
// 		exampleUser, err := apimanagement.LookupUser(ctx, &apimanagement.LookupUserArgs{
// 			UserId:            "my-user",
// 			ApiManagementName: "example-apim",
// 			ResourceGroupName: "search-service",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleGroupUser, err := apimanagement.NewGroupUser(ctx, "exampleGroupUser", &apimanagement.GroupUserArgs{
// 			UserId:            pulumi.String(exampleUser.Id),
// 			GroupName:         pulumi.String("example-group"),
// 			ResourceGroupName: pulumi.String(exampleUser.ResourceGroupName),
// 			ApiManagementName: pulumi.String(exampleUser.ApiManagementName),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type GroupUser struct {
	pulumi.CustomResourceState

	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringOutput `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringOutput `pulumi:"groupName"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The ID of the API Management User which should be assigned to this API Management Group. Changing this forces a new resource to be created.
	UserId pulumi.StringOutput `pulumi:"userId"`
}

// NewGroupUser registers a new resource with the given unique name, arguments, and options.
func NewGroupUser(ctx *pulumi.Context,
	name string, args *GroupUserArgs, opts ...pulumi.ResourceOption) (*GroupUser, error) {
	if args == nil || args.ApiManagementName == nil {
		return nil, errors.New("missing required argument 'ApiManagementName'")
	}
	if args == nil || args.GroupName == nil {
		return nil, errors.New("missing required argument 'GroupName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.UserId == nil {
		return nil, errors.New("missing required argument 'UserId'")
	}
	if args == nil {
		args = &GroupUserArgs{}
	}
	var resource GroupUser
	err := ctx.RegisterResource("azure:apimanagement/groupUser:GroupUser", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGroupUser gets an existing GroupUser resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGroupUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GroupUserState, opts ...pulumi.ResourceOption) (*GroupUser, error) {
	var resource GroupUser
	err := ctx.ReadResource("azure:apimanagement/groupUser:GroupUser", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GroupUser resources.
type groupUserState struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName *string `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName *string `pulumi:"groupName"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The ID of the API Management User which should be assigned to this API Management Group. Changing this forces a new resource to be created.
	UserId *string `pulumi:"userId"`
}

type GroupUserState struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringPtrInput
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringPtrInput
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// The ID of the API Management User which should be assigned to this API Management Group. Changing this forces a new resource to be created.
	UserId pulumi.StringPtrInput
}

func (GroupUserState) ElementType() reflect.Type {
	return reflect.TypeOf((*groupUserState)(nil)).Elem()
}

type groupUserArgs struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName string `pulumi:"apiManagementName"`
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName string `pulumi:"groupName"`
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The ID of the API Management User which should be assigned to this API Management Group. Changing this forces a new resource to be created.
	UserId string `pulumi:"userId"`
}

// The set of arguments for constructing a GroupUser resource.
type GroupUserArgs struct {
	// The name of the API Management Service. Changing this forces a new resource to be created.
	ApiManagementName pulumi.StringInput
	// The Name of the API Management Group within the API Management Service. Changing this forces a new resource to be created.
	GroupName pulumi.StringInput
	// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// The ID of the API Management User which should be assigned to this API Management Group. Changing this forces a new resource to be created.
	UserId pulumi.StringInput
}

func (GroupUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*groupUserArgs)(nil)).Elem()
}
