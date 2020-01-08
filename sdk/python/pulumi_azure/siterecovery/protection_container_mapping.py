# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class ProtectionContainerMapping(pulumi.CustomResource):
    name: pulumi.Output[str]
    """
    The name of the network mapping.
    """
    recovery_fabric_name: pulumi.Output[str]
    """
    Name of fabric that should contains the protection container to map.
    """
    recovery_replication_policy_id: pulumi.Output[str]
    """
    Id of the policy to use for this mapping.
    """
    recovery_source_protection_container_name: pulumi.Output[str]
    """
    Name of the source protection container to map.
    """
    recovery_target_protection_container_id: pulumi.Output[str]
    """
    Id of target protection container to map to.
    """
    recovery_vault_name: pulumi.Output[str]
    """
    The name of the vault that should be updated.
    """
    resource_group_name: pulumi.Output[str]
    """
    Name of the resource group where the vault that should be updated is located.
    """
    def __init__(__self__, resource_name, opts=None, name=None, recovery_fabric_name=None, recovery_replication_policy_id=None, recovery_source_protection_container_name=None, recovery_target_protection_container_id=None, recovery_vault_name=None, resource_group_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Azure recovery vault protection container mapping. A protection container mapping decides how to translate the protection container when a VM is migrated from one region to another.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the network mapping.
        :param pulumi.Input[str] recovery_fabric_name: Name of fabric that should contains the protection container to map.
        :param pulumi.Input[str] recovery_replication_policy_id: Id of the policy to use for this mapping.
        :param pulumi.Input[str] recovery_source_protection_container_name: Name of the source protection container to map.
        :param pulumi.Input[str] recovery_target_protection_container_id: Id of target protection container to map to.
        :param pulumi.Input[str] recovery_vault_name: The name of the vault that should be updated.
        :param pulumi.Input[str] resource_group_name: Name of the resource group where the vault that should be updated is located.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/site_recovery_protection_container_mapping.html.markdown.
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
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['name'] = name
            if recovery_fabric_name is None:
                raise TypeError("Missing required property 'recovery_fabric_name'")
            __props__['recovery_fabric_name'] = recovery_fabric_name
            if recovery_replication_policy_id is None:
                raise TypeError("Missing required property 'recovery_replication_policy_id'")
            __props__['recovery_replication_policy_id'] = recovery_replication_policy_id
            if recovery_source_protection_container_name is None:
                raise TypeError("Missing required property 'recovery_source_protection_container_name'")
            __props__['recovery_source_protection_container_name'] = recovery_source_protection_container_name
            if recovery_target_protection_container_id is None:
                raise TypeError("Missing required property 'recovery_target_protection_container_id'")
            __props__['recovery_target_protection_container_id'] = recovery_target_protection_container_id
            if recovery_vault_name is None:
                raise TypeError("Missing required property 'recovery_vault_name'")
            __props__['recovery_vault_name'] = recovery_vault_name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
        super(ProtectionContainerMapping, __self__).__init__(
            'azure:siterecovery/protectionContainerMapping:ProtectionContainerMapping',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, name=None, recovery_fabric_name=None, recovery_replication_policy_id=None, recovery_source_protection_container_name=None, recovery_target_protection_container_id=None, recovery_vault_name=None, resource_group_name=None):
        """
        Get an existing ProtectionContainerMapping resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the network mapping.
        :param pulumi.Input[str] recovery_fabric_name: Name of fabric that should contains the protection container to map.
        :param pulumi.Input[str] recovery_replication_policy_id: Id of the policy to use for this mapping.
        :param pulumi.Input[str] recovery_source_protection_container_name: Name of the source protection container to map.
        :param pulumi.Input[str] recovery_target_protection_container_id: Id of target protection container to map to.
        :param pulumi.Input[str] recovery_vault_name: The name of the vault that should be updated.
        :param pulumi.Input[str] resource_group_name: Name of the resource group where the vault that should be updated is located.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/site_recovery_protection_container_mapping.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["name"] = name
        __props__["recovery_fabric_name"] = recovery_fabric_name
        __props__["recovery_replication_policy_id"] = recovery_replication_policy_id
        __props__["recovery_source_protection_container_name"] = recovery_source_protection_container_name
        __props__["recovery_target_protection_container_id"] = recovery_target_protection_container_id
        __props__["recovery_vault_name"] = recovery_vault_name
        __props__["resource_group_name"] = resource_group_name
        return ProtectionContainerMapping(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

