
namespace Simulacion_1
{
    partial class Simulacion_1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txt_m = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_k = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.txt_semilla = new System.Windows.Forms.MaskedTextBox();
            this.txt_g = new System.Windows.Forms.MaskedTextBox();
            this.txt_c = new System.Windows.Forms.MaskedTextBox();
            this.txt_a = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.dgvMetodo = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txt_hasta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAplicarRango = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_confianza = new System.Windows.Forms.MaskedTextBox();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.txt_intervalos = new System.Windows.Forms.MaskedTextBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnProbar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 47);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 47);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(759, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Generador de Números Aleatorios";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.btnGenerar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 48);
            this.panel3.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(672, 13);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(95, 22);
            this.txt_m.Mask = "99999";
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(79, 20);
            this.txt_m.TabIndex = 0;
            this.txt_m.Text = "8";
            this.txt_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m.ValidatingType = typeof(int);
            this.txt_m.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_m_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "k";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_k);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.txt_semilla);
            this.groupBox1.Controls.Add(this.txt_g);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_m);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones";
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(95, 100);
            this.txt_k.Mask = "99999";
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(79, 20);
            this.txt_k.TabIndex = 3;
            this.txt_k.Text = "3";
            this.txt_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_k.ValidatingType = typeof(int);
            this.txt_k.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_k_KeyUp);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(95, 178);
            this.txt_cantidad.Mask = "9999999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(79, 20);
            this.txt_cantidad.TabIndex = 6;
            this.txt_cantidad.Text = "20";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(95, 152);
            this.txt_semilla.Mask = "99999";
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(79, 20);
            this.txt_semilla.TabIndex = 5;
            this.txt_semilla.Text = "6";
            this.txt_semilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_semilla.ValidatingType = typeof(int);
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(95, 126);
            this.txt_g.Mask = "99999";
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(79, 20);
            this.txt_g.TabIndex = 4;
            this.txt_g.Text = "3";
            this.txt_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_g.ValidatingType = typeof(int);
            this.txt_g.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_g_KeyUp);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(95, 74);
            this.txt_c.Mask = "99999";
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(79, 20);
            this.txt_c.TabIndex = 2;
            this.txt_c.Text = "7";
            this.txt_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_c.ValidatingType = typeof(int);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(95, 48);
            this.txt_a.Mask = "99999";
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(79, 20);
            this.txt_a.TabIndex = 1;
            this.txt_a.Text = "13";
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_a.ValidatingType = typeof(int);
            this.txt_a.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_a_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semilla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "g";
            // 
            // cboMetodo
            // 
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "Método Congruencial Mixto",
            "Método Congruencial Multiplicativo",
            "Método del Lenguaje"});
            this.cboMetodo.Location = new System.Drawing.Point(12, 58);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(201, 21);
            this.cboMetodo.TabIndex = 0;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // dgvMetodo
            // 
            this.dgvMetodo.AllowUserToAddRows = false;
            this.dgvMetodo.AllowUserToDeleteRows = false;
            this.dgvMetodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodo.BackgroundColor = System.Drawing.Color.White;
            this.dgvMetodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodo.Location = new System.Drawing.Point(218, 59);
            this.dgvMetodo.Name = "dgvMetodo";
            this.dgvMetodo.ReadOnly = true;
            this.dgvMetodo.RowHeadersWidth = 5;
            this.dgvMetodo.Size = new System.Drawing.Size(248, 238);
            this.dgvMetodo.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(266, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(353, 29);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(104, 23);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximos 20";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(87, 32);
            this.txt_hasta.Mask = "99999";
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(75, 20);
            this.txt_hasta.TabIndex = 1;
            this.txt_hasta.Text = "3";
            this.txt_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hasta.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAplicarRango);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_desde);
            this.groupBox2.Controls.Add(this.txt_hasta);
            this.groupBox2.Controls.Add(this.btnProximo);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 59);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grilla";
            // 
            // btnAplicarRango
            // 
            this.btnAplicarRango.Location = new System.Drawing.Point(168, 30);
            this.btnAplicarRango.Name = "btnAplicarRango";
            this.btnAplicarRango.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarRango.TabIndex = 2;
            this.btnAplicarRango.Text = "Aplicar";
            this.btnAplicarRango.UseVisualStyleBackColor = true;
            this.btnAplicarRango.Click += new System.EventHandler(this.btnAplicarRango_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Desde";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hasta";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(6, 32);
            this.txt_desde.Mask = "99999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(75, 20);
            this.txt_desde.TabIndex = 0;
            this.txt_desde.Text = "3";
            this.txt_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde.ValidatingType = typeof(int);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_confianza);
            this.groupBox3.Controls.Add(this.dgvChi);
            this.groupBox3.Controls.Add(this.txt_intervalos);
            this.groupBox3.Controls.Add(this.btnReiniciar);
            this.groupBox3.Controls.Add(this.btnProbar);
            this.groupBox3.Location = new System.Drawing.Point(472, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 304);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Cuadrado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "SubIntervalos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nivel de Confianza";
            // 
            // txt_confianza
            // 
            this.txt_confianza.Location = new System.Drawing.Point(109, 48);
            this.txt_confianza.Mask = "99999";
            this.txt_confianza.Name = "txt_confianza";
            this.txt_confianza.Size = new System.Drawing.Size(75, 20);
            this.txt_confianza.TabIndex = 0;
            this.txt_confianza.Text = "95";
            this.txt_confianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confianza.ValidatingType = typeof(int);
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.AllowUserToDeleteRows = false;
            this.dgvChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChi.BackgroundColor = System.Drawing.Color.White;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Location = new System.Drawing.Point(6, 74);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.ReadOnly = true;
            this.dgvChi.RowHeadersWidth = 5;
            this.dgvChi.Size = new System.Drawing.Size(263, 224);
            this.dgvChi.TabIndex = 6;
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(109, 19);
            this.txt_intervalos.Mask = "99999";
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(75, 20);
            this.txt_intervalos.TabIndex = 1;
            this.txt_intervalos.Text = "3";
            this.txt_intervalos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_intervalos.ValidatingType = typeof(int);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(194, 46);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(194, 17);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(75, 23);
            this.btnProbar.TabIndex = 4;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            // 
            // Simulacion_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 415);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.dgvMetodo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Simulacion_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación 1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txt_m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.MaskedTextBox txt_k;
        private System.Windows.Forms.MaskedTextBox txt_c;
        private System.Windows.Forms.MaskedTextBox txt_a;
        private System.Windows.Forms.DataGridView dgvMetodo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.MaskedTextBox txt_semilla;
        private System.Windows.Forms.MaskedTextBox txt_g;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_hasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_desde;
        private System.Windows.Forms.Button btnAplicarRango;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_confianza;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.MaskedTextBox txt_intervalos;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnProbar;
    }
}

