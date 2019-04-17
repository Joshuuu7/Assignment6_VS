namespace FloresOlderr_Assignment6
{
    partial class Donut_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Donut_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Donut_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(360, 400);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Donut_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Donut_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Donut_Chart.Legends.Add(legend1);
            this.Donut_Chart.Location = new System.Drawing.Point(20, 25);
            this.Donut_Chart.Name = "Donut_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Donut_Chart.Series.Add(series1);
            this.Donut_Chart.Size = new System.Drawing.Size(760, 320);
            this.Donut_Chart.TabIndex = 2;
            this.Donut_Chart.Text = "chart1";
            this.Donut_Chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Donut_Chart_MouseMove);
            // 
            // Donut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Donut_Chart);
            this.Controls.Add(this.Backbutton);
            this.Name = "Donut_Form";
            this.Text = "Donut_Form";
            this.Load += new System.EventHandler(this.Donut_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Donut_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Donut_Chart;
    }
}