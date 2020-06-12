# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetPublishedVersionResult:
    """
    A collection of values returned by getPublishedVersion.
    """
    def __init__(__self__, blueprint_name=None, description=None, display_name=None, id=None, last_modified=None, scope_id=None, target_scope=None, time_created=None, type=None, version=None):
        if blueprint_name and not isinstance(blueprint_name, str):
            raise TypeError("Expected argument 'blueprint_name' to be a str")
        __self__.blueprint_name = blueprint_name
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        __self__.description = description
        """
        The description of the Blueprint Published Version  
        """
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        __self__.display_name = display_name
        """
        The display name of the Blueprint Published Version  
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if last_modified and not isinstance(last_modified, str):
            raise TypeError("Expected argument 'last_modified' to be a str")
        __self__.last_modified = last_modified
        if scope_id and not isinstance(scope_id, str):
            raise TypeError("Expected argument 'scope_id' to be a str")
        __self__.scope_id = scope_id
        if target_scope and not isinstance(target_scope, str):
            raise TypeError("Expected argument 'target_scope' to be a str")
        __self__.target_scope = target_scope
        """
        The target scope  
        """
        if time_created and not isinstance(time_created, str):
            raise TypeError("Expected argument 'time_created' to be a str")
        __self__.time_created = time_created
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        __self__.type = type
        """
        The type of the Blueprint  
        """
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        __self__.version = version
class AwaitableGetPublishedVersionResult(GetPublishedVersionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPublishedVersionResult(
            blueprint_name=self.blueprint_name,
            description=self.description,
            display_name=self.display_name,
            id=self.id,
            last_modified=self.last_modified,
            scope_id=self.scope_id,
            target_scope=self.target_scope,
            time_created=self.time_created,
            type=self.type,
            version=self.version)

def get_published_version(blueprint_name=None,scope_id=None,version=None,opts=None):
    """
    Use this data source to access information about an existing Azure Blueprint Published Version

    > **NOTE:** Azure Blueprints are in Preview and potentially subject to breaking change without notice.


    ## Example Usage



    ```python
    import pulumi
    import pulumi_azure as azure

    current = azure.core.get_subscription()
    test = azure.blueprint.get_published_version(scope_id=current.id,
        blueprint_name="exampleBluePrint",
        version="dev_v2.3")
    ```



    :param str blueprint_name: The name of the Blueprint Definition
    :param str scope_id: The Resource ID of the scope where the Blueprint Definition is stored. This will be with either a Subscription ID or Management Group ID.
    :param str version: The Version name of the Published Version of the Blueprint Definition
    """
    __args__ = dict()


    __args__['blueprintName'] = blueprint_name
    __args__['scopeId'] = scope_id
    __args__['version'] = version
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:blueprint/getPublishedVersion:getPublishedVersion', __args__, opts=opts).value

    return AwaitableGetPublishedVersionResult(
        blueprint_name=__ret__.get('blueprintName'),
        description=__ret__.get('description'),
        display_name=__ret__.get('displayName'),
        id=__ret__.get('id'),
        last_modified=__ret__.get('lastModified'),
        scope_id=__ret__.get('scopeId'),
        target_scope=__ret__.get('targetScope'),
        time_created=__ret__.get('timeCreated'),
        type=__ret__.get('type'),
        version=__ret__.get('version'))
