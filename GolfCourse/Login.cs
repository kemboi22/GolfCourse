using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GolfCourse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Connection.connectionString);
        OleDbCommand cmd = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM login WHERE email = '"+Email.Text.ToString()+"' AND password= '"+Password.Text.ToString()+"' ";
            cmd = new OleDbCommand(login, con);
            cmd.ExecuteNonQuery();
            Email.Text = "";
            Password.Text = "";
            con.Close();
            new Dashboard().Show();
            this.Hide();

        }
    }
}