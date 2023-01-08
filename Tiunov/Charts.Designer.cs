
namespace Tiunov
{
    partial class Charts
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
            this.sgrafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunov_BDDataSet = new Tiunov.Tiunov_BDDataSet();
            this.grafikiTableAdapter = new Tiunov.Tiunov_BDDataSetTableAdapters.GrafikiTableAdapter();
            this.Sgraf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grafik = new System.Windows.Forms.TextBox();
            this.GbtnClear = new System.Windows.Forms.Button();
            this.GbtnDelete = new System.Windows.Forms.Button();
            this.GbtnUpdate = new System.Windows.Forms.Button();
            this.GbtnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunov_BDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sgrafDataGridViewTextBoxColumn,
            this.grafikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.grafikiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // sgrafDataGridViewTextBoxColumn
            // 
            this.sgrafDataGridViewTextBoxColumn.DataPropertyName = "Sgraf";
            this.sgrafDataGridViewTextBoxColumn.HeaderText = "Sgraf";
            this.sgrafDataGridViewTextBoxColumn.Name = "sgrafDataGridViewTextBoxColumn";
            // 
            // grafikDataGridViewTextBoxColumn
            // 
            this.grafikDataGridViewTextBoxColumn.DataPropertyName = "Grafik";
            this.grafikDataGridViewTextBoxColumn.HeaderText = "Grafik";
            this.grafikDataGridViewTextBoxColumn.Name = "grafikDataGridViewTextBoxColumn";
            // 
            // grafikiBindingSource
            // 
            this.grafikiBindingSource.DataMember = "Grafiki";
            this.grafikiBindingSource.DataSource = this.tiunov_BDDataSet;
            // 
            // tiunov_BDDataSet
            // 
            this.tiunov_BDDataSet.DataSetName = "Tiunov_BDDataSet";
            this.tiunov_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafikiTableAdapter
            // 
            this.grafikiTableAdapter.ClearBeforeFill = true;
            // 
            // Sgraf
            // 
            this.Sgraf.Location = new System.Drawing.Point(93, 44);
            this.Sgraf.Name = "Sgraf";
            this.Sgraf.Size = new System.Drawing.Size(100, 20);
            this.Sgraf.TabIndex = 42;
            this.Sgraf.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Наименование";
            // 
            // Grafik
            // 
            this.Grafik.Location = new System.Drawing.Point(208, 44);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(100, 20);
            this.Grafik.TabIndex = 40;
            // 
            // GbtnClear
            // 
            this.GbtnClear.Location = new System.Drawing.Point(93, 70);
            this.GbtnClear.Name = "GbtnClear";
            this.GbtnClear.Size = new System.Drawing.Size(75, 23);
            this.GbtnClear.TabIndex = 39;
            this.GbtnClear.Text = "Очистить";
            this.GbtnClear.UseVisualStyleBackColor = true;
            this.GbtnClear.Click += new System.EventHandler(this.GbtnClear_Click);
            // 
            // GbtnDelete
            // 
            this.GbtnDelete.Location = new System.Drawing.Point(12, 70);
            this.GbtnDelete.Name = "GbtnDelete";
            this.GbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.GbtnDelete.TabIndex = 38;
            this.GbtnDelete.Text = "Удалить";
            this.GbtnDelete.UseVisualStyleBackColor = true;
            this.GbtnDelete.Click += new System.EventHandler(this.GbtnDelete_Click);
            // 
            // GbtnUpdate
            // 
            this.GbtnUpdate.Location = new System.Drawing.Point(12, 41);
            this.GbtnUpdate.Name = "GbtnUpdate";
            this.GbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.GbtnUpdate.TabIndex = 37;
            this.GbtnUpdate.Text = "Изменить";
            this.GbtnUpdate.UseVisualStyleBackColor = true;
            this.GbtnUpdate.Click += new System.EventHandler(this.GbtnUpdate_Click);
            // 
            // GbtnInsert
            // 
            this.GbtnInsert.Location = new System.Drawing.Point(12, 12);
            this.GbtnInsert.Name = "GbtnInsert";
            this.GbtnInsert.Size = new System.Drawing.Size(75, 23);
            this.GbtnInsert.TabIndex = 36;
            this.GbtnInsert.Text = "Добавить";
            this.GbtnInsert.UseVisualStyleBackColor = true;
            this.GbtnInsert.Click += new System.EventHandler(this.GbtnInsert_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sgraf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grafik);
            this.Controls.Add(this.GbtnClear);
            this.Controls.Add(this.GbtnDelete);
            this.Controls.Add(this.GbtnUpdate);
            this.Controls.Add(this.GbtnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Charts";
            this.Text = "Графики работы";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunov_BDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tiunov_BDDataSet tiunov_BDDataSet;
        private System.Windows.Forms.BindingSource grafikiBindingSource;
        private Tiunov_BDDataSetTableAdapters.GrafikiTableAdapter grafikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgrafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grafikDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Sgraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grafik;
        private System.Windows.Forms.Button GbtnClear;
        private System.Windows.Forms.Button GbtnDelete;
        private System.Windows.Forms.Button GbtnUpdate;
        private System.Windows.Forms.Button GbtnInsert;
    }
}