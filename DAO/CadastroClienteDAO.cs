using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using hmmassoterapia.DAO.DataAcess;

namespace hmmassoterapia.DAO
{
    public class CadastroClienteDAO : BaseDAO
    {
        private VO.CadastroClienteVO vo;
        public CadastroClienteDAO(VO.CadastroClienteVO vo)
        {

            if (DAO.listacadastrocliente == null)
            {
                DAO.listacadastrocliente = new List<VO.CadastroClienteVO>();
            }
            this.vo = vo;
        }

        public void incluir()
        {
            try
            {
                string sql = "insert into cadastrocliente (EMAIL,NOME,SEXO,ENDERECO,TELEFONE,SENHA) " +
                    "values (@email,@nome,@sexo,@endereco,@telefone,@senha)";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.AddParameter("@nome", vo.nome, ParameterDirection.Input);
                db.AddParameter("@sexo", vo.sexo, ParameterDirection.Input);
                db.AddParameter("@endereco", vo.endereco, ParameterDirection.Input);
                db.AddParameter("@telefone", vo.telefone, ParameterDirection.Input);
                db.AddParameter("@senha", vo.senha, ParameterDirection.Input);
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
                string sql = "update cadastrocliente set " +
                    "EMAIL = @email," +
                    "NOME = @nome," +
                    "SEXO = @sexo," +
                    "ENDERECO = @endereco," +
                    "TELEFONE = @telefone," +
                    "SENHA = @senha," +
                    "where EMAIL = @email";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.AddParameter("@nome", vo.nome, ParameterDirection.Input);
                db.AddParameter("@sexo", vo.sexo, ParameterDirection.Input);
                db.AddParameter("@endereco", vo.endereco, ParameterDirection.Input);
                db.AddParameter("@telefone", vo.telefone, ParameterDirection.Input);
                db.AddParameter("@senha", vo.senha, ParameterDirection.Input);
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
                string sql = $"delete from cadastrocliente where email = @email";
                db.AddParameter("@email", vo.email, ParameterDirection.Input);
                db.Execute(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        public VO.CadastroClienteVO carregar()
        {
            string sql = $"SELECT email,dataconsulta,qntsessoes,procedimento,pagamento from cadastrocliente where email=@email";
            db.AddParameter("@email", vo.email, ParameterDirection.Input);
            db.AddParameter("@nome", vo.nome, ParameterDirection.Input);
            db.AddParameter("@sexo", vo.sexo, ParameterDirection.Input);
            db.AddParameter("@endereco", vo.endereco, ParameterDirection.Input);
            db.AddParameter("@telefone", vo.telefone, ParameterDirection.Input);
            db.AddParameter("@senha", vo.senha, ParameterDirection.Input);
            try
            {
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    while (dr.Read())
                    {
                        vo = LoadCadastroCliente(dr);
                    }
                    return vo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Código : " + ex.Message);
            }
        }

        private VO.CadastroClienteVO LoadCadastroCliente(DbDataReader dr)
        {
            vo = new VO.CadastroClienteVO();
            vo.email = dr["email"] != DBNull.Value ? dr["procedimento"].ToString() : "";
            vo.nome = dr["nome"] != DBNull.Value ? dr["nome"].ToString() : "";
            vo.sexo = dr["sexo"] != DBNull.Value ? dr["sexo"].ToString() : "";
            vo.endereco = dr["endereco"] != DBNull.Value ? dr["endereco"].ToString() : "";
            vo.telefone = Convert.ToInt32(dr["qntsessoes"]);
            vo.senha = Convert.ToInt32(dr["qntsessoes"]);
            return vo;
        }

        public List<VO.CadastroClienteVO> listar()
        {
            try
            {
                string sql = "SELECT * FROM cadastrocliente;";
                using (var dr = db.ExecuteReader(sql, CommandType.Text))
                {
                    var objResultado = new List<VO.CadastroClienteVO>();

                    while (dr.Read())
                    {
                        vo = LoadCadastroCliente(dr);
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
