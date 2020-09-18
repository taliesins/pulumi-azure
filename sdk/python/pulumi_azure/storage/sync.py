# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['Sync']


class Sync(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 incoming_traffic_policy: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Storage Sync.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example = azure.core.ResourceGroup("example", location="West Europe")
        test = azure.storage.Sync("test",
            resource_group_name=azurerm_resource_group["test"]["name"],
            location=azurerm_resource_group["test"]["location"],
            tags={
                "foo": "bar",
            })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] incoming_traffic_policy: Incoming traffic policy. Possible values are `AllowAllTraffic` and `AllowVirtualNetworksOnly`.
        :param pulumi.Input[str] location: The Azure Region where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[str] name: The name which should be used for this Storage Sync. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags which should be assigned to the Storage Sync.
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

            __props__['incoming_traffic_policy'] = incoming_traffic_policy
            __props__['location'] = location
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
        super(Sync, __self__).__init__(
            'azure:storage/sync:Sync',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            incoming_traffic_policy: Optional[pulumi.Input[str]] = None,
            location: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'Sync':
        """
        Get an existing Sync resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] incoming_traffic_policy: Incoming traffic policy. Possible values are `AllowAllTraffic` and `AllowVirtualNetworksOnly`.
        :param pulumi.Input[str] location: The Azure Region where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[str] name: The name which should be used for this Storage Sync. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags which should be assigned to the Storage Sync.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["incoming_traffic_policy"] = incoming_traffic_policy
        __props__["location"] = location
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["tags"] = tags
        return Sync(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="incomingTrafficPolicy")
    def incoming_traffic_policy(self) -> pulumi.Output[Optional[str]]:
        """
        Incoming traffic policy. Possible values are `AllowAllTraffic` and `AllowVirtualNetworksOnly`.
        """
        return pulumi.get(self, "incoming_traffic_policy")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The Azure Region where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name which should be used for this Storage Sync. Changing this forces a new Storage Sync to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        The name of the Resource Group where the Storage Sync should exist. Changing this forces a new Storage Sync to be created.
        """
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags which should be assigned to the Storage Sync.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

