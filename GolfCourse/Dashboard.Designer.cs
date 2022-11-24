namespace GolfCourse
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Golfers = new System.Windows.Forms.Button();
            this.LocalRules = new System.Windows.Forms.Button();
            this.Membership = new System.Windows.Forms.Button();
            this.GolfEquipments = new System.Windows.Forms.Button();
            this.CourseInformation = new System.Windows.Forms.Button();
            this.CompetitionResults = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Tournaments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Golfers
            // 
            this.Golfers.Location = new System.Drawing.Point(27, 89);
            this.Golfers.Name = "Golfers";
            this.Golfers.Size = new System.Drawing.Size(128, 62);
            this.Golfers.TabIndex = 0;
            this.Golfers.Text = "Golfers";
            this.Golfers.UseVisualStyleBackColor = true;
            this.Golfers.Click += new System.EventHandler(this.Golfers_Click);
            // 
            // LocalRules
            // 
            this.LocalRules.Location = new System.Drawing.Point(265, 224);
            this.LocalRules.Name = "LocalRules";
            this.LocalRules.Size = new System.Drawing.Size(128, 62);
            this.LocalRules.TabIndex = 1;
            this.LocalRules.Text = "Local Rules";
            this.LocalRules.UseVisualStyleBackColor = true;
            this.LocalRules.Click += new System.EventHandler(this.LocalRules_Click);
            // 
            // Membership
            // 
            this.Membership.Location = new System.Drawing.Point(555, 224);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(128, 62);
            this.Membership.TabIndex = 2;
            this.Membership.Text = "Membership";
            this.Membership.UseVisualStyleBackColor = true;
            this.Membership.Click += new System.EventHandler(this.Membership_Click);
            // 
            // GolfEquipments
            // 
            this.GolfEquipments.Location = new System.Drawing.Point(27, 224);
            this.GolfEquipments.Name = "GolfEquipments";
            this.GolfEquipments.Size = new System.Drawing.Size(128, 62);
            this.GolfEquipments.TabIndex = 3;
            this.GolfEquipments.Text = "Golf Equipments";
            this.GolfEquipments.UseVisualStyleBackColor = true;
            this.GolfEquipments.Click += new System.EventHandler(this.GolfEquipments_Click);
            // 
            // CourseInformation
            // 
            this.CourseInformation.Location = new System.Drawing.Point(555, 89);
            this.CourseInformation.Name = "CourseInformation";
            this.CourseInformation.Size = new System.Drawing.Size(128, 62);
            this.CourseInformation.TabIndex = 4;
            this.CourseInformation.Text = "Course Information";
            this.CourseInformation.UseVisualStyleBackColor = true;
            this.CourseInformation.Click += new System.EventHandler(this.CourseInformation_Click);
            // 
            // CompetitionResults
            // 
            this.CompetitionResults.Location = new System.Drawing.Point(265, 89);
            this.CompetitionResults.Name = "CompetitionResults";
            this.CompetitionResults.Size = new System.Drawing.Size(128, 62);
            this.CompetitionResults.TabIndex = 5;
            this.CompetitionResults.Text = "Competition Results";
            this.CompetitionResults.UseVisualStyleBackColor = true;
            this.CompetitionResults.Click += new System.EventHandler(this.CompetitionResults_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Location = new System.Drawing.Point(340, 464);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(128, 62);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "QuitApplication";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Tournaments
            // 
            this.Tournaments.Location = new System.Drawing.Point(27, 362);
            this.Tournaments.Name = "Tournaments";
            this.Tournaments.Size = new System.Drawing.Size(128, 62);
            this.Tournaments.TabIndex = 7;
            this.Tournaments.Text = "Upcoming Tournaments";
            this.Tournaments.UseVisualStyleBackColor = true;
            this.Tournaments.Click += new System.EventHandler(this.Tournaments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "DASHBOARD";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tournaments);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.CompetitionResults);
            this.Controls.Add(this.CourseInformation);
            this.Controls.Add(this.GolfEquipments);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.LocalRules);
            this.Controls.Add(this.Golfers);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Golfers;
        private System.Windows.Forms.Button LocalRules;
        private System.Windows.Forms.Button Membership;
        private System.Windows.Forms.Button GolfEquipments;
        private System.Windows.Forms.Button CourseInformation;
        private System.Windows.Forms.Button CompetitionResults;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Tournaments;
        private System.Windows.Forms.Label label1;
    }
}