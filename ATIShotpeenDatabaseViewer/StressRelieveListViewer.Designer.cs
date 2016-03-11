namespace ATICertViewer
{
    partial class StressRelieveListViewer
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
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.viewEditButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.certNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stressRelieveCertificationLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.stressRelieveCertificationLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.StressRelieveCertificationLogTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.certNoTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.partNoTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.certifiedByTextBox = new System.Windows.Forms.TextBox();
            this.enableDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stressRelieveCertificationLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 420);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 420);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 2;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 420);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.certNumberDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.partNumberDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.jobNumberDataGridViewTextBoxColumn,
            this.operationNumberDataGridViewTextBoxColumn,
            this.certifiedByDataGridViewTextBoxColumn,
            this.certDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stressRelieveCertificationLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // certNumberDataGridViewTextBoxColumn
            // 
            this.certNumberDataGridViewTextBoxColumn.DataPropertyName = "CertNumber";
            this.certNumberDataGridViewTextBoxColumn.HeaderText = "Cert No";
            this.certNumberDataGridViewTextBoxColumn.Name = "certNumberDataGridViewTextBoxColumn";
            this.certNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "Part_Number";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "Part No";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            this.partNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            this.revisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobNumberDataGridViewTextBoxColumn
            // 
            this.jobNumberDataGridViewTextBoxColumn.DataPropertyName = "Job_Number";
            this.jobNumberDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobNumberDataGridViewTextBoxColumn.Name = "jobNumberDataGridViewTextBoxColumn";
            this.jobNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationNumberDataGridViewTextBoxColumn
            // 
            this.operationNumberDataGridViewTextBoxColumn.DataPropertyName = "Operation_Number";
            this.operationNumberDataGridViewTextBoxColumn.HeaderText = "Op No";
            this.operationNumberDataGridViewTextBoxColumn.Name = "operationNumberDataGridViewTextBoxColumn";
            this.operationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certifiedByDataGridViewTextBoxColumn
            // 
            this.certifiedByDataGridViewTextBoxColumn.DataPropertyName = "Certified_By";
            this.certifiedByDataGridViewTextBoxColumn.HeaderText = "Certified By";
            this.certifiedByDataGridViewTextBoxColumn.Name = "certifiedByDataGridViewTextBoxColumn";
            this.certifiedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certDateDataGridViewTextBoxColumn
            // 
            this.certDateDataGridViewTextBoxColumn.DataPropertyName = "Cert_Date";
            this.certDateDataGridViewTextBoxColumn.HeaderText = "Cert Date";
            this.certDateDataGridViewTextBoxColumn.Name = "certDateDataGridViewTextBoxColumn";
            this.certDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stressRelieveCertificationLogBindingSource
            // 
            this.stressRelieveCertificationLogBindingSource.DataMember = "StressRelieveCertificationLog";
            this.stressRelieveCertificationLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stress Relieve Certs";
            // 
            // stressRelieveCertificationLogTableAdapter
            // 
            this.stressRelieveCertificationLogTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cert No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Part No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Job:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Certified By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cert Date:";
            // 
            // certNoTextBox
            // 
            this.certNoTextBox.Location = new System.Drawing.Point(92, 46);
            this.certNoTextBox.Name = "certNoTextBox";
            this.certNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.certNoTextBox.TabIndex = 19;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(92, 68);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(204, 20);
            this.customerTextBox.TabIndex = 20;
            // 
            // partNoTextBox
            // 
            this.partNoTextBox.Location = new System.Drawing.Point(92, 90);
            this.partNoTextBox.Name = "partNoTextBox";
            this.partNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.partNoTextBox.TabIndex = 21;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(92, 112);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(204, 20);
            this.jobTextBox.TabIndex = 22;
            // 
            // certifiedByTextBox
            // 
            this.certifiedByTextBox.Location = new System.Drawing.Point(92, 134);
            this.certifiedByTextBox.Name = "certifiedByTextBox";
            this.certifiedByTextBox.Size = new System.Drawing.Size(204, 20);
            this.certifiedByTextBox.TabIndex = 23;
            // 
            // enableDateFilterCheckBox
            // 
            this.enableDateFilterCheckBox.AutoSize = true;
            this.enableDateFilterCheckBox.Location = new System.Drawing.Point(306, 158);
            this.enableDateFilterCheckBox.Name = "enableDateFilterCheckBox";
            this.enableDateFilterCheckBox.Size = new System.Drawing.Size(105, 17);
            this.enableDateFilterCheckBox.TabIndex = 25;
            this.enableDateFilterCheckBox.Text = "Enable date filter";
            this.enableDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // StressRelieveListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 454);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.enableDateFilterCheckBox);
            this.Controls.Add(this.certifiedByTextBox);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.partNoTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.certNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Name = "StressRelieveListViewer";
            this.Text = "StressRelieveListViewer";
            this.Load += new System.EventHandler(this.StressRelieveListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stressRelieveCertificationLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button viewEditButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private ATIDeliveryDataSet aTIDeliveryDataSet;
        private System.Windows.Forms.BindingSource stressRelieveCertificationLogBindingSource;
        private ATIDeliveryDataSetTableAdapters.StressRelieveCertificationLogTableAdapter stressRelieveCertificationLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn certNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox certNoTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox partNoTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox certifiedByTextBox;
        private System.Windows.Forms.CheckBox enableDateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}