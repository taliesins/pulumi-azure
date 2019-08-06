# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetDateTimeVariableResult:
    """
    A collection of values returned by getDateTimeVariable.
    """
    def __init__(__self__, automation_account_name=None, description=None, encrypted=None, name=None, resource_group_name=None, value=None, id=None):
        if automation_account_name and not isinstance(automation_account_name, str):
            raise TypeError("Expected argument 'automation_account_name' to be a str")
        __self__.automation_account_name = automation_account_name
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        __self__.description = description
        """
        The description of the Automation Variable.
        """
        if encrypted and not isinstance(encrypted, bool):
            raise TypeError("Expected argument 'encrypted' to be a bool")
        __self__.encrypted = encrypted
        """
        Specifies if the Automation Variable is encrypted. Defaults to `false`.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if value and not isinstance(value, str):
            raise TypeError("Expected argument 'value' to be a str")
        __self__.value = value
        """
        The value of the Automation Variable in the [RFC3339 Section 5.6 Internet Date/Time Format](https://tools.ietf.org/html/rfc3339#section-5.6).
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return self

    __iter__ = __await__

def get_date_time_variable(automation_account_name=None,name=None,resource_group_name=None,opts=None):
    """
    Use this data source to access information about an existing Automation Datetime Variable.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/automation_variable_datetime.html.markdown.
    """
    __args__ = dict()

    __args__['automationAccountName'] = automation_account_name
    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:automation/getDateTimeVariable:getDateTimeVariable', __args__, opts=opts).value

    return GetDateTimeVariableResult(
        automation_account_name=__ret__.get('automationAccountName'),
        description=__ret__.get('description'),
        encrypted=__ret__.get('encrypted'),
        name=__ret__.get('name'),
        resource_group_name=__ret__.get('resourceGroupName'),
        value=__ret__.get('value'),
        id=__ret__.get('id'))
