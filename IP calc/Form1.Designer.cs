
namespace IP_calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IPNet = new System.Windows.Forms.Label();
            this.Mask = new System.Windows.Forms.Label();
            this.IPClass = new System.Windows.Forms.Label();
            this.ShirAd = new System.Windows.Forms.Label();
            this.MaskUnit = new System.Windows.Forms.TextBox();
            this.firstIP = new System.Windows.Forms.TextBox();
            this.secondIP = new System.Windows.Forms.TextBox();
            this.thirdIP = new System.Windows.Forms.TextBox();
            this.fourthIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colhost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(264, 34);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 2;
            this.result.Text = "Посчитать";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP сети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Маска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Широковещательный адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Класс";
            // 
            // IPNet
            // 
            this.IPNet.AutoSize = true;
            this.IPNet.Location = new System.Drawing.Point(73, 118);
            this.IPNet.Name = "IPNet";
            this.IPNet.Size = new System.Drawing.Size(40, 13);
            this.IPNet.TabIndex = 7;
            this.IPNet.Text = "0.0.0.0";
            // 
            // Mask
            // 
            this.Mask.AutoSize = true;
            this.Mask.Location = new System.Drawing.Point(73, 145);
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(40, 13);
            this.Mask.TabIndex = 8;
            this.Mask.Text = "0.0.0.0";
            // 
            // IPClass
            // 
            this.IPClass.AutoSize = true;
            this.IPClass.Location = new System.Drawing.Point(168, 193);
            this.IPClass.Name = "IPClass";
            this.IPClass.Size = new System.Drawing.Size(0, 13);
            this.IPClass.TabIndex = 9;
            // 
            // ShirAd
            // 
            this.ShirAd.AutoSize = true;
            this.ShirAd.Location = new System.Drawing.Point(73, 170);
            this.ShirAd.Name = "ShirAd";
            this.ShirAd.Size = new System.Drawing.Size(40, 13);
            this.ShirAd.TabIndex = 10;
            this.ShirAd.Text = "0.0.0.0";
            // 
            // MaskUnit
            // 
            this.MaskUnit.Location = new System.Drawing.Point(15, 84);
            this.MaskUnit.Multiline = true;
            this.MaskUnit.Name = "MaskUnit";
            this.MaskUnit.Size = new System.Drawing.Size(67, 20);
            this.MaskUnit.TabIndex = 1;
            this.MaskUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaskUnit_KeyPress);
            // 
            // firstIP
            // 
            this.firstIP.Location = new System.Drawing.Point(15, 36);
            this.firstIP.Name = "firstIP";
            this.firstIP.Size = new System.Drawing.Size(46, 20);
            this.firstIP.TabIndex = 11;
            this.firstIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstIP_KeyPress);
            // 
            // secondIP
            // 
            this.secondIP.Location = new System.Drawing.Point(67, 36);
            this.secondIP.Name = "secondIP";
            this.secondIP.Size = new System.Drawing.Size(46, 20);
            this.secondIP.TabIndex = 12;
            this.secondIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondIP_KeyPress);
            // 
            // thirdIP
            // 
            this.thirdIP.Location = new System.Drawing.Point(119, 36);
            this.thirdIP.Name = "thirdIP";
            this.thirdIP.Size = new System.Drawing.Size(46, 20);
            this.thirdIP.TabIndex = 13;
            this.thirdIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdIP_KeyPress);
            // 
            // fourthIP
            // 
            this.fourthIP.Location = new System.Drawing.Point(171, 36);
            this.fourthIP.Name = "fourthIP";
            this.fourthIP.Size = new System.Drawing.Size(46, 20);
            this.fourthIP.TabIndex = 14;
            this.fourthIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourthIP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите количество единиц в маске";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Количество хостов";
            // 
            // colhost
            // 
            this.colhost.AutoSize = true;
            this.colhost.Location = new System.Drawing.Point(165, 221);
            this.colhost.Name = "colhost";
            this.colhost.Size = new System.Drawing.Size(0, 13);
            this.colhost.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 315);
            this.Controls.Add(this.colhost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fourthIP);
            this.Controls.Add(this.thirdIP);
            this.Controls.Add(this.secondIP);
            this.Controls.Add(this.firstIP);
            this.Controls.Add(this.ShirAd);
            this.Controls.Add(this.IPClass);
            this.Controls.Add(this.Mask);
            this.Controls.Add(this.IPNet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.MaskUnit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IPNet;
        private System.Windows.Forms.Label Mask;
        private System.Windows.Forms.Label IPClass;
        private System.Windows.Forms.Label ShirAd;
        private System.Windows.Forms.TextBox MaskUnit;
        private System.Windows.Forms.TextBox firstIP;
        private System.Windows.Forms.TextBox secondIP;
        private System.Windows.Forms.TextBox thirdIP;
        private System.Windows.Forms.TextBox fourthIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label colhost;
    }
}

