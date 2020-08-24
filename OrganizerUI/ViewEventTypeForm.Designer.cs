namespace OrganizerUI
{
    partial class ViewEventTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEventTypeForm));
            this.ModifySelectedButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EventList = new System.Windows.Forms.ListBox();
            this.eventTypeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifySelectedButton
            // 
            this.ModifySelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifySelectedButton.Location = new System.Drawing.Point(347, 23);
            this.ModifySelectedButton.Name = "ModifySelectedButton";
            this.ModifySelectedButton.Size = new System.Drawing.Size(125, 81);
            this.ModifySelectedButton.TabIndex = 1;
            this.ModifySelectedButton.Text = "Modify selected";
            this.ModifySelectedButton.UseVisualStyleBackColor = true;
            this.ModifySelectedButton.Click += new System.EventHandler(this.ModifySelectedButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Location = new System.Drawing.Point(487, 23);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(125, 81);
            this.AddNewButton.TabIndex = 2;
            this.AddNewButton.Text = "Add new";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.DimGray;
            this.NameBox.ForeColor = System.Drawing.Color.White;
            this.NameBox.Location = new System.Drawing.Point(347, 173);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(265, 38);
            this.NameBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(347, 128);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 32);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // EventList
            // 
            this.EventList.BackColor = System.Drawing.Color.DimGray;
            this.EventList.ForeColor = System.Drawing.Color.White;
            this.EventList.FormattingEnabled = true;
            this.EventList.ItemHeight = 31;
            this.EventList.Location = new System.Drawing.Point(12, 3);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(311, 345);
            this.EventList.TabIndex = 5;
            this.EventList.SelectedIndexChanged += new System.EventHandler(this.EventList_SelectedIndexChanged);
            // 
            // eventTypeModelBindingSource
            // 
            this.eventTypeModelBindingSource.DataSource = typeof(OrganizerLibrary.Models.EventTypeModel);
            // 
            // ViewEventTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(656, 353);
            this.Controls.Add(this.EventList);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.ModifySelectedButton);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(674, 400);
            this.MinimumSize = new System.Drawing.Size(674, 400);
            this.Name = "ViewEventTypeForm";
            this.Text = "ViewEventTypeForm";
            this.Load += new System.EventHandler(this.ViewEventTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModifySelectedButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.BindingSource eventTypeModelBindingSource;
        private System.Windows.Forms.ListBox EventList;
    }
}