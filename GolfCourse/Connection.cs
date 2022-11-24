using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GolfCourse
{
    public class Connection
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GolfCourse.mdb";
        private static OleDbConnection con = new OleDbConnection(connectionString);

        public static void LoadDataGrid(DataGridView dataGridView, string table )
        {
            con.Open();
            string query = "SELECT * FROM " + table;
            var adapter = new OleDbDataAdapter(query, con);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            con.Close();
        }
    }
}