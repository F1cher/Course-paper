
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
            this.Sgraf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grafik = new System.Windows.Forms.TextBox();
            this.GbtnClear = new System.Windows.Forms.Button();
            this.GbtnDelete = new System.Windows.Forms.Button();
            this.GbtnUpdate = new System.Windows.Forms.Button();
            this.GbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Sgraf
            // 
            this.Sgraf.Location = new System.Drawing.Point(12, 61);
            this.Sgraf.Name = "Sgraf";
            this.Sgraf.Size = new System.Drawing.Size(100, 20);
            this.Sgraf.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Наименование";
            // 
            // Grafik
            // 
            this.Grafik.Location = new System.Drawing.Point(127, 61);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(100, 20);
            this.Grafik.TabIndex = 41;
            // 
            // GbtnClear
            // 
            this.GbtnClear.Location = new System.Drawing.Point(255, 11);
            this.GbtnClear.Name = "GbtnClear";
            this.GbtnClear.Size = new System.Drawing.Size(75, 23);
            this.GbtnClear.TabIndex = 40;
            this.GbtnClear.Text = "Очистить";
            this.GbtnClear.UseVisualStyleBackColor = true;
            this.GbtnClear.Click += new System.EventHandler(this.GbtnClear_Click);
            // 
            // GbtnDelete
            // 
            this.GbtnDelete.Location = new System.Drawing.Point(174, 11);
            this.GbtnDelete.Name = "GbtnDelete";
            this.GbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.GbtnDelete.TabIndex = 39;
            this.GbtnDelete.Text = "Удалить";
            this.GbtnDelete.UseVisualStyleBackColor = true;
            this.GbtnDelete.Click += new System.EventHandler(this.GbtnDelete_Click);
            // 
            // GbtnUpdate
            // 
            this.GbtnUpdate.Location = new System.Drawing.Point(93, 11);
            this.GbtnUpdate.Name = "GbtnUpdate";
            this.GbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.GbtnUpdate.TabIndex = 38;
            this.GbtnUpdate.Text = "Изменить";
            this.GbtnUpdate.UseVisualStyleBackColor = true;
            this.GbtnUpdate.Click += new System.EventHandler(this.GbtnUpdate_Click);
            // 
            // GbtnInsert
            // 
            this.GbtnInsert.Location = new System.Drawing.Point(12, 11);
            this.GbtnInsert.Name = "GbtnInsert";
            this.GbtnInsert.Size = new System.Drawing.Size(75, 23);
            this.GbtnInsert.TabIndex = 37;
            this.GbtnInsert.Text = "Добавить";
            this.GbtnInsert.UseVisualStyleBackColor = true;
            this.GbtnInsert.Click += new System.EventHandler(this.GbtnInsert_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 103);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(776, 337);
            this.dataGridView4.TabIndex = 36;
            this.dataGridView4.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellEnter);
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
            this.Controls.Add(this.dataGridView4);
            this.Name = "Charts";
            this.Text = "Графики работы";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sgraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grafik;
        private System.Windows.Forms.Button GbtnClear;
        private System.Windows.Forms.Button GbtnDelete;
        private System.Windows.Forms.Button GbtnUpdate;
        private System.Windows.Forms.Button GbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}