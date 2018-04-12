using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Modelos;

namespace TP1
{
    public partial class Principal : Form
    {
        private GeneradorMixto AleatorioMixtos { get; set; }
        //private GeneradorMultiplicativo AleatorioMultiplicativo { get; set; }
        //private GeneradorLenguaje AleatorioLenguaje { get; set; }
        //private List<Generado> ListaAleatoriosMultiplicativos { get; set; }
        private List<Generado> ListaAleatoriosMixtos { get; set; }
        //private List<Generado> ListaAleatoriosLenguaje { get; set; }

        public Principal()
        {
            InitializeComponent();
            AleatorioMixtos = new GeneradorMixto();
            //AleatorioMultiplicativo = new GeneradorMultiplicativo();
            //AleatorioLenguaje = new GeneradorLenguaje();

            btnGenerarUnAleatorioMixto.Enabled = false;
            //btnGenerarUnAleatorioMultiplicativo.Enabled = false;
        }

        public void InicializarGrilla()
        {
            ListaAleatoriosMixtos = new List<Generado>();
            //ListaAleatoriosMultiplicativos = new List<Generado>();
            //ListaAleatoriosLenguaje = new List<Generado>();

            dgMixto.DataSource = null;
            //dgMultiplicativo.DataSource = null;
            //grilla_aleatorios_lenguaje.DataSource = null;

            AleatorioMixtos = new GeneradorMixto();
            //AleatorioMultiplicativo = new GeneradorMultiplicativo();
            //AleatorioLenguaje = new GeneradorLenguaje();
        }

        private void btnGenerarAleatoriosMixto_Click(object sender, EventArgs e)
        {
            InicializarGrilla();

            try
            {
                AleatorioMixtos.Semilla = double.Parse(txtSemillaMixto.Text);
                AleatorioMixtos.C = double.Parse(txtCMixto.Text);
                AleatorioMixtos.A = double.Parse(txtAMixto.Text);
                AleatorioMixtos.M = double.Parse(txtMMixto.Text);

                //Pregunto si el textbox de cantidad de aleatorios mixtos tiene una cantidad, si es asi establesco la cantidad
                //sino por defecto establezco que es 20
                var contador = txtCantAleatoriosMixto.Text != string.Empty
                    ? int.Parse(txtCantAleatoriosMixto.Text)
                    : 20;


                for (var i = 0; i < contador; i++)
                {
                    AleatorioMixtos.GenerarAleatorio(i);

                    ListaAleatoriosMixtos.Add(new Generado()
                    {
                        NumAleatorio = TruncateFunction(AleatorioMixtos.Generado.NumAleatorio, 4),
                        Iteracion = AleatorioMixtos.Generado.Iteracion
                    });

                }

                //Bindeo la lista
                dgMixto.DataSource = ListaAleatoriosMixtos;

                btnGenerarUnAleatorioMixto.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese los parámetros obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double TruncateFunction(double number, int digits)
        {
            double stepper = (double)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (double)temp / stepper;
        }

        private void txtKMixto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var k = double.Parse(this.txtKMixto.Text);
                AleatorioMixtos.CalcularA(k);

                txtAMixto.Text = AleatorioMixtos.A.ToString();
                txtAMixto.Enabled = false;

            }
            catch (Exception)
            {
                txtAMixto.Text = "";
                Console.Write(e.ToString());
            }
        }

        private void txtGMixto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var g = double.Parse(txtGMixto.Text);
                AleatorioMixtos.CalcularM(g);

                txtMMixto.Text = AleatorioMixtos.M.ToString();
                txtMMixto.Enabled = false;
            }
            catch (Exception)
            {
                txtMMixto.Text = "";
                Console.Write(e.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAMixto.Text = "";
            txtCMixto.Text = "";
            txtGMixto.Text = "";
            txtKMixto.Text = "";
            txtMMixto.Text = "";
            txtSemillaMixto.Text = "";
            txtCantAleatoriosMixto.Text = "";

            txtAMixto.Enabled = true;
            txtMMixto.Enabled = true;

            btnGenerarUnAleatorioMixto.Enabled = false;

            InicializarGrilla();
        }

        private void btnGenerarUnAleatorioMixto_Click(object sender, EventArgs e)
        {
            var aleatorio = AleatorioMixtos.GenerarAleatorio(ListaAleatoriosMixtos.Count);

            ListaAleatoriosMixtos.Add(new Generado()
            {
                NumAleatorio = TruncateFunction(aleatorio.NumAleatorio, 4),
                Iteracion = aleatorio.Iteracion
            });

            //Limpio el bindeo y luego bindeo nuevamente la grilla con la lista
            dgMixto.DataSource = null;
            dgMixto.DataSource = ListaAleatoriosMixtos;
        }
    }
}
