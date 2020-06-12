// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mssql

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Security Alert Policy for a MSSQL Server.
//
// > **NOTE** Security Alert Policy is currently only available for MS SQL databases.
//
// ## Example Usage
//
//
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/mssql"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/sql"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/storage"
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
// 		exampleSqlServer, err := sql.NewSqlServer(ctx, "exampleSqlServer", &sql.SqlServerArgs{
// 			ResourceGroupName:          exampleResourceGroup.Name,
// 			Location:                   exampleResourceGroup.Location,
// 			Version:                    pulumi.String("12.0"),
// 			AdministratorLogin:         pulumi.String("4dm1n157r470r"),
// 			AdministratorLoginPassword: pulumi.String("4-v3ry-53cr37-p455w0rd"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleAccount, err := storage.NewAccount(ctx, "exampleAccount", &storage.AccountArgs{
// 			ResourceGroupName:      exampleResourceGroup.Name,
// 			Location:               exampleResourceGroup.Location,
// 			AccountTier:            pulumi.String("Standard"),
// 			AccountReplicationType: pulumi.String("GRS"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleServerSecurityAlertPolicy, err := mssql.NewServerSecurityAlertPolicy(ctx, "exampleServerSecurityAlertPolicy", &mssql.ServerSecurityAlertPolicyArgs{
// 			ResourceGroupName:       exampleResourceGroup.Name,
// 			ServerName:              exampleSqlServer.Name,
// 			State:                   pulumi.String("Enabled"),
// 			StorageEndpoint:         exampleAccount.PrimaryBlobEndpoint,
// 			StorageAccountAccessKey: exampleAccount.PrimaryAccessKey,
// 			DisabledAlerts: pulumi.StringArray{
// 				pulumi.String("Sql_Injection"),
// 				pulumi.String("Data_Exfiltration"),
// 			},
// 			RetentionDays: pulumi.Int(20),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type ServerSecurityAlertPolicy struct {
	pulumi.CustomResourceState

	// Specifies an array of alerts that are disabled. Allowed values are: `Sql_Injection`, `Sql_Injection_Vulnerability`, `Access_Anomaly`, `Data_Exfiltration`, `Unsafe_Action`.
	DisabledAlerts pulumi.StringArrayOutput `pulumi:"disabledAlerts"`
	// Boolean flag which specifies if the alert is sent to the account administrators or not. Defaults to `false`.
	EmailAccountAdmins pulumi.BoolPtrOutput `pulumi:"emailAccountAdmins"`
	// Specifies an array of e-mail addresses to which the alert is sent.
	EmailAddresses pulumi.StringArrayOutput `pulumi:"emailAddresses"`
	// The name of the resource group that contains the MS SQL Server. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// Specifies the number of days to keep in the Threat Detection audit logs. Defaults to `0`.
	RetentionDays pulumi.IntPtrOutput `pulumi:"retentionDays"`
	// Specifies the name of the MS SQL Server. Changing this forces a new resource to be created.
	ServerName pulumi.StringOutput `pulumi:"serverName"`
	// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database server. Allowed values are: `Disabled`, `Enabled`, `New`.
	State pulumi.StringOutput `pulumi:"state"`
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey pulumi.StringPtrOutput `pulumi:"storageAccountAccessKey"`
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint pulumi.StringPtrOutput `pulumi:"storageEndpoint"`
}

