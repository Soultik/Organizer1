using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizerLibrary.Models
{
    public class EventTypeModel
    {
        /// <summary>
        /// Unique Id identifying the event type in the database.
        /// </summary>
        public int EventTypeId { get; set; }
        /// <summary>
        /// The name of that event type.
        /// </summary>
        public string EventTypeName { get; set; }
    }
}
