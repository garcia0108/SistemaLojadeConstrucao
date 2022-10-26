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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void bntCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.Show();
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            frmUnidades frmUnidades  = new frmUnidades();
            frmUnidades.Show(); 
        }
    }
}
