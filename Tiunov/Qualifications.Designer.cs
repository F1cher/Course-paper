
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
            this.Skval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kval = new System.Windows.Forms.TextBox();
            this.TbtnClear = new System.Windows.Forms.Button();
            this.TbtnDelete = new System.Windows.Forms.Button();
            this.TbtnUpdate = new System.Windows.Forms.Button();
            this.TbtnInsert = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // Skval
            // 
            this.Skval.Location = new System.Drawing.Point(12, 64);
            this.Skval.Name = "Skval";
            this.Skval.Size = new System.Drawing.Size(100, 20);
            this.Skval.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Наименование";
            // 
            // Kval
            // 
            this.Kval.Location = new System.Drawing.Point(127, 64);
            this.Kval.Name = "Kval";
            this.Kval.Size = new System.Drawing.Size(100, 20);
            this.Kval.TabIndex = 41;
            // 
            // TbtnClear
            // 
            this.TbtnClear.Location = new System.Drawing.Point(255, 11);
            this.TbtnClear.Name = "TbtnClear";
            this.TbtnClear.Size = new System.Drawing.Size(75, 23);
            this.TbtnClear.TabIndex = 40;
            this.TbtnClear.Text = "Очистить";
            this.TbtnClear.UseVisualStyleBackColor = true;
            this.TbtnClear.Click += new System.EventHandler(this.TbtnClear_Click);
            // 
            // TbtnDelete
            // 
            this.TbtnDelete.Location = new System.Drawing.Point(174, 11);
            this.TbtnDelete.Name = "TbtnDelete";
            this.TbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.TbtnDelete.TabIndex = 39;
            this.TbtnDelete.Text = "Удалить";
            this.TbtnDelete.UseVisualStyleBackColor = true;
            this.TbtnDelete.Click += new System.EventHandler(this.TbtnDelete_Click);
            // 
            // TbtnUpdate
            // 
            this.TbtnUpdate.Location = new System.Drawing.Point(93, 11);
            this.TbtnUpdate.Name = "TbtnUpdate";
            this.TbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.TbtnUpdate.TabIndex = 38;
            this.TbtnUpdate.Text = "Изменить";
            this.TbtnUpdate.UseVisualStyleBackColor = true;
            this.TbtnUpdate.Click += new System.EventHandler(this.TbtnUpdate_Click);
            // 
            // TbtnInsert
            // 
            this.TbtnInsert.Location = new System.Drawing.Point(12, 11);
            this.TbtnInsert.Name = "TbtnInsert";
            this.TbtnInsert.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(12, 103);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(776, 337);
            this.dataGridView5.TabIndex = 36;
            this.dataGridView5.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellEnter);
            // 
            // Qualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Skval);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Skval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kval;
        private System.Windows.Forms.Button TbtnClear;
        private System.Windows.Forms.Button TbtnDelete;
        private System.Windows.Forms.Button TbtnUpdate;
        private System.Windows.Forms.Button TbtnInsert;
        private System.Windows.Forms.DataGridView dataGridView5;
    }
}