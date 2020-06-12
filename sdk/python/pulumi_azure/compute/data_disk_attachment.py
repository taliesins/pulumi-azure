# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class DataDiskAttachment(pulumi.CustomResource):
    caching: pulumi.Output[str]
    """
    Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
    """
    create_option: pulumi.Output[str]
    """
    The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
    """
    lun: pulumi.Output[float]
    """
    The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
    """
    managed_disk_id: pulumi.Output[str]
    """
    The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
    """
    virtual_machine_id: pulumi.Output[str]
    """
    The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
    """
    write_accelerator_enabled: pulumi.Output[bool]
    """
    Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
    """
    def __init__(__self__, resource_name, opts=None, caching=None, create_option=None, lun=None, managed_disk_id=None, virtual_machine_id=None, write_accelerator_enabled=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages attaching a Disk to a Virtual Machine.

        > **NOTE:** Data Disks can be attached either directly on the `compute.VirtualMachine` resource, or using the `compute.DataDiskAttachment` resource - but the two cannot be used together. If both are used against the same Virtual Machine, spurious changes will occur.

        > **Please Note:** only Managed Disks are supported via this separate resource, Unmanaged Disks can be attached using the `storage_data_disk` block in the `compute.VirtualMachine` resource.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        config = pulumi.Config()
        prefix = config.get("prefix")
        if prefix is None:
            prefix = "example"
        vm_name = f"{prefix}-vm"
        main_resource_group = azure.core.ResourceGroup("mainResourceGroup", location="West Europe")
        main_virtual_network = azure.network.VirtualNetwork("mainVirtualNetwork",
            address_spaces=["10.0.0.0/16"],
            location=main_resource_group.location,
            resource_group_name=main_resource_group.name)
        internal = azure.network.Subnet("internal",
            resource_group_name=main_resource_group.name,
            virtual_network_name=main_virtual_network.name,
            address_prefix="10.0.2.0/24")
        main_network_interface = azure.network.NetworkInterface("mainNetworkInterface",
            location=main_resource_group.location,
            resource_group_name=main_resource_group.name,
            ip_configuration=[{
                "name": "internal",
                "subnet_id": internal.id,
                "privateIpAddressAllocation": "Dynamic",
            }])
        example_virtual_machine = azure.compute.VirtualMachine("exampleVirtualMachine",
            location=main_resource_group.location,
            resource_group_name=main_resource_group.name,
            network_interface_ids=[main_network_interface.id],
            vm_size="Standard_F2",
            storage_image_reference={
                "publisher": "Canonical",
                "offer": "UbuntuServer",
                "sku": "16.04-LTS",
                "version": "latest",
            },
            storage_os_disk={
                "name": "myosdisk1",
                "caching": "ReadWrite",
                "create_option": "FromImage",
                "managedDiskType": "Standard_LRS",
            },
            os_profile={
                "computer_name": vm_name,
                "admin_username": "testadmin",
                "admin_password": "Password1234!",
            },
            os_profile_linux_config={
                "disable_password_authentication": False,
            })
        example_managed_disk = azure.compute.ManagedDisk("exampleManagedDisk",
            location=main_resource_group.location,
            resource_group_name=main_resource_group.name,
            storage_account_type="Standard_LRS",
            create_option="Empty",
            disk_size_gb=10)
        example_data_disk_attachment = azure.compute.DataDiskAttachment("exampleDataDiskAttachment",
            managed_disk_id=example_managed_disk.id,
            virtual_machine_id=example_virtual_machine.id,
            lun="10",
            caching="ReadWrite")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] caching: Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
        :param pulumi.Input[str] create_option: The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
        :param pulumi.Input[float] lun: The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[str] managed_disk_id: The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
        :param pulumi.Input[str] virtual_machine_id: The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] write_accelerator_enabled: Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
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

            if caching is None:
                raise TypeError("Missing required property 'caching'")
            __props__['caching'] = caching
            __props__['create_option'] = create_option
            if lun is None:
                raise TypeError("Missing required property 'lun'")
            __props__['lun'] = lun
            if managed_disk_id is None:
                raise TypeError("Missing required property 'managed_disk_id'")
            __props__['managed_disk_id'] = managed_disk_id
            if virtual_machine_id is None:
                raise TypeError("Missing required property 'virtual_machine_id'")
            __props__['virtual_machine_id'] = virtual_machine_id
            __props__['write_accelerator_enabled'] = write_accelerator_enabled
        super(DataDiskAttachment, __self__).__init__(
            'azure:compute/dataDiskAttachment:DataDiskAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, caching=None, create_option=None, lun=None, managed_disk_id=None, virtual_machine_id=None, write_accelerator_enabled=None):
        """
        Get an existing DataDiskAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] caching: Specifies the caching requirements for this Data Disk. Possible values include `None`, `ReadOnly` and `ReadWrite`.
        :param pulumi.Input[str] create_option: The Create Option of the Data Disk, such as `Empty` or `Attach`. Defaults to `Attach`. Changing this forces a new resource to be created.
        :param pulumi.Input[float] lun: The Logical Unit Number of the Data Disk, which needs to be unique within the Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[str] managed_disk_id: The ID of an existing Managed Disk which should be attached. Changing this forces a new resource to be created.
        :param pulumi.Input[str] virtual_machine_id: The ID of the Virtual Machine to which the Data Disk should be attached. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] write_accelerator_enabled: Specifies if Write Accelerator is enabled on the disk. This can only be enabled on `Premium_LRS` managed disks with no caching and [M-Series VMs](https://docs.microsoft.com/en-us/azure/virtual-machines/workloads/sap/how-to-enable-write-accelerator). Defaults to `false`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["caching"] = caching
        __props__["create_option"] = create_option
        __props__["lun"] = lun
        __props__["managed_disk_id"] = managed_disk_id
        __props__["virtual_machine_id"] = virtual_machine_id
        __props__["write_accelerator_enabled"] = write_accelerator_enabled
        return DataDiskAttachment(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
