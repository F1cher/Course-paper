
namespace Tiunov
{
    partial class Restoration_status
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
            this.Status = new System.Windows.Forms.TextBox();
            this.SbtnClear = new System.Windows.Forms.Button();
            this.SbtnDelete = new System.Windows.Forms.Button();
            this.SbtnUpdate = new System.Windows.Forms.Button();
            this.SbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.rstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restorationstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.restoration_statusTableAdapter = new Tiunov.TiunovDataSetTableAdapters.Restoration_statusTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorationstatusBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Статус";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(12, 77);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(172, 20);
            this.Status.TabIndex = 48;
            // 
            // SbtnClear
            // 
            this.SbtnClear.Location = new System.Drawing.Point(315, 11);
            this.SbtnClear.Name = "SbtnClear";
            this.SbtnClear.Size = new System.Drawing.Size(95, 29);
            this.SbtnClear.TabIndex = 47;
            this.SbtnClear.Text = "Очистить";
            this.SbtnClear.UseVisualStyleBackColor = true;
            this.SbtnClear.Click += new System.EventHandler(this.SbtnClear_Click);
            // 
            // SbtnDelete
            // 
            this.SbtnDelete.Location = new System.Drawing.Point(214, 11);
            this.SbtnDelete.Name = "SbtnDelete";
            this.SbtnDelete.Size = new System.Drawing.Size(95, 29);
            this.SbtnDelete.TabIndex = 46;
            this.SbtnDelete.Text = "Удалить";
            this.SbtnDelete.UseVisualStyleBackColor = true;
            this.SbtnDelete.Click += new System.EventHandler(this.SbtnDelete_Click);
            // 
            // SbtnUpdate
            // 
            this.SbtnUpdate.Location = new System.Drawing.Point(113, 11);
            this.SbtnUpdate.Name = "SbtnUpdate";
            this.SbtnUpdate.Size = new System.Drawing.Size(95, 29);
            this.SbtnUpdate.TabIndex = 45;
            this.SbtnUpdate.Text = "Изменить";
            this.SbtnUpdate.UseVisualStyleBackColor = true;
            this.SbtnUpdate.Click += new System.EventHandler(this.SbtnUpdate_Click);
            // 
            // SbtnInsert
            // 
            this.SbtnInsert.Location = new System.Drawing.Point(12, 11);
            this.SbtnInsert.Name = "SbtnInsert";
            this.SbtnInsert.Size = new System.Drawing.Size(95, 29);
            this.SbtnInsert.TabIndex = 44;
            this.SbtnInsert.Text = "Добавить";
            this.SbtnInsert.UseVisualStyleBackColor = true;
            this.SbtnInsert.Click += new System.EventHandler(this.SbtnInsert_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rstatusDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.restorationstatusBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(12, 103);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(776, 322);
            this.dataGridView5.TabIndex = 43;
            this.dataGridView5.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellEnter);
            // 
            // rstatusDataGridViewTextBoxColumn
            // 
            this.rstatusDataGridViewTextBoxColumn.DataPropertyName = "Rstatus";
            this.rstatusDataGridViewTextBoxColumn.HeaderText = "№ статуса";
            this.rstatusDataGridViewTextBoxColumn.Name = "rstatusDataGridViewTextBoxColumn";
            this.rstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restorationstatusBindingSource
            // 
            this.restorationstatusBindingSource.DataMember = "Restoration_status";
            this.restorationstatusBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restoration_statusTableAdapter
            // 
            this.restoration_statusTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Restoration_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SbtnClear);
            this.Controls.Add(this.SbtnDelete);
            this.Controls.Add(this.SbtnUpdate);
            this.Controls.Add(this.SbtnInsert);
            this.Controls.Add(this.dataGridView5);
            this.Name = "Restoration_status";
            this.Text = "Статусы реставрации";
            this.Load += new System.EventHandler(this.Restoration_status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorationstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button SbtnClear;
        private System.Windows.Forms.Button SbtnDelete;
        private System.Windows.Forms.Button SbtnUpdate;
        private System.Windows.Forms.Button SbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView5;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource restorationstatusBindingSource;
        private TiunovDataSetTableAdapters.Restoration_statusTableAdapter restoration_statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}