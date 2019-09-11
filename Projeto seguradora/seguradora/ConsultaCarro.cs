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
	public partial class ConsultaCarro : Form
	{
		public ConsultaCarro()
		{
			InitializeComponent();
		}

		public void limparTodosCampos()
		{
			txt_nomeCliente.Clear();
			txt_nascCliente.Clear();
			txt_telefoneCliente.Clear();
			txt_enderecoCliente.Clear();
			txt_marcaCarro.Clear();
			txt_modeloCarro.Clear();
			txt_anoFabCarro.Clear();
			txt_anoModCarro.Clear();
			txt_placaCarro.Clear();
			txt_corCarro.Clear();
			txt_chassiCarro.Clear();
			txt_CodCarro.Clear();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_consultaPlaca_Click(object sender, EventArgs e)
		{
			String sql = "SELECT cli.nome, cli.cpf, cli.data_nasc, " +
				"cli.telefone, cli.endereco, car.marca, car.modelo, car.ano_fabricao, " +
				"car.ano_modelo, car.placa, car.cor, car.chassi, car.cod_car FROM " +
				"cliente cli INNER JOIN carro car ON cli.cod_cli = car.cod_cli WHERE " +
				"car.placa = @pesquisa_placa;";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);
			
			cmd.Parameters.Add(new SqlParameter("@pesquisa_placa", txt_consultaPlaca.Text));

			cmd.CommandType = CommandType.Text;
			Conexao.obterConexao();
			DbDataReader dr = cmd.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    txt_nomeCliente.Text = dr["nome"].ToString();
					txt_cpfCliente.Text = dr["cpf"].ToString();
                    txt_nascCliente.Text = dr["data_nasc"].ToString();
                    txt_telefoneCliente.Text = dr["telefone"].ToString();
                    txt_enderecoCliente.Text = dr["endereco"].ToString();
                    txt_marcaCarro.Text = dr["marca"].ToString();
                    txt_modeloCarro.Text = dr["modelo"].ToString();
                    txt_anoFabCarro.Text = dr["ano_fabricao"].ToString();
                    txt_anoModCarro.Text = dr["ano_modelo"].ToString();
                    txt_placaCarro.Text = dr["placa"].ToString();
                    txt_corCarro.Text = dr["cor"].ToString();
                    txt_chassiCarro.Text = dr["chassi"].ToString();
					txt_CodCarro.Text = dr["cod_car"].ToString();
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

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			limparTodosCampos();
		}

		private void btn_Alterar_Click(object sender, EventArgs e)
		{
			string sql = "UPDATE carro SET marca = @marca, modelo = @modelo, " +
				"ano_fabricao = @ano_fabricao, ano_modelo = @ano_modelo, placa = @placa, " +
				"cor = @cor, chassi = @chassi WHERE cod_car = @cod_car";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand comm = new SqlCommand(sql, conn);

			comm.Parameters.Add(new SqlParameter("@marca", txt_marcaCarro.Text));
			comm.Parameters.Add(new SqlParameter("@modelo", txt_modeloCarro.Text));
			comm.Parameters.Add(new SqlParameter("@ano_fabricao", int.Parse(txt_anoFabCarro.Text)));
			comm.Parameters.Add(new SqlParameter("@ano_modelo", int.Parse(txt_anoModCarro.Text)));
			comm.Parameters.Add(new SqlParameter("@placa", txt_placaCarro.Text));
			comm.Parameters.Add(new SqlParameter("@cor", txt_corCarro.Text));
			comm.Parameters.Add(new SqlParameter("@chassi", txt_chassiCarro.Text));
			comm.Parameters.Add(new SqlParameter("@cod_car", int.Parse(txt_CodCarro.Text)));

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

		private void btn_Excluir_Click(object sender, EventArgs e)
		{
			string sql = "DELETE FROM carro WHERE cod_car = @cod_car";
			SqlConnection conn = Conexao.obterConexao();
			SqlCommand cmd = new SqlCommand(sql, conn);

			cmd.Parameters.AddWithValue("@cod_car", txt_CodCarro.Text);

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

			limparTodosCampos();
		}
	}
}
