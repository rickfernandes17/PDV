using PDV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmFuncionario : Form
    {
        DataTable dt = new DataTable();
        public FrmFuncionario()
        {
            InitializeComponent();
            Buscar();
        }

        private void Buscar() {
            dt = Funcionario.GetFuncionarios();
            dgvFuncionarios.DataSource = dt;
        }

        
    }
}
