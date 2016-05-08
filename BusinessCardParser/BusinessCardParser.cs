using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardParser
{
    /// <summary>
    /// BusinessCardParser class that implements IBusinessCardParser
    /// </summary>
    public class BusinessCardParser : IBusinessCardParser
    {
        public string Name;
        public string PhoneNumber;
        public string EmailAddress;

        /// <summary>
        /// Get a person's contact information from a document of text that represents the text from a business card 
        /// as scanned from an optical image recognition application
        /// </summary>
        /// <param name="document">The text containing the contact information</param>
        /// <returns>IContactInfo with the name, phone number and email address in the document</returns>
        public IContactInfo GetContactInfo(string document)
        {
            ContactInfo contactInfo = new ContactInfo();
            contactInfo.Document = document;
            Name = contactInfo.GetName();
            PhoneNumber = contactInfo.GetPhoneNumber();
            EmailAddress = contactInfo.GetEmailAddress();

            return contactInfo;
        }   
    }
} 