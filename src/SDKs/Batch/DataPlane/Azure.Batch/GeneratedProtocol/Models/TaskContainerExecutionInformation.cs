// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the container which a task is executing.
    /// </summary>
    public partial class TaskContainerExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the TaskContainerExecutionInformation
        /// class.
        /// </summary>
        public TaskContainerExecutionInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskContainerExecutionInformation
        /// class.
        /// </summary>
        /// <param name="containerId">The ID of the container.</param>
        /// <param name="state">The state of the container.</param>
        /// <param name="error">Detailed error information about the
        /// container.</param>
        public TaskContainerExecutionInformation(string containerId = default(string), string state = default(string), string error = default(string))
        {
            ContainerId = containerId;
            State = state;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the container.
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets the state of the container.
        /// </summary>
        /// <remarks>
        /// This is the state of the container according to the Docker service.
        /// It is equivalent to the status field returned by "docker inspect".
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets detailed error information about the container.
        /// </summary>
        /// <remarks>
        /// This is the detailed error string from the Docker service, if
        /// available. It is equivalent to the error field returned by "docker
        /// inspect".
        /// </remarks>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

    }
}
