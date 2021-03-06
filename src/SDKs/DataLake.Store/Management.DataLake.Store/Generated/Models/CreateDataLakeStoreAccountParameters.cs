// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class CreateDataLakeStoreAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataLakeStoreAccountParameters class.
        /// </summary>
        public CreateDataLakeStoreAccountParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataLakeStoreAccountParameters class.
        /// </summary>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="identity">The Key Vault encryption identity, if
        /// any.</param>
        /// <param name="defaultGroup">The default owner group for all new
        /// folders and files created in the Data Lake Store account.</param>
        /// <param name="encryptionConfig">The Key Vault encryption
        /// configuration.</param>
        /// <param name="encryptionState">The current state of encryption for
        /// this Data Lake Store account. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this Data Lake Store account.</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this Data Lake Store account. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="trustedIdProviders">The list of trusted identity
        /// providers associated with this Data Lake Store account.</param>
        /// <param name="trustedIdProviderState">The current state of the
        /// trusted identity provider feature for this Data Lake Store account.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="newTier">The commitment tier to use for next month.
        /// Possible values include: 'Consumption', 'Commitment_1TB',
        /// 'Commitment_10TB', 'Commitment_100TB', 'Commitment_500TB',
        /// 'Commitment_1PB', 'Commitment_5PB'</param>
        public CreateDataLakeStoreAccountParameters(string location, IDictionary<string, string> tags = default(IDictionary<string, string>), EncryptionIdentity identity = default(EncryptionIdentity), string defaultGroup = default(string), EncryptionConfig encryptionConfig = default(EncryptionConfig), EncryptionState? encryptionState = default(EncryptionState?), IList<CreateFirewallRuleWithAccountParameters> firewallRules = default(IList<CreateFirewallRuleWithAccountParameters>), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), IList<CreateTrustedIdProviderWithAccountParameters> trustedIdProviders = default(IList<CreateTrustedIdProviderWithAccountParameters>), TrustedIdProviderState? trustedIdProviderState = default(TrustedIdProviderState?), TierType? newTier = default(TierType?))
        {
            Location = location;
            Tags = tags;
            Identity = identity;
            DefaultGroup = defaultGroup;
            EncryptionConfig = encryptionConfig;
            EncryptionState = encryptionState;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            TrustedIdProviders = trustedIdProviders;
            TrustedIdProviderState = trustedIdProviderState;
            NewTier = newTier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the Key Vault encryption identity, if any.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public EncryptionIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the default owner group for all new folders and files
        /// created in the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultGroup")]
        public string DefaultGroup { get; set; }

        /// <summary>
        /// Gets or sets the Key Vault encryption configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionConfig")]
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Gets or sets the current state of encryption for this Data Lake
        /// Store account. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionState")]
        public EncryptionState? EncryptionState { get; set; }

        /// <summary>
        /// Gets or sets the list of firewall rules associated with this Data
        /// Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<CreateFirewallRuleWithAccountParameters> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets the current state of the IP address firewall for this
        /// Data Lake Store account. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; set; }

        /// <summary>
        /// Gets or sets the current state of allowing or disallowing IPs
        /// originating within Azure through the firewall. If the firewall is
        /// disabled, this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; set; }

        /// <summary>
        /// Gets or sets the list of trusted identity providers associated with
        /// this Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedIdProviders")]
        public IList<CreateTrustedIdProviderWithAccountParameters> TrustedIdProviders { get; set; }

        /// <summary>
        /// Gets or sets the current state of the trusted identity provider
        /// feature for this Data Lake Store account. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedIdProviderState")]
        public TrustedIdProviderState? TrustedIdProviderState { get; set; }

        /// <summary>
        /// Gets or sets the commitment tier to use for next month. Possible
        /// values include: 'Consumption', 'Commitment_1TB', 'Commitment_10TB',
        /// 'Commitment_100TB', 'Commitment_500TB', 'Commitment_1PB',
        /// 'Commitment_5PB'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (EncryptionConfig != null)
            {
                EncryptionConfig.Validate();
            }
            if (FirewallRules != null)
            {
                foreach (var element in FirewallRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (TrustedIdProviders != null)
            {
                foreach (var element1 in TrustedIdProviders)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
