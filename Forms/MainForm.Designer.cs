namespace ModNote
{
    partial class MainForm
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
            this.loadModuleTxt = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.moduleList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveAllBtn = new System.Windows.Forms.Button();
            this.editModBtn = new System.Windows.Forms.Button();
            this.newModBtn = new System.Windows.Forms.Button();
            this.remModBtn = new System.Windows.Forms.Button();
            this.notesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load modules from directory";
            // 
            // loadModuleTxt
            // 
            this.loadModuleTxt.Location = new System.Drawing.Point(168, 6);
            this.loadModuleTxt.Name = "loadModuleTxt";
            this.loadModuleTxt.Size = new System.Drawing.Size(294, 20);
            this.loadModuleTxt.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(468, 4);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(99, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // moduleList
            // 
            this.moduleList.FormattingEnabled = true;
            this.moduleList.Location = new System.Drawing.Point(168, 55);
            this.moduleList.Name = "moduleList";
            this.moduleList.Size = new System.Drawing.Size(294, 134);
            this.moduleList.TabIndex = 3;
            this.moduleList.DoubleClick += new System.EventHandler(this.moduleList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loaded modules";
            // 
            // saveAllBtn
            // 
            this.saveAllBtn.Location = new System.Drawing.Point(468, 166);
            this.saveAllBtn.Name = "saveAllBtn";
            this.saveAllBtn.Size = new System.Drawing.Size(99, 23);
            this.saveAllBtn.TabIndex = 5;
            this.saveAllBtn.Text = "Save All";
            this.saveAllBtn.UseVisualStyleBackColor = true;
            this.saveAllBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // editModBtn
            // 
            this.editModBtn.Location = new System.Drawing.Point(468, 84);
            this.editModBtn.Name = "editModBtn";
            this.editModBtn.Size = new System.Drawing.Size(99, 23);
            this.editModBtn.TabIndex = 6;
            this.editModBtn.Text = "Edit Selected";
            this.editModBtn.UseVisualStyleBackColor = true;
            this.editModBtn.Click += new System.EventHandler(this.editModBtn_Click);
            // 
            // newModBtn
            // 
            this.newModBtn.Location = new System.Drawing.Point(468, 55);
            this.newModBtn.Name = "newModBtn";
            this.newModBtn.Size = new System.Drawing.Size(99, 23);
            this.newModBtn.TabIndex = 7;
            this.newModBtn.Text = "New Module";
            this.newModBtn.UseVisualStyleBackColor = true;
            this.newModBtn.Click += new System.EventHandler(this.newModBtn_Click);
            // 
            // remModBtn
            // 
            this.remModBtn.Location = new System.Drawing.Point(468, 113);
            this.remModBtn.Name = "remModBtn";
            this.remModBtn.Size = new System.Drawing.Size(99, 23);
            this.remModBtn.TabIndex = 8;
            this.remModBtn.Text = "Delete Module";
            this.remModBtn.UseVisualStyleBackColor = true;
            this.remModBtn.Click += new System.EventHandler(this.remModBtn_Click);
            // 
            // notesBtn
            // 
            this.notesBtn.Location = new System.Drawing.Point(168, 195);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.Size = new System.Drawing.Size(99, 23);
            this.notesBtn.TabIndex = 9;
            this.notesBtn.Text = "Notes";
            this.notesBtn.UseVisualStyleBackColor = true;
            this.notesBtn.Click += new System.EventHandler(this.notesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 229);
            this.Controls.Add(this.notesBtn);
            this.Controls.Add(this.remModBtn);
            this.Controls.Add(this.newModBtn);
            this.Controls.Add(this.editModBtn);
            this.Controls.Add(this.saveAllBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moduleList);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.loadModuleTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "ModNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loadModuleTxt;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox moduleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveAllBtn;
        private System.Windows.Forms.Button editModBtn;
        private System.Windows.Forms.Button newModBtn;
        private System.Windows.Forms.Button remModBtn;
        private System.Windows.Forms.Button notesBtn;
    }
}

