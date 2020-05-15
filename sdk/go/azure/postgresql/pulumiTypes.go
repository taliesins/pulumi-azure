// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package postgresql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ServerStorageProfile struct {
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	AutoGrow *string `pulumi:"autoGrow"`
	// Backup retention days for the server, supported values are between `7` and `35` days.
	//
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	BackupRetentionDays *int `pulumi:"backupRetentionDays"`
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	GeoRedundantBackup *string `pulumi:"geoRedundantBackup"`
	// Max storage allowed for a server. Possible values are between `5120` MB(5GB) and `1048576` MB(1TB) for the Basic SKU and between `5120` MB(5GB) and `4194304` MB(4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/postgresql/servers/create#StorageProfile).
	//
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	StorageMb *int `pulumi:"storageMb"`
}

// ServerStorageProfileInput is an input type that accepts ServerStorageProfileArgs and ServerStorageProfileOutput values.
// You can construct a concrete instance of `ServerStorageProfileInput` via:
//
// 		 ServerStorageProfileArgs{...}
//
type ServerStorageProfileInput interface {
	pulumi.Input

	ToServerStorageProfileOutput() ServerStorageProfileOutput
	ToServerStorageProfileOutputWithContext(context.Context) ServerStorageProfileOutput
}

type ServerStorageProfileArgs struct {
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	AutoGrow pulumi.StringPtrInput `pulumi:"autoGrow"`
	// Backup retention days for the server, supported values are between `7` and `35` days.
	//
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	BackupRetentionDays pulumi.IntPtrInput `pulumi:"backupRetentionDays"`
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	GeoRedundantBackup pulumi.StringPtrInput `pulumi:"geoRedundantBackup"`
	// Max storage allowed for a server. Possible values are between `5120` MB(5GB) and `1048576` MB(1TB) for the Basic SKU and between `5120` MB(5GB) and `4194304` MB(4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/postgresql/servers/create#StorageProfile).
	//
	// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
	StorageMb pulumi.IntPtrInput `pulumi:"storageMb"`
}

func (ServerStorageProfileArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerStorageProfile)(nil)).Elem()
}

func (i ServerStorageProfileArgs) ToServerStorageProfileOutput() ServerStorageProfileOutput {
	return i.ToServerStorageProfileOutputWithContext(context.Background())
}

func (i ServerStorageProfileArgs) ToServerStorageProfileOutputWithContext(ctx context.Context) ServerStorageProfileOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerStorageProfileOutput)
}

func (i ServerStorageProfileArgs) ToServerStorageProfilePtrOutput() ServerStorageProfilePtrOutput {
	return i.ToServerStorageProfilePtrOutputWithContext(context.Background())
}

func (i ServerStorageProfileArgs) ToServerStorageProfilePtrOutputWithContext(ctx context.Context) ServerStorageProfilePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerStorageProfileOutput).ToServerStorageProfilePtrOutputWithContext(ctx)
}

// ServerStorageProfilePtrInput is an input type that accepts ServerStorageProfileArgs, ServerStorageProfilePtr and ServerStorageProfilePtrOutput values.
// You can construct a concrete instance of `ServerStorageProfilePtrInput` via:
//
// 		 ServerStorageProfileArgs{...}
//
//  or:
//
// 		 nil
//
type ServerStorageProfilePtrInput interface {
	pulumi.Input

	ToServerStorageProfilePtrOutput() ServerStorageProfilePtrOutput
	ToServerStorageProfilePtrOutputWithContext(context.Context) ServerStorageProfilePtrOutput
}

type serverStorageProfilePtrType ServerStorageProfileArgs

func ServerStorageProfilePtr(v *ServerStorageProfileArgs) ServerStorageProfilePtrInput {
	return (*serverStorageProfilePtrType)(v)
}

func (*serverStorageProfilePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerStorageProfile)(nil)).Elem()
}

func (i *serverStorageProfilePtrType) ToServerStorageProfilePtrOutput() ServerStorageProfilePtrOutput {
	return i.ToServerStorageProfilePtrOutputWithContext(context.Background())
}

func (i *serverStorageProfilePtrType) ToServerStorageProfilePtrOutputWithContext(ctx context.Context) ServerStorageProfilePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerStorageProfilePtrOutput)
}

type ServerStorageProfileOutput struct{ *pulumi.OutputState }

func (ServerStorageProfileOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerStorageProfile)(nil)).Elem()
}

func (o ServerStorageProfileOutput) ToServerStorageProfileOutput() ServerStorageProfileOutput {
	return o
}

