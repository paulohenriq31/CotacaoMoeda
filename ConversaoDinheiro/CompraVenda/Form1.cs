using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            /*Lista dos Codigos da Referencia "Moeda"
            10813	Dólar (compra)
            21619	Euro (venda)
            21620	Euro (compra)
            21621	Iene (venda)
            21622	Iene (compra)
            21623	Libra esterlina (venda)
            21624	Libra esterlina (compra)
            21625	Franco Suíço (venda)
            21626	Franco Suíço (compra)
            21627	Coroa Dinamarquesa (venda)
            21628	Coroa Dinamarquesa (compra)
            21629	Coroa Norueguesa (venda)
            21630	Coroa Norueguesa (compra)
            21631	Coroa Sueca (venda)
            21632	Coroa Sueca (compra)
            21633	Dólar Australiano (venda)
            21634	Dólar Australiano (compra)
            21635	Dólar Canadense (venda)
            21636	Dólar Canadense (compra)*/

            string moeda = cmbMoedas.Items[cmbMoedas.SelectedIndex].ToString();
            int codMoeda = 1;

            if (moeda == "Dólar (Compra)")
            {
                codMoeda = 10813;

            }
            else if (moeda == "Dólar (Venda)")
            {
                codMoeda = 1;
            }
            else if (moeda == "Euro (Compra)")
            {
                codMoeda = 21620;
            }
            else if (moeda == "Euro (Venda)")
            {
                codMoeda = 21619;
            }
            else if (moeda == "Iene (Compra)")
            {
                codMoeda = 21622;
            }
            else if (moeda == "Iene (Venda)")
            {
                codMoeda = 21621;
            }
            else if (moeda == "Dólar Canadense (Compra)")
            {
                codMoeda = 21635;
            }
            else if (moeda == "Dólar Canadense (Venda))")
            {
                codMoeda = 21636;
            }
            else
            {
                MessageBox.Show("Erro !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //pegar o valor da moeda na referencia "Moeda"
            var service = new Moeda.FachadaWSSGSClient();
            var cotacao = service.getUltimoValorVO(codMoeda);
            string valor = (cotacao.ultimoValor.svalor).ToString();
            MessageBox.Show("Valor: " + valor, "Cotação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

    }
}
