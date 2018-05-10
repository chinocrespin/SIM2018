using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Montecarlo.Acumuladores;
using Montecarlo.Distribucion;
using TP_Montecarlo.Utilidades;

namespace TP_Montecarlo
{
    public partial class Principal : Form
    {
        private readonly DistribucionAleatoria _tiempoActividadA;
        private readonly DistribucionAleatoria _tiempoActividadB;
        private readonly DistribucionAleatoria _tiempoActividadC;
        private readonly DistribucionAleatoria _tiempoActividadD;
        private readonly int _decimales = 3;
        private readonly bool _mostrarTiempo = false;

        private bool _procesando = false;
        
        public Principal()
        {
            InitializeComponent();

            _tiempoActividadA = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(5, 0.25),
                new Probabilidad(6, 0.35),
                new Probabilidad(7, 0.25),
                new Probabilidad(8, 0.15)
            });
            _tiempoActividadB = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(3, 0.20),
                new Probabilidad(5, 0.55),
                new Probabilidad(7, 0.25)
            });
            _tiempoActividadC = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(10, 0.10),
                new Probabilidad(12, 0.25),
                new Probabilidad(14, 0.40),
                new Probabilidad(16, 0.20),
                new Probabilidad(18, 0.05)
            });
            _tiempoActividadD = new DistribucionAleatoria(new List<Probabilidad>()
            {
                new Probabilidad(8, 0.60),
                new Probabilidad(10, 0.40)
            });

            txtProbabilidad.Text = "";
            txtSemanas.Text = @"33";
            txtSimulaciones.Text = @"10";
            txtFilaDesde.Text = @"1";
            txtCantidadFilas.Text = @"10";
        }

        private decimal TiempoBuscado()
        {
            string input = txtSemanas.Text;
            decimal output;
            if(!decimal.TryParse(input, out output))
                throw new Exception("El tiempo buscado debe ser un número.");
            return output;
        }

        private long Simulaciones()
        {
            string input = txtSimulaciones.Text;
            long output;
            if (!Int64.TryParse(input, out output))
                throw new Exception("La cantidad de simulaciones debe ser un número entero.");
            return output;
        }

        private int FilaDesde()
        {
            string input = txtFilaDesde.Text;
            int output;
            if (!Int32.TryParse(input, out output))
                throw new Exception("La fila desde donde mostrar debe ser un número entero.");
            return output;
        }

        private int CantidadFilas()
        {
            string input = txtCantidadFilas.Text;
            int output;
            if (!Int32.TryParse(input, out output))
                throw new Exception("La cantidad de filas a mostrar debe ser un número entero.");
            return output;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Simular();
        }

        private void Simular()
        {
            try
            {
                if (!ValidarFormulario()) return;
                
                long simulaciones = Simulaciones();

                LimpiarGrilla();
                IniciarProceso();

                var acumuladorExitos = new TotalAcumulado();
                int mostrarDesde = FilaDesde();
                int cantidadAMostrar = CantidadFilas();
                Cronometro cronometro = new Cronometro();
                cronometro.Iniciar();
                int exp;
                for (exp = 1; exp <= simulaciones; exp++)
                {
                    var semanas = new List<int>();
                    var randomA = _tiempoActividadA.ObtenerValorConRandomAsociado();
                    semanas.Add((int)randomA.Valor);
                    var randomB = _tiempoActividadB.ObtenerValorConRandomAsociado();
                    semanas.Add((int)randomB.Valor);
                    var randomC = _tiempoActividadC.ObtenerValorConRandomAsociado();
                    semanas.Add((int)randomC.Valor);
                    var randomD = _tiempoActividadD.ObtenerValorConRandomAsociado();
                    semanas.Add((int)randomD.Valor);

                    int totalSemanas = semanas.Sum();

                    if (CumpleTiempoBuscado(totalSemanas))
                        acumuladorExitos.CalcularSiguiente(1);

                    //Tabla
                    if (mostrarDesde <= exp && exp < mostrarDesde + cantidadAMostrar)
                    {
                        dgDatos.Rows.Add(exp, Math.Round(randomA.Random, _decimales), randomA.Valor, Math.Round(randomB.Random, _decimales), randomB.Valor, Math.Round(randomC.Random, _decimales),
                        randomC.Valor, Math.Round(randomD.Random, _decimales), randomD.Valor, totalSemanas, acumuladorExitos.Total);
                    }

                    Application.DoEvents();
                    if (!EnProceso()) break;
                }

                CortarProceso();

                cronometro.Finalizar();
                if(_mostrarTiempo)
                    Mensaje(cronometro.TiempoTranscurrido().ToString("h'h 'm'm 's's'"), "Tiempo transcurrido");
                
                var probabilidad = exp / acumuladorExitos.Total;
                txtProbabilidad.Text = Math.Round(probabilidad, _decimales).ToString();

            }
            catch (Exception e)
            {
                MensajeError(e.Message);
            }
        }

        private bool ValidarFormulario()
        {
            decimal numeroDecimal;
            long numeroEntero;

            var tiempoBuscado = txtSemanas.Text;
            if (string.IsNullOrEmpty(tiempoBuscado) || !decimal.TryParse(tiempoBuscado, out numeroDecimal))
            {
                MensajeError("El tiempo buscado debe ser un número.");
                txtSemanas.Focus();
                return false;
            }

            var simulaciones = txtSimulaciones.Text;
            if (string.IsNullOrEmpty(simulaciones) || !Int64.TryParse(simulaciones, out numeroEntero))
            {
                MensajeError("La cantidad de simulaciones debe ser un número entero.");
                txtSimulaciones.Focus();
                return false;
            }

            var filaDesde = txtFilaDesde.Text;
            if (string.IsNullOrEmpty(filaDesde) || !Int64.TryParse(filaDesde, out numeroEntero))
            {
                MensajeError("La fila desde donde mostrar debe ser un número entero.");
                txtFilaDesde.Focus();
                return false;
            }

            var filasMostradas = txtCantidadFilas.Text;
            if (string.IsNullOrEmpty(filasMostradas) || !Int64.TryParse(filasMostradas, out numeroEntero))
            {
                MensajeError("La cantidad de filas a mostrar debe ser un número entero.");
                txtCantidadFilas.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarGrilla()
        {
            dgDatos.Rows.Clear();
            txtProbabilidad.Text = "";
        }

        private bool CumpleTiempoBuscado(decimal semanas)
        {
            return semanas >= TiempoBuscado();
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Mensaje(string mensaje, string titulo = "Aviso")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void IniciarProceso()
        {
            _procesando = true;
            btnCancelarProceso.Visible = true;
            btnSimular.Enabled = false;
        }

        public bool EnProceso()
        {
            return _procesando;
        }

        public void CortarProceso()
        {
            _procesando = false;
            btnCancelarProceso.Visible = false;
            btnSimular.Enabled = true;
        }

        private void btnCancelarProceso_Click(object sender, EventArgs e)
        {
            CortarProceso();
        }
    }
}
