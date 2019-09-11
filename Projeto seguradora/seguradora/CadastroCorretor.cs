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
        int campos = 0;
        public CadastroCorretor()
        {

            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string[] texts = new string[6];
            texts[0] = txtcorretor.Text;
            texts[1] = txtendereco.Text;
            texts[2] = txttelefone.Text;
            texts[3] = lblempresa.Text;
            texts[4] = txtregistro.Text;
            texts[5] = txtsenha.Text;

            for (int i = 0; i < texts.Length; i++)
            {

                if (texts[i] == string.Empty)
                {
                    campos = campos - 1;

                }

                else { campos++; }

            }
           // MessageBox.Show("qnt " + campos);
            if (campos < 6)
            {
               
                MessageBox.Show("É necessário preencher Todos Campos ");
            }

            else
            {

                string sql = "INSERT INTO corretor (nome, endereco, telefone, regi_corretor," +
                "senha, cod_empresa)" + " VALUES ('" +
                txtcorretor.Text + "', '" + txtendereco.Text + "', '" +
                txttelefone.Text + "', '" + txtregistro.Text + "', '" +
                 txtsenha.Text + "', " + int.Parse(lblempresa.Text) + ")";

                SqlConnection conn = Conexao.obterConexao();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                Conexao.obterConexao();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    txtcorretor.Clear();
                    txttelefone.Clear();
                    txtregistro.Clear();
                    txtsenha.Clear();
                    txtendereco.Clear();
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcorretor.Clear();
            txttelefone.Clear();
            txtregistro.Clear();
            txtsenha.Clear();
            txtendereco.Clear();


        }
    }
}
