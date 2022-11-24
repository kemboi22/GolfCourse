namespace GolfCourse
{
    partial class GolfEquipments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GolfClubs = new System.Windows.Forms.TextBox();
            this.GolfTees = new System.Windows.Forms.TextBox();
            this.GolfBalls = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AllGolfEquipments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllGolfEquipments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOLF EQUIPMENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Golf Tees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Golf Balls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Golf Clubs";
            // 
            // GolfClubs
            // 
            this.GolfClubs.Location = new System.Drawing.Point(86, 73);
            this.GolfClubs.Name = "GolfClubs";
            this.GolfClubs.Size = new System.Drawing.Size(548, 22);
            this.GolfClubs.TabIndex = 4;
            // 
            // GolfTees
            // 
            this.GolfTees.Location = new System.Drawing.Point(86, 142);
            this.GolfTees.Name = "GolfTees";
            this.GolfTees.Size = new System.Drawing.Size(548, 22);
            this.GolfTees.TabIndex = 5;
            // 
            // GolfBalls
            // 
            this.GolfBalls.Location = new System.Drawing.Point(86, 106);
            this.GolfBalls.Name = "GolfBalls";
            this.GolfBalls.Size = new System.Drawing.Size(548, 22);
            this.GolfBalls.TabIndex = 6;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(198, 184);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 47);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(341, 184);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 47);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "ALL GOLF EQUIPMENTS";
            // 
            // AllGolfEquipments
            // 
            this.AllGolfEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllGolfEquipments.Location = new System.Drawing.Point(7, 275);
            this.AllGolfEquipments.Name = "AllGolfEquipments";
            this.AllGolfEquipments.RowHeadersWidth = 51;
            this.AllGolfEquipments.RowTemplate.Height = 24;
            this.AllGolfEquipments.Size = new System.Drawing.Size(701, 231);
            this.AllGolfEquipments.TabIndex = 10;
            // 
            // GolfEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(720, 518);
            this.Controls.Add(this.AllGolfEquipments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.GolfBalls);
            this.Controls.Add(this.GolfTees);
            this.Controls.Add(this.GolfClubs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GolfEquipments";
            this.Text = "GolfEquipments";
            this.Load += new System.EventHandler(this.GolfEquipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllGolfEquipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GolfClubs;
        private System.Windows.Forms.TextBox GolfTees;
        private System.Windows.Forms.TextBox GolfBalls;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView AllGolfEquipments;
    }
}