func (o ServerStorageProfileOutput) ToServerStorageProfileOutputWithContext(ctx context.Context) ServerStorageProfileOutput {
	return o
}

func (o ServerStorageProfileOutput) ToServerStorageProfilePtrOutput() ServerStorageProfilePtrOutput {
	return o.ToServerStorageProfilePtrOutputWithContext(context.Background())
}

func (o ServerStorageProfileOutput) ToServerStorageProfilePtrOutputWithContext(ctx context.Context) ServerStorageProfilePtrOutput {
	return o.ApplyT(func(v ServerStorageProfile) *ServerStorageProfile {
		return &v
	}).(ServerStorageProfilePtrOutput)
}

// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfileOutput) AutoGrow() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServerStorageProfile) *string { return v.AutoGrow }).(pulumi.StringPtrOutput)
}

// Backup retention days for the server, supported values are between `7` and `35` days.
//
// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfileOutput) BackupRetentionDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ServerStorageProfile) *int { return v.BackupRetentionDays }).(pulumi.IntPtrOutput)
}

// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfileOutput) GeoRedundantBackup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServerStorageProfile) *string { return v.GeoRedundantBackup }).(pulumi.StringPtrOutput)
}

// Max storage allowed for a server. Possible values are between `5120` MB(5GB) and `1048576` MB(1TB) for the Basic SKU and between `5120` MB(5GB) and `4194304` MB(4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/postgresql/servers/create#StorageProfile).
//
// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfileOutput) StorageMb() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ServerStorageProfile) *int { return v.StorageMb }).(pulumi.IntPtrOutput)
}

type ServerStorageProfilePtrOutput struct{ *pulumi.OutputState }

func (ServerStorageProfilePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerStorageProfile)(nil)).Elem()
}

func (o ServerStorageProfilePtrOutput) ToServerStorageProfilePtrOutput() ServerStorageProfilePtrOutput {
	return o
}

func (o ServerStorageProfilePtrOutput) ToServerStorageProfilePtrOutputWithContext(ctx context.Context) ServerStorageProfilePtrOutput {
	return o
}

func (o ServerStorageProfilePtrOutput) Elem() ServerStorageProfileOutput {
	return o.ApplyT(func(v *ServerStorageProfile) ServerStorageProfile { return *v }).(ServerStorageProfileOutput)
}

// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfilePtrOutput) AutoGrow() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServerStorageProfile) *string {
		if v == nil {
			return nil
		}
		return v.AutoGrow
	}).(pulumi.StringPtrOutput)
}

// Backup retention days for the server, supported values are between `7` and `35` days.
//
// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfilePtrOutput) BackupRetentionDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ServerStorageProfile) *int {
		if v == nil {
			return nil
		}
		return v.BackupRetentionDays
	}).(pulumi.IntPtrOutput)
}

// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfilePtrOutput) GeoRedundantBackup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServerStorageProfile) *string {
		if v == nil {
			return nil
		}
		return v.GeoRedundantBackup
	}).(pulumi.StringPtrOutput)
}

// Max storage allowed for a server. Possible values are between `5120` MB(5GB) and `1048576` MB(1TB) for the Basic SKU and between `5120` MB(5GB) and `4194304` MB(4TB) for General Purpose/Memory Optimized SKUs. For more information see the [product documentation](https://docs.microsoft.com/en-us/rest/api/postgresql/servers/create#StorageProfile).
//
// Deprecated: this has been moved to the top level and will be removed in version 3.0 of the provider.
func (o ServerStorageProfilePtrOutput) StorageMb() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ServerStorageProfile) *int {
		if v == nil {
			return nil
		}
		return v.StorageMb
	}).(pulumi.IntPtrOutput)
}

type ServerThreatDetectionPolicy struct {
	// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
	DisabledAlerts []string `pulumi:"disabledAlerts"`
	// Should the account administrators be emailed when this alert is triggered?
	EmailAccountAdmins *bool `pulumi:"emailAccountAdmins"`
	// A list of email addresses which alerts should be sent to.
	EmailAddresses []string `pulumi:"emailAddresses"`
	// Is the policy enabled?
	Enabled *bool `pulumi:"enabled"`
	// Specifies the number of days to keep in the Threat Detection audit logs.
	RetentionDays *int `pulumi:"retentionDays"`
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey *string `pulumi:"storageAccountAccessKey"`
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint *string `pulumi:"storageEndpoint"`
}

