﻿namespace csharp_notuyg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Sınav Notunu Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 95);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "2.Sınav Notunu Giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 137);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Proje Notunu Giriniz:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(312, 179);
            button1.Name = "button1";
            button1.Size = new Size(181, 29);
            button1.TabIndex = 3;
            button1.Text = "Ortalma Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(312, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 231);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "ortalmanız:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1073, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
    }
}
