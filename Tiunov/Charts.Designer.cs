
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
            this.label1 = new System.Windows.Forms.Label();
            this.Grafik = new System.Windows.Forms.TextBox();
            this.GbtnClear = new System.Windows.Forms.Button();
            this.GbtnDelete = new System.Windows.Forms.Button();
            this.GbtnUpdate = new System.Windows.Forms.Button();
            this.GbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sgrafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.grafikiTableAdapter = new Tiunov.TiunovDataSetTableAdapters.GrafikiTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "График";
            // 
            // Grafik
            // 
            this.Grafik.Location = new System.Drawing.Point(12, 77);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(100, 20);
            this.Grafik.TabIndex = 41;
            // 
            // GbtnClear
            // 
            this.GbtnClear.Location = new System.Drawing.Point(315, 11);
            this.GbtnClear.Name = "GbtnClear";
            this.GbtnClear.Size = new System.Drawing.Size(95, 29);
            this.GbtnClear.TabIndex = 40;
            this.GbtnClear.Text = "Очистить";
            this.GbtnClear.UseVisualStyleBackColor = true;
            this.GbtnClear.Click += new System.EventHandler(this.GbtnClear_Click);
            // 
            // GbtnDelete
            // 
            this.GbtnDelete.Location = new System.Drawing.Point(214, 11);
            this.GbtnDelete.Name = "GbtnDelete";
            this.GbtnDelete.Size = new System.Drawing.Size(95, 29);
            this.GbtnDelete.TabIndex = 39;
            this.GbtnDelete.Text = "Удалить";
            this.GbtnDelete.UseVisualStyleBackColor = true;
            this.GbtnDelete.Click += new System.EventHandler(this.GbtnDelete_Click);
            // 
            // GbtnUpdate
            // 
            this.GbtnUpdate.Location = new System.Drawing.Point(113, 11);
            this.GbtnUpdate.Name = "GbtnUpdate";
            this.GbtnUpdate.Size = new System.Drawing.Size(95, 29);
            this.GbtnUpdate.TabIndex = 38;
            this.GbtnUpdate.Text = "Изменить";
            this.GbtnUpdate.UseVisualStyleBackColor = true;
            this.GbtnUpdate.Click += new System.EventHandler(this.GbtnUpdate_Click);
            // 
            // GbtnInsert
            // 
            this.GbtnInsert.Location = new System.Drawing.Point(12, 11);
            this.GbtnInsert.Name = "GbtnInsert";
            this.GbtnInsert.Size = new System.Drawing.Size(95, 29);
            this.GbtnInsert.TabIndex = 37;
            this.GbtnInsert.Text = "Добавить";
            this.GbtnInsert.UseVisualStyleBackColor = true;
            this.GbtnInsert.Click += new System.EventHandler(this.GbtnInsert_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sgrafDataGridViewTextBoxColumn,
            this.grafikDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.grafikiBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(12, 103);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(776, 322);
            this.dataGridView4.TabIndex = 36;
            this.dataGridView4.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellEnter);
            // 
            // sgrafDataGridViewTextBoxColumn
            // 
            this.sgrafDataGridViewTextBoxColumn.DataPropertyName = "Sgraf";
            this.sgrafDataGridViewTextBoxColumn.HeaderText = "№ графика";
            this.sgrafDataGridViewTextBoxColumn.Name = "sgrafDataGridViewTextBoxColumn";
            this.sgrafDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grafikDataGridViewTextBoxColumn
            // 
            this.grafikDataGridViewTextBoxColumn.DataPropertyName = "Grafik";
            this.grafikDataGridViewTextBoxColumn.HeaderText = "График";
            this.grafikDataGridViewTextBoxColumn.Name = "grafikDataGridViewTextBoxColumn";
            this.grafikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grafikiBindingSource
            // 
            this.grafikiBindingSource.DataMember = "Grafiki";
            this.grafikiBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafikiTableAdapter
            // 
            this.grafikiTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grafik);
            this.Controls.Add(this.GbtnClear);
            this.Controls.Add(this.GbtnDelete);
            this.Controls.Add(this.GbtnUpdate);
            this.Controls.Add(this.GbtnInsert);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Charts";
            this.Text = "Графики работы";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grafik;
        private System.Windows.Forms.Button GbtnClear;
        private System.Windows.Forms.Button GbtnDelete;
        private System.Windows.Forms.Button GbtnUpdate;
        private System.Windows.Forms.Button GbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView4;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource grafikiBindingSource;
        private TiunovDataSetTableAdapters.GrafikiTableAdapter grafikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgrafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grafikDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}