# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class DiagnosticSetting(pulumi.CustomResource):
    eventhub_authorization_rule_id: pulumi.Output[str]
    """
    Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data. Changing this forces a new resource to be created.
    """
    eventhub_name: pulumi.Output[str]
    """
    Specifies the name of the Event Hub where Diagnostics Data should be sent. Changing this forces a new resource to be created.
    """
    log_analytics_destination_type: pulumi.Output[str]
    """
    When set to 'Dedicated' logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.
    """
    log_analytics_workspace_id: pulumi.Output[str]
    """
    Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent. Changing this forces a new resource to be created.
    """
    logs: pulumi.Output[list]
    """
    One or more `log` blocks as defined below.

      * `category` (`str`) - The name of a Diagnostic Log Category for this Resource.
      * `enabled` (`bool`) - Is this Diagnostic Log enabled? Defaults to `true`.
      * `retention_policy` (`dict`) - A `retention_policy` block as defined below.
        * `days` (`float`) - The number of days for which this Retention Policy should apply.
        * `enabled` (`bool`) - Is this Retention Policy enabled?
    """
    metrics: pulumi.Output[list]
    """
    One or more `metric` blocks as defined below.

      * `category` (`str`) - The name of a Diagnostic Metric Category for this Resource.
      * `enabled` (`bool`) - Is this Diagnostic Metric enabled? Defaults to `true`.
      * `retention_policy` (`dict`) - A `retention_policy` block as defined below.
        * `days` (`float`) - The number of days for which this Retention Policy should apply.
        * `enabled` (`bool`) - Is this Retention Policy enabled?
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.
    """
    storage_account_id: pulumi.Output[str]
    """
    With this parameter you can specify a storage account which should be used to send the logs to. Parameter must be a valid Azure Resource ID. Changing this forces a new resource to be created.
    """
    target_resource_id: pulumi.Output[str]
    """
    The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, eventhub_authorization_rule_id=None, eventhub_name=None, log_analytics_destination_type=None, log_analytics_workspace_id=None, logs=None, metrics=None, name=None, storage_account_id=None, target_resource_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Diagnostic Setting for an existing Resource.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = example_resource_group.name.apply(lambda name: azure.storage.get_account(name="examplestoracc",
            resource_group_name=name))
        example_key_vault = example_resource_group.name.apply(lambda name: azure.keyvault.get_key_vault(name="example-vault",
            resource_group_name=name))
        example_diagnostic_setting = azure.monitoring.DiagnosticSetting("exampleDiagnosticSetting",
            target_resource_id=example_key_vault.id,
            storage_account_id=example_account.id,
            log=[{
                "category": "AuditEvent",
                "enabled": False,
                "retention_policy": {
                    "enabled": False,
                },
            }],
            metric=[{
                "category": "AllMetrics",
                "retention_policy": {
                    "enabled": False,
                },
            }])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] eventhub_authorization_rule_id: Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data. Changing this forces a new resource to be created.
        :param pulumi.Input[str] eventhub_name: Specifies the name of the Event Hub where Diagnostics Data should be sent. Changing this forces a new resource to be created.
        :param pulumi.Input[str] log_analytics_destination_type: When set to 'Dedicated' logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.
        :param pulumi.Input[str] log_analytics_workspace_id: Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent. Changing this forces a new resource to be created.
        :param pulumi.Input[list] logs: One or more `log` blocks as defined below.
        :param pulumi.Input[list] metrics: One or more `metric` blocks as defined below.
        :param pulumi.Input[str] name: Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.
        :param pulumi.Input[str] storage_account_id: With this parameter you can specify a storage account which should be used to send the logs to. Parameter must be a valid Azure Resource ID. Changing this forces a new resource to be created.
        :param pulumi.Input[str] target_resource_id: The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.

        The **logs** object supports the following:

          * `category` (`pulumi.Input[str]`) - The name of a Diagnostic Log Category for this Resource.
          * `enabled` (`pulumi.Input[bool]`) - Is this Diagnostic Log enabled? Defaults to `true`.
          * `retention_policy` (`pulumi.Input[dict]`) - A `retention_policy` block as defined below.
            * `days` (`pulumi.Input[float]`) - The number of days for which this Retention Policy should apply.
            * `enabled` (`pulumi.Input[bool]`) - Is this Retention Policy enabled?

        The **metrics** object supports the following:

          * `category` (`pulumi.Input[str]`) - The name of a Diagnostic Metric Category for this Resource.
          * `enabled` (`pulumi.Input[bool]`) - Is this Diagnostic Metric enabled? Defaults to `true`.
          * `retention_policy` (`pulumi.Input[dict]`) - A `retention_policy` block as defined below.
            * `days` (`pulumi.Input[float]`) - The number of days for which this Retention Policy should apply.
            * `enabled` (`pulumi.Input[bool]`) - Is this Retention Policy enabled?
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

            __props__['eventhub_authorization_rule_id'] = eventhub_authorization_rule_id
            __props__['eventhub_name'] = eventhub_name
            __props__['log_analytics_destination_type'] = log_analytics_destination_type
            __props__['log_analytics_workspace_id'] = log_analytics_workspace_id
            __props__['logs'] = logs
            __props__['metrics'] = metrics
            __props__['name'] = name
            __props__['storage_account_id'] = storage_account_id
            if target_resource_id is None:
                raise TypeError("Missing required property 'target_resource_id'")
            __props__['target_resource_id'] = target_resource_id
        super(DiagnosticSetting, __self__).__init__(
            'azure:monitoring/diagnosticSetting:DiagnosticSetting',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, eventhub_authorization_rule_id=None, eventhub_name=None, log_analytics_destination_type=None, log_analytics_workspace_id=None, logs=None, metrics=None, name=None, storage_account_id=None, target_resource_id=None):
        """
        Get an existing DiagnosticSetting resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] eventhub_authorization_rule_id: Specifies the ID of an Event Hub Namespace Authorization Rule used to send Diagnostics Data. Changing this forces a new resource to be created.
        :param pulumi.Input[str] eventhub_name: Specifies the name of the Event Hub where Diagnostics Data should be sent. Changing this forces a new resource to be created.
        :param pulumi.Input[str] log_analytics_destination_type: When set to 'Dedicated' logs sent to a Log Analytics workspace will go into resource specific tables, instead of the legacy AzureDiagnostics table.
        :param pulumi.Input[str] log_analytics_workspace_id: Specifies the ID of a Log Analytics Workspace where Diagnostics Data should be sent. Changing this forces a new resource to be created.
        :param pulumi.Input[list] logs: One or more `log` blocks as defined below.
        :param pulumi.Input[list] metrics: One or more `metric` blocks as defined below.
        :param pulumi.Input[str] name: Specifies the name of the Diagnostic Setting. Changing this forces a new resource to be created.
        :param pulumi.Input[str] storage_account_id: With this parameter you can specify a storage account which should be used to send the logs to. Parameter must be a valid Azure Resource ID. Changing this forces a new resource to be created.
        :param pulumi.Input[str] target_resource_id: The ID of an existing Resource on which to configure Diagnostic Settings. Changing this forces a new resource to be created.

        The **logs** object supports the following:

          * `category` (`pulumi.Input[str]`) - The name of a Diagnostic Log Category for this Resource.
          * `enabled` (`pulumi.Input[bool]`) - Is this Diagnostic Log enabled? Defaults to `true`.
          * `retention_policy` (`pulumi.Input[dict]`) - A `retention_policy` block as defined below.
            * `days` (`pulumi.Input[float]`) - The number of days for which this Retention Policy should apply.
            * `enabled` (`pulumi.Input[bool]`) - Is this Retention Policy enabled?

        The **metrics** object supports the following:

          * `category` (`pulumi.Input[str]`) - The name of a Diagnostic Metric Category for this Resource.
          * `enabled` (`pulumi.Input[bool]`) - Is this Diagnostic Metric enabled? Defaults to `true`.
          * `retention_policy` (`pulumi.Input[dict]`) - A `retention_policy` block as defined below.
            * `days` (`pulumi.Input[float]`) - The number of days for which this Retention Policy should apply.
            * `enabled` (`pulumi.Input[bool]`) - Is this Retention Policy enabled?
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["eventhub_authorization_rule_id"] = eventhub_authorization_rule_id
        __props__["eventhub_name"] = eventhub_name
        __props__["log_analytics_destination_type"] = log_analytics_destination_type
        __props__["log_analytics_workspace_id"] = log_analytics_workspace_id
        __props__["logs"] = logs
        __props__["metrics"] = metrics
        __props__["name"] = name
        __props__["storage_account_id"] = storage_account_id
        __props__["target_resource_id"] = target_resource_id
        return DiagnosticSetting(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
