﻿using Aspose.Words;
using System;
using System.IO;

namespace _06._01_InsertFormField
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for license and apply if exists
            string licenseFile = AppDomain.CurrentDomain.BaseDirectory + "Aspose.Words.lic";
            if (File.Exists(licenseFile))
            {
                // Apply Aspose.Words API License
                Aspose.Words.License license = new Aspose.Words.License();
                // Place license file in Bin/Debug/ Folder
                license.SetLicense("Aspose.Words.lic");
            }

            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Insert a drop down form field with three options.
            string[] items = { "One", "Two", "Three" };
            builder.InsertComboBox("DropDown", items, 0);

            doc.Save("FormFieldTest.docx");
        }
    }
}
