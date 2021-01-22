namespace tictac
{
    partial class TicTacToe
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblX = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblCountForX = new System.Windows.Forms.Label();
            this.lblCountForDraws = new System.Windows.Forms.Label();
            this.lblCountsForO = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(16, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(194, 114);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(216, 40);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(194, 114);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(416, 40);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(194, 114);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(16, 160);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(194, 114);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(216, 160);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(194, 114);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(416, 160);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(194, 114);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn6.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(16, 280);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(194, 114);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            this.btn7.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(216, 280);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(194, 114);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            this.btn8.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(416, 280);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(194, 114);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            this.btn9.MouseEnter += new System.EventHandler(this.button_enter);
            this.btn9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 28);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountsToolStripMenuItem
            // 
            this.resetWinCountsToolStripMenuItem.Name = "resetWinCountsToolStripMenuItem";
            this.resetWinCountsToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.resetWinCountsToolStripMenuItem.Text = "Reset win counts";
            this.resetWinCountsToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(13, 397);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(108, 18);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "X Win Count:";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.Location = new System.Drawing.Point(213, 397);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(61, 18);
            this.lblDraws.TabIndex = 14;
            this.lblDraws.Text = "Draws:";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(413, 397);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(119, 18);
            this.lblO.TabIndex = 15;
            this.lblO.Text = "O Win Counts:";
            // 
            // lblCountForX
            // 
            this.lblCountForX.AutoSize = true;
            this.lblCountForX.Location = new System.Drawing.Point(16, 419);
            this.lblCountForX.Name = "lblCountForX";
            this.lblCountForX.Size = new System.Drawing.Size(46, 17);
            this.lblCountForX.TabIndex = 16;
            this.lblCountForX.Text = "label1";
            // 
            // lblCountForDraws
            // 
            this.lblCountForDraws.AutoSize = true;
            this.lblCountForDraws.Location = new System.Drawing.Point(213, 419);
            this.lblCountForDraws.Name = "lblCountForDraws";
            this.lblCountForDraws.Size = new System.Drawing.Size(46, 17);
            this.lblCountForDraws.TabIndex = 17;
            this.lblCountForDraws.Text = "label2";
            // 
            // lblCountsForO
            // 
            this.lblCountsForO.AutoSize = true;
            this.lblCountsForO.Location = new System.Drawing.Point(413, 419);
            this.lblCountsForO.Name = "lblCountsForO";
            this.lblCountsForO.Size = new System.Drawing.Size(46, 17);
            this.lblCountsForO.TabIndex = 18;
            this.lblCountsForO.Text = "label3";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 477);
            this.Controls.Add(this.lblCountsForO);
            this.Controls.Add(this.lblCountForDraws);
            this.Controls.Add(this.lblCountForX);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblCountForX;
        private System.Windows.Forms.Label lblCountForDraws;
        private System.Windows.Forms.Label lblCountsForO;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountsToolStripMenuItem;
    }
}

