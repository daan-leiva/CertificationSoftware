namespace ATICertViewer
{
    partial class D2060RListViewer
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalShortsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particleConc14MlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availLightMin100FCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magD2060RProcessControlLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.viewEditButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.magD2060RProcessControlLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.MagD2060RProcessControlLogTableAdapter();
            this.enableDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inspectorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magD2060RProcessControlLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.availLightMin100FCDataGridViewTextBoxColumn,
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn,
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magD2060RProcessControlLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // availLightMin100FCDataGridViewTextBoxColumn
            // 
            this.availLightMin100FCDataGridViewTextBoxColumn.DataPropertyName = "Avail Light Min 100FC";
            this.availLightMin100FCDataGridViewTextBoxColumn.HeaderText = "Avail Light Min 100FC";
            this.availLightMin100FCDataGridViewTextBoxColumn.Name = "availLightMin100FCDataGridViewTextBoxColumn";
            this.availLightMin100FCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn
            // 
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.DataPropertyName = "UV Ambient Light / Ambient White Light Max 2 FC";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.HeaderText = "UV Ambient Light / Ambient White Light Max 2 FC";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.Name = "uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn";
            this.uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn
            // 
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn.DataPropertyName = "AS5282 QQI @ 1000 amps (5 holes)";
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn.HeaderText = "AS5282 QQI @ 1000 amps (5 holes)";
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn.Name = "aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn";
            this.aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magD2060RProcessControlLogBindingSource
            // 
            this.magD2060RProcessControlLogBindingSource.DataMember = "MagD2060RProcessControlLog";
            this.magD2060RProcessControlLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(989, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(210, 381);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(117, 381);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 2;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(24, 381);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "D2060 Logs";
            // 
            // magD2060RProcessControlLogTableAdapter
            // 
            this.magD2060RProcessControlLogTableAdapter.ClearBeforeFill = true;
            // 
            // enableDateFilterCheckBox
            // 
            this.enableDateFilterCheckBox.AutoSize = true;
            this.enableDateFilterCheckBox.Location = new System.Drawing.Point(292, 93);
            this.enableDateFilterCheckBox.Name = "enableDateFilterCheckBox";
            this.enableDateFilterCheckBox.Size = new System.Drawing.Size(105, 17);
            this.enableDateFilterCheckBox.TabIndex = 24;
            this.enableDateFilterCheckBox.Text = "Enable date filter";
            this.enableDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date:";
            // 
            // inspectorTextBox
            // 
            this.inspectorTextBox.Location = new System.Drawing.Point(85, 116);
            this.inspectorTextBox.Name = "inspectorTextBox";
            this.inspectorTextBox.Size = new System.Drawing.Size(200, 20);
            this.inspectorTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Inspector:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(85, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // D2060RListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 418);
            this.Controls.Add(this.enableDateFilterCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inspectorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "D2060RListViewer";
            this.Text = "D2060ListViewer";
            this.Load += new System.EventHandler(this.D2060RListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magD2060RProcessControlLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button viewEditButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label2;
        private ATIDeliveryDataSet aTIDeliveryDataSet;
        private System.Windows.Forms.BindingSource magD2060RProcessControlLogBindingSource;
        private ATIDeliveryDataSetTableAdapters.MagD2060RProcessControlLogTableAdapter magD2060RProcessControlLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalShortsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particleConc14MlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacklightMin1000uw15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availLightMin100FCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uVAmbientLightAmbientWhiteLightMax2FCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aS5282QQI1000Amps5HolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox enableDateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inspectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
    }
}