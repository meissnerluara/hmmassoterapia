using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmmassoterapia.BE 
{
    public class AvaliacaoMedicaBE : BaseBE
    {
        private VO.AvaliacaoMedicaVO vo;
        private DAO.AvaliacaoMedicaDAO dao;

        public AvaliacaoMedicaBE(VO.AvaliacaoMedicaVO vo)
        {
            this.vo = vo;
        }
        public void incluir()
        {
            if (string.IsNullOrEmpty(this.vo.email))
            {
                throw new Exception("Email obrigatório!");
            }

            dao = new DAO.AvaliacaoMedicaDAO(this.vo);
            dao.incluir();
        }
        public void alterar()
        {
            dao = new DAO.AvaliacaoMedicaDAO(this.vo);
            dao.alterar();
        }
        public VO.AvaliacaoMedicaVO carregar()
        {
            dao = new DAO.AvaliacaoMedicaDAO(this.vo);
            return dao.carregar();
        }
        public void remover()
        {
            dao = new DAO.AvaliacaoMedicaDAO(this.vo);
            dao.remover();
        }
        public List<VO.AvaliacaoMedicaVO> listar()
        {
            dao = new DAO.AvaliacaoMedicaDAO(this.vo);
            return dao.listar();
        }
    }
}
