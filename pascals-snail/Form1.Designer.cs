﻿namespace pascals_snail
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aSpinBox = new System.Windows.Forms.NumericUpDown();
            this.bSpinBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSpinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSpinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 61);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(450, 450);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // aSpinBox
            // 
            this.aSpinBox.Location = new System.Drawing.Point(31, 9);
            this.aSpinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aSpinBox.Name = "aSpinBox";
            this.aSpinBox.Size = new System.Drawing.Size(120, 20);
            this.aSpinBox.TabIndex = 3;
            this.aSpinBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.aSpinBox.ValueChanged += new System.EventHandler(this.repaint);
            // 
            // bSpinBox
            // 
            this.bSpinBox.Location = new System.Drawing.Point(31, 35);
            this.bSpinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bSpinBox.Name = "bSpinBox";
            this.bSpinBox.Size = new System.Drawing.Size(120, 20);
            this.bSpinBox.TabIndex = 4;
            this.bSpinBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.bSpinBox.ValueChanged += new System.EventHandler(this.repaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 523);
            this.Controls.Add(this.bSpinBox);
            this.Controls.Add(this.aSpinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Pascal\'s Snail";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSpinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSpinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown aSpinBox;
        private System.Windows.Forms.NumericUpDown bSpinBox;
    }
}

