﻿namespace UTS_PBO
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 19);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 0;
            label1.Text = "CONTACT APP";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(221, 326);
            button1.Name = "button1";
            button1.Size = new Size(96, 30);
            button1.TabIndex = 1;
            button1.Text = "Kontak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 326);
            button2.Name = "button2";
            button2.Size = new Size(96, 30);
            button2.TabIndex = 2;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(510, 326);
            button3.Name = "button3";
            button3.Size = new Size(96, 30);
            button3.TabIndex = 3;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 94);
            label2.Name = "label2";
            label2.Size = new Size(435, 50);
            label2.TabIndex = 4;
            label2.Text = "Welcome to Contact App";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}
