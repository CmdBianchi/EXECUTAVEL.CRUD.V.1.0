using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
namespace EXECUTAVEL.CRUD.V._1._0 {
    public partial class CadastroFuncionario : Form {
        public CadastroFuncionario() {
            InitializeComponent();
        }

        private void SalvarAction(object sender, EventArgs e) {

            // Mover os dados para a classe duncionario
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Salario = txtSalario.Text;
            funcionario.Sexo = ()? 
            // Validar os dados
            // Salvar os dados
            // Dechar e atualizar a TelaPrincipal
        }
    }
}
