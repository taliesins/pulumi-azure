// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package synapse

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Synapse Sql Pool.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/storage"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/synapse"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.NewResourceGroup(ctx, "exampleResourceGroup", &core.ResourceGroupArgs{
// 			Location: pulumi.String("West Europe"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleAccount, err := storage.NewAccount(ctx, "exampleAccount", &storage.AccountArgs{
// 			ResourceGroupName:      exampleResourceGroup.Name,
// 			Location:               exampleResourceGroup.Location,
// 			AccountTier:            pulumi.String("Standard"),
// 			AccountReplicationType: pulumi.String("LRS"),
// 			AccountKind:            pulumi.String("BlobStorage"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleDataLakeGen2Filesystem, err := storage.NewDataLakeGen2Filesystem(ctx, "exampleDataLakeGen2Filesystem", &storage.DataLakeGen2FilesystemArgs{
// 			StorageAccountId: exampleAccount.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleWorkspace, err := synapse.NewWorkspace(ctx, "exampleWorkspace", &synapse.WorkspaceArgs{
// 			ResourceGroupName:               exampleResourceGroup.Name,
// 			Location:                        exampleResourceGroup.Location,
// 			StorageDataLakeGen2FilesystemId: exampleDataLakeGen2Filesystem.ID(),
// 			SqlAdministratorLogin:           pulumi.String("sqladminuser"),
// 			SqlAdministratorLoginPassword:   pulumi.String("H@Sh1CoR3!"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = synapse.NewSqlPool(ctx, "exampleSqlPool", &synapse.SqlPoolArgs{
// 			SynapseWorkspaceId: exampleWorkspace.ID(),
// 			SkuName:            pulumi.String("DW100c"),
// 			CreateMode:         pulumi.String("Default"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type SqlPool struct {
	pulumi.CustomResourceState

	// The name of the collation to use with this pool, only applicable when `createMode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation pulumi.StringOutput `pulumi:"collation"`
	// Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
	CreateMode    pulumi.StringPtrOutput `pulumi:"createMode"`
	DataEncrypted pulumi.BoolPtrOutput   `pulumi:"dataEncrypted"`
	// The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `createMode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
	RecoveryDatabaseId pulumi.StringPtrOutput `pulumi:"recoveryDatabaseId"`
	// A `restore` block as defined below. only applicable when `createMode` is set to `PointInTimeRestore`.
	Restore SqlPoolRestorePtrOutput `pulumi:"restore"`
	// Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
	SkuName pulumi.StringOutput `pulumi:"skuName"`
	// The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
	SynapseWorkspaceId pulumi.StringOutput `pulumi:"synapseWorkspaceId"`
	// A mapping of tags which should be assigned to the Synapse Sql Pool.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
}

// NewSqlPool registers a new resource with the given unique name, arguments, and options.
func NewSqlPool(ctx *pulumi.Context,
	name string, args *SqlPoolArgs, opts ...pulumi.ResourceOption) (*SqlPool, error) {
	if args == nil || args.SkuName == nil {
		return nil, errors.New("missing required argument 'SkuName'")
	}
	if args == nil || args.SynapseWorkspaceId == nil {
		return nil, errors.New("missing required argument 'SynapseWorkspaceId'")
	}
	if args == nil {
		args = &SqlPoolArgs{}
	}
	var resource SqlPool
	err := ctx.RegisterResource("azure:synapse/sqlPool:SqlPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSqlPool gets an existing SqlPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSqlPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SqlPoolState, opts ...pulumi.ResourceOption) (*SqlPool, error) {
	var resource SqlPool
	err := ctx.ReadResource("azure:synapse/sqlPool:SqlPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SqlPool resources.
type sqlPoolState struct {
	// The name of the collation to use with this pool, only applicable when `createMode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation *string `pulumi:"collation"`
	// Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
	CreateMode    *string `pulumi:"createMode"`
	DataEncrypted *bool   `pulumi:"dataEncrypted"`
	// The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
	Name *string `pulumi:"name"`
	// The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `createMode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
	RecoveryDatabaseId *string `pulumi:"recoveryDatabaseId"`
	// A `restore` block as defined below. only applicable when `createMode` is set to `PointInTimeRestore`.
	Restore *SqlPoolRestore `pulumi:"restore"`
	// Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
	SkuName *string `pulumi:"skuName"`
	// The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
	SynapseWorkspaceId *string `pulumi:"synapseWorkspaceId"`
	// A mapping of tags which should be assigned to the Synapse Sql Pool.
	Tags map[string]string `pulumi:"tags"`
}

type SqlPoolState struct {
	// The name of the collation to use with this pool, only applicable when `createMode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation pulumi.StringPtrInput
	// Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
	CreateMode    pulumi.StringPtrInput
	DataEncrypted pulumi.BoolPtrInput
	// The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
	Name pulumi.StringPtrInput
	// The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `createMode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
	RecoveryDatabaseId pulumi.StringPtrInput
	// A `restore` block as defined below. only applicable when `createMode` is set to `PointInTimeRestore`.
	Restore SqlPoolRestorePtrInput
	// Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
	SkuName pulumi.StringPtrInput
	// The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
	SynapseWorkspaceId pulumi.StringPtrInput
	// A mapping of tags which should be assigned to the Synapse Sql Pool.
	Tags pulumi.StringMapInput
}

func (SqlPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlPoolState)(nil)).Elem()
}

type sqlPoolArgs struct {
	// The name of the collation to use with this pool, only applicable when `createMode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation *string `pulumi:"collation"`
	// Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
	CreateMode    *string `pulumi:"createMode"`
	DataEncrypted *bool   `pulumi:"dataEncrypted"`
	// The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
	Name *string `pulumi:"name"`
	// The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `createMode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
	RecoveryDatabaseId *string `pulumi:"recoveryDatabaseId"`
	// A `restore` block as defined below. only applicable when `createMode` is set to `PointInTimeRestore`.
	Restore *SqlPoolRestore `pulumi:"restore"`
	// Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
	SkuName string `pulumi:"skuName"`
	// The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
	SynapseWorkspaceId string `pulumi:"synapseWorkspaceId"`
	// A mapping of tags which should be assigned to the Synapse Sql Pool.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a SqlPool resource.
type SqlPoolArgs struct {
	// The name of the collation to use with this pool, only applicable when `createMode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
	Collation pulumi.StringPtrInput
	// Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
	CreateMode    pulumi.StringPtrInput
	DataEncrypted pulumi.BoolPtrInput
	// The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
	Name pulumi.StringPtrInput
	// The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `createMode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
	RecoveryDatabaseId pulumi.StringPtrInput
	// A `restore` block as defined below. only applicable when `createMode` is set to `PointInTimeRestore`.
	Restore SqlPoolRestorePtrInput
	// Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
	SkuName pulumi.StringInput
	// The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
	SynapseWorkspaceId pulumi.StringInput
	// A mapping of tags which should be assigned to the Synapse Sql Pool.
	Tags pulumi.StringMapInput
}

func (SqlPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sqlPoolArgs)(nil)).Elem()
}
