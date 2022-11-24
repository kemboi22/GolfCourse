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
    public partial class GolfEquipments : Form
    {
        public GolfEquipments()
        {
            InitializeComponent();
        }

        private OleDbConnection con = new OleDbConnection(Connection.connectionString);
        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO GolfEquipments (GolfBalls, GolfClubs, GolfTees) VALUES ('"+GolfBalls.Text+"','"+GolfClubs.Text+"','"+GolfTees.Text+"')";
            var cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Successfully Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.LoadDataGrid(AllGolfEquipments, "GolfEquipments");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void GolfEquipments_Load(object sender, EventArgs e)
        {
            Connection.LoadDataGrid(AllGolfEquipments, "GolfEquipments");
        }
    }
}
