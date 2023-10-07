using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace downloader
{
    public class Dialog
    {
        public static string Open()
        {
            using var dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            dialog.ShowHiddenItems = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return "NoFilename";
        }
    }
}
