# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetAccessPolicyResult:
    """
    A collection of values returned by getAccessPolicy.
    """
    def __init__(__self__, certificate_permissions=None, id=None, key_permissions=None, name=None, secret_permissions=None):
        if certificate_permissions and not isinstance(certificate_permissions, list):
            raise TypeError("Expected argument 'certificate_permissions' to be a list")
        __self__.certificate_permissions = certificate_permissions
        """
        the certificate permissions for the access policy
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if key_permissions and not isinstance(key_permissions, list):
            raise TypeError("Expected argument 'key_permissions' to be a list")
        __self__.key_permissions = key_permissions
        """
        the key permissions for the access policy
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if secret_permissions and not isinstance(secret_permissions, list):
            raise TypeError("Expected argument 'secret_permissions' to be a list")
        __self__.secret_permissions = secret_permissions
        """
        the secret permissions for the access policy
        """
class AwaitableGetAccessPolicyResult(GetAccessPolicyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAccessPolicyResult(
            certificate_permissions=self.certificate_permissions,
            id=self.id,
            key_permissions=self.key_permissions,
            name=self.name,
            secret_permissions=self.secret_permissions)

def get_access_policy(name=None,opts=None):
    """
    Use this data source to access information about the permissions from the Management Key Vault Templates.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_azure as azure

    contributor = azure.keyvault.get_access_policy(name="Key Management")
    pulumi.export("accessPolicyKeyPermissions", contributor.key_permissions)
    ```


    :param str name: Specifies the name of the Management Template. Possible values are: `Key Management`,
           `Secret Management`, `Certificate Management`, `Key & Secret Management`, `Key & Certificate Management`,
           `Secret & Certificate Management`,  `Key, Secret, & Certificate Management`
    """
    __args__ = dict()


    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:keyvault/getAccessPolicy:getAccessPolicy', __args__, opts=opts).value

    return AwaitableGetAccessPolicyResult(
        certificate_permissions=__ret__.get('certificatePermissions'),
        id=__ret__.get('id'),
        key_permissions=__ret__.get('keyPermissions'),
        name=__ret__.get('name'),
        secret_permissions=__ret__.get('secretPermissions'))
