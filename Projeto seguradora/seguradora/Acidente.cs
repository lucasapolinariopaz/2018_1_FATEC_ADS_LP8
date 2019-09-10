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
    public partial class Acidente : Form
    {          // string strconn= "Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\seguradora\\seguradora.mdf;Integrated Security = True; User Instance = True";

        public Acidente()
        {
            InitializeComponent();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(strconn);
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("select * from carro where placa= '"+txtplaca.Text+ "';", conn);
            comm.CommandType = CommandType.Text; 
            comm.Parameters.Add(new SqlParameter("@modelo", "modelo"));
            comm.Parameters.Add(new SqlParameter("@marca", "marca"));
            comm.Parameters.Add(new SqlParameter("@ano_modelo", "ano_modelo"));
            comm.Parameters.Add(new SqlParameter("@ano_fabricao", "ano_fabricao"));
            comm.Parameters.Add(new SqlParameter("@cod_car", "cod_car"));


            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtmodelo.Text = dr["modelo"].ToString();
                txtmarca.Text = dr["marca"].ToString();
                txtanomodelo.Text = dr["ano_modelo"].ToString();
                txtfabricao.Text = dr["ano_fabricao"].ToString();
                txtchassi.Text = dr["cod_car"].ToString();

            }
            conn.Close();
            txtdata.Enabled = true;
            txthora.Enabled = true;
            txtlocal.Enabled = true;
            txtdescricao.Enabled = true;
            btnsalvar.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO acidente (cod_carro,local,data,hora,descricao) "
    + "VALUES ('" + txtchassi.Text +   "', '" + txtlocal.Text + "', '" + txtdata.Text + "', '" + txthora.Text + "', '" + txtdescricao+ "')";

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
