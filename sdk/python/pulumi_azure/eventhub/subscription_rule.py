# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class SubscriptionRule(pulumi.CustomResource):
    action: pulumi.Output[str]
    """
    Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.
    """
    correlation_filter: pulumi.Output[dict]
    """
    A `correlation_filter` block as documented below to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `CorrelationFilter`.
    """
    filter_type: pulumi.Output[str]
    """
    Type of filter to be applied to a BrokeredMessage. Possible values are `SqlFilter` and `CorrelationFilter`.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the ServiceBus Subscription Rule. Changing this forces a new resource to be created.
    """
    namespace_name: pulumi.Output[str]
    """
    The name of the ServiceBus Namespace in which the ServiceBus Topic exists. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in the ServiceBus Namespace exists. Changing this forces a new resource to be created.
    """
    sql_filter: pulumi.Output[str]
    """
    Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `SqlFilter`.
    """
    subscription_name: pulumi.Output[str]
    """
    The name of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.
    """
    topic_name: pulumi.Output[str]
    """
    The name of the ServiceBus Topic in which the ServiceBus Subscription exists. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, action=None, correlation_filter=None, filter_type=None, name=None, namespace_name=None, resource_group_name=None, sql_filter=None, subscription_name=None, topic_name=None, __name__=None, __opts__=None):
        """
        Manage a ServiceBus Subscription Rule.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.
        :param pulumi.Input[dict] correlation_filter: A `correlation_filter` block as documented below to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `CorrelationFilter`.
        :param pulumi.Input[str] filter_type: Type of filter to be applied to a BrokeredMessage. Possible values are `SqlFilter` and `CorrelationFilter`.
        :param pulumi.Input[str] name: Specifies the name of the ServiceBus Subscription Rule. Changing this forces a new resource to be created.
        :param pulumi.Input[str] namespace_name: The name of the ServiceBus Namespace in which the ServiceBus Topic exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in the ServiceBus Namespace exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sql_filter: Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `SqlFilter`.
        :param pulumi.Input[str] subscription_name: The name of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] topic_name: The name of the ServiceBus Topic in which the ServiceBus Subscription exists. Changing this forces a new resource to be created.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/servicebus_subscription_rule.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['action'] = action

        __props__['correlation_filter'] = correlation_filter

        if filter_type is None:
            raise TypeError("Missing required property 'filter_type'")
        __props__['filter_type'] = filter_type

        __props__['name'] = name

        if namespace_name is None:
            raise TypeError("Missing required property 'namespace_name'")
        __props__['namespace_name'] = namespace_name

        if resource_group_name is None:
            raise TypeError("Missing required property 'resource_group_name'")
        __props__['resource_group_name'] = resource_group_name

        __props__['sql_filter'] = sql_filter

        if subscription_name is None:
            raise TypeError("Missing required property 'subscription_name'")
        __props__['subscription_name'] = subscription_name

        if topic_name is None:
            raise TypeError("Missing required property 'topic_name'")
        __props__['topic_name'] = topic_name

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = utilities.get_version()
        super(SubscriptionRule, __self__).__init__(
            'azure:eventhub/subscriptionRule:SubscriptionRule',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

