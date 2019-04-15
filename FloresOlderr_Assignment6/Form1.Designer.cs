namespace FloresOlderr_Assignment6
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
            this.BarButton = new System.Windows.Forms.Button();
            this.AreaButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.DonutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarButton
            // 
            this.BarButton.Location = new System.Drawing.Point(369, 106);
            this.BarButton.Name = "BarButton";
            this.BarButton.Size = new System.Drawing.Size(75, 23);
            this.BarButton.TabIndex = 0;
            this.BarButton.Text = "Bar";
            this.BarButton.UseVisualStyleBackColor = true;
            this.BarButton.Click += new System.EventHandler(this.BarButton_Click);
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(369, 223);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(75, 23);
            this.AreaButton.TabIndex = 1;
            this.AreaButton.Text = "Area";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.AreaButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(369, 185);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(75, 23);
            this.LineButton.TabIndex = 2;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // DonutButton
            // 
            this.DonutButton.Location = new System.Drawing.Point(369, 147);
            this.DonutButton.Name = "DonutButton";
            this.DonutButton.Size = new System.Drawing.Size(75, 23);
            this.DonutButton.TabIndex = 3;
            this.DonutButton.Text = "Donut";
            this.DonutButton.UseVisualStyleBackColor = true;
            this.DonutButton.Click += new System.EventHandler(this.DonutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DonutButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.AreaButton);
            this.Controls.Add(this.BarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BarButton;
        private System.Windows.Forms.Button AreaButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button DonutButton;
    }
}

