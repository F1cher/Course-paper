
namespace Tiunov
{
    partial class Tips_Exp
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
            this.Tip = new System.Windows.Forms.TextBox();
            this.TbtnClear = new System.Windows.Forms.Button();
            this.TbtnDelete = new System.Windows.Forms.Button();
            this.TbtnUpdate = new System.Windows.Forms.Button();
            this.TbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exponattipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.exponat_tipTableAdapter = new Tiunov.TiunovDataSetTableAdapters.Exponat_tipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponattipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Тип";
            // 
            // Tip
            // 
            this.Tip.Location = new System.Drawing.Point(12, 77);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(100, 20);
            this.Tip.TabIndex = 41;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etipDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exponattipBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 337);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // etipDataGridViewTextBoxColumn
            // 
            this.etipDataGridViewTextBoxColumn.DataPropertyName = "Etip";
            this.etipDataGridViewTextBoxColumn.HeaderText = "№ типа";
            this.etipDataGridViewTextBoxColumn.Name = "etipDataGridViewTextBoxColumn";
            this.etipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exponattipBindingSource
            // 
            this.exponattipBindingSource.DataMember = "Exponat_tip";
            this.exponattipBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exponat_tipTableAdapter
            // 
            this.exponat_tipTableAdapter.ClearBeforeFill = true;
            // 
            // Tips_Exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.TbtnClear);
            this.Controls.Add(this.TbtnDelete);
            this.Controls.Add(this.TbtnUpdate);
            this.Controls.Add(this.TbtnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tips_Exp";
            this.Text = "Типы экспонатов";
            this.Load += new System.EventHandler(this.Tips_Exp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponattipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tip;
        private System.Windows.Forms.Button TbtnClear;
        private System.Windows.Forms.Button TbtnDelete;
        private System.Windows.Forms.Button TbtnUpdate;
        private System.Windows.Forms.Button TbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource exponattipBindingSource;
        private TiunovDataSetTableAdapters.Exponat_tipTableAdapter exponat_tipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
    }
}