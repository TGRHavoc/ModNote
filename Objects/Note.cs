using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModNote.Objects
{
    /// <summary>
    /// Class that represents a note for a module
    /// </summary>
    public class Note
    {
        string _note;
        string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Content
        {
            get { return _note; }
            set { _note = value; }
        }

        public Note(string title, string note)
        {
            this._note = note;
            this._title = title;
        }

    }
}
