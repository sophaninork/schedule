using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Schedule.Views
{
    public partial class FormLoginPage : Form
    {
        public FormLoginPage()
        {
            InitializeComponent();
        }

        private void FormLoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void login_button(object sender, EventArgs e)
        {
            FormTeacherPage teacherForm = new FormTeacherPage();
            teacherForm.Show();
            this.Hide();
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
