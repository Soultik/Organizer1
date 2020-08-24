namespace OrganizerUI
{
    partial class BasicScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicScheduleForm));
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayCombobox = new System.Windows.Forms.ComboBox();
            this.ScheduleView = new System.Windows.Forms.DataGridView();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(12, 18);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(56, 32);
            this.WeekdayLabel.TabIndex = 0;
            this.WeekdayLabel.Text = "Day";
            // 
            // WeekdayCombobox
            // 
            this.WeekdayCombobox.FormattingEnabled = true;
            this.WeekdayCombobox.Location = new System.Drawing.Point(74, 18);
            this.WeekdayCombobox.Name = "WeekdayCombobox";
            this.WeekdayCombobox.Size = new System.Drawing.Size(184, 39);
            this.WeekdayCombobox.TabIndex = 1;
            this.WeekdayCombobox.SelectedIndexChanged += new System.EventHandler(this.WeekdayCombobox_SelectedIndexChanged);
            // 
            // ScheduleView
            // 
            this.ScheduleView.AllowUserToAddRows = false;
            this.ScheduleView.AllowUserToDeleteRows = false;
            this.ScheduleView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleView.AutoGenerateColumns = false;
            this.ScheduleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScheduleView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ScheduleView.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.eventTypeNameDataGridViewTextBoxColumn});
            this.ScheduleView.DataSource = this.eventModelBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ScheduleView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ScheduleView.EnableHeadersVisualStyles = false;
            this.ScheduleView.Location = new System.Drawing.Point(-6, 63);
            this.ScheduleView.Name = "ScheduleView";
            this.ScheduleView.ReadOnly = true;
            this.ScheduleView.RowHeadersWidth = 51;
            this.ScheduleView.RowTemplate.Height = 24;
            this.ScheduleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleView.Size = new System.Drawing.Size(891, 461);
            this.ScheduleView.TabIndex = 2;
            this.ScheduleView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleView_RowEnter);
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.startTimeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start time";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            dataGridViewCellStyle3.Format = "HH:mm";
            this.endTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.endTimeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventTypeNameDataGridViewTextBoxColumn
            // 
            this.eventTypeNameDataGridViewTextBoxColumn.DataPropertyName = "EventTypeName";
            this.eventTypeNameDataGridViewTextBoxColumn.FillWeight = 60F;
            this.eventTypeNameDataGridViewTextBoxColumn.HeaderText = "Event type";
            this.eventTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventTypeNameDataGridViewTextBoxColumn.Name = "eventTypeNameDataGridViewTextBoxColumn";
            this.eventTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventModelBindingSource
            // 
            this.eventModelBindingSource.DataSource = typeof(OrganizerLibrary.Models.EventModel);
            // 
            // EventBox
            // 
            this.EventBox.BackColor = System.Drawing.Color.DimGray;
            this.EventBox.ForeColor = System.Drawing.Color.White;
            this.EventBox.FormattingEnabled = true;
            this.EventBox.Location = new System.Drawing.Point(12, 570);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(221, 39);
            this.EventBox.TabIndex = 3;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 535);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(162, 32);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type of event";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(231, 536);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(118, 32);
            this.StartTimeLabel.TabIndex = 7;
            this.StartTimeLabel.Text = "Start time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(239, 578);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(110, 32);
            this.EndTimeLabel.TabIndex = 8;
            this.EndTimeLabel.Text = "End time";
            // 
            // AddEventButton
            // 
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Location = new System.Drawing.Point(474, 533);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(191, 41);
            this.AddEventButton.TabIndex = 9;
            this.AddEventButton.Text = "Add event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(474, 578);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(191, 41);
            this.DeleteSelectedButton.TabIndex = 10;
            this.DeleteSelectedButton.Text = "Delete selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(17, 682);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(109, 32);
            this.EndDateLabel.TabIndex = 14;
            this.EndDateLabel.Text = "End date";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(9, 631);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(117, 32);
            this.StartDateLabel.TabIndex = 13;
            this.StartDateLabel.Text = "Start date";
            // 
            // InitializeButton
            // 
            this.InitializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InitializeButton.Location = new System.Drawing.Point(383, 627);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(490, 93);
            this.InitializeButton.TabIndex = 15;
            this.InitializeButton.Text = "Initialize for between given dates";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // EditEventButton
            // 
            this.EditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEventButton.Location = new System.Drawing.Point(671, 533);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(202, 86);
            this.EditEventButton.TabIndex = 16;
            this.EditEventButton.Text = "Edit selected";
            this.EditEventButton.UseVisualStyleBackColor = true;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(355, 535);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(113, 38);
            this.StartTimePicker.TabIndex = 17;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(355, 579);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(113, 38);
            this.EndTimePicker.TabIndex = 18;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarForeColor = System.Drawing.Color.DimGray;
            this.StartDatePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.StartDatePicker.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.StartDatePicker.Location = new System.Drawing.Point(132, 627);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(245, 38);
            this.StartDatePicker.TabIndex = 19;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CalendarForeColor = System.Drawing.Color.DimGray;
            this.EndDatePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.EndDatePicker.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.EndDatePicker.Location = new System.Drawing.Point(132, 682);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(245, 38);
            this.EndDatePicker.TabIndex = 20;
            // 
            // BasicScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(885, 726);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.EditEventButton);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.ScheduleView);
            this.Controls.Add(this.WeekdayCombobox);
            this.Controls.Add(this.WeekdayLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(903, 773);
            this.MinimumSize = new System.Drawing.Size(903, 773);
            this.Name = "BasicScheduleForm";
            this.Text = "BasicScheduleForm";
            this.Load += new System.EventHandler(this.BasicScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.ComboBox WeekdayCombobox;
        private System.Windows.Forms.DataGridView ScheduleView;
        private System.Windows.Forms.BindingSource eventModelBindingSource;
        private System.Windows.Forms.ComboBox EventBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeNameDataGridViewTextBoxColumn;
    }
}