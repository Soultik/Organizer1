namespace OrganizerUI
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ViewScheduleButton = new System.Windows.Forms.Button();
            this.BasicScheduleButton = new System.Windows.Forms.Button();
            this.AssignmentsButton = new System.Windows.Forms.Button();
            this.EventeTypesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewScheduleButton
            // 
            this.ViewScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewScheduleButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScheduleButton.ForeColor = System.Drawing.Color.White;
            this.ViewScheduleButton.Location = new System.Drawing.Point(-4, 0);
            this.ViewScheduleButton.MinimumSize = new System.Drawing.Size(424, 72);
            this.ViewScheduleButton.Name = "ViewScheduleButton";
            this.ViewScheduleButton.Size = new System.Drawing.Size(424, 72);
            this.ViewScheduleButton.TabIndex = 0;
            this.ViewScheduleButton.Text = "View schedule";
            this.ViewScheduleButton.UseVisualStyleBackColor = true;
            this.ViewScheduleButton.Click += new System.EventHandler(this.ViewScheduleButton_Click);
            // 
            // BasicScheduleButton
            // 
            this.BasicScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasicScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasicScheduleButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicScheduleButton.ForeColor = System.Drawing.Color.White;
            this.BasicScheduleButton.Location = new System.Drawing.Point(-4, 69);
            this.BasicScheduleButton.MinimumSize = new System.Drawing.Size(424, 72);
            this.BasicScheduleButton.Name = "BasicScheduleButton";
            this.BasicScheduleButton.Size = new System.Drawing.Size(424, 72);
            this.BasicScheduleButton.TabIndex = 1;
            this.BasicScheduleButton.Text = "Create basic schedule";
            this.BasicScheduleButton.UseVisualStyleBackColor = true;
            this.BasicScheduleButton.Click += new System.EventHandler(this.BasicScheduleButton_Click);
            // 
            // AssignmentsButton
            // 
            this.AssignmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignmentsButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentsButton.ForeColor = System.Drawing.Color.White;
            this.AssignmentsButton.Location = new System.Drawing.Point(-4, 137);
            this.AssignmentsButton.MinimumSize = new System.Drawing.Size(424, 72);
            this.AssignmentsButton.Name = "AssignmentsButton";
            this.AssignmentsButton.Size = new System.Drawing.Size(424, 72);
            this.AssignmentsButton.TabIndex = 2;
            this.AssignmentsButton.Text = "View assignmentes";
            this.AssignmentsButton.UseVisualStyleBackColor = true;
            this.AssignmentsButton.Click += new System.EventHandler(this.AssignmentsButton_Click);
            // 
            // EventeTypesButton
            // 
            this.EventeTypesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventeTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventeTypesButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventeTypesButton.ForeColor = System.Drawing.Color.White;
            this.EventeTypesButton.Location = new System.Drawing.Point(-4, 206);
            this.EventeTypesButton.MinimumSize = new System.Drawing.Size(424, 72);
            this.EventeTypesButton.Name = "EventeTypesButton";
            this.EventeTypesButton.Size = new System.Drawing.Size(424, 72);
            this.EventeTypesButton.TabIndex = 3;
            this.EventeTypesButton.Text = "View event types";
            this.EventeTypesButton.UseVisualStyleBackColor = true;
            this.EventeTypesButton.Click += new System.EventHandler(this.EventeTypesButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(413, 278);
            this.Controls.Add(this.EventeTypesButton);
            this.Controls.Add(this.AssignmentsButton);
            this.Controls.Add(this.BasicScheduleButton);
            this.Controls.Add(this.ViewScheduleButton);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(431, 325);
            this.MinimumSize = new System.Drawing.Size(431, 325);
            this.Name = "MainMenuForm";
            this.Text = "Organizer";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewScheduleButton;
        private System.Windows.Forms.Button BasicScheduleButton;
        private System.Windows.Forms.Button AssignmentsButton;
        private System.Windows.Forms.Button EventeTypesButton;
    }
}

