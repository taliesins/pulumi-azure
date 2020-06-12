# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetSnapshotResult:
    """
    A collection of values returned by getSnapshot.
    """
    def __init__(__self__, account_name=None, id=None, location=None, name=None, pool_name=None, resource_group_name=None, volume_name=None):
        if account_name and not isinstance(account_name, str):
            raise TypeError("Expected argument 'account_name' to be a str")
        __self__.account_name = account_name
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        __self__.location = location
        """
        The Azure Region where the NetApp Snapshot exists.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if pool_name and not isinstance(pool_name, str):
            raise TypeError("Expected argument 'pool_name' to be a str")
        __self__.pool_name = pool_name
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if volume_name and not isinstance(volume_name, str):
            raise TypeError("Expected argument 'volume_name' to be a str")
        __self__.volume_name = volume_name
class AwaitableGetSnapshotResult(GetSnapshotResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSnapshotResult(
            account_name=self.account_name,
            id=self.id,
            location=self.location,
            name=self.name,
            pool_name=self.pool_name,
            resource_group_name=self.resource_group_name,
            volume_name=self.volume_name)

def get_snapshot(account_name=None,name=None,pool_name=None,resource_group_name=None,volume_name=None,opts=None):
    """
    Uses this data source to access information about an existing NetApp Snapshot.

    ## NetApp Snapshot Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    test = azure.netapp.get_snapshot(resource_group_name="acctestRG",
        name="acctestnetappsnapshot",
        account_name="acctestnetappaccount",
        pool_name="acctestnetapppool",
        volume_name="acctestnetappvolume")
    pulumi.export("netappSnapshotId", data["azurerm_netapp_snapshot"]["example"]["id"])
    ```


    :param str account_name: The name of the NetApp Account where the NetApp Pool exists.
    :param str name: The name of the NetApp Snapshot.
    :param str pool_name: The name of the NetApp Pool where the NetApp Volume exists.
    :param str resource_group_name: The Name of the Resource Group where the NetApp Snapshot exists.
    :param str volume_name: The name of the NetApp Volume where the NetApp Snapshot exists.
    """
    __args__ = dict()


    __args__['accountName'] = account_name
    __args__['name'] = name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    __args__['volumeName'] = volume_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:netapp/getSnapshot:getSnapshot', __args__, opts=opts).value

    return AwaitableGetSnapshotResult(
        account_name=__ret__.get('accountName'),
        id=__ret__.get('id'),
        location=__ret__.get('location'),
        name=__ret__.get('name'),
        pool_name=__ret__.get('poolName'),
        resource_group_name=__ret__.get('resourceGroupName'),
        volume_name=__ret__.get('volumeName'))
