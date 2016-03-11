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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalShortsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particleConc14MlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availLightMin100FCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holesDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magTaq525ProcessControlLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTIDeliveryDataSet = new ATICertViewer.ATIDeliveryDataSet();
            this.magTaq525ProcessControlLogTableAdapter = new ATICertViewer.ATIDeliveryDataSetTableAdapters.MagTaq525ProcessControlLogTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.inspectorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enableDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magTaq525ProcessControlLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "TAQ Logs";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1150, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(227, 371);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewEditButton
            // 
            this.viewEditButton.Location = new System.Drawing.Point(134, 371);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(75, 23);
            this.viewEditButton.TabIndex = 3;
            this.viewEditButton.Text = "View/Edit";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Click += new System.EventHandler(this.viewEditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(41, 371);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 2;
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
            this.availLightMin100FCDataGridViewTextBoxColumn,
            this.holesDataGridViewTextBoxColumn,
            this.holesDataGridViewTextBoxColumn1,
            this.holesDataGridViewTextBoxColumn2,
            this.holesDataGridViewTextBoxColumn3,
            this.holesDataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.magTaq525ProcessControlLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 211);
            this.dataGridView1.TabIndex = 1;
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
            // magTaq525ProcessControlLogBindingSource
            // 
            this.magTaq525ProcessControlLogBindingSource.DataMember = "MagTaq525ProcessControlLog";
            this.magTaq525ProcessControlLogBindingSource.DataSource = this.aTIDeliveryDataSet;
            // 
            // aTIDeliveryDataSet
            // 
            this.aTIDeliveryDataSet.DataSetName = "ATIDeliveryDataSet";
            this.aTIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magTaq525ProcessControlLogTableAdapter
            // 
            this.magTaq525ProcessControlLogTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(69, 43);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // inspectorTextBox
            // 
            this.inspectorTextBox.Location = new System.Drawing.Point(69, 95);
            this.inspectorTextBox.Name = "inspectorTextBox";
            this.inspectorTextBox.Size = new System.Drawing.Size(200, 20);
            this.inspectorTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inspector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // enableDateFilterCheckBox
            // 
            this.enableDateFilterCheckBox.AutoSize = true;
            this.enableDateFilterCheckBox.Location = new System.Drawing.Point(276, 72);
            this.enableDateFilterCheckBox.Name = "enableDateFilterCheckBox";
            this.enableDateFilterCheckBox.Size = new System.Drawing.Size(105, 17);
            this.enableDateFilterCheckBox.TabIndex = 12;
            this.enableDateFilterCheckBox.Text = "Enable date filter";
            this.enableDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // TAQ525ListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 406);
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
            this.Name = "TAQ525ListViewer";
            this.Text = "TAQ525ListViewer";
            this.Load += new System.EventHandler(this.TAQ525ListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magTaq525ProcessControlLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTIDeliveryDataSet)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox inspectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox enableDateFilterCheckBox;
    }
}