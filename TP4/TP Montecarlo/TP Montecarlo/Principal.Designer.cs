namespace TP_Montecarlo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtSimulaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSemanas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.col_exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rnd_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_actividad_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rnd_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_actividad_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rnd_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_actividad_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rnd_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_actividad_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_semanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ac_semanas_exito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarProceso = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadFilas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilaDesde = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.txtSimulaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSemanas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(356, 34);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(107, 33);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtSimulaciones
            // 
            this.txtSimulaciones.Location = new System.Drawing.Point(162, 55);
            this.txtSimulaciones.Name = "txtSimulaciones";
            this.txtSimulaciones.Size = new System.Drawing.Size(157, 22);
            this.txtSimulaciones.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Simulaciones";
            // 
            // txtSemanas
            // 
            this.txtSemanas.Location = new System.Drawing.Point(162, 27);
            this.txtSemanas.Name = "txtSemanas";
            this.txtSemanas.Size = new System.Drawing.Size(157, 22);
            this.txtSemanas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo buscado";
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_exp,
            this.col_rnd_a,
            this.col_actividad_a,
            this.col_rnd_b,
            this.col_actividad_b,
            this.col_rnd_c,
            this.col_actividad_c,
            this.col_rnd_d,
            this.col_actividad_d,
            this.col_total_semanas,
            this.col_ac_semanas_exito});
            this.dgDatos.Location = new System.Drawing.Point(12, 115);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowTemplate.Height = 24;
            this.dgDatos.Size = new System.Drawing.Size(1495, 357);
            this.dgDatos.TabIndex = 4;
            // 
            // col_exp
            // 
            this.col_exp.HeaderText = "Experimento";
            this.col_exp.Name = "col_exp";
            // 
            // col_rnd_a
            // 
            this.col_rnd_a.HeaderText = "RND A";
            this.col_rnd_a.Name = "col_rnd_a";
            // 
            // col_actividad_a
            // 
            this.col_actividad_a.HeaderText = "Semanas A";
            this.col_actividad_a.Name = "col_actividad_a";
            // 
            // col_rnd_b
            // 
            this.col_rnd_b.HeaderText = "RND B";
            this.col_rnd_b.Name = "col_rnd_b";
            // 
            // col_actividad_b
            // 
            this.col_actividad_b.HeaderText = "Semanas B";
            this.col_actividad_b.Name = "col_actividad_b";
            // 
            // col_rnd_c
            // 
            this.col_rnd_c.HeaderText = "RND C";
            this.col_rnd_c.Name = "col_rnd_c";
            // 
            // col_actividad_c
            // 
            this.col_actividad_c.HeaderText = "Semanas C";
            this.col_actividad_c.Name = "col_actividad_c";
            // 
            // col_rnd_d
            // 
            this.col_rnd_d.HeaderText = "RND D";
            this.col_rnd_d.Name = "col_rnd_d";
            // 
            // col_actividad_d
            // 
            this.col_actividad_d.HeaderText = "Semanas D";
            this.col_actividad_d.Name = "col_actividad_d";
            // 
            // col_total_semanas
            // 
            this.col_total_semanas.HeaderText = "Total Semanas";
            this.col_total_semanas.Name = "col_total_semanas";
            // 
            // col_ac_semanas_exito
            // 
            this.col_ac_semanas_exito.HeaderText = "Acumulador Éxito";
            this.col_ac_semanas_exito.Name = "col_ac_semanas_exito";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProbabilidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(780, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Probabilidad Resultante";
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Location = new System.Drawing.Point(25, 47);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.ReadOnly = true;
            this.txtProbabilidad.Size = new System.Drawing.Size(142, 22);
            this.txtProbabilidad.TabIndex = 1;
            this.txtProbabilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Probabilidad";
            // 
            // btnCancelarProceso
            // 
            this.btnCancelarProceso.Location = new System.Drawing.Point(1020, 46);
            this.btnCancelarProceso.Name = "btnCancelarProceso";
            this.btnCancelarProceso.Size = new System.Drawing.Size(199, 33);
            this.btnCancelarProceso.TabIndex = 3;
            this.btnCancelarProceso.Text = "Cortar Simulación";
            this.btnCancelarProceso.UseVisualStyleBackColor = true;
            this.btnCancelarProceso.Visible = false;
            this.btnCancelarProceso.Click += new System.EventHandler(this.btnCancelarProceso_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCantidadFilas);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFilaDesde);
            this.groupBox3.Location = new System.Drawing.Point(505, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad a mostrar";
            // 
            // txtCantidadFilas
            // 
            this.txtCantidadFilas.Location = new System.Drawing.Point(140, 55);
            this.txtCantidadFilas.Name = "txtCantidadFilas";
            this.txtCantidadFilas.Size = new System.Drawing.Size(116, 22);
            this.txtCantidadFilas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mostrar desde";
            // 
            // txtFilaDesde
            // 
            this.txtFilaDesde.Location = new System.Drawing.Point(140, 27);
            this.txtFilaDesde.Name = "txtFilaDesde";
            this.txtFilaDesde.Size = new System.Drawing.Size(116, 22);
            this.txtFilaDesde.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnCancelarProceso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1525, 531);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 4 - Montecarlo - Proyecto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtSimulaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rnd_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_actividad_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rnd_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_actividad_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rnd_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_actividad_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rnd_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_actividad_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_semanas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ac_semanas_exito;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadFilas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilaDesde;
    }
}

