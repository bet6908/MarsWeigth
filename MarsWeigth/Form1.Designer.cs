namespace MarsWeigth
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
            this.btn_convertWgt = new System.Windows.Forms.Button();
            this.lbl_wgtEarth = new System.Windows.Forms.Label();
            this.lbl_wgtMars = new System.Windows.Forms.Label();
            this.txtWgtEarth = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_convertWgt
            // 
            this.btn_convertWgt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_convertWgt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convertWgt.Location = new System.Drawing.Point(304, 257);
            this.btn_convertWgt.Name = "btn_convertWgt";
            this.btn_convertWgt.Size = new System.Drawing.Size(100, 49);
            this.btn_convertWgt.TabIndex = 0;
            this.btn_convertWgt.Text = "Convert";
            this.btn_convertWgt.UseVisualStyleBackColor = false;
            this.btn_convertWgt.Click += new System.EventHandler(this.btn_convertWgt_Click);
            // 
            // lbl_wgtEarth
            // 
            this.lbl_wgtEarth.AutoSize = true;
            this.lbl_wgtEarth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_wgtEarth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_wgtEarth.Location = new System.Drawing.Point(23, 72);
            this.lbl_wgtEarth.Name = "lbl_wgtEarth";
            this.lbl_wgtEarth.Size = new System.Drawing.Size(246, 25);
            this.lbl_wgtEarth.TabIndex = 1;
            this.lbl_wgtEarth.Text = "Enter your Weight on Earth";
            // 
            // lbl_wgtMars
            // 
            this.lbl_wgtMars.AutoSize = true;
            this.lbl_wgtMars.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_wgtMars.Location = new System.Drawing.Point(81, 162);
            this.lbl_wgtMars.Name = "lbl_wgtMars";
            this.lbl_wgtMars.Size = new System.Drawing.Size(188, 25);
            this.lbl_wgtMars.TabIndex = 2;
            this.lbl_wgtMars.Text = "Your weight on Mars";
            // 
            // txtWgtEarth
            // 
            this.txtWgtEarth.BackColor = System.Drawing.Color.Maroon;
            this.txtWgtEarth.ForeColor = System.Drawing.SystemColors.Window;
            this.txtWgtEarth.Location = new System.Drawing.Point(304, 74);
            this.txtWgtEarth.Name = "txtWgtEarth";
            this.txtWgtEarth.Size = new System.Drawing.Size(100, 23);
            this.txtWgtEarth.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Maroon;
            this.txtOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(304, 162);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 23);
            this.txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(475, 372);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtWgtEarth);
            this.Controls.Add(this.lbl_wgtMars);
            this.Controls.Add(this.lbl_wgtEarth);
            this.Controls.Add(this.btn_convertWgt);
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_convertWgt;
        private Label lbl_wgtEarth;
        private Label lbl_wgtMars;
        private TextBox txtWgtEarth;
        private TextBox txtOutput;
    }
}