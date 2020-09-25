# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'EndpointCustomDnsConfig',
    'EndpointPrivateDnsZoneConfig',
    'EndpointPrivateDnsZoneConfigRecordSet',
    'EndpointPrivateDnsZoneGroup',
    'EndpointPrivateServiceConnection',
    'GetEndpointConnectionPrivateServiceConnectionResult',
    'GetServiceEndpointConnectionsPrivateEndpointConnectionResult',
    'GetServiceNatIpConfigurationResult',
]

@pulumi.output_type
class EndpointCustomDnsConfig(dict):
    def __init__(__self__, *,
                 fqdn: Optional[str] = None,
                 ip_addresses: Optional[List[str]] = None):
        """
        :param str fqdn: The fully qualified domain name to the `private_dns_zone`.
        :param List[str] ip_addresses: A list of all IP Addresses that map to the `private_dns_zone` fqdn.
        """
        if fqdn is not None:
            pulumi.set(__self__, "fqdn", fqdn)
        if ip_addresses is not None:
            pulumi.set(__self__, "ip_addresses", ip_addresses)

    @property
    @pulumi.getter
    def fqdn(self) -> Optional[str]:
        """
        The fully qualified domain name to the `private_dns_zone`.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter(name="ipAddresses")
    def ip_addresses(self) -> Optional[List[str]]:
        """
        A list of all IP Addresses that map to the `private_dns_zone` fqdn.
        """
        return pulumi.get(self, "ip_addresses")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class EndpointPrivateDnsZoneConfig(dict):
    def __init__(__self__, *,
                 id: Optional[str] = None,
                 name: Optional[str] = None,
                 private_dns_zone_id: Optional[str] = None,
                 record_sets: Optional[List['outputs.EndpointPrivateDnsZoneConfigRecordSet']] = None):
        """
        :param str id: The ID of the Private DNS Zone Config.
        :param str name: Specifies the Name of the Private Endpoint. Changing this forces a new resource to be created.
        :param str private_dns_zone_id: A list of IP Addresses
        :param List['EndpointPrivateDnsZoneConfigRecordSetArgs'] record_sets: A `record_sets` block as defined below.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if private_dns_zone_id is not None:
            pulumi.set(__self__, "private_dns_zone_id", private_dns_zone_id)
        if record_sets is not None:
            pulumi.set(__self__, "record_sets", record_sets)

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ID of the Private DNS Zone Config.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Specifies the Name of the Private Endpoint. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateDnsZoneId")
    def private_dns_zone_id(self) -> Optional[str]:
        """
        A list of IP Addresses
        """
        return pulumi.get(self, "private_dns_zone_id")

    @property
    @pulumi.getter(name="recordSets")
    def record_sets(self) -> Optional[List['outputs.EndpointPrivateDnsZoneConfigRecordSet']]:
        """
        A `record_sets` block as defined below.
        """
        return pulumi.get(self, "record_sets")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class EndpointPrivateDnsZoneConfigRecordSet(dict):
    def __init__(__self__, *,
                 fqdn: Optional[str] = None,
                 ip_addresses: Optional[List[str]] = None,
                 name: Optional[str] = None,
                 ttl: Optional[float] = None,
                 type: Optional[str] = None):
        """
        :param str fqdn: The fully qualified domain name to the `private_dns_zone`.
        :param List[str] ip_addresses: A list of all IP Addresses that map to the `private_dns_zone` fqdn.
        :param str name: Specifies the Name of the Private Endpoint. Changing this forces a new resource to be created.
        :param float ttl: The time to live for each connection to the `private_dns_zone`.
        :param str type: The type of DNS record.
        """
        if fqdn is not None:
            pulumi.set(__self__, "fqdn", fqdn)
        if ip_addresses is not None:
            pulumi.set(__self__, "ip_addresses", ip_addresses)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if ttl is not None:
            pulumi.set(__self__, "ttl", ttl)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def fqdn(self) -> Optional[str]:
        """
        The fully qualified domain name to the `private_dns_zone`.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter(name="ipAddresses")
    def ip_addresses(self) -> Optional[List[str]]:
        """
        A list of all IP Addresses that map to the `private_dns_zone` fqdn.
        """
        return pulumi.get(self, "ip_addresses")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Specifies the Name of the Private Endpoint. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def ttl(self) -> Optional[float]:
        """
        The time to live for each connection to the `private_dns_zone`.
        """
        return pulumi.get(self, "ttl")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        The type of DNS record.
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class EndpointPrivateDnsZoneGroup(dict):
    def __init__(__self__, *,
                 name: str,
                 private_dns_zone_ids: List[str],
                 id: Optional[str] = None):
        """
        :param str name: Specifies the Name of the Private DNS Zone Group. Changing this forces a new `private_dns_zone_group` resource to be created.
        :param List[str] private_dns_zone_ids: Specifies the list of Private DNS Zones to include within the `private_dns_zone_group`.
        :param str id: The ID of the Private DNS Zone Config.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "private_dns_zone_ids", private_dns_zone_ids)
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Specifies the Name of the Private DNS Zone Group. Changing this forces a new `private_dns_zone_group` resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateDnsZoneIds")
    def private_dns_zone_ids(self) -> List[str]:
        """
        Specifies the list of Private DNS Zones to include within the `private_dns_zone_group`.
        """
        return pulumi.get(self, "private_dns_zone_ids")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        The ID of the Private DNS Zone Config.
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class EndpointPrivateServiceConnection(dict):
    def __init__(__self__, *,
                 is_manual_connection: bool,
                 name: str,
                 private_connection_resource_id: str,
                 private_ip_address: Optional[str] = None,
                 request_message: Optional[str] = None,
                 subresource_names: Optional[List[str]] = None):
        """
        :param bool is_manual_connection: Does the Private Endpoint require Manual Approval from the remote resource owner? Changing this forces a new resource to be created.
        :param str name: Specifies the Name of the Private Service Connection. Changing this forces a new resource to be created.
        :param str private_connection_resource_id: The ID of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. Changing this forces a new resource to be created.
        :param str private_ip_address: (Computed) The private IP address associated with the private endpoint, note that you will have a private IP address assigned to the private endpoint even if the connection request was `Rejected`.
        :param str request_message: A message passed to the owner of the remote resource when the private endpoint attempts to establish the connection to the remote resource. The request message can be a maximum of `140` characters in length. Only valid if `is_manual_connection` is set to `true`.
        :param List[str] subresource_names: A list of subresource names which the Private Endpoint is able to connect to. `subresource_names` corresponds to `group_id`. Changing this forces a new resource to be created.
        """
        pulumi.set(__self__, "is_manual_connection", is_manual_connection)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "private_connection_resource_id", private_connection_resource_id)
        if private_ip_address is not None:
            pulumi.set(__self__, "private_ip_address", private_ip_address)
        if request_message is not None:
            pulumi.set(__self__, "request_message", request_message)
        if subresource_names is not None:
            pulumi.set(__self__, "subresource_names", subresource_names)

    @property
    @pulumi.getter(name="isManualConnection")
    def is_manual_connection(self) -> bool:
        """
        Does the Private Endpoint require Manual Approval from the remote resource owner? Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "is_manual_connection")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Specifies the Name of the Private Service Connection. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateConnectionResourceId")
    def private_connection_resource_id(self) -> str:
        """
        The ID of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "private_connection_resource_id")

    @property
    @pulumi.getter(name="privateIpAddress")
    def private_ip_address(self) -> Optional[str]:
        """
        (Computed) The private IP address associated with the private endpoint, note that you will have a private IP address assigned to the private endpoint even if the connection request was `Rejected`.
        """
        return pulumi.get(self, "private_ip_address")

    @property
    @pulumi.getter(name="requestMessage")
    def request_message(self) -> Optional[str]:
        """
        A message passed to the owner of the remote resource when the private endpoint attempts to establish the connection to the remote resource. The request message can be a maximum of `140` characters in length. Only valid if `is_manual_connection` is set to `true`.
        """
        return pulumi.get(self, "request_message")

    @property
    @pulumi.getter(name="subresourceNames")
    def subresource_names(self) -> Optional[List[str]]:
        """
        A list of subresource names which the Private Endpoint is able to connect to. `subresource_names` corresponds to `group_id`. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "subresource_names")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GetEndpointConnectionPrivateServiceConnectionResult(dict):
    def __init__(__self__, *,
                 name: str,
                 private_ip_address: str,
                 request_response: str,
                 status: str):
        """
        :param str name: Specifies the Name of the private endpoint.
        :param str private_ip_address: The private IP address associated with the private endpoint, note that you will have a private IP address assigned to the private endpoint even if the connection request was `Rejected`.
        :param str request_response: Possible values are as follows:
               Value | Meaning
               -- | --
               `Auto-Approved` | The remote resource owner has added you to the `Auto-Approved` RBAC permission list for the remote resource, all private endpoint connection requests will be automatically `Approved`.
               `Deleted state` | The resource owner has `Rejected` the private endpoint connection request and has removed your private endpoint request from the remote resource.
               `request/response message` | If you submitted a manual private endpoint connection request, while in the `Pending` status the `request_response` will display the same text from your `request_message` in the `private_service_connection` block above. If the private endpoint connection request was `Rejected` by the owner of the remote resource, the text for the rejection will be displayed as the `request_response` text, if the private endpoint connection request was `Approved` by the owner of the remote resource, the text for the approval will be displayed as the `request_response` text
        :param str status: The current status of the private endpoint request, possible values will be `Pending`, `Approved`, `Rejected`, or `Disconnected`.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "private_ip_address", private_ip_address)
        pulumi.set(__self__, "request_response", request_response)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Specifies the Name of the private endpoint.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="privateIpAddress")
    def private_ip_address(self) -> str:
        """
        The private IP address associated with the private endpoint, note that you will have a private IP address assigned to the private endpoint even if the connection request was `Rejected`.
        """
        return pulumi.get(self, "private_ip_address")

    @property
    @pulumi.getter(name="requestResponse")
    def request_response(self) -> str:
        """
        Possible values are as follows:
        Value | Meaning
        -- | --
        `Auto-Approved` | The remote resource owner has added you to the `Auto-Approved` RBAC permission list for the remote resource, all private endpoint connection requests will be automatically `Approved`.
        `Deleted state` | The resource owner has `Rejected` the private endpoint connection request and has removed your private endpoint request from the remote resource.
        `request/response message` | If you submitted a manual private endpoint connection request, while in the `Pending` status the `request_response` will display the same text from your `request_message` in the `private_service_connection` block above. If the private endpoint connection request was `Rejected` by the owner of the remote resource, the text for the rejection will be displayed as the `request_response` text, if the private endpoint connection request was `Approved` by the owner of the remote resource, the text for the approval will be displayed as the `request_response` text
        """
        return pulumi.get(self, "request_response")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The current status of the private endpoint request, possible values will be `Pending`, `Approved`, `Rejected`, or `Disconnected`.
        """
        return pulumi.get(self, "status")


@pulumi.output_type
class GetServiceEndpointConnectionsPrivateEndpointConnectionResult(dict):
    def __init__(__self__, *,
                 action_required: str,
                 connection_id: str,
                 connection_name: str,
                 description: str,
                 private_endpoint_id: str,
                 private_endpoint_name: str,
                 status: str):
        """
        :param str action_required: A message indicating if changes on the service provider require any updates or not.
        :param str connection_id: The resource id of the private link service connection between the private link service and the private link endpoint.
        :param str connection_name: The name of the connection between the private link service and the private link endpoint.
        :param str description: The request for approval message or the reason for rejection message.
        :param str private_endpoint_id: The resource id of the private link endpoint.
        :param str private_endpoint_name: The name of the private link endpoint.
        :param str status: Indicates the state of the connection between the private link service and the private link endpoint, possible values are `Pending`, `Approved` or `Rejected`.
        """
        pulumi.set(__self__, "action_required", action_required)
        pulumi.set(__self__, "connection_id", connection_id)
        pulumi.set(__self__, "connection_name", connection_name)
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "private_endpoint_id", private_endpoint_id)
        pulumi.set(__self__, "private_endpoint_name", private_endpoint_name)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="actionRequired")
    def action_required(self) -> str:
        """
        A message indicating if changes on the service provider require any updates or not.
        """
        return pulumi.get(self, "action_required")

    @property
    @pulumi.getter(name="connectionId")
    def connection_id(self) -> str:
        """
        The resource id of the private link service connection between the private link service and the private link endpoint.
        """
        return pulumi.get(self, "connection_id")

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> str:
        """
        The name of the connection between the private link service and the private link endpoint.
        """
        return pulumi.get(self, "connection_name")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The request for approval message or the reason for rejection message.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="privateEndpointId")
    def private_endpoint_id(self) -> str:
        """
        The resource id of the private link endpoint.
        """
        return pulumi.get(self, "private_endpoint_id")

    @property
    @pulumi.getter(name="privateEndpointName")
    def private_endpoint_name(self) -> str:
        """
        The name of the private link endpoint.
        """
        return pulumi.get(self, "private_endpoint_name")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Indicates the state of the connection between the private link service and the private link endpoint, possible values are `Pending`, `Approved` or `Rejected`.
        """
        return pulumi.get(self, "status")


