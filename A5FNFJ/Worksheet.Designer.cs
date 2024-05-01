namespace A5FNFJ
{
    partial class Worksheet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Register = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.materialLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.worksheetPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.Register);
            this.groupBox1.Controls.Add(this.timeLbl);
            this.groupBox1.Controls.Add(this.materialLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 432);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(734, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Register.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Register.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.LightGreen;
            this.Register.Location = new System.Drawing.Point(615, 16);
            this.Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(113, 47);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Maroon;
            this.timeLbl.Location = new System.Drawing.Point(396, 30);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(19, 19);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "0";
            // 
            // materialLbl
            // 
            this.materialLbl.AutoSize = true;
            this.materialLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(95)))), ((int)(((byte)(114)))));
            this.materialLbl.Location = new System.Drawing.Point(139, 30);
            this.materialLbl.Name = "materialLbl";
            this.materialLbl.Size = new System.Drawing.Size(19, 19);
            this.materialLbl.TabIndex = 3;
            this.materialLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(242, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Time Cost:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material Cost:";
            // 
            // worksheetPanel
            // 
            this.worksheetPanel.Location = new System.Drawing.Point(0, 0);
            this.worksheetPanel.Name = "worksheetPanel";
            this.worksheetPanel.Size = new System.Drawing.Size(740, 425);
            this.worksheetPanel.TabIndex = 8;
            // 
            // Worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.worksheetPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Worksheet";
            this.Text = "Worksheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label materialLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel worksheetPanel;
    }
}