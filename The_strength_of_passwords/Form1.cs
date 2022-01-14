using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_strength_of_passwords
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
            clbPassword.SetItemChecked(2, true);
            LoadNote();
            SaveNote();
            LoadPassword();
            rtbMainData.Text = rtbMainData.Text + getdata;
            SavePassword();
        }

        Random rnd;

        //Pssword create

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPasswordLength.Value; i++)

            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "The Numbers":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Lowercase letters":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Capital letters":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                }
                tbPassword.Text = password;
            }
            tbPassword.Text = password;
            Clipboard.SetText(password);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPassword.Text);
        }

        public string getdata;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.tbNewPassword.Text = tbPassword.Text;
            this.Hide();
            f2.Show();
        }

        //Menu

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsmAddDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmAddTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        //Notepad
        private void NotepadSave_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void NotepadClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear notepad?", "Clear?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                rtbNotepad.Text = "";
                SaveNote();
            }
        }

        private void SaveNote()
        {
            //string data = rtbNotepad.Text;
            //rtbTransformationNotepad.Text = StringToBinary(data);

            try
            {
                //rtbTransformationNotepad
                rtbNotepad.SaveFile("Notepad.xml");
            }
            catch
            {
                MessageBox.Show("Error saving file - Notepad.xml", "Error"); 
            }
        }

        private void LoadNote()
        {
            try
            {
                //rtbTransformationNotepad
                rtbNotepad.LoadFile("Notepad.xml"); 
            }
            catch
            {
                MessageBox.Show("Error loading file - Notepad.xml", "Error"); 
            }

            //string data = rtbTransformationNotepad.Text;
            //rtbNotepad.Text = BinaryToString(data);
        }

        //Save and Load

        public void SavePassword()
        {
            try
            {
                rtbMainData.SaveFile("backdoor.dll"); //Passwords
            }
            catch
            {
                MessageBox.Show("File save error!", "Error"); //Passwords
            }
        }

        public void LoadPassword()
        {
            try
            {
                rtbMainData.LoadFile("backdoor.dll"); //Passwords
            }
            catch
            {
                MessageBox.Show("Error loading file - backdoor.dll", "Error"); //Passwords
            }
        }

        //2 Button in Saved Passwords

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all saved passwords?", "Drop data?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                rtbMainData.Text = "";
                SavePassword();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SavePassword();
        }

        //Trash

        private void tcSavedPasswords_Click(object sender, EventArgs e){}

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.rtbFullScreen.Text = rtbMainData.Text;
            f3.Show();
        }

        //About

        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Lukhverchyk Serhii\n" + "Last update: 13.12.2021\nVersion: beta(0.2)", "About");
        }

        //encryption

        /*
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.UTF8.GetString(byteList.ToArray());
        }
        */
    }
}