namespace HüsoPersonelTakipSistemi
{
    partial class Form7
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
            this.txtPcBrand = new System.Windows.Forms.TextBox();
            this.cbxPcPersonel = new System.Windows.Forms.ComboBox();
            this.btnPcAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rctPcDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPcBrand
            // 
            this.txtPcBrand.Location = new System.Drawing.Point(137, 56);
            this.txtPcBrand.Name = "txtPcBrand";
            this.txtPcBrand.Size = new System.Drawing.Size(121, 22);
            this.txtPcBrand.TabIndex = 0;
          
            // 
            // cbxPcPersonel
            // 
            this.cbxPcPersonel.FormattingEnabled = true;
            this.cbxPcPersonel.Location = new System.Drawing.Point(137, 98);
            this.cbxPcPersonel.Name = "cbxPcPersonel";
            this.cbxPcPersonel.Size = new System.Drawing.Size(121, 24);
            this.cbxPcPersonel.TabIndex = 2;
            this.cbxPcPersonel.SelectedIndexChanged += new System.EventHandler(this.cbxPcPersonel_SelectedIndexChanged);
            // 
            // btnPcAdd
            // 
            this.btnPcAdd.Location = new System.Drawing.Point(137, 249);
            this.btnPcAdd.Name = "btnPcAdd";
            this.btnPcAdd.Size = new System.Drawing.Size(121, 33);
            this.btnPcAdd.TabIndex = 3;
            this.btnPcAdd.Text = "Ekle";
            this.btnPcAdd.UseVisualStyleBackColor = true;
            this.btnPcAdd.Click += new System.EventHandler(this.btnPcAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pc Markası:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rctPcDescription);
            this.groupBox1.Controls.Add(this.txtPcBrand);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPcAdd);
            this.groupBox1.Controls.Add(this.cbxPcPersonel);
            this.groupBox1.Location = new System.Drawing.Point(115, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 309);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rctPcDescription
            // 
            this.rctPcDescription.Location = new System.Drawing.Point(137, 156);
            this.rctPcDescription.Name = "rctPcDescription";
            this.rctPcDescription.Size = new System.Drawing.Size(121, 70);
            this.rctPcDescription.TabIndex = 6;
            this.rctPcDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pc Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atanacak Personel";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPcBrand;
        private System.Windows.Forms.ComboBox cbxPcPersonel;
        private System.Windows.Forms.Button btnPcAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rctPcDescription;
    }
}