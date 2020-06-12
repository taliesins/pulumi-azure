# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class HadoopCluster(pulumi.CustomResource):
    cluster_version: pulumi.Output[str]
    """
    Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
    """
    component_version: pulumi.Output[dict]
    """
    A `component_version` block as defined below.

      * `hadoop` (`str`) - The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.
    """
    gateway: pulumi.Output[dict]
    """
    A `gateway` block as defined below.

      * `enabled` (`bool`) - Is the Ambari portal enabled? Changing this forces a new resource to be created.
      * `password` (`str`) - The password used for the Ambari Portal. Changing this forces a new resource to be created.
      * `username` (`str`) - The username used for the Ambari Portal. Changing this forces a new resource to be created.
    """
    https_endpoint: pulumi.Output[str]
    """
    The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster.
    """
    location: pulumi.Output[str]
    """
    Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
    """
    metastores: pulumi.Output[dict]
    """
    A `metastores` block as defined below.

      * `ambari` (`dict`) - An `ambari` block as defined below.
        * `database_name` (`str`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
        * `password` (`str`) - The external Ambari metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
        * `server` (`str`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Ambari metastore.  Changing this forces a new resource to be created.
        * `username` (`str`) - The external Ambari metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

      * `hive` (`dict`) - A `hive` block as defined below.
        * `database_name` (`str`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
        * `password` (`str`) - The external Hive metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
        * `server` (`str`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Hive metastore.  Changing this forces a new resource to be created.
        * `username` (`str`) - The external Hive metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

      * `oozie` (`dict`) - An `oozie` block as defined below.
        * `database_name` (`str`) - The external Oozie metastore's existing SQL database.  Changing this forces a new resource to be created.
        * `password` (`str`) - The external Oozie metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
        * `server` (`str`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore.  Changing this forces a new resource to be created.
        * `username` (`str`) - The external Oozie metastore's existing SQL server admin username.  Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
    """
    roles: pulumi.Output[dict]
    """
    A `roles` block as defined below.

      * `edgeNode` (`dict`) - A `edge_node` block as defined below.
        * `installScriptActions` (`list`) - A `install_script_action` block as defined below.
          * `name` (`str`) - The name of the install script action. Changing this forces a new resource to be created.
          * `uri` (`str`) - The URI pointing to the script to run during the installation of the edge node. Changing this forces a new resource to be created.

        * `targetInstanceCount` (`float`) - The number of instances which should be run for the Worker Nodes.
        * `vm_size` (`str`) - The Size of the Virtual Machine which should be used as the Edge Nodes. Changing this forces a new resource to be created.

      * `headNode` (`dict`) - A `head_node` block as defined above.
        * `password` (`str`) - The Password associated with the local administrator for the Head Nodes. Changing this forces a new resource to be created.
        * `sshKeys` (`list`) - A list of SSH Keys which should be used for the local administrator on the Head Nodes. Changing this forces a new resource to be created.
        * `subnet_id` (`str`) - The ID of the Subnet within the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `username` (`str`) - The Username of the local administrator for the Head Nodes. Changing this forces a new resource to be created.
        * `virtual_network_id` (`str`) - The ID of the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `vm_size` (`str`) - The Size of the Virtual Machine which should be used as the Head Nodes. Changing this forces a new resource to be created.

      * `workerNode` (`dict`) - A `worker_node` block as defined below.
        * `minInstanceCount` (`float`) - The minimum number of instances which should be run for the Worker Nodes. Changing this forces a new resource to be created.
        * `password` (`str`) - The Password associated with the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
        * `sshKeys` (`list`) - A list of SSH Keys which should be used for the local administrator on the Worker Nodes. Changing this forces a new resource to be created.
        * `subnet_id` (`str`) - The ID of the Subnet within the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `targetInstanceCount` (`float`) - The number of instances which should be run for the Worker Nodes.
        * `username` (`str`) - The Username of the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
        * `virtual_network_id` (`str`) - The ID of the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `vm_size` (`str`) - The Size of the Virtual Machine which should be used as the Worker Nodes. Changing this forces a new resource to be created.

      * `zookeeperNode` (`dict`) - A `zookeeper_node` block as defined below.
        * `password` (`str`) - The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
        * `sshKeys` (`list`) - A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.
        * `subnet_id` (`str`) - The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `username` (`str`) - The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
        * `virtual_network_id` (`str`) - The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
        * `vm_size` (`str`) - The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Changing this forces a new resource to be created.
    """
    ssh_endpoint: pulumi.Output[str]
    """
    The SSH Connectivity Endpoint for this HDInsight Hadoop Cluster.
    """
    storage_account_gen2: pulumi.Output[dict]
    """
    A `storage_account_gen2` block as defined below.

      * `filesystemId` (`str`) - The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.
      * `isDefault` (`bool`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
      * `managedIdentityResourceId` (`str`) - The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.
      * `storageResourceId` (`str`) - The ID of the Storage Account. Changing this forces a new resource to be created.
    """
    storage_accounts: pulumi.Output[list]
    """
    One or more `storage_account` block as defined below.

      * `isDefault` (`bool`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
      * `storage_account_key` (`str`) - The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.
      * `storage_container_id` (`str`) - The ID of the Storage Container. Changing this forces a new resource to be created.
    """
    tags: pulumi.Output[dict]
    """
    A map of Tags which should be assigned to this HDInsight Hadoop Cluster.
    """
    tier: pulumi.Output[str]
    """
    Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.
    """
    tls_min_version: pulumi.Output[str]
    def __init__(__self__, resource_name, opts=None, cluster_version=None, component_version=None, gateway=None, location=None, metastores=None, name=None, resource_group_name=None, roles=None, storage_account_gen2=None, storage_accounts=None, tags=None, tier=None, tls_min_version=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a HDInsight Hadoop Cluster.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS")
        example_container = azure.storage.Container("exampleContainer",
            storage_account_name=example_account.name,
            container_access_type="private")
        example_hadoop_cluster = azure.hdinsight.HadoopCluster("exampleHadoopCluster",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            cluster_version="3.6",
            tier="Standard",
            component_version={
                "hadoop": "2.7",
            },
            gateway={
                "enabled": True,
                "username": "acctestusrgw",
                "password": "PAssword123!",
            },
            storage_account=[{
                "storage_container_id": example_container.id,
                "storage_account_key": example_account.primary_access_key,
                "isDefault": True,
            }],
            roles={
                "head_node": {
                    "vm_size": "Standard_D3_V2",
                    "username": "acctestusrvm",
                    "password": "AccTestvdSC4daf986!",
                },
                "worker_node": {
                    "vm_size": "Standard_D4_V2",
                    "username": "acctestusrvm",
                    "password": "AccTestvdSC4daf986!",
                    "targetInstanceCount": 3,
                },
                "zookeeper_node": {
                    "vm_size": "Standard_D3_V2",
                    "username": "acctestusrvm",
                    "password": "AccTestvdSC4daf986!",
                },
            })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_version: Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] component_version: A `component_version` block as defined below.
        :param pulumi.Input[dict] gateway: A `gateway` block as defined below.
        :param pulumi.Input[str] location: Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] metastores: A `metastores` block as defined below.
        :param pulumi.Input[str] name: Specifies the name for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] roles: A `roles` block as defined below.
        :param pulumi.Input[dict] storage_account_gen2: A `storage_account_gen2` block as defined below.
        :param pulumi.Input[list] storage_accounts: One or more `storage_account` block as defined below.
        :param pulumi.Input[dict] tags: A map of Tags which should be assigned to this HDInsight Hadoop Cluster.
        :param pulumi.Input[str] tier: Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.

        The **component_version** object supports the following:

          * `hadoop` (`pulumi.Input[str]`) - The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.

        The **gateway** object supports the following:

          * `enabled` (`pulumi.Input[bool]`) - Is the Ambari portal enabled? Changing this forces a new resource to be created.
          * `password` (`pulumi.Input[str]`) - The password used for the Ambari Portal. Changing this forces a new resource to be created.
          * `username` (`pulumi.Input[str]`) - The username used for the Ambari Portal. Changing this forces a new resource to be created.

        The **metastores** object supports the following:

          * `ambari` (`pulumi.Input[dict]`) - An `ambari` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Ambari metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Ambari metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Ambari metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

          * `hive` (`pulumi.Input[dict]`) - A `hive` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Hive metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

          * `oozie` (`pulumi.Input[dict]`) - An `oozie` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

        The **roles** object supports the following:

          * `edgeNode` (`pulumi.Input[dict]`) - A `edge_node` block as defined below.
            * `installScriptActions` (`pulumi.Input[list]`) - A `install_script_action` block as defined below.
              * `name` (`pulumi.Input[str]`) - The name of the install script action. Changing this forces a new resource to be created.
              * `uri` (`pulumi.Input[str]`) - The URI pointing to the script to run during the installation of the edge node. Changing this forces a new resource to be created.

            * `targetInstanceCount` (`pulumi.Input[float]`) - The number of instances which should be run for the Worker Nodes.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Edge Nodes. Changing this forces a new resource to be created.

          * `headNode` (`pulumi.Input[dict]`) - A `head_node` block as defined above.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Head Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Head Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Head Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Head Nodes. Changing this forces a new resource to be created.

          * `workerNode` (`pulumi.Input[dict]`) - A `worker_node` block as defined below.
            * `minInstanceCount` (`pulumi.Input[float]`) - The minimum number of instances which should be run for the Worker Nodes. Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Worker Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `targetInstanceCount` (`pulumi.Input[float]`) - The number of instances which should be run for the Worker Nodes.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Worker Nodes. Changing this forces a new resource to be created.

          * `zookeeperNode` (`pulumi.Input[dict]`) - A `zookeeper_node` block as defined below.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Changing this forces a new resource to be created.

        The **storage_account_gen2** object supports the following:

          * `filesystemId` (`pulumi.Input[str]`) - The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.
          * `isDefault` (`pulumi.Input[bool]`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
          * `managedIdentityResourceId` (`pulumi.Input[str]`) - The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.
          * `storageResourceId` (`pulumi.Input[str]`) - The ID of the Storage Account. Changing this forces a new resource to be created.

        The **storage_accounts** object supports the following:

          * `isDefault` (`pulumi.Input[bool]`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
          * `storage_account_key` (`pulumi.Input[str]`) - The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.
          * `storage_container_id` (`pulumi.Input[str]`) - The ID of the Storage Container. Changing this forces a new resource to be created.
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

            if cluster_version is None:
                raise TypeError("Missing required property 'cluster_version'")
            __props__['cluster_version'] = cluster_version
            if component_version is None:
                raise TypeError("Missing required property 'component_version'")
            __props__['component_version'] = component_version
            if gateway is None:
                raise TypeError("Missing required property 'gateway'")
            __props__['gateway'] = gateway
            __props__['location'] = location
            __props__['metastores'] = metastores
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if roles is None:
                raise TypeError("Missing required property 'roles'")
            __props__['roles'] = roles
            __props__['storage_account_gen2'] = storage_account_gen2
            __props__['storage_accounts'] = storage_accounts
            __props__['tags'] = tags
            if tier is None:
                raise TypeError("Missing required property 'tier'")
            __props__['tier'] = tier
            __props__['tls_min_version'] = tls_min_version
            __props__['https_endpoint'] = None
            __props__['ssh_endpoint'] = None
        super(HadoopCluster, __self__).__init__(
            'azure:hdinsight/hadoopCluster:HadoopCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, cluster_version=None, component_version=None, gateway=None, https_endpoint=None, location=None, metastores=None, name=None, resource_group_name=None, roles=None, ssh_endpoint=None, storage_account_gen2=None, storage_accounts=None, tags=None, tier=None, tls_min_version=None):
        """
        Get an existing HadoopCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_version: Specifies the Version of HDInsights which should be used for this Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] component_version: A `component_version` block as defined below.
        :param pulumi.Input[dict] gateway: A `gateway` block as defined below.
        :param pulumi.Input[str] https_endpoint: The HTTPS Connectivity Endpoint for this HDInsight Hadoop Cluster.
        :param pulumi.Input[str] location: Specifies the Azure Region which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] metastores: A `metastores` block as defined below.
        :param pulumi.Input[str] name: Specifies the name for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group in which this HDInsight Hadoop Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] roles: A `roles` block as defined below.
        :param pulumi.Input[str] ssh_endpoint: The SSH Connectivity Endpoint for this HDInsight Hadoop Cluster.
        :param pulumi.Input[dict] storage_account_gen2: A `storage_account_gen2` block as defined below.
        :param pulumi.Input[list] storage_accounts: One or more `storage_account` block as defined below.
        :param pulumi.Input[dict] tags: A map of Tags which should be assigned to this HDInsight Hadoop Cluster.
        :param pulumi.Input[str] tier: Specifies the Tier which should be used for this HDInsight Hadoop Cluster. Possible values are `Standard` or `Premium`. Changing this forces a new resource to be created.

        The **component_version** object supports the following:

          * `hadoop` (`pulumi.Input[str]`) - The version of Hadoop which should be used for this HDInsight Hadoop Cluster. Changing this forces a new resource to be created.

        The **gateway** object supports the following:

          * `enabled` (`pulumi.Input[bool]`) - Is the Ambari portal enabled? Changing this forces a new resource to be created.
          * `password` (`pulumi.Input[str]`) - The password used for the Ambari Portal. Changing this forces a new resource to be created.
          * `username` (`pulumi.Input[str]`) - The username used for the Ambari Portal. Changing this forces a new resource to be created.

        The **metastores** object supports the following:

          * `ambari` (`pulumi.Input[dict]`) - An `ambari` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Ambari metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Ambari metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Ambari metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

          * `hive` (`pulumi.Input[dict]`) - A `hive` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Hive metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Hive metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

          * `oozie` (`pulumi.Input[dict]`) - An `oozie` block as defined below.
            * `database_name` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL database.  Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
            * `server` (`pulumi.Input[str]`) - The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore.  Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The external Oozie metastore's existing SQL server admin username.  Changing this forces a new resource to be created.

        The **roles** object supports the following:

          * `edgeNode` (`pulumi.Input[dict]`) - A `edge_node` block as defined below.
            * `installScriptActions` (`pulumi.Input[list]`) - A `install_script_action` block as defined below.
              * `name` (`pulumi.Input[str]`) - The name of the install script action. Changing this forces a new resource to be created.
              * `uri` (`pulumi.Input[str]`) - The URI pointing to the script to run during the installation of the edge node. Changing this forces a new resource to be created.

            * `targetInstanceCount` (`pulumi.Input[float]`) - The number of instances which should be run for the Worker Nodes.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Edge Nodes. Changing this forces a new resource to be created.

          * `headNode` (`pulumi.Input[dict]`) - A `head_node` block as defined above.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Head Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Head Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Head Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Head Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Head Nodes. Changing this forces a new resource to be created.

          * `workerNode` (`pulumi.Input[dict]`) - A `worker_node` block as defined below.
            * `minInstanceCount` (`pulumi.Input[float]`) - The minimum number of instances which should be run for the Worker Nodes. Changing this forces a new resource to be created.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Worker Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `targetInstanceCount` (`pulumi.Input[float]`) - The number of instances which should be run for the Worker Nodes.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Worker Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Worker Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Worker Nodes. Changing this forces a new resource to be created.

          * `zookeeperNode` (`pulumi.Input[dict]`) - A `zookeeper_node` block as defined below.
            * `password` (`pulumi.Input[str]`) - The Password associated with the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `sshKeys` (`pulumi.Input[list]`) - A list of SSH Keys which should be used for the local administrator on the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `subnet_id` (`pulumi.Input[str]`) - The ID of the Subnet within the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `username` (`pulumi.Input[str]`) - The Username of the local administrator for the Zookeeper Nodes. Changing this forces a new resource to be created.
            * `virtual_network_id` (`pulumi.Input[str]`) - The ID of the Virtual Network where the Zookeeper Nodes should be provisioned within. Changing this forces a new resource to be created.
            * `vm_size` (`pulumi.Input[str]`) - The Size of the Virtual Machine which should be used as the Zookeeper Nodes. Changing this forces a new resource to be created.

        The **storage_account_gen2** object supports the following:

          * `filesystemId` (`pulumi.Input[str]`) - The ID of the Gen2 Filesystem. Changing this forces a new resource to be created.
          * `isDefault` (`pulumi.Input[bool]`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
          * `managedIdentityResourceId` (`pulumi.Input[str]`) - The ID of Managed Identity to use for accessing the Gen2 filesystem. Changing this forces a new resource to be created.
          * `storageResourceId` (`pulumi.Input[str]`) - The ID of the Storage Account. Changing this forces a new resource to be created.

        The **storage_accounts** object supports the following:

          * `isDefault` (`pulumi.Input[bool]`) - Is this the Default Storage Account for the HDInsight Hadoop Cluster? Changing this forces a new resource to be created.
          * `storage_account_key` (`pulumi.Input[str]`) - The Access Key which should be used to connect to the Storage Account. Changing this forces a new resource to be created.
          * `storage_container_id` (`pulumi.Input[str]`) - The ID of the Storage Container. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["cluster_version"] = cluster_version
        __props__["component_version"] = component_version
        __props__["gateway"] = gateway
        __props__["https_endpoint"] = https_endpoint
        __props__["location"] = location
        __props__["metastores"] = metastores
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["roles"] = roles
        __props__["ssh_endpoint"] = ssh_endpoint
        __props__["storage_account_gen2"] = storage_account_gen2
        __props__["storage_accounts"] = storage_accounts
        __props__["tags"] = tags
        __props__["tier"] = tier
        __props__["tls_min_version"] = tls_min_version
        return HadoopCluster(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
