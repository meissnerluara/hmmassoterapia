using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.BE
{
    public class ProcedimentoBE : BaseBE
    {
        private VO.ProcedimentoVO vo;
        private DAO.ProcedimentoDAO dao;

        public ProcedimentoBE(VO.ProcedimentoVO vo)
        {
            this.vo = vo;
        }
        public void incluir()
        {
            if (string.IsNullOrEmpty(this.vo.email))
            {
                throw new Exception("Email obrigatório!");
            }

            dao = new DAO.ProcedimentoDAO(this.vo);
            dao.incluir();
        }
        public void alterar()
        {
            dao = new DAO.ProcedimentoDAO(this.vo);
            dao.alterar();
        }
        public VO.ProcedimentoVO carregar()
        {
            dao = new DAO.ProcedimentoDAO(this.vo);
            return dao.carregar();
        }
        public void remover()
        {
            dao = new DAO.ProcedimentoDAO(this.vo);
            dao.remover();
        }
        public List<VO.ProcedimentoVO> listar()
        {
            dao = new DAO.ProcedimentoDAO(this.vo);
            return dao.listar();
        }
    }
}
