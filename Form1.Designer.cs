namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tas1 = new System.Windows.Forms.Button();
            this.kagıt1 = new System.Windows.Forms.Button();
            this.makas1 = new System.Windows.Forms.Button();
            this.makas2 = new System.Windows.Forms.Button();
            this.kagıt2 = new System.Windows.Forms.Button();
            this.tas2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skor2 = new System.Windows.Forms.Label();
            this.skor1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tas1
            // 
            this.tas1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tas1.Location = new System.Drawing.Point(485, 344);
            this.tas1.Name = "tas1";
            this.tas1.Size = new System.Drawing.Size(152, 56);
            this.tas1.TabIndex = 0;
            this.tas1.Text = "Taş";
            this.tas1.UseVisualStyleBackColor = true;
            this.tas1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kagıt1
            // 
            this.kagıt1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagıt1.Location = new System.Drawing.Point(485, 406);
            this.kagıt1.Name = "kagıt1";
            this.kagıt1.Size = new System.Drawing.Size(152, 56);
            this.kagıt1.TabIndex = 1;
            this.kagıt1.Text = "Kağıt";
            this.kagıt1.UseVisualStyleBackColor = true;
            this.kagıt1.Click += new System.EventHandler(this.kagıt1_Click);
            // 
            // makas1
            // 
            this.makas1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makas1.Location = new System.Drawing.Point(485, 468);
            this.makas1.Name = "makas1";
            this.makas1.Size = new System.Drawing.Size(152, 56);
            this.makas1.TabIndex = 2;
            this.makas1.Text = "Makas";
            this.makas1.UseVisualStyleBackColor = true;
            this.makas1.Click += new System.EventHandler(this.makas1_Click);
            // 
            // makas2
            // 
            this.makas2.Enabled = false;
            this.makas2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makas2.Location = new System.Drawing.Point(485, 175);
            this.makas2.Name = "makas2";
            this.makas2.Size = new System.Drawing.Size(152, 56);
            this.makas2.TabIndex = 5;
            this.makas2.Text = "Makas";
            this.makas2.UseVisualStyleBackColor = true;
            // 
            // kagıt2
            // 
            this.kagıt2.Enabled = false;
            this.kagıt2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagıt2.Location = new System.Drawing.Point(485, 113);
            this.kagıt2.Name = "kagıt2";
            this.kagıt2.Size = new System.Drawing.Size(152, 56);
            this.kagıt2.TabIndex = 4;
            this.kagıt2.Text = "Kağıt";
            this.kagıt2.UseVisualStyleBackColor = true;
            // 
            // tas2
            // 
            this.tas2.Enabled = false;
            this.tas2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tas2.Location = new System.Drawing.Point(485, 51);
            this.tas2.Name = "tas2";
            this.tas2.Size = new System.Drawing.Size(152, 56);
            this.tas2.TabIndex = 3;
            this.tas2.Text = "Taş";
            this.tas2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(384, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 51);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(463, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 51);
            this.label2.TabIndex = 7;
            // 
            // skor2
            // 
            this.skor2.AutoSize = true;
            this.skor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor2.Location = new System.Drawing.Point(640, 51);
            this.skor2.Name = "skor2";
            this.skor2.Size = new System.Drawing.Size(0, 32);
            this.skor2.TabIndex = 8;
            this.skor2.Click += new System.EventHandler(this.skor_Click);
            // 
            // skor1
            // 
            this.skor1.AutoSize = true;
            this.skor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor1.Location = new System.Drawing.Point(643, 492);
            this.skor1.Name = "skor1";
            this.skor1.Size = new System.Drawing.Size(0, 32);
            this.skor1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 604);
            this.Controls.Add(this.skor1);
            this.Controls.Add(this.skor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makas2);
            this.Controls.Add(this.kagıt2);
            this.Controls.Add(this.tas2);
            this.Controls.Add(this.makas1);
            this.Controls.Add(this.kagıt1);
            this.Controls.Add(this.tas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tas1;
        private System.Windows.Forms.Button kagıt1;
        private System.Windows.Forms.Button makas1;
        private System.Windows.Forms.Button makas2;
        private System.Windows.Forms.Button kagıt2;
        private System.Windows.Forms.Button tas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label skor2;
        private System.Windows.Forms.Label skor1;
    }
}

