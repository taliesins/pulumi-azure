# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

warnings.warn("azure.eventhub.EventSubscription has been deprecated in favor of azure.eventgrid.EventSubscription", DeprecationWarning)
class EventSubscription(pulumi.CustomResource):
    event_delivery_schema: pulumi.Output[str]
    """
    Specifies the event delivery schema for the event subscription. Possible values include: `EventGridSchema`, `CloudEventSchemaV1_0`, `CustomInputSchema`. Defaults to `EventGridSchema`. Changing this forces a new resource to be created.
    """
    eventhub_endpoint: pulumi.Output[dict]
    """
    A `eventhub_endpoint` block as defined below.

      * `eventhub_id` (`str`) - Specifies the id of the eventhub where the Event Subscription will receive events.
    """
    hybrid_connection_endpoint: pulumi.Output[dict]
    """
    A `hybrid_connection_endpoint` block as defined below.

      * `hybridConnectionId` (`str`) - Specifies the id of the hybrid connection where the Event Subscription will receive events.
    """
    included_event_types: pulumi.Output[list]
    """
    A list of applicable event types that need to be part of the event subscription.
    """
    labels: pulumi.Output[list]
    """
    A list of labels to assign to the event subscription.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.
    """
    retry_policy: pulumi.Output[dict]
    """
    A `retry_policy` block as defined below.

      * `eventTimeToLive` (`float`) - Specifies the time to live (in minutes) for events.
      * `maxDeliveryAttempts` (`float`) - Specifies the maximum number of delivery retry attempts for events.
    """
    scope: pulumi.Output[str]
    """
    Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.
    """
    storage_blob_dead_letter_destination: pulumi.Output[dict]
    """
    A `storage_blob_dead_letter_destination` block as defined below.

      * `storage_account_id` (`str`) - Specifies the id of the storage account id where the storage blob is located.
      * `storageBlobContainerName` (`str`) - Specifies the name of the Storage blob container that is the destination of the deadletter events
    """
    storage_queue_endpoint: pulumi.Output[dict]
    """
    A `storage_queue_endpoint` block as defined below.

      * `queue_name` (`str`) - Specifies the name of the storage queue where the Event Subscriptio will receive events.
      * `storage_account_id` (`str`) - Specifies the id of the storage account id where the storage queue is located.
    """
    subject_filter: pulumi.Output[dict]
    """
    A `subject_filter` block as defined below.

      * `caseSensitive` (`bool`) - Specifies if `subject_begins_with` and `subject_ends_with` case sensitive. This value defaults to `false`.
      * `subjectBeginsWith` (`str`) - A string to filter events for an event subscription based on a resource path prefix.
      * `subjectEndsWith` (`str`) - A string to filter events for an event subscription based on a resource path suffix.
    """
    topic_name: pulumi.Output[str]
    """
    (Optional) Specifies the name of the topic to associate with the event subscription.
    """
    webhook_endpoint: pulumi.Output[dict]
    """
    A `webhook_endpoint` block as defined below.

      * `url` (`str`) - Specifies the url of the webhook where the Event Subscription will receive events.
    """
    warnings.warn("azure.eventhub.EventSubscription has been deprecated in favor of azure.eventgrid.EventSubscription", DeprecationWarning)
    def __init__(__self__, resource_name, opts=None, event_delivery_schema=None, eventhub_endpoint=None, hybrid_connection_endpoint=None, included_event_types=None, labels=None, name=None, retry_policy=None, scope=None, storage_blob_dead_letter_destination=None, storage_queue_endpoint=None, subject_filter=None, topic_name=None, webhook_endpoint=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages an EventGrid Event Subscription

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        default_resource_group = azure.core.ResourceGroup("defaultResourceGroup", location="West US 2")
        default_account = azure.storage.Account("defaultAccount",
            resource_group_name=default_resource_group.name,
            location=default_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS",
            tags={
                "environment": "staging",
            })
        default_queue = azure.storage.Queue("defaultQueue",
            resource_group_name=default_resource_group.name,
            storage_account_name=default_account.name)
        default_event_subscription = azure.eventgrid.EventSubscription("defaultEventSubscription",
            scope=default_resource_group.id,
            storage_queue_endpoint={
                "storageAccountId": default_account.id,
                "queueName": default_queue.name,
            })
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] event_delivery_schema: Specifies the event delivery schema for the event subscription. Possible values include: `EventGridSchema`, `CloudEventSchemaV1_0`, `CustomInputSchema`. Defaults to `EventGridSchema`. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] eventhub_endpoint: A `eventhub_endpoint` block as defined below.
        :param pulumi.Input[dict] hybrid_connection_endpoint: A `hybrid_connection_endpoint` block as defined below.
        :param pulumi.Input[list] included_event_types: A list of applicable event types that need to be part of the event subscription.
        :param pulumi.Input[list] labels: A list of labels to assign to the event subscription.
        :param pulumi.Input[str] name: Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] retry_policy: A `retry_policy` block as defined below.
        :param pulumi.Input[str] scope: Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] storage_blob_dead_letter_destination: A `storage_blob_dead_letter_destination` block as defined below.
        :param pulumi.Input[dict] storage_queue_endpoint: A `storage_queue_endpoint` block as defined below.
        :param pulumi.Input[dict] subject_filter: A `subject_filter` block as defined below.
        :param pulumi.Input[str] topic_name: (Optional) Specifies the name of the topic to associate with the event subscription.
        :param pulumi.Input[dict] webhook_endpoint: A `webhook_endpoint` block as defined below.

        The **eventhub_endpoint** object supports the following:

          * `eventhub_id` (`pulumi.Input[str]`) - Specifies the id of the eventhub where the Event Subscription will receive events.

        The **hybrid_connection_endpoint** object supports the following:

          * `hybridConnectionId` (`pulumi.Input[str]`) - Specifies the id of the hybrid connection where the Event Subscription will receive events.

        The **retry_policy** object supports the following:

          * `eventTimeToLive` (`pulumi.Input[float]`) - Specifies the time to live (in minutes) for events.
          * `maxDeliveryAttempts` (`pulumi.Input[float]`) - Specifies the maximum number of delivery retry attempts for events.

        The **storage_blob_dead_letter_destination** object supports the following:

          * `storage_account_id` (`pulumi.Input[str]`) - Specifies the id of the storage account id where the storage blob is located.
          * `storageBlobContainerName` (`pulumi.Input[str]`) - Specifies the name of the Storage blob container that is the destination of the deadletter events

        The **storage_queue_endpoint** object supports the following:

          * `queue_name` (`pulumi.Input[str]`) - Specifies the name of the storage queue where the Event Subscriptio will receive events.
          * `storage_account_id` (`pulumi.Input[str]`) - Specifies the id of the storage account id where the storage queue is located.

        The **subject_filter** object supports the following:

          * `caseSensitive` (`pulumi.Input[bool]`) - Specifies if `subject_begins_with` and `subject_ends_with` case sensitive. This value defaults to `false`.
          * `subjectBeginsWith` (`pulumi.Input[str]`) - A string to filter events for an event subscription based on a resource path prefix.
          * `subjectEndsWith` (`pulumi.Input[str]`) - A string to filter events for an event subscription based on a resource path suffix.

        The **webhook_endpoint** object supports the following:

          * `url` (`pulumi.Input[str]`) - Specifies the url of the webhook where the Event Subscription will receive events.
        """
        pulumi.log.warn("EventSubscription is deprecated: azure.eventhub.EventSubscription has been deprecated in favor of azure.eventgrid.EventSubscription")
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

            __props__['event_delivery_schema'] = event_delivery_schema
            __props__['eventhub_endpoint'] = eventhub_endpoint
            __props__['hybrid_connection_endpoint'] = hybrid_connection_endpoint
            __props__['included_event_types'] = included_event_types
            __props__['labels'] = labels
            __props__['name'] = name
            __props__['retry_policy'] = retry_policy
            if scope is None:
                raise TypeError("Missing required property 'scope'")
            __props__['scope'] = scope
            __props__['storage_blob_dead_letter_destination'] = storage_blob_dead_letter_destination
            __props__['storage_queue_endpoint'] = storage_queue_endpoint
            __props__['subject_filter'] = subject_filter
            __props__['topic_name'] = topic_name
            __props__['webhook_endpoint'] = webhook_endpoint
        super(EventSubscription, __self__).__init__(
            'azure:eventhub/eventSubscription:EventSubscription',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, event_delivery_schema=None, eventhub_endpoint=None, hybrid_connection_endpoint=None, included_event_types=None, labels=None, name=None, retry_policy=None, scope=None, storage_blob_dead_letter_destination=None, storage_queue_endpoint=None, subject_filter=None, topic_name=None, webhook_endpoint=None):
        """
        Get an existing EventSubscription resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] event_delivery_schema: Specifies the event delivery schema for the event subscription. Possible values include: `EventGridSchema`, `CloudEventSchemaV1_0`, `CustomInputSchema`. Defaults to `EventGridSchema`. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] eventhub_endpoint: A `eventhub_endpoint` block as defined below.
        :param pulumi.Input[dict] hybrid_connection_endpoint: A `hybrid_connection_endpoint` block as defined below.
        :param pulumi.Input[list] included_event_types: A list of applicable event types that need to be part of the event subscription.
        :param pulumi.Input[list] labels: A list of labels to assign to the event subscription.
        :param pulumi.Input[str] name: Specifies the name of the EventGrid Event Subscription resource. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] retry_policy: A `retry_policy` block as defined below.
        :param pulumi.Input[str] scope: Specifies the scope at which the EventGrid Event Subscription should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] storage_blob_dead_letter_destination: A `storage_blob_dead_letter_destination` block as defined below.
        :param pulumi.Input[dict] storage_queue_endpoint: A `storage_queue_endpoint` block as defined below.
        :param pulumi.Input[dict] subject_filter: A `subject_filter` block as defined below.
        :param pulumi.Input[str] topic_name: (Optional) Specifies the name of the topic to associate with the event subscription.
        :param pulumi.Input[dict] webhook_endpoint: A `webhook_endpoint` block as defined below.

        The **eventhub_endpoint** object supports the following:

          * `eventhub_id` (`pulumi.Input[str]`) - Specifies the id of the eventhub where the Event Subscription will receive events.

        The **hybrid_connection_endpoint** object supports the following:

          * `hybridConnectionId` (`pulumi.Input[str]`) - Specifies the id of the hybrid connection where the Event Subscription will receive events.

        The **retry_policy** object supports the following:

          * `eventTimeToLive` (`pulumi.Input[float]`) - Specifies the time to live (in minutes) for events.
          * `maxDeliveryAttempts` (`pulumi.Input[float]`) - Specifies the maximum number of delivery retry attempts for events.

        The **storage_blob_dead_letter_destination** object supports the following:

          * `storage_account_id` (`pulumi.Input[str]`) - Specifies the id of the storage account id where the storage blob is located.
          * `storageBlobContainerName` (`pulumi.Input[str]`) - Specifies the name of the Storage blob container that is the destination of the deadletter events

        The **storage_queue_endpoint** object supports the following:

          * `queue_name` (`pulumi.Input[str]`) - Specifies the name of the storage queue where the Event Subscriptio will receive events.
          * `storage_account_id` (`pulumi.Input[str]`) - Specifies the id of the storage account id where the storage queue is located.

        The **subject_filter** object supports the following:

          * `caseSensitive` (`pulumi.Input[bool]`) - Specifies if `subject_begins_with` and `subject_ends_with` case sensitive. This value defaults to `false`.
          * `subjectBeginsWith` (`pulumi.Input[str]`) - A string to filter events for an event subscription based on a resource path prefix.
          * `subjectEndsWith` (`pulumi.Input[str]`) - A string to filter events for an event subscription based on a resource path suffix.

        The **webhook_endpoint** object supports the following:

          * `url` (`pulumi.Input[str]`) - Specifies the url of the webhook where the Event Subscription will receive events.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["event_delivery_schema"] = event_delivery_schema
        __props__["eventhub_endpoint"] = eventhub_endpoint
        __props__["hybrid_connection_endpoint"] = hybrid_connection_endpoint
        __props__["included_event_types"] = included_event_types
        __props__["labels"] = labels
        __props__["name"] = name
        __props__["retry_policy"] = retry_policy
        __props__["scope"] = scope
        __props__["storage_blob_dead_letter_destination"] = storage_blob_dead_letter_destination
        __props__["storage_queue_endpoint"] = storage_queue_endpoint
        __props__["subject_filter"] = subject_filter
        __props__["topic_name"] = topic_name
        __props__["webhook_endpoint"] = webhook_endpoint
        return EventSubscription(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