// ServerThreatDetectionPolicyInput is an input type that accepts ServerThreatDetectionPolicyArgs and ServerThreatDetectionPolicyOutput values.
// You can construct a concrete instance of `ServerThreatDetectionPolicyInput` via:
//
// 		 ServerThreatDetectionPolicyArgs{...}
//
type ServerThreatDetectionPolicyInput interface {
	pulumi.Input

	ToServerThreatDetectionPolicyOutput() ServerThreatDetectionPolicyOutput
	ToServerThreatDetectionPolicyOutputWithContext(context.Context) ServerThreatDetectionPolicyOutput
}

type ServerThreatDetectionPolicyArgs struct {
	// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
	DisabledAlerts pulumi.StringArrayInput `pulumi:"disabledAlerts"`
	// Should the account administrators be emailed when this alert is triggered?
	EmailAccountAdmins pulumi.BoolPtrInput `pulumi:"emailAccountAdmins"`
	// A list of email addresses which alerts should be sent to.
	EmailAddresses pulumi.StringArrayInput `pulumi:"emailAddresses"`
	// Is the policy enabled?
	Enabled pulumi.BoolPtrInput `pulumi:"enabled"`
	// Specifies the number of days to keep in the Threat Detection audit logs.
	RetentionDays pulumi.IntPtrInput `pulumi:"retentionDays"`
	// Specifies the identifier key of the Threat Detection audit storage account.
	StorageAccountAccessKey pulumi.StringPtrInput `pulumi:"storageAccountAccessKey"`
	// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
	StorageEndpoint pulumi.StringPtrInput `pulumi:"storageEndpoint"`
}

func (ServerThreatDetectionPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerThreatDetectionPolicy)(nil)).Elem()
}

func (i ServerThreatDetectionPolicyArgs) ToServerThreatDetectionPolicyOutput() ServerThreatDetectionPolicyOutput {
	return i.ToServerThreatDetectionPolicyOutputWithContext(context.Background())
}

func (i ServerThreatDetectionPolicyArgs) ToServerThreatDetectionPolicyOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerThreatDetectionPolicyOutput)
}

func (i ServerThreatDetectionPolicyArgs) ToServerThreatDetectionPolicyPtrOutput() ServerThreatDetectionPolicyPtrOutput {
	return i.ToServerThreatDetectionPolicyPtrOutputWithContext(context.Background())
}

func (i ServerThreatDetectionPolicyArgs) ToServerThreatDetectionPolicyPtrOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerThreatDetectionPolicyOutput).ToServerThreatDetectionPolicyPtrOutputWithContext(ctx)
}

// ServerThreatDetectionPolicyPtrInput is an input type that accepts ServerThreatDetectionPolicyArgs, ServerThreatDetectionPolicyPtr and ServerThreatDetectionPolicyPtrOutput values.
// You can construct a concrete instance of `ServerThreatDetectionPolicyPtrInput` via:
//
// 		 ServerThreatDetectionPolicyArgs{...}
//
//  or:
//
// 		 nil
//
type ServerThreatDetectionPolicyPtrInput interface {
	pulumi.Input

	ToServerThreatDetectionPolicyPtrOutput() ServerThreatDetectionPolicyPtrOutput
	ToServerThreatDetectionPolicyPtrOutputWithContext(context.Context) ServerThreatDetectionPolicyPtrOutput
}

type serverThreatDetectionPolicyPtrType ServerThreatDetectionPolicyArgs

func ServerThreatDetectionPolicyPtr(v *ServerThreatDetectionPolicyArgs) ServerThreatDetectionPolicyPtrInput {
	return (*serverThreatDetectionPolicyPtrType)(v)
}

func (*serverThreatDetectionPolicyPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerThreatDetectionPolicy)(nil)).Elem()
}

func (i *serverThreatDetectionPolicyPtrType) ToServerThreatDetectionPolicyPtrOutput() ServerThreatDetectionPolicyPtrOutput {
	return i.ToServerThreatDetectionPolicyPtrOutputWithContext(context.Background())
}

func (i *serverThreatDetectionPolicyPtrType) ToServerThreatDetectionPolicyPtrOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerThreatDetectionPolicyPtrOutput)
}

type ServerThreatDetectionPolicyOutput struct{ *pulumi.OutputState }

func (ServerThreatDetectionPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerThreatDetectionPolicy)(nil)).Elem()
}

func (o ServerThreatDetectionPolicyOutput) ToServerThreatDetectionPolicyOutput() ServerThreatDetectionPolicyOutput {
	return o
}

func (o ServerThreatDetectionPolicyOutput) ToServerThreatDetectionPolicyOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyOutput {
	return o
}

func (o ServerThreatDetectionPolicyOutput) ToServerThreatDetectionPolicyPtrOutput() ServerThreatDetectionPolicyPtrOutput {
	return o.ToServerThreatDetectionPolicyPtrOutputWithContext(context.Background())
}

