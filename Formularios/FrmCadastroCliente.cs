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
    public partial class FrmCadastroCliente : Form
    {
        private VO.CadastroClienteVO vo;
        private BE.CadastroClienteBE be;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            vo = new VO.CadastroClienteVO();
        }

        private void InteractToObject()
        {
            if (!string.IsNullOrEmpty(txtemail.Text))
            {
                vo.email = Convert.ToString(txtemail.Text);
            }
            vo.nome = txtnome.Text;
            vo.sexo = txtsexo.Text;
            vo.endereco = txtendereco.Text;
            vo.telefone = int.Parse(txttelefone.Text);
            vo.senha = int.Parse(txtsenha.Text);
        }

        private void objecttoInterface()
        {
            txtemail.Text = vo.email.ToString();
            txtnome.Text = vo.nome.ToString();
            txtsexo.Text = vo.sexo.ToString();
            txtendereco.Text = vo.endereco.ToString();
            txttelefone.Text = vo.telefone.ToString();
            txtsenha.Text = vo.senha.ToString();
        }

        private void limpar()
        {
            txtemail.Text = "";
            txtnome.Text = "";
            txtsexo.Text = "";
            txtendereco.Text = "";
            txttelefone.Text = "";
            txtsenha.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string conectar = "server=localhost;uid=root;pwd='';database=hmmassoterapia";
            MySqlConnection conexao = new MySqlConnection(conectar);

            MySqlCommand comando = new MySqlCommand("Insert Into cadastrocliente(email,nome,sexo,endereco,telefone,senha)values(" +
                "'" + txtemail.Text + "','"
                + txtnome.Text + "','"
                + txtsexo.Text + "','"
                + txtendereco.Text + "','"
                + txttelefone.Text + "','"
                + txtsenha.Text + "')", conexao);

            conexao.Open();
            comando.ExecuteReader();
            MessageBox.Show("CADASTRO DO CLIENTE REALIZADO COM SUCESSSO! Redirecionando ao cadastro da consulta.");
            hmmassoterapia.FrmCadastroConsulta tela = new hmmassoterapia.FrmCadastroConsulta();
            tela.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            hmmassoterapia.FrmLogin tela = new hmmassoterapia.FrmLogin();
            tela.Show();
        }
    }
}
