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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafico));
            this.chFE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRestaurarH = new System.Windows.Forms.PictureBox();
            this.btnMinimizarH = new System.Windows.Forms.PictureBox();
            this.btnCerrarH = new System.Windows.Forms.PictureBox();
            this.btnMaximizarH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarH)).BeginInit();
            this.SuspendLayout();
            // 
            // chFE
            // 
            this.chFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chFE.BackImageTransparentColor = System.Drawing.Color.White;
            this.chFE.BackSecondaryColor = System.Drawing.Color.White;
            this.chFE.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea3.Name = "ChartArea1";
            this.chFE.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chFE.Legends.Add(legend3);
            this.chFE.Location = new System.Drawing.Point(1, 46);
            this.chFE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chFE.Name = "chFE";
            this.chFE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chFE.Size = new System.Drawing.Size(871, 339);
            this.chFE.TabIndex = 0;
            this.chFE.Text = "chart1";
            this.chFE.Click += new System.EventHandler(this.chFE_Click);
            // 
            // chFO
            // 
            this.chFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.chFO.BackImageTransparentColor = System.Drawing.Color.White;
            this.chFO.BackSecondaryColor = System.Drawing.Color.White;
            this.chFO.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea4.Name = "ChartArea1";
            this.chFO.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chFO.Legends.Add(legend4);
            this.chFO.Location = new System.Drawing.Point(1, 393);
            this.chFO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chFO.Name = "chFO";
            this.chFO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chFO.Size = new System.Drawing.Size(871, 361);
            this.chFO.TabIndex = 1;
            this.chFO.Text = "chart2";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1238, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnMaximizarH);
            this.barraTitulo.Controls.Add(this.btnRestaurarH);
            this.barraTitulo.Controls.Add(this.btnMinimizarH);
            this.barraTitulo.Controls.Add(this.btnCerrarH);
            this.barraTitulo.Controls.Add(this.label13);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Location = new System.Drawing.Point(1, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(871, 45);
            this.barraTitulo.TabIndex = 2;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseMove);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(304, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Gráficas de histogramas";
            // 
            // btnRestaurarH
            // 
            this.btnRestaurarH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarH.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarH.Image")));
            this.btnRestaurarH.Location = new System.Drawing.Point(802, 12);
            this.btnRestaurarH.Name = "btnRestaurarH";
            this.btnRestaurarH.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurarH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurarH.TabIndex = 11;
            this.btnRestaurarH.TabStop = false;
            this.btnRestaurarH.Visible = false;
            this.btnRestaurarH.Click += new System.EventHandler(this.btnRestaurarH_Click);
            // 
            // btnMinimizarH
            // 
            this.btnMinimizarH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarH.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarH.Image")));
            this.btnMinimizarH.Location = new System.Drawing.Point(771, 12);
            this.btnMinimizarH.Name = "btnMinimizarH";
            this.btnMinimizarH.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizarH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarH.TabIndex = 10;
            this.btnMinimizarH.TabStop = false;
            this.btnMinimizarH.Click += new System.EventHandler(this.btnMinimizarH_Click);
            // 
            // btnCerrarH
            // 
            this.btnCerrarH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarH.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarH.Image")));
            this.btnCerrarH.Location = new System.Drawing.Point(833, 12);
            this.btnCerrarH.Name = "btnCerrarH";
            this.btnCerrarH.Size = new System.Drawing.Size(25, 25);
            this.btnCerrarH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarH.TabIndex = 8;
            this.btnCerrarH.TabStop = false;
            this.btnCerrarH.Click += new System.EventHandler(this.btnCerrarH_Click);
            // 
            // btnMaximizarH
            // 
            this.btnMaximizarH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizarH.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizarH.Image")));
            this.btnMaximizarH.Location = new System.Drawing.Point(802, 12);
            this.btnMaximizarH.Name = "btnMaximizarH";
            this.btnMaximizarH.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizarH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizarH.TabIndex = 12;
            this.btnMaximizarH.TabStop = false;
            this.btnMaximizarH.Click += new System.EventHandler(this.btnMaximizarH_Click_1);
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(871, 750);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.chFO);
            this.Controls.Add(this.chFE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chFE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFO;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox btnRestaurarH;
        private System.Windows.Forms.PictureBox btnMinimizarH;
        private System.Windows.Forms.PictureBox btnCerrarH;
        private System.Windows.Forms.PictureBox btnMaximizarH;
    }
}