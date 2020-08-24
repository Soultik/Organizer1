using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizerLibrary.Models;
using OrganizerLibrary.DataConnection;

namespace OrganizerUI
{
    public partial class ViewEventTypeForm : Form
    {
        private BindingList<EventTypeModel> DisplayData = new BindingList<EventTypeModel>();

        private int activeRow;

        public ViewEventTypeForm()
        {
            InitializeComponent();
        }

        private void ViewEventTypeForm_Load(object sender, EventArgs e)
        {
            
            DisplayData = OrganizerLibrary.GlobalConfig.Connections[0].GetEventType_All();
            
            DisplayData.Add(new EventTypeModel());
            WireUpListBox();
        }

        private void EventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventList.SelectedIndex >= 0)
            {
                NameBox.Text = DisplayData[EventList.SelectedIndex].EventTypeName;
            }
        }

        private void ModifySelectedButton_Click(object sender, EventArgs e)
        {
            DisplayData[EventList.SelectedIndex].EventTypeName = NameBox.Text;

            OrganizerLibrary.GlobalConfig.Connections[0].UpdateEventType(DisplayData[EventList.SelectedIndex]);
            WireUpListBox();            
        }
        void WireUpListBox()
        {
            EventList.ClearSelected();
            EventList.DataSource = null;
            EventList.DataSource = DisplayData;
            EventList.DisplayMember = "EventTypeName";
            EventList.Refresh();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            var new_model = new EventTypeModel();
            new_model.EventTypeName = NameBox.Text;                  

            DisplayData.Add(OrganizerLibrary.GlobalConfig.Connections[0].CreateEventType(new_model));

            List<EventTypeModel> temp = DisplayData.OrderByDescending(t => t.EventTypeName).ToList();
            DisplayData = new BindingList<EventTypeModel>(temp);
            WireUpListBox();
        }
    }
}
