using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfCourse
{
    public partial class Golfers : Form
    {
        public Golfers()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Connection.connectionString);

        private void Back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Golfers(Name, PhoneNumber, Email, Address)VALUES ('"+textBox1.Text+"','"+textBox4.Text+"','"+textBox3.Text+"', '"+textBox2.Text+"')";
            var cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Succesfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.LoadDataGrid(AllGolfers, "Golfers");
        }

        private void Golfers_Load(object sender, EventArgs e)
        {
            Connection.LoadDataGrid(AllGolfers, "Golfers");
        }

       
    }
}
