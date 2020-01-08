// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package privatelink

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Private Link Service.
// 
// > **NOTE** Private Link is currently in Public Preview.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/private_link_service.html.markdown.
func LookupService(ctx *pulumi.Context, args *GetServiceArgs) (*GetServiceResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:privatelink/getService:getService", inputs)
	if err != nil {
		return nil, err
	}
	return &GetServiceResult{
		Alias: outputs["alias"],
		AutoApprovalSubscriptionIds: outputs["autoApprovalSubscriptionIds"],
		EnableProxyProtocol: outputs["enableProxyProtocol"],
		LoadBalancerFrontendIpConfigurationIds: outputs["loadBalancerFrontendIpConfigurationIds"],
		Location: outputs["location"],
		Name: outputs["name"],
		NatIpConfiguration: outputs["natIpConfiguration"],
		NetworkInterfaceIds: outputs["networkInterfaceIds"],
		ResourceGroupName: outputs["resourceGroupName"],
		Tags: outputs["tags"],
		VisibilitySubscriptionIds: outputs["visibilitySubscriptionIds"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getService.
type GetServiceArgs struct {
	// The name of the private link service.
	Name interface{}
	// The name of the resource group in which the private link service resides.
	ResourceGroupName interface{}
}

// A collection of values returned by getService.
type GetServiceResult struct {
	// The alias is a globally unique name for your private link service which Azure generates for you. Your can use this alias to request a connection to your private link service.
	Alias interface{}
	// The list of subscription(s) globally unique identifiers that will be auto approved to use the private link service.
	AutoApprovalSubscriptionIds interface{}
	// Does the Private Link Service support the Proxy Protocol?
	EnableProxyProtocol interface{}
	// The list of Standard Load Balancer(SLB) resource IDs. The Private Link service is tied to the frontend IP address of a SLB. All traffic destined for the private link service will reach the frontend of the SLB. You can configure SLB rules to direct this traffic to appropriate backend pools where your applications are running.
	LoadBalancerFrontendIpConfigurationIds interface{}
	// The supported Azure location where the resource exists.
	Location interface{}
	// The name of private link service NAT IP configuration.
	Name interface{}
	// The `natIpConfiguration` block as defined below.
	NatIpConfiguration interface{}
	NetworkInterfaceIds interface{}
	ResourceGroupName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// The list of subscription(s) globally unique identifiers(GUID) that will be able to see the private link service.
	VisibilitySubscriptionIds interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
