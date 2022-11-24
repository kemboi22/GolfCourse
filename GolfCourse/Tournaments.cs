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
    public partial class Tournaments : Form
    {
        public Tournaments()
        {
            InitializeComponent();
        }

        private OleDbConnection con = new OleDbConnection(Connection.connectionString);

        private void Back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO UpcomingTournaments (`Date`, Location, EntryFee, PrizeMoney) VALUES ('"+Date.Text+"','"+Location.Text+"', '"+EntryFee.Text+"', '"+PrizeMoney.Text+"')";
            con.Open();
            var cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.LoadDataGrid(dataGridView1, "UpcomingTournaments");
        }

        private void Tournaments_Load(object sender, EventArgs e)
        {
            Connection.LoadDataGrid(dataGridView1, "UpcomingTournaments");
        }
    }
}
