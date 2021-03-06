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

__all__ = ['Logger']


class Logger(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_management_name: Optional[pulumi.Input[str]] = None,
                 application_insights: Optional[pulumi.Input[pulumi.InputType['LoggerApplicationInsightsArgs']]] = None,
                 buffered: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 eventhub: Optional[pulumi.Input[pulumi.InputType['LoggerEventhubArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Logger within an API Management Service.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West US")
        example_insights = azure.appinsights.Insights("exampleInsights",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            application_type="other")
        example_service = azure.apimanagement.Service("exampleService",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            publisher_name="My Company",
            publisher_email="company@exmaple.com",
            sku_name="Developer_1")
        example_logger = azure.apimanagement.Logger("exampleLogger",
            api_management_name=example_service.name,
            resource_group_name=example_resource_group.name,
            application_insights=azure.apimanagement.LoggerApplicationInsightsArgs(
                instrumentation_key=example_insights.instrumentation_key,
            ))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_management_name: The name of the API Management Service. Changing this forces a new resource to be created.
        :param pulumi.Input[pulumi.InputType['LoggerApplicationInsightsArgs']] application_insights: An `application_insights` block as documented below.
        :param pulumi.Input[bool] buffered: Specifies whether records should be buffered in the Logger prior to publishing. Defaults to `true`.
        :param pulumi.Input[str] description: A description of this Logger.
        :param pulumi.Input[pulumi.InputType['LoggerEventhubArgs']] eventhub: An `eventhub` block as documented below.
        :param pulumi.Input[str] name: The name of this Logger, which must be unique within the API Management Service. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
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

            if api_management_name is None:
                raise TypeError("Missing required property 'api_management_name'")
            __props__['api_management_name'] = api_management_name
            __props__['application_insights'] = application_insights
            __props__['buffered'] = buffered
            __props__['description'] = description
            __props__['eventhub'] = eventhub
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
        super(Logger, __self__).__init__(
            'azure:apimanagement/logger:Logger',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            api_management_name: Optional[pulumi.Input[str]] = None,
            application_insights: Optional[pulumi.Input[pulumi.InputType['LoggerApplicationInsightsArgs']]] = None,
            buffered: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            eventhub: Optional[pulumi.Input[pulumi.InputType['LoggerEventhubArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None) -> 'Logger':
        """
        Get an existing Logger resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_management_name: The name of the API Management Service. Changing this forces a new resource to be created.
        :param pulumi.Input[pulumi.InputType['LoggerApplicationInsightsArgs']] application_insights: An `application_insights` block as documented below.
        :param pulumi.Input[bool] buffered: Specifies whether records should be buffered in the Logger prior to publishing. Defaults to `true`.
        :param pulumi.Input[str] description: A description of this Logger.
        :param pulumi.Input[pulumi.InputType['LoggerEventhubArgs']] eventhub: An `eventhub` block as documented below.
        :param pulumi.Input[str] name: The name of this Logger, which must be unique within the API Management Service. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["api_management_name"] = api_management_name
        __props__["application_insights"] = application_insights
        __props__["buffered"] = buffered
        __props__["description"] = description
        __props__["eventhub"] = eventhub
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        return Logger(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiManagementName")
    def api_management_name(self) -> pulumi.Output[str]:
        """
        The name of the API Management Service. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "api_management_name")

    @property
    @pulumi.getter(name="applicationInsights")
    def application_insights(self) -> pulumi.Output[Optional['outputs.LoggerApplicationInsights']]:
        """
        An `application_insights` block as documented below.
        """
        return pulumi.get(self, "application_insights")

    @property
    @pulumi.getter
    def buffered(self) -> pulumi.Output[Optional[bool]]:
        """
        Specifies whether records should be buffered in the Logger prior to publishing. Defaults to `true`.
        """
        return pulumi.get(self, "buffered")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        A description of this Logger.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def eventhub(self) -> pulumi.Output[Optional['outputs.LoggerEventhub']]:
        """
        An `eventhub` block as documented below.
        """
        return pulumi.get(self, "eventhub")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of this Logger, which must be unique within the API Management Service. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "resource_group_name")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

