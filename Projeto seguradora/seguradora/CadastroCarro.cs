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
		int fk_carro_cliente;

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
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand comm = new SqlCommand("SELECT * FROM cliente WHERE nome = '" +
				txt_nomeCliente.Text + "';", conn);
			comm.CommandType = CommandType.Text;
			comm.Parameters.Add(new SqlParameter("@data_nasc", "data_nasc"));
			comm.Parameters.Add(new SqlParameter("@telefone", "telefone"));
			comm.Parameters.Add(new SqlParameter("@endereco", "endereco"));
			comm.Parameters.Add(new SqlParameter("@cod_cli", "cod_cli"));

			Conexao.obterConexao();
			DbDataReader dr = comm.ExecuteReader();
			while (dr.Read())
			{
				txt_nascCliente.Text = dr["data_nasc"].ToString();
				txt_telefoneCliente.Text = dr["telefone"].ToString();
				txt_enderecoCliente.Text = dr["endereco"].ToString();
				fk_carro_cliente = int.Parse(dr["cod_cli"].ToString());
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
			string sql = "INSERT INTO carro (chassi, modelo, marca, cor, ano_fabricao," +
				" ano_modelo, placa, cod_cli)" + " VALUES ('" +
				txt_chassiCarro.Text + "', '" + txt_modeloCarro.Text + "', '" +
				txt_marcaCarro.Text + "', '" + txt_corCarro + "', " +
				int.Parse(txt_anoFabCarro.Text) + ", " + int.Parse(txt_anoModCarro.Text) +
				", '" + txt_placaCarro.Text + "', " + fk_carro_cliente + ")";

			// SqlConnection con = new SqlConnection(strconn);
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);
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
