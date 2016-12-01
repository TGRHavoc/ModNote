namespace ModNote.Forms
{
    partial class AssignmentForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.dueDatePckr = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.wcChck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(31, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(31, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Type";
            // 
            // dueDateLbl
            // 
            this.dueDateLbl.AutoSize = true;
            this.dueDateLbl.Location = new System.Drawing.Point(12, 56);
            this.dueDateLbl.Name = "dueDateLbl";
            this.dueDateLbl.Size = new System.Drawing.Size(53, 13);
            this.dueDateLbl.TabIndex = 4;
            this.dueDateLbl.Text = "Due Date";
            // 
            // dueDatePckr
            // 
            this.dueDatePckr.Location = new System.Drawing.Point(68, 56);
            this.dueDatePckr.Name = "dueDatePckr";
            this.dueDatePckr.Size = new System.Drawing.Size(204, 20);
            this.dueDatePckr.TabIndex = 5;
            this.dueDatePckr.ValueChanged += new System.EventHandler(this.dueDatePckr_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 82);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(153, 82);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Assignment",
            "In-Class Test"});
            this.typeBox.Location = new System.Drawing.Point(68, 6);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(204, 21);
            this.typeBox.TabIndex = 8;
            this.typeBox.Text = "Please select a type";
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // wcChck
            // 
            this.wcChck.AutoSize = true;
            this.wcChck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wcChck.Checked = true;
            this.wcChck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wcChck.Location = new System.Drawing.Point(33, 33);
            this.wcChck.Name = "wcChck";
            this.wcChck.Size = new System.Drawing.Size(49, 17);
            this.wcChck.TabIndex = 9;
            this.wcChck.Text = "W/C";
            this.toolTip1.SetToolTip(this.wcChck, "Check this if the due date is the Week Commencing the due date");
            this.wcChck.UseVisualStyleBackColor = true;
            this.wcChck.CheckedChanged += new System.EventHandler(this.wcChck_CheckedChanged);
            // 
            // CreateAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.wcChck);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dueDatePckr);
            this.Controls.Add(this.dueDateLbl);
            this.Controls.Add(this.nameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateAssignmentForm";
            this.Text = "Create Assignment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAssignmentForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label dueDateLbl;
        private System.Windows.Forms.DateTimePicker dueDatePckr;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.CheckBox wcChck;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}