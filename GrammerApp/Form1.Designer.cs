﻿namespace GrammerApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.shimmertable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.edavalue = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bescvalue = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.kraftvalue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.subjlabel = new System.Windows.Forms.Label();
            this.subjvalue = new System.Windows.Forms.Label();
            this.ProtocolTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 159);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::GrammerApp.Properties.Resources.start;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Location = new System.Drawing.Point(1346, 55);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(67, 63);
            this.Stop.TabIndex = 1;
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 157);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.ProtocolTb);
            this.panel2.Controls.Add(this.shimmertable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 587);
            this.panel2.TabIndex = 1;
            // 
            // shimmertable
            // 
            this.shimmertable.ColumnCount = 3;
            this.shimmertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.shimmertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.shimmertable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.shimmertable.Location = new System.Drawing.Point(8, 468);
            this.shimmertable.Name = "shimmertable";
            this.shimmertable.RowCount = 2;
            this.shimmertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shimmertable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shimmertable.Size = new System.Drawing.Size(425, 100);
            this.shimmertable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 424);
            this.label2.MaximumSize = new System.Drawing.Size(900, 50);
            this.label2.MinimumSize = new System.Drawing.Size(430, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shimmer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.MaximumSize = new System.Drawing.Size(900, 50);
            this.label1.MinimumSize = new System.Drawing.Size(430, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAQ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1206, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 587);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.edavalue);
            this.panel7.Location = new System.Drawing.Point(3, 435);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(221, 100);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(95, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "EDA";
            // 
            // edavalue
            // 
            this.edavalue.AutoSize = true;
            this.edavalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edavalue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.edavalue.Location = new System.Drawing.Point(116, 18);
            this.edavalue.Name = "edavalue";
            this.edavalue.Size = new System.Drawing.Size(24, 31);
            this.edavalue.TabIndex = 0;
            this.edavalue.Text = "-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.bescvalue);
            this.panel6.Location = new System.Drawing.Point(3, 294);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 100);
            this.panel6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(37, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Beschleunigung";
            // 
            // bescvalue
            // 
            this.bescvalue.AutoSize = true;
            this.bescvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bescvalue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bescvalue.Location = new System.Drawing.Point(116, 18);
            this.bescvalue.Name = "bescvalue";
            this.bescvalue.Size = new System.Drawing.Size(24, 31);
            this.bescvalue.TabIndex = 0;
            this.bescvalue.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.kraftvalue);
            this.panel5.Location = new System.Drawing.Point(3, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 100);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(95, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kraft";
            // 
            // kraftvalue
            // 
            this.kraftvalue.AutoSize = true;
            this.kraftvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kraftvalue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kraftvalue.Location = new System.Drawing.Point(116, 18);
            this.kraftvalue.Name = "kraftvalue";
            this.kraftvalue.Size = new System.Drawing.Size(24, 31);
            this.kraftvalue.TabIndex = 0;
            this.kraftvalue.Text = "-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.subjlabel);
            this.panel4.Controls.Add(this.subjvalue);
            this.panel4.Location = new System.Drawing.Point(4, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 100);
            this.panel4.TabIndex = 0;
            // 
            // subjlabel
            // 
            this.subjlabel.AutoSize = true;
            this.subjlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjlabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.subjlabel.Location = new System.Drawing.Point(49, 66);
            this.subjlabel.Name = "subjlabel";
            this.subjlabel.Size = new System.Drawing.Size(141, 25);
            this.subjlabel.TabIndex = 1;
            this.subjlabel.Text = "Subj. Wahrn";
            // 
            // subjvalue
            // 
            this.subjvalue.AutoSize = true;
            this.subjvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjvalue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subjvalue.Location = new System.Drawing.Point(116, 18);
            this.subjvalue.Name = "subjvalue";
            this.subjvalue.Size = new System.Drawing.Size(24, 31);
            this.subjvalue.TabIndex = 0;
            this.subjvalue.Text = "-";
            // 
            // ProtocolTb
            // 
            this.ProtocolTb.Location = new System.Drawing.Point(7, 52);
            this.ProtocolTb.Multiline = true;
            this.ProtocolTb.Name = "ProtocolTb";
            this.ProtocolTb.Size = new System.Drawing.Size(425, 343);
            this.ProtocolTb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1439, 746);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TableLayoutPanel shimmertable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label edavalue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bescvalue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kraftvalue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label subjlabel;
        private System.Windows.Forms.Label subjvalue;
        private System.Windows.Forms.TextBox ProtocolTb;
    }
}

