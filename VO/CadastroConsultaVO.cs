using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.VO
{
    public class CadastroConsultaVO : BaseVO
    {
        public DateTime dataconsulta { get; set; }
        public int qntsessoes { get; set; }
        public ProcedimentoVO procedimento { get; set; }
        public PagamentoVO pagamento { get; set; }
    }
}
