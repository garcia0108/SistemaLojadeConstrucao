using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLojadeConstrucao
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            //se verificado que o RadionButton rbPessoaFisica está selecionado
            if (rbPessoaFisica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa física fica visível e da jurídica invisível
                gbDocumentosPessoaFisica.Visible = true;
                gbDocumentosPessoaJuridica.Visible = false;
            }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //se verificado que o RadionButton rbPessoaJuridica está selecionado
            if (rbPessoaJuridica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa jurídica fica visível e da física invisível
                gbDocumentosPessoaJuridica.Visible = true;
                gbDocumentosPessoaFisica.Visible = false;
            }
        }
    }
}
