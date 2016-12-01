using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModNote.Objects;

namespace ModNote.Forms
{
    public partial class NoteForm : Form
    {
        Form parent;
        Module module;

        public NoteForm(Form parent, Module module)
        {
            InitializeComponent();

            this.module = module;
            this.parent = parent;

            foreach (Note note in module.Notes)
                notesBox.Items.Add(note.Title);

            notesBox.Items.Add("Create New");
        }

        private void notesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notesBox.Text == "Create New")
            {
                //TODO: Reset fields
                titleTxt.Text = "";
                contentTxt.Text = "";
            }
            else
            {
                //TODO: Get note and set fields
                Note selectedNote = module.Notes[notesBox.SelectedIndex];
                titleTxt.Text = selectedNote.Title;
                contentTxt.Text = selectedNote.Content;
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Note editedNote = new Note(titleTxt.Text, contentTxt.Text);
            module.UpdateOrAdd(editedNote);

            //Quick and dirty way of adding the note to the combo box :P
            new NoteForm(parent, module).Show(); // Show the updated form
            Dispose(true); // Dispose of this form
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            Dispose(true);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            Dispose(true);
        }
    }
}
