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
    public partial class BasicScheduleForm : Form
    {
        #region BasicFormDataAndEvents
        // a date in the past
        DateTime ninetyNine = new DateTime(1999, 12, 31, 0, 0, 0);
        // which row has focus at the time
        private int activeRow;
        // for day combobox control
        private enum DayEnum {Weekday = 1, Weekend = 2};
        // list of event that will be displayed in gridview form
        BindingList<EventModel> DisplayData = new BindingList<EventModel>();
        // constructor
        public BasicScheduleForm()
        {
            InitializeComponent();
            
        }
        // list used for storing and displaying event types in eventbox control
        BindingList<EventTypeModel> EventDisplayData =
            OrganizerLibrary.GlobalConfig.Connections[0].GetEventType_All();

        // form load
        private void BasicScheduleForm_Load(object sender, EventArgs e)
        {
            WeekdayCombobox.DataSource = Enum.GetValues(typeof(DayEnum));
            EventBox.DataSource = EventDisplayData;
            EventBox.DisplayMember = "EventTypeName";
            EventBox.SelectedIndex = EventBox.FindStringExact(DisplayData[0].EventTypeName);
        }
        // loading template events for different days
        private void WeekdayCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData = OrganizerLibrary.GlobalConfig.Connections[0].GetTemplateEvents(WeekdayCombobox.Text);
            DisplayData.Add(new EventModel());
            ScheduleView.DataSource = DisplayData;
            ScheduleView.Refresh();
        }
        // row takes focus
        private void ScheduleView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // choose the row index of the selected row
            int rowIndex = e.RowIndex;
            // set active row variable to current row
            activeRow = rowIndex;
            // initialize form controls with data from the selected row
            // so it can be changed 

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
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            // initializng var
            var NewEvent = new EventModel();
            // editing the new event with new data taken from form controls

            // start time
            NewEvent.StartTime = new DateTime(
                ninetyNine.Year,
                ninetyNine.Month,
                ninetyNine.Day,
                StartTimePicker.Value.Hour,
                StartTimePicker.Value.Minute,
                StartTimePicker.Value.Second);
            // end time
            NewEvent.EndTime = new DateTime(
                ninetyNine.Year,
                ninetyNine.Month,
                ninetyNine.Day,
                EndTimePicker.Value.Hour,
                EndTimePicker.Value.Minute,
                EndTimePicker.Value.Second);
            // event type name
            NewEvent.EventTypeName = EventBox.Text;
            // event type id
            NewEvent.EventTypeId = EventDisplayData[EventBox.SelectedIndex].EventTypeId;
            // create event in the database and return the id assigned to it when inserting
            NewEvent = OrganizerLibrary.GlobalConfig.Connections[0].CreateTemplateEvent(
                NewEvent,
                WeekdayCombobox.SelectedIndex + 1);
            // removes empty row
            DisplayData.Remove(DisplayData[DisplayData.Count - 1]);
            // add new event to the displayed events
            DisplayData.Add(NewEvent);
            // adds empty row
            DisplayData.Add(new EventModel());
            ScheduleView.Refresh();
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            OrganizerLibrary.GlobalConfig.Connections[0].DeleteTemplateEvent(DisplayData[activeRow]);
            DisplayData.Remove(DisplayData[activeRow]);
            ScheduleView.Refresh();
        }

        private void EditEventButton_Click(object sender, EventArgs e)
        {
            // editing the chosen event with new data taken from form controls

            // start time
            DisplayData[activeRow].StartTime = new DateTime(
                ninetyNine.Year,
                ninetyNine.Month,
                ninetyNine.Day,
                StartTimePicker.Value.Hour,
                StartTimePicker.Value.Minute,
                StartTimePicker.Value.Second);
            // end time
            DisplayData[activeRow].EndTime = new DateTime(
                ninetyNine.Year,
                ninetyNine.Month,
                ninetyNine.Day,
                EndTimePicker.Value.Hour,
                EndTimePicker.Value.Minute,
                EndTimePicker.Value.Second);
            // event type name
            DisplayData[activeRow].EventTypeName = EventBox.Text;
            // event type id
            DisplayData[activeRow].EventTypeId = EventDisplayData[EventBox.SelectedIndex].EventTypeId;
            // update event in the database
            OrganizerLibrary.GlobalConfig.Connections[0].UpdateTemplateEvent(DisplayData[activeRow]);

            ScheduleView.Refresh();
        }
        #endregion

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            // removes empty member from display data list
            DisplayData.Remove(DisplayData[DisplayData.Count-1]);
            // 
            OrganizerLibrary.GlobalConfig.Connections[0].InitializeBasicSchedule(
                DisplayData.ToList(), 
                StartDatePicker.Value.Date, 
                EndDatePicker.Value.Date,
                WeekdayCombobox.Text);
            // adds empty member to display data list, so that that empty row could be used for creating new events
            DisplayData.Add(new EventModel());
        }
    }
}
