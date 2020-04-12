namespace MySQLlabs
{
    partial class MistsyaProzhyvannya
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
            this.konferentsiyiDataSet = new MySQLlabs.konferentsiyiDataSet();
            this.konferentsiyiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mistsyaprozhyvannyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mistsya_prozhyvannyaTableAdapter = new MySQLlabs.konferentsiyiDataSetTableAdapters.mistsya_prozhyvannyaTableAdapter();
            this.idmistsyaprozhyvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typprozhyvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaprozhyvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonprozhyvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mistsyaprozhyvannyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmistsyaprozhyvannyaDataGridViewTextBoxColumn,
            this.typprozhyvannyaDataGridViewTextBoxColumn,
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn,
            this.adresaprozhyvannyaDataGridViewTextBoxColumn,
            this.telefonprozhyvannyaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mistsyaprozhyvannyaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // konferentsiyiDataSet
            // 
            this.konferentsiyiDataSet.DataSetName = "konferentsiyiDataSet";
            this.konferentsiyiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konferentsiyiDataSetBindingSource
            // 
            this.konferentsiyiDataSetBindingSource.DataSource = this.konferentsiyiDataSet;
            this.konferentsiyiDataSetBindingSource.Position = 0;
            // 
            // mistsyaprozhyvannyaBindingSource
            // 
            this.mistsyaprozhyvannyaBindingSource.DataMember = "mistsya_prozhyvannya";
            this.mistsyaprozhyvannyaBindingSource.DataSource = this.konferentsiyiDataSetBindingSource;
            // 
            // mistsya_prozhyvannyaTableAdapter
            // 
            this.mistsya_prozhyvannyaTableAdapter.ClearBeforeFill = true;
            // 
            // idmistsyaprozhyvannyaDataGridViewTextBoxColumn
            // 
            this.idmistsyaprozhyvannyaDataGridViewTextBoxColumn.DataPropertyName = "id_mistsya_prozhyvannya";
            this.idmistsyaprozhyvannyaDataGridViewTextBoxColumn.HeaderText = "Код місця";
            this.idmistsyaprozhyvannyaDataGridViewTextBoxColumn.Name = "idmistsyaprozhyvannyaDataGridViewTextBoxColumn";
            // 
            // typprozhyvannyaDataGridViewTextBoxColumn
            // 
            this.typprozhyvannyaDataGridViewTextBoxColumn.DataPropertyName = "typ_prozhyvannya";
            this.typprozhyvannyaDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typprozhyvannyaDataGridViewTextBoxColumn.Name = "typprozhyvannyaDataGridViewTextBoxColumn";
            this.typprozhyvannyaDataGridViewTextBoxColumn.Width = 200;
            // 
            // nazvaprozhyvannyaDataGridViewTextBoxColumn
            // 
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn.DataPropertyName = "nazva_prozhyvannya";
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn.Name = "nazvaprozhyvannyaDataGridViewTextBoxColumn";
            this.nazvaprozhyvannyaDataGridViewTextBoxColumn.Width = 200;
            // 
            // adresaprozhyvannyaDataGridViewTextBoxColumn
            // 
            this.adresaprozhyvannyaDataGridViewTextBoxColumn.DataPropertyName = "adresa_prozhyvannya";
            this.adresaprozhyvannyaDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.adresaprozhyvannyaDataGridViewTextBoxColumn.Name = "adresaprozhyvannyaDataGridViewTextBoxColumn";
            this.adresaprozhyvannyaDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonprozhyvannyaDataGridViewTextBoxColumn
            // 
            this.telefonprozhyvannyaDataGridViewTextBoxColumn.DataPropertyName = "telefon_prozhyvannya";
            this.telefonprozhyvannyaDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonprozhyvannyaDataGridViewTextBoxColumn.Name = "telefonprozhyvannyaDataGridViewTextBoxColumn";
            this.telefonprozhyvannyaDataGridViewTextBoxColumn.Width = 200;
            // 
            // MistsyaProzhyvannya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 542);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MistsyaProzhyvannya";
            this.Text = "MistsyaProzhyvannya";
            this.Load += new System.EventHandler(this.MistsyaProzhyvannya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mistsyaprozhyvannyaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource konferentsiyiDataSetBindingSource;
        private konferentsiyiDataSet konferentsiyiDataSet;
        private System.Windows.Forms.BindingSource mistsyaprozhyvannyaBindingSource;
        private konferentsiyiDataSetTableAdapters.mistsya_prozhyvannyaTableAdapter mistsya_prozhyvannyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmistsyaprozhyvannyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typprozhyvannyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaprozhyvannyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaprozhyvannyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonprozhyvannyaDataGridViewTextBoxColumn;
    }
}