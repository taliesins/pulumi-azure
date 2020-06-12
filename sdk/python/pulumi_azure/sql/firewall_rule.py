# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class FirewallRule(pulumi.CustomResource):
    end_ip_address: pulumi.Output[str]
    """
    The ending IP address to allow through the firewall for this rule.
    """
    name: pulumi.Output[str]
    """
    The name of the firewall rule.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the sql server.
    """
    server_name: pulumi.Output[str]
    """
    The name of the SQL Server on which to create the Firewall Rule.
    """
    start_ip_address: pulumi.Output[str]
    """
    The starting IP address to allow through the firewall for this rule.
    """
    def __init__(__self__, resource_name, opts=None, end_ip_address=None, name=None, resource_group_name=None, server_name=None, start_ip_address=None, __props__=None, __name__=None, __opts__=None):
        """
        Allows you to manage an Azure SQL Firewall Rule

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West US")
        example_sql_server = azure.sql.SqlServer("exampleSqlServer",
            resource_group_name=example_resource_group.name,
            location="West US",
            version="12.0",
            administrator_login="4dm1n157r470r",
            administrator_login_password="4-v3ry-53cr37-p455w0rd")
        example_firewall_rule = azure.sql.FirewallRule("exampleFirewallRule",
            resource_group_name=example_resource_group.name,
            server_name=example_sql_server.name,
            start_ip_address="10.0.17.62",
            end_ip_address="10.0.17.62")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] end_ip_address: The ending IP address to allow through the firewall for this rule.
        :param pulumi.Input[str] name: The name of the firewall rule.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the sql server.
        :param pulumi.Input[str] server_name: The name of the SQL Server on which to create the Firewall Rule.
        :param pulumi.Input[str] start_ip_address: The starting IP address to allow through the firewall for this rule.
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

            if end_ip_address is None:
                raise TypeError("Missing required property 'end_ip_address'")
            __props__['end_ip_address'] = end_ip_address
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if server_name is None:
                raise TypeError("Missing required property 'server_name'")
            __props__['server_name'] = server_name
            if start_ip_address is None:
                raise TypeError("Missing required property 'start_ip_address'")
            __props__['start_ip_address'] = start_ip_address
        super(FirewallRule, __self__).__init__(
            'azure:sql/firewallRule:FirewallRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, end_ip_address=None, name=None, resource_group_name=None, server_name=None, start_ip_address=None):
        """
        Get an existing FirewallRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] end_ip_address: The ending IP address to allow through the firewall for this rule.
        :param pulumi.Input[str] name: The name of the firewall rule.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the sql server.
        :param pulumi.Input[str] server_name: The name of the SQL Server on which to create the Firewall Rule.
        :param pulumi.Input[str] start_ip_address: The starting IP address to allow through the firewall for this rule.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["end_ip_address"] = end_ip_address
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["server_name"] = server_name
        __props__["start_ip_address"] = start_ip_address
        return FirewallRule(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
