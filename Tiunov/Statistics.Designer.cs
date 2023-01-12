
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
            this.exportToWord_2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.колвоЭкспонатовDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exportToWord = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.статусРеставрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЭкспонатовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statRestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statRestTableAdapter = new Tiunov.TiunovDataSetTableAdapters.StatRestTableAdapter();
            this.statExpTableAdapter = new Tiunov.TiunovDataSetTableAdapters.StatExpTableAdapter();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statExpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statRestBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exportToWord_2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика приобретения экспонатов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exportToWord_2
            // 
            this.exportToWord_2.Location = new System.Drawing.Point(7, 6);
            this.exportToWord_2.Name = "exportToWord_2";
            this.exportToWord_2.Size = new System.Drawing.Size(95, 29);
            this.exportToWord_2.TabIndex = 2;
            this.exportToWord_2.Text = "Экспорт";
            this.exportToWord_2.UseVisualStyleBackColor = true;
            this.exportToWord_2.Click += new System.EventHandler(this.exportToWord_2_Click);
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
            this.колвоЭкспонатовDataGridViewTextBoxColumn1,
            this.итогоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statExpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // колвоЭкспонатовDataGridViewTextBoxColumn1
            // 
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.DataPropertyName = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.HeaderText = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.Name = "колвоЭкспонатовDataGridViewTextBoxColumn1";
            this.колвоЭкспонатовDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            this.итогоDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            this.итогоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statExpBindingSource
            // 
            this.statExpBindingSource.DataMember = "StatExp";
            this.statExpBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // exportToWord
            // 
            this.exportToWord.Location = new System.Drawing.Point(7, 6);
            this.exportToWord.Name = "exportToWord";
            this.exportToWord.Size = new System.Drawing.Size(95, 29);
            this.exportToWord.TabIndex = 1;
            this.exportToWord.Text = "Экспорт";
            this.exportToWord.UseVisualStyleBackColor = true;
            this.exportToWord.Click += new System.EventHandler(this.exportToWord_Click);
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
            this.колвоЭкспонатовDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.statRestBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(776, 363);
            this.dataGridView2.TabIndex = 0;
            // 
            // статусРеставрацииDataGridViewTextBoxColumn
            // 
            this.статусРеставрацииDataGridViewTextBoxColumn.DataPropertyName = "Статус реставрации";
            this.статусРеставрацииDataGridViewTextBoxColumn.HeaderText = "Статус реставрации";
            this.статусРеставрацииDataGridViewTextBoxColumn.Name = "статусРеставрацииDataGridViewTextBoxColumn";
            this.статусРеставрацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колвоЭкспонатовDataGridViewTextBoxColumn
            // 
            this.колвоЭкспонатовDataGridViewTextBoxColumn.DataPropertyName = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.HeaderText = "Кол-во экспонатов";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.Name = "колвоЭкспонатовDataGridViewTextBoxColumn";
            this.колвоЭкспонатовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statRestBindingSource
            // 
            this.statRestBindingSource.DataMember = "StatRest";
            this.statRestBindingSource.DataSource = this.tiunovDataSet;
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
            // statRestTableAdapter
            // 
            this.statRestTableAdapter.ClearBeforeFill = true;
            // 
            // statExpTableAdapter
            // 
            this.statExpTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statExpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statRestBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button exportToWord;
        private System.Windows.Forms.Button exportToWord_2;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource statRestBindingSource;
        private TiunovDataSetTableAdapters.StatRestTableAdapter statRestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусРеставрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЭкспонатовDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statExpBindingSource;
        private TiunovDataSetTableAdapters.StatExpTableAdapter statExpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЭкспонатовDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
    }
}