using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrganizerLibrary.Models;
using OrganizerLibrary.DataConnection;
using System.ComponentModel;

namespace OrganizerUI
{
    public partial class AssignmentsForm : Form
    {
        private BindingList<AssignmentModel> DisplayData = new BindingList<AssignmentModel>();
        #region BasicFormEventsAndVariables
       
        private int activeRow;
        public AssignmentsForm()
        {
            InitializeComponent();
        }
        private void AssignmentsForm_Load(object sender, EventArgs e)
        {        
            DisplayData = OrganizerLibrary.GlobalConfig.Connections[0].GetAssignment_All();
            DisplayData.Add(new AssignmentModel());
            AView.DataSource = DisplayData;
            AView.ClearSelection();
        }
        
        // When someone selects a row in dataviewbox
        private void AView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // choose the row index of the selected row
            int rowIndex = e.RowIndex;
            // set active row variable to current row
            activeRow = rowIndex;
            // initialize form controls with data from the selected row
            // so it can be changed 
            CommentRichBox.Text = DisplayData[rowIndex].Comment;

            if (DisplayData[rowIndex].DateToFinish.Date > DateTime.MinValue)
            {
                DateFinishPicker.Value = DisplayData[rowIndex].DateToFinish.Date;
            }
            else
            {
                DateFinishPicker.Value = DateTime.Now;
            }

            if (DisplayData[rowIndex].DateToFinish.Date > DateTime.MinValue)
            {
                HoursPicker.Value = DisplayData[rowIndex].DateToFinish;
            }
            else
            {
                HoursPicker.Value = DateTime.Now;
            }
        }

        #endregion
        #region ButtonClicks
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // combines date data and time data from two picker controls
                DateTime finish = DateFinishPicker.Value.Date +
                    HoursPicker.Value.TimeOfDay;

                //initializes the assignment with 4 parameter constructor
                AssignmentModel model = new AssignmentModel(
                    CommentRichBox.Text, 
                    false, 
                    DateTime.Now, 
                    finish);

                //inserts the new assignmnet into the database
                OrganizerLibrary.GlobalConfig.Connections[0].CreateAssignment(model);

                DisplayData[DisplayData.Count - 1] = model;
                DisplayData.Add(new AssignmentModel());
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
            
        }
        private void EditSelectedButton_Click(object sender, EventArgs e)
        {
            DisplayData[activeRow].Comment = CommentRichBox.Text;
            DisplayData[activeRow].DateToFinish = DateFinishPicker.Value.Date +
                    HoursPicker.Value.TimeOfDay;

            OrganizerLibrary.GlobalConfig.Connections[0].UpdateAssignment(DisplayData[activeRow]);
            Refresh();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OrganizerLibrary.GlobalConfig.Connections[0].DeleteAssignment(DisplayData[activeRow]);
            DisplayData.Remove(DisplayData[activeRow]);
        }

        #endregion
        #region Helpers

        /// <summary>
        /// Validates input in assignments forms.
        /// </summary>
        /// <returns>
        /// True if the data is corect, false otherwise. Checks if the due time is not earlier 
        /// than the current time.
        /// </returns>
        private bool ValidateForm()
        {
            bool output = true;
            
            // checks if the date/time given lie in the future,
            // you can't a task retroactively
            if (DateFinishPicker.Value.Date +
                    HoursPicker.Value.TimeOfDay < DateTime.Now)
            {
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Creates a test entry used to check data formatting in the dataview 
        /// controller of the form.
        /// </summary>
        /// <returns>
        /// Test entry.
        /// </returns>
        AssignmentModel CreateTestEntry()
        {
            AssignmentModel A = new AssignmentModel();
            A.GeneralAssignmentId = 1;
            A.Comment = "I need to develop organizer application for Windows first. " +
                "Then make a web app that touches upon the same idea. And then maybe an android app. Hopefully it will be " +
                "enough for portfolio";
            A.DateAdded = new DateTime(2020, 7, 28);
            A.DateToFinish = new DateTime(2020, 8, 31);
            A.IsDone = false;
            return A;
        }

        #endregion              
        #region CheckboxHandling

        // checkbox state changing
        private void AView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                // update data in the database
                OrganizerLibrary.GlobalConfig.Connections[0].UpdateAssignment(DisplayData[e.RowIndex]);
                
            }
        }
        
        /* the code to tell the checkbox it is done editing when it is clicked, 
           instead of waiting till the user leaves the field*/
        private void AView_OnCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                AView.EndEdit();
            }
        }


        #endregion
    }
}
