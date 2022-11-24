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
    public partial class CompetitionResults : Form
    {
        public CompetitionResults()
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
            string query = "INSERT INTO CompetiotionResults (`Date`, Location, Results) VALUES ('"+textBox1.Text+"', '"+textBox3.Text+"','"+textBox2.Text+"')";
            con.Open();
            var cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have successfully Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.LoadDataGrid(AllCompetionResults, "CompetiotionResults");
        }

        private void CompetitionResults_Load(object sender, EventArgs e)
        {
            Connection.LoadDataGrid(AllCompetionResults, "CompetiotionResults");
        }
    }
}
