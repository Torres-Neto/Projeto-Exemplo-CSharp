using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExemplo.WindowsForms.UI
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dvgFornecedores.DataSource = listaFornecedores;

        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (TxtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = TxtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor");

            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o endereço");

            }

            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato");

            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o telefone");

            }

            return fornecedor;
        }
    }
}
