namespace ATICertViewer
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
            this.certnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyinspectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magListLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.magListLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.MagListLogTableAdapter();
            this.magListLogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enableDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectorTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.partNoTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.certNoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(977, 417);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(198, 417);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(105, 417);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 2;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 417);
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
            this.certnumDataGridViewTextBoxColumn,
            this.partnumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.jobnumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.qtyinspectedDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magListLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // certnumDataGridViewTextBoxColumn
            // 
            this.certnumDataGridViewTextBoxColumn.DataPropertyName = "cert_num";
            this.certnumDataGridViewTextBoxColumn.HeaderText = "Cert Num";
            this.certnumDataGridViewTextBoxColumn.Name = "certnumDataGridViewTextBoxColumn";
            this.certnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partnumDataGridViewTextBoxColumn
            // 
            this.partnumDataGridViewTextBoxColumn.DataPropertyName = "part_num";
            this.partnumDataGridViewTextBoxColumn.HeaderText = "Part Num";
            this.partnumDataGridViewTextBoxColumn.Name = "partnumDataGridViewTextBoxColumn";
            this.partnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rev";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rev";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "material_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Material Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // jobnumDataGridViewTextBoxColumn
            // 
            this.jobnumDataGridViewTextBoxColumn.DataPropertyName = "job_num";
            this.jobnumDataGridViewTextBoxColumn.HeaderText = "Job Num";
            this.jobnumDataGridViewTextBoxColumn.Name = "jobnumDataGridViewTextBoxColumn";
            this.jobnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // qtyinspectedDataGridViewTextBoxColumn
            // 
            this.qtyinspectedDataGridViewTextBoxColumn.DataPropertyName = "qty_inspected";
            this.qtyinspectedDataGridViewTextBoxColumn.HeaderText = "Qty Inspected";
            this.qtyinspectedDataGridViewTextBoxColumn.Name = "qtyinspectedDataGridViewTextBoxColumn";
            this.qtyinspectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magListLogBindingSource
            // 
            this.magListLogBindingSource.DataMember = "MagListLog";
            this.magListLogBindingSource.DataSource = this.aTIDeliveryDataSet;
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
            this.label2.Location = new System.Drawing.Point(449, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mag Certs";
            // 
            // magListLogTableAdapter
            // 
            this.magListLogTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // enableDateFilterCheckBox
            // 
            this.enableDateFilterCheckBox.AutoSize = true;
            this.enableDateFilterCheckBox.Location = new System.Drawing.Point(293, 157);
            this.enableDateFilterCheckBox.Name = "enableDateFilterCheckBox";
            this.enableDateFilterCheckBox.Size = new System.Drawing.Size(105, 17);
            this.enableDateFilterCheckBox.TabIndex = 38;
            this.enableDateFilterCheckBox.Text = "Enable date filter";
            this.enableDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectorTextBox
            // 
            this.inspectorTextBox.Location = new System.Drawing.Point(79, 133);
            this.inspectorTextBox.Name = "inspectorTextBox";
            this.inspectorTextBox.Size = new System.Drawing.Size(204, 20);
            this.inspectorTextBox.TabIndex = 37;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(79, 111);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(204, 20);
            this.jobTextBox.TabIndex = 36;
            // 
            // partNoTextBox
            // 
            this.partNoTextBox.Location = new System.Drawing.Point(79, 89);
            this.partNoTextBox.Name = "partNoTextBox";
            this.partNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.partNoTextBox.TabIndex = 35;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(79, 67);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(204, 20);
            this.customerTextBox.TabIndex = 34;
            // 
            // certNoTextBox
            // 
            this.certNoTextBox.Location = new System.Drawing.Point(79, 45);
            this.certNoTextBox.Name = "certNoTextBox";
            this.certNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.certNoTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Inspector:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Job:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Part No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cert No:";
            // 
            // MagListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 453);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.enableDateFilterCheckBox);
            this.Controls.Add(this.inspectorTextBox);
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
            this.Name = "MagListViewer";
            this.Text = "MagListViewer";
            this.Load += new System.EventHandler(this.MagListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magListLogBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource magListLogBindingSource2;
        private System.Windows.Forms.BindingSource magListLogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn certnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyinspectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox enableDateFilterCheckBox;
        private System.Windows.Forms.TextBox inspectorTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox partNoTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox certNoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}