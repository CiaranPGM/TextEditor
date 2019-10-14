using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Text_Editor
{
    public partial class LoginForm : Form
    {
        private string filePath = Directory.GetCurrentDirectory();
        private string loginFilePath;
        private List<string[]> users = new List<string[]>();

        public LoginForm()
        {
            InitializeComponent();

            //Grabs the login.txt file and writes all the lines into a list of string arrays
            loginFilePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\") + "login.txt");
            string[] lines = File.ReadAllLines(loginFilePath);
            foreach (string line in lines)
            {
                users.Add(line.Split(','));
            }

            //Stars out the password while typing
            PwTextbox.PasswordChar = '*';
            PwTextbox.MaxLength = 13;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UnTextbox.Text;
            string password = PwTextbox.Text;
            string[] last = users.Last<string[]>();

            foreach(string[] element in users)
            {
                if (element[0] == username && element[1] == password)
                {
                    this.Hide();
                    TextEditorForm te = new TextEditorForm(element);
                    te.Show();
                    break;
                }else if(element[0] == username && element[1] != password)
                {
                    MessageBox.Show("Incorrect Password");
                    break;
                }
                if(element == last)
                {
                    MessageBox.Show("Incorrect Credentials");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm nu = new NewUserForm(users, loginFilePath);
            nu.Show();
        }

        private void PwTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
