using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmmassoterapia.BE
{
    public class CadastroClienteBE : BaseBE
    {
        private VO.CadastroClienteVO vo;
        private DAO.CadastroClienteDAO dao;

        public CadastroClienteBE(VO.CadastroClienteVO vo)
        {
            this.vo = vo;
        }
        public void incluir()
        {
            if (string.IsNullOrEmpty(this.vo.email))
            {
                throw new Exception("Email obrigatório!");
            }

            dao = new DAO.CadastroClienteDAO(this.vo);
            dao.incluir();
        }
        public void alterar()
        {
            dao = new DAO.CadastroClienteDAO(this.vo);
            dao.alterar();
        }
        public VO.CadastroClienteVO carregar()
        {
            dao = new DAO.CadastroClienteDAO(this.vo);
            return dao.carregar();
        }
        public void remover()
        {
            dao = new DAO.CadastroClienteDAO(this.vo);
            dao.remover();
        }
        public List<VO.CadastroClienteVO> listar()
        {
            dao = new DAO.CadastroClienteDAO(this.vo);
            return dao.listar();
        }
    }
}
