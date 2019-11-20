// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    /// <summary>
    /// Manages an Azure Storage Account Management Policy.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_management_policy.html.markdown.
    /// </summary>
    public partial class ManagementPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// A `rule` block as documented below.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.ManagementPolicyRules>> Rules { get; private set; } = null!;

        /// <summary>
        /// Specifies the id of the storage account to apply the management policy to.
        /// </summary>
        [Output("storageAccountId")]
        public Output<string> StorageAccountId { get; private set; } = null!;


        /// <summary>
        /// Create a ManagementPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagementPolicy(string name, ManagementPolicyArgs args, CustomResourceOptions? options = null)
            : base("azure:storage/managementPolicy:ManagementPolicy", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ManagementPolicy(string name, Input<string> id, ManagementPolicyState? state = null, CustomResourceOptions? options = null)
            : base("azure:storage/managementPolicy:ManagementPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ManagementPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagementPolicy Get(string name, Input<string> id, ManagementPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagementPolicy(name, id, state, options);
        }
    }

    public sealed class ManagementPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("rules")]
        private InputList<Inputs.ManagementPolicyRulesArgs>? _rules;

        /// <summary>
        /// A `rule` block as documented below.
        /// </summary>
        public InputList<Inputs.ManagementPolicyRulesArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ManagementPolicyRulesArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Specifies the id of the storage account to apply the management policy to.
        /// </summary>
        [Input("storageAccountId", required: true)]
        public Input<string> StorageAccountId { get; set; } = null!;

        public ManagementPolicyArgs()
        {
        }
    }

    public sealed class ManagementPolicyState : Pulumi.ResourceArgs
    {
        [Input("rules")]
        private InputList<Inputs.ManagementPolicyRulesGetArgs>? _rules;

        /// <summary>
        /// A `rule` block as documented below.
        /// </summary>
        public InputList<Inputs.ManagementPolicyRulesGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.ManagementPolicyRulesGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Specifies the id of the storage account to apply the management policy to.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        public ManagementPolicyState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ManagementPolicyRulesActionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `base_blob` block as documented below.
        /// </summary>
        [Input("baseBlob")]
        public Input<ManagementPolicyRulesActionsBaseBlobArgs>? BaseBlob { get; set; }

        /// <summary>
        /// A `snapshot` block as documented below.
        /// </summary>
        [Input("snapshot")]
        public Input<ManagementPolicyRulesActionsSnapshotArgs>? Snapshot { get; set; }

        public ManagementPolicyRulesActionsArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesActionsBaseBlobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The age in days after last modification to delete the blob. Must be at least 0.
        /// </summary>
        [Input("deleteAfterDaysSinceModificationGreaterThan")]
        public Input<int>? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

        /// <summary>
        /// The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be at least 0.
        /// </summary>
        [Input("tierToArchiveAfterDaysSinceModificationGreaterThan")]
        public Input<int>? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

        /// <summary>
        /// The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be at least 0.
        /// </summary>
        [Input("tierToCoolAfterDaysSinceModificationGreaterThan")]
        public Input<int>? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }

        public ManagementPolicyRulesActionsBaseBlobArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesActionsBaseBlobGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The age in days after last modification to delete the blob. Must be at least 0.
        /// </summary>
        [Input("deleteAfterDaysSinceModificationGreaterThan")]
        public Input<int>? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

        /// <summary>
        /// The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be at least 0.
        /// </summary>
        [Input("tierToArchiveAfterDaysSinceModificationGreaterThan")]
        public Input<int>? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

        /// <summary>
        /// The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be at least 0.
        /// </summary>
        [Input("tierToCoolAfterDaysSinceModificationGreaterThan")]
        public Input<int>? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }

        public ManagementPolicyRulesActionsBaseBlobGetArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesActionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `base_blob` block as documented below.
        /// </summary>
        [Input("baseBlob")]
        public Input<ManagementPolicyRulesActionsBaseBlobGetArgs>? BaseBlob { get; set; }

        /// <summary>
        /// A `snapshot` block as documented below.
        /// </summary>
        [Input("snapshot")]
        public Input<ManagementPolicyRulesActionsSnapshotGetArgs>? Snapshot { get; set; }

        public ManagementPolicyRulesActionsGetArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesActionsSnapshotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The age in days after create to delete the snaphot. Must be at least 0.
        /// </summary>
        [Input("deleteAfterDaysSinceCreationGreaterThan")]
        public Input<int>? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

        public ManagementPolicyRulesActionsSnapshotArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesActionsSnapshotGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The age in days after create to delete the snaphot. Must be at least 0.
        /// </summary>
        [Input("deleteAfterDaysSinceCreationGreaterThan")]
        public Input<int>? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

        public ManagementPolicyRulesActionsSnapshotGetArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An `actions` block as documented below.
        /// </summary>
        [Input("actions", required: true)]
        public Input<ManagementPolicyRulesActionsArgs> Actions { get; set; } = null!;

        /// <summary>
        /// Boolean to specify whether the rule is enabled.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// A `filter` block as documented below.
        /// </summary>
        [Input("filters")]
        public Input<ManagementPolicyRulesFiltersArgs>? Filters { get; set; }

        /// <summary>
        /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ManagementPolicyRulesArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesFiltersArgs : Pulumi.ResourceArgs
    {
        [Input("blobTypes")]
        private InputList<string>? _blobTypes;

        /// <summary>
        /// An array of predefined values. Only `blockBlob` is supported.
        /// </summary>
        public InputList<string> BlobTypes
        {
            get => _blobTypes ?? (_blobTypes = new InputList<string>());
            set => _blobTypes = value;
        }

        [Input("prefixMatches")]
        private InputList<string>? _prefixMatches;

        /// <summary>
        /// An array of strings for prefixes to be matched.
        /// </summary>
        public InputList<string> PrefixMatches
        {
            get => _prefixMatches ?? (_prefixMatches = new InputList<string>());
            set => _prefixMatches = value;
        }

        public ManagementPolicyRulesFiltersArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesFiltersGetArgs : Pulumi.ResourceArgs
    {
        [Input("blobTypes")]
        private InputList<string>? _blobTypes;

        /// <summary>
        /// An array of predefined values. Only `blockBlob` is supported.
        /// </summary>
        public InputList<string> BlobTypes
        {
            get => _blobTypes ?? (_blobTypes = new InputList<string>());
            set => _blobTypes = value;
        }

        [Input("prefixMatches")]
        private InputList<string>? _prefixMatches;

        /// <summary>
        /// An array of strings for prefixes to be matched.
        /// </summary>
        public InputList<string> PrefixMatches
        {
            get => _prefixMatches ?? (_prefixMatches = new InputList<string>());
            set => _prefixMatches = value;
        }

        public ManagementPolicyRulesFiltersGetArgs()
        {
        }
    }

    public sealed class ManagementPolicyRulesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An `actions` block as documented below.
        /// </summary>
        [Input("actions", required: true)]
        public Input<ManagementPolicyRulesActionsGetArgs> Actions { get; set; } = null!;

        /// <summary>
        /// Boolean to specify whether the rule is enabled.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// A `filter` block as documented below.
        /// </summary>
        [Input("filters")]
        public Input<ManagementPolicyRulesFiltersGetArgs>? Filters { get; set; }

        /// <summary>
        /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ManagementPolicyRulesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ManagementPolicyRules
    {
        /// <summary>
        /// An `actions` block as documented below.
        /// </summary>
        public readonly ManagementPolicyRulesActions Actions;
        /// <summary>
        /// Boolean to specify whether the rule is enabled.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// A `filter` block as documented below.
        /// </summary>
        public readonly ManagementPolicyRulesFilters? Filters;
        /// <summary>
        /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ManagementPolicyRules(
            ManagementPolicyRulesActions actions,
            bool enabled,
            ManagementPolicyRulesFilters? filters,
            string name)
        {
            Actions = actions;
            Enabled = enabled;
            Filters = filters;
            Name = name;
        }
    }

    [OutputType]
    public sealed class ManagementPolicyRulesActions
    {
        /// <summary>
        /// A `base_blob` block as documented below.
        /// </summary>
        public readonly ManagementPolicyRulesActionsBaseBlob? BaseBlob;
        /// <summary>
        /// A `snapshot` block as documented below.
        /// </summary>
        public readonly ManagementPolicyRulesActionsSnapshot? Snapshot;

        [OutputConstructor]
        private ManagementPolicyRulesActions(
            ManagementPolicyRulesActionsBaseBlob? baseBlob,
            ManagementPolicyRulesActionsSnapshot? snapshot)
        {
            BaseBlob = baseBlob;
            Snapshot = snapshot;
        }
    }

    [OutputType]
    public sealed class ManagementPolicyRulesActionsBaseBlob
    {
        /// <summary>
        /// The age in days after last modification to delete the blob. Must be at least 0.
        /// </summary>
        public readonly int? DeleteAfterDaysSinceModificationGreaterThan;
        /// <summary>
        /// The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be at least 0.
        /// </summary>
        public readonly int? TierToArchiveAfterDaysSinceModificationGreaterThan;
        /// <summary>
        /// The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be at least 0.
        /// </summary>
        public readonly int? TierToCoolAfterDaysSinceModificationGreaterThan;

        [OutputConstructor]
        private ManagementPolicyRulesActionsBaseBlob(
            int? deleteAfterDaysSinceModificationGreaterThan,
            int? tierToArchiveAfterDaysSinceModificationGreaterThan,
            int? tierToCoolAfterDaysSinceModificationGreaterThan)
        {
            DeleteAfterDaysSinceModificationGreaterThan = deleteAfterDaysSinceModificationGreaterThan;
            TierToArchiveAfterDaysSinceModificationGreaterThan = tierToArchiveAfterDaysSinceModificationGreaterThan;
            TierToCoolAfterDaysSinceModificationGreaterThan = tierToCoolAfterDaysSinceModificationGreaterThan;
        }
    }

    [OutputType]
    public sealed class ManagementPolicyRulesActionsSnapshot
    {
        /// <summary>
        /// The age in days after create to delete the snaphot. Must be at least 0.
        /// </summary>
        public readonly int? DeleteAfterDaysSinceCreationGreaterThan;

        [OutputConstructor]
        private ManagementPolicyRulesActionsSnapshot(int? deleteAfterDaysSinceCreationGreaterThan)
        {
            DeleteAfterDaysSinceCreationGreaterThan = deleteAfterDaysSinceCreationGreaterThan;
        }
    }

    [OutputType]
    public sealed class ManagementPolicyRulesFilters
    {
        /// <summary>
        /// An array of predefined values. Only `blockBlob` is supported.
        /// </summary>
        public readonly ImmutableArray<string> BlobTypes;
        /// <summary>
        /// An array of strings for prefixes to be matched.
        /// </summary>
        public readonly ImmutableArray<string> PrefixMatches;

        [OutputConstructor]
        private ManagementPolicyRulesFilters(
            ImmutableArray<string> blobTypes,
            ImmutableArray<string> prefixMatches)
        {
            BlobTypes = blobTypes;
            PrefixMatches = prefixMatches;
        }
    }
    }
}
