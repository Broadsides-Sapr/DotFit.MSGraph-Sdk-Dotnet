using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TodoTask : Entity, IParsable {
        /// <summary>A collection of file attachments for the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttachmentBase>? Attachments {
            get { return BackingStore?.Get<List<AttachmentBase>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<AttachmentBase> Attachments {
            get { return BackingStore?.Get<List<AttachmentBase>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The attachmentSessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttachmentSession>? AttachmentSessions {
            get { return BackingStore?.Get<List<AttachmentSession>?>("attachmentSessions"); }
            set { BackingStore?.Set("attachmentSessions", value); }
        }
#nullable restore
#else
        public List<AttachmentSession> AttachmentSessions {
            get { return BackingStore?.Get<List<AttachmentSession>>("attachmentSessions"); }
            set { BackingStore?.Set("attachmentSessions", value); }
        }
#endif
        /// <summary>The task body that typically contains information about the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body {
            get { return BackingStore?.Get<ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>The date and time when the task body was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? BodyLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("bodyLastModifiedDateTime"); }
            set { BackingStore?.Set("bodyLastModifiedDateTime", value); }
        }
        /// <summary>The categories associated with the task. Each category corresponds to the displayName property of an outlookCategory that the user has defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>A collection of checklistItems linked to a task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChecklistItem>? ChecklistItems {
            get { return BackingStore?.Get<List<ChecklistItem>?>("checklistItems"); }
            set { BackingStore?.Set("checklistItems", value); }
        }
#nullable restore
#else
        public List<ChecklistItem> ChecklistItems {
            get { return BackingStore?.Get<List<ChecklistItem>>("checklistItems"); }
            set { BackingStore?.Set("checklistItems", value); }
        }
#endif
        /// <summary>The date and time in the specified time zone that the task was finished.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? CompletedDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone CompletedDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
#endif
        /// <summary>The date and time when the task was created. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time in the specified time zone that the task is to be finished.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? DueDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone DueDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the task. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>Indicates whether the task has attachments.</summary>
        public bool? HasAttachments {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The importance property</summary>
        public Microsoft.Graph.Models.Importance? Importance {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>Set to true if an alert is set to remind the user of the task.</summary>
        public bool? IsReminderOn {
            get { return BackingStore?.Get<bool?>("isReminderOn"); }
            set { BackingStore?.Set("isReminderOn", value); }
        }
        /// <summary>The date and time when the task was last modified. By default, it is in UTC. You can provide a custom time zone in the request header. The property value uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2020 would look like this: &apos;2020-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>A collection of resources linked to the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LinkedResource>? LinkedResources {
            get { return BackingStore?.Get<List<LinkedResource>?>("linkedResources"); }
            set { BackingStore?.Set("linkedResources", value); }
        }
#nullable restore
#else
        public List<LinkedResource> LinkedResources {
            get { return BackingStore?.Get<List<LinkedResource>>("linkedResources"); }
            set { BackingStore?.Set("linkedResources", value); }
        }
#endif
        /// <summary>The recurrence pattern for the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PatternedRecurrence? Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#nullable restore
#else
        public PatternedRecurrence Recurrence {
            get { return BackingStore?.Get<PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#endif
        /// <summary>The date and time in the specified time zone for a reminder alert of the task to occur.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? ReminderDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("reminderDateTime"); }
            set { BackingStore?.Set("reminderDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone ReminderDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("reminderDateTime"); }
            set { BackingStore?.Set("reminderDateTime", value); }
        }
#endif
        /// <summary>The date and time in the specified time zone at which the task is scheduled to start.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone StartDateTime {
            get { return BackingStore?.Get<DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>The status property</summary>
        public TaskStatus? Status {
            get { return BackingStore?.Get<TaskStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>A brief description of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TodoTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TodoTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<AttachmentBase>(AttachmentBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attachmentSessions", n => { AttachmentSessions = n.GetCollectionOfObjectValues<AttachmentSession>(AttachmentSession.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"bodyLastModifiedDateTime", n => { BodyLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"checklistItems", n => { ChecklistItems = n.GetCollectionOfObjectValues<ChecklistItem>(ChecklistItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"linkedResources", n => { LinkedResources = n.GetCollectionOfObjectValues<LinkedResource>(LinkedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"recurrence", n => { Recurrence = n.GetObjectValue<PatternedRecurrence>(PatternedRecurrence.CreateFromDiscriminatorValue); } },
                {"reminderDateTime", n => { ReminderDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<TaskStatus>(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttachmentBase>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<AttachmentSession>("attachmentSessions", AttachmentSessions);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("bodyLastModifiedDateTime", BodyLastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<ChecklistItem>("checklistItems", ChecklistItems);
            writer.WriteObjectValue<DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LinkedResource>("linkedResources", LinkedResources);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<DateTimeTimeZone>("reminderDateTime", ReminderDateTime);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<TaskStatus>("status", Status);
            writer.WriteStringValue("title", Title);
        }
    }
}
