// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package containerservice

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Azure Container Registry Webhook.
//
//
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/container_registry_webhook.html.markdown.
type RegistryWebhook struct {
	pulumi.CustomResourceState

	// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chartPush`, `chartDelete`
	Actions pulumi.StringArrayOutput `pulumi:"actions"`
	// Custom headers that will be added to the webhook notifications request.
	CustomHeaders pulumi.StringMapOutput `pulumi:"customHeaders"`
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringOutput `pulumi:"location"`
	// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
	RegistryName pulumi.StringOutput `pulumi:"registryName"`
	// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// Specifies the service URI for the Webhook to post notifications.
	ServiceUri pulumi.StringOutput `pulumi:"serviceUri"`
	// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
	Status pulumi.StringPtrOutput `pulumi:"status"`
	Tags   pulumi.StringMapOutput `pulumi:"tags"`
}

// NewRegistryWebhook registers a new resource with the given unique name, arguments, and options.
func NewRegistryWebhook(ctx *pulumi.Context,
	name string, args *RegistryWebhookArgs, opts ...pulumi.ResourceOption) (*RegistryWebhook, error) {
	if args == nil || args.Actions == nil {
		return nil, errors.New("missing required argument 'Actions'")
	}
	if args == nil || args.RegistryName == nil {
		return nil, errors.New("missing required argument 'RegistryName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceUri == nil {
		return nil, errors.New("missing required argument 'ServiceUri'")
	}
	if args == nil {
		args = &RegistryWebhookArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure:containerservice/registryWebook:RegistryWebook"),
		},
	})
	opts = append(opts, aliases)
	var resource RegistryWebhook
	err := ctx.RegisterResource("azure:containerservice/registryWebhook:RegistryWebhook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRegistryWebhook gets an existing RegistryWebhook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRegistryWebhook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RegistryWebhookState, opts ...pulumi.ResourceOption) (*RegistryWebhook, error) {
	var resource RegistryWebhook
	err := ctx.ReadResource("azure:containerservice/registryWebhook:RegistryWebhook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RegistryWebhook resources.
type registryWebhookState struct {
	// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chartPush`, `chartDelete`
	Actions []string `pulumi:"actions"`
	// Custom headers that will be added to the webhook notifications request.
	CustomHeaders map[string]string `pulumi:"customHeaders"`
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
	RegistryName *string `pulumi:"registryName"`
	// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
	Scope *string `pulumi:"scope"`
	// Specifies the service URI for the Webhook to post notifications.
	ServiceUri *string `pulumi:"serviceUri"`
	// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
	Status *string           `pulumi:"status"`
	Tags   map[string]string `pulumi:"tags"`
}

type RegistryWebhookState struct {
	// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chartPush`, `chartDelete`
	Actions pulumi.StringArrayInput
	// Custom headers that will be added to the webhook notifications request.
	CustomHeaders pulumi.StringMapInput
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
	RegistryName pulumi.StringPtrInput
	// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
	Scope pulumi.StringPtrInput
	// Specifies the service URI for the Webhook to post notifications.
	ServiceUri pulumi.StringPtrInput
	// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
	Status pulumi.StringPtrInput
	Tags   pulumi.StringMapInput
}

func (RegistryWebhookState) ElementType() reflect.Type {
	return reflect.TypeOf((*registryWebhookState)(nil)).Elem()
}

type registryWebhookArgs struct {
	// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chartPush`, `chartDelete`
	Actions []string `pulumi:"actions"`
	// Custom headers that will be added to the webhook notifications request.
	CustomHeaders map[string]string `pulumi:"customHeaders"`
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
	Scope *string `pulumi:"scope"`
	// Specifies the service URI for the Webhook to post notifications.
	ServiceUri string `pulumi:"serviceUri"`
	// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
	Status *string           `pulumi:"status"`
	Tags   map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a RegistryWebhook resource.
type RegistryWebhookArgs struct {
	// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chartPush`, `chartDelete`
	Actions pulumi.StringArrayInput
	// Custom headers that will be added to the webhook notifications request.
	CustomHeaders pulumi.StringMapInput
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
	RegistryName pulumi.StringInput
	// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
	Scope pulumi.StringPtrInput
	// Specifies the service URI for the Webhook to post notifications.
	ServiceUri pulumi.StringInput
	// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
	Status pulumi.StringPtrInput
	Tags   pulumi.StringMapInput
}

func (RegistryWebhookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*registryWebhookArgs)(nil)).Elem()
}