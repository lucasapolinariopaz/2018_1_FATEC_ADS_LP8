﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace seguradora
{
	public partial class CadastroApolice : Form
	{
		public CadastroApolice()
		{
			InitializeComponent();
		}

		public void limparTodosCampos()
		{
			txt_CorretorCod.Clear();
			txt_CorretorNome.Clear();
			txt_EmpresaCod.Clear();
			txt_CorretorRegistro.Clear();
			txt_CorretorEndereco.Clear();
			txt_CorretorTelefone.Clear();

			txt_ClienteCod.Clear();
			txt_ClienteNome.Clear();
			txt_ClienteCpf.Clear();
			txt_ClienteDataNasc.Clear();
			txt_ClienteEndereco.Clear();
			txt_ClienteTelefone.Clear();

			txt_CarroCod.Clear();
			txt_CarroMarca.Clear();
			txt_CarroModelo.Clear();
			txt_CarroCor.Clear();
			txt_CarroAnoFab.Clear();
			txt_CarroAnoModelo.Clear();
			txt_CarroChassis.Clear();
			txt_CarroPlaca.Clear();

			txt_ApoliceValor.Clear();
			txt_ApoliceVigencia.Clear();
			txt_ApoliceFranquia.Clear();
			txt_ApoliceData.Clear();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			limparTodosCampos();
		}

		private void btn_ConsultarCorretor_Click(object sender, EventArgs e)
		{
			String sql = "SELECT * FROM corretor WHERE regi_corretor = @regi_corretor";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);
			
			cmd.Parameters.Add(new SqlParameter("@regi_corretor", txt_ConsultarCorretor.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					txt_CorretorCod.Text = dr["cod_corretor"].ToString();
					txt_CorretorNome.Text = dr["nome"].ToString();
					txt_EmpresaCod.Text = dr["cod_empresa"].ToString();
					txt_CorretorRegistro.Text = dr["regi_corretor"].ToString();
					txt_CorretorEndereco.Text = dr["endereco"].ToString();
					txt_CorretorTelefone.Text = dr["telefone"].ToString();
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

		private void btn_ConsultarCarro_Click(object sender, EventArgs e)
		{
			String sql = "SELECT * FROM carro car INNER JOIN cliente cli ON car.cod_cli = cli.cod_cli WHERE car.placa = @placa;";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@placa", txt_ConsultarCarro.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					txt_CarroCod.Text = dr["cod_car"].ToString();
					txt_CarroMarca.Text = dr["marca"].ToString();
					txt_CarroModelo.Text = dr["modelo"].ToString();
					txt_CarroCor.Text = dr["cor"].ToString();
					txt_CarroAnoFab.Text = dr["ano_fabricao"].ToString();
					txt_CarroAnoModelo.Text = dr["ano_modelo"].ToString();
					txt_CarroChassis.Text = dr["chassi"].ToString();
					txt_CarroPlaca.Text = dr["placa"].ToString();
					txt_ClienteCod.Text = dr["cod_cli"].ToString();
					txt_ClienteNome.Text = dr["nome"].ToString();
					txt_ClienteCpf.Text = dr["cpf"].ToString();
					txt_ClienteDataNasc.Text = dr["data_nasc"].ToString();
					txt_ClienteEndereco.Text = dr["endereco"].ToString();
					txt_ClienteTelefone.Text = dr["telefone"].ToString();
				}
				else
				{
					MessageBox.Show("Nenhum registro encontrado com a placa informada!");
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

		private void btn_Salvar_Click(object sender, EventArgs e)
		{
			if (txt_CorretorCod.Text != "" && txt_CarroCod.Text != "" && txt_ClienteCod.Text != "" && 
				txt_CarroModelo.Text != "" && txt_ApoliceValor.Text != "" && txt_ApoliceVigencia.Text != "" 
				&& txt_ApoliceFranquia.Text != "" && txt_ApoliceData.Text != "")
			{
				string sql = "INSERT INTO apolice(valor, vigencia, franquia, data, modelo, cod_corretor, cod_cli, cod_car) " +
					"VALUES(@valor, @vigencia, @franquia, @data, @modelo, @cod_corretor, @cod_cli, @cod_car)";
				SqlConnection conn = Conexao.obterConexao();
				SqlCommand cmd = new SqlCommand(sql, conn);

				cmd.Parameters.Add(new SqlParameter("@valor", float.Parse(txt_ApoliceValor.Text)));
				cmd.Parameters.Add(new SqlParameter("@vigencia", txt_ApoliceVigencia.Text));
				cmd.Parameters.Add(new SqlParameter("@franquia", float.Parse(txt_ApoliceFranquia.Text)));
				cmd.Parameters.Add(new SqlParameter("@data", txt_ApoliceData.Text));
				cmd.Parameters.Add(new SqlParameter("@modelo", txt_CarroModelo.Text));
				cmd.Parameters.Add(new SqlParameter("@cod_corretor", int.Parse(txt_CorretorCod.Text)));
				cmd.Parameters.Add(new SqlParameter("@cod_cli", int.Parse(txt_ClienteCod.Text)));
				cmd.Parameters.Add(new SqlParameter("@cod_car", int.Parse(txt_CarroCod.Text)));

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
			else
				MessageBox.Show("Informe todos os campos!");
		}

		private void txt_CarroMarca_MouseClick(object sender, MouseEventArgs e)
		{
			String sql = "SELECT * FROM carro car INNER JOIN cliente cli ON car.cod_cli = cli.cod_cli WHERE car.placa = @placa;";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@placa", txt_ConsultarCarro.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();
			try
			{
				if (dr.Read())
				{
					txt_CarroCod.Text = dr["cod_car"].ToString();
					txt_CarroMarca.Text = dr["marca"].ToString();
					txt_CarroModelo.Text = dr["modelo"].ToString();
					txt_CarroCor.Text = dr["cor"].ToString();
					txt_CarroAnoFab.Text = dr["ano_fabricao"].ToString();
					txt_CarroAnoModelo.Text = dr["ano_modelo"].ToString();
					txt_CarroChassis.Text = dr["chassi"].ToString();
					txt_CarroPlaca.Text = dr["placa"].ToString();
					txt_ClienteCod.Text = dr["cod_cli"].ToString();
					txt_ClienteNome.Text = dr["nome_cli"].ToString();
					txt_ClienteCpf.Text = dr["cpf"].ToString();
					txt_ClienteDataNasc.Text = dr["data_nasc"].ToString();
					txt_ClienteEndereco.Text = dr["endereco_cli"].ToString();
					txt_ClienteTelefone.Text = dr["telefone_cli"].ToString();
				}
				else
				{
					MessageBox.Show("Nenhum registro encontrado com a placa informada!");
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

		private void txt_CorretorNome_MouseClick(object sender, MouseEventArgs e)
		{
			String sql = "SELECT * FROM corretor WHERE regi_corretor = @regi_corretor";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.Add(new SqlParameter("@regi_corretor", txt_ConsultarCorretor.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					txt_CorretorCod.Text = dr["cod_corretor"].ToString();
					txt_CorretorNome.Text = dr["nome"].ToString();
					txt_EmpresaCod.Text = dr["cod_empresa"].ToString();
					txt_CorretorRegistro.Text = dr["regi_corretor"].ToString();
					txt_CorretorEndereco.Text = dr["endereco"].ToString();
					txt_CorretorTelefone.Text = dr["telefone"].ToString();
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
