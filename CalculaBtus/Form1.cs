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
            //Trata o erro de formato inválido
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

                //Se selecionar com sol da tarde, ele faz esse calculo
                if (chkSolDaTarde.Checked)
                {
                    AreaEmMetros = double.Parse(txtAreaEmMetrosQuadrados.Text);
                    result = AreaEmMetros * 800;
                    //No final ele soma o resultado + qntPessoas * 800
                    result += quantidadePessoa * 800;
                    //Mostra o resultado na tela para o user
                    lblResultado.Text = $"Área de {AreaEmMetros} metros quadrados," +
                          $" com {quantidadePessoa} pessoas usando o ambiente, será necessário {result} BTUs.";
                }
                //Se não selecionar com sol da tarde, ele faz esse calculo
                else
                {
                    AreaEmMetros = double.Parse(txtAreaEmMetrosQuadrados.Text);
                    result = AreaEmMetros * 600;
                    //No final ele soma o resultado + qntPessoas * 800
                    result += quantidadePessoa * 600;
                    //Mostra o resultado na tela para o user
                    lblResultado.Text = $"Área de {AreaEmMetros} metros quadrados," +
                          $" com {quantidadePessoa} pessoas usando o ambiente, será necessário {result} BTUs.";
                }

            }
            //Trata o erro de formato inválido
            catch (FormatException)
            {
                MessageBox.Show("Digite uma valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LimpaCampo()
        {
            //Método para limpar os campos
            txt_Largura.Text = "";
            txt_Comprimento.Text = "";
            txtAreaEmMetrosQuadrados.Text = "";
            lblResultado.Text = "";
            cboQuantidadeDePessoas.Text = "";
            chkSolDaTarde.Checked = false;
            cboQuantidadeDePessoas.SelectedIndex = 0;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //Chama o método para limpar os campos 
            LimpaCampo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Já começa o programa com uma 0 pessoa selecionada
            cboQuantidadeDePessoas.SelectedIndex = 0;
        }

        private void txt_Largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_Comprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAreaEmMetrosQuadrados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}