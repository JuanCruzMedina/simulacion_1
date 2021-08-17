namespace Simulacion_1
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chFE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).BeginInit();
            this.SuspendLayout();
            // 
            // chFE
            // 
            chartArea1.Name = "ChartArea1";
            this.chFE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFE.Legends.Add(legend1);
            this.chFE.Location = new System.Drawing.Point(1, 2);
            this.chFE.Name = "chFE";
            this.chFE.Size = new System.Drawing.Size(653, 300);
            this.chFE.TabIndex = 0;
            this.chFE.Text = "chart1";
            // 
            // chFO
            // 
            chartArea2.Name = "ChartArea1";
            this.chFO.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chFO.Legends.Add(legend2);
            this.chFO.Location = new System.Drawing.Point(1, 308);
            this.chFO.Name = "chFO";
            this.chFO.Size = new System.Drawing.Size(653, 300);
            this.chFO.TabIndex = 1;
            this.chFO.Text = "chart2";
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 609);
            this.Controls.Add(this.chFO);
            this.Controls.Add(this.chFE);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chFE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFO;
    }
}