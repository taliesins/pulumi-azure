// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DevTest
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Dev Test Lab.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/dev_test_lab.html.markdown.
        /// </summary>
        public static Task<GetLabResult> GetLab(GetLabArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLabResult>("azure:devtest/getLab:getLab", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetLabArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Dev Test Lab.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the Dev Test Lab exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetLabArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetLabResult
    {
        /// <summary>
        /// The ID of the Storage Account used for Artifact Storage.
        /// </summary>
        public readonly string ArtifactsStorageAccountId;
        /// <summary>
        /// The ID of the Default Premium Storage Account for this Dev Test Lab.
        /// </summary>
        public readonly string DefaultPremiumStorageAccountId;
        /// <summary>
        /// The ID of the Default Storage Account for this Dev Test Lab.
        /// </summary>
        public readonly string DefaultStorageAccountId;
        /// <summary>
        /// The ID of the Key used for this Dev Test Lab.
        /// </summary>
        public readonly string KeyVaultId;
        /// <summary>
        /// The Azure location where the Dev Test Lab exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        /// <summary>
        /// The ID of the Storage Account used for Storage of Premium Data Disk.
        /// </summary>
        public readonly string PremiumDataDiskStorageAccountId;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The type of storage used by the Dev Test Lab.
        /// </summary>
        public readonly string StorageType;
        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// The unique immutable identifier of the Dev Test Lab.
        /// </summary>
        public readonly string UniqueIdentifier;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetLabResult(
            string artifactsStorageAccountId,
            string defaultPremiumStorageAccountId,
            string defaultStorageAccountId,
            string keyVaultId,
            string location,
            string name,
            string premiumDataDiskStorageAccountId,
            string resourceGroupName,
            string storageType,
            ImmutableDictionary<string, string> tags,
            string uniqueIdentifier,
            string id)
        {
            ArtifactsStorageAccountId = artifactsStorageAccountId;
            DefaultPremiumStorageAccountId = defaultPremiumStorageAccountId;
            DefaultStorageAccountId = defaultStorageAccountId;
            KeyVaultId = keyVaultId;
            Location = location;
            Name = name;
            PremiumDataDiskStorageAccountId = premiumDataDiskStorageAccountId;
            ResourceGroupName = resourceGroupName;
            StorageType = storageType;
            Tags = tags;
            UniqueIdentifier = uniqueIdentifier;
            Id = id;
        }
    }
}
