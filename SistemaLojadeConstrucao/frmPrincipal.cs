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

namespace SistemaLojadeConstrucao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           using (SqlConnection novaConexao = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    novaConexao.Open();
                    MessageBox.Show("Conectou!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Não conectou!");
                }
                finally
                {
                    MessageBox.Show("Bem-vindo ao Sistema para Loja de Materiais para Consturção!");
                }
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Evento Click do btnClientes em que o formulário frmClientes é instanciado e exibido.
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //Evento Click do btnProdutos em que o fomulário frmProdutos é instanciado e exibido.
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.Show(); 

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //Evento Click do btnFuncionario e que o fomulário frmFuncionario é instanciado e exibido.
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.Show();
        }
    }
}
