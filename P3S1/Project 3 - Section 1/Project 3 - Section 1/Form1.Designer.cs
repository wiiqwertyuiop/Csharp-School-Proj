namespace Project_3___Section_1 {
    partial class P3S1DataFileTasksForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.CDCListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LetterDropBox = new System.Windows.Forms.ComboBox();
            this.ExportCSVButton = new System.Windows.Forms.Button();
            this.ExportTXTButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CDC Locations";
            // 
            // CDCListBox
            // 
            this.CDCListBox.FormattingEnabled = true;
            this.CDCListBox.ItemHeight = 16;
            this.CDCListBox.Location = new System.Drawing.Point(48, 48);
            this.CDCListBox.Name = "CDCListBox";
            this.CDCListBox.Size = new System.Drawing.Size(152, 228);
            this.CDCListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter List Using Letter";
            // 
            // LetterDropBox
            // 
            this.LetterDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LetterDropBox.FormattingEnabled = true;
            this.LetterDropBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.LetterDropBox.Location = new System.Drawing.Point(222, 48);
            this.LetterDropBox.MaxDropDownItems = 26;
            this.LetterDropBox.Name = "LetterDropBox";
            this.LetterDropBox.Size = new System.Drawing.Size(66, 24);
            this.LetterDropBox.TabIndex = 3;
            // 
            // ExportCSVButton
            // 
            this.ExportCSVButton.Location = new System.Drawing.Point(302, 167);
            this.ExportCSVButton.Name = "ExportCSVButton";
            this.ExportCSVButton.Size = new System.Drawing.Size(270, 33);
            this.ExportCSVButton.TabIndex = 4;
            this.ExportCSVButton.Text = "Export To &Delimited File (.csv)";
            this.ExportCSVButton.UseVisualStyleBackColor = true;
            this.ExportCSVButton.Click += new System.EventHandler(this.ExportCSVButton_Click);
            // 
            // ExportTXTButton
            // 
            this.ExportTXTButton.Location = new System.Drawing.Point(302, 206);
            this.ExportTXTButton.Name = "ExportTXTButton";
            this.ExportTXTButton.Size = new System.Drawing.Size(270, 28);
            this.ExportTXTButton.TabIndex = 5;
            this.ExportTXTButton.Text = "Export To &Fixed Width Text File (.txt)";
            this.ExportTXTButton.UseVisualStyleBackColor = true;
            this.ExportTXTButton.Click += new System.EventHandler(this.ExportTXTButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(497, 240);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 24);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // P3S1DataFileTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 295);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExportTXTButton);
            this.Controls.Add(this.ExportCSVButton);
            this.Controls.Add(this.LetterDropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CDCListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "P3S1DataFileTasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P3S1 Data File Tasks";
            this.Load += new System.EventHandler(this.P3S1DataFileTasksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CDCListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LetterDropBox;
        private System.Windows.Forms.Button ExportCSVButton;
        private System.Windows.Forms.Button ExportTXTButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

