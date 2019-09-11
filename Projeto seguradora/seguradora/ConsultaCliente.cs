using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace seguradora
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			txt_codCliente.Clear();
			txt_nomeCliente.Clear();
			txt_Cpf.Clear();
			txt_nascCliente.Clear();
			txt_enderecoCliente.Clear();
			txt_telefoneCliente.Clear();
		}

		private void btn_ConsultarCliente_Click(object sender, EventArgs e)
		{
			String sql = "SELECT * FROM cliente WHERE cpf = @cpf";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);
			
			cmd.Parameters.Add(new SqlParameter("@cpf", txt_consultaCpf.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					txt_codCliente.Text = dr["cod_cli"].ToString();
					txt_nomeCliente.Text = dr["nome_cli"].ToString();
					txt_Cpf.Text = dr["cpf"].ToString();
					txt_nascCliente.Text = dr["data_nasc"].ToString();
					txt_enderecoCliente.Text = dr["endereco_cli"].ToString();
					txt_telefoneCliente.Text = dr["telefone_cli"].ToString();
				}
				else
				{
					MessageBox.Show("Nenhum registro encontrado com o CPF informado!");
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

		private void btn_Alterar_Click(object sender, EventArgs e)
		{
			string sql = "UPDATE cliente SET nome_cli = @nome, cpf = @cpf, data_nasc = @data_nasc, telefone_cli = @telefone, " +
                "endereco_cli = @endereco WHERE cod_cli = @cod_cli";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@nome", txt_nomeCliente.Text));
			cmd.Parameters.Add(new SqlParameter("@cpf", txt_Cpf.Text));
			cmd.Parameters.Add(new SqlParameter("@data_nasc", txt_nascCliente.Text));
			cmd.Parameters.Add(new SqlParameter("@telefone", txt_telefoneCliente.Text));
			cmd.Parameters.Add(new SqlParameter("@endereco", txt_enderecoCliente.Text));
			cmd.Parameters.Add(new SqlParameter("@cod_cli", int.Parse(txt_codCliente.Text)));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			try
			{
				int i = cmd.ExecuteNonQuery();
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

		private void btn_Excluir_Click(object sender, EventArgs e)
		{
			string sql = "DELETE FROM cliente WHERE cod_cli = @cod_cli";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@cod_cli", int.Parse(txt_codCliente.Text)));

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
		}
	}
}
