namespace Project_2___Section_1
{
    partial class P2S1Form
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.OrganismsLabel = new System.Windows.Forms.Label();
            this.DailyINCLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.NumbOrganismsTextBox = new System.Windows.Forms.TextBox();
            this.DailyINCTextBox = new System.Windows.Forms.TextBox();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.PopOfOrgCalcLabel = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            this.ChristianChernock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.HorizontalScrollbar = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(18, 163);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(531, 148);
            this.outputListBox.TabIndex = 0;
            // 
            // OrganismsLabel
            // 
            this.OrganismsLabel.AutoSize = true;
            this.OrganismsLabel.Location = new System.Drawing.Point(15, 29);
            this.OrganismsLabel.Name = "OrganismsLabel";
            this.OrganismsLabel.Size = new System.Drawing.Size(198, 17);
            this.OrganismsLabel.TabIndex = 1;
            this.OrganismsLabel.Text = "Starting number of organisms:";
            // 
            // DailyINCLabel
            // 
            this.DailyINCLabel.AutoSize = true;
            this.DailyINCLabel.Location = new System.Drawing.Point(15, 78);
            this.DailyINCLabel.Name = "DailyINCLabel";
            this.DailyINCLabel.Size = new System.Drawing.Size(156, 17);
            this.DailyINCLabel.TabIndex = 2;
            this.DailyINCLabel.Text = "Average daily increase:";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(18, 129);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(179, 17);
            this.DaysLabel.TabIndex = 3;
            this.DaysLabel.Text = "Number of days to multiply:";
            // 
            // NumbOrganismsTextBox
            // 
            this.NumbOrganismsTextBox.Location = new System.Drawing.Point(220, 29);
            this.NumbOrganismsTextBox.MaxLength = 11;
            this.NumbOrganismsTextBox.Name = "NumbOrganismsTextBox";
            this.NumbOrganismsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumbOrganismsTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumbOrganismsTextBox.TabIndex = 4;
            this.NumbOrganismsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DailyINCTextBox
            // 
            this.DailyINCTextBox.Location = new System.Drawing.Point(220, 78);
            this.DailyINCTextBox.MaxLength = 11;
            this.DailyINCTextBox.Name = "DailyINCTextBox";
            this.DailyINCTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DailyINCTextBox.Size = new System.Drawing.Size(100, 22);
            this.DailyINCTextBox.TabIndex = 5;
            this.DailyINCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(220, 123);
            this.DaysTextBox.MaxLength = 11;
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DaysTextBox.Size = new System.Drawing.Size(100, 22);
            this.DaysTextBox.TabIndex = 6;
            this.DaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(329, 327);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 41);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(445, 327);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 41);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(364, 25);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(173, 121);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(326, 81);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(20, 17);
            this.PercentLabel.TabIndex = 10;
            this.PercentLabel.Text = "%";
            // 
            // PopOfOrgCalcLabel
            // 
            this.PopOfOrgCalcLabel.AutoSize = true;
            this.PopOfOrgCalcLabel.Location = new System.Drawing.Point(46, 327);
            this.PopOfOrgCalcLabel.Name = "PopOfOrgCalcLabel";
            this.PopOfOrgCalcLabel.Size = new System.Drawing.Size(233, 17);
            this.PopOfOrgCalcLabel.TabIndex = 11;
            this.PopOfOrgCalcLabel.Text = "Population Of Organisms Calculator";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.Location = new System.Drawing.Point(148, 344);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(23, 17);
            this.by.TabIndex = 12;
            this.by.Text = "by";
            // 
            // ChristianChernock
            // 
            this.ChristianChernock.AutoSize = true;
            this.ChristianChernock.Location = new System.Drawing.Point(98, 361);
            this.ChristianChernock.Name = "ChristianChernock";
            this.ChristianChernock.Size = new System.Drawing.Size(127, 17);
            this.ChristianChernock.TabIndex = 13;
            this.ChristianChernock.Text = "Christian Chernock";
            // 
            // P2S1Form
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 394);
            this.Controls.Add(this.ChristianChernock);
            this.Controls.Add(this.by);
            this.Controls.Add(this.PopOfOrgCalcLabel);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.DailyINCTextBox);
            this.Controls.Add(this.NumbOrganismsTextBox);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.DailyINCLabel);
            this.Controls.Add(this.OrganismsLabel);
            this.Controls.Add(this.outputListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 492);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "P2S1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P2S1 Population Of Organisms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label OrganismsLabel;
        private System.Windows.Forms.Label DailyINCLabel;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.TextBox NumbOrganismsTextBox;
        private System.Windows.Forms.TextBox DailyINCTextBox;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label PopOfOrgCalcLabel;
        private System.Windows.Forms.Label by;
        private System.Windows.Forms.Label ChristianChernock;
    }
}

