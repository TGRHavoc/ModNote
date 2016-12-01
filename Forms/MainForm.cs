using ModNote.Forms;
using ModNote.Objects;
using ModNote.Utils;

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ModNote
{
    public partial class MainForm : Form
    {
        List<Module> loadedModules = new List<Module>();

        public MainForm()
        {
            InitializeComponent();

            folderBrowserDialog1.SelectedPath = Path.Combine(Directory.GetCurrentDirectory(), "modules");
            loadModuleTxt.Text = folderBrowserDialog1.SelectedPath;

            loadModules();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                loadModules();
            }
        }

        private void loadModules()
        {
            if (Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                loadedModules.Clear();
                moduleList.Items.Clear();

                loadModuleTxt.Text = folderBrowserDialog1.SelectedPath;

                foreach (string file in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
                {
                    Module m = Parser.ParseFile(file);
                    if (m != null)
                        addModule(m);
                }

                Console.WriteLine("Loaded " + loadedModules.Count + " modules!");

                sortModuleListByAssignments();
            }
        }

        private void addModule(Module m)
        {
            loadedModules.Add(m);
            moduleList.Items.Add(m.Code + " - " + m.Title);
        }

        private void saveModule(Module m)
        {
            foreach(Module module in loadedModules)
            {
                if (module.Code == m.Code) // Module already exists, override it
                {
                    Console.WriteLine("Overriden module");
                    module.Override(m); //We've change the modules' data. We can safely return
                    return;
                }
                else
                    continue;
            }

            Console.WriteLine("Added a new module");
            //Module not found in list
            //Add it!
            addModule(m);
        }

        //When user double clicks a module, assume they want to edit it
        private void moduleList_DoubleClick(object sender, EventArgs e)
        {
            this.Hide(); //Hide this form
            new ModuleForm(this, saveModule, loadedModules[moduleList.SelectedIndex]).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parser.SaveAll(folderBrowserDialog1.SelectedPath, loadedModules.ToArray());
        }
        private void editModBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide this form
            new ModuleForm(this, saveModule, loadedModules[moduleList.SelectedIndex]).Show();
        }

        private void newModBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModuleForm(this, saveModule).Show();
        }

        private void remModBtn_Click(object sender, EventArgs e)
        {
            Module tmp = loadedModules[moduleList.SelectedIndex];
            loadedModules.Remove(tmp);
            moduleList.Items.RemoveAt(moduleList.SelectedIndex);

            //Delete the file
            File.Delete(Path.Combine(folderBrowserDialog1.SelectedPath, tmp.Code + ".txt"));
        }


        private void sortModuleListByAssignments()
        {
            List<Module> tmp = new List<Module>();
            tmp.AddRange(loadedModules);
            //Let's do a bubble sort... Because we're not bothered about speed and/or efficiency!

            int changed = 0;

            do
            {
                changed = 0;
                // tmp.Count = x;
                // x-1 = "last" element in bubble (because of the x+1)
                for(int i = 0; i < tmp.Count - 1; i++)
                {
                    Module m1 = tmp[i];
                    Module m2 = tmp[i + 1];
                    Console.WriteLine("Comparing two modules: " + m2.SigDate.CompareTo(m1.SigDate));
                    if (m2.SigDate.CompareTo(m1.SigDate) > 0)
                    {
                        tmp[i] = m2;
                        tmp[i + 1] = m1;
                        changed++;
                        Console.WriteLine("Swapped " + m1.Code + " with " + m2.Code);
                    }
                }
            } while (changed != 0);

            Console.WriteLine("Sorted!");

            //Now we put the sorted list into the list box
            moduleList.Items.Clear();
            loadedModules.Clear();

            foreach (Module m in tmp)
                addModule(m);
        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            new NoteForm(this, loadedModules[moduleList.SelectedIndex]).Show();
            Hide();
        }
    }
}
