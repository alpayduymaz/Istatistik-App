using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegbisUygulaması
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }
        private bool passwordVisible = false;

        public string EnteredUsername { get; set; }
        public string EnteredPassword { get; set; }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            txtPassword.PasswordChar = passwordVisible ? '\0' : '*';
            btnShowPassword.Text = passwordVisible ? "🙈" : "👁";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnteredUsername = txtUsername.Text;
            EnteredPassword = txtPassword.Text;
            btnSave.Text = "Başarılı";
            Form1 mainForm = new Form1();
            mainForm.Show();

            this.Hide();
        }

    }
}
