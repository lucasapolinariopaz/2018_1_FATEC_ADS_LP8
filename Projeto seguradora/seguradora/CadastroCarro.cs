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
	public partial class CadastroCarro : Form
	{
		public CadastroCarro()
		{
			InitializeComponent();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_consultaCliente_Click(object sender, EventArgs e)
		{
			//SqlConnection conn = new SqlConnection(strconn);
			String sql = "SELECT * FROM cliente WHERE cpf = @cpf";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);
			
			cmd.Parameters.Add(new SqlParameter("@cpf", txt_consultarCliente.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				txt_nomeCliente.Text = dr["nome_cli"].ToString();
				txt_cpfCliente.Text = dr["cpf"].ToString();
				txt_nascCliente.Text = dr["data_nasc"].ToString();
				txt_telefoneCliente.Text = dr["telefone_cli"].ToString();
				txt_enderecoCliente.Text = dr["endereco_cli"].ToString();
				txt_codCliente.Text = dr["cod_cli"].ToString();
			}

			conn.Close();
			txt_marcaCarro.Enabled = true;
			txt_modeloCarro.Enabled = true;
			txt_anoFabCarro.Enabled = true;
			txt_anoModCarro.Enabled = true;
			txt_placaCarro.Enabled = true;
			txt_corCarro.Enabled = true;
			txt_chassiCarro.Enabled = true;
			btn_Salvar.Enabled = true;
		}

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			txt_nomeCliente.Text = "";
			txt_codCliente.Text = "";
			txt_cpfCliente.Text = "";
			txt_nascCliente.Text = "";
			txt_telefoneCliente.Text = "";
			txt_enderecoCliente.Text = "";
			txt_marcaCarro.Text = "";
			txt_modeloCarro.Text = "";
			txt_anoFabCarro.Text = "";
			txt_anoModCarro.Text = "";
			txt_placaCarro.Text = "";
			txt_corCarro.Text = "";
			txt_chassiCarro.Text = "";
		}

		private void btn_Salvar_Click(object sender, EventArgs e)
		{
			string sql = "INSERT INTO carro (chassi, modelo, marca, cor, ano_fabricao, ano_modelo, placa, cod_cli) " +
				"VALUES (@chassi, @modelo, @marca, @cor, @ano_fabricao, @ano_modelo, @placa, @cod_cli)";

			// SqlConnection con = new SqlConnection(strconn);
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@chassi", txt_chassiCarro.Text));
			cmd.Parameters.Add(new SqlParameter("@modelo", txt_modeloCarro.Text));
			cmd.Parameters.Add(new SqlParameter("@marca", txt_marcaCarro.Text));
			cmd.Parameters.Add(new SqlParameter("@cor", txt_corCarro.Text));
			cmd.Parameters.Add(new SqlParameter("@ano_fabricao", int.Parse(txt_anoFabCarro.Text)));
			cmd.Parameters.Add(new SqlParameter("@ano_modelo", int.Parse(txt_anoModCarro.Text)));
			cmd.Parameters.Add(new SqlParameter("@placa", txt_placaCarro.Text));
			cmd.Parameters.Add(new SqlParameter("@cod_cli", int.Parse(txt_codCliente.Text)));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();

			try
			{
				int i = cmd.ExecuteNonQuery();
				if (i > 0)
					MessageBox.Show("Cadastro realizado com sucesso!");
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
