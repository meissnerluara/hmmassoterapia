using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using hmmassoterapia.DAO.DataAcess;

namespace hmmassoterapia.DAO
{
    public class AvaliacaoMedicaDAO : BaseDAO
    {
        private VO.AvaliacaoMedicaVO vo;
        public AvaliacaoMedicaDAO(VO.AvaliacaoMedicaVO vo)
        {

            if (DAO.listaavaliacaomedica == null)
            {
                DAO.listaavaliacaomedica = new List<VO.AvaliacaoMedicaVO>();
            }
            this.vo = vo;
        }

        public void incluir()
        {
            try
            {
                string sql = "insert into avaliacaomedica (EMAIL,DESCRICAO) " +
                    "values (@email)" +
                    "values (@descricao)";
                db.AddParameter("@descricao", vo.descricao, ParameterDirection.Input);
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
        public void alterar()
        {
            try
            {
                string sql = "update avaliacaomedica set " +
                    "EMAIL = @email," +
                    "DESCRICAO = @descricao," +
                    "where EMAIL = @email";
                db.AddParameter("@descricao", vo.descricao, ParameterDirection.Input);
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
        public void remover()
        {
            try
            {
                string sql = $"delete from avaliacaomedica where email = @email";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public VO.AvaliacaoMedicaVO carregar()
        {
            string sql = $"SELECT descricao,email from avaliacaomedica where email=@email";
            db.AddParameter("@descricao", vo.descricao, ParameterDirection.Input);
            db.AddParameter("@email", vo.email, ParameterDirection.Input);
            try
            {
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        vo = LoadAvaliacaoMedica(dr);
                    }
                    return vo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        private VO.AvaliacaoMedicaVO LoadAvaliacaoMedica(DbDataReader dr)
        {
            vo = new VO.AvaliacaoMedicaVO();
            vo.descricao = dr["descricao"] != DBNull.Value ? dr["descricao"].ToString() : "";
            return vo;
        }

        public List<VO.AvaliacaoMedicaVO> listar()
        {
            try
            {
                string sql = "SELECT * FROM avaliacaomedica;";
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    var objResultado = new List<VO.AvaliacaoMedicaVO>();

                    while (dr.Read())
                    {
                        vo = LoadAvaliacaoMedica(dr);
                        objResultado.Add(vo);
                    }
                    return objResultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }
    }
}
