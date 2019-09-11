using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace seguradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool VerificaLogin()
        {
           
            bool result = false;
   
           // string StringDeConexao = "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\seguradora\\seguradora.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection cn = Conexao.obterConexao())
            {
               // cn.ConnectionString = StringDeConexao;
                try
                {

            SqlCommand cmd = new SqlCommand("Select regi_corretor,senha from corretor where regi_corretor='" + txtnomeacesso.Text + "'and senha='"+txtkey.Text + "';", cn);
                    Conexao.obterConexao();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                Conexao.fecharConexao();
            }
                return result;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           bool Logado = false;
           bool result = VerificaLogin();

            Logado = result;

            if (result)
            {

                MessageBox.Show("Seja bem vindo!");
                eMPRESAToolStripMenuItem.Enabled = true;
                ACIDENTESToolStripMenuItem.Enabled = true;
                cLIENTESToolStripMenuItem.Enabled = true;
                vEÍCULOSToolStripMenuItem.Enabled = true;
                aRQUIVOToolStripMenuItem.Enabled = true;
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkey.Clear();
            txtnomeacesso.Clear();

        }

        private void cADASTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrodeAcidente novo = new CadastrodeAcidente();
            novo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Consulta_Acidente  novo = new Consulta_Acidente();
            novo.Show();
        }

		private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CadastroCarro novo = new CadastroCarro();
			novo.Show();
		}

		private void cONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConsultaCarro novo = new ConsultaCarro();
			novo.Show();
		}

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_cliente novo = new Cadastro_de_cliente();
            novo.Show();
        }

        private void sAIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Deseja sair?", "Fechar Sistema", MessageBoxButtons.YesNo);
            if (dialog_result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cADASTROCORRETORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCorretor novo = new CadastroCorretor();
            novo.Show();
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa novo = new Empresa();
            novo.Show();
        }

        private void cONSULTACORRETORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCorretor novo = new ConsultaCorretor();
            novo.Show();
        }

      

        private void cONSULTARAPIDAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaRapida novo = new ConsultaRapida();
            novo.Show();
        }
    }
    }
  
