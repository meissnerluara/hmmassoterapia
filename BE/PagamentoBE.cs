using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.BE
{
    public class PagamentoBE : BaseBE
    {
        private VO.PagamentoVO vo;
        private DAO.PagamentoDAO dao;

        public PagamentoBE(VO.PagamentoVO vo)
        {
            this.vo = vo;
        }
        public void incluir()
        {
            if (string.IsNullOrEmpty(this.vo.email))
            {
                throw new Exception("Email obrigatório!");
            }

            dao = new DAO.PagamentoDAO(this.vo);
            dao.incluir();
        }
        public void alterar()
        {
            dao = new DAO.PagamentoDAO(this.vo);
            dao.alterar();
        }
        public VO.PagamentoVO carregar()
        {
            dao = new DAO.PagamentoDAO(this.vo);
            return dao.carregar();
        }
        public void remover()
        {
            dao = new DAO.PagamentoDAO(this.vo);
            dao.remover();
        }
        public List<VO.PagamentoVO> listar()
        {
            dao = new DAO.PagamentoDAO(this.vo);
            return dao.listar();
        }
    }
}
