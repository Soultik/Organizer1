using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using OrganizerLibrary.Models;

namespace OrganizerLibrary.DataConnection
{
    public interface IDataConnection
    {
        #region Assignment
        AssignmentModel CreateAssignment(AssignmentModel model);
        BindingList<AssignmentModel> GetAssignment_All();
        void UpdateAssignment(AssignmentModel model);
        void DeleteAssignment(AssignmentModel model);
        #endregion
        #region EventType
        BindingList<EventTypeModel> GetEventType_All();
        void UpdateEventType(EventTypeModel model);
        EventTypeModel CreateEventType(EventTypeModel model);
        #endregion
        #region ActualEvents
        BindingList<EventModel> GetEventsOfDay_All(DateTime day);
        void UpdateEvent(EventModel model);
        EventModel CreateEvent(EventModel model);
        void DeleteEvent(EventModel model);
        #endregion
        #region TemplateDay

        BindingList<EventModel> GetTemplateEvents(string day);
        EventModel CreateTemplateEvent(EventModel model, int day);
        void UpdateTemplateEvent(EventModel model);
        void DeleteTemplateEvent(EventModel model);

        #endregion
        #region AddingSchedule

        void InitializeBasicSchedule(List<EventModel> models, DateTime startDate, DateTime endDate, string weekday);
        #endregion
    }
}
