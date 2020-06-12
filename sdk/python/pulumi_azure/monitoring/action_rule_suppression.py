# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class ActionRuleSuppression(pulumi.CustomResource):
    condition: pulumi.Output[dict]
    """
    A `condition` block as defined below.

      * `alertContext` (`dict`) - A `alert_context` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
        * `values` (`list`) - A list of values to match for a given condition.

      * `alertRuleId` (`dict`) - A `alert_rule_id` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
        * `values` (`list`) - A list of values to match for a given condition.

      * `description` (`dict`) - A `description` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
        * `values` (`list`) - A list of values to match for a given condition.

      * `monitor` (`dict`) - A `monitor` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
        * `values` (`list`) - A list of values to match for a given condition. Possible values are `Fired` and `Resolved`.

      * `monitorService` (`dict`) - A `monitor_service` as block defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
        * `values` (`list`) - A list of values to match for a given condition. Possible values are `ActivityLog Administrative`, `ActivityLog Autoscale`, `ActivityLog Policy`, `ActivityLog Recommendation`, `ActivityLog Security`, `Application Insights`, `Azure Backup`, `Data Box Edge`, `Data Box Gateway`, `Health Platform`, `Log Analytics`, `Platform`, and `Resource Health`.

      * `severity` (`dict`) - A `severity` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals`and `NotEquals`.
        * `values` (`list`) - A list of values to match for a given condition. Possible values are `Sev0`, `Sev1`, `Sev2`, `Sev3`, and `Sev4`.

      * `targetResourceType` (`dict`) - A `target_resource_type` block as defined below.
        * `operator` (`str`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
        * `values` (`list`) - A list of values to match for a given condition. The values should be valid resource types.
    """
    description: pulumi.Output[str]
    """
    Specifies a description for the Action Rule.
    """
    enabled: pulumi.Output[bool]
    """
    Is the Action Rule enabled? Defaults to `true`.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
    """
    scope: pulumi.Output[dict]
    """
    A `scope` block as defined below.

      * `resourceIds` (`list`) - A list of resource IDs of the given scope type which will be the target of action rule.
      * `type` (`str`) - Specifies the type of target scope. Possible values are `ResourceGroup` and `Resource`.
    """
    suppression: pulumi.Output[dict]
    """
    A `suppression` block as defined below.

      * `recurrence_type` (`str`) - Specifies the type of suppression. Possible values are `Always`, `Daily`, `Monthly`, `Once`, and `Weekly`.
      * `schedule` (`dict`) - A `schedule` block as defined below. Required if `recurrence_type` is `Daily`, `Monthly`, `Once` or `Weekly`.
        * `endDateUtc` (`str`) - specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').
        * `recurrenceMonthlies` (`list`) - specifies the list of dayOfMonth to recurrence. Possible values are between `1` - `31`. Required if `recurrence_type` is `Monthly`.
        * `recurrenceWeeklies` (`list`) - specifies the list of dayOfWeek to recurrence. Possible values are `Sunday`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday` and  `Saturday`.
        * `startDateUtc` (`str`) - specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, condition=None, description=None, enabled=None, name=None, resource_group_name=None, scope=None, suppression=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages an Monitor Action Rule which type is suppression.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_action_rule_suppression = azure.monitoring.ActionRuleSuppression("exampleActionRuleSuppression",
            resource_group_name=example_resource_group.name,
            scope={
                "type": "ResourceGroup",
                "resourceIds": [example_resource_group.id],
            },
            suppression={
                "recurrence_type": "Weekly",
                "schedule": {
                    "startDateUtc": "2019-01-01T01:02:03Z",
                    "endDateUtc": "2019-01-03T15:02:07Z",
                    "recurrenceWeeklies": [
                        "Sunday",
                        "Monday",
                        "Friday",
                        "Saturday",
                    ],
                },
            },
            tags={
                "foo": "bar",
            })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] condition: A `condition` block as defined below.
        :param pulumi.Input[str] description: Specifies a description for the Action Rule.
        :param pulumi.Input[bool] enabled: Is the Action Rule enabled? Defaults to `true`.
        :param pulumi.Input[str] name: Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] scope: A `scope` block as defined below.
        :param pulumi.Input[dict] suppression: A `suppression` block as defined below.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        The **condition** object supports the following:

          * `alertContext` (`pulumi.Input[dict]`) - A `alert_context` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `alertRuleId` (`pulumi.Input[dict]`) - A `alert_rule_id` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `description` (`pulumi.Input[dict]`) - A `description` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `monitor` (`pulumi.Input[dict]`) - A `monitor` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `Fired` and `Resolved`.

          * `monitorService` (`pulumi.Input[dict]`) - A `monitor_service` as block defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `ActivityLog Administrative`, `ActivityLog Autoscale`, `ActivityLog Policy`, `ActivityLog Recommendation`, `ActivityLog Security`, `Application Insights`, `Azure Backup`, `Data Box Edge`, `Data Box Gateway`, `Health Platform`, `Log Analytics`, `Platform`, and `Resource Health`.

          * `severity` (`pulumi.Input[dict]`) - A `severity` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `Sev0`, `Sev1`, `Sev2`, `Sev3`, and `Sev4`.

          * `targetResourceType` (`pulumi.Input[dict]`) - A `target_resource_type` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. The values should be valid resource types.

        The **scope** object supports the following:

          * `resourceIds` (`pulumi.Input[list]`) - A list of resource IDs of the given scope type which will be the target of action rule.
          * `type` (`pulumi.Input[str]`) - Specifies the type of target scope. Possible values are `ResourceGroup` and `Resource`.

        The **suppression** object supports the following:

          * `recurrence_type` (`pulumi.Input[str]`) - Specifies the type of suppression. Possible values are `Always`, `Daily`, `Monthly`, `Once`, and `Weekly`.
          * `schedule` (`pulumi.Input[dict]`) - A `schedule` block as defined below. Required if `recurrence_type` is `Daily`, `Monthly`, `Once` or `Weekly`.
            * `endDateUtc` (`pulumi.Input[str]`) - specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').
            * `recurrenceMonthlies` (`pulumi.Input[list]`) - specifies the list of dayOfMonth to recurrence. Possible values are between `1` - `31`. Required if `recurrence_type` is `Monthly`.
            * `recurrenceWeeklies` (`pulumi.Input[list]`) - specifies the list of dayOfWeek to recurrence. Possible values are `Sunday`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday` and  `Saturday`.
            * `startDateUtc` (`pulumi.Input[str]`) - specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').
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

            __props__['condition'] = condition
            __props__['description'] = description
            __props__['enabled'] = enabled
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['scope'] = scope
            if suppression is None:
                raise TypeError("Missing required property 'suppression'")
            __props__['suppression'] = suppression
            __props__['tags'] = tags
        super(ActionRuleSuppression, __self__).__init__(
            'azure:monitoring/actionRuleSuppression:ActionRuleSuppression',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, condition=None, description=None, enabled=None, name=None, resource_group_name=None, scope=None, suppression=None, tags=None):
        """
        Get an existing ActionRuleSuppression resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] condition: A `condition` block as defined below.
        :param pulumi.Input[str] description: Specifies a description for the Action Rule.
        :param pulumi.Input[bool] enabled: Is the Action Rule enabled? Defaults to `true`.
        :param pulumi.Input[str] name: Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] scope: A `scope` block as defined below.
        :param pulumi.Input[dict] suppression: A `suppression` block as defined below.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        The **condition** object supports the following:

          * `alertContext` (`pulumi.Input[dict]`) - A `alert_context` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `alertRuleId` (`pulumi.Input[dict]`) - A `alert_rule_id` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `description` (`pulumi.Input[dict]`) - A `description` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`, `NotEquals`, `Contains`, and `DoesNotContain`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition.

          * `monitor` (`pulumi.Input[dict]`) - A `monitor` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `Fired` and `Resolved`.

          * `monitorService` (`pulumi.Input[dict]`) - A `monitor_service` as block defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `ActivityLog Administrative`, `ActivityLog Autoscale`, `ActivityLog Policy`, `ActivityLog Recommendation`, `ActivityLog Security`, `Application Insights`, `Azure Backup`, `Data Box Edge`, `Data Box Gateway`, `Health Platform`, `Log Analytics`, `Platform`, and `Resource Health`.

          * `severity` (`pulumi.Input[dict]`) - A `severity` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals`and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. Possible values are `Sev0`, `Sev1`, `Sev2`, `Sev3`, and `Sev4`.

          * `targetResourceType` (`pulumi.Input[dict]`) - A `target_resource_type` block as defined below.
            * `operator` (`pulumi.Input[str]`) - The operator for a given condition. Possible values are `Equals` and `NotEquals`.
            * `values` (`pulumi.Input[list]`) - A list of values to match for a given condition. The values should be valid resource types.

        The **scope** object supports the following:

          * `resourceIds` (`pulumi.Input[list]`) - A list of resource IDs of the given scope type which will be the target of action rule.
          * `type` (`pulumi.Input[str]`) - Specifies the type of target scope. Possible values are `ResourceGroup` and `Resource`.

        The **suppression** object supports the following:

          * `recurrence_type` (`pulumi.Input[str]`) - Specifies the type of suppression. Possible values are `Always`, `Daily`, `Monthly`, `Once`, and `Weekly`.
          * `schedule` (`pulumi.Input[dict]`) - A `schedule` block as defined below. Required if `recurrence_type` is `Daily`, `Monthly`, `Once` or `Weekly`.
            * `endDateUtc` (`pulumi.Input[str]`) - specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').
            * `recurrenceMonthlies` (`pulumi.Input[list]`) - specifies the list of dayOfMonth to recurrence. Possible values are between `1` - `31`. Required if `recurrence_type` is `Monthly`.
            * `recurrenceWeeklies` (`pulumi.Input[list]`) - specifies the list of dayOfWeek to recurrence. Possible values are `Sunday`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday` and  `Saturday`.
            * `startDateUtc` (`pulumi.Input[str]`) - specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["condition"] = condition
        __props__["description"] = description
        __props__["enabled"] = enabled
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["scope"] = scope
        __props__["suppression"] = suppression
        __props__["tags"] = tags
        return ActionRuleSuppression(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
