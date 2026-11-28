using DVLDBusinessLayer;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD.Global_Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();
            return newGuid.ToString();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show($"Error creating folder: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);

                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {

            string DestinationFolder = @"C:\PeopleImages\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MaterialMessageBox.Show($"{iox.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        UseRichTextBox: false, buttonsPosition: MaterialFlexibleForm.ButtonsPosition.Center);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }

        public static void ShowError(MaterialTextBoxEdit box, bool hasError, string message = "")
        {
            box.SetErrorState(hasError);
            box.ShowAssistiveText = hasError;
            box.ErrorMessage = hasError ? message : "";
        }

        public static void ShowError(MaterialMaskedTextBox box, bool hasError, string message = "")
        {
            box.SetErrorState(hasError);
            box.ShowAssistiveText = hasError;
            box.ErrorMessage = hasError ? message : "";
        }
    }
}
