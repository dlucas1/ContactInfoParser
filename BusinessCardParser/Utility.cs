using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardParser
{
    /// <summary>
    /// Contains helpful methods for the business card parser application
    /// </summary>
    public static class Utility
    {
        public static List<string> List = GetFileIntoList(ConfigurationManager.AppSettings["NamesList"]); 
        /// <summary>
        /// Looks in a directory path and puts all files with the provided extension into a list of strings
        /// </summary>
        /// <param name="directory">Location to look for the files</param>
        /// <param name="extension">Can be 'txt', 'xlsx', etc</param>
        /// <returns>List of strings</returns>
        public static List<string> GetFilePathsWithExtensionIntoListFromDirectory(string directory, string extension)
        {
            List<string> filePaths = new List<string>();

            foreach (string file in Directory.GetFiles(directory))
            {
                if (Path.HasExtension(extension))
                {
                    filePaths.Add(file);
                }
            }

            return filePaths;
        } 

        /// <summary>
        /// Uses a file as input and returns a list of strings
        /// </summary>
        /// <param name="file">The file to use as input</param>
        /// <returns>A list of strings</returns>
        public static List<string> GetFileIntoList(string file)
        {
            var logFile = File.ReadAllLines(file);
            List<string> list = new List<string>(logFile);
            return list;
        }

        /// <summary>
        /// Determines if a list contains the given text
        /// </summary>
        /// <param name="list">The list to use for comparison</param>
        /// <param name="text">The text to find in the list</param>
        /// <returns>true if text is found; false if not</returns>
        public static bool ListContainsText(List<string> list, string text)
        {
            if (list.Contains(text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes special characters from a string of text
        /// </summary>
        /// <param name="str">The string to use</param>
        /// <returns>The string without special characters</returns>
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}