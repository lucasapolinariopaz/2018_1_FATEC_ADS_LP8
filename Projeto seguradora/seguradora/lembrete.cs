using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace seguradora
{
    public partial class lembrete : Form
    {
        int pk_regi_corretor, cod;
        int contarcamposmudados = 0;

        public lembrete()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (contarcamposmudados == 0)
            {
                MessageBox.Show("Nenhum campo alterado");
            }
            else
            {
                if(txtsenhac.Text==txtsenha.Text) { 
                string sql = "UPDATE corretor SET senha = @senha WHERE cod_corretor = @cod_corretor";
                SqlConnection conn = Conexao.obterConexao();
                SqlCommand comm = new SqlCommand(sql, conn);
               
                comm.Parameters.Add(new SqlParameter("@senha", txtsenha.Text));
                comm.Parameters.Add(new SqlParameter("@cod_corretor", (cod)));
                comm.CommandType = CommandType.Text;
                Conexao.obterConexao();
                try
                {
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    Conexao.fecharConexao();
                }
                }
                else
                {
                    MessageBox.Show("As senhas não são parecidas");
                }
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void txtsenhac_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("SELECT cor.nome, cor.endereco, " +
                "cor.telefone, cor.regi_corretor,cor.senha,cor.cod_corretor, emp.cod_empresa  FROM " +
                "corretor cor INNER JOIN empresa emp ON cor.cod_empresa = emp.cod_empresa WHERE " +
                "cor.regi_corretor = '" + textpesquisa.Text + "';", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@corretor", "corretor"));
            comm.Parameters.Add(new SqlParameter("@endereco", "endereco"));
            comm.Parameters.Add(new SqlParameter("@telefone", "telefone"));
            comm.Parameters.Add(new SqlParameter("@registro", "regi_corretor"));
            comm.Parameters.Add(new SqlParameter("@senha", "senha"));
            comm.Parameters.Add(new SqlParameter("@cod_empresa", "cod_empresa"));
            comm.Parameters.Add(new SqlParameter("@cod_corretor", "cod_corretor"));

            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            // while (dr.Read())
            try
            {
                if (dr.Read())
                {
                    txtcorretor.Text = dr["nome"].ToString();
                    //txtsenha.Text = dr["senha"].ToString();
                    pk_regi_corretor = int.Parse(dr["cod_empresa"].ToString());
                    cod = int.Parse(dr["cod_corretor"].ToString());
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o Registro de Habilitação informado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
    }
}
