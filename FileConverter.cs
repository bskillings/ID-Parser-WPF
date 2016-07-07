using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;

namespace IDParserWPF
{
    public class FileConverter
    {
        public string FindFile()
        {
            var openDialog = new OpenFileDialog
            {
                DefaultExt = ".txt"
            };

            bool? result = openDialog.ShowDialog();

            if (result == true)
            {
                string inputName = openDialog.FileName;
                return inputName;

            }
            return "";
        }

        public string ConvertFile(string inputName, string outputName)
        {
            const string textMarker = "|11=";
            var random = new Random();
            
            //Check if file exists
            if (!File.Exists(inputName))
            {
                Console.WriteLine(inputName + " does not exist");
                return "";
            }

            //check if file is empty
            if (new FileInfo(inputName).Length == 0)
            {
                Console.WriteLine(inputName + " is empty");
                return "";
            }


            //main functionality starts here 
            using (var reader = new StreamReader(inputName))
            using (var writer = new StreamWriter(outputName))
            {
                while (!reader.EndOfStream)
                {
                    var lineComingIn = reader.ReadLine();
                    var lineGoingOut = lineComingIn;
                    if (lineComingIn != null && lineComingIn.Contains(textMarker))
                    {
                        var markerIndex = lineComingIn.IndexOf(textMarker, StringComparison.Ordinal) + textMarker.Length;
                        var counter = 0;
                        var endChar = ' ';
                        while (!endChar.Equals('|'))
                        {
                            counter++;
                            endChar = lineComingIn[markerIndex + counter];
                        }
                        var newNumber = random.Next();

                        var lineModifying = lineComingIn.Remove(markerIndex, counter);
                        lineGoingOut = lineModifying.Insert(markerIndex, newNumber.ToString());
                    }

                    writer.WriteLine(lineGoingOut);
                }
            }
            return " Done";
        }
    }
}
