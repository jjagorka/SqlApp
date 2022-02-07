using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.userPass.AutoSize = false;
            this.userPass.Size = new Size(this.userPass.Size.Width, 49);
            userName.Text = "Enter your name";
            userSurname.Text = "Enter your last name";
            userLogin.Text = "Login";
            this.userPass.UseSystemPasswordChar = false;
            userPass.Text = "Password";

        }


        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Enter your name")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }    
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Enter your name";
                userName.ForeColor = Color.Gray;

            }
                
        }

        private void userSurname_Enter(object sender, EventArgs e)
        {
            if (userSurname.Text == "Enter your last name")
            {
                userSurname.Text = "";
                userSurname.ForeColor = Color.Black;
            }
        }

        private void userSurname_Leave(object sender, EventArgs e)
        {
            if (userSurname.Text == "")
            {
                userSurname.Text = "Enter your last name";
                userSurname.ForeColor = Color.Gray;

            }
        }

        private void userLogin_Enter(object sender, EventArgs e)
        {
            if (userLogin.Text == "Login")
            {
                userLogin.Text = "";
                userLogin.ForeColor = Color.Black;
            }
        }

        private void userLogin_Leave(object sender, EventArgs e)
        {
            if (userLogin.Text == "")
            {
                userLogin.Text = "Login";
                userLogin.ForeColor = Color.Gray;
            }
        }

        private void userPass_Enter(object sender, EventArgs e)
        {
            this.userPass.UseSystemPasswordChar = true;
            if (userPass.Text == "Password")
            {
                userPass.Text = "";
                userPass.ForeColor = Color.Black;
            }
        }

        private void userPass_Leave(object sender, EventArgs e)
        {
            if (userPass.Text == "")
            {
                this.userPass.UseSystemPasswordChar = false;
                userPass.Text = "Password";
                userPass.ForeColor = Color.Gray;
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {

            if (userLogin.Text == "Login" | userName.Text == "Enter your name" | userSurname.Text == "Enter your last name" | userPass.Text == "Password")
            {
                MessageBox.Show("Fill in all the data");
                return;

            }

            if (IsUserExists())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)",db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userPass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurname.Text;

            db.openConnections();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Accoont created!");
            else
                MessageBox.Show("Account not created!");

            db.closeConnections();
        }

        public Boolean IsUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists");
                return true;
            }
            else
                return false;
        }

        private void Sign_in_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
