using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using hmmassoterapia.DAO.DataAcess;

namespace hmmassoterapia.DAO
{
    public class ProcedimentoDAO : BaseDAO
    {
        private VO.ProcedimentoVO vo;
        public ProcedimentoDAO(VO.ProcedimentoVO vo)
        {

            if (DAO.listaprocedimento == null)
            {
                DAO.listaprocedimento = new List<VO.ProcedimentoVO>();
            }
            this.vo = vo;
        }

        public void incluir()
        {
            try
            {
                string sql = "insert into procedimento (PROCEDIMENTO) " +
                    "values (@procedimento)";
                db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
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
                string sql = "update procedimento set " +
                    "PROCEDIMENTO = @procedimento," +
                    "where PROCEDIMENTO = @procedimento";
                db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
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
                string sql = $"delete from procedimento where procedimento = @procedimento";
                db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public VO.ProcedimentoVO carregar()
        {
            string sql = $"SELECT procedimento from procedimento where procedimento=@procedimento";
            db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
            try
            {
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        vo = LoadProcedimento(dr);
                    }
                    return vo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        private VO.ProcedimentoVO LoadProcedimento(DbDataReader dr)
        {
            vo = new VO.ProcedimentoVO();
            vo.procedimento = dr["procedimento"] != DBNull.Value ? dr["procedimento"].ToString() : "";
            return vo;
        }

        public List<VO.ProcedimentoVO> listar()
        {
            try
            {
                string sql = "SELECT * FROM procedimento;";
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    var objResultado = new List<VO.ProcedimentoVO>();

                    while (dr.Read())
                    {
                        vo = LoadProcedimento(dr);
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
