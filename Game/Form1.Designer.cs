namespace Game
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
            this.Startgame = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Startgame
            // 
            this.Startgame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Startgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Startgame.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Startgame.FlatAppearance.BorderSize = 0;
            this.Startgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startgame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startgame.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Startgame.Location = new System.Drawing.Point(322, 223);
            this.Startgame.Name = "Startgame";
            this.Startgame.Size = new System.Drawing.Size(164, 130);
            this.Startgame.TabIndex = 1;
            this.Startgame.Text = "Start Game";
            this.Startgame.UseVisualStyleBackColor = false;
            this.Startgame.Click += new System.EventHandler(this.Startgame_Click);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CountdownLabel.Location = new System.Drawing.Point(128, 136);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(545, 84);
            this.CountdownLabel.TabIndex = 2;
            this.CountdownLabel.Text = "Game starts in ";
            this.CountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountdownLabel.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.Startgame);
            this.Name = "Form1";
            this.Text = "Game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Startgame;
        private System.Windows.Forms.Label CountdownLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

