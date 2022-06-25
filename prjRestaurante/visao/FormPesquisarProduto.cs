using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestaurante.visao
{
    public partial class FormPesquisarProduto : Form
    {
        public FormPesquisarProduto()
        {
            InitializeComponent();
        }

        internal int codigo { get; set; }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            dgvLista.DataSource = tabela.pesquisarnome(txtNome.Text);
            dgvLista.AutoResizeColumns();
        }

        private void btnAbrirFicha_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count != 0)
            {
                codigo = Int16.Parse(dgvLista.CurrentRow.Cells["Codigo"].Value.ToString());
                this.Dispose();
            }
        }
    }
}
