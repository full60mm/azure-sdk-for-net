// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Simple policy schedule.
    /// </summary>
    public partial class SimpleSchedulePolicy : SchedulePolicy
    {
        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>
        public SimpleSchedulePolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>
        /// <param name="scheduleRunFrequency">Frequency of the schedule
        /// operation of this policy. Possible values include: 'Invalid',
        /// 'Daily', 'Weekly'</param>
        /// <param name="scheduleRunDays">List of days of week this schedule
        /// has to be run.</param>
        /// <param name="scheduleRunTimes">List of times of day this schedule
        /// has to be run.</param>
        /// <param name="scheduleWeeklyFrequency">At every number weeks this
        /// schedule has to be run.</param>
        public SimpleSchedulePolicy(string scheduleRunFrequency = default(string), IList<DayOfWeek?> scheduleRunDays = default(IList<DayOfWeek?>), IList<System.DateTime?> scheduleRunTimes = default(IList<System.DateTime?>), int? scheduleWeeklyFrequency = default(int?))
        {
            ScheduleRunFrequency = scheduleRunFrequency;
            ScheduleRunDays = scheduleRunDays;
            ScheduleRunTimes = scheduleRunTimes;
            ScheduleWeeklyFrequency = scheduleWeeklyFrequency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frequency of the schedule operation of this policy.
        /// Possible values include: 'Invalid', 'Daily', 'Weekly'
        /// </summary>
        [JsonProperty(PropertyName = "scheduleRunFrequency")]
        public string ScheduleRunFrequency { get; set; }

        /// <summary>
        /// Gets or sets list of days of week this schedule has to be run.
        /// </summary>
        [JsonProperty(PropertyName = "scheduleRunDays")]
        public IList<DayOfWeek?> ScheduleRunDays { get; set; }

        /// <summary>
        /// Gets or sets list of times of day this schedule has to be run.
        /// </summary>
        [JsonProperty(PropertyName = "scheduleRunTimes")]
        public IList<System.DateTime?> ScheduleRunTimes { get; set; }

        /// <summary>
        /// Gets or sets at every number weeks this schedule has to be run.
        /// </summary>
        [JsonProperty(PropertyName = "scheduleWeeklyFrequency")]
        public int? ScheduleWeeklyFrequency { get; set; }

    }
}