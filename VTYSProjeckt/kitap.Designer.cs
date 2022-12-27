namespace VTYSProjeckt
{
    partial class kitap
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtisb = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cturid = new System.Windows.Forms.ComboBox();
            this.txtkutuphane = new System.Windows.Forms.TextBox();
            this.txtyayinci = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(926, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Yayinci ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(950, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tur ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(899, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "KutuphaneNo";
            // 
            // txtisb
            // 
            this.txtisb.Location = new System.Drawing.Point(1019, 134);
            this.txtisb.Name = "txtisb";
            this.txtisb.Size = new System.Drawing.Size(125, 27);
            this.txtisb.TabIndex = 37;
            // 
            // txtisbn
            // 
            this.txtisbn.AutoSize = true;
            this.txtisbn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtisbn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtisbn.Location = new System.Drawing.Point(958, 134);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(49, 23);
            this.txtisbn.TabIndex = 36;
            this.txtisbn.Text = "ISBN";
            this.txtisbn.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Location = new System.Drawing.Point(1200, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 40);
            this.button5.TabIndex = 35;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Location = new System.Drawing.Point(1200, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 40);
            this.button4.TabIndex = 34;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(1200, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(1200, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 32;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(1200, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "TümünüListele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(1019, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 27);
            this.txtAd.TabIndex = 30;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(928, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kitap Adi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(842, 426);
            this.dataGridView1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(936, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Yazar ID";
            // 
            // cturid
            // 
            this.cturid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cturid.FormattingEnabled = true;
            this.cturid.Location = new System.Drawing.Point(1019, 301);
            this.cturid.Name = "cturid";
            this.cturid.Size = new System.Drawing.Size(125, 28);
            this.cturid.TabIndex = 47;
            // 
            // txtkutuphane
            // 
            this.txtkutuphane.Location = new System.Drawing.Point(1019, 239);
            this.txtkutuphane.Name = "txtkutuphane";
            this.txtkutuphane.Size = new System.Drawing.Size(125, 27);
            this.txtkutuphane.TabIndex = 50;
            // 
            // txtyayinci
            // 
            this.txtyayinci.Location = new System.Drawing.Point(1019, 365);
            this.txtyayinci.Name = "txtyayinci";
            this.txtyayinci.Size = new System.Drawing.Size(125, 27);
            this.txtyayinci.TabIndex = 51;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(1019, 414);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(125, 27);
            this.txtyazar.TabIndex = 52;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(1019, 185);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(125, 27);
            this.txtstok.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(921, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Stok Adeti";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1355, 555);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtyayinci);
            this.Controls.Add(this.txtkutuphane);
            this.Controls.Add(this.cturid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtisb);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitap";
            this.Text = "kitap";
            this.Load += new System.EventHandler(this.kitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtisb;
        private Label txtisbn;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtAd;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cturid;
        private TextBox txtkutuphane;
        private TextBox txtyayinci;
        private TextBox txtyazar;
        private TextBox txtstok;
        private Label label3;
    }
}