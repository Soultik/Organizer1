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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewScheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm f2 = new ScheduleForm(); 
            f2.ShowDialog();
        }

        private void BasicScheduleButton_Click(object sender, EventArgs e)
        {
            BasicScheduleForm f3 = new BasicScheduleForm();
            f3.ShowDialog();
        }

        private void AssignmentsButton_Click(object sender, EventArgs e)
        {
            AssignmentsForm f4 = new AssignmentsForm();
            f4.ShowDialog();
        }

        private void EventeTypesButton_Click(object sender, EventArgs e)
        {
            ViewEventTypeForm f5 = new ViewEventTypeForm();
            f5.ShowDialog();
        }
    }
}
