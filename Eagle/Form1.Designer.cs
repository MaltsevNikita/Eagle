namespace Eagle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUSERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUSEDATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERLXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERPASSWORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eagle202DataSet = new Eagle.Eagle202DataSet();
            this.uSERPASSWORDTableAdapter = new Eagle.Eagle202DataSetTableAdapters.USERPASSWORDTableAdapter();
            this.ToFind_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseFind_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadData_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPASSWORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagle202DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMDataGridViewTextBoxColumn,
            this.userUserDataGridViewTextBoxColumn,
            this.uSERPASSWORDDataGridViewTextBoxColumn,
            this.uSERTIMEDataGridViewTextBoxColumn,
            this.pUSERTIMEDataGridViewTextBoxColumn,
            this.pUSEDATADataGridViewTextBoxColumn,
            this.uSERLXDataGridViewTextBoxColumn,
            this.measureunitDataGridViewTextBoxColumn,
            this.contactpersonDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.scopeNameDataGridViewTextBoxColumn,
            this.dXDataGridViewTextBoxColumn,
            this.dYDataGridViewTextBoxColumn,
            this.dZDataGridViewTextBoxColumn,
            this.rXDataGridViewTextBoxColumn,
            this.rYDataGridViewTextBoxColumn,
            this.rZDataGridViewTextBoxColumn,
            this.sFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSERPASSWORDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 319);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nUMDataGridViewTextBoxColumn
            // 
            this.nUMDataGridViewTextBoxColumn.DataPropertyName = "NUM";
            this.nUMDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.nUMDataGridViewTextBoxColumn.Name = "nUMDataGridViewTextBoxColumn";
            // 
            // userUserDataGridViewTextBoxColumn
            // 
            this.userUserDataGridViewTextBoxColumn.DataPropertyName = "UserUser";
            this.userUserDataGridViewTextBoxColumn.HeaderText = "UserUser";
            this.userUserDataGridViewTextBoxColumn.Name = "userUserDataGridViewTextBoxColumn";
            // 
            // uSERPASSWORDDataGridViewTextBoxColumn
            // 
            this.uSERPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "USERPASSWORD";
            this.uSERPASSWORDDataGridViewTextBoxColumn.HeaderText = "USERPASSWORD";
            this.uSERPASSWORDDataGridViewTextBoxColumn.Name = "uSERPASSWORDDataGridViewTextBoxColumn";
            // 
            // uSERTIMEDataGridViewTextBoxColumn
            // 
            this.uSERTIMEDataGridViewTextBoxColumn.DataPropertyName = "USERTIME";
            this.uSERTIMEDataGridViewTextBoxColumn.HeaderText = "USERTIME";
            this.uSERTIMEDataGridViewTextBoxColumn.Name = "uSERTIMEDataGridViewTextBoxColumn";
            // 
            // pUSERTIMEDataGridViewTextBoxColumn
            // 
            this.pUSERTIMEDataGridViewTextBoxColumn.DataPropertyName = "PUSERTIME";
            this.pUSERTIMEDataGridViewTextBoxColumn.HeaderText = "PUSERTIME";
            this.pUSERTIMEDataGridViewTextBoxColumn.Name = "pUSERTIMEDataGridViewTextBoxColumn";
            // 
            // pUSEDATADataGridViewTextBoxColumn
            // 
            this.pUSEDATADataGridViewTextBoxColumn.DataPropertyName = "PUSEDATA";
            this.pUSEDATADataGridViewTextBoxColumn.HeaderText = "PUSEDATA";
            this.pUSEDATADataGridViewTextBoxColumn.Name = "pUSEDATADataGridViewTextBoxColumn";
            // 
            // uSERLXDataGridViewTextBoxColumn
            // 
            this.uSERLXDataGridViewTextBoxColumn.DataPropertyName = "USERLX";
            this.uSERLXDataGridViewTextBoxColumn.HeaderText = "USERLX";
            this.uSERLXDataGridViewTextBoxColumn.Name = "uSERLXDataGridViewTextBoxColumn";
            // 
            // measureunitDataGridViewTextBoxColumn
            // 
            this.measureunitDataGridViewTextBoxColumn.DataPropertyName = "Measure_unit";
            this.measureunitDataGridViewTextBoxColumn.HeaderText = "Measure_unit";
            this.measureunitDataGridViewTextBoxColumn.Name = "measureunitDataGridViewTextBoxColumn";
            // 
            // contactpersonDataGridViewTextBoxColumn
            // 
            this.contactpersonDataGridViewTextBoxColumn.DataPropertyName = "Contact_person";
            this.contactpersonDataGridViewTextBoxColumn.HeaderText = "Contact_person";
            this.contactpersonDataGridViewTextBoxColumn.Name = "contactpersonDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // scopeNameDataGridViewTextBoxColumn
            // 
            this.scopeNameDataGridViewTextBoxColumn.DataPropertyName = "ScopeName";
            this.scopeNameDataGridViewTextBoxColumn.HeaderText = "ScopeName";
            this.scopeNameDataGridViewTextBoxColumn.Name = "scopeNameDataGridViewTextBoxColumn";
            // 
            // dXDataGridViewTextBoxColumn
            // 
            this.dXDataGridViewTextBoxColumn.DataPropertyName = "DX";
            this.dXDataGridViewTextBoxColumn.HeaderText = "DX";
            this.dXDataGridViewTextBoxColumn.Name = "dXDataGridViewTextBoxColumn";
            // 
            // dYDataGridViewTextBoxColumn
            // 
            this.dYDataGridViewTextBoxColumn.DataPropertyName = "DY";
            this.dYDataGridViewTextBoxColumn.HeaderText = "DY";
            this.dYDataGridViewTextBoxColumn.Name = "dYDataGridViewTextBoxColumn";
            // 
            // dZDataGridViewTextBoxColumn
            // 
            this.dZDataGridViewTextBoxColumn.DataPropertyName = "DZ";
            this.dZDataGridViewTextBoxColumn.HeaderText = "DZ";
            this.dZDataGridViewTextBoxColumn.Name = "dZDataGridViewTextBoxColumn";
            // 
            // rXDataGridViewTextBoxColumn
            // 
            this.rXDataGridViewTextBoxColumn.DataPropertyName = "RX";
            this.rXDataGridViewTextBoxColumn.HeaderText = "RX";
            this.rXDataGridViewTextBoxColumn.Name = "rXDataGridViewTextBoxColumn";
            // 
            // rYDataGridViewTextBoxColumn
            // 
            this.rYDataGridViewTextBoxColumn.DataPropertyName = "RY";
            this.rYDataGridViewTextBoxColumn.HeaderText = "RY";
            this.rYDataGridViewTextBoxColumn.Name = "rYDataGridViewTextBoxColumn";
            // 
            // rZDataGridViewTextBoxColumn
            // 
            this.rZDataGridViewTextBoxColumn.DataPropertyName = "RZ";
            this.rZDataGridViewTextBoxColumn.HeaderText = "RZ";
            this.rZDataGridViewTextBoxColumn.Name = "rZDataGridViewTextBoxColumn";
            // 
            // sFDataGridViewTextBoxColumn
            // 
            this.sFDataGridViewTextBoxColumn.DataPropertyName = "SF";
            this.sFDataGridViewTextBoxColumn.HeaderText = "SF";
            this.sFDataGridViewTextBoxColumn.Name = "sFDataGridViewTextBoxColumn";
            // 
            // uSERPASSWORDBindingSource
            // 
            this.uSERPASSWORDBindingSource.DataMember = "USERPASSWORD";
            this.uSERPASSWORDBindingSource.DataSource = this.eagle202DataSet;
            // 
            // eagle202DataSet
            // 
            this.eagle202DataSet.DataSetName = "Eagle202DataSet";
            this.eagle202DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERPASSWORDTableAdapter
            // 
            this.uSERPASSWORDTableAdapter.ClearBeforeFill = true;
            // 
            // ToFind_textBox
            // 
            this.ToFind_textBox.Location = new System.Drawing.Point(270, 12);
            this.ToFind_textBox.Name = "ToFind_textBox";
            this.ToFind_textBox.Size = new System.Drawing.Size(100, 20);
            this.ToFind_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Найти:";
            // 
            // BaseFind_button
            // 
            this.BaseFind_button.Location = new System.Drawing.Point(226, 43);
            this.BaseFind_button.Name = "BaseFind_button";
            this.BaseFind_button.Size = new System.Drawing.Size(144, 23);
            this.BaseFind_button.TabIndex = 8;
            this.BaseFind_button.Text = "Найти в базе";
            this.BaseFind_button.UseVisualStyleBackColor = true;
            this.BaseFind_button.Click += new System.EventHandler(this.BaseFind_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сохранить изменения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Загрузить изменения";
            // 
            // LoadData_button
            // 
            this.LoadData_button.Location = new System.Drawing.Point(399, 43);
            this.LoadData_button.Name = "LoadData_button";
            this.LoadData_button.Size = new System.Drawing.Size(86, 23);
            this.LoadData_button.TabIndex = 11;
            this.LoadData_button.Text = "Указать базу";
            this.LoadData_button.UseVisualStyleBackColor = true;
            this.LoadData_button.Click += new System.EventHandler(this.LoadData_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 416);
            this.Controls.Add(this.LoadData_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BaseFind_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToFind_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "NRS Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERPASSWORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagle202DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Eagle202DataSet eagle202DataSet;
        private System.Windows.Forms.BindingSource uSERPASSWORDBindingSource;
        private Eagle202DataSetTableAdapters.USERPASSWORDTableAdapter uSERPASSWORDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUSERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUSEDATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERLXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ToFind_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BaseFind_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoadData_button;
    }
}

