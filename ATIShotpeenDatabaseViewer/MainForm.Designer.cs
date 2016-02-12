namespace ATICertViewer
{
    partial class MainForm
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
            this.shotpeenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.magButton = new System.Windows.Forms.Button();
            this.edmButton = new System.Windows.Forms.Button();
            this.stressRelieveButton = new System.Windows.Forms.Button();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shotpeenButton
            // 
            this.shotpeenButton.Location = new System.Drawing.Point(75, 89);
            this.shotpeenButton.Name = "shotpeenButton";
            this.shotpeenButton.Size = new System.Drawing.Size(97, 23);
            this.shotpeenButton.TabIndex = 0;
            this.shotpeenButton.Text = "Shotpeen";
            this.shotpeenButton.UseVisualStyleBackColor = true;
            this.shotpeenButton.Click += new System.EventHandler(this.shotpeenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CERTIFICATION\r\nFORMS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magButton
            // 
            this.magButton.Location = new System.Drawing.Point(75, 118);
            this.magButton.Name = "magButton";
            this.magButton.Size = new System.Drawing.Size(97, 23);
            this.magButton.TabIndex = 2;
            this.magButton.Text = "Mag";
            this.magButton.UseVisualStyleBackColor = true;
            this.magButton.Click += new System.EventHandler(this.magButton_Click);
            // 
            // edmButton
            // 
            this.edmButton.Location = new System.Drawing.Point(75, 147);
            this.edmButton.Name = "edmButton";
            this.edmButton.Size = new System.Drawing.Size(97, 23);
            this.edmButton.TabIndex = 3;
            this.edmButton.Text = "EDM";
            this.edmButton.UseVisualStyleBackColor = true;
            this.edmButton.Click += new System.EventHandler(this.edmButton_Click);
            // 
            // stressRelieveButton
            // 
            this.stressRelieveButton.Location = new System.Drawing.Point(75, 176);
            this.stressRelieveButton.Name = "stressRelieveButton";
            this.stressRelieveButton.Size = new System.Drawing.Size(97, 23);
            this.stressRelieveButton.TabIndex = 4;
            this.stressRelieveButton.Text = "Stress Relieve";
            this.stressRelieveButton.UseVisualStyleBackColor = true;
            this.stressRelieveButton.Click += new System.EventHandler(this.stressRelieveButton_Click);
            // 
            // registerUserButton
            // 
            this.registerUserButton.Location = new System.Drawing.Point(23, 231);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(97, 23);
            this.registerUserButton.TabIndex = 5;
            this.registerUserButton.Text = "Register User";
            this.registerUserButton.UseVisualStyleBackColor = true;
            this.registerUserButton.Click += new System.EventHandler(this.registerUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(126, 231);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(97, 23);
            this.editUserButton.TabIndex = 6;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 266);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.registerUserButton);
            this.Controls.Add(this.stressRelieveButton);
            this.Controls.Add(this.edmButton);
            this.Controls.Add(this.magButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shotpeenButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shotpeenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button magButton;
        private System.Windows.Forms.Button edmButton;
        private System.Windows.Forms.Button stressRelieveButton;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.Button editUserButton;
    }
}