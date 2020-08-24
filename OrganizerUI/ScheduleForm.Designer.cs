namespace OrganizerUI
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.ScheduleView = new System.Windows.Forms.DataGridView();
            this.eventModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventBox = new System.Windows.Forms.ComboBox();
            this.EventLabel = new System.Windows.Forms.Label();
            this.CommentaryLabel = new System.Windows.Forms.Label();
            this.CommentaryBox = new System.Windows.Forms.RichTextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CalendarForeColor = System.Drawing.Color.DimGray;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.datePicker.Location = new System.Drawing.Point(12, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 38);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // ScheduleView
            // 
            this.ScheduleView.AllowUserToAddRows = false;
            this.ScheduleView.AllowUserToOrderColumns = true;
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
            this.eventTypeNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
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
            this.ScheduleView.Location = new System.Drawing.Point(-8, 56);
            this.ScheduleView.Name = "ScheduleView";
            this.ScheduleView.RowHeadersWidth = 51;
            this.ScheduleView.RowTemplate.Height = 24;
            this.ScheduleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScheduleView.Size = new System.Drawing.Size(909, 431);
            this.ScheduleView.TabIndex = 3;
            this.ScheduleView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleView_RowEnter);
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
            this.EventBox.Location = new System.Drawing.Point(182, 498);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(229, 39);
            this.EventBox.TabIndex = 4;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.Location = new System.Drawing.Point(31, 498);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(128, 32);
            this.EventLabel.TabIndex = 5;
            this.EventLabel.Text = "Event type";
            // 
            // CommentaryLabel
            // 
            this.CommentaryLabel.AutoSize = true;
            this.CommentaryLabel.Location = new System.Drawing.Point(6, 551);
            this.CommentaryLabel.Name = "CommentaryLabel";
            this.CommentaryLabel.Size = new System.Drawing.Size(153, 32);
            this.CommentaryLabel.TabIndex = 6;
            this.CommentaryLabel.Text = "Commentary";
            // 
            // CommentaryBox
            // 
            this.CommentaryBox.BackColor = System.Drawing.Color.DimGray;
            this.CommentaryBox.ForeColor = System.Drawing.Color.White;
            this.CommentaryBox.Location = new System.Drawing.Point(182, 560);
            this.CommentaryBox.Name = "CommentaryBox";
            this.CommentaryBox.Size = new System.Drawing.Size(229, 86);
            this.CommentaryBox.TabIndex = 7;
            this.CommentaryBox.Text = "";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(427, 516);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(118, 32);
            this.StartTimeLabel.TabIndex = 8;
            this.StartTimeLabel.Text = "Start time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(427, 586);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(110, 32);
            this.EndTimeLabel.TabIndex = 9;
            this.EndTimeLabel.Text = "End time";
            // 
            // AddEventButton
            // 
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Location = new System.Drawing.Point(691, 544);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(192, 48);
            this.AddEventButton.TabIndex = 13;
            this.AddEventButton.Text = "Add event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(691, 598);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(192, 48);
            this.DeleteSelectedButton.TabIndex = 14;
            this.DeleteSelectedButton.Text = "Delete selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // EditEventButton
            // 
            this.EditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEventButton.Location = new System.Drawing.Point(691, 493);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(192, 48);
            this.EditEventButton.TabIndex = 15;
            this.EditEventButton.Text = "Edit event";
            this.EditEventButton.UseVisualStyleBackColor = true;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(551, 514);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(113, 38);
            this.StartTimePicker.TabIndex = 16;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(551, 586);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(113, 38);
            this.EndTimePicker.TabIndex = 17;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.startTimeDataGridViewTextBoxColumn.FillWeight = 15F;
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
            this.endTimeDataGridViewTextBoxColumn.FillWeight = 15F;
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "End time";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventTypeNameDataGridViewTextBoxColumn
            // 
            this.eventTypeNameDataGridViewTextBoxColumn.DataPropertyName = "EventTypeName";
            this.eventTypeNameDataGridViewTextBoxColumn.FillWeight = 25F;
            this.eventTypeNameDataGridViewTextBoxColumn.HeaderText = "Event";
            this.eventTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventTypeNameDataGridViewTextBoxColumn.Name = "eventTypeNameDataGridViewTextBoxColumn";
            this.eventTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 45F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(895, 654);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.EditEventButton);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.CommentaryBox);
            this.Controls.Add(this.CommentaryLabel);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.ScheduleView);
            this.Controls.Add(this.datePicker);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView ScheduleView;
        private System.Windows.Forms.BindingSource eventModelBindingSource;
        private System.Windows.Forms.ComboBox EventBox;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label CommentaryLabel;
        private System.Windows.Forms.RichTextBox CommentaryBox;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}