// NewServerSecurityAlertPolicy registers a new resource with the given unique name, arguments, and options.
func NewServerSecurityAlertPolicy(ctx *pulumi.Context,
	name string, args *ServerSecurityAlertPolicyArgs, opts ...pulumi.ResourceOption) (*ServerSecurityAlertPolicy, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil || args.State == nil {
		return nil, errors.New("missing required argument 'State'")
	}
	if args == nil {
		args = &ServerSecurityAlertPolicyArgs{}
	}
	var resource ServerSecurityAlertPolicy
	err := ctx.RegisterResource("azure:mssql/serverSecurityAlertPolicy:ServerSecurityAlertPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerSecurityAlertPolicy gets an existing ServerSecurityAlertPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerSecurityAlertPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerSecurityAlertPolicyState, opts ...pulumi.ResourceOption) (*ServerSecurityAlertPolicy, error) {
	var resource ServerSecurityAlertPolicy
	err := ctx.ReadResource("azure:mssql/serverSecurityAlertPolicy:ServerSecurityAlertPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerSecurityAlertPolicy resources.
type serverSecurityAlertPolicyState struct {
	// Specifies an array of alerts that are disabled. Allowed values are: `Sql_Injection`, `Sql_Injection_Vulnerability`, `Access_Anomaly`, `Data_Exfiltration`, `Unsafe_Action`.
	DisabledAlerts []string `pulumi:"disabledAlerts"`
	// Boolean flag which specifies if the alert is sent to the account administrators or not. Defaults to `false`.
	EmailAccountAdmins *bool `pulumi:"emailAccountAdmins"`
	// Specifies an array of e-mail addresses to which the alert is sent.
	EmailAddresses []string `pulumi:"emailAddresses"`
	// The name of the resource group that contains the MS SQL Server. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// Specifies the number of days to keep in the Threat Detection audit logs. Defaults to `0`.
	RetentionDays *int `pulumi:"retentionDays"`
	// Specifies the name of the MS SQL Server. Changing this forces a new resource to be created.
	ServerName *string `pulumi:"serverName"`
	// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database server. Allowed values are: `Disabled`, `Enabled`, `New`.
	State *string `pulumi:"state"`
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey *string `pulumi:"storageAccountAccessKey"`
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint *string `pulumi:"storageEndpoint"`
}

type ServerSecurityAlertPolicyState struct {
	// Specifies an array of alerts that are disabled. Allowed values are: `Sql_Injection`, `Sql_Injection_Vulnerability`, `Access_Anomaly`, `Data_Exfiltration`, `Unsafe_Action`.
	DisabledAlerts pulumi.StringArrayInput
	// Boolean flag which specifies if the alert is sent to the account administrators or not. Defaults to `false`.
	EmailAccountAdmins pulumi.BoolPtrInput
	// Specifies an array of e-mail addresses to which the alert is sent.
	EmailAddresses pulumi.StringArrayInput
	// The name of the resource group that contains the MS SQL Server. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// Specifies the number of days to keep in the Threat Detection audit logs. Defaults to `0`.
	RetentionDays pulumi.IntPtrInput
	// Specifies the name of the MS SQL Server. Changing this forces a new resource to be created.
	ServerName pulumi.StringPtrInput
	// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database server. Allowed values are: `Disabled`, `Enabled`, `New`.
	State pulumi.StringPtrInput
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey pulumi.StringPtrInput
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint pulumi.StringPtrInput
}

func (ServerSecurityAlertPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverSecurityAlertPolicyState)(nil)).Elem()
}

type serverSecurityAlertPolicyArgs struct {
	// Specifies an array of alerts that are disabled. Allowed values are: `Sql_Injection`, `Sql_Injection_Vulnerability`, `Access_Anomaly`, `Data_Exfiltration`, `Unsafe_Action`.
	DisabledAlerts []string `pulumi:"disabledAlerts"`
	// Boolean flag which specifies if the alert is sent to the account administrators or not. Defaults to `false`.
	EmailAccountAdmins *bool `pulumi:"emailAccountAdmins"`
	// Specifies an array of e-mail addresses to which the alert is sent.
	EmailAddresses []string `pulumi:"emailAddresses"`
	// The name of the resource group that contains the MS SQL Server. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the number of days to keep in the Threat Detection audit logs. Defaults to `0`.
	RetentionDays *int `pulumi:"retentionDays"`
	// Specifies the name of the MS SQL Server. Changing this forces a new resource to be created.
	ServerName string `pulumi:"serverName"`
	// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database server. Allowed values are: `Disabled`, `Enabled`, `New`.
	State string `pulumi:"state"`
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey *string `pulumi:"storageAccountAccessKey"`
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint *string `pulumi:"storageEndpoint"`
}

// The set of arguments for constructing a ServerSecurityAlertPolicy resource.
type ServerSecurityAlertPolicyArgs struct {
	// Specifies an array of alerts that are disabled. Allowed values are: `Sql_Injection`, `Sql_Injection_Vulnerability`, `Access_Anomaly`, `Data_Exfiltration`, `Unsafe_Action`.
	DisabledAlerts pulumi.StringArrayInput
	// Boolean flag which specifies if the alert is sent to the account administrators or not. Defaults to `false`.
	EmailAccountAdmins pulumi.BoolPtrInput
	// Specifies an array of e-mail addresses to which the alert is sent.
	EmailAddresses pulumi.StringArrayInput
	// The name of the resource group that contains the MS SQL Server. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// Specifies the number of days to keep in the Threat Detection audit logs. Defaults to `0`.
	RetentionDays pulumi.IntPtrInput
	// Specifies the name of the MS SQL Server. Changing this forces a new resource to be created.
	ServerName pulumi.StringInput
	// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database server. Allowed values are: `Disabled`, `Enabled`, `New`.
	State pulumi.StringInput
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey pulumi.StringPtrInput
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint pulumi.StringPtrInput
}

func (ServerSecurityAlertPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverSecurityAlertPolicyArgs)(nil)).Elem()
}
