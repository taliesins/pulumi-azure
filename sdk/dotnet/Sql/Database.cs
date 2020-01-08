// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Sql
{
    /// <summary>
    /// Allows you to manage an Azure SQL Database
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/sql_database.html.markdown.
    /// </summary>
    public partial class Database : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the collation. Applies only if `create_mode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("collation")]
        public Output<string> Collation { get; private set; } = null!;

        /// <summary>
        /// Specifies how to create the database. Valid values are: `Default`, `Copy`, `OnlineSecondary`, `NonReadableSecondary`,  `PointInTimeRestore`, `Recovery`, `Restore` or `RestoreLongTermRetentionBackup`. Must be `Default` to create a new database. Defaults to `Default`. Please see [Azure SQL Database REST API](https://docs.microsoft.com/en-us/rest/api/sql/databases/createorupdate#createmode)
        /// </summary>
        [Output("createMode")]
        public Output<string?> CreateMode { get; private set; } = null!;

        /// <summary>
        /// The creation date of the SQL Database.
        /// </summary>
        [Output("creationDate")]
        public Output<string> CreationDate { get; private set; } = null!;

        /// <summary>
        /// The default secondary location of the SQL Database.
        /// </summary>
        [Output("defaultSecondaryLocation")]
        public Output<string> DefaultSecondaryLocation { get; private set; } = null!;

        /// <summary>
        /// The edition of the database to be created. Applies only if `create_mode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Output("edition")]
        public Output<string> Edition { get; private set; } = null!;

        /// <summary>
        /// The name of the elastic database pool.
        /// </summary>
        [Output("elasticPoolName")]
        public Output<string> ElasticPoolName { get; private set; } = null!;

        [Output("encryption")]
        public Output<string> Encryption { get; private set; } = null!;

        /// <summary>
        /// A Database Import block as documented below. `create_mode` must be set to `Default`.
        /// </summary>
        [Output("import")]
        public Output<Outputs.DatabaseImport?> Import { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The maximum size that the database can grow to. Applies only if `create_mode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Output("maxSizeBytes")]
        public Output<string> MaxSizeBytes { get; private set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
        /// </summary>
        [Output("readScale")]
        public Output<bool?> ReadScale { get; private set; } = null!;

        /// <summary>
        /// Use `requested_service_objective_id` or `requested_service_objective_name` to set the performance level for the database.
        /// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Output("requestedServiceObjectiveId")]
        public Output<string> RequestedServiceObjectiveId { get; private set; } = null!;

        /// <summary>
        /// Use `requested_service_objective_name` or `requested_service_objective_id` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Output("requestedServiceObjectiveName")]
        public Output<string> RequestedServiceObjectiveName { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The point in time for the restore. Only applies if `create_mode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
        /// </summary>
        [Output("restorePointInTime")]
        public Output<string> RestorePointInTime { get; private set; } = null!;

        /// <summary>
        /// The name of the SQL Server on which to create the database.
        /// </summary>
        [Output("serverName")]
        public Output<string> ServerName { get; private set; } = null!;

        /// <summary>
        /// The deletion date time of the source database. Only applies to deleted databases where `create_mode` is `PointInTimeRestore`.
        /// </summary>
        [Output("sourceDatabaseDeletionDate")]
        public Output<string> SourceDatabaseDeletionDate { get; private set; } = null!;

        /// <summary>
        /// The URI of the source database if `create_mode` value is not `Default`.
        /// </summary>
        [Output("sourceDatabaseId")]
        public Output<string> SourceDatabaseId { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// Threat detection policy configuration. The `threat_detection_policy` block supports fields documented below.
        /// </summary>
        [Output("threatDetectionPolicy")]
        public Output<Outputs.DatabaseThreatDetectionPolicy> ThreatDetectionPolicy { get; private set; } = null!;


        /// <summary>
        /// Create a Database resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Database(string name, DatabaseArgs args, CustomResourceOptions? options = null)
            : base("azure:sql/database:Database", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Database(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
            : base("azure:sql/database:Database", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Database resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Database Get(string name, Input<string> id, DatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new Database(name, id, state, options);
        }
    }

    public sealed class DatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the collation. Applies only if `create_mode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("collation")]
        public Input<string>? Collation { get; set; }

        /// <summary>
        /// Specifies how to create the database. Valid values are: `Default`, `Copy`, `OnlineSecondary`, `NonReadableSecondary`,  `PointInTimeRestore`, `Recovery`, `Restore` or `RestoreLongTermRetentionBackup`. Must be `Default` to create a new database. Defaults to `Default`. Please see [Azure SQL Database REST API](https://docs.microsoft.com/en-us/rest/api/sql/databases/createorupdate#createmode)
        /// </summary>
        [Input("createMode")]
        public Input<string>? CreateMode { get; set; }

        /// <summary>
        /// The edition of the database to be created. Applies only if `create_mode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("edition")]
        public Input<string>? Edition { get; set; }

        /// <summary>
        /// The name of the elastic database pool.
        /// </summary>
        [Input("elasticPoolName")]
        public Input<string>? ElasticPoolName { get; set; }

        /// <summary>
        /// A Database Import block as documented below. `create_mode` must be set to `Default`.
        /// </summary>
        [Input("import")]
        public Input<Inputs.DatabaseImportArgs>? Import { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The maximum size that the database can grow to. Applies only if `create_mode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("maxSizeBytes")]
        public Input<string>? MaxSizeBytes { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
        /// </summary>
        [Input("readScale")]
        public Input<bool>? ReadScale { get; set; }

        /// <summary>
        /// Use `requested_service_objective_id` or `requested_service_objective_name` to set the performance level for the database.
        /// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("requestedServiceObjectiveId")]
        public Input<string>? RequestedServiceObjectiveId { get; set; }

        /// <summary>
        /// Use `requested_service_objective_name` or `requested_service_objective_id` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("requestedServiceObjectiveName")]
        public Input<string>? RequestedServiceObjectiveName { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The point in time for the restore. Only applies if `create_mode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
        /// </summary>
        [Input("restorePointInTime")]
        public Input<string>? RestorePointInTime { get; set; }

        /// <summary>
        /// The name of the SQL Server on which to create the database.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        /// <summary>
        /// The deletion date time of the source database. Only applies to deleted databases where `create_mode` is `PointInTimeRestore`.
        /// </summary>
        [Input("sourceDatabaseDeletionDate")]
        public Input<string>? SourceDatabaseDeletionDate { get; set; }

        /// <summary>
        /// The URI of the source database if `create_mode` value is not `Default`.
        /// </summary>
        [Input("sourceDatabaseId")]
        public Input<string>? SourceDatabaseId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Threat detection policy configuration. The `threat_detection_policy` block supports fields documented below.
        /// </summary>
        [Input("threatDetectionPolicy")]
        public Input<Inputs.DatabaseThreatDetectionPolicyArgs>? ThreatDetectionPolicy { get; set; }

        public DatabaseArgs()
        {
        }
    }

    public sealed class DatabaseState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the collation. Applies only if `create_mode` is `Default`.  Azure default is `SQL_LATIN1_GENERAL_CP1_CI_AS`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("collation")]
        public Input<string>? Collation { get; set; }

        /// <summary>
        /// Specifies how to create the database. Valid values are: `Default`, `Copy`, `OnlineSecondary`, `NonReadableSecondary`,  `PointInTimeRestore`, `Recovery`, `Restore` or `RestoreLongTermRetentionBackup`. Must be `Default` to create a new database. Defaults to `Default`. Please see [Azure SQL Database REST API](https://docs.microsoft.com/en-us/rest/api/sql/databases/createorupdate#createmode)
        /// </summary>
        [Input("createMode")]
        public Input<string>? CreateMode { get; set; }

        /// <summary>
        /// The creation date of the SQL Database.
        /// </summary>
        [Input("creationDate")]
        public Input<string>? CreationDate { get; set; }

        /// <summary>
        /// The default secondary location of the SQL Database.
        /// </summary>
        [Input("defaultSecondaryLocation")]
        public Input<string>? DefaultSecondaryLocation { get; set; }

        /// <summary>
        /// The edition of the database to be created. Applies only if `create_mode` is `Default`. Valid values are: `Basic`, `Standard`, `Premium`, `DataWarehouse`, `Business`, `BusinessCritical`, `Free`, `GeneralPurpose`, `Hyperscale`, `Premium`, `PremiumRS`, `Standard`, `Stretch`, `System`, `System2`, or `Web`. Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("edition")]
        public Input<string>? Edition { get; set; }

        /// <summary>
        /// The name of the elastic database pool.
        /// </summary>
        [Input("elasticPoolName")]
        public Input<string>? ElasticPoolName { get; set; }

        [Input("encryption")]
        public Input<string>? Encryption { get; set; }

        /// <summary>
        /// A Database Import block as documented below. `create_mode` must be set to `Default`.
        /// </summary>
        [Input("import")]
        public Input<Inputs.DatabaseImportGetArgs>? Import { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The maximum size that the database can grow to. Applies only if `create_mode` is `Default`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("maxSizeBytes")]
        public Input<string>? MaxSizeBytes { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Read-only connections will be redirected to a high-available replica. Please see [Use read-only replicas to load-balance read-only query workloads](https://docs.microsoft.com/en-us/azure/sql-database/sql-database-read-scale-out).
        /// </summary>
        [Input("readScale")]
        public Input<bool>? ReadScale { get; set; }

        /// <summary>
        /// Use `requested_service_objective_id` or `requested_service_objective_name` to set the performance level for the database.
        /// Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("requestedServiceObjectiveId")]
        public Input<string>? RequestedServiceObjectiveId { get; set; }

        /// <summary>
        /// Use `requested_service_objective_name` or `requested_service_objective_id` to set the performance level for the database. Valid values are: `S0`, `S1`, `S2`, `S3`, `P1`, `P2`, `P4`, `P6`, `P11` and `ElasticPool`.  Please see [Azure SQL Database Service Tiers](https://azure.microsoft.com/en-gb/documentation/articles/sql-database-service-tiers/).
        /// </summary>
        [Input("requestedServiceObjectiveName")]
        public Input<string>? RequestedServiceObjectiveName { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the database.  This must be the same as Database Server resource group currently.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The point in time for the restore. Only applies if `create_mode` is `PointInTimeRestore` e.g. 2013-11-08T22:00:40Z
        /// </summary>
        [Input("restorePointInTime")]
        public Input<string>? RestorePointInTime { get; set; }

        /// <summary>
        /// The name of the SQL Server on which to create the database.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// The deletion date time of the source database. Only applies to deleted databases where `create_mode` is `PointInTimeRestore`.
        /// </summary>
        [Input("sourceDatabaseDeletionDate")]
        public Input<string>? SourceDatabaseDeletionDate { get; set; }

        /// <summary>
        /// The URI of the source database if `create_mode` value is not `Default`.
        /// </summary>
        [Input("sourceDatabaseId")]
        public Input<string>? SourceDatabaseId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Threat detection policy configuration. The `threat_detection_policy` block supports fields documented below.
        /// </summary>
        [Input("threatDetectionPolicy")]
        public Input<Inputs.DatabaseThreatDetectionPolicyGetArgs>? ThreatDetectionPolicy { get; set; }

        public DatabaseState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DatabaseImportArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the SQL administrator.
        /// </summary>
        [Input("administratorLogin", required: true)]
        public Input<string> AdministratorLogin { get; set; } = null!;

        /// <summary>
        /// Specifies the password of the SQL administrator.
        /// </summary>
        [Input("administratorLoginPassword", required: true)]
        public Input<string> AdministratorLoginPassword { get; set; } = null!;

        /// <summary>
        /// Specifies the type of authentication used to access the server. Valid values are `SQL` or `ADPassword`.
        /// </summary>
        [Input("authenticationType", required: true)]
        public Input<string> AuthenticationType { get; set; } = null!;

        /// <summary>
        /// Specifies the type of import operation being performed. The only allowable value is `Import`.
        /// </summary>
        [Input("operationMode")]
        public Input<string>? OperationMode { get; set; }

        /// <summary>
        /// Specifies the access key for the storage account.
        /// </summary>
        [Input("storageKey", required: true)]
        public Input<string> StorageKey { get; set; } = null!;

        /// <summary>
        /// Specifies the type of access key for the storage account. Valid values are `StorageAccessKey` or `SharedAccessKey`.
        /// </summary>
        [Input("storageKeyType", required: true)]
        public Input<string> StorageKeyType { get; set; } = null!;

        /// <summary>
        /// Specifies the blob URI of the .bacpac file.
        /// </summary>
        [Input("storageUri", required: true)]
        public Input<string> StorageUri { get; set; } = null!;

        public DatabaseImportArgs()
        {
        }
    }

    public sealed class DatabaseImportGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the SQL administrator.
        /// </summary>
        [Input("administratorLogin", required: true)]
        public Input<string> AdministratorLogin { get; set; } = null!;

        /// <summary>
        /// Specifies the password of the SQL administrator.
        /// </summary>
        [Input("administratorLoginPassword", required: true)]
        public Input<string> AdministratorLoginPassword { get; set; } = null!;

        /// <summary>
        /// Specifies the type of authentication used to access the server. Valid values are `SQL` or `ADPassword`.
        /// </summary>
        [Input("authenticationType", required: true)]
        public Input<string> AuthenticationType { get; set; } = null!;

        /// <summary>
        /// Specifies the type of import operation being performed. The only allowable value is `Import`.
        /// </summary>
        [Input("operationMode")]
        public Input<string>? OperationMode { get; set; }

        /// <summary>
        /// Specifies the access key for the storage account.
        /// </summary>
        [Input("storageKey", required: true)]
        public Input<string> StorageKey { get; set; } = null!;

        /// <summary>
        /// Specifies the type of access key for the storage account. Valid values are `StorageAccessKey` or `SharedAccessKey`.
        /// </summary>
        [Input("storageKeyType", required: true)]
        public Input<string> StorageKeyType { get; set; } = null!;

        /// <summary>
        /// Specifies the blob URI of the .bacpac file.
        /// </summary>
        [Input("storageUri", required: true)]
        public Input<string> StorageUri { get; set; } = null!;

        public DatabaseImportGetArgs()
        {
        }
    }

    public sealed class DatabaseThreatDetectionPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("disabledAlerts")]
        private InputList<string>? _disabledAlerts;

        /// <summary>
        /// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
        /// </summary>
        public InputList<string> DisabledAlerts
        {
            get => _disabledAlerts ?? (_disabledAlerts = new InputList<string>());
            set => _disabledAlerts = value;
        }

        /// <summary>
        /// Should the account administrators be emailed when this alert is triggered?
        /// </summary>
        [Input("emailAccountAdmins")]
        public Input<string>? EmailAccountAdmins { get; set; }

        [Input("emailAddresses")]
        private InputList<string>? _emailAddresses;

        /// <summary>
        /// A list of email addresses which alerts should be sent to.
        /// </summary>
        public InputList<string> EmailAddresses
        {
            get => _emailAddresses ?? (_emailAddresses = new InputList<string>());
            set => _emailAddresses = value;
        }

        /// <summary>
        /// Specifies the number of days to keep in the Threat Detection audit logs.
        /// </summary>
        [Input("retentionDays")]
        public Input<int>? RetentionDays { get; set; }

        /// <summary>
        /// The State of the Policy. Possible values are `Enabled`, `Disabled` or `New`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Specifies the identifier key of the Threat Detection audit storage account. Required if `state` is `Enabled`.
        /// </summary>
        [Input("storageAccountAccessKey")]
        public Input<string>? StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if `state` is `Enabled`.
        /// </summary>
        [Input("storageEndpoint")]
        public Input<string>? StorageEndpoint { get; set; }

        /// <summary>
        /// Should the default server policy be used? Defaults to `Disabled`.
        /// </summary>
        [Input("useServerDefault")]
        public Input<string>? UseServerDefault { get; set; }

        public DatabaseThreatDetectionPolicyArgs()
        {
        }
    }

    public sealed class DatabaseThreatDetectionPolicyGetArgs : Pulumi.ResourceArgs
    {
        [Input("disabledAlerts")]
        private InputList<string>? _disabledAlerts;

        /// <summary>
        /// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
        /// </summary>
        public InputList<string> DisabledAlerts
        {
            get => _disabledAlerts ?? (_disabledAlerts = new InputList<string>());
            set => _disabledAlerts = value;
        }

        /// <summary>
        /// Should the account administrators be emailed when this alert is triggered?
        /// </summary>
        [Input("emailAccountAdmins")]
        public Input<string>? EmailAccountAdmins { get; set; }

        [Input("emailAddresses")]
        private InputList<string>? _emailAddresses;

        /// <summary>
        /// A list of email addresses which alerts should be sent to.
        /// </summary>
        public InputList<string> EmailAddresses
        {
            get => _emailAddresses ?? (_emailAddresses = new InputList<string>());
            set => _emailAddresses = value;
        }

        /// <summary>
        /// Specifies the number of days to keep in the Threat Detection audit logs.
        /// </summary>
        [Input("retentionDays")]
        public Input<int>? RetentionDays { get; set; }

        /// <summary>
        /// The State of the Policy. Possible values are `Enabled`, `Disabled` or `New`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// Specifies the identifier key of the Threat Detection audit storage account. Required if `state` is `Enabled`.
        /// </summary>
        [Input("storageAccountAccessKey")]
        public Input<string>? StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if `state` is `Enabled`.
        /// </summary>
        [Input("storageEndpoint")]
        public Input<string>? StorageEndpoint { get; set; }

        /// <summary>
        /// Should the default server policy be used? Defaults to `Disabled`.
        /// </summary>
        [Input("useServerDefault")]
        public Input<string>? UseServerDefault { get; set; }

        public DatabaseThreatDetectionPolicyGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DatabaseImport
    {
        /// <summary>
        /// Specifies the name of the SQL administrator.
        /// </summary>
        public readonly string AdministratorLogin;
        /// <summary>
        /// Specifies the password of the SQL administrator.
        /// </summary>
        public readonly string AdministratorLoginPassword;
        /// <summary>
        /// Specifies the type of authentication used to access the server. Valid values are `SQL` or `ADPassword`.
        /// </summary>
        public readonly string AuthenticationType;
        /// <summary>
        /// Specifies the type of import operation being performed. The only allowable value is `Import`.
        /// </summary>
        public readonly string? OperationMode;
        /// <summary>
        /// Specifies the access key for the storage account.
        /// </summary>
        public readonly string StorageKey;
        /// <summary>
        /// Specifies the type of access key for the storage account. Valid values are `StorageAccessKey` or `SharedAccessKey`.
        /// </summary>
        public readonly string StorageKeyType;
        /// <summary>
        /// Specifies the blob URI of the .bacpac file.
        /// </summary>
        public readonly string StorageUri;

        [OutputConstructor]
        private DatabaseImport(
            string administratorLogin,
            string administratorLoginPassword,
            string authenticationType,
            string? operationMode,
            string storageKey,
            string storageKeyType,
            string storageUri)
        {
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            OperationMode = operationMode;
            StorageKey = storageKey;
            StorageKeyType = storageKeyType;
            StorageUri = storageUri;
        }
    }

    [OutputType]
    public sealed class DatabaseThreatDetectionPolicy
    {
        /// <summary>
        /// Specifies a list of alerts which should be disabled. Possible values include `Access_Anomaly`, `Sql_Injection` and `Sql_Injection_Vulnerability`.
        /// </summary>
        public readonly ImmutableArray<string> DisabledAlerts;
        /// <summary>
        /// Should the account administrators be emailed when this alert is triggered?
        /// </summary>
        public readonly string? EmailAccountAdmins;
        /// <summary>
        /// A list of email addresses which alerts should be sent to.
        /// </summary>
        public readonly ImmutableArray<string> EmailAddresses;
        /// <summary>
        /// Specifies the number of days to keep in the Threat Detection audit logs.
        /// </summary>
        public readonly int? RetentionDays;
        /// <summary>
        /// The State of the Policy. Possible values are `Enabled`, `Disabled` or `New`.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// Specifies the identifier key of the Threat Detection audit storage account. Required if `state` is `Enabled`.
        /// </summary>
        public readonly string? StorageAccountAccessKey;
        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if `state` is `Enabled`.
        /// </summary>
        public readonly string? StorageEndpoint;
        /// <summary>
        /// Should the default server policy be used? Defaults to `Disabled`.
        /// </summary>
        public readonly string? UseServerDefault;

        [OutputConstructor]
        private DatabaseThreatDetectionPolicy(
            ImmutableArray<string> disabledAlerts,
            string? emailAccountAdmins,
            ImmutableArray<string> emailAddresses,
            int? retentionDays,
            string? state,
            string? storageAccountAccessKey,
            string? storageEndpoint,
            string? useServerDefault)
        {
            DisabledAlerts = disabledAlerts;
            EmailAccountAdmins = emailAccountAdmins;
            EmailAddresses = emailAddresses;
            RetentionDays = retentionDays;
            State = state;
            StorageAccountAccessKey = storageAccountAccessKey;
            StorageEndpoint = storageEndpoint;
            UseServerDefault = useServerDefault;
        }
    }
    }
}
