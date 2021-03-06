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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DisableComputeNodeSchedulingOption.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisableComputeNodeSchedulingOption
    {
        /// <summary>
        /// Terminate running task processes and requeue the tasks. The tasks
        /// may run again on other compute nodes, or when task scheduling is
        /// re-enabled on this node. Enter offline state as soon as tasks have
        /// been terminated.
        /// </summary>
        [EnumMember(Value = "requeue")]
        Requeue,
        /// <summary>
        /// Terminate running tasks. The tasks will be completed with
        /// failureInfo indicating that they were terminated, and will not run
        /// again. Enter offline state as soon as tasks have been terminated.
        /// </summary>
        [EnumMember(Value = "terminate")]
        Terminate,
        /// <summary>
        /// Allow currently running tasks to complete. Schedule no new tasks
        /// while waiting. Enter offline state when all tasks have completed.
        /// </summary>
        [EnumMember(Value = "taskcompletion")]
        TaskCompletion
    }
    internal static class DisableComputeNodeSchedulingOptionEnumExtension
    {
        internal static string ToSerializedValue(this DisableComputeNodeSchedulingOption? value)
        {
            return value == null ? null : ((DisableComputeNodeSchedulingOption)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DisableComputeNodeSchedulingOption value)
        {
            switch( value )
            {
                case DisableComputeNodeSchedulingOption.Requeue:
                    return "requeue";
                case DisableComputeNodeSchedulingOption.Terminate:
                    return "terminate";
                case DisableComputeNodeSchedulingOption.TaskCompletion:
                    return "taskcompletion";
            }
            return null;
        }

        internal static DisableComputeNodeSchedulingOption? ParseDisableComputeNodeSchedulingOption(this string value)
        {
            switch( value )
            {
                case "requeue":
                    return DisableComputeNodeSchedulingOption.Requeue;
                case "terminate":
                    return DisableComputeNodeSchedulingOption.Terminate;
                case "taskcompletion":
                    return DisableComputeNodeSchedulingOption.TaskCompletion;
            }
            return null;
        }
    }
}
