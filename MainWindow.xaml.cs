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
        FileConverter converter = new FileConverter();

        public MainWindow()
        {
            InitializeComponent();

            basicGrid.DataContext = converter;
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            converter.FindFile();
            
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            converter.ConvertFile();
        }

     }
}
