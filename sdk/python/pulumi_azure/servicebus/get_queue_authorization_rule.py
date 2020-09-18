# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'GetQueueAuthorizationRuleResult',
    'AwaitableGetQueueAuthorizationRuleResult',
    'get_queue_authorization_rule',
]

@pulumi.output_type
class GetQueueAuthorizationRuleResult:
    """
    A collection of values returned by getQueueAuthorizationRule.
    """
    def __init__(__self__, id=None, listen=None, manage=None, name=None, namespace_name=None, primary_connection_string=None, primary_key=None, queue_name=None, resource_group_name=None, secondary_connection_string=None, secondary_key=None, send=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if listen and not isinstance(listen, bool):
            raise TypeError("Expected argument 'listen' to be a bool")
        pulumi.set(__self__, "listen", listen)
        if manage and not isinstance(manage, bool):
            raise TypeError("Expected argument 'manage' to be a bool")
        pulumi.set(__self__, "manage", manage)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if namespace_name and not isinstance(namespace_name, str):
            raise TypeError("Expected argument 'namespace_name' to be a str")
        pulumi.set(__self__, "namespace_name", namespace_name)
        if primary_connection_string and not isinstance(primary_connection_string, str):
            raise TypeError("Expected argument 'primary_connection_string' to be a str")
        pulumi.set(__self__, "primary_connection_string", primary_connection_string)
        if primary_key and not isinstance(primary_key, str):
            raise TypeError("Expected argument 'primary_key' to be a str")
        pulumi.set(__self__, "primary_key", primary_key)
        if queue_name and not isinstance(queue_name, str):
            raise TypeError("Expected argument 'queue_name' to be a str")
        pulumi.set(__self__, "queue_name", queue_name)
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if secondary_connection_string and not isinstance(secondary_connection_string, str):
            raise TypeError("Expected argument 'secondary_connection_string' to be a str")
        pulumi.set(__self__, "secondary_connection_string", secondary_connection_string)
        if secondary_key and not isinstance(secondary_key, str):
            raise TypeError("Expected argument 'secondary_key' to be a str")
        pulumi.set(__self__, "secondary_key", secondary_key)
        if send and not isinstance(send, bool):
            raise TypeError("Expected argument 'send' to be a bool")
        pulumi.set(__self__, "send", send)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def listen(self) -> bool:
        return pulumi.get(self, "listen")

    @property
    @pulumi.getter
    def manage(self) -> bool:
        return pulumi.get(self, "manage")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> str:
        return pulumi.get(self, "namespace_name")

    @property
    @pulumi.getter(name="primaryConnectionString")
    def primary_connection_string(self) -> str:
        """
        The Primary Connection String for the ServiceBus Queue authorization Rule.
        """
        return pulumi.get(self, "primary_connection_string")

    @property
    @pulumi.getter(name="primaryKey")
    def primary_key(self) -> str:
        """
        The Primary Key for the ServiceBus Queue authorization Rule.
        """
        return pulumi.get(self, "primary_key")

    @property
    @pulumi.getter(name="queueName")
    def queue_name(self) -> str:
        return pulumi.get(self, "queue_name")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> str:
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter(name="secondaryConnectionString")
    def secondary_connection_string(self) -> str:
        """
        The Secondary Connection String for the ServiceBus Queue authorization Rule.
        """
        return pulumi.get(self, "secondary_connection_string")

    @property
    @pulumi.getter(name="secondaryKey")
    def secondary_key(self) -> str:
        """
        The Secondary Key for the ServiceBus Queue authorization Rule.
        """
        return pulumi.get(self, "secondary_key")

    @property
    @pulumi.getter
    def send(self) -> bool:
        return pulumi.get(self, "send")


class AwaitableGetQueueAuthorizationRuleResult(GetQueueAuthorizationRuleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetQueueAuthorizationRuleResult(
            id=self.id,
            listen=self.listen,
            manage=self.manage,
            name=self.name,
            namespace_name=self.namespace_name,
            primary_connection_string=self.primary_connection_string,
            primary_key=self.primary_key,
            queue_name=self.queue_name,
            resource_group_name=self.resource_group_name,
            secondary_connection_string=self.secondary_connection_string,
            secondary_key=self.secondary_key,
            send=self.send)


def get_queue_authorization_rule(name: Optional[str] = None,
                                 namespace_name: Optional[str] = None,
                                 queue_name: Optional[str] = None,
                                 resource_group_name: Optional[str] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetQueueAuthorizationRuleResult:
    """
    Use this data source to access information about an existing ServiceBus Queue Authorisation Rule within a ServiceBus Queue.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.servicebus.get_queue_authorization_rule(name="example-tfex_name",
        resource_group_name="example-resources",
        queue_name="example-servicebus_queue",
        namespace_name="example-namespace")
    pulumi.export("id", example.id)
    ```


    :param str name: The name of this ServiceBus Queue Authorisation Rule.
    :param str namespace_name: The name of the ServiceBus Namespace.
    :param str queue_name: The name of the ServiceBus Queue.
    :param str resource_group_name: The name of the Resource Group where the ServiceBus Queue Authorisation Rule exists.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['namespaceName'] = namespace_name
    __args__['queueName'] = queue_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:servicebus/getQueueAuthorizationRule:getQueueAuthorizationRule', __args__, opts=opts, typ=GetQueueAuthorizationRuleResult).value

    return AwaitableGetQueueAuthorizationRuleResult(
        id=__ret__.id,
        listen=__ret__.listen,
        manage=__ret__.manage,
        name=__ret__.name,
        namespace_name=__ret__.namespace_name,
        primary_connection_string=__ret__.primary_connection_string,
        primary_key=__ret__.primary_key,
        queue_name=__ret__.queue_name,
        resource_group_name=__ret__.resource_group_name,
        secondary_connection_string=__ret__.secondary_connection_string,
        secondary_key=__ret__.secondary_key,
        send=__ret__.send)
