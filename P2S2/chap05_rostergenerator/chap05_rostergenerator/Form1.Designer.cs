namespace RosterGenerator
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.AvailPlayersListBox = new System.Windows.Forms.ListBox();
            this.SelPlayersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mov1AvailBttn = new System.Windows.Forms.Button();
            this.MovAllAvailBttn = new System.Windows.Forms.Button();
            this.Mov1SelBttn = new System.Windows.Forms.Button();
            this.MovAllSelAvailBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WriteInLabel = new System.Windows.Forms.Label();
            this.WriteInPlayerTextBox = new System.Windows.Forms.TextBox();
            this.AddWriteInPlayerBttn = new System.Windows.Forms.Button();
            this.Delete1AvailBttn = new System.Windows.Forms.Button();
            this.EditAvailBttn = new System.Windows.Forms.Button();
            this.DeleteAllAvailBttn = new System.Windows.Forms.Button();
            this.ImportRosterBttn = new System.Windows.Forms.Button();
            this.PrintRosterBttn = new System.Windows.Forms.Button();
            this.ExportRosterBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.TeamComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExportRosterFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MoveUpFormBttn = new System.Windows.Forms.Button();
            this.MoveDownFormBttn = new System.Windows.Forms.Button();
            this.RosterGeneratorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDialogBox = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RosterGeneratorContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailPlayersListBox
            // 
            this.AvailPlayersListBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailPlayersListBox.FormattingEnabled = true;
            this.AvailPlayersListBox.ItemHeight = 16;
            this.AvailPlayersListBox.Items.AddRange(new object[] {
            "Boswell, Susan",
            "Claus, Santa",
            "Conwell, Adam",
            "Dietz, Carl",
            "Higgs, Rodney",
            "Jennings, Barry",
            "Mendeleson, Cathy",
            "Niker, Gary",
            "Oslund, Matthew",
            "Powell, Joe",
            "Rodriguez, Alex",
            "Ruth, Babe",
            "Smith, Freddie",
            "Stucey, Jack",
            "Trevetone, Donna",
            "Veniere, Henry"});
            this.AvailPlayersListBox.Location = new System.Drawing.Point(12, 116);
            this.AvailPlayersListBox.Name = "AvailPlayersListBox";
            this.AvailPlayersListBox.Size = new System.Drawing.Size(129, 164);
            this.AvailPlayersListBox.Sorted = true;
            this.AvailPlayersListBox.TabIndex = 1;
            // 
            // SelPlayersListBox
            // 
            this.SelPlayersListBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelPlayersListBox.FormattingEnabled = true;
            this.SelPlayersListBox.ItemHeight = 16;
            this.SelPlayersListBox.Location = new System.Drawing.Point(277, 116);
            this.SelPlayersListBox.Name = "SelPlayersListBox";
            this.SelPlayersListBox.Size = new System.Drawing.Size(121, 164);
            this.SelPlayersListBox.Sorted = true;
            this.SelPlayersListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Players";
            // 
            // Mov1AvailBttn
            // 
            this.Mov1AvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mov1AvailBttn.Location = new System.Drawing.Point(178, 99);
            this.Mov1AvailBttn.Name = "Mov1AvailBttn";
            this.Mov1AvailBttn.Size = new System.Drawing.Size(59, 23);
            this.Mov1AvailBttn.TabIndex = 2;
            this.Mov1AvailBttn.Text = ">";
            this.Mov1AvailBttn.UseVisualStyleBackColor = true;
            this.Mov1AvailBttn.Click += new System.EventHandler(this.Mov1AvailBttn_Click);
            // 
            // MovAllAvailBttn
            // 
            this.MovAllAvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovAllAvailBttn.Location = new System.Drawing.Point(178, 128);
            this.MovAllAvailBttn.Name = "MovAllAvailBttn";
            this.MovAllAvailBttn.Size = new System.Drawing.Size(59, 23);
            this.MovAllAvailBttn.TabIndex = 4;
            this.MovAllAvailBttn.Text = ">>";
            this.MovAllAvailBttn.UseVisualStyleBackColor = true;
            this.MovAllAvailBttn.Click += new System.EventHandler(this.MovAllAvailBttn_Click);
            // 
            // Mov1SelBttn
            // 
            this.Mov1SelBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mov1SelBttn.Location = new System.Drawing.Point(178, 166);
            this.Mov1SelBttn.Name = "Mov1SelBttn";
            this.Mov1SelBttn.Size = new System.Drawing.Size(59, 23);
            this.Mov1SelBttn.TabIndex = 5;
            this.Mov1SelBttn.Text = "<";
            this.Mov1SelBttn.UseVisualStyleBackColor = true;
            this.Mov1SelBttn.Click += new System.EventHandler(this.Mov1SelBttn_Click);
            // 
            // MovAllSelAvailBttn
            // 
            this.MovAllSelAvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovAllSelAvailBttn.Location = new System.Drawing.Point(178, 195);
            this.MovAllSelAvailBttn.Name = "MovAllSelAvailBttn";
            this.MovAllSelAvailBttn.Size = new System.Drawing.Size(59, 23);
            this.MovAllSelAvailBttn.TabIndex = 6;
            this.MovAllSelAvailBttn.Text = "<<";
            this.MovAllSelAvailBttn.UseVisualStyleBackColor = true;
            this.MovAllSelAvailBttn.Click += new System.EventHandler(this.MovAllSelAvailBttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tea&m";
            // 
            // WriteInLabel
            // 
            this.WriteInLabel.AutoSize = true;
            this.WriteInLabel.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteInLabel.Location = new System.Drawing.Point(12, 294);
            this.WriteInLabel.Name = "WriteInLabel";
            this.WriteInLabel.Size = new System.Drawing.Size(80, 17);
            this.WriteInLabel.TabIndex = 9;
            this.WriteInLabel.Text = "Write-in Player";
            // 
            // WriteInPlayerTextBox
            // 
            this.WriteInPlayerTextBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteInPlayerTextBox.Location = new System.Drawing.Point(15, 309);
            this.WriteInPlayerTextBox.Name = "WriteInPlayerTextBox";
            this.WriteInPlayerTextBox.Size = new System.Drawing.Size(106, 22);
            this.WriteInPlayerTextBox.TabIndex = 9;
            // 
            // AddWriteInPlayerBttn
            // 
            this.AddWriteInPlayerBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWriteInPlayerBttn.Location = new System.Drawing.Point(127, 307);
            this.AddWriteInPlayerBttn.Name = "AddWriteInPlayerBttn";
            this.AddWriteInPlayerBttn.Size = new System.Drawing.Size(100, 30);
            this.AddWriteInPlayerBttn.TabIndex = 10;
            this.AddWriteInPlayerBttn.Text = "&Add";
            this.AddWriteInPlayerBttn.UseVisualStyleBackColor = true;
            this.AddWriteInPlayerBttn.Click += new System.EventHandler(this.AddWriteInPlayerBttn_Click);
            // 
            // Delete1AvailBttn
            // 
            this.Delete1AvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete1AvailBttn.Location = new System.Drawing.Point(15, 345);
            this.Delete1AvailBttn.Name = "Delete1AvailBttn";
            this.Delete1AvailBttn.Size = new System.Drawing.Size(100, 30);
            this.Delete1AvailBttn.TabIndex = 12;
            this.Delete1AvailBttn.Text = "&Delete";
            this.Delete1AvailBttn.UseVisualStyleBackColor = true;
            this.Delete1AvailBttn.Click += new System.EventHandler(this.Delete1AvailBttn_Click);
            // 
            // EditAvailBttn
            // 
            this.EditAvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAvailBttn.Location = new System.Drawing.Point(127, 345);
            this.EditAvailBttn.Name = "EditAvailBttn";
            this.EditAvailBttn.Size = new System.Drawing.Size(100, 30);
            this.EditAvailBttn.TabIndex = 13;
            this.EditAvailBttn.Text = "&Edit";
            this.EditAvailBttn.UseVisualStyleBackColor = true;
            this.EditAvailBttn.Click += new System.EventHandler(this.EditAvailBttn_Click);
            // 
            // DeleteAllAvailBttn
            // 
            this.DeleteAllAvailBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllAvailBttn.Location = new System.Drawing.Point(15, 383);
            this.DeleteAllAvailBttn.Name = "DeleteAllAvailBttn";
            this.DeleteAllAvailBttn.Size = new System.Drawing.Size(100, 30);
            this.DeleteAllAvailBttn.TabIndex = 15;
            this.DeleteAllAvailBttn.Text = "De&lete All";
            this.DeleteAllAvailBttn.UseVisualStyleBackColor = true;
            this.DeleteAllAvailBttn.Click += new System.EventHandler(this.DeleteAllAvailBttn_Click);
            // 
            // ImportRosterBttn
            // 
            this.ImportRosterBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportRosterBttn.Location = new System.Drawing.Point(127, 383);
            this.ImportRosterBttn.Name = "ImportRosterBttn";
            this.ImportRosterBttn.Size = new System.Drawing.Size(100, 30);
            this.ImportRosterBttn.TabIndex = 16;
            this.ImportRosterBttn.Text = "&Import Roster";
            this.ImportRosterBttn.UseVisualStyleBackColor = true;
            this.ImportRosterBttn.Click += new System.EventHandler(this.ImportRosterBttn_Click);
            // 
            // PrintRosterBttn
            // 
            this.PrintRosterBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintRosterBttn.Location = new System.Drawing.Point(277, 345);
            this.PrintRosterBttn.Name = "PrintRosterBttn";
            this.PrintRosterBttn.Size = new System.Drawing.Size(100, 30);
            this.PrintRosterBttn.TabIndex = 14;
            this.PrintRosterBttn.Text = "&Print Roster";
            this.PrintRosterBttn.UseVisualStyleBackColor = true;
            this.PrintRosterBttn.Click += new System.EventHandler(this.PrintRosterBttn_Click);
            // 
            // ExportRosterBttn
            // 
            this.ExportRosterBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportRosterBttn.Location = new System.Drawing.Point(277, 383);
            this.ExportRosterBttn.Name = "ExportRosterBttn";
            this.ExportRosterBttn.Size = new System.Drawing.Size(100, 30);
            this.ExportRosterBttn.TabIndex = 17;
            this.ExportRosterBttn.Text = "Expor&t Roster";
            this.ExportRosterBttn.UseVisualStyleBackColor = true;
            this.ExportRosterBttn.Click += new System.EventHandler(this.ExportRosterBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBttn.Location = new System.Drawing.Point(277, 421);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(100, 32);
            this.ExitBttn.TabIndex = 18;
            this.ExitBttn.Text = "E&xit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // TeamComboBox
            // 
            this.TeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamComboBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamComboBox.FormattingEnabled = true;
            this.TeamComboBox.Items.AddRange(new object[] {
            "Blue Jays",
            "Orioles",
            "Rays",
            "Red Sox",
            "Yankees"});
            this.TeamComboBox.Location = new System.Drawing.Point(277, 309);
            this.TeamComboBox.Name = "TeamComboBox";
            this.TeamComboBox.Size = new System.Drawing.Size(121, 24);
            this.TeamComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Roster Generator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(137, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 72);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // MoveUpFormBttn
            // 
            this.MoveUpFormBttn.Location = new System.Drawing.Point(162, 224);
            this.MoveUpFormBttn.Name = "MoveUpFormBttn";
            this.MoveUpFormBttn.Size = new System.Drawing.Size(93, 29);
            this.MoveUpFormBttn.TabIndex = 7;
            this.MoveUpFormBttn.Text = "Move Up";
            this.MoveUpFormBttn.UseVisualStyleBackColor = true;
            this.MoveUpFormBttn.Click += new System.EventHandler(this.MoveUpFormBttn_Click);
            // 
            // MoveDownFormBttn
            // 
            this.MoveDownFormBttn.Location = new System.Drawing.Point(147, 259);
            this.MoveDownFormBttn.Name = "MoveDownFormBttn";
            this.MoveDownFormBttn.Size = new System.Drawing.Size(124, 28);
            this.MoveDownFormBttn.TabIndex = 8;
            this.MoveDownFormBttn.Text = "Move Down";
            this.MoveDownFormBttn.UseVisualStyleBackColor = true;
            this.MoveDownFormBttn.Click += new System.EventHandler(this.MoveDownFormBttn_Click);
            // 
            // RosterGeneratorContextMenu
            // 
            this.RosterGeneratorContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RosterGeneratorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.RosterGeneratorContextMenu.Name = "contextMenuStrip1";
            this.RosterGeneratorContextMenu.Size = new System.Drawing.Size(203, 100);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.moveUpToolStripMenuItem.Text = "Player Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.moveDownToolStripMenuItem.Text = "Player Move Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PrintDialogBox
            // 
            this.PrintDialogBox.UseEXDialog = true;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 463);
            this.ContextMenuStrip = this.RosterGeneratorContextMenu;
            this.Controls.Add(this.MoveDownFormBttn);
            this.Controls.Add(this.MoveUpFormBttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamComboBox);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ExportRosterBttn);
            this.Controls.Add(this.PrintRosterBttn);
            this.Controls.Add(this.ImportRosterBttn);
            this.Controls.Add(this.DeleteAllAvailBttn);
            this.Controls.Add(this.EditAvailBttn);
            this.Controls.Add(this.Delete1AvailBttn);
            this.Controls.Add(this.AddWriteInPlayerBttn);
            this.Controls.Add(this.WriteInPlayerTextBox);
            this.Controls.Add(this.WriteInLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovAllSelAvailBttn);
            this.Controls.Add(this.Mov1SelBttn);
            this.Controls.Add(this.MovAllAvailBttn);
            this.Controls.Add(this.Mov1AvailBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelPlayersListBox);
            this.Controls.Add(this.AvailPlayersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 5 - Roster Generator";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RosterGeneratorContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvailPlayersListBox;
        private System.Windows.Forms.ListBox SelPlayersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mov1AvailBttn;
        private System.Windows.Forms.Button MovAllAvailBttn;
        private System.Windows.Forms.Button Mov1SelBttn;
        private System.Windows.Forms.Button MovAllSelAvailBttn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WriteInLabel;
        private System.Windows.Forms.TextBox WriteInPlayerTextBox;
        private System.Windows.Forms.Button AddWriteInPlayerBttn;
        private System.Windows.Forms.Button Delete1AvailBttn;
        private System.Windows.Forms.Button EditAvailBttn;
        private System.Windows.Forms.Button DeleteAllAvailBttn;
        private System.Windows.Forms.Button ImportRosterBttn;
        private System.Windows.Forms.Button PrintRosterBttn;
        private System.Windows.Forms.Button ExportRosterBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.ComboBox TeamComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog ExportRosterFolderBrowserDialog;
        private System.Windows.Forms.Button MoveUpFormBttn;
        private System.Windows.Forms.Button MoveDownFormBttn;
        private System.Windows.Forms.ContextMenuStrip RosterGeneratorContextMenu;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.PrintDialog PrintDialogBox;
    }
}

