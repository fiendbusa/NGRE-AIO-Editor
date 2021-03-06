﻿using System;
using NGRE_Save_Editor.Save_Files;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;


namespace NGRE_Save_Editor.Save_File
{
    static class SaveFile
    {
        public static string ChapterSave { get; set; }
        public static string StorySave { get; set; }
        public static string SystemSave { get; set; }

        public static void writeHex(Save save, long[] offsets, byte[] hex)
        {
            try
            {
                //if (offsets.Length != hex.Length || hex.Length != offsets.Length) MessageBox.Show("The length of the Offset and Hex must be parallel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

                string path;

                //set the path of the save file
                switch(save)
                {
                    case Save.Chapter:
                        path = ChapterSave;
                        break;
                    case Save.Story:
                        path = StorySave;
                        break;
                    case Save.System:
                        path = SystemSave;
                        break;
                    default:
                        path = "";
                        break;
                }

                if (String.IsNullOrEmpty(path))
                {
                    MessageBox.Show(save.ToString() + " path is invalid");
                    return;
                }

                using (FileStream saveStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    //Writes hexadecimal value to offset position 1:1 (hex[1] writes to offset[1], hex[2] writes to offset[2] etc...
                    for (int i = 0; i < offsets.Length; i++)
                    {
                        saveStream.Seek(offsets[i], SeekOrigin.Begin);
                        saveStream.WriteByte(hex[i]);
                        Debug.WriteLine("Wrote at: " + offsets[i] + "\n" + "value written: " + hex[i]);
                        
                    }
                    
                    
                }
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                MessageBox.Show(fileNotFoundEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Stores the path of the save file to local properties
        public static void savePath(Save type)
        {
            using (OpenFileDialog opnFileDialog = new OpenFileDialog())
            {
                opnFileDialog.ShowDialog();
                string filePath = opnFileDialog.FileName;
                switch (type)
                {
                    case Save.System:
                        SystemSave = filePath;
                        break;
                    case Save.Story:
                        StorySave = filePath;
                        break;
                    case Save.Chapter:
                        ChapterSave = filePath;
                        break;
                }
            }
        }
        //Fail safe to check if the correct save file is selected.
        public static void saveFileTypeCheck(Save type, string fileName)
        {
            string save;
            string defaultMessage = "Incorrect save file detected. Are you sure you want to use this file?";
            DialogResult option;
            switch (type)
            {
                case Save.System:
                    if (!fileName.Contains("SAVE.SYS.DAT"))
                    {

                        option = MessageBox.Show(defaultMessage, "Error", MessageBoxButtons.YesNo);
                    }
                    

                    break;
            }
        }
    }
}



 