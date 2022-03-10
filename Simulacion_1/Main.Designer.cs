
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblNombres = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_confianza = new System.Windows.Forms.MaskedTextBox();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_intervalos = new System.Windows.Forms.MaskedTextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnProbar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnIrChi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerar.Location = new System.Drawing.Point(12, 294);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(164, 29);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar valores";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(67, 21);
            this.txt_m.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m.Mask = "99999";
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(87, 23);
            this.txt_m.TabIndex = 0;
            this.txt_m.Text = "0";
            this.txt_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_m.ValidatingType = typeof(int);
            this.txt_m.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_m_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(166, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
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
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(7, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones";
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(182, 21);
            this.txt_k.Margin = new System.Windows.Forms.Padding(4);
            this.txt_k.Mask = "99999";
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(87, 23);
            this.txt_k.TabIndex = 3;
            this.txt_k.Text = "0";
            this.txt_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_k.ValidatingType = typeof(int);
            this.txt_k.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_k_KeyUp);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(221, 109);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Mask = "9999999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(87, 23);
            this.txt_cantidad.TabIndex = 6;
            this.txt_cantidad.Text = "50000";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(67, 109);
            this.txt_semilla.Margin = new System.Windows.Forms.Padding(4);
            this.txt_semilla.Mask = "99999";
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(87, 23);
            this.txt_semilla.TabIndex = 5;
            this.txt_semilla.Text = "0";
            this.txt_semilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_semilla.ValidatingType = typeof(int);
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(182, 51);
            this.txt_g.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g.Mask = "99999";
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(87, 23);
            this.txt_g.TabIndex = 4;
            this.txt_g.Text = "0";
            this.txt_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_g.ValidatingType = typeof(int);
            this.txt_g.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_g_KeyUp);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(67, 81);
            this.txt_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c.Mask = "99999";
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(87, 23);
            this.txt_c.TabIndex = 2;
            this.txt_c.Text = "0";
            this.txt_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_c.ValidatingType = typeof(int);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(67, 51);
            this.txt_a.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a.Mask = "99999";
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(87, 23);
            this.txt_a.TabIndex = 1;
            this.txt_a.Text = "0";
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_a.ValidatingType = typeof(int);
            this.txt_a.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_a_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(162, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semilla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(165, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "g";
            // 
            // cboMetodo
            // 
            this.cboMetodo.BackColor = System.Drawing.SystemColors.Control;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboMetodo.FormattingEnabled = true;
            this.cboMetodo.Items.AddRange(new object[] {
            "Método Congruencial Mixto",
            "Método Congruencial Multiplicativo",
            "Método del Lenguaje"});
            this.cboMetodo.Location = new System.Drawing.Point(9, 27);
            this.cboMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(331, 24);
            this.cboMetodo.TabIndex = 0;
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.CboMetodo_SelectedIndexChanged);
            // 
            // dgvMetodo
            // 
            this.dgvMetodo.AllowUserToAddRows = false;
            this.dgvMetodo.AllowUserToDeleteRows = false;
            this.dgvMetodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMetodo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMetodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMetodo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMetodo.Location = new System.Drawing.Point(348, 57);
            this.dgvMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMetodo.Name = "dgvMetodo";
            this.dgvMetodo.ReadOnly = true;
            this.dgvMetodo.RowHeadersWidth = 5;
            this.dgvMetodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetodo.Size = new System.Drawing.Size(327, 266);
            this.dgvMetodo.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(348, 25);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 24);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar grilla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.Location = new System.Drawing.Point(458, 25);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 24);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximos 20";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(67, 46);
            this.txt_hasta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hasta.Mask = "99999";
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(99, 23);
            this.txt_hasta.TabIndex = 1;
            this.txt_hasta.Text = "50000";
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
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(7, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(333, 78);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango";
            // 
            // btnAplicarRango
            // 
            this.btnAplicarRango.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarRango.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAplicarRango.Location = new System.Drawing.Point(223, 46);
            this.btnAplicarRango.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicarRango.Name = "btnAplicarRango";
            this.btnAplicarRango.Size = new System.Drawing.Size(102, 24);
            this.btnAplicarRango.TabIndex = 2;
            this.btnAplicarRango.Text = "Aplicar rango";
            this.btnAplicarRango.UseVisualStyleBackColor = true;
            this.btnAplicarRango.Click += new System.EventHandler(this.BtnAplicarRango_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(23, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Desde";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(22, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hasta";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(67, 17);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desde.Mask = "99999";
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(99, 23);
            this.txt_desde.TabIndex = 0;
            this.txt_desde.Text = "0";
            this.txt_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_desde.ValidatingType = typeof(int);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblNombres);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_confianza);
            this.groupBox3.Controls.Add(this.dgvChi);
            this.groupBox3.Controls.Add(this.txt_intervalos);
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Controls.Add(this.btnProbar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(684, 333);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Cuadrado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(18, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "SubIntervalos";
            // 
            // lblNombres
            // 
            this.lblNombres.BackColor = System.Drawing.SystemColors.Info;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(8, 303);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(559, 23);
            this.lblNombres.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(211, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nivel de Confianza";
            // 
            // txt_confianza
            // 
            this.txt_confianza.Enabled = false;
            this.txt_confianza.Location = new System.Drawing.Point(328, 24);
            this.txt_confianza.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confianza.Mask = "99999";
            this.txt_confianza.Name = "txt_confianza";
            this.txt_confianza.Size = new System.Drawing.Size(99, 23);
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
            this.dgvChi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.fo,
            this.fe,
            this.c,
            this.cac});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChi.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvChi.Location = new System.Drawing.Point(8, 52);
            this.dgvChi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChi.RowHeadersWidth = 5;
            this.dgvChi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChi.Size = new System.Drawing.Size(668, 247);
            this.dgvChi.TabIndex = 6;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.MinimumWidth = 6;
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Frecuencia Observada";
            this.fo.MinimumWidth = 6;
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Frecuencia Esperada";
            this.fe.MinimumWidth = 6;
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "Chi cuadrado";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // cac
            // 
            this.cac.HeaderText = "c(AC) Acumulador";
            this.cac.MinimumWidth = 6;
            this.cac.Name = "cac";
            this.cac.ReadOnly = true;
            // 
            // txt_intervalos
            // 
            this.txt_intervalos.Location = new System.Drawing.Point(104, 24);
            this.txt_intervalos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_intervalos.Mask = "99999";
            this.txt_intervalos.Name = "txt_intervalos";
            this.txt_intervalos.Size = new System.Drawing.Size(99, 23);
            this.txt_intervalos.TabIndex = 1;
            this.txt_intervalos.Text = "3";
            this.txt_intervalos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_intervalos.ValidatingType = typeof(int);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisplay.Location = new System.Drawing.Point(574, 302);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 24);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Ver Gráfico";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnProbar
            // 
            this.btnProbar.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProbar.Location = new System.Drawing.Point(574, 23);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(102, 24);
            this.btnProbar.TabIndex = 4;
            this.btnProbar.Text = "Calcular chi";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.BtnCalcularChiCuadrado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(20, 553);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 22);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 365);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnIrChi);
            this.tabPage1.Controls.Add(this.btnGenerar);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cboMetodo);
            this.tabPage1.Controls.Add(this.dgvMetodo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnProximo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generación de números";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnIrChi
            // 
            this.btnIrChi.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIrChi.Location = new System.Drawing.Point(568, 25);
            this.btnIrChi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIrChi.Name = "btnIrChi";
            this.btnIrChi.Size = new System.Drawing.Size(107, 24);
            this.btnIrChi.TabIndex = 9;
            this.btnIrChi.Text = "Ir a Chi Cuadrado";
            this.btnIrChi.UseVisualStyleBackColor = true;
            this.btnIrChi.Click += new System.EventHandler(this.BtnIrChi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Metodo de Generación";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Simulacion_1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulacion_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación de números pseudoaleatorios - Test de Chi Cuadrado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.MaskedTextBox txt_intervalos;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_confianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnIrChi;
    }
}

