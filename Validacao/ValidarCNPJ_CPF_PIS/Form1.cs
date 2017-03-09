using System;
using System.Windows.Forms;

namespace ValidarCNPJ_CPF_PIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string mensagem = "";

        /// <summary>
        /// Exemplos de CNPJ Bacen (14 posições sem os caracteres)
        //00.038.166/0001-05
        //00.038.166/0002-88
        //00.038.166/0003-69
        //00.038.166/0004-40
        //00.038.166/0005-20
        //PIS - NNNNNNNNNND (11 posições com o digito)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidar_Click(object sender, EventArgs e)
        {
            //string valor = txtNumero.Text;
            string valor = maskValor.Text;
            if (rdb_cnpj.Checked)
            {
                if (Validacao.ValidaCNPJ.IsCnpj(valor))
                {
                    mensagem = "O número é um CNPJ Válido !";
                }
                else
                {
                    mensagem = "O número é um CNPJ Inválido !";
                }
            }
            else if (rdb_cpf.Checked)
            {
                if (Validacao.ValidaCPF.IsCpf(valor))
                {
                    mensagem = "O número é um CPF Válido !";
                }
                else
                {
                    mensagem = "O número é um CPF Inválido !";
                }
            }
            else if (rdb_pis.Checked)
            {
                if (Validacao.ValidaPis.IsPis(valor))
                {
                    mensagem = "O número é um PIS Válido !";
                }
                else
                {
                    mensagem = "O número é um PIS inválido !";
                }
            }
            else
            {
                mensagem = "Informe o número e o seu tipo para validação !";
            }
            MessageBox.Show(mensagem, "Validação");
        }

        private void rdb_cnpj_CheckedChanged(object sender, EventArgs e)
        {
              maskValor.Text = "";
              maskValor.Mask = "00,000,000/0000-00";
              maskValor.MaskInputRejected += new MaskInputRejectedEventHandler(maskValor_MaskInputRejected);
        }

        private void rdb_cpf_CheckedChanged(object sender, EventArgs e)
        {
              maskValor.Text = "";
              maskValor.Mask = "000,000,000-00";
              maskValor.MaskInputRejected += new MaskInputRejectedEventHandler(maskValor_MaskInputRejected);
        }

        private void rdb_pis_CheckedChanged(object sender, EventArgs e)
        {
              maskValor.Text = "";
              maskValor.Mask = "0000000000-0";
              maskValor.MaskInputRejected += new MaskInputRejectedEventHandler(maskValor_MaskInputRejected);
        }

        void maskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Número informado inválido";
            toolTip1.Show("Somente digitos de (0-9) são permitidos.", maskValor, maskValor.Location, 5000);
        }
        //private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetter(e.KeyChar) ||
        //        char.IsSymbol(e.KeyChar) ||
        //        char.IsWhiteSpace(e.KeyChar) ||
        //        char.IsPunctuation(e.KeyChar))
        //        e.Handled = true;
        //}

        //public static string tira_acentos(string texto)
        //{
        //    string ComAcentos = "!@#$%¨&*()-?:{}][ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç ";
        //    string SemAcentos = "_________________AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc_";
        //    for (int i = 0; i < ComAcentos.Length; i++)
        //        texto = texto.Replace(ComAcentos[i].ToString(), SemAcentos[i].ToString()).Trim();
        //    return texto;
        //}
    }
}
