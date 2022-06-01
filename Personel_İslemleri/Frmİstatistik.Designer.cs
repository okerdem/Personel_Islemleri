
namespace Personel_İslemleri
{
    partial class Frmİstatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPerSay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEvliPerSay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSehirSay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOrtMaas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTopMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Sayısı :";
            // 
            // labelPerSay
            // 
            this.labelPerSay.AutoSize = true;
            this.labelPerSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerSay.Location = new System.Drawing.Point(186, 9);
            this.labelPerSay.Name = "labelPerSay";
            this.labelPerSay.Size = new System.Drawing.Size(19, 20);
            this.labelPerSay.TabIndex = 1;
            this.labelPerSay.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Evli Personel Sayısı :";
            // 
            // labelEvliPerSay
            // 
            this.labelEvliPerSay.AutoSize = true;
            this.labelEvliPerSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEvliPerSay.Location = new System.Drawing.Point(186, 43);
            this.labelEvliPerSay.Name = "labelEvliPerSay";
            this.labelEvliPerSay.Size = new System.Drawing.Size(19, 20);
            this.labelEvliPerSay.TabIndex = 3;
            this.labelEvliPerSay.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir Sayısı :";
            // 
            // labelSehirSay
            // 
            this.labelSehirSay.AutoSize = true;
            this.labelSehirSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSehirSay.Location = new System.Drawing.Point(186, 81);
            this.labelSehirSay.Name = "labelSehirSay";
            this.labelSehirSay.Size = new System.Drawing.Size(19, 20);
            this.labelSehirSay.TabIndex = 5;
            this.labelSehirSay.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ortalama Maaş :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelOrtMaas
            // 
            this.labelOrtMaas.AutoSize = true;
            this.labelOrtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrtMaas.Location = new System.Drawing.Point(186, 120);
            this.labelOrtMaas.Name = "labelOrtMaas";
            this.labelOrtMaas.Size = new System.Drawing.Size(19, 20);
            this.labelOrtMaas.TabIndex = 7;
            this.labelOrtMaas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toplam Maaş :";
            // 
            // labelTopMaas
            // 
            this.labelTopMaas.AutoSize = true;
            this.labelTopMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTopMaas.Location = new System.Drawing.Point(186, 156);
            this.labelTopMaas.Name = "labelTopMaas";
            this.labelTopMaas.Size = new System.Drawing.Size(19, 20);
            this.labelTopMaas.TabIndex = 9;
            this.labelTopMaas.Text = "0";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 185);
            this.Controls.Add(this.labelTopMaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOrtMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSehirSay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEvliPerSay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPerSay);
            this.Controls.Add(this.label1);
            this.Name = "Frmİstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.Per_İstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPerSay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEvliPerSay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSehirSay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOrtMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTopMaas;
    }
}