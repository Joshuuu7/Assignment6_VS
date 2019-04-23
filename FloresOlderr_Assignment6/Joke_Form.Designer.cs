namespace FloresOlderr_Assignment6
{
    partial class Joke_Form
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
            this.BackButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.NothingButton = new System.Windows.Forms.Button();
            this.JokeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(380, 360);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.ImageLocation = "imagination_hat.png";
            this.PictureBox.Location = new System.Drawing.Point(270, 20);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(300, 300);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // NothingButton
            // 
            this.NothingButton.Location = new System.Drawing.Point(380, 400);
            this.NothingButton.Name = "NothingButton";
            this.NothingButton.Size = new System.Drawing.Size(75, 23);
            this.NothingButton.TabIndex = 2;
            this.NothingButton.Text = "Back";
            this.NothingButton.UseVisualStyleBackColor = true;
            this.NothingButton.Click += new System.EventHandler(this.NothingButton_Click);
            // 
            // JokeLabel
            // 
            this.JokeLabel.AutoSize = true;
            this.JokeLabel.Location = new System.Drawing.Point(320, 340);
            this.JokeLabel.Name = "JokeLabel";
            this.JokeLabel.Size = new System.Drawing.Size(0, 13);
            this.JokeLabel.TabIndex = 3;
            // 
            // Joke_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JokeLabel);
            this.Controls.Add(this.NothingButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BackButton);
            this.Name = "Joke_Form";
            this.Text = "Joke_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Joke_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button NothingButton;
        private System.Windows.Forms.Label JokeLabel;
    }
}