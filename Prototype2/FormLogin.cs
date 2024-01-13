using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototype2
{
    public partial class FormLogin : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Smart city\Prototype2\Login.mdf;Integrated Security=True;Connect Timeout=30;");

        public FormLogin()
        {
            InitializeComponent();
            panelLogin.Visible = true;
            panelRegistration.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                System.Drawing.Color[] backcolor = new System.Drawing.Color[4] { Color.LightSkyBlue, Color.LightCoral, Color.Blue, Color.LightCyan };
                con.Open();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from users_tbl where Username='" + txtUserName.Text + "' and Password= '" + txtPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        BackColor = backcolor[1];
                        this.Hide();
                        FormMain newForm = new FormMain();
                        newForm.Show();
                    }
                    else
                    {
                        this.BackColor = backcolor[3];
                        MessageBox.Show("Please, check youe username and password!");
                    }
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Fill all fields to login.");
            }

        } 
        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRegistration.Visible = false;
            panelLogin.Visible = true;
        }

        private void lblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegistration.Visible = true;
        }

       private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtReEnterP.Text && txtNewUserName.Text != "" && txtNewPassword.Text != "")
            {
                con.Open();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO users_tbl(Username, Email, Password) VALUES('" + txtNewUserName.Text + "', '" + txtEmail.Text + "', '" + txtNewPassword.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Congratulations! You have successfully registered.");

            }
            else
            {
                MessageBox.Show("Error! Rewrite the passwords and check if there are the same and fill all fields! ");
            }

        }


         //Close-Maximize-Minimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizer_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExitr_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Txt, Lbl effect
        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            if (lbl.Location.X==54)
            {
                lbl.Font = new Font("Century Gothic", 10);
                lbl.Cursor = Cursors.IBeam;
                lbl.Location = new Point(lbl.Location.X - 3, lbl.Location.Y - 140);
                foreach(Control txt in panelLogin.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void TextbBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
          
            
            foreach (Control ctrl in panelLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.MediumPurple;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.MediumPurple;
                    if (ctrl.Location.X != 51)
                    {
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 22);
                    }
                    

                }
            }
            
        }

        private void TextbBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelLogin.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 22);
                    }
                    

                }
            }

        }


        private void LabelEffectReg_Click(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            if (pic.Location.X == 54)
            {
                pic.Font = new Font("Century Gothic", 10);
                pic.Cursor = Cursors.IBeam;
                pic.Location = new Point(pic.Location.X - 3, pic.Location.Y - 140);
                foreach (Control txt in panelRegistration.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txt" + pic.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
        }


        private void TextbBoxReg_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelRegistration.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.MediumPurple;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.MediumPurple;
                    if (ctrl.Location.X != 51)
                    {
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X - 3, ctrl.Location.Y - 22);
                    }

                }
            }

        }

        private void TextbBoxReg_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in panelRegistration.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 3))
                {
                    ctrl.BackColor = Color.Lavender;
                }
                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 3))
                {
                    ctrl.ForeColor = Color.Lavender;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Century Gothic", 10);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X + 3, ctrl.Location.Y + 22);
                    }

                }
            }

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void checkbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtNewPassword.UseSystemPasswordChar = true;
                txtReEnterP.UseSystemPasswordChar = true;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtReEnterP.UseSystemPasswordChar = false;
            }
        }
    }

}
