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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormProduto frProduto = null; // aqui

        private void mnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //encerra o programa
        }
        // gerar o evento para o código do botão abaixo
        private void mnProdutos_Click(object sender, EventArgs e)
        {
            if (frProduto == null) // aqui também
            {
                frProduto = new FormProduto();
                frProduto.MdiParent = this;
                frProduto.Location = new Point(0, 0);
                frProduto.Show();
            }
        }
    }
}
