using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

using ModNote.Objects;

namespace ModNote.Forms
{
    public partial class ModuleForm : Form
    {
        private Form parentForm;
        private Module myModule;
        private Action<Module> doneMethod;

        /// <summary>
        /// Call this constructor to create a new module
        /// </summary>
        public ModuleForm(Form parent, Action<Module> callback)
        {
            InitializeComponent();

            parentForm = parent;
            myModule = new Module();
            doneMethod = callback;

        }

        /// <summary>
        /// Call this constructor to edit an existing module
        /// </summary>
        /// <param name="toEdit">The module to edit</param>
        public ModuleForm(Form parent, Action<Module> callback, Module toEdit)
        {
            InitializeComponent();

            parentForm = parent;
            myModule = toEdit;
            doneMethod = callback;

            //Load the module's data into the form
            codeTxt.Text = myModule.Code;
            nameTxt.Text = myModule.Title;
            summaryTxt.Text = myModule.Synopsis;

            foreach (string lo in myModule.LearningOutcomes)
                loList.Items.Add(lo);

            foreach (Assignment assignment in myModule.Assignments)
                addAssignment(assignment, false);
        }

        private void addAssignmentBtn_Click(object sender, EventArgs e)
        {
            //TODO: Open the assignment form and do stuff
            Hide();
            new AssignmentForm(this, addAssignment).Show();
        }

        public void addAssignment(Assignment assignment, bool isNew = true)
        {
            if (isNew)
                myModule.AddAssignment(assignment);


            ListViewItem li = new ListViewItem();
            li.Text = assignment.FormString;

            if (assignment.FormString.Contains("Deadline Passed"))
            {
                li.BackColor = Color.OrangeRed;
                li.ForeColor = Color.Yellow;
            }

            assignmentLst.Items.Add(li);
        }

        private void saveModBtn_Click(object sender, EventArgs e)
        {
            doneMethod(myModule);
            this.Close();
        }

        private void addLoBtn_Click(object sender, EventArgs e)
        {
            //new EnterStringForm(AddLearningObjective).Show();
            new StringForm(this, AddLearningObjective).Show();
        }

        private void AddLearningObjective(string toAdd)
        {
            myModule.AddLearningOutcome(toAdd);
            loList.Items.Add(toAdd);
        }

        private void ModuleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();//Show the parent form
        }

        private void codeTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codeTxt.Text))
            {
                MessageBox.Show("Sorry, the module code cannot be empty!", "Error", MessageBoxButtons.OK);
                codeTxt.Focus();
                return;
            }

            myModule.Code = codeTxt.Text;
        }

        private void summaryTxt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(summaryTxt.Text))
            {
                myModule.Synopsis = summaryTxt.Text;
            }
        }

        private void rmvLoBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = loList.SelectedItems;
            if (selected.Count < 1)
            {
                MessageBox.Show("Please select a learning outcome to remove", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (ListViewItem toRemove in selected)
            {
                Console.WriteLine("Trying to remove: " + toRemove.Text);

                //Console.WriteLine(learningOutcomes.ToString(""));
                myModule.RemoveLearningOutcome(toRemove.Text);
                toRemove.Remove(); //Remove from list
            }
        }

        private void remAsmtBtn_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = assignmentLst.SelectedItems;
            if (selected.Count < 1)
            {
                MessageBox.Show("Please select an assignment to remove", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (ListViewItem toRemove in selected)
            {
                foreach(Assignment assignment in myModule.Assignments)
                {
                    if (toRemove.Text == assignment.FormString)
                    {
                        myModule.RemoveAssignment(assignment);
                    }
                }
                toRemove.Remove(); //Remove from list
            }
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
            {
                MessageBox.Show("Sorry, the module name cannot be empty!", "Error", MessageBoxButtons.OK);
                nameTxt.Focus();
                return;
            }

            myModule.Title = nameTxt.Text;
        }
    }
}
