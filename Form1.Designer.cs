﻿namespace YilanOyunu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRe = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.buttonStop);
            this.panel2.Controls.Add(this.buttonRe);
            this.panel2.Controls.Add(this.labelScore);
            this.panel2.Controls.Add(this.labelPuan);
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 600);
            this.panel2.TabIndex = 1;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonStop.Location = new System.Drawing.Point(6, 368);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(182, 80);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Durdur";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonRe
            // 
            this.buttonRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.buttonRe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRe.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRe.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonRe.Location = new System.Drawing.Point(6, 245);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(182, 80);
            this.buttonRe.TabIndex = 3;
            this.buttonRe.Text = "Yeniden Oyna";
            this.buttonRe.UseVisualStyleBackColor = false;
            this.buttonRe.Click += new System.EventHandler(this.ButtonRe_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelScore.Location = new System.Drawing.Point(61, 116);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(62, 68);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuan.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelPuan.Location = new System.Drawing.Point(16, 48);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(163, 68);
            this.labelPuan.TabIndex = 1;
            this.labelPuan.Text = "Puan";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExit.ForeColor = System.Drawing.Color.DarkRed;
            this.labelExit.Location = new System.Drawing.Point(164, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(36, 32);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "X";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelExit.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SneakGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRe;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Timer timer1;
    }
}

