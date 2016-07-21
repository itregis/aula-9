using AcessoDados;
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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            InserirCliente formInserirCliente = new InserirCliente();
            formInserirCliente.MdiParent = this.MdiParent;
            formInserirCliente.Show();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            DBCliente dbCli = new DBCliente();
            DataGridViewRow row = gwCliente.CurrentRow;
            if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
            {
                dbCli.RemoverCliente(row.Cells[1].Value.ToString());
            }
            btConsultar_Click(sender, e);
            MessageBox.Show("Cliente removido com sucesso!");
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            DBCliente dbCli = new DBCliente();
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                gwCliente.DataSource = dbCli.ConsultarTodosClientes();
            }
            else
            {
                gwCliente.DataSource = dbCli.ConsultarClientePorNome(txtNome.Text);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gwCliente.CurrentRow;
            Cliente cli = new Cliente();
            cli.Codigo = Convert.ToInt16(row.Cells[0].Value);
            cli.Nome = row.Cells[1].Value.ToString();
            cli.Idade = Convert.ToInt16(row.Cells[2].Value);
            cli.Telefone = row.Cells[3].Value.ToString();
            cli.Endereco = row.Cells[4].Value.ToString();
            cli.Sexo = Convert.ToChar(row.Cells[5].Value);
            try
            {
                if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    InserirCliente formInserirCliente = new InserirCliente(cli);
                    formInserirCliente.MdiParent = this.MdiParent;
                    formInserirCliente.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na pesquisa de Cliente");
                throw;
            }
            
        }
    }
}
