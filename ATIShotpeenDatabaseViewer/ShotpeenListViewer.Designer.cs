namespace ATICertViewer
{
    partial class ShotpeenListViewer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partrevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblJobProcessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.tblJobProcessLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.tblJobProcessLogTableAdapter();
            this.newButton = new System.Windows.Forms.Button();
            this.viewEditButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enableDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.specificationTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.partNoTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.certNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobProcessLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.jobnumDataGridViewTextBoxColumn,
            this.partnumDataGridViewTextBoxColumn,
            this.partrevDataGridViewTextBoxColumn,
            this.partdescDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.finishdateDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblJobProcessLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "process_num";
            this.Column1.HeaderText = "Cert Num";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // jobnumDataGridViewTextBoxColumn
            // 
            this.jobnumDataGridViewTextBoxColumn.DataPropertyName = "job_num";
            this.jobnumDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobnumDataGridViewTextBoxColumn.Name = "jobnumDataGridViewTextBoxColumn";
            this.jobnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partnumDataGridViewTextBoxColumn
            // 
            this.partnumDataGridViewTextBoxColumn.DataPropertyName = "part_num";
            this.partnumDataGridViewTextBoxColumn.HeaderText = "Part Number";
            this.partnumDataGridViewTextBoxColumn.Name = "partnumDataGridViewTextBoxColumn";
            this.partnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partrevDataGridViewTextBoxColumn
            // 
            this.partrevDataGridViewTextBoxColumn.DataPropertyName = "part_rev";
            this.partrevDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.partrevDataGridViewTextBoxColumn.Name = "partrevDataGridViewTextBoxColumn";
            this.partrevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partdescDataGridViewTextBoxColumn
            // 
            this.partdescDataGridViewTextBoxColumn.DataPropertyName = "part_desc";
            this.partdescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.partdescDataGridViewTextBoxColumn.Name = "partdescDataGridViewTextBoxColumn";
            this.partdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishdateDataGridViewTextBoxColumn
            // 
            this.finishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.HeaderText = "Finish Date";
            this.finishdateDataGridViewTextBoxColumn.Name = "finishdateDataGridViewTextBoxColumn";
            this.finishdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblJobProcessLogBindingSource
            // 
            this.tblJobProcessLogBindingSource.DataMember = "tblJobProcessLog";
            this.tblJobProcessLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblJobProcessLogTableAdapter
            // 
            this.tblJobProcessLogTableAdapter.ClearBeforeFill = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 448);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 448);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 2;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 448);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shotpeen Certs";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // enableDateFilterCheckBox
            // 
            this.enableDateFilterCheckBox.AutoSize = true;
            this.enableDateFilterCheckBox.Location = new System.Drawing.Point(295, 181);
            this.enableDateFilterCheckBox.Name = "enableDateFilterCheckBox";
            this.enableDateFilterCheckBox.Size = new System.Drawing.Size(105, 17);
            this.enableDateFilterCheckBox.TabIndex = 38;
            this.enableDateFilterCheckBox.Text = "Enable date filter";
            this.enableDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // specificationTextBox
            // 
            this.specificationTextBox.Location = new System.Drawing.Point(81, 157);
            this.specificationTextBox.Name = "specificationTextBox";
            this.specificationTextBox.Size = new System.Drawing.Size(204, 20);
            this.specificationTextBox.TabIndex = 37;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(81, 135);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(204, 20);
            this.jobTextBox.TabIndex = 36;
            // 
            // partNoTextBox
            // 
            this.partNoTextBox.Location = new System.Drawing.Point(81, 113);
            this.partNoTextBox.Name = "partNoTextBox";
            this.partNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.partNoTextBox.TabIndex = 35;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(81, 91);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(204, 20);
            this.customerTextBox.TabIndex = 34;
            // 
            // certNoTextBox
            // 
            this.certNoTextBox.Location = new System.Drawing.Point(81, 69);
            this.certNoTextBox.Name = "certNoTextBox";
            this.certNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.certNoTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Specification:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Job:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Part No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cert No:";
            // 
            // ShotpeenListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 489);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.enableDateFilterCheckBox);
            this.Controls.Add(this.specificationTextBox);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.partNoTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.certNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShotpeenListViewer";
            this.Text = "ListViewer";
            this.Load += new System.EventHandler(this.ListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobProcessLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ATIDeliveryDataSet aTIDeliveryDataSet;
        private System.Windows.Forms.BindingSource tblJobProcessLogBindingSource;
        private ATIDeliveryDataSetTableAdapters.tblJobProcessLogTableAdapter tblJobProcessLogTableAdapter;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button viewEditButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partrevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox enableDateFilterCheckBox;
        private System.Windows.Forms.TextBox specificationTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox partNoTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox certNoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}