@pulumi.output_type
class GetServiceNatIpConfigurationResult(dict):
    def __init__(__self__, *,
                 name: str,
                 primary: bool,
                 private_ip_address: str,
                 private_ip_address_version: str,
                 subnet_id: str):
        """
        :param str name: The name of the private link service.
        :param bool primary: Value that indicates if the IP configuration is the primary configuration or not.
        :param str private_ip_address: The private IP address of the NAT IP configuration.
        :param str private_ip_address_version: The version of the IP Protocol.
        :param str subnet_id: The ID of the subnet to be used by the service.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "primary", primary)
        pulumi.set(__self__, "private_ip_address", private_ip_address)
        pulumi.set(__self__, "private_ip_address_version", private_ip_address_version)
        pulumi.set(__self__, "subnet_id", subnet_id)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the private link service.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def primary(self) -> bool:
        """
        Value that indicates if the IP configuration is the primary configuration or not.
        """
        return pulumi.get(self, "primary")

    @property
    @pulumi.getter(name="privateIpAddress")
    def private_ip_address(self) -> str:
        """
        The private IP address of the NAT IP configuration.
        """
        return pulumi.get(self, "private_ip_address")

    @property
    @pulumi.getter(name="privateIpAddressVersion")
    def private_ip_address_version(self) -> str:
        """
        The version of the IP Protocol.
        """
        return pulumi.get(self, "private_ip_address_version")

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> str:
        """
        The ID of the subnet to be used by the service.
        """
        return pulumi.get(self, "subnet_id")


