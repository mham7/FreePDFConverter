using System.Text;
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

//to work with word documents
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;

//to read convert and work with PDF files
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;

//for our theme
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.FluentLight.WPF;

//to start a proccess we need the diagnostics namespace
using System.Diagnostics;

//to work with images
using System.Drawing;

//to save and read files
using System.IO;
using System.Windows;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace WarehouseManagement
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




        private string selectedFilePath;

        private void SelectFolder(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents (*.docx)|*.doc|All Files (*.*)|*.*";
            bool? result = openFileDialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"Selected Folder: {selectedFilePath}");

            }
        }

        private void ConvertButton(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a Word document to convert.");
                return;
            }

        
        }
    }
}