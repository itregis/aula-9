using AcessoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CursoDesktop
{
    public partial class InserirCliente : Form
    {
        public InserirCliente(Cliente cli)
        {
            InitializeComponent();
            txtCodigo.Text = cli.Codigo.ToString();
            nuIdade.Value = cli.Idade;
            txtEndereco.Text = cli.Endereco;
            txtNome.Text = cli.Nome;
            mskTelefone.Text = cli.Telefone;
            if (cli.Sexo.Equals('M'))
                rbMasculino.Checked = true;
            else
                rbFeminino.Checked = true;
        }
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Nome = txtNome.Text;
            cli.Idade = Convert.ToInt16(nuIdade.Value.ToString());
            cli.Telefone = mskTelefone.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Sexo = (rbMasculino.Checked ? 'M' :'F');
            if (txtCodigo.Text != "")
                cli.Codigo = Convert.ToUInt16(txtCodigo.Text);
            DBCliente dbCli = new DBCliente();
            try
            {
                if (txtCodigo.Text == "")
                    dbCli.InserirCliente(cli.Nome, cli.Idade, cli.Telefone, cli.Endereco, cli.Sexo);
                else
                    dbCli.AtualizarCliente(cli.Codigo, cli.Nome, cli.Idade, cli.Telefone, cli.Endereco, cli.Sexo);
                MessageBox.Show("Cliente cadatrado com sucesso!");
            }
            catch (SqlException odbcEx)
            {
                MessageBox.Show("Erro ao gravar cadastrar cliente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente!");
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            nuIdade.Value = 0;
            mskTelefone.Text = "";
            txtEndereco.Text = "";
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }
    }
}
