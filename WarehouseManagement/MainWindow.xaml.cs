using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Aspose.Words;
using Microsoft.Win32;


namespace WarehouseManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedFilePath;
        public MainWindow()
        {
            InitializeComponent();
        }




      

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

            // Load the Word document
            Aspose.Words.Document doc = new Aspose.Words.Document(selectedFilePath);

            try
            {
                // Open a SaveFileDialog to allow the user to select the location and name of the converted PDF file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == true)
                {
                    // Get the selected file path
                    string outputFilePath = saveFileDialog.FileName;

                    // Save the document to PDF format
                    doc.Save(outputFilePath, SaveFormat.Pdf);

                    MessageBox.Show("Document converted and saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting document: {ex.Message}");
            }
        }

    }
}