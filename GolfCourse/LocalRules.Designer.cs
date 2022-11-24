﻿namespace GolfCourse
{
    partial class LocalRules
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

        private void InitializeComponent()
{
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.textBox2 = new System.Windows.Forms.TextBox();
    this.textBox3 = new System.Windows.Forms.TextBox();
    this.Save = new System.Windows.Forms.Button();
    this.Back = new System.Windows.Forms.Button();
    this.AllLocalRules = new System.Windows.Forms.DataGridView();
    this.label5 = new System.Windows.Forms.Label();
    ((System.ComponentModel.ISupportInitialize)(this.AllLocalRules)).BeginInit();
    this.SuspendLayout();
    // 
    // label1
    // 
    this.label1.AutoSize = true;
    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.Location = new System.Drawing.Point(265, 26);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(175, 26);
    this.label1.TabIndex = 0;
    this.label1.Text = "LOCAL RULES";
    // 
    // label2
    // 
    this.label2.AutoSize = true;
    this.label2.Location = new System.Drawing.Point(12, 154);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(42, 16);
    this.label2.TabIndex = 1;
    this.label2.Text = "Rules";
    // 
    // label3
    // 
    this.label3.AutoSize = true;
    this.label3.Location = new System.Drawing.Point(12, 122);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(58, 16);
    this.label3.TabIndex = 2;
    this.label3.Text = "Location";
    // 
    // label4
    // 
    this.label4.AutoSize = true;
    this.label4.Location = new System.Drawing.Point(12, 87);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(36, 16);
    this.label4.TabIndex = 3;
    this.label4.Text = "Date";
    // 
    // textBox1
    // 
    this.textBox1.Location = new System.Drawing.Point(107, 87);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(441, 22);
    this.textBox1.TabIndex = 4;
    // 
    // textBox2
    // 
    this.textBox2.Location = new System.Drawing.Point(107, 154);
    this.textBox2.Name = "textBox2";
    this.textBox2.Size = new System.Drawing.Size(441, 22);
    this.textBox2.TabIndex = 5;
    // 
    // textBox3
    // 
    this.textBox3.Location = new System.Drawing.Point(107, 122);
    this.textBox3.Name = "textBox3";
    this.textBox3.Size = new System.Drawing.Size(441, 22);
    this.textBox3.TabIndex = 6;
    // 
    // Save
    // 
    this.Save.Location = new System.Drawing.Point(214, 207);
    this.Save.Name = "Save";
    this.Save.Size = new System.Drawing.Size(91, 37);
    this.Save.TabIndex = 7;
    this.Save.Text = "Save";
    this.Save.UseVisualStyleBackColor = true;
    this.Save.Click += new System.EventHandler(this.Save_Click);
    // 
    // Back
    // 
    this.Back.Location = new System.Drawing.Point(373, 207);
    this.Back.Name = "Back";
    this.Back.Size = new System.Drawing.Size(91, 37);
    this.Back.TabIndex = 8;
    this.Back.Text = "Back";
    this.Back.UseVisualStyleBackColor = true;
    this.Back.Click += new System.EventHandler(this.Back_Click);
    // 
    // AllLocalRules
    // 
    this.AllLocalRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.AllLocalRules.Location = new System.Drawing.Point(16, 297);
    this.AllLocalRules.Name = "AllLocalRules";
    this.AllLocalRules.RowHeadersWidth = 51;
    this.AllLocalRules.RowTemplate.Height = 24;
    this.AllLocalRules.Size = new System.Drawing.Size(684, 253);
    this.AllLocalRules.TabIndex = 9;
    // 
    // label5
    // 
    this.label5.AutoSize = true;
    this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label5.Location = new System.Drawing.Point(265, 268);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(224, 26);
    this.label5.TabIndex = 10;
    this.label5.Text = "ALL LOCAL RULES";
    // 
    // LocalRules
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.Yellow;
    this.ClientSize = new System.Drawing.Size(712, 562);
    this.Controls.Add(this.label5);
    this.Controls.Add(this.AllLocalRules);
    this.Controls.Add(this.Back);
    this.Controls.Add(this.Save);
    this.Controls.Add(this.textBox3);
    this.Controls.Add(this.textBox2);
    this.Controls.Add(this.textBox1);
    this.Controls.Add(this.label4);
    this.Controls.Add(this.label3);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.label1);
    this.Name = "LocalRules";
    this.Text = "LocalRules";
    this.Load += new System.EventHandler(this.LocalRules_Load);
    ((System.ComponentModel.ISupportInitialize)(this.AllLocalRules)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView AllLocalRules;
        private System.Windows.Forms.Label label5;
    }
}