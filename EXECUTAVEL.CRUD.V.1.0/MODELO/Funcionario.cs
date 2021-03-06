using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modelo {
    class Funcionario { // --- > CLASSES DA TABELA CRIADA
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal Salario { get; set; }
        public string Sexo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
