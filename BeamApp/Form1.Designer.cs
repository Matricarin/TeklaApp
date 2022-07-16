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
            this.SuspendLayout();
            // 
            // BeamButton
            // 
            this.BeamButton.Location = new System.Drawing.Point(174, 91);
            this.BeamButton.Name = "BeamButton";
            this.BeamButton.Size = new System.Drawing.Size(137, 35);
            this.BeamButton.TabIndex = 0;
            this.BeamButton.Text = "BeamButton";
            this.BeamButton.UseVisualStyleBackColor = true;
            this.BeamButton.Click += new System.EventHandler(this.BeamButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 240);
            this.Controls.Add(this.BeamButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BeamButton;
    }
}

