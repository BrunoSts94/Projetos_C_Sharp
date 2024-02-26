using System.Security.Cryptography;
using System.Text;

namespace CriptoProg
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();

            // Inicializa a instância de RSACryptoServiceProvider
            this.rsa = new RSACryptoServiceProvider();

            // Verificar se as chaves já existem em um arquivo
            if (File.Exists("chaves.xml"))
            {
                // Carregar chaves existentes, salvas no arquivo "chaves.xml"
                this.rsa.FromXmlString(File.ReadAllText("chaves.xml"));
            }
            else
            {
                // Criar um novo par de chaves
                File.WriteAllText("chaves.xml", this.rsa.ToXmlString(true));
            }

        }



        private void btnCriptografa_Click(object sender, EventArgs e)
        {
            // Obter o texto a ser criptografado
            string textoInicial = textBox1.Text;

            // Criptografar usando a chave pública
            byte[] textoCriptografado = EncryptData(textoInicial, rsa.ToXmlString(false));

            // Exibir o resultado da criptografia
            textBox2.Text = Convert.ToBase64String(textoCriptografado);
        }

        private void btnDescriptografa_Click(object sender, EventArgs e)
        {
            try
            {
                string pvK = rsa.ToXmlString(true);
                // Obter o texto criptografado
                string textoCriptografadoBase64 = textBox2.Text;

                byte[] textoCriptografado = Convert.FromBase64String(textoCriptografadoBase64);

                // Descriptografar usando a chave privada
                string textoDescriptografado = DecryptData(textoCriptografado, rsa.ToXmlString(true));

                // Exibir o resultado da descriptografia
                textBox1.Text = textoDescriptografado;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

        //Metodo do Botão de Copiar dados do campo Criptografia
        private void btnCopiaCriptografia_Click(object sender, EventArgs e)
        {
            // Verifica se há texto no TextBox
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Copia o texto para a área de transferência
                Clipboard.SetText(textBox1.Text);

                // Exibe uma mensagem informando que os dados foram copiados
                MessageBox.Show("Dados copiados para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Exibe uma mensagem se o TextBox estiver vazio
                MessageBox.Show("Nenhum dado para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Metodo do Botão de Copiar dados do campo Descriptografia
        private void btnCopiaDescriptografia_Click(object sender, EventArgs e)
        {
            // Verifica se há texto no TextBox
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                // Copia o texto para a área de transferência
                Clipboard.SetText(textBox2.Text);

                // Exibe uma mensagem informando que os dados foram copiados
                MessageBox.Show("Dados copiados para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Exibe uma mensagem se o TextBox estiver vazio
                MessageBox.Show("Nenhum dado para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Faz a limpeza dos campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }




        private byte[] EncryptData(string data, string publicKey)
        {
            using (RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider())
            {
                rsaEncrypt.FromXmlString(publicKey);
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(data);
                return rsaEncrypt.Encrypt(dataToEncrypt, false);
            }
        }

        private string DecryptData(byte[] encryptedData, string privateKey)
        {
            using (RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider())
            {
                rsaDecrypt.FromXmlString(privateKey);
                byte[] decryptedData = rsaDecrypt.Decrypt(encryptedData, false);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }



        // Métodos não usados dos campos de texto, não podem ser apagados senão da erro
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}