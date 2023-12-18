namespace HüsoPersonelTakipSistemi
{
    partial class Form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPersonelList = new System.Windows.Forms.Button();
            this.btnComputerAdd = new System.Windows.Forms.Button();
            this.btnComputerList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAdd.Location = new System.Drawing.Point(14, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(381, 105);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Personel Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPersonelList
            // 
            this.btnPersonelList.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPersonelList.Location = new System.Drawing.Point(401, 19);
            this.btnPersonelList.Name = "btnPersonelList";
            this.btnPersonelList.Size = new System.Drawing.Size(381, 106);
            this.btnPersonelList.TabIndex = 0;
            this.btnPersonelList.Text = "Personel Listeleme";
            this.btnPersonelList.UseVisualStyleBackColor = false;
            this.btnPersonelList.Click += new System.EventHandler(this.btnPersonelList_Click);
            // 
            // btnComputerAdd
            // 
            this.btnComputerAdd.BackColor = System.Drawing.Color.Linen;
            this.btnComputerAdd.Location = new System.Drawing.Point(14, 20);
            this.btnComputerAdd.Name = "btnComputerAdd";
            this.btnComputerAdd.Size = new System.Drawing.Size(381, 101);
            this.btnComputerAdd.TabIndex = 0;
            this.btnComputerAdd.Text = "Bilgisayar Ekle";
            this.btnComputerAdd.UseVisualStyleBackColor = false;
            this.btnComputerAdd.Click += new System.EventHandler(this.btnComputerAdd_Click);
            // 
            // btnComputerList
            // 
            this.btnComputerList.BackColor = System.Drawing.Color.Linen;
            this.btnComputerList.Location = new System.Drawing.Point(401, 20);
            this.btnComputerList.Name = "btnComputerList";
            this.btnComputerList.Size = new System.Drawing.Size(381, 101);
            this.btnComputerList.TabIndex = 0;
            this.btnComputerList.Text = "Bigisayarları Listele";
            this.btnComputerList.UseVisualStyleBackColor = false;
            this.btnComputerList.Click += new System.EventHandler(this.btnComputerList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnPersonelList);
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.btnComputerList);
            this.groupBox2.Controls.Add(this.btnComputerAdd);
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok İşlemleri";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPersonelList;
        private System.Windows.Forms.Button btnComputerAdd;
        private System.Windows.Forms.Button btnComputerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}