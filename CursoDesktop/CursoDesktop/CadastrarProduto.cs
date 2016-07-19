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
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            InserirProduto formInserirProduto = new InserirProduto();
            formInserirProduto.MdiParent = this.MdiParent;
            formInserirProduto.Show();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }
    }
}
