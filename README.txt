Hello! Thanks for reading me!

SUMMARY:

This application parses input for business cards that have been processed through an optical image recognition smartphone application.
Results of the OCR application are available in an input folder as defined in the app.config file.
This application reads each file in the app.config InputFileFolder of the extension specified in the app.config InputFileExtension. 
The application then parses the content to find the name, phone number, and email address. 
The parsed results are ouputted to the GUI textbox.

INSTRUCTIONS:

In order to run BusinessCardParser C# Windows Form Application, first, verify that the app.config is setup correctly by modifying it in Notepad/Notepad++.

Here is how the app.config is currently setup:

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="InputFileFolder" value="C:\Projects\BusinessCardParser\BusinessCardParser\Input"/>
    <add key="InputFileExt" value=".txt"/>
    <add key="NamesList" value="C:\Projects\BusinessCardParser\BusinessCardParser\NAMES.txt"/>
  </appSettings>
</configuration>

The "InputFileFolder" key is pointed to an Input folder that should contain Example1.txt, Example2.txt, and Example3.txt.
The "InputFileExt" key is already setup to use text files, so leave that parameter alone for now.
The "NamesList" is pointed to a file called NAMES.txt which is used by the application. Make sure that is pointed to the correct file location on your disk drive.

Once the app.config is setup, then depending on your operating system, use one of the following sets of instructions:

If running on a Windows machine, then...
1. Execute the BusinessCardParser.exe file located in \BusinessCardParser\BusinessCardParser\bin\Debug

If running on a Mac, then...
1. Download Mono from http://www.mono-project.com
2. Open the Mono terminal as described at http://www.mono-project.com/docs/about-mono/supported-platforms/osx/
3. Run the following command: mono BusinessCardParser.exe

If running on Linux, then...
1. Download Wine
2. Run the following command from the terminal:
$ wine BusinessCardParser.exe
For more detailed instructions, see https://www.winehq.org/docs/wineusr-guide/running-wine
