using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using hmmassoterapia.DAO.DataAcess;

namespace hmmassoterapia.DAO
{
    public class PagamentoDAO : BaseDAO
    {
        private VO.PagamentoVO vo;
        public PagamentoDAO(VO.PagamentoVO vo)
        {

            if (DAO.listapagamento == null)
            {
                DAO.listapagamento = new List<VO.PagamentoVO>();
            }
            this.vo = vo;
        }

        public void incluir()
        {
            try
            {
                string sql = "insert into pagamento (PAGAMENTO) " +
                    "values (@pagamento)";
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
                string sql = "update pagamento set " +
                    "PAGAMENTO = @pagamento," +
                    "where PAGAMENTO = @pagamento";
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
                string sql = $"delete from pagamento where pagamento = @pagamento";
                db.AddParameter("@pagamento", vo.pagamento, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public VO.PagamentoVO carregar()
        {
            string sql = $"SELECT pagamento from pagamento where pagamento=@pagamento";
            db.AddParameter("@pagamento", vo.pagamento, ParameterDirection.Input);
            try
            {
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        vo = LoadPagamento(dr);
                    }
                    return vo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        private VO.PagamentoVO LoadPagamento(DbDataReader dr)
        {
            vo = new VO.PagamentoVO();
            vo.pagamento = dr["pagamento"] != DBNull.Value ? dr["pagamento"].ToString() : "";
            return vo;
        }

        public List<VO.PagamentoVO> listar()
        {
            try
            {
                string sql = "SELECT * FROM pagamento;";
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    var objResultado = new List<VO.PagamentoVO>();

                    while (dr.Read())
                    {
                        vo = LoadPagamento(dr);
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
