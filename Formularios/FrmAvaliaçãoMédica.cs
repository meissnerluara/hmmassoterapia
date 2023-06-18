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
    public partial class FrmAvaliaçãoMédica : Form
    {
        private VO.AvaliacaoMedicaVO vo;
        private BE.AvaliacaoMedicaBE be;

        public FrmAvaliaçãoMédica()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            vo = new VO.AvaliacaoMedicaVO();
        }

        private void InteractToObject()
        {
            if (!string.IsNullOrEmpty(txtemail.Text))
            {
                vo.email = Convert.ToString(txtemail.Text);
            }
            vo.descricao = txtdescricao.Text;
        }

        private void objecttoInterface()
        {
            txtemail.Text = vo.email.ToString();
            txtdescricao.Text = vo.descricao.ToString();
        }

        private void limpar()
        {
            txtemail.Text = "";
            txtdescricao.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=hmmassoterapia");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("insert into avaliacaomedica(email,descricao) values(" +
                "'" + txtemail.Text + "','"
                + txtdescricao.Text + "')", conexao);

            comando.ExecuteReader();
            MessageBox.Show("CADASTRO REALIZADO COM SUCESSSO!");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            hmmassoterapia.FrmCadastroConsulta tela = new hmmassoterapia.FrmCadastroConsulta();
            tela.Show();
        }
    }
}
