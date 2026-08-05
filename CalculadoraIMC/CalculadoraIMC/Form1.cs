namespace CalculadoraIMC
{
    public partial class lblCalculadoraImc : Form
    {
        public lblCalculadoraImc()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.Red;
            txtAltura.BackColor = Color.White;
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.BackColor = Color.White;
        }

        private void inserirNumeros_Click(object sender, EventArgs e)
        {
            if (txtPeso.BackColor == Color.Red)
            {
                txtPeso.Text += (sender as Button).Text;
            }

            if (txtAltura.BackColor == Color.Red)
            {
                txtAltura.Text += (sender as Button).Text;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float imc = peso / (float)Math.Pow(altura, 2);
            txtResultado.Text = imc.ToString("N1");

            if (imc < 19.1)
            {
                lblSituação.Text = "Abaixo do peso!";
            }

            else
            {
               if(imc >= 19.1 && imc <= 25.8)
                {
                    lblSituação.Text = "Peso normal!";
                }

               else
                {
                    lblSituação.Text = "Obeso";
                }
            }
        }
    }
}

