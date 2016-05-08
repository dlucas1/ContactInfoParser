using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BusinessCardParser
{
    /// <summary>
    /// This application parses input for business cards that have been processed through an optical image recognition smartphone application.
    /// Results of the OCR application are available in an input folder as defined in the app.config file.
    /// This application reads each file in the app.config InputFileFolder of the extension specified in the app.config InputFileExtension. 
    /// The application then parses the content to find the name, phone number, and email address. 
    /// The parsed results are ouputted to the GUI textbox.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BusinessCardParserForm());
        }
    }

    /// <summary>
    /// Contains method signatures for the ContactInfo class
    /// </summary>
    public interface IContactInfo
    {
        /// <summary>
        /// returns the full name of the individual (eg. John Smith, Susan Malick)
        /// </summary>
        /// <returns></returns>
        String GetName();

        /// <summary>
        /// returns the phone number formatted as a sequence of digits with no punctuation
        /// </summary>
        /// <returns></returns>
        String GetPhoneNumber();

        /// <summary>
        /// returns the email address of the individual
        /// </summary>
        /// <returns></returns>
        String GetEmailAddress();
    }

    /// <summary>
    /// Contains method signatures for the BusinessCardParser interface
    /// </summary>
    interface IBusinessCardParser
    {
        IContactInfo GetContactInfo(String document);
    }
}