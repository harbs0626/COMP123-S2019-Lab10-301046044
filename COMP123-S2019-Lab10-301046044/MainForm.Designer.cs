﻿namespace COMP123_S2019_Lab10_301046044
{
    partial class MainForm
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
            this.MainFormLabel = new System.Windows.Forms.Label();
            this.MainFormNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainFormLabel
            // 
            this.MainFormLabel.AutoSize = true;
            this.MainFormLabel.Location = new System.Drawing.Point(12, 9);
            this.MainFormLabel.Name = "MainFormLabel";
            this.MainFormLabel.Size = new System.Drawing.Size(299, 31);
            this.MainFormLabel.TabIndex = 0;
            this.MainFormLabel.Text = "Welcome to Main Form!";
            // 
            // MainFormNextButton
            // 
            this.MainFormNextButton.Location = new System.Drawing.Point(18, 52);
            this.MainFormNextButton.Name = "MainFormNextButton";
            this.MainFormNextButton.Size = new System.Drawing.Size(220, 54);
            this.MainFormNextButton.TabIndex = 1;
            this.MainFormNextButton.Text = "Next Button";
            this.MainFormNextButton.UseVisualStyleBackColor = true;
            this.MainFormNextButton.Click += new System.EventHandler(this.MainFormNextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainFormNextButton);
            this.Controls.Add(this.MainFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainFormLabel;
        private System.Windows.Forms.Button MainFormNextButton;
    }
}

