using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hmmassoterapia
{
    public partial class FrmCadastroConsulta : Form
    {
        private VO.CadastroConsultaVO vo;
        private BE.CadastroConsultaBE be;

        public FrmCadastroConsulta()
        {
            InitializeComponent();
            Inicializar();
            carregarProcedimento();
            carregarPagamento();
        }

        private void carregarProcedimento()
        {
            BE.ProcedimentoBE vo = new BE.ProcedimentoBE(new VO.ProcedimentoVO());
            cmbProcedimento.DataSource = null;
            cmbProcedimento.DataSource = vo.listar();
            cmbProcedimento.ValueMember = "procedimento";
            cmbProcedimento.DisplayMember = "procedimento";
            cmbProcedimento.Refresh();
        }

        private void carregarPagamento()
        {
            BE.PagamentoBE vo = new BE.PagamentoBE(new VO.PagamentoVO());
            cmbPagamento.DataSource = null;
            cmbPagamento.DataSource = vo.listar();
            cmbPagamento.ValueMember = "pagamento";
            cmbPagamento.DisplayMember = "pagamento";
            cmbPagamento.Refresh();
        }

        private void Inicializar()
        {
            vo = new VO.CadastroConsultaVO();
        }

        private void InteractToObject()
        {
            if (!string.IsNullOrEmpty(txtemail.Text))
            {
                vo.email = Convert.ToString(txtemail.Text);
            }
            vo.dataconsulta = DateTime.Parse(txtdtconsulta.Text);
            vo.procedimento = (VO.ProcedimentoVO)cmbProcedimento.SelectedItem;
            vo.qntsessoes = int.Parse(txtquantidade.Text);
            vo.pagamento = (VO.PagamentoVO)cmbPagamento.SelectedItem;
        }

        private void objecttoInterface()
        {
            txtemail.Text = vo.email.ToString();
            txtdtconsulta.Text = vo.dataconsulta.ToString();
            txtquantidade.Text = vo.qntsessoes.ToString();
            int index = 0;
            foreach (VO.ProcedimentoVO item in cmbProcedimento.Items)
            {
                if (item.procedimento.Equals(vo.procedimento.procedimento))
                {
                    cmbProcedimento.SelectedIndex = index;
                    return;
                }
                index++;
            }
            foreach (VO.PagamentoVO item in cmbPagamento.Items)
            {
                if (item.pagamento.Equals(vo.pagamento.pagamento))
                {
                    cmbProcedimento.SelectedIndex = index;
                    return;
                }
                index++;
            }
        }

        private void limpar()
        {
            txtemail.Text = "";
            txtdtconsulta.Text = "";
            txtquantidade.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=hmmassoterapia");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand("insert into cadastroconsulta(email,dataconsulta,qntsessoes,procedimento,pagamento) values(" +
                "'" + txtemail.Text + "','"
                + txtdtconsulta.Text + "','"
                + txtquantidade.Text + "','"
                + cmbProcedimento.Text + "','"
                + cmbPagamento.Text + "')", conexao);

            comando.ExecuteReader();

            if (MessageBox.Show("Deseja cadastrar avaliação médica?", "CADASTRO REALIZADO COM SUCESSSO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hmmassoterapia.FrmAvaliaçãoMédica tela = new hmmassoterapia.FrmAvaliaçãoMédica();
                tela.Show();
            }
            else
            {
                MessageBox.Show("CADASTRO DA CONSULTA REALIZADO COM SUCESSSO!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            hmmassoterapia.FrmLogin tela = new hmmassoterapia.FrmLogin();
            tela.Show();
        }
    }
}
