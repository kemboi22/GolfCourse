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
    public partial class CourseInformation : Form
    {
        public CourseInformation()
        {
            InitializeComponent();
        }

        private OleDbConnection con = new OleDbConnection(Connection.connectionString);
        private void Back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Show();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CourseInformation(HoleByHole, yardage, DifficultyRating) VALUES ('"+textBox1.Text+"', '"+textBox3.Text+"', '"+textBox2.Text+"')";
            con.Open();
            var cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Created Succesffully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.LoadDataGrid(dataGridView1, "CourseInformation");
        }


        private void CourseInformation_Load(object sender, EventArgs e)
        {
            Connection.LoadDataGrid(dataGridView1, "CourseInformation");
        }
    }
}
