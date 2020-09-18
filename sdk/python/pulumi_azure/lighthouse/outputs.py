# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'DefinitionAuthorization',
]

@pulumi.output_type
class DefinitionAuthorization(dict):
    def __init__(__self__, *,
                 principal_id: str,
                 role_definition_id: str):
        """
        :param str principal_id: Principal ID of the security group/service principal/user that would be assigned permissions to the projected subscription.
        :param str role_definition_id: The role definition identifier. This role will define the permissions that are granted to the principal. This cannot be an `Owner` role.
        """
        pulumi.set(__self__, "principal_id", principal_id)
        pulumi.set(__self__, "role_definition_id", role_definition_id)

    @property
    @pulumi.getter(name="principalId")
    def principal_id(self) -> str:
        """
        Principal ID of the security group/service principal/user that would be assigned permissions to the projected subscription.
        """
        return pulumi.get(self, "principal_id")

    @property
    @pulumi.getter(name="roleDefinitionId")
    def role_definition_id(self) -> str:
        """
        The role definition identifier. This role will define the permissions that are granted to the principal. This cannot be an `Owner` role.
        """
        return pulumi.get(self, "role_definition_id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


