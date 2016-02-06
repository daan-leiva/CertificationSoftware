namespace ATIShotpeenDatabaseViewer
{
    partial class EDMListViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.eDMCertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSet();
            this.eDMCertsTableAdapter = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSetTableAdapters.EDMCertsTableAdapter();
            this.certnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partrevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edmprogramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationRevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDMCertsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 308);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 308);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 308);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 8;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 308);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 7;
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
            this.certnumDataGridViewTextBoxColumn,
            this.jobnumDataGridViewTextBoxColumn,
            this.partnumDataGridViewTextBoxColumn,
            this.partrevDataGridViewTextBoxColumn,
            this.partdescDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.lotnumDataGridViewTextBoxColumn,
            this.opnumDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.edmprogramDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.performedDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.specificationRevDataGridViewTextBoxColumn,
            this.certifierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eDMCertsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "EDM Certs";
            // 
            // eDMCertsBindingSource
            // 
            this.eDMCertsBindingSource.DataMember = "EDMCerts";
            this.eDMCertsBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eDMCertsTableAdapter
            // 
            this.eDMCertsTableAdapter.ClearBeforeFill = true;
            // 
            // certnumDataGridViewTextBoxColumn
            // 
            this.certnumDataGridViewTextBoxColumn.DataPropertyName = "cert_num";
            this.certnumDataGridViewTextBoxColumn.HeaderText = "Cert Num";
            this.certnumDataGridViewTextBoxColumn.Name = "certnumDataGridViewTextBoxColumn";
            this.certnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobnumDataGridViewTextBoxColumn
            // 
            this.jobnumDataGridViewTextBoxColumn.DataPropertyName = "job_num";
            this.jobnumDataGridViewTextBoxColumn.HeaderText = "Job Num";
            this.jobnumDataGridViewTextBoxColumn.Name = "jobnumDataGridViewTextBoxColumn";
            this.jobnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partnumDataGridViewTextBoxColumn
            // 
            this.partnumDataGridViewTextBoxColumn.DataPropertyName = "part_num";
            this.partnumDataGridViewTextBoxColumn.HeaderText = "Part Num";
            this.partnumDataGridViewTextBoxColumn.Name = "partnumDataGridViewTextBoxColumn";
            this.partnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partrevDataGridViewTextBoxColumn
            // 
            this.partrevDataGridViewTextBoxColumn.DataPropertyName = "part_rev";
            this.partrevDataGridViewTextBoxColumn.HeaderText = "Part Rev";
            this.partrevDataGridViewTextBoxColumn.Name = "partrevDataGridViewTextBoxColumn";
            this.partrevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partdescDataGridViewTextBoxColumn
            // 
            this.partdescDataGridViewTextBoxColumn.DataPropertyName = "part_desc";
            this.partdescDataGridViewTextBoxColumn.HeaderText = "Part Desc";
            this.partdescDataGridViewTextBoxColumn.Name = "partdescDataGridViewTextBoxColumn";
            this.partdescDataGridViewTextBoxColumn.ReadOnly = true;
            this.partdescDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lotnumDataGridViewTextBoxColumn
            // 
            this.lotnumDataGridViewTextBoxColumn.DataPropertyName = "lot_num";
            this.lotnumDataGridViewTextBoxColumn.HeaderText = "Lot Num";
            this.lotnumDataGridViewTextBoxColumn.Name = "lotnumDataGridViewTextBoxColumn";
            this.lotnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opnumDataGridViewTextBoxColumn
            // 
            this.opnumDataGridViewTextBoxColumn.DataPropertyName = "op_num";
            this.opnumDataGridViewTextBoxColumn.HeaderText = "Op Num";
            this.opnumDataGridViewTextBoxColumn.Name = "opnumDataGridViewTextBoxColumn";
            this.opnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edmprogramDataGridViewTextBoxColumn
            // 
            this.edmprogramDataGridViewTextBoxColumn.DataPropertyName = "edm_program";
            this.edmprogramDataGridViewTextBoxColumn.HeaderText = "EDM Program";
            this.edmprogramDataGridViewTextBoxColumn.Name = "edmprogramDataGridViewTextBoxColumn";
            this.edmprogramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty Processed";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // performedDataGridViewTextBoxColumn
            // 
            this.performedDataGridViewTextBoxColumn.DataPropertyName = "performed";
            this.performedDataGridViewTextBoxColumn.HeaderText = "Performed";
            this.performedDataGridViewTextBoxColumn.Name = "performedDataGridViewTextBoxColumn";
            this.performedDataGridViewTextBoxColumn.ReadOnly = true;
            this.performedDataGridViewTextBoxColumn.Visible = false;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specificationRevDataGridViewTextBoxColumn
            // 
            this.specificationRevDataGridViewTextBoxColumn.DataPropertyName = "specificationRev";
            this.specificationRevDataGridViewTextBoxColumn.HeaderText = "Spec Rev";
            this.specificationRevDataGridViewTextBoxColumn.Name = "specificationRevDataGridViewTextBoxColumn";
            this.specificationRevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certifierDataGridViewTextBoxColumn
            // 
            this.certifierDataGridViewTextBoxColumn.DataPropertyName = "certifier";
            this.certifierDataGridViewTextBoxColumn.HeaderText = "Certified By";
            this.certifierDataGridViewTextBoxColumn.Name = "certifierDataGridViewTextBoxColumn";
            this.certifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EDMListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Name = "EDMListViewer";
            this.Text = "EDMListViewer";
            this.Load += new System.EventHandler(this.EDMListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDMCertsBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private ATIDeliveryDataSet aTIDeliveryDataSet;
        private System.Windows.Forms.BindingSource eDMCertsBindingSource;
        private ATIDeliveryDataSetTableAdapters.EDMCertsTableAdapter eDMCertsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn certnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partrevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edmprogramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn performedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationRevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certifierDataGridViewTextBoxColumn;
    }
}