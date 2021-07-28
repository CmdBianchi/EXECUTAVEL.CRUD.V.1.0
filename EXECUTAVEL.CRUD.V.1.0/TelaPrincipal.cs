using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXECUTAVEL.CRUD.V._1._0 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            dgvTabelaFuncionario.DataSource = BANCO.FuncionarioDataAccess.PegarFUncionario();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void NovoAction(object sender, EventArgs e) {
            new CadastroFuncionario().Show();
        }
    }
}
