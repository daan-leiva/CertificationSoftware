namespace ATICertViewer
{
    partial class MagForms
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
            this.d2060Button = new System.Windows.Forms.Button();
            this.taqButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.magCertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d2060Button
            // 
            this.d2060Button.Location = new System.Drawing.Point(62, 140);
            this.d2060Button.Name = "d2060Button";
            this.d2060Button.Size = new System.Drawing.Size(97, 23);
            this.d2060Button.TabIndex = 2;
            this.d2060Button.Text = "D-2060R";
            this.d2060Button.UseVisualStyleBackColor = true;
            this.d2060Button.Click += new System.EventHandler(this.d2060Button_Click);
            // 
            // taqButton
            // 
            this.taqButton.Location = new System.Drawing.Point(62, 111);
            this.taqButton.Name = "taqButton";
            this.taqButton.Size = new System.Drawing.Size(97, 23);
            this.taqButton.TabIndex = 1;
            this.taqButton.Text = "TAQ 525";
            this.taqButton.UseVisualStyleBackColor = true;
            this.taqButton.Click += new System.EventHandler(this.taqButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAG FORMS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magCertButton
            // 
            this.magCertButton.Location = new System.Drawing.Point(62, 82);
            this.magCertButton.Name = "magCertButton";
            this.magCertButton.Size = new System.Drawing.Size(97, 23);
            this.magCertButton.TabIndex = 0;
            this.magCertButton.Text = "Mag Cert";
            this.magCertButton.UseVisualStyleBackColor = true;
            this.magCertButton.Click += new System.EventHandler(this.magCertButton_Click);
            // 
            // MagForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(220, 204);
            this.Controls.Add(this.d2060Button);
            this.Controls.Add(this.taqButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magCertButton);
            this.Name = "MagForms";
            this.Text = "MadForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d2060Button;
        private System.Windows.Forms.Button taqButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button magCertButton;
    }
}