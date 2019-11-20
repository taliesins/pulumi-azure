// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    public partial class ZipBlob : Pulumi.CustomResource
    {
        [Output("accessTier")]
        public Output<string> AccessTier { get; private set; } = null!;

        [Output("attempts")]
        public Output<int?> Attempts { get; private set; } = null!;

        [Output("contentType")]
        public Output<string?> ContentType { get; private set; } = null!;

        [Output("metadata")]
        public Output<ImmutableDictionary<string, object>> Metadata { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("parallelism")]
        public Output<int?> Parallelism { get; private set; } = null!;

        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        [Output("size")]
        public Output<int?> Size { get; private set; } = null!;

        [Output("content")]
        public Output<Archive?> Content { get; private set; } = null!;

        [Output("sourceContent")]
        public Output<string?> SourceContent { get; private set; } = null!;

        [Output("sourceUri")]
        public Output<string?> SourceUri { get; private set; } = null!;

        [Output("storageAccountName")]
        public Output<string> StorageAccountName { get; private set; } = null!;

        [Output("storageContainerName")]
        public Output<string> StorageContainerName { get; private set; } = null!;

        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a ZipBlob resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ZipBlob(string name, ZipBlobArgs args, CustomResourceOptions? options = null)
            : base("azure:storage/zipBlob:ZipBlob", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ZipBlob(string name, Input<string> id, ZipBlobState? state = null, CustomResourceOptions? options = null)
            : base("azure:storage/zipBlob:ZipBlob", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ZipBlob resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ZipBlob Get(string name, Input<string> id, ZipBlobState? state = null, CustomResourceOptions? options = null)
        {
            return new ZipBlob(name, id, state, options);
        }
    }

    public sealed class ZipBlobArgs : Pulumi.ResourceArgs
    {
        [Input("accessTier")]
        public Input<string>? AccessTier { get; set; }

        [Input("attempts")]
        public Input<int>? Attempts { get; set; }

        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        [Input("metadata")]
        private InputMap<object>? _metadata;
        public InputMap<object> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<object>());
            set => _metadata = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parallelism")]
        public Input<int>? Parallelism { get; set; }

        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("size")]
        public Input<int>? Size { get; set; }

        [Input("content")]
        public Input<Archive>? Content { get; set; }

        [Input("sourceContent")]
        public Input<string>? SourceContent { get; set; }

        [Input("sourceUri")]
        public Input<string>? SourceUri { get; set; }

        [Input("storageAccountName", required: true)]
        public Input<string> StorageAccountName { get; set; } = null!;

        [Input("storageContainerName", required: true)]
        public Input<string> StorageContainerName { get; set; } = null!;

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ZipBlobArgs()
        {
        }
    }

    public sealed class ZipBlobState : Pulumi.ResourceArgs
    {
        [Input("accessTier")]
        public Input<string>? AccessTier { get; set; }

        [Input("attempts")]
        public Input<int>? Attempts { get; set; }

        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        [Input("metadata")]
        private InputMap<object>? _metadata;
        public InputMap<object> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<object>());
            set => _metadata = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parallelism")]
        public Input<int>? Parallelism { get; set; }

        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("size")]
        public Input<int>? Size { get; set; }

        [Input("content")]
        public Input<Archive>? Content { get; set; }

        [Input("sourceContent")]
        public Input<string>? SourceContent { get; set; }

        [Input("sourceUri")]
        public Input<string>? SourceUri { get; set; }

        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        [Input("storageContainerName")]
        public Input<string>? StorageContainerName { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public ZipBlobState()
        {
        }
    }
}
