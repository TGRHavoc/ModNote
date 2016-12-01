using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModNote.Utils
{
    /// <summary>
    /// Helper class to allow "peaking" of the next line in a file without consuming said line
    /// </summary>
    public class PeakedStreamReader : StreamReader
    {
        private Queue<string> _peeks;
        public PeakedStreamReader(Stream stream) : base(stream)
        {
            _peeks = new Queue<string>();
        }
        public override string ReadLine()
        {
            if (_peeks.Count > 0)
            {
                var nextLine = _peeks.Dequeue();
                return nextLine;
            }
            return base.ReadLine();
        }

        public string PeekReadLine()
        {
            var nextLine = ReadLine();
            _peeks.Enqueue(nextLine);
            return nextLine;
        }

    }
}
