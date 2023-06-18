using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.VO
{
    public class CadastroClienteVO : BaseVO
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public int telefone { get; set; }
        public int senha { get; set; }
    }
}
