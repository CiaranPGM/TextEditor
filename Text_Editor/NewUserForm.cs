using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    public partial class NewUserForm : Form
    {
        private List<string[]> users = new List<string[]>();
        private string loginFilePath;

        public NewUserForm(List<string[]> users, string loginFilePath)
        {
            InitializeComponent();
            this.users = users;
            this.loginFilePath = loginFilePath;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UnTextbox.Text;
            string password = PwTextbox.Text;
            string firstName = FNTextbox.Text;
            string lastName = LNTextbox.Text;
            string dob = DOBBox.Text;
            string userType = UTComboBox.Text;
            string[] newUser = { username, password, userType, firstName, lastName, dob}; 

            this.Close();

            //Adds new user to the list and writes them to the login.txt file
            users.Add(newUser);
            using (StreamWriter writer = File.CreateText(loginFilePath))
            {
                foreach (string[] element in users)
                {
                    foreach (string i in element)
                    {
                        if(i != element.Last<string>())
                        {
                            writer.Write(i + ",");
                        }
                        else { writer.WriteLine(i); }
                    }
                }
            }

            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
