﻿namespace JARVIS
{
    partial class frmJarvis
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
            this.cbRecognise = new System.Windows.Forms.CheckBox();
            this.cbSynthesis = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRecognise
            // 
            this.cbRecognise.AutoSize = true;
            this.cbRecognise.ForeColor = System.Drawing.Color.White;
            this.cbRecognise.Location = new System.Drawing.Point(8, 23);
            this.cbRecognise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRecognise.Name = "cbRecognise";
            this.cbRecognise.Size = new System.Drawing.Size(105, 21);
            this.cbRecognise.TabIndex = 4;
            this.cbRecognise.Text = "Recognition";
            this.cbRecognise.UseVisualStyleBackColor = true;
            this.cbRecognise.CheckedChanged += new System.EventHandler(this.cbRecognise_CheckedChanged);
            // 
            // cbSynthesis
            // 
            this.cbSynthesis.AutoSize = true;
            this.cbSynthesis.ForeColor = System.Drawing.Color.White;
            this.cbSynthesis.Location = new System.Drawing.Point(8, 52);
            this.cbSynthesis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSynthesis.Name = "cbSynthesis";
            this.cbSynthesis.Size = new System.Drawing.Size(91, 21);
            this.cbSynthesis.TabIndex = 5;
            this.cbSynthesis.Text = "Synthesis";
            this.cbSynthesis.UseVisualStyleBackColor = true;
            this.cbSynthesis.CheckedChanged += new System.EventHandler(this.cbSynthesis_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSynthesis);
            this.groupBox1.Controls.Add(this.cbRecognise);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(793, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(133, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disable";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(793, 15);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(116, 33);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(685, 588);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(100, 28);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Read";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.MediumBlue;
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(16, 591);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(660, 22);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.MediumBlue;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(16, 15);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(768, 568);
            this.txtOutput.TabIndex = 2;
            // 
            // frmJarvis
            // 
            this.AcceptButton = this.btnInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(936, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSettings);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJarvis";
            this.Text = "JARVIS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJarvis_FormClosed);
            this.Load += new System.EventHandler(this.frmJarvis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRecognise;
        private System.Windows.Forms.CheckBox cbSynthesis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

