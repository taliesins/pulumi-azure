// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package backup

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Azure Backup Protected File Share to enable backups for file shares within an Azure Storage Account
//
// > **NOTE:** Azure Backup for Azure File Shares is currently in public preview. During the preview, the service is subject to additional limitations and unsupported backup scenarios. [Read More](https://docs.microsoft.com/en-us/azure/backup/backup-azure-files#limitations-for-azure-file-share-backup-during-preview)
//
// > **NOTE** Azure Backup for Azure File Shares does not support Soft Delete at this time. Deleting this resource will also delete all associated backup data. Please exercise caution. Consider using [`protect`](https://www.pulumi.com/docs/intro/concepts/programming-model/#protect) to guard against accidental deletion.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/backup_protected_file_share.markdown.
type ProtectedFileShare struct {
	pulumi.CustomResourceState

	// Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
	BackupPolicyId pulumi.StringOutput `pulumi:"backupPolicyId"`
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName pulumi.StringOutput `pulumi:"recoveryVaultName"`
	// The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// Specifies the name of the file share to backup. Changing this forces a new resource to be created.
	SourceFileShareName pulumi.StringOutput `pulumi:"sourceFileShareName"`
	// Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
	SourceStorageAccountId pulumi.StringOutput `pulumi:"sourceStorageAccountId"`
}

// NewProtectedFileShare registers a new resource with the given unique name, arguments, and options.
func NewProtectedFileShare(ctx *pulumi.Context,
	name string, args *ProtectedFileShareArgs, opts ...pulumi.ResourceOption) (*ProtectedFileShare, error) {
	if args == nil || args.BackupPolicyId == nil {
		return nil, errors.New("missing required argument 'BackupPolicyId'")
	}
	if args == nil || args.RecoveryVaultName == nil {
		return nil, errors.New("missing required argument 'RecoveryVaultName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SourceFileShareName == nil {
		return nil, errors.New("missing required argument 'SourceFileShareName'")
	}
	if args == nil || args.SourceStorageAccountId == nil {
		return nil, errors.New("missing required argument 'SourceStorageAccountId'")
	}
	if args == nil {
		args = &ProtectedFileShareArgs{}
	}
	var resource ProtectedFileShare
	err := ctx.RegisterResource("azure:backup/protectedFileShare:ProtectedFileShare", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProtectedFileShare gets an existing ProtectedFileShare resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProtectedFileShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProtectedFileShareState, opts ...pulumi.ResourceOption) (*ProtectedFileShare, error) {
	var resource ProtectedFileShare
	err := ctx.ReadResource("azure:backup/protectedFileShare:ProtectedFileShare", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProtectedFileShare resources.
type protectedFileShareState struct {
	// Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
	BackupPolicyId *string `pulumi:"backupPolicyId"`
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName *string `pulumi:"recoveryVaultName"`
	// The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// Specifies the name of the file share to backup. Changing this forces a new resource to be created.
	SourceFileShareName *string `pulumi:"sourceFileShareName"`
	// Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
	SourceStorageAccountId *string `pulumi:"sourceStorageAccountId"`
}

type ProtectedFileShareState struct {
	// Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
	BackupPolicyId pulumi.StringPtrInput
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName pulumi.StringPtrInput
	// The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// Specifies the name of the file share to backup. Changing this forces a new resource to be created.
	SourceFileShareName pulumi.StringPtrInput
	// Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
	SourceStorageAccountId pulumi.StringPtrInput
}

func (ProtectedFileShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*protectedFileShareState)(nil)).Elem()
}

type protectedFileShareArgs struct {
	// Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
	BackupPolicyId string `pulumi:"backupPolicyId"`
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName string `pulumi:"recoveryVaultName"`
	// The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the name of the file share to backup. Changing this forces a new resource to be created.
	SourceFileShareName string `pulumi:"sourceFileShareName"`
	// Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
	SourceStorageAccountId string `pulumi:"sourceStorageAccountId"`
}

// The set of arguments for constructing a ProtectedFileShare resource.
type ProtectedFileShareArgs struct {
	// Specifies the ID of the backup policy to use. The policy must be an Azure File Share backup policy. Other types are not supported.
	BackupPolicyId pulumi.StringInput
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName pulumi.StringInput
	// The name of the resource group in which to create the Azure Backup Protected File Share. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// Specifies the name of the file share to backup. Changing this forces a new resource to be created.
	SourceFileShareName pulumi.StringInput
	// Specifies the ID of the storage account of the file share to backup. Changing this forces a new resource to be created.
	SourceStorageAccountId pulumi.StringInput
}

func (ProtectedFileShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*protectedFileShareArgs)(nil)).Elem()
}

