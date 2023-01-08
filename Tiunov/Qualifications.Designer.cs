
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalifikacyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunov_BDDataSet = new Tiunov.Tiunov_BDDataSet();
            this.kvalifikacyaTableAdapter = new Tiunov.Tiunov_BDDataSetTableAdapters.KvalifikacyaTableAdapter();
            this.KbtnClear = new System.Windows.Forms.Button();
            this.KbtnDelete = new System.Windows.Forms.Button();
            this.KbtnUpdate = new System.Windows.Forms.Button();
            this.KbtnInsert = new System.Windows.Forms.Button();
            this.Kval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Skval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikacyaBindingSource)).BeginInit();
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
            this.skvalDataGridViewTextBoxColumn,
            this.kvalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvalifikacyaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // skvalDataGridViewTextBoxColumn
            // 
            this.skvalDataGridViewTextBoxColumn.DataPropertyName = "Skval";
            this.skvalDataGridViewTextBoxColumn.HeaderText = "Skval";
            this.skvalDataGridViewTextBoxColumn.Name = "skvalDataGridViewTextBoxColumn";
            // 
            // kvalDataGridViewTextBoxColumn
            // 
            this.kvalDataGridViewTextBoxColumn.DataPropertyName = "Kval";
            this.kvalDataGridViewTextBoxColumn.HeaderText = "Kval";
            this.kvalDataGridViewTextBoxColumn.Name = "kvalDataGridViewTextBoxColumn";
            // 
            // kvalifikacyaBindingSource
            // 
            this.kvalifikacyaBindingSource.DataMember = "Kvalifikacya";
            this.kvalifikacyaBindingSource.DataSource = this.tiunov_BDDataSet;
            // 
            // tiunov_BDDataSet
            // 
            this.tiunov_BDDataSet.DataSetName = "Tiunov_BDDataSet";
            this.tiunov_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvalifikacyaTableAdapter
            // 
            this.kvalifikacyaTableAdapter.ClearBeforeFill = true;
            // 
            // KbtnClear
            // 
            this.KbtnClear.Location = new System.Drawing.Point(93, 73);
            this.KbtnClear.Name = "KbtnClear";
            this.KbtnClear.Size = new System.Drawing.Size(75, 23);
            this.KbtnClear.TabIndex = 25;
            this.KbtnClear.Text = "Очистить";
            this.KbtnClear.UseVisualStyleBackColor = true;
            this.KbtnClear.Click += new System.EventHandler(this.KbtnClear_Click);
            // 
            // KbtnDelete
            // 
            this.KbtnDelete.Location = new System.Drawing.Point(12, 73);
            this.KbtnDelete.Name = "KbtnDelete";
            this.KbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.KbtnDelete.TabIndex = 24;
            this.KbtnDelete.Text = "Удалить";
            this.KbtnDelete.UseVisualStyleBackColor = true;
            this.KbtnDelete.Click += new System.EventHandler(this.KbtnDelete_Click);
            // 
            // KbtnUpdate
            // 
            this.KbtnUpdate.Location = new System.Drawing.Point(12, 44);
            this.KbtnUpdate.Name = "KbtnUpdate";
            this.KbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.KbtnUpdate.TabIndex = 23;
            this.KbtnUpdate.Text = "Изменить";
            this.KbtnUpdate.UseVisualStyleBackColor = true;
            this.KbtnUpdate.Click += new System.EventHandler(this.KbtnUpdate_Click);
            // 
            // KbtnInsert
            // 
            this.KbtnInsert.Location = new System.Drawing.Point(12, 15);
            this.KbtnInsert.Name = "KbtnInsert";
            this.KbtnInsert.Size = new System.Drawing.Size(75, 23);
            this.KbtnInsert.TabIndex = 22;
            this.KbtnInsert.Text = "Добавить";
            this.KbtnInsert.UseVisualStyleBackColor = true;
            this.KbtnInsert.Click += new System.EventHandler(this.KbtnInsert_Click);
            // 
            // Kval
            // 
            this.Kval.Location = new System.Drawing.Point(208, 47);
            this.Kval.Name = "Kval";
            this.Kval.Size = new System.Drawing.Size(100, 20);
            this.Kval.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Наименование";
            // 
            // Skval
            // 
            this.Skval.Location = new System.Drawing.Point(93, 47);
            this.Skval.Name = "Skval";
            this.Skval.Size = new System.Drawing.Size(100, 20);
            this.Skval.TabIndex = 28;
            this.Skval.Visible = false;
            // 
            // Qualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Skval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kval);
            this.Controls.Add(this.KbtnClear);
            this.Controls.Add(this.KbtnDelete);
            this.Controls.Add(this.KbtnUpdate);
            this.Controls.Add(this.KbtnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Qualifications";
            this.Text = "Квалификации";
            this.Load += new System.EventHandler(this.Qualifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikacyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunov_BDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Tiunov_BDDataSet tiunov_BDDataSet;
        private System.Windows.Forms.BindingSource kvalifikacyaBindingSource;
        private Tiunov_BDDataSetTableAdapters.KvalifikacyaTableAdapter kvalifikacyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn skvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button KbtnClear;
        private System.Windows.Forms.Button KbtnDelete;
        private System.Windows.Forms.Button KbtnUpdate;
        private System.Windows.Forms.Button KbtnInsert;
        private System.Windows.Forms.TextBox Kval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Skval;
    }
}