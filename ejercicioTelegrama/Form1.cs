namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            //JVG2425
            //Este es un telegrama de prueba JVG2425
            //Este es un telegrama de prueba creado para la práctica de Entornos de desarrollo
            //Este es un telegrama de prueba
            //Este es un telegrama de prueba creado para la práctica de Entornos de desarrollo
            string textoTelegrama;

            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            //JVG2425
            // EL código no asigna un valor por defecto a tipoTelegrama, por lo que nunca
            // entrará en la parte correspondiente al telegrama ordinario.
            // Solucionamos esto asignando el valor en el else. Altenativamente, podria ser
            // una asingación inicial.
            else
            {
                tipoTelegrama = 'o';
            }
            //JVG2425
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Split(' ').Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
