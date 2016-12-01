using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModNote.Objects;

namespace ModNote.Forms
{
    public partial class AssignmentForm : Form
    {
        bool save = false;
        Form parentForm;
        Action<Assignment, bool> callback;

        Assignment myAssignment;

        public AssignmentForm(Form parent, Action<Assignment, bool> callback)
        {
            InitializeComponent();

            parentForm = parent;
            this.callback = callback;
            myAssignment = new Assignment();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save = true;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateAssignmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (typeBox.Text != "Please select a type" && !save)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?\nYour data won't be saved.", "Quit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //They are sure
                    Dispose(true);
                    parentForm.Show();
                    return;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }else if(typeBox.Text == "Please select a type" && save)
            {
                DialogResult result = MessageBox.Show("You cannot save the assignment without a type.\nPlease select a type from the dropdown box.", "Please select a type", MessageBoxButtons.OK);
                e.Cancel = true;
                return;
            }

            myAssignment.Date = dueDatePckr.Value;
            myAssignment.Type = typeBox.Text;
            myAssignment.WeekCommencing = wcChck.Checked;

            callback(myAssignment, true);
            Dispose(true);
            parentForm.Show();
        }

        private void wcChck_CheckedChanged(object sender, EventArgs e)
        {
            myAssignment.WeekCommencing = wcChck.Checked;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myAssignment.Type = typeBox.Text;
        }

        private void dueDatePckr_ValueChanged(object sender, EventArgs e)
        {
            myAssignment.Date = dueDatePckr.Value;
        }
    }
}
