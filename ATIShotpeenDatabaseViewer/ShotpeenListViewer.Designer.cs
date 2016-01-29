namespace ATIShotpeenDatabaseViewer
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
            this.tblJobProcessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSet();
            this.tblJobProcessLogTableAdapter = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSetTableAdapters.tblJobProcessLogTableAdapter();
            this.newButton = new System.Windows.Forms.Button();
            this.viewEditButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.newButton.Location = new System.Drawing.Point(12, 310);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 310);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 3;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 310);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
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
            this.exitButton.Location = new System.Drawing.Point(977, 310);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // ShotpeenListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 354);
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
    }
}