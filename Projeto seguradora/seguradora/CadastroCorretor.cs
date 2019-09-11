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
    public partial class CadastroCorretor : Form
    {
        int fk_corretor_empresa;
        public CadastroCorretor()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO corretor (nome, endereco, telefone, cod_empresa, regi_corretor," +
                "senha)" + " VALUES ('" +
                txtcorretor.Text + "', '" + txtendereco.Text + "', '" +
                txttelefone.Text + "', '" + int.Parse(txtcodempresa.Text) + "', " +
                txtregistro.Text + ", " + txtsenha.Text + fk_corretor_empresa+")";

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

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
