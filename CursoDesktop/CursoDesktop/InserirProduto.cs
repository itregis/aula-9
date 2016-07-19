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
    public partial class InserirProduto : Form
    {
        public InserirProduto()
        {
            InitializeComponent();
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Produto prd = new Produto();
            prd.Descricao = txtDescricao.Text;
            prd.Valor = Convert.ToDouble(nuValor.Value.ToString());
            prd.Fabricante = cbFabricante.SelectedText;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            nuValor.Value = 0;
            cbFabricante.SelectedItem = 0;
        }
    }
}