func (o ServerThreatDetectionPolicyOutput) ToServerThreatDetectionPolicyPtrOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *ServerThreatDetectionPolicy {
		return &v
	}).(ServerThreatDetectionPolicyPtrOutput)
}

// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
func (o ServerThreatDetectionPolicyOutput) DisabledAlerts() pulumi.StringArrayOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) []string { return v.DisabledAlerts }).(pulumi.StringArrayOutput)
}

// Should the account administrators be emailed when this alert is triggered?
func (o ServerThreatDetectionPolicyOutput) EmailAccountAdmins() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *bool { return v.EmailAccountAdmins }).(pulumi.BoolPtrOutput)
}

// A list of email addresses which alerts should be sent to.
func (o ServerThreatDetectionPolicyOutput) EmailAddresses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) []string { return v.EmailAddresses }).(pulumi.StringArrayOutput)
}

// Is the policy enabled?
func (o ServerThreatDetectionPolicyOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *bool { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// Specifies the number of days to keep in the Threat Detection audit logs.
func (o ServerThreatDetectionPolicyOutput) RetentionDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *int { return v.RetentionDays }).(pulumi.IntPtrOutput)
}

// Specifies the identifier key of the Threat Detection audit storage account.
func (o ServerThreatDetectionPolicyOutput) StorageAccountAccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *string { return v.StorageAccountAccessKey }).(pulumi.StringPtrOutput)
}

// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
func (o ServerThreatDetectionPolicyOutput) StorageEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServerThreatDetectionPolicy) *string { return v.StorageEndpoint }).(pulumi.StringPtrOutput)
}

type ServerThreatDetectionPolicyPtrOutput struct{ *pulumi.OutputState }

func (ServerThreatDetectionPolicyPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerThreatDetectionPolicy)(nil)).Elem()
}

func (o ServerThreatDetectionPolicyPtrOutput) ToServerThreatDetectionPolicyPtrOutput() ServerThreatDetectionPolicyPtrOutput {
	return o
}

func (o ServerThreatDetectionPolicyPtrOutput) ToServerThreatDetectionPolicyPtrOutputWithContext(ctx context.Context) ServerThreatDetectionPolicyPtrOutput {
	return o
}

func (o ServerThreatDetectionPolicyPtrOutput) Elem() ServerThreatDetectionPolicyOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) ServerThreatDetectionPolicy { return *v }).(ServerThreatDetectionPolicyOutput)
}

// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
func (o ServerThreatDetectionPolicyPtrOutput) DisabledAlerts() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) []string {
		if v == nil {
			return nil
		}
		return v.DisabledAlerts
	}).(pulumi.StringArrayOutput)
}

// Should the account administrators be emailed when this alert is triggered?
func (o ServerThreatDetectionPolicyPtrOutput) EmailAccountAdmins() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) *bool {
		if v == nil {
			return nil
		}
		return v.EmailAccountAdmins
	}).(pulumi.BoolPtrOutput)
}

// A list of email addresses which alerts should be sent to.
func (o ServerThreatDetectionPolicyPtrOutput) EmailAddresses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) []string {
		if v == nil {
			return nil
		}
		return v.EmailAddresses
	}).(pulumi.StringArrayOutput)
}

// Is the policy enabled?
func (o ServerThreatDetectionPolicyPtrOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) *bool {
		if v == nil {
			return nil
		}
		return v.Enabled
	}).(pulumi.BoolPtrOutput)
}

// Specifies the number of days to keep in the Threat Detection audit logs.
func (o ServerThreatDetectionPolicyPtrOutput) RetentionDays() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) *int {
		if v == nil {
			return nil
		}
		return v.RetentionDays
	}).(pulumi.IntPtrOutput)
}

// Specifies the identifier key of the Threat Detection audit storage account.
func (o ServerThreatDetectionPolicyPtrOutput) StorageAccountAccessKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) *string {
		if v == nil {
			return nil
		}
		return v.StorageAccountAccessKey
	}).(pulumi.StringPtrOutput)
}

// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
func (o ServerThreatDetectionPolicyPtrOutput) StorageEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ServerThreatDetectionPolicy) *string {
		if v == nil {
			return nil
		}
		return v.StorageEndpoint
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ServerStorageProfileOutput{})
	pulumi.RegisterOutputType(ServerStorageProfilePtrOutput{})
	pulumi.RegisterOutputType(ServerThreatDetectionPolicyOutput{})
	pulumi.RegisterOutputType(ServerThreatDetectionPolicyPtrOutput{})
}
