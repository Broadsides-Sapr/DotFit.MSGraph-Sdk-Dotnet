// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Calendar.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Calendar : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// The calendar name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets color.
        /// Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: LightBlue=0, LightGreen=1, LightOrange=2, LightGray=3, LightYellow=4, LightTeal=5, LightPink=6, LightBrown=7, LightRed=8, MaxColor=9, Auto=-1
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "color", Required = Newtonsoft.Json.Required.Default)]
        public CalendarColor? Color { get; set; }
    
        /// <summary>
        /// Gets or sets change key.
        /// Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeKey", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets can share.
        /// True if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canShare", Required = Newtonsoft.Json.Required.Default)]
        public bool? CanShare { get; set; }
    
        /// <summary>
        /// Gets or sets can view private items.
        /// True if the user can read calendar items that have been marked private, false otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canViewPrivateItems", Required = Newtonsoft.Json.Required.Default)]
        public bool? CanViewPrivateItems { get; set; }
    
        /// <summary>
        /// Gets or sets can edit.
        /// True if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canEdit", Required = Newtonsoft.Json.Required.Default)]
        public bool? CanEdit { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public EmailAddress Owner { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "events", Required = Newtonsoft.Json.Required.Default)]
        public ICalendarEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarView", Required = Newtonsoft.Json.Required.Default)]
        public ICalendarCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public ICalendarSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public ICalendarMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
    }
}

