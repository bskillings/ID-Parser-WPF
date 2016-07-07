using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;



namespace IDParserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private FileConverter converter = new FileConverter();

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            string inputFile = converter.FindFile();
            inputFilenameTextbox.Text = inputFile;
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string messageText = converter.ConvertFile(inputFilenameTextbox.Text, outputFilenameTextbox.Text);
            messageBlock.Text = messageText;
        }

    }
}
