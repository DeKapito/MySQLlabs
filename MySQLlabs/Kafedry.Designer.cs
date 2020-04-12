namespace MySQLlabs
{
    partial class Kafedry
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
            this.kafedryGridView = new System.Windows.Forms.DataGridView();
            this.idkafedryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvakafedryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roztashuvannyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kafedryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konferentsiyiDataSet = new MySQLlabs.konferentsiyiDataSet();
            this.konferentsiyiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kafedryTableAdapter = new MySQLlabs.konferentsiyiDataSetTableAdapters.kafedryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.idKafedryBox = new System.Windows.Forms.TextBox();
            this.nazvaKavedryBox = new System.Windows.Forms.TextBox();
            this.roztashuvannyaBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kafedryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kafedryGridView
            // 
            this.kafedryGridView.AllowUserToAddRows = false;
            this.kafedryGridView.AllowUserToDeleteRows = false;
            this.kafedryGridView.AutoGenerateColumns = false;
            this.kafedryGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kafedryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kafedryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkafedryDataGridViewTextBoxColumn,
            this.nazvakafedryDataGridViewTextBoxColumn,
            this.roztashuvannyaDataGridViewTextBoxColumn});
            this.kafedryGridView.DataSource = this.kafedryBindingSource;
            this.kafedryGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kafedryGridView.Location = new System.Drawing.Point(-2, 3);
            this.kafedryGridView.MultiSelect = false;
            this.kafedryGridView.Name = "kafedryGridView";
            this.kafedryGridView.RowHeadersWidth = 60;
            this.kafedryGridView.RowTemplate.Height = 24;
            this.kafedryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kafedryGridView.Size = new System.Drawing.Size(685, 336);
            this.kafedryGridView.TabIndex = 0;
            this.kafedryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kafedryGridView_CellClick);
            // 
            // idkafedryDataGridViewTextBoxColumn
            // 
            this.idkafedryDataGridViewTextBoxColumn.DataPropertyName = "id_kafedry";
            this.idkafedryDataGridViewTextBoxColumn.HeaderText = "Код кафедри";
            this.idkafedryDataGridViewTextBoxColumn.Name = "idkafedryDataGridViewTextBoxColumn";
            // 
            // nazvakafedryDataGridViewTextBoxColumn
            // 
            this.nazvakafedryDataGridViewTextBoxColumn.DataPropertyName = "nazva_kafedry";
            this.nazvakafedryDataGridViewTextBoxColumn.HeaderText = "Назва кафедри";
            this.nazvakafedryDataGridViewTextBoxColumn.Name = "nazvakafedryDataGridViewTextBoxColumn";
            this.nazvakafedryDataGridViewTextBoxColumn.Width = 300;
            // 
            // roztashuvannyaDataGridViewTextBoxColumn
            // 
            this.roztashuvannyaDataGridViewTextBoxColumn.DataPropertyName = "roztashuvannya";
            this.roztashuvannyaDataGridViewTextBoxColumn.HeaderText = "Розташування";
            this.roztashuvannyaDataGridViewTextBoxColumn.Name = "roztashuvannyaDataGridViewTextBoxColumn";
            this.roztashuvannyaDataGridViewTextBoxColumn.Width = 220;
            // 
            // kafedryBindingSource
            // 
            this.kafedryBindingSource.DataMember = "kafedry";
            this.kafedryBindingSource.DataSource = this.konferentsiyiDataSet;
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
            // kafedryTableAdapter
            // 
            this.kafedryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код кафедри:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва кафедри:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Розташування:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(37, 445);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(157, 40);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(200, 445);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(159, 40);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(518, 445);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(147, 40);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Видалити";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // idKafedryBox
            // 
            this.idKafedryBox.Location = new System.Drawing.Point(146, 346);
            this.idKafedryBox.Name = "idKafedryBox";
            this.idKafedryBox.ReadOnly = true;
            this.idKafedryBox.Size = new System.Drawing.Size(100, 22);
            this.idKafedryBox.TabIndex = 8;
            // 
            // nazvaKavedryBox
            // 
            this.nazvaKavedryBox.Location = new System.Drawing.Point(146, 374);
            this.nazvaKavedryBox.Name = "nazvaKavedryBox";
            this.nazvaKavedryBox.Size = new System.Drawing.Size(338, 22);
            this.nazvaKavedryBox.TabIndex = 9;
            // 
            // roztashuvannyaBox
            // 
            this.roztashuvannyaBox.Location = new System.Drawing.Point(146, 402);
            this.roztashuvannyaBox.Name = "roztashuvannyaBox";
            this.roztashuvannyaBox.Size = new System.Drawing.Size(483, 22);
            this.roztashuvannyaBox.TabIndex = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(200, 491);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(312, 50);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Закрити";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(365, 445);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(147, 40);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // Kafedry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 553);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.roztashuvannyaBox);
            this.Controls.Add(this.nazvaKavedryBox);
            this.Controls.Add(this.idKafedryBox);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kafedryGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kafedry";
            this.Text = "Kafedry";
            this.Load += new System.EventHandler(this.Kafedry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kafedryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konferentsiyiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kafedryGridView;
        private System.Windows.Forms.BindingSource konferentsiyiDataSetBindingSource;
        private konferentsiyiDataSet konferentsiyiDataSet;
        private System.Windows.Forms.BindingSource kafedryBindingSource;
        private konferentsiyiDataSetTableAdapters.kafedryTableAdapter kafedryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkafedryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvakafedryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roztashuvannyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox idKafedryBox;
        private System.Windows.Forms.TextBox nazvaKavedryBox;
        private System.Windows.Forms.TextBox roztashuvannyaBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button editBtn;
    }
}