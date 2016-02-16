namespace ATICertViewer
{
    partial class TAQ525ListViewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.viewEditButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.magTaq525ProcessControlLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magTaq525ProcessControlLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.MagTaq525ProcessControlLogTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalShortsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particleConc14MlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blacklightMin1000uw15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availLightMin100FCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magTaq525ProcessControlLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "TAQ Logs";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1150, 294);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(227, 294);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(134, 294);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 20;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(41, 294);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 19;
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
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.internalShortsDataGridViewTextBoxColumn,
            this.particleConc14MlDataGridViewTextBoxColumn,
            this.blacklightMin1000uw15DataGridViewTextBoxColumn,
            this.availLightMin100FCDataGridViewTextBoxColumn,
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn,
            this.holesDataGridViewTextBoxColumn,
            this.holesDataGridViewTextBoxColumn1,
            this.holesDataGridViewTextBoxColumn2,
            this.holesDataGridViewTextBoxColumn3,
            this.holesDataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.magTaq525ProcessControlLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 211);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magTaq525ProcessControlLogBindingSource
            // 
            this.magTaq525ProcessControlLogBindingSource.DataMember = "MagTaq525ProcessControlLog";
            this.magTaq525ProcessControlLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // magTaq525ProcessControlLogTableAdapter
            // 
            this.magTaq525ProcessControlLogTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internalShortsDataGridViewTextBoxColumn
            // 
            this.internalShortsDataGridViewTextBoxColumn.DataPropertyName = "Internal Shorts";
            this.internalShortsDataGridViewTextBoxColumn.HeaderText = "Internal Shorts";
            this.internalShortsDataGridViewTextBoxColumn.Name = "internalShortsDataGridViewTextBoxColumn";
            this.internalShortsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // particleConc14MlDataGridViewTextBoxColumn
            // 
            this.particleConc14MlDataGridViewTextBoxColumn.DataPropertyName = "Particle Conc 1-4 ml";
            this.particleConc14MlDataGridViewTextBoxColumn.HeaderText = "Particle Conc 1-4 ml";
            this.particleConc14MlDataGridViewTextBoxColumn.Name = "particleConc14MlDataGridViewTextBoxColumn";
            this.particleConc14MlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blacklightMin1000uw15DataGridViewTextBoxColumn
            // 
            this.blacklightMin1000uw15DataGridViewTextBoxColumn.DataPropertyName = "Blacklight Min 1000uw@ 15\"";
            this.blacklightMin1000uw15DataGridViewTextBoxColumn.HeaderText = "Blacklight Min 1000uw@ 15\"";
            this.blacklightMin1000uw15DataGridViewTextBoxColumn.Name = "blacklightMin1000uw15DataGridViewTextBoxColumn";
            this.blacklightMin1000uw15DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availLightMin100FCDataGridViewTextBoxColumn
            // 
            this.availLightMin100FCDataGridViewTextBoxColumn.DataPropertyName = "Avail Light Min 100FC";
            this.availLightMin100FCDataGridViewTextBoxColumn.HeaderText = "Avail Light Min 100FC";
            this.availLightMin100FCDataGridViewTextBoxColumn.Name = "availLightMin100FCDataGridViewTextBoxColumn";
            this.availLightMin100FCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn
            // 
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.DataPropertyName = "UV Ambient Light / Ambient White Light Max 2FC";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.HeaderText = "UV Ambient Light / Ambient White Light Max 2FC";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.Name = "uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holesDataGridViewTextBoxColumn
            // 
            this.holesDataGridViewTextBoxColumn.DataPropertyName = "500 (3 holes)";
            this.holesDataGridViewTextBoxColumn.HeaderText = "500 (3 holes)";
            this.holesDataGridViewTextBoxColumn.Name = "holesDataGridViewTextBoxColumn";
            this.holesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holesDataGridViewTextBoxColumn1
            // 
            this.holesDataGridViewTextBoxColumn1.DataPropertyName = "1000 (5 holes)";
            this.holesDataGridViewTextBoxColumn1.HeaderText = "1000 (5 holes)";
            this.holesDataGridViewTextBoxColumn1.Name = "holesDataGridViewTextBoxColumn1";
            this.holesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // holesDataGridViewTextBoxColumn2
            // 
            this.holesDataGridViewTextBoxColumn2.DataPropertyName = "1500 (6 holes)";
            this.holesDataGridViewTextBoxColumn2.HeaderText = "1500 (6 holes)";
            this.holesDataGridViewTextBoxColumn2.Name = "holesDataGridViewTextBoxColumn2";
            this.holesDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // holesDataGridViewTextBoxColumn3
            // 
            this.holesDataGridViewTextBoxColumn3.DataPropertyName = "2500 (7 holes)";
            this.holesDataGridViewTextBoxColumn3.HeaderText = "2500 (7 holes)";
            this.holesDataGridViewTextBoxColumn3.Name = "holesDataGridViewTextBoxColumn3";
            this.holesDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // holesDataGridViewTextBoxColumn4
            // 
            this.holesDataGridViewTextBoxColumn4.DataPropertyName = "3500 (9 holes)";
            this.holesDataGridViewTextBoxColumn4.HeaderText = "3500 (9 holes)";
            this.holesDataGridViewTextBoxColumn4.Name = "holesDataGridViewTextBoxColumn4";
            this.holesDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // TAQ525ListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TAQ525ListViewer";
            this.Text = "TAQ525ListViewer";
            this.Load += new System.EventHandler(this.TAQ525ListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magTaq525ProcessControlLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button viewEditButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ATIDeliveryDataSet aTIDeliveryDataSet;
        private System.Windows.Forms.BindingSource magTaq525ProcessControlLogBindingSource;
        private ATIDeliveryDataSetTableAdapters.MagTaq525ProcessControlLogTableAdapter magTaq525ProcessControlLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalShortsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particleConc14MlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacklightMin1000uw15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availLightMin100FCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn holesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn holesDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn holesDataGridViewTextBoxColumn4;
    }
}