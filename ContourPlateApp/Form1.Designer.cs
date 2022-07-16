namespace ContourPlateApp
{
    partial class Form1
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
            this.CreateCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfilePartName = new System.Windows.Forms.TextBox();
            this.MaterialPartName = new System.Windows.Forms.TextBox();
            this.PartName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreatePolyBeam = new System.Windows.Forms.Button();
            this.ProfilePartName2 = new System.Windows.Forms.TextBox();
            this.MaterialPartName2 = new System.Windows.Forms.TextBox();
            this.PartName2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCP
            // 
            this.CreateCP.Location = new System.Drawing.Point(10, 152);
            this.CreateCP.Name = "CreateCP";
            this.CreateCP.Size = new System.Drawing.Size(173, 59);
            this.CreateCP.TabIndex = 0;
            this.CreateCP.Text = "Create Contour Plate";
            this.CreateCP.UseVisualStyleBackColor = true;
            this.CreateCP.Click += new System.EventHandler(this.CreateCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile / PL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // ProfilePartName
            // 
            this.ProfilePartName.Location = new System.Drawing.Point(84, 21);
            this.ProfilePartName.Name = "ProfilePartName";
            this.ProfilePartName.Size = new System.Drawing.Size(361, 20);
            this.ProfilePartName.TabIndex = 4;
            // 
            // MaterialPartName
            // 
            this.MaterialPartName.Location = new System.Drawing.Point(84, 64);
            this.MaterialPartName.Name = "MaterialPartName";
            this.MaterialPartName.Size = new System.Drawing.Size(362, 20);
            this.MaterialPartName.TabIndex = 5;
            // 
            // PartName
            // 
            this.PartName.Location = new System.Drawing.Point(84, 106);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(361, 20);
            this.PartName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PartName2);
            this.groupBox1.Controls.Add(this.MaterialPartName2);
            this.groupBox1.Controls.Add(this.ProfilePartName2);
            this.groupBox1.Controls.Add(this.CreatePolyBeam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(478, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PolyBeam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProfilePartName);
            this.groupBox2.Controls.Add(this.PartName);
            this.groupBox2.Controls.Add(this.MaterialPartName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CreateCP);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 234);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ContourPlate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Profile / PL";
            // 
            // CreatePolyBeam
            // 
            this.CreatePolyBeam.Location = new System.Drawing.Point(15, 145);
            this.CreatePolyBeam.Name = "CreatePolyBeam";
            this.CreatePolyBeam.Size = new System.Drawing.Size(173, 66);
            this.CreatePolyBeam.TabIndex = 7;
            this.CreatePolyBeam.Text = "Create Poly Beam";
            this.CreatePolyBeam.UseVisualStyleBackColor = true;
            this.CreatePolyBeam.Click += new System.EventHandler(this.CreatePolyBeam_Click);
            // 
            // ProfilePartName2
            // 
            this.ProfilePartName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfilePartName2.Location = new System.Drawing.Point(105, 20);
            this.ProfilePartName2.Name = "ProfilePartName2";
            this.ProfilePartName2.Size = new System.Drawing.Size(351, 22);
            this.ProfilePartName2.TabIndex = 8;
            // 
            // MaterialPartName2
            // 
            this.MaterialPartName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialPartName2.Location = new System.Drawing.Point(105, 62);
            this.MaterialPartName2.Name = "MaterialPartName2";
            this.MaterialPartName2.Size = new System.Drawing.Size(351, 22);
            this.MaterialPartName2.TabIndex = 9;
            // 
            // PartName2
            // 
            this.PartName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartName2.Location = new System.Drawing.Point(105, 104);
            this.PartName2.Name = "PartName2";
            this.PartName2.Size = new System.Drawing.Size(351, 22);
            this.PartName2.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(951, 253);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProfilePartName;
        private System.Windows.Forms.TextBox MaterialPartName;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PartName2;
        private System.Windows.Forms.TextBox MaterialPartName2;
        private System.Windows.Forms.TextBox ProfilePartName2;
        private System.Windows.Forms.Button CreatePolyBeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

