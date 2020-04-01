# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Cache(pulumi.CustomResource):
    cache_size_in_gb: pulumi.Output[float]
    """
    The size of the HPC Cache, in GB. Possible values are `3072`, `6144`, `12288`, `24576`, and `49152`. Changing this forces a new resource to be created.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.
    """
    mount_addresses: pulumi.Output[list]
    """
    A list of IP Addresses where the HPC Cache can be mounted.
    """
    name: pulumi.Output[str]
    """
    The name of the HPC Cache. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.
    """
    sku_name: pulumi.Output[str]
    """
    The SKU of HPC Cache to use. Possible values are `Standard_2G`, `Standard_4G` and `Standard_8G`. Changing this forces a new resource to be created.
    """
    subnet_id: pulumi.Output[str]
    """
    The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, cache_size_in_gb=None, location=None, name=None, resource_group_name=None, sku_name=None, subnet_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a HPC Cache.

        > **Note**: During the first several months of the GA release, a request must be made to the Azure HPC Cache team to add your subscription to the access list before it can be used to create a cache instance. Fill out [this form](https://aka.ms/onboard-hpc-cache) to request access.



        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/hpc_cache.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] cache_size_in_gb: The size of the HPC Cache, in GB. Possible values are `3072`, `6144`, `12288`, `24576`, and `49152`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] location: Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the HPC Cache. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sku_name: The SKU of HPC Cache to use. Possible values are `Standard_2G`, `Standard_4G` and `Standard_8G`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] subnet_id: The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.
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

            if cache_size_in_gb is None:
                raise TypeError("Missing required property 'cache_size_in_gb'")
            __props__['cache_size_in_gb'] = cache_size_in_gb
            __props__['location'] = location
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku_name is None:
                raise TypeError("Missing required property 'sku_name'")
            __props__['sku_name'] = sku_name
            if subnet_id is None:
                raise TypeError("Missing required property 'subnet_id'")
            __props__['subnet_id'] = subnet_id
            __props__['mount_addresses'] = None
        super(Cache, __self__).__init__(
            'azure:hpc/cache:Cache',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, cache_size_in_gb=None, location=None, mount_addresses=None, name=None, resource_group_name=None, sku_name=None, subnet_id=None):
        """
        Get an existing Cache resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] cache_size_in_gb: The size of the HPC Cache, in GB. Possible values are `3072`, `6144`, `12288`, `24576`, and `49152`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] location: Specifies the supported Azure Region where the HPC Cache should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[list] mount_addresses: A list of IP Addresses where the HPC Cache can be mounted.
        :param pulumi.Input[str] name: The name of the HPC Cache. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which to create the HPC Cache. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sku_name: The SKU of HPC Cache to use. Possible values are `Standard_2G`, `Standard_4G` and `Standard_8G`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] subnet_id: The ID of the Subnet for the HPC Cache. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["cache_size_in_gb"] = cache_size_in_gb
        __props__["location"] = location
        __props__["mount_addresses"] = mount_addresses
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["sku_name"] = sku_name
        __props__["subnet_id"] = subnet_id
        return Cache(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
