// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The local user associated with the storage accounts.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LocalUser : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LocalUser class.
        /// </summary>
        public LocalUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalUser class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="permissionScopes">The permission scopes of the local
        /// user.</param>
        /// <param name="homeDirectory">Optional, local user home
        /// directory.</param>
        /// <param name="sid">A unique Security Identifier that is generated by
        /// the server.</param>
        /// <param name="hasSharedKey">Indicates whether shared key exists. Set
        /// it to false to remove existing shared key.</param>
        /// <param name="hasSshKey">Indicates whether ssh key exists. Set it to
        /// false to remove existing SSH key.</param>
        /// <param name="hasSshPassword">Indicates whether ssh password exists.
        /// Set it to false to remove existing SSH password.</param>
        public LocalUser(string id = default(string), string name = default(string), string type = default(string), IList<PermissionScope> permissionScopes = default(IList<PermissionScope>), string homeDirectory = default(string), IList<SshPublicKey> sshAuthorizedKeys = default(IList<SshPublicKey>), string sid = default(string), bool? hasSharedKey = default(bool?), bool? hasSshKey = default(bool?), bool? hasSshPassword = default(bool?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            PermissionScopes = permissionScopes;
            HomeDirectory = homeDirectory;
            SshAuthorizedKeys = sshAuthorizedKeys;
            Sid = sid;
            HasSharedKey = hasSharedKey;
            HasSshKey = hasSshKey;
            HasSshPassword = hasSshPassword;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the permission scopes of the local user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.permissionScopes")]
        public IList<PermissionScope> PermissionScopes { get; set; }

        /// <summary>
        /// Gets or sets optional, local user home directory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.homeDirectory")]
        public string HomeDirectory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.sshAuthorizedKeys")]
        public IList<SshPublicKey> SshAuthorizedKeys { get; set; }

        /// <summary>
        /// Gets a unique Security Identifier that is generated by the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sid")]
        public string Sid { get; private set; }

        /// <summary>
        /// Gets or sets indicates whether shared key exists. Set it to false
        /// to remove existing shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasSharedKey")]
        public bool? HasSharedKey { get; set; }

        /// <summary>
        /// Gets or sets indicates whether ssh key exists. Set it to false to
        /// remove existing SSH key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasSshKey")]
        public bool? HasSshKey { get; set; }

        /// <summary>
        /// Gets or sets indicates whether ssh password exists. Set it to false
        /// to remove existing SSH password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasSshPassword")]
        public bool? HasSshPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}