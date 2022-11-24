namespace GolfCourse
{
    partial class MembershipInfo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Fees = new System.Windows.Forms.TextBox();
            this.Benefits = new System.Windows.Forms.TextBox();
            this.MembershipOptions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Membership)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "MEMBERSHIP INFORMATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Benefits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Membership Options";
            // 
            // Membership
            // 
            this.Membership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Membership.Location = new System.Drawing.Point(15, 262);
            this.Membership.Name = "Membership";
            this.Membership.RowHeadersWidth = 51;
            this.Membership.RowTemplate.Height = 24;
            this.Membership.Size = new System.Drawing.Size(773, 231);
            this.Membership.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "ALL MEMBERSHIP INFORMATION";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(404, 171);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 47);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(261, 171);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 47);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Fees
            // 
            this.Fees.Location = new System.Drawing.Point(149, 93);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(548, 22);
            this.Fees.TabIndex = 13;
            // 
            // Benefits
            // 
            this.Benefits.Location = new System.Drawing.Point(149, 129);
            this.Benefits.Name = "Benefits";
            this.Benefits.Size = new System.Drawing.Size(548, 22);
            this.Benefits.TabIndex = 12;
            // 
            // MembershipOptions
            // 
            this.MembershipOptions.Location = new System.Drawing.Point(149, 60);
            this.MembershipOptions.Name = "MembershipOptions";
            this.MembershipOptions.Size = new System.Drawing.Size(548, 22);
            this.MembershipOptions.TabIndex = 11;
            // 
            // MembershipInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.Benefits);
            this.Controls.Add(this.MembershipOptions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "MembershipInfo";
            this.Text = "MembershipInfo";
            this.Load += new System.EventHandler(this.MembershipInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Membership)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Membership;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Fees;
        private System.Windows.Forms.TextBox Benefits;
        private System.Windows.Forms.TextBox MembershipOptions;
    }
}