using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.BE
{
    public class CadastroConsultaBE : BaseBE
    {
        private VO.CadastroConsultaVO vo;
        private DAO.CadastroConsultaDAO dao;

        public CadastroConsultaBE(VO.CadastroConsultaVO vo)
        {
            this.vo = vo;
        }
        public void incluir()
        {
            if (string.IsNullOrEmpty(this.vo.email))
            {
                throw new Exception("Email obrigatório!");
            }

            dao = new DAO.CadastroConsultaDAO(this.vo);
            dao.incluir();
        }
        public void alterar()
        {
            dao = new DAO.CadastroConsultaDAO(this.vo);
            dao.alterar();
        }
        public VO.CadastroConsultaVO carregar()
        {
            dao = new DAO.CadastroConsultaDAO(this.vo);
            return dao.carregar();
        }
        public void remover()
        {
            dao = new DAO.CadastroConsultaDAO(this.vo);
            dao.remover();
        }
        public List<VO.CadastroConsultaVO> listar()
        {
            dao = new DAO.CadastroConsultaDAO(this.vo);
            return dao.listar();
        }
    }
}
