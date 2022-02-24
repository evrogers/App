using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormEnter : Form
    {
        MainForm mainForm = new MainForm();
        private string password = "12345";
        public static bool isAdmin;


        public FormEnter()
        {
            InitializeComponent();

        }

        private void adminModeButton_Click(object sender, EventArgs e)
        {
            panelGuest.Hide();
            panelAdmin.Show();
            label1.Show();
        }

        private void guestModeButton_Click(object sender, EventArgs e)
        {
            panelAdmin.Hide();
            panelGuest.Show();
            adminPassword.Text = "";
            showPic_Click(showPic, e);
        }

        private void guestEnterButton_Click(object sender, EventArgs e)
        {
            isAdmin = false;
            this.Hide();
            mainForm.Show();
        }

        private void adminEnterButton_Click(object sender, EventArgs e)
        {
            if (adminPassword.Text == "") MessageBox.Show("Введите пароль!");
            else if (adminPassword.Text != password) MessageBox.Show("Неверный пароль!");
            else
            {
                isAdmin = true;
                this.Hide();
                mainForm.Show();
            }
        }

        private void hidePic_Click(object sender, EventArgs e)
        {
            hidePic.Hide();
            showPic.Show();
            adminPassword.UseSystemPasswordChar = false;
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            showPic.Hide();
            hidePic.Show();
            adminPassword.UseSystemPasswordChar = true;
        }

        private void adminPassword_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void adminPassword_Leave(object sender, EventArgs e)
        {
            if (adminPassword.Text == "") label1.Show();
        }

        private void FormEnter_Load(object sender, EventArgs e)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;

            if (resolution.Width < 1920 && resolution.Height < 1080)
            {
                adminEnterButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                guestEnterButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                adminModeButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                guestModeButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                adminPassword.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                adminPassword.Location = new Point(296, 259);
                label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                label1.Location = new Point(297, 259);
            }
        }

        private void FormEnter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelInfo.Hide();
            panelGuest.Show();
        }
    }
}
