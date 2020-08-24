using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizerLibrary.Models
{
    public class EventModel : EventTypeModel
    {
        public int EventId { get; set; }
        /// <summary>
        /// Represent particulars of that event or things to remember.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// When the event starts.
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// When the event ends.
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
