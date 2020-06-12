// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lb

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Load Balancer's Backend Address Pool.
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
// 		exampleLB, err := lb.LookupLB(ctx, &lb.LookupLBArgs{
// 			Name:              "example-lb",
// 			ResourceGroupName: "example-resources",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleBackendAddressPool, err := lb.LookupBackendAddressPool(ctx, &lb.LookupBackendAddressPoolArgs{
// 			Name:           "first",
// 			LoadbalancerId: exampleLB.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("backendAddressPoolId", exampleBackendAddressPool.Id)
// 		ctx.Export("backendIpConfigurationIds")
// 		return nil
// 	})
// }
// ```
func LookupBackendAddressPool(ctx *pulumi.Context, args *LookupBackendAddressPoolArgs, opts ...pulumi.InvokeOption) (*LookupBackendAddressPoolResult, error) {
	var rv LookupBackendAddressPoolResult
	err := ctx.Invoke("azure:lb/getBackendAddressPool:getBackendAddressPool", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackendAddressPool.
type LookupBackendAddressPoolArgs struct {
	// The ID of the Load Balancer in which the Backend Address Pool exists.
	LoadbalancerId string `pulumi:"loadbalancerId"`
	// Specifies the name of the Backend Address Pool.
	Name string `pulumi:"name"`
}

// A collection of values returned by getBackendAddressPool.
type LookupBackendAddressPoolResult struct {
	// An array of references to IP addresses defined in network interfaces.
	BackendIpConfigurations []GetBackendAddressPoolBackendIpConfiguration `pulumi:"backendIpConfigurations"`
	// The provider-assigned unique ID for this managed resource.
	Id             string `pulumi:"id"`
	LoadbalancerId string `pulumi:"loadbalancerId"`
	// The name of the Backend Address Pool.
	Name string `pulumi:"name"`
}
