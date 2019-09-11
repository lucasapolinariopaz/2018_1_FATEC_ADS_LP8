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
    public partial class ConsultaCorretor : Form
    {
        int pk_regi_corretor,cod;
        int contarcamposmudados = 0;
        public ConsultaCorretor()
        {
            InitializeComponent();
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
                txtendereco.Text = dr["endereco"].ToString();
                txttelefone.Text = dr["telefone"].ToString();
                lblempresa.Text = dr["cod_empresa"].ToString();
                txtregistro.Text = dr["regi_corretor"].ToString();
                txtsenha.Text = dr["senha"].ToString();
                pk_regi_corretor = int.Parse(dr["cod_empresa"].ToString());
                cod = int.Parse(dr["cod_corretor"].ToString());
            }
            else {
                MessageBox.Show("Nenhum registro encontrado com o Registro de Habilitação informado!");
            } }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fecharConexao();
            }
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcorretor_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void txtregistro_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            contarcamposmudados++;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM corretor WHERE cod_corretor=@Id";
            SqlConnection con = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", cod);
            cmd.CommandType = CommandType.Text;
            Conexao.obterConexao();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fecharConexao();
            }
            txtcorretor.Clear();
            txtendereco.Clear();
            txttelefone.Clear();
            txtregistro.Clear();
            txtsenha.Clear();
            textpesquisa.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcorretor.Clear();
            txttelefone.Clear();
            txtregistro.Clear();
            txtsenha.Clear();
            txtendereco.Clear();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (contarcamposmudados == 0)
            {
                MessageBox.Show("Nenhum campo alterado");
            }
            else
            {
                string sql = "UPDATE corretor SET nome = @nome, endereco = @endereco, " +
                 "telefone = @telefone, cod_empresa = @cod_empresa, regi_corretor = @regi_corretor, " +
                 "senha = @senha WHERE cod_corretor = @cod_corretor";
                SqlConnection conn = Conexao.obterConexao();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.Add(new SqlParameter("@nome", txtcorretor.Text));
                comm.Parameters.Add(new SqlParameter("@endereco", txtendereco.Text));
                comm.Parameters.Add(new SqlParameter("@telefone", txttelefone.Text));
                comm.Parameters.Add(new SqlParameter("@regi_corretor", txtregistro.Text));
                comm.Parameters.Add(new SqlParameter("@senha", txtsenha.Text));
                comm.Parameters.Add(new SqlParameter("@cod_empresa", pk_regi_corretor));
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
        }
    }
}
