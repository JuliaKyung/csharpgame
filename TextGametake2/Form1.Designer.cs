namespace TextGametake2
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
            this.outputbox = new System.Windows.Forms.TextBox();
            this.LookBTN = new System.Windows.Forms.Button();
            this.North = new System.Windows.Forms.Button();
            this.South = new System.Windows.Forms.Button();
            this.West = new System.Windows.Forms.Button();
            this.East = new System.Windows.Forms.Button();
            this.SelectObj = new System.Windows.Forms.GroupBox();
            this.LookAt = new System.Windows.Forms.Button();
            this.dropbtn = new System.Windows.Forms.Button();
            this.takebtn = new System.Windows.Forms.Button();
            this.objtextbox = new System.Windows.Forms.TextBox();
            this.inventory = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.commandbox = new System.Windows.Forms.TextBox();
            this.cmdbtn = new System.Windows.Forms.Button();
            this.SelectObj.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputbox
            // 
            this.outputbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputbox.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputbox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputbox.Location = new System.Drawing.Point(12, 36);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(883, 299);
            this.outputbox.TabIndex = 0;
            // 
            // LookBTN
            // 
            this.LookBTN.Location = new System.Drawing.Point(347, 383);
            this.LookBTN.Name = "LookBTN";
            this.LookBTN.Size = new System.Drawing.Size(91, 41);
            this.LookBTN.TabIndex = 1;
            this.LookBTN.Text = "Look";
            this.LookBTN.UseVisualStyleBackColor = true;
            this.LookBTN.Click += new System.EventHandler(this.LookBTN_Click);
            // 
            // North
            // 
            this.North.Location = new System.Drawing.Point(694, 356);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(93, 34);
            this.North.TabIndex = 2;
            this.North.Text = "North";
            this.North.UseVisualStyleBackColor = true;
            this.North.Click += new System.EventHandler(this.North_Click);
            // 
            // South
            // 
            this.South.Location = new System.Drawing.Point(694, 436);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(93, 34);
            this.South.TabIndex = 3;
            this.South.Text = "South";
            this.South.UseVisualStyleBackColor = true;
            this.South.Click += new System.EventHandler(this.South_Click);
            // 
            // West
            // 
            this.West.Location = new System.Drawing.Point(631, 396);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(93, 34);
            this.West.TabIndex = 4;
            this.West.Text = "West";
            this.West.UseVisualStyleBackColor = true;
            this.West.Click += new System.EventHandler(this.West_Click);
            // 
            // East
            // 
            this.East.Location = new System.Drawing.Point(760, 396);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(93, 34);
            this.East.TabIndex = 5;
            this.East.Text = "East";
            this.East.UseVisualStyleBackColor = true;
            this.East.Click += new System.EventHandler(this.East_Click);
            // 
            // SelectObj
            // 
            this.SelectObj.Controls.Add(this.LookAt);
            this.SelectObj.Controls.Add(this.dropbtn);
            this.SelectObj.Controls.Add(this.takebtn);
            this.SelectObj.Controls.Add(this.objtextbox);
            this.SelectObj.Location = new System.Drawing.Point(12, 373);
            this.SelectObj.Name = "SelectObj";
            this.SelectObj.Size = new System.Drawing.Size(329, 110);
            this.SelectObj.TabIndex = 6;
            this.SelectObj.TabStop = false;
            this.SelectObj.Text = "Select Object";
            // 
            // LookAt
            // 
            this.LookAt.Location = new System.Drawing.Point(216, 71);
            this.LookAt.Name = "LookAt";
            this.LookAt.Size = new System.Drawing.Size(99, 33);
            this.LookAt.TabIndex = 3;
            this.LookAt.Text = "Look At";
            this.LookAt.UseVisualStyleBackColor = true;
            this.LookAt.Click += new System.EventHandler(this.LookAt_Click);
            // 
            // dropbtn
            // 
            this.dropbtn.Location = new System.Drawing.Point(111, 71);
            this.dropbtn.Name = "dropbtn";
            this.dropbtn.Size = new System.Drawing.Size(99, 33);
            this.dropbtn.TabIndex = 2;
            this.dropbtn.Text = "Drop";
            this.dropbtn.UseVisualStyleBackColor = true;
            this.dropbtn.Click += new System.EventHandler(this.dropbtn_Click);
            // 
            // takebtn
            // 
            this.takebtn.Location = new System.Drawing.Point(6, 71);
            this.takebtn.Name = "takebtn";
            this.takebtn.Size = new System.Drawing.Size(99, 33);
            this.takebtn.TabIndex = 1;
            this.takebtn.Text = "Take";
            this.takebtn.UseVisualStyleBackColor = true;
            this.takebtn.Click += new System.EventHandler(this.takebtn_Click);
            // 
            // objtextbox
            // 
            this.objtextbox.Location = new System.Drawing.Point(6, 25);
            this.objtextbox.Name = "objtextbox";
            this.objtextbox.Size = new System.Drawing.Size(309, 26);
            this.objtextbox.TabIndex = 0;
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(347, 442);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(91, 41);
            this.inventory.TabIndex = 7;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // commandbox
            // 
            this.commandbox.Location = new System.Drawing.Point(12, 341);
            this.commandbox.Name = "commandbox";
            this.commandbox.Size = new System.Drawing.Size(462, 26);
            this.commandbox.TabIndex = 9;
            // 
            // cmdbtn
            // 
            this.cmdbtn.Location = new System.Drawing.Point(480, 338);
            this.cmdbtn.Name = "cmdbtn";
            this.cmdbtn.Size = new System.Drawing.Size(76, 33);
            this.cmdbtn.TabIndex = 10;
            this.cmdbtn.Text = "submit";
            this.cmdbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(907, 495);
            this.Controls.Add(this.cmdbtn);
            this.Controls.Add(this.commandbox);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.SelectObj);
            this.Controls.Add(this.East);
            this.Controls.Add(this.West);
            this.Controls.Add(this.South);
            this.Controls.Add(this.North);
            this.Controls.Add(this.LookBTN);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SelectObj.ResumeLayout(false);
            this.SelectObj.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.Button LookBTN;
        private System.Windows.Forms.Button North;
        private System.Windows.Forms.Button South;
        private System.Windows.Forms.Button West;
        private System.Windows.Forms.Button East;
        private System.Windows.Forms.GroupBox SelectObj;
        private System.Windows.Forms.Button dropbtn;
        private System.Windows.Forms.Button takebtn;
        private System.Windows.Forms.TextBox objtextbox;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LookAt;
        private System.Windows.Forms.TextBox commandbox;
        private System.Windows.Forms.Button cmdbtn;
    }
}

