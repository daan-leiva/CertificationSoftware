namespace ATIShotpeenDatabaseViewer
{
    partial class MagListViewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.aTIDeliveryDataSet = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSet();
            this.magListLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magListLogTableAdapter = new ATIShotpeenDatabaseViewer.ATIDeliveryDataSetTableAdapters.MagListLogTableAdapter();
            this.certDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInspectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAcceptedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyRejectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 319);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 319);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 8;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 319);
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
            this.certDataGridViewTextBoxColumn,
            this.partNumberDataGridViewTextBoxColumn,
            this.revDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.jobNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.quantityInspectedDataGridViewTextBoxColumn,
            this.qtyAcceptedDataGridViewTextBoxColumn,
            this.qtyRejectedDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.specTypeDataGridViewTextBoxColumn,
            this.specClassDataGridViewTextBoxColumn,
            this.acceptTypeDataGridViewTextBoxColumn,
            this.acceptgradeDataGridViewTextBoxColumn,
            this.magMachineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magListLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mag Certs";
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magListLogBindingSource
            // 
            this.magListLogBindingSource.DataMember = "MagListLog";
            this.magListLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // magListLogTableAdapter
            // 
            this.magListLogTableAdapter.ClearBeforeFill = true;
            // 
            // certDataGridViewTextBoxColumn
            // 
            this.certDataGridViewTextBoxColumn.DataPropertyName = "Cert";
            this.certDataGridViewTextBoxColumn.HeaderText = "Cert Num";
            this.certDataGridViewTextBoxColumn.Name = "certDataGridViewTextBoxColumn";
            this.certDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "Part Number";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "Part Number";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            this.partNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revDataGridViewTextBoxColumn
            // 
            this.revDataGridViewTextBoxColumn.DataPropertyName = "Rev";
            this.revDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revDataGridViewTextBoxColumn.Name = "revDataGridViewTextBoxColumn";
            this.revDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobNumberDataGridViewTextBoxColumn
            // 
            this.jobNumberDataGridViewTextBoxColumn.DataPropertyName = "Job Number";
            this.jobNumberDataGridViewTextBoxColumn.HeaderText = "Job Number";
            this.jobNumberDataGridViewTextBoxColumn.Name = "jobNumberDataGridViewTextBoxColumn";
            this.jobNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInspectedDataGridViewTextBoxColumn
            // 
            this.quantityInspectedDataGridViewTextBoxColumn.DataPropertyName = "Quantity Inspected";
            this.quantityInspectedDataGridViewTextBoxColumn.HeaderText = "Qty Inspected";
            this.quantityInspectedDataGridViewTextBoxColumn.Name = "quantityInspectedDataGridViewTextBoxColumn";
            this.quantityInspectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyAcceptedDataGridViewTextBoxColumn
            // 
            this.qtyAcceptedDataGridViewTextBoxColumn.DataPropertyName = "Qty Accepted";
            this.qtyAcceptedDataGridViewTextBoxColumn.HeaderText = "Qty Accepted";
            this.qtyAcceptedDataGridViewTextBoxColumn.Name = "qtyAcceptedDataGridViewTextBoxColumn";
            this.qtyAcceptedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyRejectedDataGridViewTextBoxColumn
            // 
            this.qtyRejectedDataGridViewTextBoxColumn.DataPropertyName = "Qty Rejected";
            this.qtyRejectedDataGridViewTextBoxColumn.HeaderText = "Qty Rejected";
            this.qtyRejectedDataGridViewTextBoxColumn.Name = "qtyRejectedDataGridViewTextBoxColumn";
            this.qtyRejectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "Spec";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specTypeDataGridViewTextBoxColumn
            // 
            this.specTypeDataGridViewTextBoxColumn.DataPropertyName = "Spec Type";
            this.specTypeDataGridViewTextBoxColumn.HeaderText = "Spec Type";
            this.specTypeDataGridViewTextBoxColumn.Name = "specTypeDataGridViewTextBoxColumn";
            this.specTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specClassDataGridViewTextBoxColumn
            // 
            this.specClassDataGridViewTextBoxColumn.DataPropertyName = "Spec Class";
            this.specClassDataGridViewTextBoxColumn.HeaderText = "Spec Class";
            this.specClassDataGridViewTextBoxColumn.Name = "specClassDataGridViewTextBoxColumn";
            this.specClassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acceptTypeDataGridViewTextBoxColumn
            // 
            this.acceptTypeDataGridViewTextBoxColumn.DataPropertyName = "Accept Type";
            this.acceptTypeDataGridViewTextBoxColumn.HeaderText = "Accept Type";
            this.acceptTypeDataGridViewTextBoxColumn.Name = "acceptTypeDataGridViewTextBoxColumn";
            this.acceptTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acceptgradeDataGridViewTextBoxColumn
            // 
            this.acceptgradeDataGridViewTextBoxColumn.DataPropertyName = "Accept_grade";
            this.acceptgradeDataGridViewTextBoxColumn.HeaderText = "Accept Grade";
            this.acceptgradeDataGridViewTextBoxColumn.Name = "acceptgradeDataGridViewTextBoxColumn";
            this.acceptgradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magMachineDataGridViewTextBoxColumn
            // 
            this.magMachineDataGridViewTextBoxColumn.DataPropertyName = "Mag Machine";
            this.magMachineDataGridViewTextBoxColumn.HeaderText = "Mag Machine";
            this.magMachineDataGridViewTextBoxColumn.Name = "magMachineDataGridViewTextBoxColumn";
            this.magMachineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MagListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Name = "MagListViewer";
            this.Text = "MagListViewer";
            this.Load += new System.EventHandler(this.MagListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource magListLogBindingSource;
        private ATIDeliveryDataSetTableAdapters.MagListLogTableAdapter magListLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn certDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInspectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAcceptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyRejectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magMachineDataGridViewTextBoxColumn;
    }
}