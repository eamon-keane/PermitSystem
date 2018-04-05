namespace PermitSystem {
    partial class PermitSystem {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Results = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleTextBox = new System.Windows.Forms.TextBox();
            this.reg1TextBox = new System.Windows.Forms.TextBox();
            this.reg2TextBox = new System.Windows.Forms.TextBox();
            this.AptTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CountPermitsInUseBtn = new System.Windows.Forms.Button();
            this.totalpermitstextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.percentageInUseText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPermitsIssued = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Results, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 602);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 644);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Results.Location = new System.Drawing.Point(3, 3);
            this.Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Results.Name = "Results";
            this.Results.RowTemplate.Height = 28;
            this.Results.Size = new System.Drawing.Size(1478, 639);
            this.Results.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(155, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All Entries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(241, 74);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(293, 30);
            this.NameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicle Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registration 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registration 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apartment Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Permit Expiry Date";
            // 
            // VehicleTextBox
            // 
            this.VehicleTextBox.Location = new System.Drawing.Point(241, 138);
            this.VehicleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleTextBox.Name = "VehicleTextBox";
            this.VehicleTextBox.Size = new System.Drawing.Size(293, 30);
            this.VehicleTextBox.TabIndex = 11;
            // 
            // reg1TextBox
            // 
            this.reg1TextBox.Location = new System.Drawing.Point(241, 201);
            this.reg1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reg1TextBox.Name = "reg1TextBox";
            this.reg1TextBox.Size = new System.Drawing.Size(293, 30);
            this.reg1TextBox.TabIndex = 12;
            // 
            // reg2TextBox
            // 
            this.reg2TextBox.Location = new System.Drawing.Point(241, 256);
            this.reg2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reg2TextBox.Name = "reg2TextBox";
            this.reg2TextBox.Size = new System.Drawing.Size(293, 30);
            this.reg2TextBox.TabIndex = 13;
            // 
            // AptTextBox
            // 
            this.AptTextBox.Location = new System.Drawing.Point(241, 319);
            this.AptTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AptTextBox.Name = "AptTextBox";
            this.AptTextBox.Size = new System.Drawing.Size(293, 30);
            this.AptTextBox.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 382);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 30);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Update Entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 518);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Delete Entry";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(518, 517);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(222, 35);
            this.button5.TabIndex = 19;
            this.button5.Text = "Set Permit to In Use";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CountPermitsInUseBtn
            // 
            this.CountPermitsInUseBtn.Location = new System.Drawing.Point(12, 515);
            this.CountPermitsInUseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CountPermitsInUseBtn.Name = "CountPermitsInUseBtn";
            this.CountPermitsInUseBtn.Size = new System.Drawing.Size(223, 35);
            this.CountPermitsInUseBtn.TabIndex = 20;
            this.CountPermitsInUseBtn.Text = "Display Permits Stats";
            this.CountPermitsInUseBtn.UseVisualStyleBackColor = true;
            this.CountPermitsInUseBtn.Click += new System.EventHandler(this.CountPermitsInUseBtn_Click);
            // 
            // totalpermitstextbox
            // 
            this.totalpermitstextbox.Location = new System.Drawing.Point(1101, 153);
            this.totalpermitstextbox.Margin = new System.Windows.Forms.Padding(4);
            this.totalpermitstextbox.Name = "totalpermitstextbox";
            this.totalpermitstextbox.Size = new System.Drawing.Size(293, 30);
            this.totalpermitstextbox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(889, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Permits In Use";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(898, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "% Permits In Use";
            // 
            // percentageInUseText
            // 
            this.percentageInUseText.Location = new System.Drawing.Point(1101, 220);
            this.percentageInUseText.Margin = new System.Windows.Forms.Padding(4);
            this.percentageInUseText.Name = "percentageInUseText";
            this.percentageInUseText.Size = new System.Drawing.Size(293, 30);
            this.percentageInUseText.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(889, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Permits Issued";
            // 
            // totalPermitsIssued
            // 
            this.totalPermitsIssued.Location = new System.Drawing.Point(1101, 97);
            this.totalPermitsIssued.Margin = new System.Windows.Forms.Padding(4);
            this.totalPermitsIssued.Name = "totalPermitsIssued";
            this.totalPermitsIssued.Size = new System.Drawing.Size(293, 30);
            this.totalPermitsIssued.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(706, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(524, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "To delete entry, click on entry and click \'Delete Entry\' button";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(706, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(538, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "To update entry, click on entry and click \'Update Entry\' button";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(769, 518);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(290, 35);
            this.button6.TabIndex = 29;
            this.button6.Text = "Set Permit to Not In Use";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(706, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(612, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "If permit is not in use, click on entry and click \'Set Permit to Not In Use\'";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(706, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(545, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "If permit is in use, click on entry and click \'Set Permit to In Use\'";
            // 
            // PermitSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 1246);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalPermitsIssued);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.percentageInUseText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalpermitstextbox);
            this.Controls.Add(this.CountPermitsInUseBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AptTextBox);
            this.Controls.Add(this.reg2TextBox);
            this.Controls.Add(this.reg1TextBox);
            this.Controls.Add(this.VehicleTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PermitSystem";
            this.Text = "NUIG Parking Permit System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PermitSystem_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VehicleTextBox;
        private System.Windows.Forms.TextBox reg1TextBox;
        private System.Windows.Forms.TextBox reg2TextBox;
        private System.Windows.Forms.TextBox AptTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CountPermitsInUseBtn;
        private System.Windows.Forms.TextBox totalpermitstextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox percentageInUseText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalPermitsIssued;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

