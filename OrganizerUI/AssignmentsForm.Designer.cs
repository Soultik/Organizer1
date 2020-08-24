namespace OrganizerUI
{
    partial class AssignmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentsForm));
            this.AView = new System.Windows.Forms.DataGridView();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDoneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.generalAssignmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateButton = new System.Windows.Forms.Button();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentRichBox = new System.Windows.Forms.RichTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DateFinishLabel = new System.Windows.Forms.Label();
            this.DateFinishPicker = new System.Windows.Forms.DateTimePicker();
            this.EditSelectedButton = new System.Windows.Forms.Button();
            this.HoursPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAssignmentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AView
            // 
            this.AView.AllowUserToAddRows = false;
            this.AView.AllowUserToOrderColumns = true;
            this.AView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AView.AutoGenerateColumns = false;
            this.AView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AView.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAddedDataGridViewTextBoxColumn,
            this.dateToFinishDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.isDoneDataGridViewCheckBoxColumn});
            this.AView.DataSource = this.generalAssignmentModelBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AView.DefaultCellStyle = dataGridViewCellStyle6;
            this.AView.EnableHeadersVisualStyles = false;
            this.AView.Location = new System.Drawing.Point(-5, 0);
            this.AView.Name = "AView";
            this.AView.RowHeadersWidth = 51;
            this.AView.RowTemplate.Height = 24;
            this.AView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AView.Size = new System.Drawing.Size(878, 461);
            this.AView.TabIndex = 0;
            this.AView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AView_CellEndEdit);
            this.AView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AView_OnCellMouseUp);
            this.AView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AView_RowEnter);
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateAddedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateAddedDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date added";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateToFinishDataGridViewTextBoxColumn
            // 
            this.dateToFinishDataGridViewTextBoxColumn.DataPropertyName = "DateToFinish";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateToFinishDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateToFinishDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dateToFinishDataGridViewTextBoxColumn.HeaderText = "When to finish";
            this.dateToFinishDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateToFinishDataGridViewTextBoxColumn.Name = "dateToFinishDataGridViewTextBoxColumn";
            this.dateToFinishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.commentDataGridViewTextBoxColumn.FillWeight = 50F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "What to do";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDoneDataGridViewCheckBoxColumn
            // 
            this.isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.isDoneDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.isDoneDataGridViewCheckBoxColumn.FillWeight = 10F;
            this.isDoneDataGridViewCheckBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isDoneDataGridViewCheckBoxColumn.HeaderText = "Is done";
            this.isDoneDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
            // 
            // generalAssignmentModelBindingSource
            // 
            this.generalAssignmentModelBindingSource.DataSource = typeof(OrganizerLibrary.Models.AssignmentModel);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(217, 552);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(261, 93);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create assignment";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(478, 473);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(135, 32);
            this.CommentLabel.TabIndex = 4;
            this.CommentLabel.Text = "What to do";
            // 
            // CommentRichBox
            // 
            this.CommentRichBox.BackColor = System.Drawing.Color.DimGray;
            this.CommentRichBox.ForeColor = System.Drawing.Color.White;
            this.CommentRichBox.Location = new System.Drawing.Point(484, 508);
            this.CommentRichBox.Name = "CommentRichBox";
            this.CommentRichBox.Size = new System.Drawing.Size(377, 137);
            this.CommentRichBox.TabIndex = 5;
            this.CommentRichBox.Text = "";
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(12, 552);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(199, 44);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DateFinishLabel
            // 
            this.DateFinishLabel.AutoSize = true;
            this.DateFinishLabel.Location = new System.Drawing.Point(6, 473);
            this.DateFinishLabel.Name = "DateFinishLabel";
            this.DateFinishLabel.Size = new System.Drawing.Size(172, 32);
            this.DateFinishLabel.TabIndex = 7;
            this.DateFinishLabel.Text = "When to finish";
            // 
            // DateFinishPicker
            // 
            this.DateFinishPicker.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.DateFinishPicker.Location = new System.Drawing.Point(12, 508);
            this.DateFinishPicker.Name = "DateFinishPicker";
            this.DateFinishPicker.Size = new System.Drawing.Size(243, 38);
            this.DateFinishPicker.TabIndex = 8;
            // 
            // EditSelectedButton
            // 
            this.EditSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSelectedButton.Location = new System.Drawing.Point(12, 602);
            this.EditSelectedButton.Name = "EditSelectedButton";
            this.EditSelectedButton.Size = new System.Drawing.Size(199, 43);
            this.EditSelectedButton.TabIndex = 9;
            this.EditSelectedButton.Text = "Edit selected";
            this.EditSelectedButton.UseVisualStyleBackColor = true;
            this.EditSelectedButton.Click += new System.EventHandler(this.EditSelectedButton_Click);
            // 
            // HoursPicker
            // 
            this.HoursPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoursPicker.Location = new System.Drawing.Point(261, 508);
            this.HoursPicker.Name = "HoursPicker";
            this.HoursPicker.ShowUpDown = true;
            this.HoursPicker.Size = new System.Drawing.Size(113, 38);
            this.HoursPicker.TabIndex = 10;
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(870, 647);
            this.Controls.Add(this.HoursPicker);
            this.Controls.Add(this.EditSelectedButton);
            this.Controls.Add(this.DateFinishPicker);
            this.Controls.Add(this.DateFinishLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CommentRichBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AView);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(888, 734);
            this.MinimumSize = new System.Drawing.Size(888, 694);
            this.Name = "AssignmentsForm";
            this.Text = "AssignmentsForm";
            this.Load += new System.EventHandler(this.AssignmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAssignmentModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.RichTextBox CommentRichBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource generalAssignmentModelBindingSource;
        private System.Windows.Forms.Label DateFinishLabel;
        private System.Windows.Forms.DateTimePicker DateFinishPicker;
        private System.Windows.Forms.Button EditSelectedButton;
        private System.Windows.Forms.DateTimePicker HoursPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
    }
}