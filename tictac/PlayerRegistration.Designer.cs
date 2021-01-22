namespace tictac
{
    partial class PlayerRegistration
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
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.txtPlayerOneName = new System.Windows.Forms.TextBox();
            this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(12, 20);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(162, 20);
            this.lblPlayerOne.TabIndex = 0;
            this.lblPlayerOne.Text = "Player One Name:";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(12, 59);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(162, 20);
            this.lblPlayerTwo.TabIndex = 1;
            this.lblPlayerTwo.Text = "Player Two Name:";
            // 
            // txtPlayerOneName
            // 
            this.txtPlayerOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneName.Location = new System.Drawing.Point(195, 20);
            this.txtPlayerOneName.Name = "txtPlayerOneName";
            this.txtPlayerOneName.Size = new System.Drawing.Size(192, 27);
            this.txtPlayerOneName.TabIndex = 2;
            // 
            // txtPlayerTwoName
            // 
            this.txtPlayerTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoName.Location = new System.Drawing.Point(195, 57);
            this.txtPlayerTwoName.Name = "txtPlayerTwoName";
            this.txtPlayerTwoName.Size = new System.Drawing.Size(192, 27);
            this.txtPlayerTwoName.TabIndex = 3;
            this.txtPlayerTwoName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoName_KeyPress);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(299, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(88, 29);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // PlayerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 131);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayerTwoName);
            this.Controls.Add(this.txtPlayerOneName);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.MaximumSize = new System.Drawing.Size(426, 178);
            this.MinimumSize = new System.Drawing.Size(426, 178);
            this.Name = "PlayerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.Button btnPlay;
    }
}