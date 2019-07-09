namespace Group_Assignment
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.loseTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.picOverlay = new System.Windows.Forms.PictureBox();
            this.creatureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHealth.Location = new System.Drawing.Point(12, 527);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(94, 25);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Health: ";
            // 
            // loseTimer
            // 
            this.loseTimer.Tick += new System.EventHandler(this.loseTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTimer.Location = new System.Drawing.Point(12, 566);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(125, 25);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Timer Left:";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayerHealth.Location = new System.Drawing.Point(12, 490);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(94, 25);
            this.lblPlayerHealth.TabIndex = 6;
            this.lblPlayerHealth.Text = "Health: ";
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(382, 291);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 8;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // picOverlay
            // 
            this.picOverlay.BackColor = System.Drawing.Color.DimGray;
            this.picOverlay.Image = global::Group_Assignment.Properties.Resources.dabdcb017b41820;
            this.picOverlay.Location = new System.Drawing.Point(0, 0);
            this.picOverlay.Name = "picOverlay";
            this.picOverlay.Size = new System.Drawing.Size(800, 600);
            this.picOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOverlay.TabIndex = 7;
            this.picOverlay.TabStop = false;
            // 
            // creatureBox
            // 
            this.creatureBox.BackColor = System.Drawing.Color.Transparent;
            this.creatureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.creatureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatureBox.Location = new System.Drawing.Point(331, 183);
            this.creatureBox.Name = "creatureBox";
            this.creatureBox.Size = new System.Drawing.Size(469, 417);
            this.creatureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creatureBox.TabIndex = 2;
            this.creatureBox.TabStop = false;
            this.creatureBox.Click += new System.EventHandler(this.creatureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.picOverlay);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creatureBox);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox creatureBox;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Timer loseTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.PictureBox picOverlay;
        private System.Windows.Forms.Button btnRetry;
    }
}