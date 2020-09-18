# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['SqlPool']


class SqlPool(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 collation: Optional[pulumi.Input[str]] = None,
                 create_mode: Optional[pulumi.Input[str]] = None,
                 data_encrypted: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 recovery_database_id: Optional[pulumi.Input[str]] = None,
                 restore: Optional[pulumi.Input[pulumi.InputType['SqlPoolRestoreArgs']]] = None,
                 sku_name: Optional[pulumi.Input[str]] = None,
                 synapse_workspace_id: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Synapse Sql Pool.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS",
            account_kind="BlobStorage")
        example_data_lake_gen2_filesystem = azure.storage.DataLakeGen2Filesystem("exampleDataLakeGen2Filesystem", storage_account_id=example_account.id)
        example_workspace = azure.synapse.Workspace("exampleWorkspace",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            storage_data_lake_gen2_filesystem_id=example_data_lake_gen2_filesystem.id,
            sql_administrator_login="sqladminuser",
            sql_administrator_login_password="H@Sh1CoR3!")
        example_sql_pool = azure.synapse.SqlPool("exampleSqlPool",
            synapse_workspace_id=example_workspace.id,
            sku_name="DW100c",
            create_mode="Default")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] collation: The name of the collation to use with this pool, only applicable when `create_mode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] create_mode: Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
        :param pulumi.Input[str] name: The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
        :param pulumi.Input[str] recovery_database_id: The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `create_mode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
        :param pulumi.Input[pulumi.InputType['SqlPoolRestoreArgs']] restore: A `restore` block as defined below. only applicable when `create_mode` is set to `PointInTimeRestore`.
        :param pulumi.Input[str] sku_name: Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
        :param pulumi.Input[str] synapse_workspace_id: The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags which should be assigned to the Synapse Sql Pool.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['collation'] = collation
            __props__['create_mode'] = create_mode
            __props__['data_encrypted'] = data_encrypted
            __props__['name'] = name
            __props__['recovery_database_id'] = recovery_database_id
            __props__['restore'] = restore
            if sku_name is None:
                raise TypeError("Missing required property 'sku_name'")
            __props__['sku_name'] = sku_name
            if synapse_workspace_id is None:
                raise TypeError("Missing required property 'synapse_workspace_id'")
            __props__['synapse_workspace_id'] = synapse_workspace_id
            __props__['tags'] = tags
        super(SqlPool, __self__).__init__(
            'azure:synapse/sqlPool:SqlPool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            collation: Optional[pulumi.Input[str]] = None,
            create_mode: Optional[pulumi.Input[str]] = None,
            data_encrypted: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            recovery_database_id: Optional[pulumi.Input[str]] = None,
            restore: Optional[pulumi.Input[pulumi.InputType['SqlPoolRestoreArgs']]] = None,
            sku_name: Optional[pulumi.Input[str]] = None,
            synapse_workspace_id: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'SqlPool':
        """
        Get an existing SqlPool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] collation: The name of the collation to use with this pool, only applicable when `create_mode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] create_mode: Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
        :param pulumi.Input[str] name: The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
        :param pulumi.Input[str] recovery_database_id: The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `create_mode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
        :param pulumi.Input[pulumi.InputType['SqlPoolRestoreArgs']] restore: A `restore` block as defined below. only applicable when `create_mode` is set to `PointInTimeRestore`.
        :param pulumi.Input[str] sku_name: Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
        :param pulumi.Input[str] synapse_workspace_id: The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags which should be assigned to the Synapse Sql Pool.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["collation"] = collation
        __props__["create_mode"] = create_mode
        __props__["data_encrypted"] = data_encrypted
        __props__["name"] = name
        __props__["recovery_database_id"] = recovery_database_id
        __props__["restore"] = restore
        __props__["sku_name"] = sku_name
        __props__["synapse_workspace_id"] = synapse_workspace_id
        __props__["tags"] = tags
        return SqlPool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def collation(self) -> pulumi.Output[str]:
        """
        The name of the collation to use with this pool, only applicable when `create_mode` is set to `Default`. Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "collation")

    @property
    @pulumi.getter(name="createMode")
    def create_mode(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies how to create the Sql Pool. Valid values are: `Default`, `Recovery` or `PointInTimeRestore`. Must be `Default` to create a new database. Defaults to `Default`.
        """
        return pulumi.get(self, "create_mode")

    @property
    @pulumi.getter(name="dataEncrypted")
    def data_encrypted(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "data_encrypted")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name which should be used for this Synapse Sql Pool. Changing this forces a new synapse SqlPool to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="recoveryDatabaseId")
    def recovery_database_id(self) -> pulumi.Output[Optional[str]]:
        """
        The ID of the Synapse Sql Pool or Sql Database which is to back up, only applicable when `create_mode` is set to `Recovery`. Changing this forces a new Synapse Sql Pool to be created.
        """
        return pulumi.get(self, "recovery_database_id")

    @property
    @pulumi.getter
    def restore(self) -> pulumi.Output[Optional['outputs.SqlPoolRestore']]:
        """
        A `restore` block as defined below. only applicable when `create_mode` is set to `PointInTimeRestore`.
        """
        return pulumi.get(self, "restore")

    @property
    @pulumi.getter(name="skuName")
    def sku_name(self) -> pulumi.Output[str]:
        """
        Specifies the SKU Name for this Synapse Sql Pool. Possible values are `DW100c`, `DW200c`, `DW300c`, `DW400c`, `DW500c`, `DW1000c`, `DW1500c`, `DW2000c`, `DW2500c`, `DW3000c`, `DW5000c`, `DW6000c`, `DW7500c`, `DW10000c`, `DW15000c` or `DW30000c`.
        """
        return pulumi.get(self, "sku_name")

    @property
    @pulumi.getter(name="synapseWorkspaceId")
    def synapse_workspace_id(self) -> pulumi.Output[str]:
        """
        The ID of Synapse Workspace within which this Sql Pool should be created. Changing this forces a new Synapse Sql Pool to be created.
        """
        return pulumi.get(self, "synapse_workspace_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags which should be assigned to the Synapse Sql Pool.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

