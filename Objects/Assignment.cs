using System;

namespace ModNote.Objects
{
    /// <summary>
    /// Class that represents the assignments for modules
    /// </summary>
    public class Assignment
    {
        string _type; //Type of the assignment (Assignment or In-Class Test)
        bool _weekCommencing = false; // Whether the assignment is due the week commencing the date or the actual date
        DateTime _date; // The date the assignment is due

        /// <summary>
        /// Type of assignment
        /// Examples:
        ///     Assignment,
        ///     In-Class Test
        ///
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Whether or not the due date for the assignment is the week commencing the date provided
        /// </summary>
        public bool WeekCommencing
        {
            get { return _weekCommencing; }
            set { _weekCommencing = value; }
        }

        /// <summary>
        /// The due date
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// A formatted string for use in ListBox to display the assignment
        /// </summary>
        public string FormString
        {
            get
            {
                return string.Format("{0}   {1}{2}   {3}", 
                    _type, 
                    _weekCommencing ? "w/c " : "",
                    _date.ToShortDateString(),
                    _date.CompareTo(DateTime.Now) < 0 ? "Deadline Passed" : "");
            }
        }

        /// <summary>
        /// Assignment constructor for raw string in file.
        /// The constructor automatically transforms the date (e.g. w/c 07/04/2016) into the proper DateTime object
        /// </summary>
        /// <param name="type">The type of assignment</param>
        /// <param name="date">The due date for the assignment (pre-appended with w/c)</param>
        public Assignment (string type, string date)
        {
            this._type = type;

            string[] dateObj = date.Split(' ');
            if (dateObj.Length == 2)
            {
                _weekCommencing = true;
                _date = DateTime.Parse(dateObj[1]);
            }
            else
            {
                _date = DateTime.Parse(date);
            }
        }

        public Assignment()
        {
        }

        /// <summary>
        /// A formatted string to represent the assignment in a file
        /// </summary>
        /// 
        /// <returns>A formatted string for saving in file</returns>
        public override string ToString()
        {
            return string.Format("{0}\t{1}{2}", _type, _weekCommencing ? "w/c " : "", _date.ToShortDateString());
        }

    }
}
