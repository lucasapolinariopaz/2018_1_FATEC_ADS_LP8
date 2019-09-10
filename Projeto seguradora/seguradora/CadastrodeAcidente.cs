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
    public partial class CadastrodeAcidente : Form
    {
        int fk_acicarro;
        public CadastrodeAcidente()
        {
            InitializeComponent();
        }

       

        private void txtchassi_MouseClick(object sender, MouseEventArgs e)
        {
            string m = txtplaca.Text.ToUpper();
            txtplaca.Text = m;
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("SELECT *from carro WHERE " +
                "placa = '" +txtplaca.Text + "';", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@marca", "marca"));
            comm.Parameters.Add(new SqlParameter("@modelo", "modelo"));
            comm.Parameters.Add(new SqlParameter("@ano_fabricao", "ano_fabricao"));
            comm.Parameters.Add(new SqlParameter("@ano_modelo", "ano_modelo"));
            comm.Parameters.Add(new SqlParameter("@placa", "placa"));
            comm.Parameters.Add(new SqlParameter("@cor", "cor"));
            comm.Parameters.Add(new SqlParameter("@chassi", "chassi"));
            comm.Parameters.Add(new SqlParameter("@cod_car", "cod_car"));

            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                
                txtmarca.Text = dr["marca"].ToString();
                txtmodelo.Text = dr["modelo"].ToString();
                txtfabricao.Text = dr["ano_fabricao"].ToString();
                txtanom.Text = dr["ano_modelo"].ToString();
                txtplaca.Text = dr["placa"].ToString();
                txtcor.Text = dr["cor"].ToString();
                txtchassi.Text = dr["chassi"].ToString();
                 fk_acicarro =int.Parse(dr["cod_car"].ToString());
                
            }
            Conexao.fecharConexao();
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
           
            string sql = "INSERT INTO acidente (descricao, local, data, hora, cod_carro ) VALUES ( @descricao,@local,@data,@hora,@fk_acicarro)";
            // SqlConnection con = new SqlConnection(strconn);
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@descricao", txtdescricao.Text));
            cmd.Parameters.Add(new SqlParameter("@local", txtlocal.Text));
            cmd.Parameters.Add(new SqlParameter("@data", txtdata.Text));
            cmd.Parameters.Add(new SqlParameter("@hora", txthora.Text));
            cmd.Parameters.Add(new SqlParameter("@fk_acicarro", fk_acicarro));
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
        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }
    }
}
