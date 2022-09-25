using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PWGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.BurlyWood;
            Exit.BorderStyle = BorderStyle.FixedSingle;
            copyButton.Visible = false;
            passGenTextBox.Visible = false;
            createFolderButton.Visible = false;
            createFileButton.Visible = false;
            filenameTextBox.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Exit.ForeColor= Color.Orange;
            Exit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.BurlyWood;
            Exit.BorderStyle = BorderStyle.FixedSingle;
        }

        private void createFolderButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                createFolderButton.Text = dialog.FileName;
                string folderout = dialog.FileName;
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            string folderout = createFolderButton.Text;
            string fileout = filenameTextBox.Text;
            string pass = passGenTextBox.Text;
            var text = "Password: \n" +
                        "Testing";
            if (passGenTextBox.Text == null)
            {
                text = "Undefined. Please generate password before creating file.";
            }
            if (filenameTextBox.Text == "Filename")
            {
                text = pass + " | It is also recommended to change your filename.";
            }
            if (filenameTextBox.Text != "Filename")
            {
                text = "Password: " + pass;
            }
            if (filenameTextBox.Text != null)
            {
                text = "Password: " + pass;
            }
            FileStream fWrite = new FileStream(folderout + @"\" + fileout + ".txt",
                FileMode.Create, FileAccess.Write, FileShare.None);
            byte[] writeArr = Encoding.UTF8.GetBytes(text);
            fWrite.Write(writeArr, 0, text.Length);
            fWrite.Close();
        }


        static List<char> chars = new List<char>();
        static void addChars(ref List<char> chars)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                chars.Add(c);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                chars.Add(c);
            }
            for (char c = '!'; c <= '?'; c++)
            {
                chars.Add(c);
            }
            for (char c = '0'; c <= '9'; c++)
            {
                chars.Add(c);
            }
        }
        static string genPass(int length)
        {
            StringBuilder sb = new StringBuilder(); 
            Random rnd = new Random();
            int j = 0;

            while(j < length)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                j++;
            }
            return sb.ToString();   
        }
        private void genButton_Click(object sender, EventArgs e)
        {
            decimal lengthP = lengthPass.Value;
            int length = Convert.ToInt32(lengthP);
            string lengths = Convert.ToString(length);
            addChars(ref chars);
            if (int.TryParse(lengths, out length))
            {
                copyButton.Visible = true;
                passGenTextBox.Visible = true;
                passGenTextBox.Text = genPass(length);
            }
            
            
        }

        private void AdvSettingsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvSettingsToggle.Checked)
            {
                createFolderButton.Visible = true;
                createFileButton.Visible = true;
                filenameTextBox.Visible = true;
            }

            if(AdvSettingsToggle.Checked == false)
            {
                createFolderButton.Visible = false;
                createFileButton.Visible = false;
                filenameTextBox.Visible = false;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passGenTextBox.Text);
        }

        


    }
}
