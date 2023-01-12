
namespace Tiunov
{
    partial class Qualifications
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
            this.label1 = new System.Windows.Forms.Label();
            this.Kval = new System.Windows.Forms.TextBox();
            this.TbtnClear = new System.Windows.Forms.Button();
            this.TbtnDelete = new System.Windows.Forms.Button();
            this.TbtnUpdate = new System.Windows.Forms.Button();
            this.TbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.skvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalifikacyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.kvalifikacyaTableAdapter = new Tiunov.TiunovDataSetTableAdapters.KvalifikacyaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikacyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Квалификация";
            // 
            // Kval
            // 
            this.Kval.Location = new System.Drawing.Point(12, 77);
            this.Kval.Name = "Kval";
            this.Kval.Size = new System.Drawing.Size(100, 20);
            this.Kval.TabIndex = 41;
            // 
            // TbtnClear
            // 
            this.TbtnClear.Location = new System.Drawing.Point(315, 11);
            this.TbtnClear.Name = "TbtnClear";
            this.TbtnClear.Size = new System.Drawing.Size(95, 29);
            this.TbtnClear.TabIndex = 40;
            this.TbtnClear.Text = "Очистить";
            this.TbtnClear.UseVisualStyleBackColor = true;
            this.TbtnClear.Click += new System.EventHandler(this.TbtnClear_Click);
            // 
            // TbtnDelete
            // 
            this.TbtnDelete.Location = new System.Drawing.Point(214, 11);
            this.TbtnDelete.Name = "TbtnDelete";
            this.TbtnDelete.Size = new System.Drawing.Size(95, 29);
            this.TbtnDelete.TabIndex = 39;
            this.TbtnDelete.Text = "Удалить";
            this.TbtnDelete.UseVisualStyleBackColor = true;
            this.TbtnDelete.Click += new System.EventHandler(this.TbtnDelete_Click);
            // 
            // TbtnUpdate
            // 
            this.TbtnUpdate.Location = new System.Drawing.Point(113, 11);
            this.TbtnUpdate.Name = "TbtnUpdate";
            this.TbtnUpdate.Size = new System.Drawing.Size(95, 29);
            this.TbtnUpdate.TabIndex = 38;
            this.TbtnUpdate.Text = "Изменить";
            this.TbtnUpdate.UseVisualStyleBackColor = true;
            this.TbtnUpdate.Click += new System.EventHandler(this.TbtnUpdate_Click);
            // 
            // TbtnInsert
            // 
            this.TbtnInsert.Location = new System.Drawing.Point(12, 11);
            this.TbtnInsert.Name = "TbtnInsert";
            this.TbtnInsert.Size = new System.Drawing.Size(95, 29);
            this.TbtnInsert.TabIndex = 37;
            this.TbtnInsert.Text = "Добавить";
            this.TbtnInsert.UseVisualStyleBackColor = true;
            this.TbtnInsert.Click += new System.EventHandler(this.TbtnInsert_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skvalDataGridViewTextBoxColumn,
            this.kvalDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.kvalifikacyaBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(12, 103);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(776, 337);
            this.dataGridView5.TabIndex = 36;
            this.dataGridView5.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellEnter);
            // 
            // skvalDataGridViewTextBoxColumn
            // 
            this.skvalDataGridViewTextBoxColumn.DataPropertyName = "Skval";
            this.skvalDataGridViewTextBoxColumn.HeaderText = "№ квалификации";
            this.skvalDataGridViewTextBoxColumn.Name = "skvalDataGridViewTextBoxColumn";
            this.skvalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvalDataGridViewTextBoxColumn
            // 
            this.kvalDataGridViewTextBoxColumn.DataPropertyName = "Kval";
            this.kvalDataGridViewTextBoxColumn.HeaderText = "Квалификация";
            this.kvalDataGridViewTextBoxColumn.Name = "kvalDataGridViewTextBoxColumn";
            this.kvalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvalifikacyaBindingSource
            // 
            this.kvalifikacyaBindingSource.DataMember = "Kvalifikacya";
            this.kvalifikacyaBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvalifikacyaTableAdapter
            // 
            this.kvalifikacyaTableAdapter.ClearBeforeFill = true;
            // 
            // Qualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kval);
            this.Controls.Add(this.TbtnClear);
            this.Controls.Add(this.TbtnDelete);
            this.Controls.Add(this.TbtnUpdate);
            this.Controls.Add(this.TbtnInsert);
            this.Controls.Add(this.dataGridView5);
            this.Name = "Qualifications";
            this.Text = "Квалификации";
            this.Load += new System.EventHandler(this.Qualifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikacyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kval;
        private System.Windows.Forms.Button TbtnClear;
        private System.Windows.Forms.Button TbtnDelete;
        private System.Windows.Forms.Button TbtnUpdate;
        private System.Windows.Forms.Button TbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView5;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource kvalifikacyaBindingSource;
        private TiunovDataSetTableAdapters.KvalifikacyaTableAdapter kvalifikacyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn skvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvalDataGridViewTextBoxColumn;
    }
}