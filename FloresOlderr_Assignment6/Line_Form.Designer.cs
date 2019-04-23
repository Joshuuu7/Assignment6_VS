namespace FloresOlderr_Assignment6
{
    partial class Line_Form
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
            this.Line_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Line_Graph)).BeginInit();
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
            // Line_Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Line_Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Line_Graph.Legends.Add(legend1);
            this.Line_Graph.Location = new System.Drawing.Point(20, 25);
            this.Line_Graph.Name = "Line_Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Line_Graph.Series.Add(series1);
            this.Line_Graph.Size = new System.Drawing.Size(760, 320);
            this.Line_Graph.TabIndex = 2;
            this.Line_Graph.Text = "Cool Points";
            this.Line_Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Line_Graph_MouseMove);
            // 
            // Line_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Line_Graph);
            this.Controls.Add(this.Backbutton);
            this.Name = "Line_Form";
            this.Text = "Line_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LineForm_Closed);
            this.Load += new System.EventHandler(this.Line_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Line_Graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Line_Graph;
    }
}