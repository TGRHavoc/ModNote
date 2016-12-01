namespace ModNote.Forms
{
    partial class ModuleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loList = new System.Windows.Forms.ListView();
            this.addLoBtn = new System.Windows.Forms.Button();
            this.rmvLoBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addAssignmentBtn = new System.Windows.Forms.Button();
            this.saveModBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.remAsmtBtn = new System.Windows.Forms.Button();
            this.assignmentLst = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // codeTxt
            // 
            this.codeTxt.Location = new System.Drawing.Point(53, 6);
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.Size = new System.Drawing.Size(136, 20);
            this.codeTxt.TabIndex = 1;
            this.codeTxt.Leave += new System.EventHandler(this.codeTxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary";
            // 
            // summaryTxt
            // 
            this.summaryTxt.Location = new System.Drawing.Point(53, 70);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(136, 116);
            this.summaryTxt.TabIndex = 3;
            this.summaryTxt.Leave += new System.EventHandler(this.summaryTxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Learning Outcomes";
            // 
            // loList
            // 
            this.loList.Location = new System.Drawing.Point(300, 12);
            this.loList.Name = "loList";
            this.loList.Size = new System.Drawing.Size(178, 117);
            this.loList.TabIndex = 5;
            this.loList.TabStop = false;
            this.loList.UseCompatibleStateImageBehavior = false;
            this.loList.View = System.Windows.Forms.View.Tile;
            // 
            // addLoBtn
            // 
            this.addLoBtn.Location = new System.Drawing.Point(300, 135);
            this.addLoBtn.Name = "addLoBtn";
            this.addLoBtn.Size = new System.Drawing.Size(75, 23);
            this.addLoBtn.TabIndex = 4;
            this.addLoBtn.Text = "Add";
            this.addLoBtn.UseVisualStyleBackColor = true;
            this.addLoBtn.Click += new System.EventHandler(this.addLoBtn_Click);
            // 
            // rmvLoBtn
            // 
            this.rmvLoBtn.Location = new System.Drawing.Point(403, 135);
            this.rmvLoBtn.Name = "rmvLoBtn";
            this.rmvLoBtn.Size = new System.Drawing.Size(75, 23);
            this.rmvLoBtn.TabIndex = 5;
            this.rmvLoBtn.Text = "Remove";
            this.rmvLoBtn.UseVisualStyleBackColor = true;
            this.rmvLoBtn.Click += new System.EventHandler(this.rmvLoBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assignments";
            // 
            // addAssignmentBtn
            // 
            this.addAssignmentBtn.Location = new System.Drawing.Point(53, 311);
            this.addAssignmentBtn.Name = "addAssignmentBtn";
            this.addAssignmentBtn.Size = new System.Drawing.Size(97, 23);
            this.addAssignmentBtn.TabIndex = 6;
            this.addAssignmentBtn.Text = "Add Assignment";
            this.addAssignmentBtn.UseVisualStyleBackColor = true;
            this.addAssignmentBtn.Click += new System.EventHandler(this.addAssignmentBtn_Click);
            // 
            // saveModBtn
            // 
            this.saveModBtn.Location = new System.Drawing.Point(12, 357);
            this.saveModBtn.Name = "saveModBtn";
            this.saveModBtn.Size = new System.Drawing.Size(466, 23);
            this.saveModBtn.TabIndex = 8;
            this.saveModBtn.Text = "Save Module";
            this.saveModBtn.UseVisualStyleBackColor = true;
            this.saveModBtn.Click += new System.EventHandler(this.saveModBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(53, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(136, 20);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // remAsmtBtn
            // 
            this.remAsmtBtn.Location = new System.Drawing.Point(381, 311);
            this.remAsmtBtn.Name = "remAsmtBtn";
            this.remAsmtBtn.Size = new System.Drawing.Size(97, 23);
            this.remAsmtBtn.TabIndex = 7;
            this.remAsmtBtn.Text = "Remove Assignment";
            this.remAsmtBtn.UseVisualStyleBackColor = true;
            this.remAsmtBtn.Click += new System.EventHandler(this.remAsmtBtn_Click);
            // 
            // assignmentLst
            // 
            this.assignmentLst.Location = new System.Drawing.Point(53, 205);
            this.assignmentLst.Name = "assignmentLst";
            this.assignmentLst.Size = new System.Drawing.Size(425, 100);
            this.assignmentLst.TabIndex = 92;
            this.assignmentLst.UseCompatibleStateImageBehavior = false;
            this.assignmentLst.View = System.Windows.Forms.View.List;
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 392);
            this.Controls.Add(this.assignmentLst);
            this.Controls.Add(this.remAsmtBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveModBtn);
            this.Controls.Add(this.addAssignmentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rmvLoBtn);
            this.Controls.Add(this.addLoBtn);
            this.Controls.Add(this.loList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.summaryTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTxt);
            this.Controls.Add(this.label1);
            this.Name = "ModuleForm";
            this.Text = "Module";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModuleForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView loList;
        private System.Windows.Forms.Button addLoBtn;
        private System.Windows.Forms.Button rmvLoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addAssignmentBtn;
        private System.Windows.Forms.Button saveModBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button remAsmtBtn;
        private System.Windows.Forms.ListView assignmentLst;
    }
}