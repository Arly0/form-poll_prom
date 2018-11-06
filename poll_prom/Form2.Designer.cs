namespace poll_prom
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.promBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new poll_prom.Database1DataSet();
            this.promTableAdapter = new poll_prom.Database1DataSetTableAdapters.promTableAdapter();
            this.promBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new poll_prom.Database1DataSet1();
            this.promTableAdapter1 = new poll_prom.Database1DataSet1TableAdapters.promTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet2 = new poll_prom.Database1DataSet();
            this.promBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sityofschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // promBindingSource
            // 
            this.promBindingSource.DataMember = "prom";
            this.promBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promTableAdapter
            // 
            this.promTableAdapter.ClearBeforeFill = true;
            // 
            // promBindingSource1
            // 
            this.promBindingSource1.DataMember = "prom";
            this.promBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promTableAdapter1
            // 
            this.promTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnumberDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.datebirthDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.oblDataGridViewTextBoxColumn,
            this.sityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.numhouseDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.schoolnameDataGridViewTextBoxColumn,
            this.numberschoolDataGridViewTextBoxColumn,
            this.sityofschoolDataGridViewTextBoxColumn,
            this.dateendschoolDataGridViewTextBoxColumn,
            this.prizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.promBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promBindingSource2
            // 
            this.promBindingSource2.DataMember = "prom";
            this.promBindingSource2.DataSource = this.database1DataSet2;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // datebirthDataGridViewTextBoxColumn
            // 
            this.datebirthDataGridViewTextBoxColumn.DataPropertyName = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.HeaderText = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.Name = "datebirthDataGridViewTextBoxColumn";
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // oblDataGridViewTextBoxColumn
            // 
            this.oblDataGridViewTextBoxColumn.DataPropertyName = "obl";
            this.oblDataGridViewTextBoxColumn.HeaderText = "obl";
            this.oblDataGridViewTextBoxColumn.Name = "oblDataGridViewTextBoxColumn";
            // 
            // sityDataGridViewTextBoxColumn
            // 
            this.sityDataGridViewTextBoxColumn.DataPropertyName = "sity";
            this.sityDataGridViewTextBoxColumn.HeaderText = "sity";
            this.sityDataGridViewTextBoxColumn.Name = "sityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // numhouseDataGridViewTextBoxColumn
            // 
            this.numhouseDataGridViewTextBoxColumn.DataPropertyName = "num_house";
            this.numhouseDataGridViewTextBoxColumn.HeaderText = "num_house";
            this.numhouseDataGridViewTextBoxColumn.Name = "numhouseDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // schoolnameDataGridViewTextBoxColumn
            // 
            this.schoolnameDataGridViewTextBoxColumn.DataPropertyName = "school_name";
            this.schoolnameDataGridViewTextBoxColumn.HeaderText = "school_name";
            this.schoolnameDataGridViewTextBoxColumn.Name = "schoolnameDataGridViewTextBoxColumn";
            // 
            // numberschoolDataGridViewTextBoxColumn
            // 
            this.numberschoolDataGridViewTextBoxColumn.DataPropertyName = "number_school";
            this.numberschoolDataGridViewTextBoxColumn.HeaderText = "number_school";
            this.numberschoolDataGridViewTextBoxColumn.Name = "numberschoolDataGridViewTextBoxColumn";
            // 
            // sityofschoolDataGridViewTextBoxColumn
            // 
            this.sityofschoolDataGridViewTextBoxColumn.DataPropertyName = "sity_of_school";
            this.sityofschoolDataGridViewTextBoxColumn.HeaderText = "sity_of_school";
            this.sityofschoolDataGridViewTextBoxColumn.Name = "sityofschoolDataGridViewTextBoxColumn";
            // 
            // dateendschoolDataGridViewTextBoxColumn
            // 
            this.dateendschoolDataGridViewTextBoxColumn.DataPropertyName = "date_end_school";
            this.dateendschoolDataGridViewTextBoxColumn.HeaderText = "date_end_school";
            this.dateendschoolDataGridViewTextBoxColumn.Name = "dateendschoolDataGridViewTextBoxColumn";
            // 
            // prizeDataGridViewTextBoxColumn
            // 
            this.prizeDataGridViewTextBoxColumn.DataPropertyName = "prize";
            this.prizeDataGridViewTextBoxColumn.HeaderText = "prize";
            this.prizeDataGridViewTextBoxColumn.Name = "prizeDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource promBindingSource;
        private Database1DataSetTableAdapters.promTableAdapter promTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource promBindingSource1;
        private Database1DataSet1TableAdapters.promTableAdapter promTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.BindingSource promBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sityofschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prizeDataGridViewTextBoxColumn;
    }
}