using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using hmmassoterapia.DAO.DataAcess;

namespace hmmassoterapia.DAO
{
    public class CadastroConsultaDAO : BaseDAO
    {
        private VO.CadastroConsultaVO vo;
        public CadastroConsultaDAO(VO.CadastroConsultaVO vo)
        {

            if (DAO.listacadastroconsulta == null)
            {
                DAO.listacadastroconsulta = new List<VO.CadastroConsultaVO>();
            }
            this.vo = vo;
        }

        public void incluir()
        {
            try
            {
                string sql = "insert into cadastroconsulta (EMAIL,DATACONSULTA,QNTSESSOES,PROCEDIMENTO,PAGAMENTO) " +
                    "values (@email,@dataconsulta,@qntsessoes,@procedimento,@pagamento)";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.AddParameter("@dataconsulta", vo.dataconsulta, ParameterDirection.Input);
                db.AddParameter("@qntsessoes", vo.qntsessoes, ParameterDirection.Input);
                db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
                db.AddParameter("@pagamento", vo.pagamento, ParameterDirection.Input);
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
                string sql = "update cadastroconsulta set " +
                    "EMAIL = @email," +
                    "DATACONSULTA = @dataconsulta," +
                    "QNTSESSOES = @qntsessoes," +
                    "PROCEDIMENTO = @procedimento," +
                    "PAGAMENTO = @pagamento," +
                    "where EMAIL = @email";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.AddParameter("@dataconsulta", vo.dataconsulta, ParameterDirection.Input);
                db.AddParameter("@qntsessoes", vo.qntsessoes, ParameterDirection.Input);
                db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
                db.AddParameter("@pagamento", vo.pagamento, ParameterDirection.Input);
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
                string sql = $"delete from cadastroconsulta where email = @email";
                db.AddParameter("@email", vo.procedimento, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public VO.CadastroConsultaVO carregar()
        {
            string sql = $"SELECT email,dataconsulta,qntsessoes,procedimento,pagamento from cadastroconsulta where email=@email";
            db.AddParameter("@email", vo.email, ParameterDirection.Input);
            db.AddParameter("@dataconsulta", vo.dataconsulta, ParameterDirection.Input);
            db.AddParameter("@qntsessoes", vo.qntsessoes, ParameterDirection.Input);
            db.AddParameter("@procedimento", vo.procedimento, ParameterDirection.Input);
            db.AddParameter("@pagamento", vo.pagamento, ParameterDirection.Input);
            try
            {
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        vo = LoadCadastroConsulta(dr);
                    }
                    return vo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        private VO.CadastroConsultaVO LoadCadastroConsulta(DbDataReader dr)
        {
            vo = new VO.CadastroConsultaVO();
            vo.email = dr["email"] != DBNull.Value ? dr["procedimento"].ToString() : "";
            vo.dataconsulta = Convert.ToDateTime(dr["dataconsulta"]);
            vo.qntsessoes = Convert.ToInt32(dr["qntsessoes"]);
            vo.procedimento = new VO.ProcedimentoVO();
            vo.procedimento.procedimento = dr["procedimento"] != DBNull.Value ? dr["procedimento"].ToString() : "";
            vo.pagamento = new VO.PagamentoVO();
            vo.pagamento.pagamento = dr["pagamento"] != DBNull.Value ? dr["pagamento"].ToString() : "";
            return vo;
        }

        public List<VO.CadastroConsultaVO> listar()
        {
            try
            {
                string sql = "SELECT * FROM cadastroconsulta;";
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    var objResultado = new List<VO.CadastroConsultaVO>();

                    while (dr.Read())
                    {
                        vo = LoadCadastroConsulta(dr);
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
