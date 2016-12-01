using System;
using System.IO;
using ModNote.Objects;
using System.Text;

namespace ModNote.Utils
{
    /// <summary>
    /// Parser for loading modules to/from files
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// Try an parse a file into a module object
        /// </summary>
        /// 
        /// <param name="file">The file to try and parse</param>
        /// <returns>A module that the file represents, new module if parsing failes and null if file isn't a txt file.</returns>
        public static Module ParseFile(string file)
        {
            Module parsedModule = new Module(); // Our module obj

            int loSize = 0, assSize =0, notesSize = 0; //Sizes of the arrays (used for determining whether module needs saving)

            FileInfo fi = new FileInfo(file); //The file info.. Just need to double check it's a txt file
            if (fi.Extension != ".txt") // Make sure it's a txt file
                return null; // If not, return nothing

            using (PeakedStreamReader reader = new PeakedStreamReader(File.Open(file, FileMode.Open)))
            { // Open the file for reading
                string line = null; //the current line
                while ((line = reader.ReadLine()) != null) //Whilst we're not at the end
                {
                    line = line.Trim(); // Get rid of them pesky whitespaces!

                    if (line == "CODE")
                    {
                        //Next line is the code
                        parsedModule.Code = reader.ReadLine();
                    }
                    if (line == "TITLE")
                    {
                        parsedModule.Title = reader.ReadLine();
                    }
                    if(line == "SYNOPSIS")
                    {
                        parsedModule.Synopsis = reader.ReadLine();
                    }
                    if (line == "LO")
                    {
                        //We have an array now...
                        string nextLine = null;
                        while ((nextLine = reader.PeekReadLine()) != "ASSIGNMENT")
                        {
                            if (nextLine == null || string.IsNullOrEmpty(nextLine))
                                break;
                            Console.WriteLine("Added LO: " + nextLine);
                            parsedModule.AddLearningOutcome(reader.ReadLine()); //Add the read learning outcome
                            loSize++;
                            //We've just read this line via peek
                        }
                    }
                    //Console.WriteLine("Line: " + line + " : " + (line == null));
                    if (line == "ASSIGNMENT")
                    {
                        string nextLine = null;
                        while ((nextLine = reader.PeekReadLine()) != "NOTE")
                        {
                            Console.WriteLine("nextLine: " + nextLine);
                            if (nextLine == null || string.IsNullOrEmpty(nextLine))
                                break;

                            nextLine = reader.ReadLine();
                            string[] objs = nextLine.Split('\t');
                            Assignment assignment = new Assignment(objs[0], objs[1]);
                            parsedModule.AddAssignment(assignment);
                            assSize++;
                            Console.WriteLine("Adding assignment: " + nextLine);
                        }
                    }
                    if (line == "NOTE")
                    {

                        string nextLine = null;
                        while ((nextLine = reader.PeekReadLine()) != null)
                        {
                            // First readLine() = title
                            // Second readLine() = content
                            string title = reader.ReadLine();
                            string encodedContent = reader.ReadLine();
                            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(encodedContent))
                                continue;

                            Note note = new Note(title, decode(encodedContent));
                            parsedModule.AddNote(note);
                            notesSize++;
                        }
                    }

                }
            }

            parsedModule.AssignmentsSize = assSize;
            parsedModule.NotesSize = notesSize;
            parsedModule.LearningOutcomesSize = loSize;
            Console.WriteLine("Finished parsing");
            return parsedModule;
        }

        /// <summary>
        /// Save all modules in the given array to their corrisponding files.
        /// (File is saved as "{Module.Code}.txt")
        /// </summary>
        /// 
        /// <param name="directory">Directory to save the modules in</param>
        /// <param name="modules">An aray of modules to save</param>
        public static void SaveAll(string directory, Module[] modules)
        {
            foreach(Module module in modules)
            {
                if (!module.Save) //If no changes have been made
                    continue; //Don't need to save it
                
                string filename = Path.Combine(directory, module.Code + ".txt");
                Console.WriteLine("Saving: " + module.Code + " :: " + filename);
                using (StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Create)))
                {
                    sw.WriteLine(ParseToString(module)); //Write the module to the file
                }
            }
        }

        /// <summary>
        /// Transforms the given module to a string to allow file saving.
        /// </summary>
        /// 
        /// <param name="toParse">The module to parse to string</param>
        /// <returns>A string representation of the module that can be saved directly to a file</returns>
        private static string ParseToString(Module toParse)
        {
            StringBuilder builder = new StringBuilder();
            //TODO: Turn the module object into a string for saving in a file
            builder.Append("CODE\r\n");
            builder.Append(toParse.Code);
            builder.Append("\r\nTITLE\r\n");
            builder.Append(toParse.Title);
            builder.Append("\r\nSYNOPSIS\r\n");
            builder.Append(toParse.Synopsis);

            builder.Append("\r\nLO\r\n");
            foreach (string lo in toParse.LearningOutcomes)
                builder.Append(lo + "\r\n");

            builder.Append("ASSIGNMENT\r\n");
            foreach (Assignment assignment in toParse.Assignments)
                builder.Append(assignment.ToString() + "\r\n");

            builder.Append("NOTE\r\n");
            foreach (Note note in toParse.Notes)
                builder.Append(note.Title + "\r\n" + encode(note.Content) + "\r\n");

            return builder.ToString();
        }

        private static string encode(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainBytes);
        }

        private static string decode(string base64)
        {
            byte[] encodedBytes = Convert.FromBase64String(base64);
            return Encoding.UTF8.GetString(encodedBytes);
        }

    }
}
