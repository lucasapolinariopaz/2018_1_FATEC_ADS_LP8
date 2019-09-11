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
    public partial class Cadastro_de_cliente : Form
    {
        public Cadastro_de_cliente()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
         
            string sql = "INSERT INTO cliente (nome, data_nasc, telefone, endereco, cpf)  VALUES ( @nome,@data_nasc,@endereco,@telefone,@cpf)"; 
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@nome", txt_nomeCliente.Text));
            cmd.Parameters.Add(new SqlParameter("@data_nasc", txt_nascCliente.Text));
            cmd.Parameters.Add(new SqlParameter("@endereco", txt_enderecoCliente.Text));
            cmd.Parameters.Add(new SqlParameter("@telefone", txt_telefoneCliente.Text));
			cmd.Parameters.Add(new SqlParameter("@cpf", txtcpf.Text));
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

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			txt_nomeCliente.Clear();
			txtcpf.Clear();
			txt_nascCliente.Clear();
			txt_enderecoCliente.Clear();
			txt_telefoneCliente.Clear();
		}
	}
    
}
