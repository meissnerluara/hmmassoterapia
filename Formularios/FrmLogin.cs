using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hmmassoterapia
{
    public partial class FrmLogin : Form
    {
        private VO.LoginVO vo;

        public FrmLogin()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            vo = new VO.LoginVO();
        }

        private void InteractToObject()
        {
            if (!string.IsNullOrEmpty(txtemail.Text))
            {
                vo.email = Convert.ToString(txtemail.Text);
            }
            vo.senha = int.Parse(txtsenha.Text);
        }

        private void objecttoInterface()
        {
            txtemail.Text = vo.email.ToString();
            txtsenha.Text = vo.senha.ToString();
        }

        private void limpar()
        {
            txtemail.Text = "";
            txtsenha.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=hmmassoterapia");
            conexao.Open();

            string sql = "select email, senha from cadastrocliente where email = ? and senha = ?";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@senha", txtsenha.Text);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtemail.Text = dr[0].ToString();
                txtsenha.Text = dr[1].ToString();
                MessageBox.Show("LOGIN EFETUADO COM SUCESSO! Redirecionando ao cadastro da consulta.");
                hmmassoterapia.FrmCadastroConsulta tela = new hmmassoterapia.FrmCadastroConsulta();
                tela.Show();
            }
            else if (dr.Read())
            {
                txtemail.Text = dr[0].ToString();
                MessageBox.Show("SENHA INCORRETA! Tente novamente.");
            }
            else if (dr.Read())
            {
                txtsenha.Text = dr[0].ToString();
                MessageBox.Show("EMAIL INCORRETO! Tente novamente.");
            }
            else
            {
                MessageBox.Show("VOCÊ NÃO POSSUI CADASTRO! Redirecionando ao cadastro do cliente.");
                hmmassoterapia.FrmCadastroCliente tela = new hmmassoterapia.FrmCadastroCliente();
                tela.Show();
            }
        }

        private void bntfrmcadastrocliente_Click(object sender, EventArgs e)
        {
            hmmassoterapia.FrmCadastroCliente tela = new hmmassoterapia.FrmCadastroCliente();
            tela.Show();
        }
    }
}
