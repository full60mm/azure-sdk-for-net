// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information for connecting to SQL database server
    /// </summary>
    public partial class SqlConnectionInfo : ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the SqlConnectionInfo class.
        /// </summary>
        public SqlConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlConnectionInfo class.
        /// </summary>
        /// <param name="dataSource">Data source in the format
        /// Protocol:MachineName\SQLServerInstanceName,PortNumber</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential.</param>
        /// <param name="authentication">Authentication type to use for
        /// connection. Possible values include: 'None',
        /// 'WindowsAuthentication', 'SqlAuthentication',
        /// 'ActiveDirectoryIntegrated', 'ActiveDirectoryPassword'</param>
        /// <param name="encryptConnection">Whether to encrypt the
        /// connection</param>
        /// <param name="additionalSettings">Additional connection
        /// settings</param>
        /// <param name="trustServerCertificate">Whether to trust the server
        /// certificate</param>
        public SqlConnectionInfo(string dataSource, string userName = default(string), string password = default(string), AuthenticationType? authentication = default(AuthenticationType?), bool? encryptConnection = default(bool?), string additionalSettings = default(string), bool? trustServerCertificate = default(bool?))
            : base(userName, password)
        {
            DataSource = dataSource;
            Authentication = authentication;
            EncryptConnection = encryptConnection;
            AdditionalSettings = additionalSettings;
            TrustServerCertificate = trustServerCertificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data source in the format
        /// Protocol:MachineName\SQLServerInstanceName,PortNumber
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or sets authentication type to use for connection. Possible
        /// values include: 'None', 'WindowsAuthentication',
        /// 'SqlAuthentication', 'ActiveDirectoryIntegrated',
        /// 'ActiveDirectoryPassword'
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public AuthenticationType? Authentication { get; set; }

        /// <summary>
        /// Gets or sets whether to encrypt the connection
        /// </summary>
        [JsonProperty(PropertyName = "encryptConnection")]
        public bool? EncryptConnection { get; set; }

        /// <summary>
        /// Gets or sets additional connection settings
        /// </summary>
        [JsonProperty(PropertyName = "additionalSettings")]
        public string AdditionalSettings { get; set; }

        /// <summary>
        /// Gets or sets whether to trust the server certificate
        /// </summary>
        [JsonProperty(PropertyName = "trustServerCertificate")]
        public bool? TrustServerCertificate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSource");
            }
        }
    }
}