using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessCardParser
{
    /// <summary>
    /// Implements IContactInfo to obtain the name, phone number and email address of a business card contact
    /// </summary>
    internal class ContactInfo : IContactInfo
    {
        public string Document;
        public string Name;
        public string PhoneNumber;
        public string EmailAddress;

        /// <summary>
        /// Gets the name of a contact from a string of text containing business card contact info
        /// </summary>
        /// <returns>the name</returns>
        public string GetName()
        {
            Regex nameRegEx =
                new Regex(@"[A-Z]([a-z]+|\.)(?:\s+[A-Z]([a-z]+|\.))*(?:\s+[a-z][a-z\-]+){0,2}\s+[A-Z]([a-z]+|\.)");
            if (!string.IsNullOrEmpty(Document))
            {
                using (StringReader reader = new StringReader(Document))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Match nameMatch = nameRegEx.Match(line);
                        if (nameMatch.Success)
                        {
                            // Split nameMatch into separate words for comparison to names list
                            string[] words = nameMatch.ToString().Split(' ');
                            bool isMatch = false;

                            foreach (string word in words)
                            {
                                // If any word matches a name, set isMatch to true.
                                // TODO: handle scenario when company name uses a person's real name
                                if (Utility.ListContainsText(Utility.List, word.ToLower()))
                                {
                                    isMatch = true;
                                }
                            }

                            //Also check to see if name matches list of names
                            if (isMatch)
                            {
                                Name = nameMatch.Value;
                                return Name;
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Could not match with name. Name is empty or null.");
            }
            return Name;
        }

        /// <summary>
        /// Gets the phone number of a contact from a string of text containing business card info
        /// </summary>
        /// <returns>the phone number</returns>
        public string GetPhoneNumber()
        {
            Regex phoneRegEx =
                new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (!string.IsNullOrEmpty(Document))
            {
                using (StringReader reader = new StringReader(Document))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        bool containsFax = line.Contains("Fax");
                        if (!containsFax)
                        {
                            Match phoneMatch = phoneRegEx.Match(line);
                            if (phoneMatch.Success)
                            {
                                PhoneNumber = Utility.RemoveSpecialCharacters(phoneMatch.Value);
                                return PhoneNumber;
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                throw new Exception("Could not match with name. Name is empty or null.");
            }
            return PhoneNumber;
        }

        /// <summary>
        /// Gets the email address from a string of text containing business card info
        /// </summary>
        /// <returns>the email address</returns>
        public string GetEmailAddress()
        {
            Regex emailRegEx =
                new Regex(
                    @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                    RegexOptions.IgnoreCase);

            if (!string.IsNullOrEmpty(Document))
            {
                using (StringReader reader = new StringReader(Document))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Match emailMatch = emailRegEx.Match(line);
                        if (emailMatch.Success)
                        {
                            return emailMatch.Value;
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(EmailAddress))
            {
                throw new Exception("Could not match with name. Name is empty or null.");
            }
            return EmailAddress;
        }
    }
}