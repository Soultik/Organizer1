using OrganizerLibrary.DataConnection;
using OrganizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizerUI
{
    public partial class ScheduleForm : Form
    {
        #region BasicFormData
        // list used for storing and displaying events for the current (chosen) day
        BindingList<EventModel> DisplayData = new BindingList<EventModel>();
        // variable for the row currently chosen in the table
        private int activeRow;
        // list used for storing and displaying event types in eventbox control
        BindingList<EventTypeModel> EventDisplayData =
            OrganizerLibrary.GlobalConfig.Connections[0].GetEventType_All();
        // constructor
        public ScheduleForm()
        {
            InitializeComponent();
        }
        // loader
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            DisplayData = OrganizerLibrary.GlobalConfig.Connections[0].GetEventsOfDay_All(DateTime.Now);
            DisplayData.Add(new EventModel());
            ScheduleView.DataSource = DisplayData;
            EventBox.DataSource = EventDisplayData;
            EventBox.DisplayMember = "EventTypeName";
            EventBox.SelectedIndex = EventBox.FindStringExact(DisplayData[0].EventTypeName);
        }
        // changing day
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            DisplayData = OrganizerLibrary.GlobalConfig.Connections[0].GetEventsOfDay_All(datePicker.Value);
            DisplayData.Add(new EventModel());
            ScheduleView.DataSource = DisplayData;
        }
        // changing active row in the table
        private void ScheduleView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // choose the row index of the selected row
            int rowIndex = e.RowIndex;
            // set active row variable to current row
            activeRow = rowIndex;
            // initialize form controls with data from the selected row
            // so it can be changed 
            CommentaryBox.Text = DisplayData[rowIndex].Comment;

            if (DisplayData[rowIndex].StartTime.Date > DateTime.MinValue)
            {
                StartTimePicker.Value = DisplayData[rowIndex].StartTime;
            }
            else
            {
                StartTimePicker.Value = DateTime.Now - DateTime.Now.TimeOfDay;
            }

            if (DisplayData[rowIndex].EndTime.Date > DateTime.MinValue)
            {
                EndTimePicker.Value = DisplayData[rowIndex].EndTime;
            }
            else
            {
                EndTimePicker.Value = DateTime.Now - DateTime.Now.TimeOfDay;
            }

            EventBox.SelectedIndex = EventBox.FindStringExact(DisplayData[rowIndex].EventTypeName);
        }
        #endregion

        #region ButtonClicks
        // editing current row
        private void EditEventButton_Click(object sender, EventArgs e)
        {
            // editing the chosen event with new data taken from form controls

            // commentary
            DisplayData[activeRow].Comment = CommentaryBox.Text;

            // start time
            DisplayData[activeRow].StartTime = new DateTime(
                datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day,
                StartTimePicker.Value.Hour,
                StartTimePicker.Value.Minute,
                StartTimePicker.Value.Second);
            // end time
            DisplayData[activeRow].EndTime = new DateTime(
                datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day,
                EndTimePicker.Value.Hour,
                EndTimePicker.Value.Minute,
                EndTimePicker.Value.Second);
            // event type name
            DisplayData[activeRow].EventTypeName = EventBox.Text;
            // event type id
            DisplayData[activeRow].EventTypeId = EventDisplayData[EventBox.SelectedIndex].EventTypeId;
            // update event in the database
            OrganizerLibrary.GlobalConfig.Connections[0].UpdateEvent(DisplayData[activeRow]);

            ScheduleView.Refresh();
            // TODO - add sorting by time, so that the edited event takes its place in the table according to the start time in case starting time was changed

            // TODO - add error handling for when a user tries to edit the empty row

            // TODO - add error handling for when a user tries to set end time before start time
        }
        // adding new event
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            // initializng var
            var NewEvent = new EventModel();
            // editing the new event with new data taken from form controls

            // commentary
            NewEvent.Comment = CommentaryBox.Text;

            // start time
            NewEvent.StartTime = new DateTime(
                datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day,
                StartTimePicker.Value.Hour,
                StartTimePicker.Value.Minute,
                StartTimePicker.Value.Second);
            // end time
            NewEvent.EndTime = new DateTime(
                datePicker.Value.Year,
                datePicker.Value.Month,
                datePicker.Value.Day,
                EndTimePicker.Value.Hour,
                EndTimePicker.Value.Minute,
                EndTimePicker.Value.Second);
            // event type name
            NewEvent.EventTypeName = EventBox.Text;
            // event type id
            NewEvent.EventTypeId = EventDisplayData[EventBox.SelectedIndex].EventTypeId;
            // create event in the database and return the id assigned to it when inserting
            NewEvent = OrganizerLibrary.GlobalConfig.Connections[0].CreateEvent(NewEvent);
            // removes empty row
            DisplayData.Remove(DisplayData[DisplayData.Count - 1]);
            // add new event to the displayed events
            DisplayData.Add(NewEvent);
            // adds empty row
            DisplayData.Add(new EventModel());
            ScheduleView.Refresh();
            // TODO - add sorting by time, so that the new event takes its place in the table according to the start time

        }
        // removing selected event from agenda  
        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            OrganizerLibrary.GlobalConfig.Connections[0].DeleteEvent(DisplayData[activeRow]);
            DisplayData.Remove(DisplayData[activeRow]);
            ScheduleView.Refresh();
        }
        #endregion
    }
}
