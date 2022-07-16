namespace BeamApp
{
    public partial class Form1
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
            this.BeamButton = new System.Windows.Forms.Button();
            this.BeamName = new System.Windows.Forms.Label();
            this.InsertBeamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BeamButton
            // 
            this.BeamButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BeamButton.Location = new System.Drawing.Point(53, 57);
            this.BeamButton.Name = "BeamButton";
            this.BeamButton.Size = new System.Drawing.Size(168, 35);
            this.BeamButton.TabIndex = 0;
            this.BeamButton.Text = "BeamButton";
            this.BeamButton.UseVisualStyleBackColor = true;
            this.BeamButton.Click += new System.EventHandler(this.BeamButton_Click);
            // 
            // BeamName
            // 
            this.BeamName.AutoSize = true;
            this.BeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeamName.Location = new System.Drawing.Point(21, 10);
            this.BeamName.Name = "BeamName";
            this.BeamName.Size = new System.Drawing.Size(118, 16);
            this.BeamName.TabIndex = 1;
            this.BeamName.Text = "Insert Beam Name";
            // 
            // InsertBeamName
            // 
            this.InsertBeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertBeamName.Location = new System.Drawing.Point(24, 29);
            this.InsertBeamName.Name = "InsertBeamName";
            this.InsertBeamName.Size = new System.Drawing.Size(237, 22);
            this.InsertBeamName.TabIndex = 2;
            this.InsertBeamName.TextChanged += new System.EventHandler(this.InsertBeamName_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.InsertBeamName);
            this.Controls.Add(this.BeamName);
            this.Controls.Add(this.BeamButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeamButton;
        private System.Windows.Forms.Label BeamName;
        private System.Windows.Forms.TextBox InsertBeamName;
    }
}

