using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfCourse
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Golfers_Click(object sender, EventArgs e)
        {
            new Golfers().Show();
            this.Hide();
        }

        private void CompetitionResults_Click(object sender, EventArgs e)
        {
            new CompetitionResults().Show();
            this.Hide();
        }

        private void CourseInformation_Click(object sender, EventArgs e)
        {
            new CourseInformation().Show();
            this.Hide();
        }

        private void GolfEquipments_Click(object sender, EventArgs e)
        {
            new GolfEquipments().Show();
            this.Hide();
            
        }

        private void LocalRules_Click(object sender, EventArgs e)
        {
            new LocalRules().Show();
            this.Hide();
        }

        private void Membership_Click(object sender, EventArgs e)
        {
            new MembershipInfo().Show();
            this.Hide();
        }

        private void Tournaments_Click(object sender, EventArgs e)
        {
            new Tournaments().Show();
            this.Hide();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
