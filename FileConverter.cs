using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;



namespace IDParserWPF
{
    public class FileConverter: INotifyPropertyChanged
    {
     
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; } = "Output.txt";
        public string Message { get; set; } = "";

        public event PropertyChangedEventHandler PropertyChanged;

        public void FindFile()
        {
            var openDialog = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".txt"
            };

            bool? result = openDialog.ShowDialog();

            if (result == true)
            {
                InputFileName = openDialog.FileName;
                OnPropertyChanged("InputFileName");
   
            }
        }
 

        public void ConvertFile()
        {
            const string textMarker = "|11=";
            var random = new Random();
            
            //Check if file exists
            if (!File.Exists(InputFileName))
            {
                Console.WriteLine(InputFileName + " does not exist");
                return;
            }

            //check if file is empty
            if (new FileInfo(InputFileName).Length == 0)
            {
                Console.WriteLine(InputFileName + " is empty");
                return;
            }


            //main functionality starts here 
            using (var reader = new StreamReader(InputFileName))
            using (var writer = new StreamWriter(OutputFileName))
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
            Message = "Done";
            OnPropertyChanged("Message");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
