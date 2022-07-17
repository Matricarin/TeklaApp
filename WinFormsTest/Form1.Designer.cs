namespace WinFormsTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hello_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hello_button
            // 
            this.Hello_button.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.Hello_button.FlatAppearance.BorderSize = 20;
            this.Hello_button.Font = new System.Drawing.Font("EuroRoman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hello_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hello_button.Location = new System.Drawing.Point(17, 13);
            this.Hello_button.Name = "Hello_button";
            this.Hello_button.Size = new System.Drawing.Size(112, 41);
            this.Hello_button.TabIndex = 0;
            this.Hello_button.Text = "Say \"Hello!\"";
            this.Hello_button.UseVisualStyleBackColor = true;
            this.Hello_button.Click += new System.EventHandler(this.Hello_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Hello_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "TEST";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Hello_button;
    }
}