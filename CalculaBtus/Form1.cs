namespace CalculaBtus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_calcularArea_Click(object sender, EventArgs e)
        {
            try
            {
                double largura = double.Parse(txt_Largura.Text);
                double comprimento = double.Parse(txt_Comprimento.Text);
                double area;

                area = largura * comprimento;
                txtAreaEmMetrosQuadrados.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CalculaBtus_Click(object sender, EventArgs e)
        {
            try
            {

                int quantidadePessoa = int.Parse(cboQuantidadeDePessoas.Text);
                double AreaEmMetros;
                double result;

                if (chkSolDaTarde.Checked)
                {
                    AreaEmMetros = double.Parse(txtAreaEmMetrosQuadrados.Text);
                    result = AreaEmMetros * 800;
                }
                else
                {
                    AreaEmMetros = double.Parse(txtAreaEmMetrosQuadrados.Text);
                    result = AreaEmMetros * 600;
                }

                result += quantidadePessoa * 800;

                lblResultado.Text = $"Área de {AreaEmMetros} metros quadrados," +
                      $" com {quantidadePessoa} pessoas usando o ambiente, será necessário {result} BTUs.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}