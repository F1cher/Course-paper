
namespace Tiunov
{
    partial class Statistics
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.statExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statExpTableAdapter = new Tiunov.TiunovDataSetTableAdapters.StatExpTableAdapter();
            this.колвоЭкспонатовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tiunovDataSet1 = new Tiunov.TiunovDataSet();
            this.statRestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statRestTableAdapter = new Tiunov.TiunovDataSetTableAdapters.StatRestTableAdapter();
            this.статусРеставрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЭкспонатовDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportToWord = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statExpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statRestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика приобретения экспонатов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exportToWord);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистика реставраций";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 438);
            this.tabControl1.TabIndex = 0;
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
            this.колвоЭкспонатовDataGridViewTextBoxColumn,
            this.итогоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statExpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statExpBindingSource
            // 
            this.statExpBindingSource.DataMember = "StatExp";
            this.statExpBindingSource.DataSource = this.tiunovDataSet;
            // 
            // statExpTableAdapter
            // 
            this.statExpTableAdapter.ClearBeforeFill = true;
            // 
            // колвоЭкспонатовDataGridViewTextBoxColumn
            // 
            this.колвоЭкспонатовDataGridViewTextBoxColumn.DataPropertyName = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.HeaderText = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.Name = "колвоЭкспонатовDataGridViewTextBoxColumn";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            this.итогоDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            this.итогоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.статусРеставрацииDataGridViewTextBoxColumn,
            this.колвоЭкспонатовDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.statRestBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // tiunovDataSet1
            // 
            this.tiunovDataSet1.DataSetName = "TiunovDataSet";
            this.tiunovDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statRestBindingSource
            // 
            this.statRestBindingSource.DataMember = "StatRest";
            this.statRestBindingSource.DataSource = this.tiunovDataSet1;
            // 
            // statRestTableAdapter
            // 
            this.statRestTableAdapter.ClearBeforeFill = true;
            // 
            // статусРеставрацииDataGridViewTextBoxColumn
            // 
            this.статусРеставрацииDataGridViewTextBoxColumn.DataPropertyName = "Статус реставрации";
            this.статусРеставрацииDataGridViewTextBoxColumn.HeaderText = "Статус реставрации";
            this.статусРеставрацииDataGridViewTextBoxColumn.Name = "статусРеставрацииDataGridViewTextBoxColumn";
            // 
            // колвоЭкспонатовDataGridViewTextBoxColumn1
            // 
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.DataPropertyName = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.HeaderText = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.Name = "колвоЭкспонатовDataGridViewTextBoxColumn1";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // exportToWord
            // 
            this.exportToWord.Location = new System.Drawing.Point(23, 210);
            this.exportToWord.Name = "exportToWord";
            this.exportToWord.Size = new System.Drawing.Size(75, 23);
            this.exportToWord.TabIndex = 1;
            this.exportToWord.Text = "button1";
            this.exportToWord.UseVisualStyleBackColor = true;
            this.exportToWord.Click += new System.EventHandler(this.exportToWord_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistics";
            this.Text = "Статистики";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statExpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statRestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource statExpBindingSource;
        private TiunovDataSetTableAdapters.StatExpTableAdapter statExpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЭкспонатовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private TiunovDataSet tiunovDataSet1;
        private System.Windows.Forms.BindingSource statRestBindingSource;
        private TiunovDataSetTableAdapters.StatRestTableAdapter statRestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусРеставрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЭкспонатовDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button exportToWord;
    }
}