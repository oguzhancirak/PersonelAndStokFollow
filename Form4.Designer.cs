namespace HüsoPersonelTakipSistemi
{
    partial class Form4
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
            this.dgwGetAll = new System.Windows.Forms.DataGridView();
            this.cbxIsComputer = new System.Windows.Forms.ComboBox();
            this.txtFindPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUptade = new System.Windows.Forms.Button();
            this.btnShowPc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGetAll
            // 
            this.dgwGetAll.AccessibleName = "dgwGetAll";
            this.dgwGetAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGetAll.Location = new System.Drawing.Point(12, 141);
            this.dgwGetAll.Name = "dgwGetAll";
            this.dgwGetAll.RowHeadersWidth = 51;
            this.dgwGetAll.RowTemplate.Height = 24;
            this.dgwGetAll.Size = new System.Drawing.Size(776, 208);
            this.dgwGetAll.TabIndex = 0;
            this.dgwGetAll.Click += new System.EventHandler(this.dgwGetAll_Click);
            // 
            // cbxIsComputer
            // 
            this.cbxIsComputer.FormattingEnabled = true;
            this.cbxIsComputer.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.cbxIsComputer.Location = new System.Drawing.Point(43, 53);
            this.cbxIsComputer.Name = "cbxIsComputer";
            this.cbxIsComputer.Size = new System.Drawing.Size(142, 24);
            this.cbxIsComputer.TabIndex = 1;
            this.cbxIsComputer.SelectedIndexChanged += new System.EventHandler(this.cbxIsComputer_SelectedIndexChanged);
            // 
            // txtFindPerson
            // 
            this.txtFindPerson.Location = new System.Drawing.Point(477, 43);
            this.txtFindPerson.Multiline = true;
            this.txtFindPerson.Name = "txtFindPerson";
            this.txtFindPerson.Size = new System.Drawing.Size(256, 34);
            this.txtFindPerson.TabIndex = 2;
            this.txtFindPerson.TextChanged += new System.EventHandler(this.txtFindPerson_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bilgisyarı Var Mı?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUptade
            // 
            this.btnUptade.Location = new System.Drawing.Point(12, 367);
            this.btnUptade.Name = "btnUptade";
            this.btnUptade.Size = new System.Drawing.Size(122, 43);
            this.btnUptade.TabIndex = 5;
            this.btnUptade.Text = "Güncelle";
            this.btnUptade.UseVisualStyleBackColor = true;
            this.btnUptade.Click += new System.EventHandler(this.btnUptade_Click);
            // 
            // btnShowPc
            // 
            this.btnShowPc.Location = new System.Drawing.Point(646, 355);
            this.btnShowPc.Name = "btnShowPc";
            this.btnShowPc.Size = new System.Drawing.Size(142, 33);
            this.btnShowPc.TabIndex = 6;
            this.btnShowPc.Text = "Bilgisarı Göster";
            this.btnShowPc.UseVisualStyleBackColor = true;
            this.btnShowPc.Click += new System.EventHandler(this.btnShowPc_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPc);
            this.Controls.Add(this.btnUptade);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindPerson);
            this.Controls.Add(this.cbxIsComputer);
            this.Controls.Add(this.dgwGetAll);
            this.Name = "Form4";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGetAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGetAll;
        private System.Windows.Forms.ComboBox cbxIsComputer;
        private System.Windows.Forms.TextBox txtFindPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUptade;
        private System.Windows.Forms.Button btnShowPc;
    }
}