namespace chap03_and_04_airlinecalc
{
    partial class CISAirways
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CISAirways));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstClassBttn = new System.Windows.Forms.RadioButton();
            this.CoachBttn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdultTicketCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TeenTicketCount = new System.Windows.Forms.TextBox();
            this.ChildrenTicketCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AAABox = new System.Windows.Forms.CheckBox();
            this.SamsClubBox = new System.Windows.Forms.CheckBox();
            this.WeekendBox = new System.Windows.Forms.CheckBox();
            this.CalculateBttn = new System.Windows.Forms.Button();
            this.ResetBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FirstClassAdult = new System.Windows.Forms.TextBox();
            this.CoachAdult = new System.Windows.Forms.TextBox();
            this.FirstClassTeen = new System.Windows.Forms.TextBox();
            this.FirstClassChild = new System.Windows.Forms.TextBox();
            this.CoachTeen = new System.Windows.Forms.TextBox();
            this.CoachChild = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TotalTicketCount = new System.Windows.Forms.TextBox();
            this.Pre_discountCost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Post_discountCost = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIS Airways";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Airline Ticket Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ticket Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Per Ticket Price";
            // 
            // FirstClassBttn
            // 
            this.FirstClassBttn.AutoSize = true;
            this.FirstClassBttn.Checked = true;
            this.FirstClassBttn.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstClassBttn.Location = new System.Drawing.Point(224, 138);
            this.FirstClassBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstClassBttn.Name = "FirstClassBttn";
            this.FirstClassBttn.Size = new System.Drawing.Size(75, 20);
            this.FirstClassBttn.TabIndex = 1;
            this.FirstClassBttn.TabStop = true;
            this.FirstClassBttn.Text = "First Class";
            this.FirstClassBttn.UseVisualStyleBackColor = true;
            this.FirstClassBttn.CheckedChanged += new System.EventHandler(this.FirstClassBttn_CheckedChanged);
            // 
            // CoachBttn
            // 
            this.CoachBttn.AutoSize = true;
            this.CoachBttn.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachBttn.Location = new System.Drawing.Point(316, 138);
            this.CoachBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CoachBttn.Name = "CoachBttn";
            this.CoachBttn.Size = new System.Drawing.Size(85, 20);
            this.CoachBttn.TabIndex = 5;
            this.CoachBttn.Text = "Coach Class";
            this.CoachBttn.UseVisualStyleBackColor = true;
            this.CoachBttn.CheckedChanged += new System.EventHandler(this.CoachBttn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 1);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 1);
            this.label6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adults (21 and up).............";
            // 
            // AdultTicketCount
            // 
            this.AdultTicketCount.Location = new System.Drawing.Point(156, 166);
            this.AdultTicketCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdultTicketCount.Name = "AdultTicketCount";
            this.AdultTicketCount.Size = new System.Drawing.Size(37, 22);
            this.AdultTicketCount.TabIndex = 0;
            this.AdultTicketCount.Text = "0";
            this.AdultTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Teens (13-20)....................";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pre-teens (12 and under)..";
            // 
            // TeenTicketCount
            // 
            this.TeenTicketCount.Location = new System.Drawing.Point(156, 192);
            this.TeenTicketCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TeenTicketCount.Name = "TeenTicketCount";
            this.TeenTicketCount.Size = new System.Drawing.Size(37, 22);
            this.TeenTicketCount.TabIndex = 2;
            this.TeenTicketCount.Text = "0";
            this.TeenTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChildrenTicketCount
            // 
            this.ChildrenTicketCount.Location = new System.Drawing.Point(156, 220);
            this.ChildrenTicketCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ChildrenTicketCount.Name = "ChildrenTicketCount";
            this.ChildrenTicketCount.Size = new System.Drawing.Size(37, 22);
            this.ChildrenTicketCount.TabIndex = 3;
            this.ChildrenTicketCount.Text = "0";
            this.ChildrenTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(24, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 1);
            this.label10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Discount Options (non-taxable)";
            // 
            // AAABox
            // 
            this.AAABox.AutoSize = true;
            this.AAABox.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAABox.Location = new System.Drawing.Point(35, 279);
            this.AAABox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AAABox.Name = "AAABox";
            this.AAABox.Size = new System.Drawing.Size(81, 20);
            this.AAABox.TabIndex = 4;
            this.AAABox.Text = "AAA (10%)";
            this.AAABox.UseVisualStyleBackColor = true;
            // 
            // SamsClubBox
            // 
            this.SamsClubBox.AutoSize = true;
            this.SamsClubBox.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamsClubBox.Location = new System.Drawing.Point(35, 299);
            this.SamsClubBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SamsClubBox.Name = "SamsClubBox";
            this.SamsClubBox.Size = new System.Drawing.Size(110, 20);
            this.SamsClubBox.TabIndex = 5;
            this.SamsClubBox.Text = "Sam\'s Club (12%)";
            this.SamsClubBox.UseVisualStyleBackColor = true;
            // 
            // WeekendBox
            // 
            this.WeekendBox.AutoSize = true;
            this.WeekendBox.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekendBox.Location = new System.Drawing.Point(35, 325);
            this.WeekendBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WeekendBox.Name = "WeekendBox";
            this.WeekendBox.Size = new System.Drawing.Size(137, 20);
            this.WeekendBox.TabIndex = 6;
            this.WeekendBox.Text = "Weekend arr./dep. (20%)";
            this.WeekendBox.UseVisualStyleBackColor = true;
            // 
            // CalculateBttn
            // 
            this.CalculateBttn.Location = new System.Drawing.Point(24, 404);
            this.CalculateBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculateBttn.Name = "CalculateBttn";
            this.CalculateBttn.Size = new System.Drawing.Size(81, 33);
            this.CalculateBttn.TabIndex = 7;
            this.CalculateBttn.Text = "&Calculate";
            this.CalculateBttn.UseVisualStyleBackColor = true;
            this.CalculateBttn.Click += new System.EventHandler(this.CalculateBttn_Click);
            // 
            // ResetBttn
            // 
            this.ResetBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ResetBttn.Location = new System.Drawing.Point(225, 404);
            this.ResetBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ResetBttn.Name = "ResetBttn";
            this.ResetBttn.Size = new System.Drawing.Size(81, 33);
            this.ResetBttn.TabIndex = 8;
            this.ResetBttn.Text = "&Reset";
            this.ResetBttn.UseVisualStyleBackColor = true;
            this.ResetBttn.Click += new System.EventHandler(this.ResetBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(330, 404);
            this.ExitBttn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(81, 33);
            this.ExitBttn.TabIndex = 9;
            this.ExitBttn.Text = "E&xit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(182, 252);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(32, 348);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 51);
            this.label14.TabIndex = 52;
            this.label14.Text = "applies to all ticket levels;\r\ndicounts may be\r\ncombined.";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(217, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 120);
            this.label15.TabIndex = 25;
            // 
            // FirstClassAdult
            // 
            this.FirstClassAdult.Enabled = false;
            this.FirstClassAdult.Location = new System.Drawing.Point(256, 164);
            this.FirstClassAdult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstClassAdult.Name = "FirstClassAdult";
            this.FirstClassAdult.ReadOnly = true;
            this.FirstClassAdult.Size = new System.Drawing.Size(57, 22);
            this.FirstClassAdult.TabIndex = 40;
            this.FirstClassAdult.Text = "$500.00";
            this.FirstClassAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoachAdult
            // 
            this.CoachAdult.Enabled = false;
            this.CoachAdult.Location = new System.Drawing.Point(331, 166);
            this.CoachAdult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CoachAdult.Name = "CoachAdult";
            this.CoachAdult.ReadOnly = true;
            this.CoachAdult.Size = new System.Drawing.Size(57, 22);
            this.CoachAdult.TabIndex = 27;
            this.CoachAdult.Text = "$375.00";
            this.CoachAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstClassTeen
            // 
            this.FirstClassTeen.Enabled = false;
            this.FirstClassTeen.Location = new System.Drawing.Point(256, 194);
            this.FirstClassTeen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstClassTeen.Name = "FirstClassTeen";
            this.FirstClassTeen.ReadOnly = true;
            this.FirstClassTeen.Size = new System.Drawing.Size(57, 22);
            this.FirstClassTeen.TabIndex = 28;
            this.FirstClassTeen.Text = "$325.00";
            this.FirstClassTeen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstClassChild
            // 
            this.FirstClassChild.Enabled = false;
            this.FirstClassChild.Location = new System.Drawing.Point(256, 222);
            this.FirstClassChild.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstClassChild.Name = "FirstClassChild";
            this.FirstClassChild.ReadOnly = true;
            this.FirstClassChild.Size = new System.Drawing.Size(57, 22);
            this.FirstClassChild.TabIndex = 29;
            this.FirstClassChild.Text = "$175.00";
            this.FirstClassChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoachTeen
            // 
            this.CoachTeen.Enabled = false;
            this.CoachTeen.Location = new System.Drawing.Point(331, 194);
            this.CoachTeen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CoachTeen.Name = "CoachTeen";
            this.CoachTeen.ReadOnly = true;
            this.CoachTeen.Size = new System.Drawing.Size(57, 22);
            this.CoachTeen.TabIndex = 30;
            this.CoachTeen.Text = "$280.00";
            this.CoachTeen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoachChild
            // 
            this.CoachChild.Enabled = false;
            this.CoachChild.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachChild.Location = new System.Drawing.Point(331, 222);
            this.CoachChild.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CoachChild.Name = "CoachChild";
            this.CoachChild.ReadOnly = true;
            this.CoachChild.Size = new System.Drawing.Size(57, 22);
            this.CoachChild.TabIndex = 31;
            this.CoachChild.Text = "$80.00";
            this.CoachChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 279);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Total Ticket Count......";
            // 
            // TotalTicketCount
            // 
            this.TotalTicketCount.Enabled = false;
            this.TotalTicketCount.Location = new System.Drawing.Point(335, 277);
            this.TotalTicketCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TotalTicketCount.Name = "TotalTicketCount";
            this.TotalTicketCount.ReadOnly = true;
            this.TotalTicketCount.Size = new System.Drawing.Size(70, 22);
            this.TotalTicketCount.TabIndex = 33;
            this.TotalTicketCount.Text = "0";
            this.TotalTicketCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pre_discountCost
            // 
            this.Pre_discountCost.Enabled = false;
            this.Pre_discountCost.Location = new System.Drawing.Point(335, 307);
            this.Pre_discountCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pre_discountCost.Name = "Pre_discountCost";
            this.Pre_discountCost.ReadOnly = true;
            this.Pre_discountCost.Size = new System.Drawing.Size(70, 22);
            this.Pre_discountCost.TabIndex = 35;
            this.Pre_discountCost.Text = "$0.00";
            this.Pre_discountCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(228, 309);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Pre-discount Cost......";
            // 
            // Post_discountCost
            // 
            this.Post_discountCost.Enabled = false;
            this.Post_discountCost.Location = new System.Drawing.Point(335, 332);
            this.Post_discountCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Post_discountCost.Name = "Post_discountCost";
            this.Post_discountCost.ReadOnly = true;
            this.Post_discountCost.Size = new System.Drawing.Size(70, 22);
            this.Post_discountCost.TabIndex = 37;
            this.Post_discountCost.Text = "$0.00";
            this.Post_discountCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(232, 337);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Post-discount Cost....";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(230, 364);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "tax rate is current PA value (6%)\r\n";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(222, 364);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 17);
            this.label21.TabIndex = 39;
            this.label21.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(224, 332);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 17);
            this.label19.TabIndex = 53;
            this.label19.Text = "*";
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(363, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(60, 17);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "n/a";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(156, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 64);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // CISAirways
            // 
            this.AcceptButton = this.CalculateBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ResetBttn;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Post_discountCost);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Pre_discountCost);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TotalTicketCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CoachChild);
            this.Controls.Add(this.CoachTeen);
            this.Controls.Add(this.FirstClassChild);
            this.Controls.Add(this.FirstClassTeen);
            this.Controls.Add(this.CoachAdult);
            this.Controls.Add(this.FirstClassAdult);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ResetBttn);
            this.Controls.Add(this.CalculateBttn);
            this.Controls.Add(this.WeekendBox);
            this.Controls.Add(this.SamsClubBox);
            this.Controls.Add(this.AAABox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChildrenTicketCount);
            this.Controls.Add(this.TeenTicketCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdultTicketCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CoachBttn);
            this.Controls.Add(this.FirstClassBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "CISAirways";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapters 3 and 4 - CIS Airways";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CISAirways_FormClosing);
            this.Load += new System.EventHandler(this.ResetBttn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton FirstClassBttn;
        private System.Windows.Forms.RadioButton CoachBttn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdultTicketCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TeenTicketCount;
        private System.Windows.Forms.TextBox ChildrenTicketCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox AAABox;
        private System.Windows.Forms.CheckBox SamsClubBox;
        private System.Windows.Forms.CheckBox WeekendBox;
        private System.Windows.Forms.Button CalculateBttn;
        private System.Windows.Forms.Button ResetBttn;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FirstClassAdult;
        private System.Windows.Forms.TextBox CoachAdult;
        private System.Windows.Forms.TextBox FirstClassTeen;
        private System.Windows.Forms.TextBox FirstClassChild;
        private System.Windows.Forms.TextBox CoachTeen;
        private System.Windows.Forms.TextBox CoachChild;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TotalTicketCount;
        private System.Windows.Forms.TextBox Pre_discountCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Post_discountCost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

