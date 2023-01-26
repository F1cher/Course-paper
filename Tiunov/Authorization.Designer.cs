
namespace Tiunov
{
    partial class Authorization
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
            this.Authbtn = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.ComboBox();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiunovDataSet = new Tiunov.TiunovDataSet();
            this.sotrudnikiTableAdapter = new Tiunov.TiunovDataSetTableAdapters.SotrudnikiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Authbtn
            // 
            this.Authbtn.Location = new System.Drawing.Point(85, 173);
            this.Authbtn.Name = "Authbtn";
            this.Authbtn.Size = new System.Drawing.Size(142, 30);
            this.Authbtn.TabIndex = 9;
            this.Authbtn.Text = "Войти";
            this.Authbtn.UseVisualStyleBackColor = true;
            this.Authbtn.Click += new System.EventHandler(this.Authbtn_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(75, 136);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(166, 20);
            this.Pass.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // Login
            // 
            this.Login.DataSource = this.sotrudnikiBindingSource;
            this.Login.DisplayMember = "Login";
            this.Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login.FormattingEnabled = true;
            this.Login.Location = new System.Drawing.Point(75, 72);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(166, 21);
            this.Login.TabIndex = 10;
            this.Login.ValueMember = "Login";
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.tiunovDataSet;
            // 
            // tiunovDataSet
            // 
            this.tiunovDataSet.DataSetName = "TiunovDataSet";
            this.tiunovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Authbtn);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiunovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authbtn;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Login;
        private TiunovDataSet tiunovDataSet;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private TiunovDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}