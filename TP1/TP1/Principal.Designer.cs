namespace TP1
{
    partial class Principal
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMixto = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantIntervalosMixto = new System.Windows.Forms.TextBox();
            this.btnGenerarHistogramaMixto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gpGenerador = new System.Windows.Forms.GroupBox();
            this.btnGenerarUnAleatorioMixto = new System.Windows.Forms.Button();
            this.btnGenerarAleatoriosMixto = new System.Windows.Forms.Button();
            this.txtCantAleatoriosMixto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgMixto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGMixto = new System.Windows.Forms.TextBox();
            this.txtKMixto = new System.Windows.Forms.TextBox();
            this.txtMMixto = new System.Windows.Forms.TextBox();
            this.txtCMixto = new System.Windows.Forms.TextBox();
            this.txtAMixto = new System.Windows.Forms.TextBox();
            this.txtSemillaMixto = new System.Windows.Forms.TextBox();
            this.tabMultiplicativo = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tabMixto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpGenerador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMixto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMixto);
            this.tabs.Controls.Add(this.tabMultiplicativo);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(993, 517);
            this.tabs.TabIndex = 4;
            // 
            // tabMixto
            // 
            this.tabMixto.Controls.Add(this.groupBox2);
            this.tabMixto.Controls.Add(this.gpGenerador);
            this.tabMixto.Controls.Add(this.dgMixto);
            this.tabMixto.Controls.Add(this.groupBox1);
            this.tabMixto.Location = new System.Drawing.Point(4, 25);
            this.tabMixto.Name = "tabMixto";
            this.tabMixto.Padding = new System.Windows.Forms.Padding(3);
            this.tabMixto.Size = new System.Drawing.Size(985, 488);
            this.tabMixto.TabIndex = 0;
            this.tabMixto.Text = "Congruencial Mixto";
            this.tabMixto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantIntervalosMixto);
            this.groupBox2.Controls.Add(this.btnGenerarHistogramaMixto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(-4, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histograma";
            // 
            // txtCantIntervalosMixto
            // 
            this.txtCantIntervalosMixto.Location = new System.Drawing.Point(21, 51);
            this.txtCantIntervalosMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtCantIntervalosMixto.Name = "txtCantIntervalosMixto";
            this.txtCantIntervalosMixto.Size = new System.Drawing.Size(123, 22);
            this.txtCantIntervalosMixto.TabIndex = 1;
            // 
            // btnGenerarHistogramaMixto
            // 
            this.btnGenerarHistogramaMixto.Location = new System.Drawing.Point(154, 48);
            this.btnGenerarHistogramaMixto.Name = "btnGenerarHistogramaMixto";
            this.btnGenerarHistogramaMixto.Size = new System.Drawing.Size(105, 28);
            this.btnGenerarHistogramaMixto.TabIndex = 2;
            this.btnGenerarHistogramaMixto.Text = "Graficar";
            this.btnGenerarHistogramaMixto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cant. de intervalos";
            // 
            // gpGenerador
            // 
            this.gpGenerador.Controls.Add(this.btnGenerarUnAleatorioMixto);
            this.gpGenerador.Controls.Add(this.btnGenerarAleatoriosMixto);
            this.gpGenerador.Controls.Add(this.txtCantAleatoriosMixto);
            this.gpGenerador.Controls.Add(this.label7);
            this.gpGenerador.Location = new System.Drawing.Point(-4, 87);
            this.gpGenerador.Name = "gpGenerador";
            this.gpGenerador.Size = new System.Drawing.Size(439, 95);
            this.gpGenerador.TabIndex = 5;
            this.gpGenerador.TabStop = false;
            this.gpGenerador.Text = "Generador";
            // 
            // btnGenerarUnAleatorioMixto
            // 
            this.btnGenerarUnAleatorioMixto.Location = new System.Drawing.Point(348, 43);
            this.btnGenerarUnAleatorioMixto.Name = "btnGenerarUnAleatorioMixto";
            this.btnGenerarUnAleatorioMixto.Size = new System.Drawing.Size(46, 28);
            this.btnGenerarUnAleatorioMixto.TabIndex = 3;
            this.btnGenerarUnAleatorioMixto.Text = "+1";
            this.btnGenerarUnAleatorioMixto.UseVisualStyleBackColor = true;
            this.btnGenerarUnAleatorioMixto.Click += new System.EventHandler(this.btnGenerarUnAleatorioMixto_Click);
            // 
            // btnGenerarAleatoriosMixto
            // 
            this.btnGenerarAleatoriosMixto.Location = new System.Drawing.Point(237, 43);
            this.btnGenerarAleatoriosMixto.Name = "btnGenerarAleatoriosMixto";
            this.btnGenerarAleatoriosMixto.Size = new System.Drawing.Size(105, 28);
            this.btnGenerarAleatoriosMixto.TabIndex = 2;
            this.btnGenerarAleatoriosMixto.Text = "Generar";
            this.btnGenerarAleatoriosMixto.UseVisualStyleBackColor = true;
            this.btnGenerarAleatoriosMixto.Click += new System.EventHandler(this.btnGenerarAleatoriosMixto_Click);
            // 
            // txtCantAleatoriosMixto
            // 
            this.txtCantAleatoriosMixto.Location = new System.Drawing.Point(21, 46);
            this.txtCantAleatoriosMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtCantAleatoriosMixto.Name = "txtCantAleatoriosMixto";
            this.txtCantAleatoriosMixto.Size = new System.Drawing.Size(206, 22);
            this.txtCantAleatoriosMixto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad de números aleatorios";
            // 
            // dgMixto
            // 
            this.dgMixto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMixto.Location = new System.Drawing.Point(445, 87);
            this.dgMixto.Name = "dgMixto";
            this.dgMixto.RowHeadersVisible = false;
            this.dgMixto.RowTemplate.Height = 24;
            this.dgMixto.Size = new System.Drawing.Size(544, 416);
            this.dgMixto.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGMixto);
            this.groupBox1.Controls.Add(this.txtKMixto);
            this.groupBox1.Controls.Add(this.txtMMixto);
            this.groupBox1.Controls.Add(this.txtCMixto);
            this.groupBox1.Controls.Add(this.txtAMixto);
            this.groupBox1.Controls.Add(this.txtSemillaMixto);
            this.groupBox1.Location = new System.Drawing.Point(-4, -14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(860, 43);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 28);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semilla";
            // 
            // txtGMixto
            // 
            this.txtGMixto.Location = new System.Drawing.Point(723, 46);
            this.txtGMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtGMixto.Name = "txtGMixto";
            this.txtGMixto.Size = new System.Drawing.Size(127, 22);
            this.txtGMixto.TabIndex = 11;
            this.txtGMixto.TextChanged += new System.EventHandler(this.txtGMixto_TextChanged);
            // 
            // txtKMixto
            // 
            this.txtKMixto.Location = new System.Drawing.Point(586, 46);
            this.txtKMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtKMixto.Name = "txtKMixto";
            this.txtKMixto.Size = new System.Drawing.Size(127, 22);
            this.txtKMixto.TabIndex = 9;
            this.txtKMixto.TextChanged += new System.EventHandler(this.txtKMixto_TextChanged);
            // 
            // txtMMixto
            // 
            this.txtMMixto.Location = new System.Drawing.Point(449, 46);
            this.txtMMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtMMixto.Name = "txtMMixto";
            this.txtMMixto.Size = new System.Drawing.Size(127, 22);
            this.txtMMixto.TabIndex = 7;
            // 
            // txtCMixto
            // 
            this.txtCMixto.Location = new System.Drawing.Point(312, 46);
            this.txtCMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtCMixto.Name = "txtCMixto";
            this.txtCMixto.Size = new System.Drawing.Size(127, 22);
            this.txtCMixto.TabIndex = 5;
            // 
            // txtAMixto
            // 
            this.txtAMixto.Location = new System.Drawing.Point(175, 46);
            this.txtAMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtAMixto.Name = "txtAMixto";
            this.txtAMixto.Size = new System.Drawing.Size(127, 22);
            this.txtAMixto.TabIndex = 3;
            // 
            // txtSemillaMixto
            // 
            this.txtSemillaMixto.Location = new System.Drawing.Point(38, 46);
            this.txtSemillaMixto.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.txtSemillaMixto.Name = "txtSemillaMixto";
            this.txtSemillaMixto.Size = new System.Drawing.Size(127, 22);
            this.txtSemillaMixto.TabIndex = 1;
            // 
            // tabMultiplicativo
            // 
            this.tabMultiplicativo.Location = new System.Drawing.Point(4, 25);
            this.tabMultiplicativo.Name = "tabMultiplicativo";
            this.tabMultiplicativo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplicativo.Size = new System.Drawing.Size(985, 488);
            this.tabMultiplicativo.TabIndex = 1;
            this.tabMultiplicativo.Text = "Congruencial Multiplicativo";
            this.tabMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 541);
            this.Controls.Add(this.tabs);
            this.Name = "Principal";
            this.Text = "TP 1 SIM";
            this.tabs.ResumeLayout(false);
            this.tabMixto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpGenerador.ResumeLayout(false);
            this.gpGenerador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMixto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMixto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantIntervalosMixto;
        private System.Windows.Forms.Button btnGenerarHistogramaMixto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpGenerador;
        private System.Windows.Forms.Button btnGenerarUnAleatorioMixto;
        private System.Windows.Forms.Button btnGenerarAleatoriosMixto;
        private System.Windows.Forms.TextBox txtCantAleatoriosMixto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgMixto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGMixto;
        private System.Windows.Forms.TextBox txtKMixto;
        private System.Windows.Forms.TextBox txtMMixto;
        private System.Windows.Forms.TextBox txtCMixto;
        private System.Windows.Forms.TextBox txtAMixto;
        private System.Windows.Forms.TextBox txtSemillaMixto;
        private System.Windows.Forms.TabPage tabMultiplicativo;
    }
}

