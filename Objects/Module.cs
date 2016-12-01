using System;
using System.Collections.Generic;

namespace ModNote.Objects
{
    /// <summary>
    /// Class that represents the modules
    /// </summary>
    public class Module
    {
        #region Private variables

        string _code; // The modules' code
        string _title; // The title of the module
        string _synopsis; // A brief synopsis

        List<string> _learningOutcomes = new List<string>(); // The learning outcomes
        List<Assignment> _assignments = new List<Assignment>(); // The assignments
        List<Note> _notes = new List<Note>(); // The notes

        // The sizes of the arrays (used for checking if the module has been modified)
        int _loSize = -1,
            _assSize = -1,
            _noteSize = -1;

        bool changed = true; // Whether or not the module has been changed since it was loaded

        #endregion

        #region Public properties

        public bool Save
        {
            get { return changed; }
        }

        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != null)
                    changed = true;
                _code = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != null)
                    changed = true;
                _title = value;
            }
        }

        public string Synopsis
        {
            get { return _synopsis; }
            set
            {
                if (_synopsis != null)
                    changed = true;    
                _synopsis = value;
            }
        }

        public int LearningOutcomesSize
        {
            get { return _loSize; }
            set { _loSize = value; }
        }
        public int AssignmentsSize
        {
            get { return _assSize; }
            set { _assSize = value; }
        }
        public int NotesSize
        {
            get { return _noteSize; }
            set { _noteSize = value; }
        }

        public string[] LearningOutcomes
        {
            get { return _learningOutcomes.ToArray(); }
        }

        public Assignment[] Assignments
        {
            get { return _assignments.ToArray(); }
        }

        public Note[] Notes
        {
            get { return _notes.ToArray(); }
        }

        public DateTime SigDate
        {
            get
            {
                Assignment closest = null;

                foreach(Assignment assignment in _assignments)
                {
                    //Console.WriteLine(assignment.Date + " : " + closest + " => " + assignment.Date.CompareTo(closest.Date));
                    if (closest != null)
                    {
                        if (assignment.Date.CompareTo(closest.Date) > 0)
                            closest = assignment;
                    }
                    else
                    { //Closest is null... Might as well set it
                        closest = assignment;
                    }

                }

                return closest.Date;
            }
        }

        #endregion

        public void AddLearningOutcome(string outcome)
        {
            _learningOutcomes.Add(outcome);

            if (_loSize != -1 && _loSize != _learningOutcomes.Count) //If it's not the default value AND arr isn't right size
                changed = true; //We have changes to save
        }
        public void AddAssignment(Assignment assignment)
        {
            _assignments.Add(assignment);

            if (_assSize != -1 && _assSize != _assignments.Count)
                changed = true;
        }
        public void AddNote(Note note)
        {
            _notes.Add(note);

            if (_noteSize != -1 && _noteSize != _notes.Count)
                changed = true;
        }

        public void RemoveLearningOutcome(string learningOutcome)
        {
            Console.WriteLine("Removing lo: " + learningOutcome);
            _learningOutcomes.Remove(learningOutcome);
        }

        public void RemoveAssignment(Assignment assignment)
        {
            Console.WriteLine("Removing assignment: " + assignment.ToString());
            _assignments.Remove(assignment);
        }

        public void RemoveNote(Note note)
        {
            Console.WriteLine("Removing note: " + note.ToString());
            _notes.Remove(note);
        }

        public void UpdateOrAdd(Note note)
        {
            changed = true;

            foreach (Note n in _notes)
            {
                if (n.Title == note.Title)
                {
                    n.Content = note.Content;
                    return;
                }
            }

            _notes.Add(note);
        }

        public void Override(Module module)
        {
            this._title = module._title;
            this._synopsis = module._synopsis;

            this._assignments = module._assignments;
            this._assSize = module._assSize;

            this._learningOutcomes = module._learningOutcomes;
            this._loSize = module._loSize;

            this._notes = module._notes;
            this._noteSize = module._noteSize;

            Console.WriteLine("Changed stuff: " + _synopsis);

            this.changed = true;
        }

        public Module()
        {
            changed = true; // It's a new module... Make sure it gets saved 
        }


    }
}
