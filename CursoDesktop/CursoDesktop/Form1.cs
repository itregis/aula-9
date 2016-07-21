using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cliennteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente formCadastrarCliente = new CadastrarCliente();
            formCadastrarCliente.MdiParent = this;
            formCadastrarCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto formCadastrarProduto = new CadastrarProduto();
            formCadastrarProduto.MdiParent = this;
            formCadastrarProduto.Show();
        }
    }
}
