﻿namespace DesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OilTypelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnleaded95Amount = new System.Windows.Forms.TextBox();
            this.txtMaxEuroDieselAmount = new System.Windows.Forms.TextBox();
            this.txtProEuroDieselAmount = new System.Windows.Forms.TextBox();
            this.txtAutoGasAmount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.unleaded95 = new System.Windows.Forms.ProgressBar();
            this.maxEuroDiesel = new System.Windows.Forms.ProgressBar();
            this.proEuroDiesel = new System.Windows.Forms.ProgressBar();
            this.autoGas = new System.Windows.Forms.ProgressBar();
            this.lblUnleaded95liter = new System.Windows.Forms.Label();
            this.lblMaxEuroDieselLiter = new System.Windows.Forms.Label();
            this.lblProEuroDieselLiter = new System.Windows.Forms.Label();
            this.lblAutogasLiter = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPlaque = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblUnleaded95 = new System.Windows.Forms.Label();
            this.lblMaxEuroDiesel = new System.Windows.Forms.Label();
            this.lblProEuroDiesel = new System.Windows.Forms.Label();
            this.lblAutoGas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.lblCase = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAutoGas);
            this.groupBox1.Controls.Add(this.lblProEuroDiesel);
            this.groupBox1.Controls.Add(this.lblMaxEuroDiesel);
            this.groupBox1.Controls.Add(this.lblUnleaded95);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OilTypelbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // OilTypelbl
            // 
            this.OilTypelbl.AutoSize = true;
            this.OilTypelbl.Font = new System.Drawing.Font("Cambria", 18F);
            this.OilTypelbl.Location = new System.Drawing.Point(15, 33);
            this.OilTypelbl.Name = "OilTypelbl";
            this.OilTypelbl.Size = new System.Drawing.Size(97, 28);
            this.OilTypelbl.TabIndex = 0;
            this.OilTypelbl.Text = "Oil Type";
            this.OilTypelbl.Click += new System.EventHandler(this.OilTypelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(205, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liter Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "V/Max Unleaded 95";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "V/Max EuroDiesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "V/Pro EuroDiesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Po/Gas AutoGas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.btnFill);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtPlaque);
            this.groupBox2.Controls.Add(this.txtAutoGasAmount);
            this.groupBox2.Controls.Add(this.txtProEuroDieselAmount);
            this.groupBox2.Controls.Add(this.txtMaxEuroDieselAmount);
            this.groupBox2.Controls.Add(this.txtUnleaded95Amount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 18F);
            this.label6.Location = new System.Drawing.Point(28, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Liter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 18F);
            this.label7.Location = new System.Drawing.Point(190, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Amount";
            // 
            // txtUnleaded95Amount
            // 
            this.txtUnleaded95Amount.Location = new System.Drawing.Point(195, 76);
            this.txtUnleaded95Amount.Name = "txtUnleaded95Amount";
            this.txtUnleaded95Amount.Size = new System.Drawing.Size(102, 20);
            this.txtUnleaded95Amount.TabIndex = 6;
            // 
            // txtMaxEuroDieselAmount
            // 
            this.txtMaxEuroDieselAmount.Location = new System.Drawing.Point(195, 102);
            this.txtMaxEuroDieselAmount.Name = "txtMaxEuroDieselAmount";
            this.txtMaxEuroDieselAmount.Size = new System.Drawing.Size(102, 20);
            this.txtMaxEuroDieselAmount.TabIndex = 7;
            // 
            // txtProEuroDieselAmount
            // 
            this.txtProEuroDieselAmount.Location = new System.Drawing.Point(195, 127);
            this.txtProEuroDieselAmount.Name = "txtProEuroDieselAmount";
            this.txtProEuroDieselAmount.Size = new System.Drawing.Size(102, 20);
            this.txtProEuroDieselAmount.TabIndex = 8;
            // 
            // txtAutoGasAmount
            // 
            this.txtAutoGasAmount.Location = new System.Drawing.Point(195, 152);
            this.txtAutoGasAmount.Name = "txtAutoGasAmount";
            this.txtAutoGasAmount.Size = new System.Drawing.Size(102, 20);
            this.txtAutoGasAmount.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblAutogasLiter);
            this.groupBox3.Controls.Add(this.lblProEuroDieselLiter);
            this.groupBox3.Controls.Add(this.lblMaxEuroDieselLiter);
            this.groupBox3.Controls.Add(this.lblUnleaded95liter);
            this.groupBox3.Controls.Add(this.autoGas);
            this.groupBox3.Controls.Add(this.proEuroDiesel);
            this.groupBox3.Controls.Add(this.maxEuroDiesel);
            this.groupBox3.Controls.Add(this.unleaded95);
            this.groupBox3.Location = new System.Drawing.Point(792, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // unleaded95
            // 
            this.unleaded95.Location = new System.Drawing.Point(22, 73);
            this.unleaded95.Maximum = 10000;
            this.unleaded95.Name = "unleaded95";
            this.unleaded95.Size = new System.Drawing.Size(276, 23);
            this.unleaded95.TabIndex = 0;
            this.unleaded95.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // maxEuroDiesel
            // 
            this.maxEuroDiesel.Location = new System.Drawing.Point(22, 99);
            this.maxEuroDiesel.Maximum = 10000;
            this.maxEuroDiesel.Name = "maxEuroDiesel";
            this.maxEuroDiesel.Size = new System.Drawing.Size(276, 23);
            this.maxEuroDiesel.TabIndex = 1;
            // 
            // proEuroDiesel
            // 
            this.proEuroDiesel.Location = new System.Drawing.Point(22, 124);
            this.proEuroDiesel.Maximum = 10000;
            this.proEuroDiesel.Name = "proEuroDiesel";
            this.proEuroDiesel.Size = new System.Drawing.Size(276, 23);
            this.proEuroDiesel.TabIndex = 2;
            // 
            // autoGas
            // 
            this.autoGas.Location = new System.Drawing.Point(22, 149);
            this.autoGas.Maximum = 10000;
            this.autoGas.Name = "autoGas";
            this.autoGas.Size = new System.Drawing.Size(276, 23);
            this.autoGas.TabIndex = 3;
            // 
            // lblUnleaded95liter
            // 
            this.lblUnleaded95liter.AutoSize = true;
            this.lblUnleaded95liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnleaded95liter.Location = new System.Drawing.Point(304, 75);
            this.lblUnleaded95liter.Name = "lblUnleaded95liter";
            this.lblUnleaded95liter.Size = new System.Drawing.Size(46, 18);
            this.lblUnleaded95liter.TabIndex = 4;
            this.lblUnleaded95liter.Text = "label8";
            // 
            // lblMaxEuroDieselLiter
            // 
            this.lblMaxEuroDieselLiter.AutoSize = true;
            this.lblMaxEuroDieselLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxEuroDieselLiter.Location = new System.Drawing.Point(304, 102);
            this.lblMaxEuroDieselLiter.Name = "lblMaxEuroDieselLiter";
            this.lblMaxEuroDieselLiter.Size = new System.Drawing.Size(46, 18);
            this.lblMaxEuroDieselLiter.TabIndex = 5;
            this.lblMaxEuroDieselLiter.Text = "label9";
            // 
            // lblProEuroDieselLiter
            // 
            this.lblProEuroDieselLiter.AutoSize = true;
            this.lblProEuroDieselLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProEuroDieselLiter.Location = new System.Drawing.Point(304, 129);
            this.lblProEuroDieselLiter.Name = "lblProEuroDieselLiter";
            this.lblProEuroDieselLiter.Size = new System.Drawing.Size(54, 18);
            this.lblProEuroDieselLiter.TabIndex = 6;
            this.lblProEuroDieselLiter.Text = "label10";
            // 
            // lblAutogasLiter
            // 
            this.lblAutogasLiter.AutoSize = true;
            this.lblAutogasLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAutogasLiter.Location = new System.Drawing.Point(304, 155);
            this.lblAutogasLiter.Name = "lblAutogasLiter";
            this.lblAutogasLiter.Size = new System.Drawing.Size(54, 18);
            this.lblAutogasLiter.TabIndex = 7;
            this.lblAutogasLiter.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 18F);
            this.label12.Location = new System.Drawing.Point(17, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 28);
            this.label12.TabIndex = 8;
            this.label12.Text = "Storage Oil Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 18F);
            this.label13.Location = new System.Drawing.Point(17, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 28);
            this.label13.TabIndex = 9;
            this.label13.Text = "Case";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCase);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(792, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 177);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtPlaque
            // 
            this.txtPlaque.Location = new System.Drawing.Point(117, 228);
            this.txtPlaque.Name = "txtPlaque";
            this.txtPlaque.Size = new System.Drawing.Size(180, 20);
            this.txtPlaque.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 18F);
            this.label14.Location = new System.Drawing.Point(28, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 28);
            this.label14.TabIndex = 11;
            this.label14.Text = "Plaque";
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Cambria", 18F);
            this.btnFill.Location = new System.Drawing.Point(33, 356);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(271, 47);
            this.btnFill.TabIndex = 12;
            this.btnFill.Text = "Fill In";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // lblUnleaded95
            // 
            this.lblUnleaded95.AutoSize = true;
            this.lblUnleaded95.Location = new System.Drawing.Point(210, 79);
            this.lblUnleaded95.Name = "lblUnleaded95";
            this.lblUnleaded95.Size = new System.Drawing.Size(41, 13);
            this.lblUnleaded95.TabIndex = 6;
            this.lblUnleaded95.Text = "label15";
            // 
            // lblMaxEuroDiesel
            // 
            this.lblMaxEuroDiesel.AutoSize = true;
            this.lblMaxEuroDiesel.Location = new System.Drawing.Point(210, 105);
            this.lblMaxEuroDiesel.Name = "lblMaxEuroDiesel";
            this.lblMaxEuroDiesel.Size = new System.Drawing.Size(41, 13);
            this.lblMaxEuroDiesel.TabIndex = 7;
            this.lblMaxEuroDiesel.Text = "label15";
            this.lblMaxEuroDiesel.Click += new System.EventHandler(this.lblMaxEuroDiesel_Click);
            // 
            // lblProEuroDiesel
            // 
            this.lblProEuroDiesel.AutoSize = true;
            this.lblProEuroDiesel.Location = new System.Drawing.Point(210, 130);
            this.lblProEuroDiesel.Name = "lblProEuroDiesel";
            this.lblProEuroDiesel.Size = new System.Drawing.Size(84, 13);
            this.lblProEuroDiesel.TabIndex = 8;
            this.lblProEuroDiesel.Text = "lblProEuroDiesel";
            // 
            // lblAutoGas
            // 
            this.lblAutoGas.AutoSize = true;
            this.lblAutoGas.Location = new System.Drawing.Point(210, 155);
            this.lblAutoGas.Name = "lblAutoGas";
            this.lblAutoGas.Size = new System.Drawing.Size(41, 13);
            this.lblAutoGas.TabIndex = 9;
            this.lblAutoGas.Text = "label15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(33, 102);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(33, 127);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 15;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(33, 152);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCase.Location = new System.Drawing.Point(22, 90);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(124, 42);
            this.lblCase.TabIndex = 10;
            this.lblCase.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1271, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "OilTrackingAutomation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OilTypelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutoGasAmount;
        private System.Windows.Forms.TextBox txtProEuroDieselAmount;
        private System.Windows.Forms.TextBox txtMaxEuroDieselAmount;
        private System.Windows.Forms.TextBox txtUnleaded95Amount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar proEuroDiesel;
        private System.Windows.Forms.ProgressBar maxEuroDiesel;
        private System.Windows.Forms.ProgressBar unleaded95;
        private System.Windows.Forms.ProgressBar autoGas;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPlaque;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAutogasLiter;
        private System.Windows.Forms.Label lblProEuroDieselLiter;
        private System.Windows.Forms.Label lblMaxEuroDieselLiter;
        private System.Windows.Forms.Label lblUnleaded95liter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMaxEuroDiesel;
        private System.Windows.Forms.Label lblUnleaded95;
        private System.Windows.Forms.Label lblAutoGas;
        private System.Windows.Forms.Label lblProEuroDiesel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCase;
    }
}
