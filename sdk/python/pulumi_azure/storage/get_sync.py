# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'GetSyncResult',
    'AwaitableGetSyncResult',
    'get_sync',
]

@pulumi.output_type
class GetSyncResult:
    """
    A collection of values returned by getSync.
    """
    def __init__(__self__, id=None, incoming_traffic_policy=None, location=None, name=None, resource_group_name=None, tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if incoming_traffic_policy and not isinstance(incoming_traffic_policy, str):
            raise TypeError("Expected argument 'incoming_traffic_policy' to be a str")
        pulumi.set(__self__, "incoming_traffic_policy", incoming_traffic_policy)
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        pulumi.set(__self__, "location", location)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="incomingTrafficPolicy")
    def incoming_traffic_policy(self) -> str:
        """
        Incoming traffic policy.
        """
        return pulumi.get(self, "incoming_traffic_policy")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        The Azure Region where the Storage Sync exists.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> str:
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter
    def tags(self) -> Mapping[str, str]:
        """
        A mapping of tags assigned to the Storage Sync.
        """
        return pulumi.get(self, "tags")


class AwaitableGetSyncResult(GetSyncResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSyncResult(
            id=self.id,
            incoming_traffic_policy=self.incoming_traffic_policy,
            location=self.location,
            name=self.name,
            resource_group_name=self.resource_group_name,
            tags=self.tags)


def get_sync(name: Optional[str] = None,
             resource_group_name: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSyncResult:
    """
    Use this data source to access information about an existing Storage Sync.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.storage.get_sync(name="existingStorageSyncName",
        resource_group_name="existingResGroup")
    pulumi.export("id", example.id)
    ```


    :param str name: The name of this Storage Sync.
    :param str resource_group_name: The name of the Resource Group where the Storage Sync exists.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:storage/getSync:getSync', __args__, opts=opts, typ=GetSyncResult).value

    return AwaitableGetSyncResult(
        id=__ret__.id,
        incoming_traffic_policy=__ret__.incoming_traffic_policy,
        location=__ret__.location,
        name=__ret__.name,
        resource_group_name=__ret__.resource_group_name,
        tags=__ret__.tags)
