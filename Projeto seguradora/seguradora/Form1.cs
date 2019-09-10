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
            // String strConexao = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\cesar\\Desktop\\seguradora\\seguradora.mdf;Integrated Security=True;User Instance=True";
            // conexao conexao = new conexao(strConexao);
            string StringDeConexao = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\cesar\\Desktop\\seguradora\\seguradora.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                try
                {

            SqlCommand cmd = new SqlCommand("Select regi_corretor,senha from corretor where regi_corretor='" + txtnomeacesso.Text + "'and senha='"+txtkey.Text + "';", cn);
                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                 cn.Close(); }
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
            Acidente novo = new Acidente();
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
    }
    }

