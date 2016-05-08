using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCardParser
{
    /// <summary>
    /// Form for the BusinessCardParser application
    /// </summary>
    public partial class BusinessCardParserForm : Form
    {
        /// <summary>
        /// Initializes the BusinessCardParser form
        /// </summary>
        public BusinessCardParserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the business card parser form and populates with data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Display input information from the app.config to the user
            inputFileFolderText.Text = ConfigurationManager.AppSettings["InputFileFolder"];
            inputFileFolderText.Refresh();
            inputFileExtensionText.Text = ConfigurationManager.AppSettings["InputFileExt"];
            inputFileExtensionText.Refresh();

            BusinessCardParser parser = new BusinessCardParser();

            // Get input file absolute paths in a list
            List<string> inputFiles =
                Utility.GetFilePathsWithExtensionIntoListFromDirectory(
                    ConfigurationManager.AppSettings["InputFileFolder"], ConfigurationManager.AppSettings["InputFileExt"]);

            // Parse each input file and output to the form
            foreach (string file in inputFiles)
            {
                parser.GetContactInfo(File.ReadAllText(file));
                parsedResultsTextBox.Text += Path.GetFileNameWithoutExtension(file) + @":" + Environment.NewLine + Environment.NewLine;
                parsedResultsTextBox.Text += File.ReadAllText(file) + Environment.NewLine + Environment.NewLine;
                parsedResultsTextBox.Text += @"==>" + Environment.NewLine + Environment.NewLine;
                string name = parser.Name;
                string phoneNumber = parser.PhoneNumber;
                string emailAddress = parser.EmailAddress;
                parsedResultsTextBox.Text += @"Name: " + name + Environment.NewLine;
                parsedResultsTextBox.Text += @"Phone: " + phoneNumber + Environment.NewLine;
                parsedResultsTextBox.Text += @"Email: " + emailAddress + Environment.NewLine + Environment.NewLine;
            }
            parsedResultsTextBox.Refresh();
        }
    }
}
