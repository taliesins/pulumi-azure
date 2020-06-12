// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package managementgroups

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Management Group.
//
// ## Example Usage
//
//
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		example, err := management.LookupGroup(ctx, &management.LookupGroupArgs{
// 			Name: "00000000-0000-0000-0000-000000000000",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("displayName", example.DisplayName)
// 		return nil
// 	})
// }
// ```
//
// Deprecated: azure.managementgroups.getManagementGroup has been deprecated in favor of azure.management.getGroup
func LookupManagementGroup(ctx *pulumi.Context, args *LookupManagementGroupArgs, opts ...pulumi.InvokeOption) (*LookupManagementGroupResult, error) {
	var rv LookupManagementGroupResult
	err := ctx.Invoke("azure:managementgroups/getManagementGroup:getManagementGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getManagementGroup.
type LookupManagementGroupArgs struct {
	// Specifies the name or UUID of this Management Group.
	//
	// Deprecated: Deprecated in favour of `name`
	GroupId *string `pulumi:"groupId"`
	// Specifies the name or UUID of this Management Group.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getManagementGroup.
type LookupManagementGroupResult struct {
	// A friendly name for the Management Group.
	DisplayName string `pulumi:"displayName"`
	// Deprecated: Deprecated in favour of `name`
	GroupId string `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// The ID of any Parent Management Group.
	ParentManagementGroupId string `pulumi:"parentManagementGroupId"`
	// A list of Subscription ID's which are assigned to the Management Group.
	SubscriptionIds []string `pulumi:"subscriptionIds"`
}
