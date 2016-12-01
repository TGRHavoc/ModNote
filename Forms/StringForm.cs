using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModNote.Forms
{
    public partial class StringForm : Form
    {
        Form parentForm;
        Action<string> callback;
        bool saved = false;

        public StringForm(Form parent, Action<string> callback)
        {
            InitializeComponent();

            this.callback = callback;
            this.parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callback(enteredTxt.Text);
            saved = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue? You will lose your learning outcome.", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Do nothing
                Dispose(true); //Get rid of the form.
            }
        }

        private void StringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(enteredTxt.Text) && !saved)
            {
                //They have entered something.. Make sure they know what's going down
                DialogResult res = MessageBox.Show("Are you sure you want to exit without saving the learning outcome?", "Quit...", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            if (!e.Cancel)
                parentForm.Show();
        }
    }
}
