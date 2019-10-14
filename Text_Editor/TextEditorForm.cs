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
    public partial class TextEditorForm : Form
    {
        private string[] currUser;
        private enum AccessType {View, Edit}
        private AccessType accessType;

        public TextEditorForm(string[] currUser)
        {
            InitializeComponent();
            this.currUser = currUser;
            Enum.TryParse(currUser[2], out accessType);
            if(accessType == AccessType.View)
            {
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;

                toolStripMenuItem1.Visible = false;
                toolStripMenuItem2.Visible = false;
                toolStripMenuItem3.Visible = false;
                toolStripMenuItem4.Visible = true;

                TextEditor.ReadOnly = true;
            }else if(accessType == AccessType.Edit)
            {
                toolStripMenuItem8.Visible = false;
            }
        }

        private void LogoutMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void LogoutButtonView_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
        
        private void StripMenu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            TextEditor.Text = sr.ReadToEnd();
        }
    }
}
