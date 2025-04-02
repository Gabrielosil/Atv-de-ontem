using System.Text.RegularExpressions;

namespace ATV31do3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtIdade.Clear();
            txtSenha.Clear();
            txtConfirmar.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) || txtNome.Text.Length < 3)
            {
                MessageBox.Show("O nome completo tem que ter 3 caracteres no mínimo.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("e-mail invalido!.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidIdade(txtIdade.Text))
            {
                MessageBox.Show("Sua idade deve estar entre 18 e 100 Anos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("As senhas não são iguais.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!checkBox1.Checked)
            {
                MessageBox.Show("para continuar, você tem que aceitar os termos de uso.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cadastro finalizado com exito!", "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidIdade(string idadeText)
        {
            if (int.TryParse(idadeText, out int idade))
            {
                if (idade >= 18 && idade <= 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}