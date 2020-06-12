// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eventhub

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing EventHub Namespace.
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
// 		example, err := eventhub.LookupNamespace(ctx, &eventhub.LookupNamespaceArgs{
// 			Name:              "search-eventhubns",
// 			ResourceGroupName: "search-service",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("eventhubNamespaceId", example.Id)
// 		return nil
// 	})
// }
// ```
//
// Deprecated: azure.eventhub.getEventhubNamespace has been deprecated in favor of azure.eventhub.getNamespace
func GetEventhubNamespace(ctx *pulumi.Context, args *GetEventhubNamespaceArgs, opts ...pulumi.InvokeOption) (*GetEventhubNamespaceResult, error) {
	var rv GetEventhubNamespaceResult
	err := ctx.Invoke("azure:eventhub/getEventhubNamespace:getEventhubNamespace", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEventhubNamespace.
type GetEventhubNamespaceArgs struct {
	// The name of the EventHub Namespace.
	Name string `pulumi:"name"`
	// The Name of the Resource Group where the EventHub Namespace exists.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A collection of values returned by getEventhubNamespace.
type GetEventhubNamespaceResult struct {
	// Is Auto Inflate enabled for the EventHub Namespace?
	AutoInflateEnabled bool `pulumi:"autoInflateEnabled"`
	// The Capacity / Throughput Units for a `Standard` SKU namespace.
	Capacity int `pulumi:"capacity"`
	// The primary connection string for the authorization
	// rule `RootManageSharedAccessKey`.
	DefaultPrimaryConnectionString string `pulumi:"defaultPrimaryConnectionString"`
	// The alias of the primary connection string for the authorization
	// rule `RootManageSharedAccessKey`.
	DefaultPrimaryConnectionStringAlias string `pulumi:"defaultPrimaryConnectionStringAlias"`
	// The primary access key for the authorization rule `RootManageSharedAccessKey`.
	DefaultPrimaryKey string `pulumi:"defaultPrimaryKey"`
	// The secondary connection string for the
	// authorization rule `RootManageSharedAccessKey`.
	DefaultSecondaryConnectionString string `pulumi:"defaultSecondaryConnectionString"`
	// The alias of the secondary connection string for the
	// authorization rule `RootManageSharedAccessKey`.
	DefaultSecondaryConnectionStringAlias string `pulumi:"defaultSecondaryConnectionStringAlias"`
	// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
	DefaultSecondaryKey string `pulumi:"defaultSecondaryKey"`
	// The provider-assigned unique ID for this managed resource.
	Id           string `pulumi:"id"`
	KafkaEnabled bool   `pulumi:"kafkaEnabled"`
	// The Azure location where the EventHub Namespace exists
	Location string `pulumi:"location"`
	// Specifies the maximum number of throughput units when Auto Inflate is Enabled.
	MaximumThroughputUnits int    `pulumi:"maximumThroughputUnits"`
	Name                   string `pulumi:"name"`
	ResourceGroupName      string `pulumi:"resourceGroupName"`
	// Defines which tier to use.
	Sku string `pulumi:"sku"`
	// A mapping of tags to assign to the EventHub Namespace.
	Tags map[string]string `pulumi:"tags"`
}
