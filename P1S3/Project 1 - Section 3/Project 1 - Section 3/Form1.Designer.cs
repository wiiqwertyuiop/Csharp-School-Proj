namespace Project_1___Section_3
{
    partial class BMICalculator
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
            this.LBSBox = new System.Windows.Forms.TextBox();
            this.LBSLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.INSBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.INSLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBSBox
            // 
            this.LBSBox.Location = new System.Drawing.Point(129, 19);
            this.LBSBox.MaxLength = 4;
            this.LBSBox.Name = "LBSBox";
            this.LBSBox.Size = new System.Drawing.Size(49, 22);
            this.LBSBox.TabIndex = 4;
            // 
            // LBSLabel
            // 
            this.LBSLabel.AutoSize = true;
            this.LBSLabel.Location = new System.Drawing.Point(184, 24);
            this.LBSLabel.Name = "LBSLabel";
            this.LBSLabel.Size = new System.Drawing.Size(87, 17);
            this.LBSLabel.TabIndex = 8;
            this.LBSLabel.Text = "pounds (lbs)";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(6, 24);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(122, 17);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "Enter your weight:";
            // 
            // INSBox
            // 
            this.INSBox.Location = new System.Drawing.Point(129, 69);
            this.INSBox.MaxLength = 4;
            this.INSBox.Name = "INSBox";
            this.INSBox.Size = new System.Drawing.Size(49, 22);
            this.INSBox.TabIndex = 6;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(6, 74);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(121, 17);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Enter your height:";
            // 
            // INSLabel
            // 
            this.INSLabel.AutoSize = true;
            this.INSLabel.Location = new System.Drawing.Point(184, 74);
            this.INSLabel.Name = "INSLabel";
            this.INSLabel.Size = new System.Drawing.Size(81, 17);
            this.INSLabel.TabIndex = 10;
            this.INSLabel.Text = "inches (ins)";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(84, 108);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(94, 23);
            this.CalcButton.TabIndex = 11;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(9, 147);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(256, 50);
            this.OutputTextBox.TabIndex = 12;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(175, 213);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(90, 28);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 213);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 28);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.INSLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.LBSBox);
            this.Controls.Add(this.LBSLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.INSBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1S3 BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LBSBox;
        private System.Windows.Forms.Label LBSLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox INSBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label INSLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

